using System.ComponentModel;

namespace Ping_Pong_Yarosh_v1 {
   partial class PvsPGameFieldForm {
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
         this.Racket2 = new System.Windows.Forms.PictureBox();
         this.Racket1 = new System.Windows.Forms.PictureBox();
         this.FinishLabel = new System.Windows.Forms.Label();
         this.PauseLabel = new System.Windows.Forms.Label();
         this.Ball = new System.Windows.Forms.PictureBox();
         this.timer = new System.Windows.Forms.Timer(this.components);
         this.Playground.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.Racket2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.Racket1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize) (this.Ball)).BeginInit();
         this.SuspendLayout();
         // 
         // Playground
         // 
         this.Playground.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.Playground.Controls.Add(this.Racket2);
         this.Playground.Controls.Add(this.Racket1);
         this.Playground.Controls.Add(this.FinishLabel);
         this.Playground.Controls.Add(this.PauseLabel);
         this.Playground.Controls.Add(this.Ball);
         this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Playground.Location = new System.Drawing.Point(0, 0);
         this.Playground.Name = "Playground";
         this.Playground.Size = new System.Drawing.Size(800, 450);
         this.Playground.TabIndex = 0;
         this.Playground.MouseEnter += new System.EventHandler(this.Playground_MouseEnter);
         this.Playground.MouseLeave += new System.EventHandler(this.Playground_MouseLeave);
         // 
         // Racket2
         // 
         this.Racket2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.Racket2.BackColor = System.Drawing.Color.White;
         this.Racket2.Location = new System.Drawing.Point(249, 348);
         this.Racket2.Name = "Racket2";
         this.Racket2.Size = new System.Drawing.Size(159, 27);
         this.Racket2.TabIndex = 6;
         this.Racket2.TabStop = false;
         // 
         // Racket1
         // 
         this.Racket1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.Racket1.BackColor = System.Drawing.Color.White;
         this.Racket1.Location = new System.Drawing.Point(68, 348);
         this.Racket1.Name = "Racket1";
         this.Racket1.Size = new System.Drawing.Size(159, 27);
         this.Racket1.TabIndex = 1;
         this.Racket1.TabStop = false;
         // 
         // FinishLabel
         // 
         this.FinishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.FinishLabel.ForeColor = System.Drawing.Color.White;
         this.FinishLabel.Location = new System.Drawing.Point(272, 119);
         this.FinishLabel.Name = "FinishLabel";
         this.FinishLabel.Size = new System.Drawing.Size(373, 197);
         this.FinishLabel.TabIndex = 5;
         this.FinishLabel.Text = "Game over\r\nF1 - restart\r\nF2 - exit\r\n";
         this.FinishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.FinishLabel.Visible = false;
         // 
         // PauseLabel
         // 
         this.PauseLabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.PauseLabel.ForeColor = System.Drawing.Color.White;
         this.PauseLabel.Location = new System.Drawing.Point(131, 27);
         this.PauseLabel.Name = "PauseLabel";
         this.PauseLabel.Size = new System.Drawing.Size(547, 92);
         this.PauseLabel.TabIndex = 4;
         this.PauseLabel.Text = "II The game is paused";
         this.PauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.PauseLabel.Visible = false;
         // 
         // Ball
         // 
         this.Ball.BackColor = System.Drawing.Color.White;
         this.Ball.Location = new System.Drawing.Point(159, 227);
         this.Ball.Name = "Ball";
         this.Ball.Size = new System.Drawing.Size(30, 30);
         this.Ball.TabIndex = 2;
         this.Ball.TabStop = false;
         // 
         // timer
         // 
         this.timer.Enabled = true;
         this.timer.Interval = 1;
         this.timer.Tick += new System.EventHandler(this.timer_Tick);
         // 
         // PvsPGameFieldForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.Playground);
         this.Name = "PvsPGameFieldForm";
         this.Text = "PvsPGameFieldForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PvsPGameFieldForm_FormClosing);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PvsPGameFieldForm_KeyDown);
         this.Playground.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize) (this.Racket2)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.Racket1)).EndInit();
         ((System.ComponentModel.ISupportInitialize) (this.Ball)).EndInit();
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.PictureBox Racket1;
      private System.Windows.Forms.PictureBox Racket2;

      private System.Windows.Forms.Label FinishLabel;

      private System.Windows.Forms.Label PauseLabel;

      private System.Windows.Forms.PictureBox Ball;
      private System.Windows.Forms.Timer timer;

      private System.Windows.Forms.Panel Playground;

      #endregion
   }
}