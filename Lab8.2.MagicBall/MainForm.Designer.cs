namespace Lab8._2.MagicBall
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.answerBtn = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerBtn
            // 
            this.answerBtn.BackColor = System.Drawing.Color.Black;
            this.answerBtn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerBtn.ForeColor = System.Drawing.Color.White;
            this.answerBtn.Location = new System.Drawing.Point(8, 410);
            this.answerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(209, 32);
            this.answerBtn.TabIndex = 0;
            this.answerBtn.Text = "Ответь мне!";
            this.answerBtn.UseVisualStyleBackColor = false;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionBox.Location = new System.Drawing.Point(8, 367);
            this.questionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(211, 34);
            this.questionBox.TabIndex = 1;
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(314, 175);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(134, 99);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.answerBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MagicBall";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button answerBtn;
		private System.Windows.Forms.TextBox questionBox;
		private System.Windows.Forms.Label answerLabel;
	}
}

