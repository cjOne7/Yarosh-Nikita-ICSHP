using System;
using System.Drawing;
using System.Windows.Forms;
namespace Ping_Pong_Yarosh_v1 {
   public partial class OptionsForm : Form {
      public OptionsForm() {
         InitializeComponent();
      }

      private void ConfirmBtn_Click(object sender, EventArgs e) {
         
      }

      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }

      private void MouseRadioBtn_CheckedChanged(object sender, EventArgs e) {
         MovingLeftTextBox.Enabled = false;
         MovingRightTextBox.Enabled = false;
      }

      private void KeyboardRadioBtn_CheckedChanged(object sender, EventArgs e) {
         MovingLeftTextBox.Enabled = true;
         MovingRightTextBox.Enabled = true;
         
      }
   }
}