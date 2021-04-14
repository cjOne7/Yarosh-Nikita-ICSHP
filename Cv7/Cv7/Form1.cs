using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cv7 {
   ///source http://netghost.narod.ru/gff/graphics/summary/pcx.htm
   public partial class Form1 : Form {
      private const int HeaderLength = 128;

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
               // var bitmap = LoadPCX(fileName);
               // PCXImage.Width = bitmap.Width;
               // PCXImage.Height = bitmap.Height;
               // PCXImage.Image = bitmap;
            }
         }

         _binaryReader.Close();
      }

      private Bitmap LoadPCX() {
         return null;
      }

      /// <summary>
      /// The first 128 bytes of every PCX file is the header, which has the following format:
      /// typedef struct _PcxHeader
      /// {
      ///   BYTE  Identifier;        /* PCX Id Number (Always 0x0A) */
      ///   BYTE  Version;           /* Version Number */
      ///   BYTE  Encoding;          /* Encoding Format */
      ///   BYTE  BitsPerPixel;      /* Bits per Pixel */
      ///   WORD  XStart;            /* Left of image */
      ///   WORD  YStart;            /* Top of Image */
      ///   WORD  XEnd;              /* Right of Image
      ///   WORD  YEnd;              /* Bottom of image */
      ///   WORD  HorzRes;           /* Horizontal Resolution */
      ///   WORD  VertRes;           /* Vertical Resolution */
      ///   BYTE  Palette[48];       /* 16-Color EGA Palette */
      ///   BYTE  Reserved1;         /* Reserved (Always 0) */
      ///   BYTE  NumBitPlanes;      /* Number of Bit Planes */
      ///   WORD  BytesPerLine;      /* Bytes per Scan-line */
      ///   WORD  PaletteType;       /* Palette Type */
      ///   WORD  HorzScreenSize;    /* Horizontal Screen Size */
      ///   WORD  VertScreenSize;    /* Vertical Screen Size */
      ///   BYTE  Reserved2[54];     /* Reserved (Always 0) */
      ///   } PCXHEAD;
      ///   Total: 1+1+1+1+2+2+2+2+2+2+48+1+1+2+2+2+2+54 = 128
      /// </summary>
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
   }
}