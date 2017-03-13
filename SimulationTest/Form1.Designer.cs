namespace SimulationTest
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbRandomNumbers = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZ0 = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkZeroToOne = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 120);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 439);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkZeroToOne);
            this.tabPage1.Controls.Add(this.txtCount);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txta);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtZ0);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rtbRandomNumbers);
            this.tabPage1.Location = new System.Drawing.Point(124, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Linear congruential generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbRandomNumbers
            // 
            this.rtbRandomNumbers.Location = new System.Drawing.Point(20, 148);
            this.rtbRandomNumbers.Name = "rtbRandomNumbers";
            this.rtbRandomNumbers.Size = new System.Drawing.Size(512, 254);
            this.rtbRandomNumbers.TabIndex = 0;
            this.rtbRandomNumbers.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Find Full Period Parameters (a, c)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Z0 :";
            // 
            // txtZ0
            // 
            this.txtZ0.Location = new System.Drawing.Point(67, 25);
            this.txtZ0.Name = "txtZ0";
            this.txtZ0.Size = new System.Drawing.Size(70, 20);
            this.txtZ0.TabIndex = 4;
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(67, 51);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(70, 20);
            this.txtm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "m :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type :";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Mixed Congruential Generator",
            "Multiplicative Congruential Generator"});
            this.cmbType.Location = new System.Drawing.Point(67, 75);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(231, 21);
            this.cmbType.TabIndex = 8;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(191, 51);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(70, 20);
            this.txtc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "c :";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(191, 25);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(70, 20);
            this.txta.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "a :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Get Random Numbers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(348, 124);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(70, 20);
            this.txtCount.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Length :";
            // 
            // chkZeroToOne
            // 
            this.chkZeroToOne.AutoSize = true;
            this.chkZeroToOne.Location = new System.Drawing.Point(424, 125);
            this.chkZeroToOne.Name = "chkZeroToOne";
            this.chkZeroToOne.Size = new System.Drawing.Size(55, 17);
            this.chkZeroToOne.TabIndex = 16;
            this.chkZeroToOne.Text = "U[0,1]";
            this.chkZeroToOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimulationTest";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZ0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbRandomNumbers;
        private System.Windows.Forms.CheckBox chkZeroToOne;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

