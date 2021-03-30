namespace Ping_Pong_Yarosh_v1 {
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
         this.StartNewGame = new System.Windows.Forms.Button();
         this.ExitBtn = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // StartNewGame
         // 
         this.StartNewGame.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.StartNewGame.Location = new System.Drawing.Point(307, 163);
         this.StartNewGame.Name = "StartNewGame";
         this.StartNewGame.Size = new System.Drawing.Size(168, 40);
         this.StartNewGame.TabIndex = 0;
         this.StartNewGame.Text = "New game";
         this.StartNewGame.UseVisualStyleBackColor = true;
         this.StartNewGame.Click += new System.EventHandler(this.startNewGame_Click);
         // 
         // ExitBtn
         // 
         this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.ExitBtn.Location = new System.Drawing.Point(307, 211);
         this.ExitBtn.Name = "ExitBtn";
         this.ExitBtn.Size = new System.Drawing.Size(168, 40);
         this.ExitBtn.TabIndex = 1;
         this.ExitBtn.Text = "Exit";
         this.ExitBtn.UseVisualStyleBackColor = true;
         this.ExitBtn.Click += new System.EventHandler(this.exit_Click);
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(218, 91);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(340, 55);
         this.label1.TabIndex = 2;
         this.label1.Text = "PING PONG GAME";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.ExitBtn);
         this.Controls.Add(this.StartNewGame);
         this.ForeColor = System.Drawing.Color.Black;
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.Button ExitBtn;
      private System.Windows.Forms.Button StartNewGame;

      private System.Windows.Forms.Label label1;

      #endregion
   }
}