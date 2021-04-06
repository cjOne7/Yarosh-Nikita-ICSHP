using System.ComponentModel;

namespace Ping_Pong_Yarosh_v1 {
   partial class OptionsForm {
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
         this.ConfirmBtn = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.MouseRadioBtn = new System.Windows.Forms.RadioButton();
         this.MovingLeftTextBox = new System.Windows.Forms.TextBox();
         this.KeyboardRadioBtn = new System.Windows.Forms.RadioButton();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.MovingRightTextBox = new System.Windows.Forms.TextBox();
         this.CancelBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // ConfirmBtn
         // 
         this.ConfirmBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.ConfirmBtn.Location = new System.Drawing.Point(45, 325);
         this.ConfirmBtn.Name = "ConfirmBtn";
         this.ConfirmBtn.Size = new System.Drawing.Size(109, 35);
         this.ConfirmBtn.TabIndex = 0;
         this.ConfirmBtn.Text = "Confirm";
         this.ConfirmBtn.UseVisualStyleBackColor = true;
         this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(74, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(274, 35);
         this.label1.TabIndex = 2;
         this.label1.Text = "Type of racket control";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // MouseRadioBtn
         // 
         this.MouseRadioBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.MouseRadioBtn.ForeColor = System.Drawing.Color.White;
         this.MouseRadioBtn.Location = new System.Drawing.Point(124, 54);
         this.MouseRadioBtn.Name = "MouseRadioBtn";
         this.MouseRadioBtn.Size = new System.Drawing.Size(118, 40);
         this.MouseRadioBtn.TabIndex = 3;
         this.MouseRadioBtn.Text = "Mouse";
         this.MouseRadioBtn.UseVisualStyleBackColor = true;
         this.MouseRadioBtn.CheckedChanged += new System.EventHandler(this.MouseRadioBtn_CheckedChanged);
         // 
         // MovingLeftTextBox
         // 
         this.MovingLeftTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.MovingLeftTextBox.Location = new System.Drawing.Point(167, 179);
         this.MovingLeftTextBox.Name = "MovingLeftTextBox";
         this.MovingLeftTextBox.Size = new System.Drawing.Size(161, 36);
         this.MovingLeftTextBox.TabIndex = 4;
         this.MovingLeftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // KeyboardRadioBtn
         // 
         this.KeyboardRadioBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.KeyboardRadioBtn.ForeColor = System.Drawing.Color.White;
         this.KeyboardRadioBtn.Location = new System.Drawing.Point(124, 110);
         this.KeyboardRadioBtn.Name = "KeyboardRadioBtn";
         this.KeyboardRadioBtn.Size = new System.Drawing.Size(150, 40);
         this.KeyboardRadioBtn.TabIndex = 5;
         this.KeyboardRadioBtn.Text = "Keyboard";
         this.KeyboardRadioBtn.UseVisualStyleBackColor = true;
         this.KeyboardRadioBtn.CheckedChanged += new System.EventHandler(this.KeyboardRadioBtn_CheckedChanged);
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(65, 254);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(82, 35);
         this.label2.TabIndex = 6;
         this.label2.Text = "Right";
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(65, 179);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(82, 35);
         this.label3.TabIndex = 7;
         this.label3.Text = "Left";
         // 
         // MovingRightTextBox
         // 
         this.MovingRightTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.MovingRightTextBox.Location = new System.Drawing.Point(167, 254);
         this.MovingRightTextBox.Name = "MovingRightTextBox";
         this.MovingRightTextBox.Size = new System.Drawing.Size(161, 36);
         this.MovingRightTextBox.TabIndex = 9;
         this.MovingRightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // CancelBtn
         // 
         this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.CancelBtn.Location = new System.Drawing.Point(244, 325);
         this.CancelBtn.Name = "CancelBtn";
         this.CancelBtn.Size = new System.Drawing.Size(116, 35);
         this.CancelBtn.TabIndex = 10;
         this.CancelBtn.Text = "Cancel";
         this.CancelBtn.UseVisualStyleBackColor = true;
         this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
         // 
         // OptionsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(409, 409);
         this.Controls.Add(this.CancelBtn);
         this.Controls.Add(this.MovingRightTextBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.KeyboardRadioBtn);
         this.Controls.Add(this.MovingLeftTextBox);
         this.Controls.Add(this.MouseRadioBtn);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.ConfirmBtn);
         this.Name = "OptionsForm";
         this.Text = "Options";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.Button CancelBtn;
      private System.Windows.Forms.Button ConfirmBtn;
      private System.Windows.Forms.TextBox MovingLeftTextBox;
      private System.Windows.Forms.TextBox MovingRightTextBox;

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;

      private System.Windows.Forms.RadioButton KeyboardRadioBtn;

      private System.Windows.Forms.RadioButton MouseRadioBtn;

      private System.Windows.Forms.Label label1;

      #endregion
   }
}