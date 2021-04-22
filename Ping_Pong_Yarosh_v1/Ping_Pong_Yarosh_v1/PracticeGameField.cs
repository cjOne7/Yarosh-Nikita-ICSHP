using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.Json;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class PracticeGameField : Form {
      private readonly Options _options;
      private const int StartBallSpeed = 2;
      private const int RacketSpeed = 20;
      private int _speedLeft = StartBallSpeed;
      private int _speedTop = StartBallSpeed;
      private int _points;

      private readonly StartMenu _startMenu;

      private static readonly SoundPlayer StartGamePlayer = new SoundPlayer(Files.StartGameSound);
      private static readonly SoundPlayer PlatformTouchSoundPlayer = new SoundPlayer(Files.PlatformTouchSound);

      private PracticeGameField() {
         InitializeComponent();
         Cursor.Hide();
         FormBorderStyle = FormBorderStyle.None;
         TopMost = true; //on top
         Bounds = Screen.PrimaryScreen.Bounds; //full screen 
         Racket.Top = Playground.Bottom - (Playground.Bottom / 10); //racket init pos

         Centralized(FinishLabel);
         Centralized(PauseLabel);
         StartGamePlayer.Play();
      }

      public PracticeGameField(StartMenu startMenu) : this() {
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
            if (Cursor.Position.X - Racket.Width / 2 <= Playground.Left){
               Racket.Left = Playground.Left;
            }
            else if (Cursor.Position.X + Racket.Width / 2 >= Playground.Right){
               Racket.Left = Playground.Right - Racket.Width;
            }
            else{
               Racket.Left = Cursor.Position.X - Racket.Width / 2;
            }
         }
      }

      private void timer_Tick(object sender, EventArgs e) {
         Ball.Left += _speedLeft;
         Ball.Top += _speedTop;

         if (Ball.Bounds.IntersectsWith(Racket.Bounds)){
            PlatformTouchSoundPlayer.Play();
            _speedTop++;
            _speedLeft++;
            _speedTop = -_speedTop;
            _points++;
            ScoreLabel.Text = $@"Score: {_points}";
         }

         if (Ball.Left <= Playground.Left || Ball.Right >= Playground.Right){
            PlatformTouchSoundPlayer.Play();
            _speedLeft = -_speedLeft;
         }

         if (Ball.Top <= Playground.Top){
            PlatformTouchSoundPlayer.Play();
            _speedTop = -_speedTop;
         }

         if (Ball.Bottom >= Playground.Bottom){
            timer.Enabled = false;
            FinishLabel.Visible = true;
         }
      }

      private void GameField_KeyDown(object sender, KeyEventArgs e) {
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
               SaveScore();
               Ball.Top = Ball.Left = 100;
               _speedLeft = _speedTop = StartBallSpeed;
               FinishLabel.Visible = false;
               _points = 0;
               ScoreLabel.Text = @"Score: 0";
               timer.Enabled = true;
               StartGamePlayer.Play();
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

      private void Playground_MouseEnter(object sender, EventArgs e) {
         Cursor.Hide();
      }

      private void Playground_MouseLeave(object sender, EventArgs e) {
         Cursor.Show();
      }

      private void PracticeGameField_FormClosing(object sender, FormClosingEventArgs e) {
         SaveScore();
         Cursor.Show();
         _startMenu.Show();
      }

      private void SaveScore() {
         var input = File.ReadLines(Files.PracticeScoreFilepath).ToList();
         using (var sw = new StreamWriter(File.Open(Files.PracticeScoreFilepath, FileMode.Append))){
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

      private void Centralized(Control controlObject) {
         controlObject.Left = (Playground.Width - controlObject.Width) / 2;
         controlObject.Top = (Playground.Height - controlObject.Height) / 2;
      }
   }
}