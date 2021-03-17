﻿namespace Cv4 {
   partial class Form1 {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

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
         this.gameListBox = new System.Windows.Forms.ListBox();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.accurancyLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
         this.difficultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
         this.timer1 = new System.Timers.Timer();
         this.StartNewGameBtn = new System.Windows.Forms.Button();
         this.ExitBtn = new System.Windows.Forms.Button();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
         this.flowLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // gameListBox
         // 
         this.gameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.gameListBox.FormattingEnabled = true;
         this.gameListBox.ItemHeight = 135;
         this.gameListBox.Items.AddRange(new object[] {"q", "q", "q"});
         this.gameListBox.Location = new System.Drawing.Point(0, 49);
         this.gameListBox.MultiColumn = true;
         this.gameListBox.Name = "gameListBox";
         this.gameListBox.Size = new System.Drawing.Size(800, 139);
         this.gameListBox.TabIndex = 0;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.correctLabel, this.missedLabel, this.accurancyLabel, this.toolStripStatusLabel4, this.difficultProgressBar});
         this.statusStrip1.Location = new System.Drawing.Point(0, 188);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(800, 25);
         this.statusStrip1.TabIndex = 1;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // correctLabel
         // 
         this.correctLabel.Name = "correctLabel";
         this.correctLabel.Size = new System.Drawing.Size(72, 20);
         this.correctLabel.Text = "Correct: 0";
         // 
         // missedLabel
         // 
         this.missedLabel.Name = "missedLabel";
         this.missedLabel.Size = new System.Drawing.Size(70, 20);
         this.missedLabel.Text = "Missed: 0";
         // 
         // accurancyLabel
         // 
         this.accurancyLabel.Name = "accurancyLabel";
         this.accurancyLabel.Size = new System.Drawing.Size(103, 20);
         this.accurancyLabel.Text = "Accurancy: 0%";
         // 
         // toolStripStatusLabel4
         // 
         this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
         this.toolStripStatusLabel4.Size = new System.Drawing.Size(438, 20);
         this.toolStripStatusLabel4.Spring = true;
         this.toolStripStatusLabel4.Text = "Difficulty";
         this.toolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // difficultProgressBar
         // 
         this.difficultProgressBar.Maximum = 800;
         this.difficultProgressBar.Name = "difficultProgressBar";
         this.difficultProgressBar.Size = new System.Drawing.Size(100, 19);
         // 
         // timer1
         // 
         this.timer1.Enabled = true;
         this.timer1.Interval = 800D;
         this.timer1.SynchronizingObject = this;
         // 
         // StartNewGameBtn
         // 
         this.StartNewGameBtn.Location = new System.Drawing.Point(3, 3);
         this.StartNewGameBtn.Name = "StartNewGameBtn";
         this.StartNewGameBtn.Size = new System.Drawing.Size(90, 37);
         this.StartNewGameBtn.TabIndex = 2;
         this.StartNewGameBtn.Text = "New game";
         this.StartNewGameBtn.UseVisualStyleBackColor = true;
         this.StartNewGameBtn.Click += new System.EventHandler(this.button1_Click);
         // 
         // ExitBtn
         // 
         this.ExitBtn.Location = new System.Drawing.Point(99, 3);
         this.ExitBtn.Name = "ExitBtn";
         this.ExitBtn.Size = new System.Drawing.Size(64, 36);
         this.ExitBtn.TabIndex = 3;
         this.ExitBtn.Text = "Exit";
         this.ExitBtn.UseVisualStyleBackColor = true;
         this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Controls.Add(this.StartNewGameBtn);
         this.flowLayoutPanel1.Controls.Add(this.ExitBtn);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 43);
         this.flowLayoutPanel1.TabIndex = 5;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 213);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.gameListBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.Text = "Form1";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

      private System.Windows.Forms.Button ExitBtn;
      private System.Windows.Forms.Button StartNewGameBtn;

      private System.Windows.Forms.ListBox gameListBox;

      private System.Timers.Timer timer1;

      private System.Windows.Forms.ToolStripProgressBar difficultProgressBar;

      private System.Windows.Forms.ToolStripStatusLabel accurancyLabel;

      private System.Windows.Forms.ToolStripStatusLabel missedLabel;

      private System.Windows.Forms.ToolStripStatusLabel correctLabel;

      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;

      private System.Windows.Forms.StatusStrip statusStrip1;

      #endregion
   }
}