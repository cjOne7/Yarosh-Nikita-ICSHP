using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class GameField : Form {
      private string _playerName1;
      private string _playerName2;

      private readonly StartMenu _startMenu;

      public GameField() {
         InitializeComponent();
      }

      public GameField(string playerName1, string playerName2) : this() {
         _playerName1 = playerName1;
         _playerName2 = playerName2;
      }

      public GameField(string playerName1, string playerName2, StartMenu startMenu) : this(playerName1, playerName2) {
         _startMenu = startMenu;
      }
   }
}