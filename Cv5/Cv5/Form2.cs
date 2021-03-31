using System;
using System.Windows.Forms;

namespace Cv5 {
   public partial class Form2 : Form {
      private readonly InitForm _initForm;
      private Gamer _gamer;

      private Form2() {
         InitializeComponent();
         ClubComboBox.DataSource = Enum.GetValues(typeof(FootballClub));
      }

      public Form2(InitForm initForm) : this() {
         _initForm = initForm;
      }

      public Form2(InitForm initForm, Gamer gamer) : this(initForm) {
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

         if (_initForm.IsChange){
             _initForm.Gamers.Delete(_initForm.PlayersListView.Items.IndexOf(_initForm.PlayersListView.SelectedItems[0]));
             _initForm.PlayersListView.Items.RemoveAt(_initForm.PlayersListView.SelectedIndices[0]);
            _initForm.PlayersListView.Items.Add(item);
         }
         else{
            _initForm.Gamers.Add(gamer);
            _initForm.PlayersListView.Items.Add(item);
            _initForm.PlayersListView.Refresh();
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