using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv4 {
   public partial class Form1 : Form {
      private readonly Random _random = new Random();
      private Stats _stats = new Stats();

      public Form1() {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e) {
         gameListBox.Items.Clear();
         gameListBox.Refresh();
         correctLabel.Text = @"Correct: 0";
         missedLabel.Text = @"Missed: 0";
         accurancyLabel.Text = @"Accuracy: 0%";
         difficultProgressBar.Value = 0;
         timer1.Interval = 800;
         _stats = new Stats();
         timer1.Start();
      }

      private void ExitBtn_Click(object sender, EventArgs e) {
         Application.Exit();
      }

      private void gameListBox_KeyDown(object sender, KeyEventArgs e) {
         if (gameListBox.Items.Contains(e.KeyCode)){
            gameListBox.Items.Remove(e.KeyCode);
            gameListBox.Refresh();
            UpdateTimerTimeInterval();
            _stats.Update(true);
         }
         else{
            _stats.Update(false);
         }

         correctLabel.Text = $@"Correct: {_stats.Correct}";
         missedLabel.Text = $@"Missed: {_stats.Missed}";
         accurancyLabel.Text = $@"Accuracy: {_stats.Accuracy}%";
      }

      private void UpdateTimerTimeInterval() {
         var decrement = 0;
         if (timer1.Interval > 400){
            decrement = 60;
         }
         else if (timer1.Interval > 250){
            decrement = 15;
         }
         else if (timer1.Interval > 150){
            decrement = 8;
         }

         timer1.Interval -= decrement;
         if (difficultProgressBar.Value < 800){
            difficultProgressBar.Value += decrement;
         }
      }

      private void timer1_Tick(object sender, EventArgs e) {
         gameListBox.Items.Add((Keys) _random.Next('A', 'A' + 26));
         if (gameListBox.Items.Count > 5){
            timer1.Stop();
            gameListBox.Items.Clear();
            gameListBox.Refresh();
            gameListBox.Items.Add("Game over");
         }
      }
   }
}