using System.ComponentModel;

namespace Cv5 {
   partial class SaveForm {
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
         this.NoneBox = new System.Windows.Forms.CheckBox();
         this.FCPortoBox = new System.Windows.Forms.CheckBox();
         this.ArsenalBox = new System.Windows.Forms.CheckBox();
         this.RealMadridBox = new System.Windows.Forms.CheckBox();
         this.ChelseaBox = new System.Windows.Forms.CheckBox();
         this.BarcelonaBox = new System.Windows.Forms.CheckBox();
         this.ConfirmBtn = new System.Windows.Forms.Button();
         this.CancelBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // NoneBox
         // 
         this.NoneBox.Location = new System.Drawing.Point(91, 24);
         this.NoneBox.Name = "NoneBox";
         this.NoneBox.Size = new System.Drawing.Size(142, 24);
         this.NoneBox.TabIndex = 0;
         this.NoneBox.Text = "None";
         this.NoneBox.UseVisualStyleBackColor = true;
         // 
         // FCPortoBox
         // 
         this.FCPortoBox.Location = new System.Drawing.Point(91, 54);
         this.FCPortoBox.Name = "FCPortoBox";
         this.FCPortoBox.Size = new System.Drawing.Size(142, 24);
         this.FCPortoBox.TabIndex = 1;
         this.FCPortoBox.Text = "FCPorto";
         this.FCPortoBox.UseVisualStyleBackColor = true;
         // 
         // ArsenalBox
         // 
         this.ArsenalBox.Location = new System.Drawing.Point(91, 84);
         this.ArsenalBox.Name = "ArsenalBox";
         this.ArsenalBox.Size = new System.Drawing.Size(142, 24);
         this.ArsenalBox.TabIndex = 2;
         this.ArsenalBox.Text = "Arsenal";
         this.ArsenalBox.UseVisualStyleBackColor = true;
         // 
         // RealMadridBox
         // 
         this.RealMadridBox.Location = new System.Drawing.Point(91, 114);
         this.RealMadridBox.Name = "RealMadridBox";
         this.RealMadridBox.Size = new System.Drawing.Size(142, 24);
         this.RealMadridBox.TabIndex = 3;
         this.RealMadridBox.Text = "Real Madrid";
         this.RealMadridBox.UseVisualStyleBackColor = true;
         // 
         // ChelseaBox
         // 
         this.ChelseaBox.Location = new System.Drawing.Point(91, 144);
         this.ChelseaBox.Name = "ChelseaBox";
         this.ChelseaBox.Size = new System.Drawing.Size(142, 24);
         this.ChelseaBox.TabIndex = 4;
         this.ChelseaBox.Text = "Chelsea";
         this.ChelseaBox.UseVisualStyleBackColor = true;
         // 
         // BarcelonaBox
         // 
         this.BarcelonaBox.Location = new System.Drawing.Point(91, 174);
         this.BarcelonaBox.Name = "BarcelonaBox";
         this.BarcelonaBox.Size = new System.Drawing.Size(142, 24);
         this.BarcelonaBox.TabIndex = 5;
         this.BarcelonaBox.Text = "Barcelona";
         this.BarcelonaBox.UseVisualStyleBackColor = true;
         // 
         // ConfirmBtn
         // 
         this.ConfirmBtn.Location = new System.Drawing.Point(29, 232);
         this.ConfirmBtn.Name = "ConfirmBtn";
         this.ConfirmBtn.Size = new System.Drawing.Size(95, 32);
         this.ConfirmBtn.TabIndex = 6;
         this.ConfirmBtn.Text = "Confirm";
         this.ConfirmBtn.UseVisualStyleBackColor = true;
         this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
         // 
         // CancelBtn
         // 
         this.CancelBtn.Location = new System.Drawing.Point(208, 232);
         this.CancelBtn.Name = "CancelBtn";
         this.CancelBtn.Size = new System.Drawing.Size(95, 32);
         this.CancelBtn.TabIndex = 7;
         this.CancelBtn.Text = "Cancel";
         this.CancelBtn.UseVisualStyleBackColor = true;
         this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
         // 
         // SaveForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(336, 302);
         this.Controls.Add(this.CancelBtn);
         this.Controls.Add(this.ConfirmBtn);
         this.Controls.Add(this.BarcelonaBox);
         this.Controls.Add(this.ChelseaBox);
         this.Controls.Add(this.RealMadridBox);
         this.Controls.Add(this.ArsenalBox);
         this.Controls.Add(this.FCPortoBox);
         this.Controls.Add(this.NoneBox);
         this.Name = "SaveForm";
         this.Text = "SaveForm";
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.Button CancelBtn;

      private System.Windows.Forms.Button ConfirmBtn;

      private System.Windows.Forms.CheckBox BarcelonaBox;

      private System.Windows.Forms.CheckBox ChelseaBox;

      private System.Windows.Forms.CheckBox RealMadridBox;

      private System.Windows.Forms.CheckBox ArsenalBox;

      private System.Windows.Forms.CheckBox FCPortoBox;
      private System.Windows.Forms.CheckBox NoneBox;

      #endregion
   }
}