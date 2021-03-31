using System;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class GameField : Form {
      private int _speedLeft = 4;
      private int _speedTop = 4;
      private int _points;

      private string _playerName1;
      private string _playerName2;

      private readonly StartMenu _startMenu;

      public GameField() {
         InitializeComponent();
         Cursor.Hide();
         // FormBorderStyle = FormBorderStyle.None;
         TopMost = true;
         Bounds = Screen.PrimaryScreen.Bounds; //full screen 
         Racket.Top = Playground.Bottom - (Playground.Bottom / 10); // racket init pos
         // PauseLabel;
      }

      public GameField(string playerName1, string playerName2) : this() {
         _playerName1 = playerName1;
         _playerName2 = playerName2;
      }

      public GameField(string playerName1, string playerName2, StartMenu startMenu) : this(playerName1, playerName2) {
         _startMenu = startMenu;
      }

      private void timer_Tick(object sender, EventArgs e) {
         Racket.Left = Cursor.Position.X - Racket.Width / 2;
         
         Ball.Left += _speedLeft;
         Ball.Top += _speedTop;

         if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom
                                       && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right){
            _speedTop += 2;
            _speedLeft += 2;
            _speedTop = -_speedTop;
            _points++;
         }

         if (Ball.Left <= Playground.Left){
            _speedLeft = -_speedLeft;
         }

         if (Ball.Right >= Playground.Right){
            _speedLeft = -_speedLeft;
         }

         if (Ball.Top <= Playground.Top){
            _speedTop = -_speedTop;
         }

         if (Ball.Bottom >= Playground.Bottom){
            timer.Enabled = false;
         }
      }

      private void GameField_KeyDown(object sender, KeyEventArgs e) {
         if (e.KeyCode == Keys.Escape){
            timer.Enabled = !timer.Enabled;
            PauseLabel.Visible = !PauseLabel.Visible;
         }
      }
   }
}