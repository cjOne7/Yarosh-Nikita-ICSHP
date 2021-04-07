using System;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class ResultsForm : Form {
      private readonly StartMenu _startMenu;
      private const string PracticeScoreFilepath = "../../../Your relults.txt";
      private const string PvPScorePath = "../../../PvP.csv";
      

      private ResultsForm() {
         InitializeComponent();
         GameTypeChooser.DataSource = Enum.GetValues(typeof(GameType));
         
      }

      public ResultsForm(StartMenu startMenu) : this() {
         _startMenu = startMenu;
      }

      private void ResultsForm_FormClosing(object sender, FormClosingEventArgs e) {
         _startMenu.Show();
      }
   }
}