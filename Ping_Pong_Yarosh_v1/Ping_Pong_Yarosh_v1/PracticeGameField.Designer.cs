using System.ComponentModel;

namespace Ping_Pong_Yarosh_v1 {
   partial class PracticeGameField {
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
         this.FinishLabel = new System.Windows.Forms.Label();
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
         this.Playground.Controls.Add(this.FinishLabel);
         this.Playground.Controls.Add(this.PauseLabel);
         this.Playground.Controls.Add(this.ScoreLabel);
         this.Playground.Controls.Add(this.Ball);
         this.Playground.Controls.Add(this.Racket);
         this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Playground.Location = new System.Drawing.Point(0, 0);
         this.Playground.Name = "Playground";
         this.Playground.Size = new System.Drawing.Size(931, 530);
         this.Playground.TabIndex = 0;
         this.Playground.MouseEnter += new System.EventHandler(this.Playground_MouseEnter);
         this.Playground.MouseLeave += new System.EventHandler(this.Playground_MouseLeave);
         // 
         // FinishLabel
         // 
         this.FinishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.FinishLabel.ForeColor = System.Drawing.Color.White;
         this.FinishLabel.Location = new System.Drawing.Point(362, 173);
         this.FinishLabel.Name = "FinishLabel";
         this.FinishLabel.Size = new System.Drawing.Size(261, 197);
         this.FinishLabel.TabIndex = 4;
         this.FinishLabel.Text = "Game over\r\nF1 - restart\r\nF2 - exit\r\n";
         this.FinishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.FinishLabel.Visible = false;
         // 
         // PauseLabel
         // 
         this.PauseLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.PauseLabel.ForeColor = System.Drawing.Color.White;
         this.PauseLabel.Location = new System.Drawing.Point(198, 57);
         this.PauseLabel.Name = "PauseLabel";
         this.PauseLabel.Size = new System.Drawing.Size(547, 92);
         this.PauseLabel.TabIndex = 3;
         this.PauseLabel.Text = "II The game is paused";
         this.PauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.PauseLabel.Visible = false;
         // 
         // ScoreLabel
         // 
         this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
         this.ScoreLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.ScoreLabel.ForeColor = System.Drawing.Color.White;
         this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
         this.ScoreLabel.Name = "ScoreLabel";
         this.ScoreLabel.Size = new System.Drawing.Size(201, 48);
         this.ScoreLabel.TabIndex = 2;
         this.ScoreLabel.Text = "Score: 0";
         // 
         // Ball
         // 
         this.Ball.BackColor = System.Drawing.Color.White;
         this.Ball.Location = new System.Drawing.Point(128, 173);
         this.Ball.Name = "Ball";
         this.Ball.Size = new System.Drawing.Size(30, 30);
         this.Ball.TabIndex = 1;
         this.Ball.TabStop = false;
         // 
         // Racket
         // 
         this.Racket.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.Racket.BackColor = System.Drawing.Color.White;
         this.Racket.Location = new System.Drawing.Point(54, 458);
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
         // PracticeGameField
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(931, 530);
         this.Controls.Add(this.Playground);
         this.Name = "PracticeGameField";
         this.Text = "GameField";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PracticeGameField_FormClosing);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameField_KeyDown);
         this.Playground.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.Ball)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.Racket)).EndInit();
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.Label FinishLabel;

      private System.Windows.Forms.Label PauseLabel;
      private System.Windows.Forms.Label ScoreLabel;

      private System.Windows.Forms.Timer timer;

      private System.Windows.Forms.PictureBox Ball;

      private System.Windows.Forms.PictureBox Racket;

      private System.Windows.Forms.Panel Playground;

      #endregion
   }
}