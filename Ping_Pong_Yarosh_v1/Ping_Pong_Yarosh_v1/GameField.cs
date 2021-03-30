using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class GameField : Form {
      private string _playerName1;
      private string _playerName2;
      public GameField() {
         InitializeComponent();
      }

      public GameField(string playerName1, string playerName2) : this() {
         _playerName1 = playerName1;
         _playerName2 = playerName2;
      }
   }
}