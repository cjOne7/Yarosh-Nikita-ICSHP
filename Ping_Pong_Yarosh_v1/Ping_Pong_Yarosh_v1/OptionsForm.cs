using System;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class OptionsForm : Form {
      private readonly Options _options;

      public OptionsForm() {
         InitializeComponent();
         var input = File.ReadAllText(Files.OptionsFilePath);
         _options = JsonSerializer.Deserialize<Options>(input);
         if (_options.IsMouse == _options.IsKeyboard){
            throw new ArgumentException("You can't use mouse and keyboard simultaneously.");
         }

         MouseRadioBtn.Checked = _options.IsMouse;
         if (MouseRadioBtn.Checked){
            MovingLeftTextBox.Enabled = MovingRightTextBox.Enabled = false;
         }

         KeyboardRadioBtn.Checked = _options.IsKeyboard;
         MovingLeftTextBox.Text = _options.KeyboardControl.Left;
         MovingRightTextBox.Text = _options.KeyboardControl.Right;
      }

      private void ConfirmBtn_Click(object sender, EventArgs e) {
         const string mess = "Are you sure?";
         const string caption = "Changing control options";
         var result = MessageBox.Show(mess, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
         if (result == DialogResult.OK){
            _options.IsMouse = MouseRadioBtn.Checked;
            _options.IsKeyboard = KeyboardRadioBtn.Checked;
            _options.KeyboardControl.Left = MovingLeftTextBox.Text;
            _options.KeyboardControl.Right = MovingRightTextBox.Text;
            var json = JsonSerializer.Serialize(_options);
            File.WriteAllText(Files.OptionsFilePath, json);
            Close();
         }
      }

      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }

      private void MouseRadioBtn_CheckedChanged(object sender, EventArgs e) {
         MovingLeftTextBox.Enabled = MovingRightTextBox.Enabled = false;
      }

      private void KeyboardRadioBtn_CheckedChanged(object sender, EventArgs e) {
         MovingLeftTextBox.Enabled = MovingRightTextBox.Enabled = true;
      }
   }
}