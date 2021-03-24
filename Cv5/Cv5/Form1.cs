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

      public Form1() {
         Gamers = new Gamers(10);
         InitializeComponent();

         Gamer gamer = new Gamer("Ronaldo", FootballClub.RealMadrid, 10);
         Gamers.Add(gamer);
         var item = new ListViewItem(new[]
            {"Ronaldo", FootballClubInfo.GetName(FootballClub.RealMadrid), 10.ToString()});
         PlayersListView.Items.Add(item);
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
   }
}