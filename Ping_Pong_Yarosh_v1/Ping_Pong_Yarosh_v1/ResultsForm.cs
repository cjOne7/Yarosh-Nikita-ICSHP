using System;
using System.IO;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class ResultsForm : Form {
      private readonly StartMenu _startMenu;
      private readonly LinkedList<SelfPractice> _selfPractices = new LinkedList<SelfPractice>();
      private readonly LinkedList<PvPGame> _pvPGames = new LinkedList<PvPGame>();

      private ResultsForm() {
         InitializeComponent();
         GameTypeChooser.DataSource = Enum.GetValues(typeof(GameType));
         ParsePractices();
         ParsePvP();
      }

      private void ParsePractices() {
         var practiceScores = File.ReadAllLines(Files.PracticeScoreFilepath);
         for (var i = 1; i < practiceScores.Length; i++){
            var splittedRow = practiceScores[i].Split(';');
            var id = int.Parse(splittedRow[0]);
            var score = int.Parse(splittedRow[1]);
            var dateTime = DateTime.Parse(splittedRow[2]);
            var practice = new SelfPractice(id, score, dateTime);
            _selfPractices.Add(practice);
         }
      }

      private void ParsePvP() {
         var practiceScores = File.ReadAllLines(Files.PvPScorePath);
         for (var i = 1; i < practiceScores.Length; i++){
            var splittedRow = practiceScores[i].Split(';');
            var id = int.Parse(splittedRow[0]);
            var player1 = splittedRow[1];
            var player2 = splittedRow[2];
            var winner = splittedRow[3];
            var dateTime = DateTime.Parse(splittedRow[4]);
            var pvPGame = new PvPGame(id, player1, player2, winner, dateTime);
            _pvPGames.Add(pvPGame);
         }
      }

      public ResultsForm(StartMenu startMenu) : this() {
         _startMenu = startMenu;
      }

      private void ResultsForm_FormClosing(object sender, FormClosingEventArgs e) {
         _startMenu.Show();
      }
   }
}