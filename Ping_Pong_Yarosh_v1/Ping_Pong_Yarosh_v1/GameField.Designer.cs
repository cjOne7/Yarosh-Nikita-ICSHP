using System.ComponentModel;

namespace Ping_Pong_Yarosh_v1 {
   partial class GameField {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)){
            components.Dispose();
         }

         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         this.Playground = new System.Windows.Forms.Panel();
         this.PauseLabel = new System.Windows.Forms.Label();
         this.ScoreLabel = new System.Windows.Forms.Label();
         this.Ball = new System.Windows.Forms.PictureBox();
         this.Racket = new System.Windows.Forms.PictureBox();
         this.timer = new System.Windows.Forms.Timer(this.components);
         this.Playground.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.Ball)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.Racket)).BeginInit();
         this.SuspendLayout();
         // 
         // Playground
         // 
         this.Playground.Controls.Add(this.PauseLabel);
         this.Playground.Controls.Add(this.ScoreLabel);
         this.Playground.Controls.Add(this.Ball);
         this.Playground.Controls.Add(this.Racket);
         this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Playground.Location = new System.Drawing.Point(0, 0);
         this.Playground.Name = "Playground";
         this.Playground.Size = new System.Drawing.Size(800, 450);
         this.Playground.TabIndex = 0;
         // 
         // PauseLabel
         // 
         this.PauseLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.PauseLabel.ForeColor = System.Drawing.Color.White;
         this.PauseLabel.Location = new System.Drawing.Point(211, 120);
         this.PauseLabel.Name = "PauseLabel";
         this.PauseLabel.Size = new System.Drawing.Size(398, 43);
         this.PauseLabel.TabIndex = 3;
         this.PauseLabel.Text = "II The game is paused";
         this.PauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // ScoreLabel
         // 
         this.ScoreLabel.ForeColor = System.Drawing.Color.White;
         this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
         this.ScoreLabel.Name = "ScoreLabel";
         this.ScoreLabel.Size = new System.Drawing.Size(100, 23);
         this.ScoreLabel.TabIndex = 2;
         // 
         // Ball
         // 
         this.Ball.BackColor = System.Drawing.Color.White;
         this.Ball.Location = new System.Drawing.Point(234, 217);
         this.Ball.Name = "Ball";
         this.Ball.Size = new System.Drawing.Size(30, 30);
         this.Ball.TabIndex = 1;
         this.Ball.TabStop = false;
         // 
         // Racket
         // 
         this.Racket.BackColor = System.Drawing.Color.White;
         this.Racket.Location = new System.Drawing.Point(54, 401);
         this.Racket.Name = "Racket";
         this.Racket.Size = new System.Drawing.Size(159, 27);
         this.Racket.TabIndex = 0;
         this.Racket.TabStop = false;
         // 
         // timer
         // 
         this.timer.Enabled = true;
         this.timer.Interval = 1;
         this.timer.Tick += new System.EventHandler(this.timer_Tick);
         // 
         // GameField
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.Playground);
         this.Name = "GameField";
         this.Text = "GameField";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameField_KeyDown);
         this.Playground.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.Ball)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.Racket)).EndInit();
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.Label PauseLabel;
      private System.Windows.Forms.Label ScoreLabel;

      private System.Windows.Forms.Timer timer;

      private System.Windows.Forms.PictureBox Ball;

      private System.Windows.Forms.PictureBox Racket;

      private System.Windows.Forms.Panel Playground;

      #endregion
   }
}