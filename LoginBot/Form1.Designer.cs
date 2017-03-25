namespace LoginBot
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StopBTN = new System.Windows.Forms.Button();
            this.ServerAdrsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AccountListRTB = new System.Windows.Forms.RichTextBox();
            this.SelectDataFileBTN = new System.Windows.Forms.Button();
            this.reCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.AccountListFileOFD = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.61172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.38828F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.2028F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.7972F));
            this.tableLayoutPanel2.Controls.Add(this.StopBTN, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ServerAdrsCB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StartBTN, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // StopBTN
            // 
            this.StopBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopBTN.Enabled = false;
            this.StopBTN.Location = new System.Drawing.Point(3, 28);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(129, 21);
            this.StopBTN.TabIndex = 3;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // ServerAdrsCB
            // 
            this.ServerAdrsCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerAdrsCB.FormattingEnabled = true;
            this.ServerAdrsCB.Items.AddRange(new object[] {
            "http://hotspot2.znu.ac.ir/login",
            "http://hotspot1.znu.ac.ir/login"});
            this.ServerAdrsCB.Location = new System.Drawing.Point(138, 3);
            this.ServerAdrsCB.Name = "ServerAdrsCB";
            this.ServerAdrsCB.Size = new System.Drawing.Size(145, 21);
            this.ServerAdrsCB.TabIndex = 0;
            this.ServerAdrsCB.Text = "http://hotspot2.znu.ac.ir/login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Address";
            // 
            // StartBTN
            // 
            this.StartBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartBTN.Enabled = false;
            this.StartBTN.Location = new System.Drawing.Point(138, 28);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(145, 21);
            this.StartBTN.TabIndex = 2;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.AccountListRTB, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.SelectDataFileBTN, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(286, 209);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // AccountListRTB
            // 
            this.AccountListRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountListRTB.Enabled = false;
            this.AccountListRTB.Location = new System.Drawing.Point(3, 32);
            this.AccountListRTB.Name = "AccountListRTB";
            this.AccountListRTB.Size = new System.Drawing.Size(280, 174);
            this.AccountListRTB.TabIndex = 2;
            this.AccountListRTB.Text = "";
            // 
            // SelectDataFileBTN
            // 
            this.SelectDataFileBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectDataFileBTN.Location = new System.Drawing.Point(3, 3);
            this.SelectDataFileBTN.Name = "SelectDataFileBTN";
            this.SelectDataFileBTN.Size = new System.Drawing.Size(280, 23);
            this.SelectDataFileBTN.TabIndex = 3;
            this.SelectDataFileBTN.Text = "Select Data File";
            this.SelectDataFileBTN.UseVisualStyleBackColor = true;
            this.SelectDataFileBTN.Click += new System.EventHandler(this.SelectDataFileBTN_Click);
            // 
            // reCheckTimer
            // 
            this.reCheckTimer.Interval = 5000;
            this.reCheckTimer.Tick += new System.EventHandler(this.reCheckTimer_Tick);
            // 
            // AccountListFileOFD
            // 
            this.AccountListFileOFD.Filter = "TXT files|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.ComboBox ServerAdrsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Timer reCheckTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox AccountListRTB;
        private System.Windows.Forms.Button SelectDataFileBTN;
        private System.Windows.Forms.OpenFileDialog AccountListFileOFD;

    }
}

