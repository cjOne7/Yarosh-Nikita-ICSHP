using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cv5 {
   public partial class SaveForm : Form {
      private Gamers _gamers;

      public SaveForm() {
         InitializeComponent();
      }

      public SaveForm(Gamers gamers) : this() {
         _gamers = gamers;
      }


      private void ConfirmBtn_Click(object sender, EventArgs e) {
         var builder = new StringBuilder();
         if (NoneBox.Checked){
            builder.Append(GetGamersByClub(FootballClub.None));
         }

         if (FCPortoBox.Checked){
            builder.Append(GetGamersByClub(FootballClub.FCPorto));
         }

         if (ArsenalBox.Checked){
            builder.Append(GetGamersByClub(FootballClub.Arsenal));
         }

         if (RealMadridBox.Checked){
            builder.Append(GetGamersByClub(FootballClub.RealMadrid));
         }

         if (ChelseaBox.Checked){
            builder.Append(GetGamersByClub(FootballClub.Chelsea));
         }

         if (BarcelonaBox.Checked){
            builder.Append(GetGamersByClub(FootballClub.Barcelona));
         }

         File.WriteAllText("../../../Saved clubs.txt", builder.ToString());
         Close();
      }

      private string GetGamersByClub(FootballClub footballClub) {
         var builder = new StringBuilder();
         for (var i = 0; i < _gamers.LinkedList.Count; i++){
            if (_gamers[i].Club.Equals(footballClub)){
               builder.Append(_gamers[i]).Append("\n");
            }
         }

         return builder.ToString();
      }

      private void CancelBtn_Click(object sender, EventArgs e) {
         Close();
      }
   }
}