using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class DestroyBlocksForm : Form {
      private readonly Options _options;
      private const int StartBallSpeed = 2;
      private const int RacketSpeed = 20;
      private int _speedLeft = StartBallSpeed;
      private int _speedTop = StartBallSpeed;
      private int _points;
      private readonly List<Control> _initBlocks = new List<Control>();

      private readonly StartMenu _startMenu;

      private DestroyBlocksForm() {
         InitializeComponent();

         foreach (Control control in Playground.Controls){
            if (control is PictureBox && (string) control.Tag == "blocks"){
               _initBlocks.Add(control);
            }
         }
         Cursor.Hide();
         // TopMost = true; //on top
         Centralized(FinishLabel);
         Centralized(PauseLabel);
         Centralized(Ball);
         Racket.Top = Playground.Bottom - (Playground.Bottom / 10); //racket init pos
      }

      public DestroyBlocksForm(StartMenu startMenu) : this() {
         _startMenu = startMenu;
         var input = File.ReadAllText(Files.OptionsFilePath);
         _options = JsonSerializer.Deserialize<Options>(input);
         if (_options.IsMouse == _options.IsKeyboard){
            throw new ArgumentException("You can't use mouse and keyboard simultaneously.");
         }

         if (_options.IsMouse){
            Playground.MouseMove += Playground_MouseMove;
         }
      }

      private void RacketMoving_KeyDown(object sender, KeyEventArgs e) {
         var left = (Keys) Enum.Parse(typeof(Keys), _options.KeyboardControl.Left.ToUpper());
         var right = (Keys) Enum.Parse(typeof(Keys), _options.KeyboardControl.Right.ToUpper());
         if (e.KeyCode == left){
            if (Racket.Left > Playground.Left){
               Racket.Left -= RacketSpeed;
            }
         }

         if (e.KeyCode == right){
            if (Racket.Left <= Playground.Right - Racket.Width){
               Racket.Left += RacketSpeed;
            }
         }
      }

      private void Playground_MouseMove(object sender, MouseEventArgs e) {
         if (timer.Enabled){
            if (Cursor.Position.X - Left - Racket.Width / 2 <= Playground.Left){
               Racket.Left = Playground.Left;
            }
            else if (Cursor.Position.X - Left + Racket.Width / 2 >= Playground.Right){
               Racket.Left = Playground.Right - Racket.Width;
            }
            else{
               Racket.Left = Cursor.Position.X - Left - Racket.Width / 2;
            }
         }
      }

      private void timer_Tick(object sender, EventArgs e) {
         ScoreLabel.Text = $@"Score: {_points}";

         Ball.Left += _speedLeft;
         Ball.Top += _speedTop;

         if (Ball.Bounds.IntersectsWith(Racket.Bounds)){
            _speedTop = -_speedTop;
            ScoreLabel.Text = $@"Score: {_points}";
         }

         if (Ball.Left <= Playground.Left || Ball.Right >= Playground.Right){
            _speedLeft = -_speedLeft;
         }

         if (Ball.Top <= Playground.Top){
            _speedTop = -_speedTop;
         }

         foreach (Control control in Playground.Controls){
            if (control is PictureBox && (string) control.Tag == "blocks"){
               if (Ball.Bounds.IntersectsWith(control.Bounds)){
                  _points++;
                  _speedTop = -_speedTop;
                  Playground.Controls.Remove(control);
               }
            }
         }

         if (Ball.Bottom >= Playground.Bottom || _points == 8){
            timer.Enabled = false;
            FinishLabel.Visible = true;
         }
      }

      private void DestroyBlocksForm_KeyDown(object sender, KeyEventArgs e) {
         switch (e.KeyCode){
            case Keys.Escape:
               timer.Enabled = !timer.Enabled;
               PauseLabel.Visible = !PauseLabel.Visible;
               if (timer.Enabled){
                  Cursor.Hide();
               }
               else{
                  Cursor.Show();
               }

               break;
            case Keys.F1:
               Centralized(Ball);
               _speedLeft = _speedTop = StartBallSpeed;
               FinishLabel.Visible = false;
               _points = 0;
               ScoreLabel.Text = $@"Score: {_points}";
               Playground.Controls.AddRange(_initBlocks.ToArray());
               timer.Enabled = true;
               break;
            case Keys.F2:
               Close();
               _startMenu.Show();
               break;
         }

         if (_options.IsKeyboard){
            RacketMoving_KeyDown(sender, e);
         }
      }

      private void DestroyBlocksForm_FormClosing(object sender, FormClosingEventArgs e) {
         SaveScore();
         _startMenu.Show();
      }

      private void Playground_MouseEnter(object sender, EventArgs e) {
         Cursor.Hide();
      }

      private void Playground_MouseLeave(object sender, EventArgs e) {
         Cursor.Show();
      }

      private void Centralized(Control controlObject) {
         controlObject.Left = (Playground.Width - controlObject.Width) / 2;
         controlObject.Top = (Playground.Height - controlObject.Height) / 2;
      }

      private void SaveScore() {
         var input = File.ReadLines(Files.DestroyBlocksFilePath).ToList();
         using (var sw = new StreamWriter(File.Open(Files.DestroyBlocksFilePath, FileMode.Append))){
            if (input.Count() == 0){
               sw.WriteLine("game_id;score;date");
               sw.WriteLine($"1;{_points};{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            }
            else{
               var incrementGameId = int.Parse(input.Last().Split(';')[0]) + 1;
               sw.WriteLine($"{incrementGameId};{_points};{DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            }
         }
      }
   }
}