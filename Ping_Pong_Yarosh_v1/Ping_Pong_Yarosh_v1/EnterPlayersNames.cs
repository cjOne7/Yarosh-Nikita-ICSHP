using System;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class EnterPlayersNames : Form {
      private readonly StartMenu _startMenu;
      public EnterPlayersNames() {
         InitializeComponent();
      }

      public EnterPlayersNames(StartMenu startMenu) : this() {
         _startMenu = startMenu;
      }

      private void ConfirmBtn_Click(object sender, EventArgs e) {
         var playerName1 = PlayersName1.Text.Trim();
         var playerName2 = PlayersName2.Text.Trim();
         if (string.IsNullOrEmpty(playerName1) || string.IsNullOrEmpty(playerName2)){
            ErrorMessLabel.Text = "Both fields must be filled";
         }
         else{
            // var gameField = new PracticeGameField(playerName1, playerName2, _startMenu);
            // _startMenu.Hide();
            // Close();
            // gameField.Show();
         }
      }
      
      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }
   }
}