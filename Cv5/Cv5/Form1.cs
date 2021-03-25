using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv5 {
   public partial class Form1 : Form {
      public Gamers Gamers { get; }

      private Form2 form2;

      public bool IsChange { get; set; } = false;

      public Form1() {
         Gamers = new Gamers(10);
         InitializeComponent();

         var gamer = new Gamer("Ronaldo", FootballClub.RealMadrid, 10);
         var gamer1 = new Gamer("Ronaldo1", FootballClub.RealMadrid, 10);
         var gamer2 = new Gamer("Ronaldo2", FootballClub.RealMadrid, 10);
         Gamers.Add(gamer);
         Gamers.Add(gamer1);
         Gamers.Add(gamer2);
         var item = new ListViewItem(
            new[] {"Ronaldo", FootballClubInfo.GetName(FootballClub.RealMadrid), 10.ToString()});
         PlayersListView.Items.Add(item);
         var item1 = new ListViewItem(new[]
            {"Ronaldo1", FootballClubInfo.GetName(FootballClub.RealMadrid), 10.ToString()});
         PlayersListView.Items.Add(item1);
         var item2 = new ListViewItem(new[]
            {"Ronaldo2", FootballClubInfo.GetName(FootballClub.RealMadrid), 10.ToString()});
         PlayersListView.Items.Add(item2);
      }

      private void AddBtn_Click(object sender, EventArgs e) {
         form2 = new Form2(this);
         form2.ShowDialog();
      }

      private void CloseBtn_Click(object sender, EventArgs e) {
         Close();
      }

      private void DeleteBtn_Click(object sender, EventArgs e) {
         PlayersListView.Items.RemoveAt(PlayersListView.SelectedIndices[0]);
      }

      private void ChangeBtn_Click(object sender, EventArgs e) {
         var gamer = new Gamer {
            Name = PlayersListView.SelectedItems[0].SubItems[0].Text
            , Club = (FootballClub) Enum.Parse(typeof(FootballClub), PlayersListView.SelectedItems[0].SubItems[1].Text)
            , GoalsNumber = int.Parse(PlayersListView.SelectedItems[0].SubItems[2].Text)
         };
         IsChange = true;
         form2 = new Form2(this, gamer);
         form2.Show();
      }

      private void RegisterBtn_Click(object sender, EventArgs e) {
         Gamers.NumberChanged += NoticeChanges;
      }

      private void NoticeChanges(int number) {
         MessageTextBox.Text = number < Gamers.Capacity ? "Player was added\n" : "Player wasn't added\n";
      }

      private void CancelRegistrationBtn_Click(object sender, EventArgs e) {
         Gamers.NumberChanged -= NoticeChanges;
      }

      private void TheBestPlayerBtn_Click(object sender, EventArgs e) {
         
      }
   }
}