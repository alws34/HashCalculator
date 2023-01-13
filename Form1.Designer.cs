namespace ShaCalculator
{
    partial class frmShaCalculator
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
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHash2 = new System.Windows.Forms.TextBox();
            this.tbHash1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlRes = new System.Windows.Forms.Panel();
            this.lblRes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbConsole
            // 
            this.lbConsole.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.HorizontalScrollbar = true;
            this.lbConsole.Location = new System.Drawing.Point(415, 0);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(385, 412);
            this.lbConsole.TabIndex = 0;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(5, 22);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(394, 20);
            this.tbPath.TabIndex = 1;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbHash2);
            this.panel1.Controls.Add(this.tbHash1);
            this.panel1.Controls.Add(this.tbPath);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 144);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Compared Hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calculated Hash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FilePath";
            // 
            // tbHash2
            // 
            this.tbHash2.Location = new System.Drawing.Point(5, 115);
            this.tbHash2.Name = "tbHash2";
            this.tbHash2.Size = new System.Drawing.Size(394, 20);
            this.tbHash2.TabIndex = 3;
            this.tbHash2.TextChanged += new System.EventHandler(this.tbHash1_TextChanged);
            // 
            // tbHash1
            // 
            this.tbHash1.Location = new System.Drawing.Point(5, 67);
            this.tbHash1.Name = "tbHash1";
            this.tbHash1.Size = new System.Drawing.Size(394, 20);
            this.tbHash1.TabIndex = 2;
            this.tbHash1.TextChanged += new System.EventHandler(this.tbHash1_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(4, 356);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 52);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pnlRes
            // 
            this.pnlRes.Controls.Add(this.lblRes);
            this.pnlRes.Location = new System.Drawing.Point(116, 154);
            this.pnlRes.Name = "pnlRes";
            this.pnlRes.Size = new System.Drawing.Size(221, 99);
            this.pnlRes.TabIndex = 4;
            this.pnlRes.Visible = false;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(89, 39);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(29, 16);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "res";
            // 
            // frmShaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.pnlRes);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbConsole);
            this.Name = "frmShaCalculator";
            this.Text = "Sha Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRes.ResumeLayout(false);
            this.pnlRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHash2;
        private System.Windows.Forms.TextBox tbHash1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel pnlRes;
        private System.Windows.Forms.Label lblRes;
    }
}

