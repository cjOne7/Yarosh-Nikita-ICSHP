using System;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class PvsPGameFieldForm : Form {
      private readonly StartMenu _startMenu;
      private const int StartBallSpeed = 2;
      private int _racketSpeed = 20;
      private int _speedLeft = StartBallSpeed;
      private int _speedTop = StartBallSpeed;
      private int _counter;
      private ControlType _controlType;

      private readonly string _playerName1;
      private readonly string _playerName2;

      private PvsPGameFieldForm() {
         InitializeComponent();

         FormBorderStyle = FormBorderStyle.None;
         TopMost = true; //on top
         Bounds = Screen.PrimaryScreen.Bounds; //full screen 

         Racket1.Top = Playground.Bottom - (Playground.Bottom / 20); //racket1 init pos
         Racket1.Left = (Playground.Width - Racket1.Width) / 2; //racket1 init pos

         Racket2.Top = Playground.Top + (Playground.Height / 20) - Racket2.Height; //racket2 init pos
         Racket2.Left = (Playground.Width - Racket2.Width) / 2; //racket2 init pos

         Centralized(Ball);
         Centralized(PauseLabel);
         Centralized(FinishLabel);
      }

      public PvsPGameFieldForm(ControlType controlType, StartMenu startMenu
         , string playerName1, string playerName2) : this() {
         _playerName1 = playerName1;
         _playerName2 = playerName2;
         _controlType = controlType;
         _startMenu = startMenu;
         KeyDown += KeyboardControl1_KeyDown;
         switch (controlType){
            case ControlType.KeyboardKeyboard:
               KeyUp += KeyboardControl2_KeyUp;
               break;
            case ControlType.KeyboardMouse:
               Playground.MouseMove += MouseControl_MouseMove;
               break;
         }

         timer.Start();
      }

      private void KeyboardControl1_KeyDown(object sender, KeyEventArgs e) {
         switch (e.KeyCode){
            case Keys.A:
               if (Racket1.Left >= Playground.Left){
                  Racket1.Left -= _racketSpeed;
               }

               break;
            case Keys.D:
               if (Racket1.Left <= Playground.Right - Racket1.Width){
                  Racket1.Left += _racketSpeed;
               }

               break;
         }
      }

      private void KeyboardControl2_KeyUp(object sender, KeyEventArgs e) {
         switch (e.KeyCode){
            case Keys.Left:
               if (Racket2.Left > Playground.Left){
                  Racket2.Left -= _racketSpeed;
               }

               break;
            case Keys.Right:
               if (Racket2.Left <= Playground.Right - Racket2.Width){
                  Racket2.Left += _racketSpeed;
               }

               break;
         }
      }

      private void MouseControl_MouseMove(object sender, MouseEventArgs e) {
         if (timer.Enabled){
            if (Cursor.Position.X - Racket2.Width / 2 <= Playground.Left){
               Racket2.Left = Playground.Left;
            }
            else if (Cursor.Position.X + Racket2.Width / 2 >= Playground.Right){
               Racket2.Left = Playground.Right - Racket2.Width;
            }
            else{
               Racket2.Left = Cursor.Position.X - Racket2.Width / 2;
            }
         }
      }

      private void timer_Tick(object sender, EventArgs e) {
         Ball.Left -= _speedLeft;
         Ball.Top -= _speedTop;

         if (Ball.Left <= Playground.Left || Ball.Right >= Playground.Right){
            _speedLeft = -_speedLeft;
         }

         if (Ball.Top <= Racket2.Bottom && Ball.Top >= Racket2.Top
                                        && Ball.Left >= Racket2.Left && Ball.Right <= Racket2.Right){
            _speedLeft = _speedLeft < 0 ? _speedLeft - 1 : _speedLeft + 1;
            _speedTop = _speedTop < 0 ? _speedTop - 1 : _speedTop + 1;

            _speedTop = -_speedTop;
         }

         if (Ball.Bottom >= Racket1.Top && Ball.Bottom <= Racket1.Bottom
                                        && Ball.Left >= Racket1.Left && Ball.Right <= Racket1.Right){
            _speedLeft = _speedLeft < 0 ? _speedLeft - 1 : _speedLeft + 1;
            _speedTop = _speedTop < 0 ? _speedTop - 1 : _speedTop + 1;

            if (_controlType == ControlType.KeyboardMouse){ //boost
               _racketSpeed += 3;
               Racket1.Width += 10;
            }

            _speedTop = -_speedTop;
         }

         if (Ball.Bottom >= Playground.Bottom || Ball.Top <= Playground.Top){
            timer.Enabled = false;
            FinishLabel.Visible = true;
         }

         if (Ball.Top <= Playground.Top){
            timer.Enabled = false;
            FinishLabel.Visible = true;
            FinishLabel.Text = $"Game over\nPlayer {_playerName1} wins\nF1 - restart\nF2 - exit";
         }

         if (Ball.Bottom >= Playground.Bottom){
            timer.Enabled = false;
            FinishLabel.Visible = true;
            FinishLabel.Text = $"Game over\nPlayer {_playerName2} wins\nF1 - restart\nF2 - exit";
         }
      }

      private void Centralized(Control controlObject) {
         controlObject.Left = (Playground.Width - controlObject.Width) / 2; //center
         controlObject.Top = (Playground.Height - controlObject.Height) / 2;
      }

      private void PvsPGameFieldForm_KeyDown(object sender, KeyEventArgs e) {
         switch (e.KeyCode){
            case Keys.Escape:
               timer.Enabled = !timer.Enabled;
               PauseLabel.Visible = !PauseLabel.Visible;
               if (timer.Enabled){
                  Cursor.Hide();
                  FormBorderStyle = FormBorderStyle.None;
               }
               else{
                  Cursor.Show();
                  FormBorderStyle = FormBorderStyle.Sizable;
               }

               break;
            case Keys.F1:
               // SaveScore();
               Ball.Top = Ball.Left = 100;
               _speedLeft = _speedTop = StartBallSpeed;
               FinishLabel.Visible = false;
               timer.Enabled = true;
               Centralized(Ball);
               break;
            case Keys.F2:
               Close();
               _startMenu.Show();
               break;
         }
      }

      private void Playground_MouseEnter(object sender, EventArgs e) {
         Cursor.Hide();
      }

      private void Playground_MouseLeave(object sender, EventArgs e) {
         Cursor.Show();
      }

      private void PvsPGameFieldForm_FormClosing(object sender, FormClosingEventArgs e) {
         _startMenu.Show();
      }
   }
}