using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class StartMenu : Form {
      private static readonly SoundPlayer Player = new SoundPlayer(Files.ClickSound);

      public StartMenu() {
         InitializeComponent();
      }

      private void startNewGame_Click(object sender, EventArgs e) {
         Player.Play();
         var practiceGameField = new PracticeGameField(this);
         practiceGameField.Show();
         Hide();
      }

      private void exit_Click(object sender, EventArgs e) {
         Player.Play();
         Close();
      }

      private void PvsPBtn_Click(object sender, EventArgs e) {
         Player.Play();
         var enterPlayersNames = new EnterPlayersNames(this);
         enterPlayersNames.Show();
      }

      private void DestroyBlocksBtn_Click(object sender, EventArgs e) {
         Player.Play();
         var destroyBlocksForm = new DestroyBlocksForm(this);
         destroyBlocksForm.Show();
         Hide();
      }

      private void OptionsBtn_Click(object sender, EventArgs e) {
         Player.Play();
         var optionsForm = new OptionsForm();
         optionsForm.Show();
      }

      private void ResultsBoardBtn_Click(object sender, EventArgs e) {
         Player.Play();
         var form = new ResultsForm(this);
         form.Show();
         Hide();
      }
   }
}