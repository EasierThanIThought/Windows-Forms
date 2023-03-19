namespace GREENPEACE
{
    partial class Form1
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
            this.CloseGreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseGreen
            // 
            this.CloseGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseGreen.Location = new System.Drawing.Point(211, 175);
            this.CloseGreen.Margin = new System.Windows.Forms.Padding(0);
            this.CloseGreen.Name = "CloseGreen";
            this.CloseGreen.Size = new System.Drawing.Size(160, 60);
            this.CloseGreen.TabIndex = 0;
            this.CloseGreen.Text = "GREENPEACE";
            this.CloseGreen.UseVisualStyleBackColor = true;
            this.CloseGreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.CloseGreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseGreen;
    }
}

