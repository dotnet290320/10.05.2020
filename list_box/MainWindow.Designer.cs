namespace Win1005b
{
    partial class MainWindow
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
            this.numberTxtBx = new System.Windows.Forms.TextBox();
            this.numbersLst = new System.Windows.Forms.ListBox();
            this.addBn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.sumBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTxtBx
            // 
            this.numberTxtBx.Location = new System.Drawing.Point(100, 40);
            this.numberTxtBx.Name = "numberTxtBx";
            this.numberTxtBx.Size = new System.Drawing.Size(128, 22);
            this.numberTxtBx.TabIndex = 0;
            this.numberTxtBx.Text = "0";
            this.numberTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberTxtBx.DoubleClick += new System.EventHandler(this.addBn_Click);
            // 
            // numbersLst
            // 
            this.numbersLst.FormattingEnabled = true;
            this.numbersLst.ItemHeight = 16;
            this.numbersLst.Location = new System.Drawing.Point(76, 90);
            this.numbersLst.Name = "numbersLst";
            this.numbersLst.Size = new System.Drawing.Size(171, 132);
            this.numbersLst.TabIndex = 1;
            this.numbersLst.DoubleClick += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBn
            // 
            this.addBn.Location = new System.Drawing.Point(35, 255);
            this.addBn.Name = "addBn";
            this.addBn.Size = new System.Drawing.Size(75, 34);
            this.addBn.TabIndex = 2;
            this.addBn.Text = "Add";
            this.addBn.UseVisualStyleBackColor = true;
            this.addBn.Click += new System.EventHandler(this.addBn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(129, 255);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 34);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(224, 255);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(75, 34);
            this.sumBtn.TabIndex = 4;
            this.sumBtn.Text = "Sum";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.sumBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 328);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBn);
            this.Controls.Add(this.numbersLst);
            this.Controls.Add(this.numberTxtBx);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTxtBx;
        private System.Windows.Forms.ListBox numbersLst;
        private System.Windows.Forms.Button addBn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button sumBtn;
    }
}

