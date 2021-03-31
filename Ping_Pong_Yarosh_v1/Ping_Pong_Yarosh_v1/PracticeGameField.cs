﻿using System;
using System.Windows.Forms;

namespace Ping_Pong_Yarosh_v1 {
   public partial class PracticeGameField : Form {
      private int _speedLeft = 4;
      private int _speedTop = 4;
      private int _points;

      private readonly StartMenu _startMenu;

      private PracticeGameField() {
         InitializeComponent();
         FormBorderStyle = FormBorderStyle.None;
         TopMost = true;
         Bounds = Screen.PrimaryScreen.Bounds; //full screen 
         Racket.Top = Playground.Bottom - (Playground.Bottom / 10); // racket init pos
         PauseLabel.Left = (Playground.Width - PauseLabel.Width) / 2;
         PauseLabel.Top = (Playground.Height - PauseLabel.Height) / 2;
      }

      public PracticeGameField(StartMenu startMenu) : this() {
         _startMenu = startMenu;
      }

      private void timer_Tick(object sender, EventArgs e) {
         if (Cursor.Position.X - Racket.Width / 2 <= Playground.Left){
            Racket.Left = Playground.Left;
         } else if (Cursor.Position.X + Racket.Width / 2 >= Playground.Right){
            Racket.Left = Playground.Right - Racket.Width;
         }
         else{
            Racket.Left = Cursor.Position.X - Racket.Width / 2;            
         }

         // Ball.Left += _speedLeft;
         // Ball.Top += _speedTop;

         if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom
                                       && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right){
            _speedTop++;
            _speedLeft++;
            _speedTop = -_speedTop;
            _points++;
            ScoreLabel.Text = $@"Score: {_points}";
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
            if (timer.Enabled){
               Cursor.Hide();
               FormBorderStyle = FormBorderStyle.None;
            }
            else{
               Cursor.Show();
               FormBorderStyle = FormBorderStyle.Sizable;
            }
         }
      }

      private void Playground_MouseEnter(object sender, EventArgs e) {
         Cursor.Hide();
      }

      private void Playground_MouseLeave(object sender, EventArgs e) {
         Cursor.Show();
      }
   }
}