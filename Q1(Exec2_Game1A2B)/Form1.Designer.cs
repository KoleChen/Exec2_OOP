namespace Q1_Exec2_Game1A2B_
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.CountLabel = new System.Windows.Forms.Label();
			this.CheckButton = new System.Windows.Forms.Button();
			this.AnswerButton = new System.Windows.Forms.Button();
			this.RestartButton = new System.Windows.Forms.Button();
			this.AnswerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入數字";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(148, 42);
			this.InputTextBox.MaxLength = 4;
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(100, 22);
			this.InputTextBox.TabIndex = 1;
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ResultTextBox.Location = new System.Drawing.Point(68, 90);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			this.ResultTextBox.Size = new System.Drawing.Size(180, 236);
			this.ResultTextBox.TabIndex = 2;
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CountLabel.Location = new System.Drawing.Point(68, 358);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(71, 16);
			this.CountLabel.TabIndex = 3;
			this.CountLabel.Text = "猜測次數";
			// 
			// CheckButton
			// 
			this.CheckButton.Location = new System.Drawing.Point(307, 90);
			this.CheckButton.Name = "CheckButton";
			this.CheckButton.Size = new System.Drawing.Size(75, 23);
			this.CheckButton.TabIndex = 4;
			this.CheckButton.Text = "確定";
			this.CheckButton.UseVisualStyleBackColor = true;
			this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
			// 
			// AnswerButton
			// 
			this.AnswerButton.Location = new System.Drawing.Point(307, 168);
			this.AnswerButton.Name = "AnswerButton";
			this.AnswerButton.Size = new System.Drawing.Size(75, 23);
			this.AnswerButton.TabIndex = 5;
			this.AnswerButton.Text = "看答案";
			this.AnswerButton.UseVisualStyleBackColor = true;
			this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
			// 
			// RestartButton
			// 
			this.RestartButton.Location = new System.Drawing.Point(307, 246);
			this.RestartButton.Name = "RestartButton";
			this.RestartButton.Size = new System.Drawing.Size(75, 23);
			this.RestartButton.TabIndex = 6;
			this.RestartButton.Text = "重新開始";
			this.RestartButton.UseVisualStyleBackColor = true;
			this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
			// 
			// AnswerLabel
			// 
			this.AnswerLabel.AutoSize = true;
			this.AnswerLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AnswerLabel.Location = new System.Drawing.Point(406, 168);
			this.AnswerLabel.Name = "AnswerLabel";
			this.AnswerLabel.Size = new System.Drawing.Size(85, 19);
			this.AnswerLabel.TabIndex = 7;
			this.AnswerLabel.Text = "顯示答案";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 432);
			this.Controls.Add(this.AnswerLabel);
			this.Controls.Add(this.RestartButton);
			this.Controls.Add(this.AnswerButton);
			this.Controls.Add(this.CheckButton);
			this.Controls.Add(this.CountLabel);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "1A2B遊戲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.Label CountLabel;
		private System.Windows.Forms.Button CheckButton;
		private System.Windows.Forms.Button AnswerButton;
		private System.Windows.Forms.Button RestartButton;
		private System.Windows.Forms.Label AnswerLabel;
	}
}

