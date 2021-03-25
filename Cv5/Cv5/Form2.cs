using System;
using System.Windows.Forms;

namespace Cv5 {
   public partial class Form2 : Form {
      private readonly Form1 _form1;
      private Gamer _gamer;

      private Form2() {
         InitializeComponent();
         ClubComboBox.DataSource = Enum.GetValues(typeof(FootballClub));
      }

      public Form2(Form1 form1) : this() {
         _form1 = form1;
      }

      public Form2(Form1 form1, Gamer gamer) : this(form1) {
         _gamer = gamer;
         NameTextBox.Text = gamer.Name;
         ClubComboBox.Text = FootballClubInfo.GetName(gamer.Club);
         GoalsTextBox.Text = gamer.GoalsNumber.ToString();
      }

      private void ConfirmBtn_Click(object sender, EventArgs e) {
         var name = NameTextBox.Text;
         var club = (FootballClub) Enum.Parse(typeof(FootballClub), ClubComboBox.Text);
         var goals = int.Parse(GoalsTextBox.Text);
         var gamer = new Gamer(name, club, goals);
         string[] row = {name, FootballClubInfo.GetName(club), GoalsTextBox.Text};
         var item = new ListViewItem(row);

         if (_form1.IsChange){
             _form1.Gamers.Delete(_form1.PlayersListView.Items.IndexOf(_form1.PlayersListView.SelectedItems[0]));
             _form1.PlayersListView.Items.RemoveAt(_form1.PlayersListView.SelectedIndices[0]);
            _form1.PlayersListView.Items.Add(item);
         }
         else{
            _form1.Gamers.Add(gamer);
            _form1.PlayersListView.Items.Add(item);
            _form1.PlayersListView.Refresh();
         }


         NameTextBox.Text = "";
         GoalsTextBox.Text = "";
         ClubComboBox.SelectedItem = FootballClub.None;
         Close();
      }

      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }
   }
}