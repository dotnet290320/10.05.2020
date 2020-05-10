namespace Win1005a
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearCmbBx = new System.Windows.Forms.ComboBox();
            this.monthCmbBx = new System.Windows.Forms.ComboBox();
            this.dayCmbBx = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yearCmbBx);
            this.panel1.Controls.Add(this.monthCmbBx);
            this.panel1.Controls.Add(this.dayCmbBx);
            this.panel1.Location = new System.Drawing.Point(89, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 216);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Day:";
            // 
            // yearCmbBx
            // 
            this.yearCmbBx.FormattingEnabled = true;
            this.yearCmbBx.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.yearCmbBx.Location = new System.Drawing.Point(167, 141);
            this.yearCmbBx.Name = "yearCmbBx";
            this.yearCmbBx.Size = new System.Drawing.Size(121, 24);
            this.yearCmbBx.TabIndex = 8;
            // 
            // monthCmbBx
            // 
            this.monthCmbBx.FormattingEnabled = true;
            this.monthCmbBx.Items.AddRange(new object[] {
            "Jan",
            "Feb"});
            this.monthCmbBx.Location = new System.Drawing.Point(167, 91);
            this.monthCmbBx.Name = "monthCmbBx";
            this.monthCmbBx.Size = new System.Drawing.Size(121, 24);
            this.monthCmbBx.TabIndex = 7;
            // 
            // dayCmbBx
            // 
            this.dayCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCmbBx.FormattingEnabled = true;
            this.dayCmbBx.Location = new System.Drawing.Point(167, 44);
            this.dayCmbBx.Name = "dayCmbBx";
            this.dayCmbBx.Size = new System.Drawing.Size(121, 24);
            this.dayCmbBx.TabIndex = 6;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(89, 282);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(116, 33);
            this.showBtn.TabIndex = 7;
            this.showBtn.Text = "Show Selection";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Picker App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearCmbBx;
        private System.Windows.Forms.ComboBox monthCmbBx;
        private System.Windows.Forms.ComboBox dayCmbBx;
        private System.Windows.Forms.Button showBtn;
    }
}

