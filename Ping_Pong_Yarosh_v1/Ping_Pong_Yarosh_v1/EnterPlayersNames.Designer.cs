using System.ComponentModel;

namespace Ping_Pong_Yarosh_v1 {
   partial class EnterPlayersNames {
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.PlayersName1 = new System.Windows.Forms.TextBox();
         this.PlayersName2 = new System.Windows.Forms.TextBox();
         this.ConfirmBtn = new System.Windows.Forms.Button();
         this.CancelBtn = new System.Windows.Forms.Button();
         this.ErrorMessLabel = new System.Windows.Forms.Label();
         this.KeyboardMouseRadioBtn = new System.Windows.Forms.RadioButton();
         this.KeyboardKeyboardRadioBtn = new System.Windows.Forms.RadioButton();
         this.label3 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(34, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(231, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Enter player\'s 1 name ";
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(34, 92);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(231, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Enter player\'s 2 name ";
         // 
         // PlayersName1
         // 
         this.PlayersName1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.PlayersName1.Location = new System.Drawing.Point(258, 38);
         this.PlayersName1.Name = "PlayersName1";
         this.PlayersName1.Size = new System.Drawing.Size(193, 32);
         this.PlayersName1.TabIndex = 2;
         // 
         // PlayersName2
         // 
         this.PlayersName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.PlayersName2.Location = new System.Drawing.Point(258, 85);
         this.PlayersName2.Name = "PlayersName2";
         this.PlayersName2.Size = new System.Drawing.Size(193, 32);
         this.PlayersName2.TabIndex = 3;
         // 
         // ConfirmBtn
         // 
         this.ConfirmBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.ConfirmBtn.Location = new System.Drawing.Point(71, 284);
         this.ConfirmBtn.Name = "ConfirmBtn";
         this.ConfirmBtn.Size = new System.Drawing.Size(137, 43);
         this.ConfirmBtn.TabIndex = 4;
         this.ConfirmBtn.Text = "Confirm";
         this.ConfirmBtn.UseVisualStyleBackColor = true;
         this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
         // 
         // CancelBtn
         // 
         this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.CancelBtn.Location = new System.Drawing.Point(267, 284);
         this.CancelBtn.Name = "CancelBtn";
         this.CancelBtn.Size = new System.Drawing.Size(137, 43);
         this.CancelBtn.TabIndex = 5;
         this.CancelBtn.Text = "Cancel";
         this.CancelBtn.UseVisualStyleBackColor = true;
         this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
         // 
         // ErrorMessLabel
         // 
         this.ErrorMessLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.ErrorMessLabel.ForeColor = System.Drawing.Color.Tomato;
         this.ErrorMessLabel.Location = new System.Drawing.Point(34, 125);
         this.ErrorMessLabel.Name = "ErrorMessLabel";
         this.ErrorMessLabel.Size = new System.Drawing.Size(417, 23);
         this.ErrorMessLabel.TabIndex = 6;
         this.ErrorMessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // KeyboardMouseRadioBtn
         // 
         this.KeyboardMouseRadioBtn.Checked = true;
         this.KeyboardMouseRadioBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.KeyboardMouseRadioBtn.ForeColor = System.Drawing.Color.White;
         this.KeyboardMouseRadioBtn.Location = new System.Drawing.Point(34, 218);
         this.KeyboardMouseRadioBtn.Name = "KeyboardMouseRadioBtn";
         this.KeyboardMouseRadioBtn.Size = new System.Drawing.Size(174, 40);
         this.KeyboardMouseRadioBtn.TabIndex = 7;
         this.KeyboardMouseRadioBtn.TabStop = true;
         this.KeyboardMouseRadioBtn.Text = "AD + Mouse";
         this.KeyboardMouseRadioBtn.UseVisualStyleBackColor = true;
         this.KeyboardMouseRadioBtn.CheckedChanged += new System.EventHandler(this.KeyboardMouseRadioBtn_CheckedChanged);
         // 
         // KeyboardKeyboardRadioBtn
         // 
         this.KeyboardKeyboardRadioBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.KeyboardKeyboardRadioBtn.ForeColor = System.Drawing.Color.White;
         this.KeyboardKeyboardRadioBtn.Location = new System.Drawing.Point(258, 218);
         this.KeyboardKeyboardRadioBtn.Name = "KeyboardKeyboardRadioBtn";
         this.KeyboardKeyboardRadioBtn.Size = new System.Drawing.Size(154, 40);
         this.KeyboardKeyboardRadioBtn.TabIndex = 8;
         this.KeyboardKeyboardRadioBtn.Text = "AD + ← →";
         this.KeyboardKeyboardRadioBtn.UseVisualStyleBackColor = true;
         this.KeyboardKeyboardRadioBtn.CheckedChanged += new System.EventHandler(this.KeyboardKeyboardRadioBtn_CheckedChanged);
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(119, 177);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(247, 23);
         this.label3.TabIndex = 9;
         this.label3.Text = "Choose control type";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // EnterPlayersNames
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(491, 362);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.KeyboardKeyboardRadioBtn);
         this.Controls.Add(this.KeyboardMouseRadioBtn);
         this.Controls.Add(this.ErrorMessLabel);
         this.Controls.Add(this.CancelBtn);
         this.Controls.Add(this.ConfirmBtn);
         this.Controls.Add(this.PlayersName2);
         this.Controls.Add(this.PlayersName1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "EnterPlayersNames";
         this.Text = "EnterPlayersNames";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.Label label3;

      private System.Windows.Forms.RadioButton KeyboardKeyboardRadioBtn;
      private System.Windows.Forms.RadioButton KeyboardMouseRadioBtn;

      private System.Windows.Forms.Label ErrorMessLabel;

      private System.Windows.Forms.TextBox PlayersName1;
      private System.Windows.Forms.TextBox PlayersName2;

      private System.Windows.Forms.Button ConfirmBtn;

      private System.Windows.Forms.Button CancelBtn;

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;

      #endregion
   }
}