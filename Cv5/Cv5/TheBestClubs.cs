using System.Text;
using System.Windows.Forms;

namespace Cv5 {
   public partial class TheBestClubs : Form {
      private TheBestClubs() {
         InitializeComponent();
      }

      public TheBestClubs(InitForm initForm) : this() {
         initForm.Gamers.FindTheBestClub(out var clubs, out var goals);
         GoalsNumber.Text = goals.ToString();
         var builder = new StringBuilder();
         foreach (var club in clubs){
            builder.Append(club).Append(", \n");
         }

         ClubsList.Text = builder.ToString();
      }
   }
}