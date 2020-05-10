namespace Win1005
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLbl = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLbl
            // 
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeLbl.Location = new System.Drawing.Point(-1, 185);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(359, 25);
            this.timeLbl.TabIndex = 0;
            this.timeLbl.Text = "?";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeBtn
            // 
            this.timeBtn.Location = new System.Drawing.Point(100, 107);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(154, 40);
            this.timeBtn.TabIndex = 1;
            this.timeBtn.Text = "Show me the time";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 318);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.timeLbl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button timeBtn;
    }
}

