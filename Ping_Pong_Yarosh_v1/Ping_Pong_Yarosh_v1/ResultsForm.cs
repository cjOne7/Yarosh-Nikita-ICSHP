using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class ResultsForm : Form {
      private readonly StartMenu _startMenu;
      private readonly LinkedList<SelfPractice> _selfPractices = new LinkedList<SelfPractice>();
      private readonly LinkedList<SelfPractice> _destroyBlocks = new LinkedList<SelfPractice>();
      private readonly LinkedList<PvPGame> _pvPGames = new LinkedList<PvPGame>();

      private ResultsForm() {
         InitializeComponent();
         // GameTypeChooser.DataSource = Enum.GetValues(typeof(GameType));
         GameTypeChooser.Items.AddRange(Enum.GetNames(typeof(GameType)));
         ParsePractices(Files.PracticeScoreFilepath, _selfPractices);
         ParsePractices(Files.DestroyBlocksFilePath, _destroyBlocks);
         ParsePvP();
      }

      private void ParsePractices(string filepath, LinkedList<SelfPractice> list) {
         var practiceScores = File.ReadAllLines(filepath);
         for (var i = 1; i < practiceScores.Length; i++){
            var splittedRow = practiceScores[i].Split(';');
            var id = int.Parse(splittedRow[0]);
            var score = int.Parse(splittedRow[1]);
            var dateTime = DateTime.Parse(splittedRow[2]);
            var practice = new SelfPractice(id, score, dateTime);
            list.Add(practice);
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

      private static string GetListAsString<T>(IList<T> list) {
         var builder = new StringBuilder();
         for (var i = list.Count - 1; i >= 0; i--){
            builder.Append(list[i]).Append("\r\n");
         }

         return builder.ToString();
      }

      private void GameTypeChooser_SelectedIndexChanged(object sender, EventArgs e) {
         if (GameTypeChooser.Text == GameType.PvP.ToString()){
            ResultsBoardTextBox.Text = GetListAsString(_pvPGames);
            BestScoreLable.Text = "";
         }
         else if (GameTypeChooser.Text == GameType.Practice.ToString()){
            ResultsBoardTextBox.Text = GetListAsString(_selfPractices);
            BestScoreLable.Text = GetBestScore();
         }
         else if (GameTypeChooser.Text == GameType.DestroyBlocks.ToString()){
            ResultsBoardTextBox.Text = GetListAsString(_destroyBlocks);
            BestScoreLable.Text = "";
         }
      }

      private string GetBestScore() {
         var max = _selfPractices.Select(practice => practice.Score).Max();
         return $"Your best score is {max}.";
      }
   }
}