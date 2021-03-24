using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cv5 {
   public partial class Form2 : Form {
      private Form1 f;
      public Form2() {
         InitializeComponent();
         ClubComboBox.DataSource = Enum.GetValues(typeof(FootballClub));
      }

      public Form2(Form1 f) {
         this.f = f;
         InitializeComponent();
         ClubComboBox.DataSource = Enum.GetValues(typeof(FootballClub));
      }

      private void ConfirmBtn_Click(object sender, EventArgs e) {
         var name = NameTextBox.Text;
         var club = (FootballClub) Enum.Parse(typeof(FootballClub), ClubComboBox.Text);
         var goals = int.Parse(GoalsTextBox.Text);
         var gamer = new Gamer(name, club, goals);
         var item = new ListViewItem();
         f.Gamers.Add(gamer);
         item.SubItems.Add(gamer.ToString());
         f.PlayersListView.Items.Add(item);
         Close();
      }

      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }
   }
}