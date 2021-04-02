using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace Ping_Pong_Yarosh_v1 {
   public partial class PvsPGameFieldForm : Form {
      private ControlType _controlType;
      private readonly StartMenu _startMenu;
      private const int StartBallSpeed = 2;
      private const int RacketSpeed = 20;
      private int _speedLeft = StartBallSpeed;
      private int _speedTop = StartBallSpeed;
      private int _points;

      private PvsPGameFieldForm() {
         InitializeComponent();

         // FormBorderStyle = FormBorderStyle.None;
         // TopMost = true; //on top
         Bounds = Screen.PrimaryScreen.Bounds; //full screen 
         Racket1.Top = Playground.Bottom - (Playground.Bottom / 20); //racket1 init pos
         Racket2.Top = Playground.Top + (Playground.Bottom / 20) - Racket2.Height; //racket2 init pos

         PauseLabel.Left = (Playground.Width - PauseLabel.Width) / 2; //center
         PauseLabel.Top = (Playground.Height - PauseLabel.Height) / 2;

         FinishLabel.Left = (Playground.Width - FinishLabel.Width) / 2; //center
         FinishLabel.Top = (Playground.Height - FinishLabel.Height) / 2;

         Ball.Left = (Playground.Width - Ball.Width) / 2; //center
         Ball.Top = (Playground.Height - Ball.Height) / 2;
      }

      public PvsPGameFieldForm(ControlType controlType, StartMenu startMenu) : this() {
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
               if (Racket1.Left > Playground.Left){
                  Racket1.Left -= RacketSpeed;
               }

               break;
            case Keys.D:
               if (Racket1.Left <= Playground.Right - Racket1.Width){
                  Racket1.Left += RacketSpeed;
               }

               break;
         }
      }

      private void KeyboardControl2_KeyUp(object sender, KeyEventArgs e) {
         switch (e.KeyCode){
            case Keys.Left:
               if (Racket2.Left > Playground.Left){
                  Racket2.Left -= RacketSpeed;
               }

               break;
            case Keys.Right:
               if (Racket2.Left <= Playground.Right - Racket2.Width){
                  Racket2.Left += RacketSpeed;
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
         if (Ball.Left <= Playground.Left || Ball.Right >= Playground.Right){
            _speedLeft = -_speedLeft;
         }
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
               _points = 0;
               //todo add event to update it when value has been changed
               // ScoreLabel.Text = @"Score: 0";
               timer.Enabled = true;
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