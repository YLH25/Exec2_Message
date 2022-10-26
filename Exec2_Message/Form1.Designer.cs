namespace Exec2_Message
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
			this.greetingButton1 = new System.Windows.Forms.Button();
			this.greetingButton2 = new System.Windows.Forms.Button();
			this.showLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// greetingButton1
			// 
			this.greetingButton1.Location = new System.Drawing.Point(114, 58);
			this.greetingButton1.Name = "greetingButton1";
			this.greetingButton1.Size = new System.Drawing.Size(175, 57);
			this.greetingButton1.TabIndex = 0;
			this.greetingButton1.Text = "GreetingButton1";
			this.greetingButton1.UseVisualStyleBackColor = true;
			this.greetingButton1.Click += new System.EventHandler(this.greetingButton1_Click);
			// 
			// greetingButton2
			// 
			this.greetingButton2.Location = new System.Drawing.Point(441, 65);
			this.greetingButton2.Name = "greetingButton2";
			this.greetingButton2.Size = new System.Drawing.Size(178, 50);
			this.greetingButton2.TabIndex = 0;
			this.greetingButton2.Text = "GreetingButton2";
			this.greetingButton2.UseVisualStyleBackColor = true;
			this.greetingButton2.Click += new System.EventHandler(this.greetingButton2_Click);
			// 
			// showLabel
			// 
			this.showLabel.Location = new System.Drawing.Point(44, 163);
			this.showLabel.Name = "showLabel";
			this.showLabel.Size = new System.Drawing.Size(710, 254);
			this.showLabel.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.showLabel);
			this.Controls.Add(this.greetingButton2);
			this.Controls.Add(this.greetingButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button greetingButton1;
		private System.Windows.Forms.Button greetingButton2;
		private System.Windows.Forms.Label showLabel;
	}
}

