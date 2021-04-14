using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cv7 {
   ///source http://netghost.narod.ru/gff/graphics/summary/pcx.htm
   public partial class Form1 : Form {
      private int _imageWidth;
      private int _imageHeight;
      private int _numBitPlanes;
      private int _scanLineLength;
      private BinaryReader _binaryReader;

      public Form1() {
         InitializeComponent();
      }

      private void LoadImageBtn_Click(object sender, EventArgs e) {
         using (var openFileDialog = new OpenFileDialog {
            Title = @"Choose PCX file", Filter = @"PCX Images (*.pcx)|*.pcx"
         }){
            if (openFileDialog.ShowDialog() == DialogResult.OK){
               _binaryReader = new BinaryReader(openFileDialog.OpenFile());
               ReadPcxHeader();
               var bitmap = new Bitmap(_imageWidth, _imageHeight);
               for (var j = 0; j < _imageHeight; j++){
                  var bytes = DecodePcxScanLine();
                  SetPixels(bytes, bitmap, j);
               }

               PCXImage.Width = bitmap.Width;
               PCXImage.Height = bitmap.Height;
               PCXImage.Image = bitmap;
            }
         }

         _binaryReader.Close();
      }

      private void ReadPcxHeader() {
         //skip Identifier, Version, Encoding, BitsPerPixel
         SkipBytes(1, 1, 1, 1);

         var xStart = _binaryReader.ReadUInt16();
         var yStart = _binaryReader.ReadUInt16();
         var xEnd = _binaryReader.ReadUInt16();
         var yEnd = _binaryReader.ReadUInt16();

         _imageWidth = xEnd - xStart + 1; // Width of image in pixels
         _imageHeight = yEnd - yStart + 1; // Length of image in scan lines

         //skip HorzRes, VertRes, Palette[48], Reserved1
         SkipBytes(2, 2, 48, 1);
         _numBitPlanes = _binaryReader.ReadByte();
         var bytesPerLine = _binaryReader.ReadUInt16();

         _scanLineLength = _numBitPlanes * bytesPerLine;

         //skip PaletteType, HorzScreenSize, VertScreenSize, Reserved2[54]
         SkipBytes(2, 2, 2, 54);
      }

      private void SkipBytes(params int[] bytes) {
         _binaryReader.BaseStream.Seek(bytes.Sum(), SeekOrigin.Current);
      }

      private byte[] DecodePcxScanLine() {
         // var index = 0;
         // var buffer = new byte[_scanLineLength];
         // while (index < _scanLineLength){
         //    var b = _binaryReader.ReadByte();
         //    int runCount;
         //    byte runValue;
         //    if ((b & 0xC0) == 0xC0){
         //       runCount = b & 0x3F;
         //       runValue = _binaryReader.ReadByte();
         //    }
         //    else{
         //       runCount = 1;
         //       runValue = b;
         //    }
         //
         //    while (runCount > 0 && index < _scanLineLength){
         //       buffer[index++] = runValue;
         //       runCount--;
         //    }
         // }
         //
         // return buffer;

         var index = 0;
         var buffer = new byte[_scanLineLength];
         do{
            var b = _binaryReader.ReadByte();
            int runCount;
            byte runValue;
            if ((b & 0xC0) == 0xC0){ /* 2-byte code */
               runCount = b & 0x3F; /* Get run count */
               runValue = _binaryReader.ReadByte(); /* Get pixel value */
            }
            else /* 1-byte code */{
               runCount = 1; /* Run count is one */
               runValue = b; /* Pixel value */
            }

            while (runCount-- != 0 && index < _scanLineLength){
               buffer[index++] = runValue;
            }
         } while (index < _scanLineLength);

         return buffer;
      }

      private void SetPixels(IReadOnlyList<byte> bytes, Bitmap bitmap, int j) {
         if (_numBitPlanes == 1){
            for (var i = 0; i < _scanLineLength - 1; i++){
               var b = bytes[i];
               var pos = _binaryReader.BaseStream.Position;
               _binaryReader.BaseStream.Seek(-768, SeekOrigin.End);
               _binaryReader.BaseStream.Seek(b * 3, SeekOrigin.Current);
               var color = Color.FromArgb(
                  _binaryReader.ReadByte(), _binaryReader.ReadByte(), _binaryReader.ReadByte());
               _binaryReader.BaseStream.Position = pos;
               bitmap.SetPixel(i, j, color);
            }
         }
         else{
            for (var i = 0; i < (_scanLineLength - 1) / 3; i++){
               var color = Color.FromArgb(bytes[i]
                  , bytes[(_scanLineLength / 3) + i]
                  , bytes[(_scanLineLength / 3) * 2 + i]);
               bitmap.SetPixel(i, j, color);
            }
         }
      }
   }
}