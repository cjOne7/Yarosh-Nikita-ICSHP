using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Exercise04 {
    public partial class GameForm : Form {
        private readonly Random _random = new Random();
        private Stats _stats = new Stats();

        public GameForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void timer1_Tick(object sender, EventArgs e) {
            gameListBox.Items.Add((Keys) _random.Next(65, 90));
            if (gameListBox.Items.Count > 6) {
                timer1.Stop();
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over!");
            }
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e) {
            if (gameListBox.Items.Contains(e.KeyCode)) {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();
                DecrementTimerInterval();
                _stats.Update(true);
            }
            else {
                _stats.Update(false);
            }

            correctLabel.Text = $@"Correct: {_stats.Correct}";
            missedLabel.Text = $@"Missed: {_stats.Missed}";
            accuracyLabel.Text = $@"Accuracy: {_stats.Accuracy}%";
        }

        private void DecrementTimerInterval() {
            var increment = 0;
            if (timer1.Interval > 400) {
                increment = 60;
            }
            else if (timer1.Interval > 250) {
                increment = 15;
            }
            else if (timer1.Interval > 150) {
                increment = 8;
            }

            timer1.Interval -= increment;
            if (progressBar.Value < 760) {
                progressBar.Value += increment;
            }
        }

        private void newGameMenu_Click(object sender, EventArgs e) {
            gameListBox.Items.Clear();
            gameListBox.Refresh();
            correctLabel.Text = @"Correct: 0";
            missedLabel.Text = @"Missed: 0";
            accuracyLabel.Text = @"Accuracy: 0%";
            progressBar.Value = 0;
            timer1.Stop();
            timer1.Interval = 800;
            _stats = new Stats();
            timer1.Start();
        }

        private void exitMenu_Click(object sender, EventArgs e) {
            Close();
        }
    }
}