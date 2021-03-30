using System;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class EnterPlayersNames : Form {
      private StartMenu _startMenu;
      public EnterPlayersNames() {
         InitializeComponent();
      }

      private void ConfirmBtn_Click(object sender, EventArgs e) {
         var playerName1 = PlayersName1.Text.Trim();
         var playerName2 = PlayersName2.Text.Trim();
         if (string.IsNullOrEmpty(playerName1) || string.IsNullOrEmpty(playerName2)){
            ErrorMessLabel.Text = "Both fields must be filled";
         }
         else{
            var gameField = new GameField(playerName1, playerName2);
            gameField.Show();
         }
      }
      
      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }
   }
}