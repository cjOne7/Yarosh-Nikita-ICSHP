using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void startNewGame_Click(object sender, EventArgs e) {
         var enterPlayersNames = new EnterPlayersNames();
         enterPlayersNames.Show();
      }

      private void exit_Click(object sender, EventArgs e) {
         Close();
      }
   }
}