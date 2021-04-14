namespace Cv7 {
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
         this.LoadImageBtn = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // LoadImageBtn
         // 
         this.LoadImageBtn.Location = new System.Drawing.Point(12, 12);
         this.LoadImageBtn.Name = "LoadImageBtn";
         this.LoadImageBtn.Size = new System.Drawing.Size(138, 41);
         this.LoadImageBtn.TabIndex = 0;
         this.LoadImageBtn.Text = "Load image";
         this.LoadImageBtn.UseVisualStyleBackColor = true;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.pictureBox1.Location = new System.Drawing.Point(0, 68);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(554, 326);
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(554, 394);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.LoadImageBtn);
         this.Name = "Form1";
         this.Text = "Read PCX image";
         this.TopMost = true;
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.Button LoadImageBtn;

      private System.Windows.Forms.PictureBox pictureBox1;

      #endregion
   }
}