namespace R_test_1
{
    partial class frm1
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
            this.txtboxFName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtboxRCommands = new System.Windows.Forms.TextBox();
            this.lblRCmdBox = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtboxResults = new System.Windows.Forms.TextBox();
            this.lblRResults = new System.Windows.Forms.Label();
            this.btnClearResults = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnTestCode = new System.Windows.Forms.Button();
            this.txtRunRFile = new System.Windows.Forms.TextBox();
            this.btnRunPgm = new System.Windows.Forms.Button();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.ofdRPath = new System.Windows.Forms.OpenFileDialog();
            this.btnExamples = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxFName
            // 
            this.txtboxFName.Location = new System.Drawing.Point(12, 12);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(669, 20);
            this.txtboxFName.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(687, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtboxRCommands
            // 
            this.txtboxRCommands.Location = new System.Drawing.Point(12, 263);
            this.txtboxRCommands.Multiline = true;
            this.txtboxRCommands.Name = "txtboxRCommands";
            this.txtboxRCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxRCommands.Size = new System.Drawing.Size(365, 146);
            this.txtboxRCommands.TabIndex = 3;
            this.txtboxRCommands.TextChanged += new System.EventHandler(this.txtboxRCommands_TextChanged);
            // 
            // lblRCmdBox
            // 
            this.lblRCmdBox.AutoSize = true;
            this.lblRCmdBox.Location = new System.Drawing.Point(12, 247);
            this.lblRCmdBox.Name = "lblRCmdBox";
            this.lblRCmdBox.Size = new System.Drawing.Size(131, 13);
            this.lblRCmdBox.TabIndex = 4;
            this.lblRCmdBox.Text = "Enter R commands below:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(302, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 157);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtboxResults
            // 
            this.txtboxResults.Location = new System.Drawing.Point(397, 263);
            this.txtboxResults.Multiline = true;
            this.txtboxResults.Name = "txtboxResults";
            this.txtboxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxResults.Size = new System.Drawing.Size(365, 146);
            this.txtboxResults.TabIndex = 9;
            // 
            // lblRResults
            // 
            this.lblRResults.AutoSize = true;
            this.lblRResults.Location = new System.Drawing.Point(394, 247);
            this.lblRResults.Name = "lblRResults";
            this.lblRResults.Size = new System.Drawing.Size(51, 13);
            this.lblRResults.TabIndex = 10;
            this.lblRResults.Text = "R results:";
            // 
            // btnClearResults
            // 
            this.btnClearResults.Location = new System.Drawing.Point(687, 415);
            this.btnClearResults.Name = "btnClearResults";
            this.btnClearResults.Size = new System.Drawing.Size(75, 23);
            this.btnClearResults.TabIndex = 11;
            this.btnClearResults.Text = "Clear";
            this.btnClearResults.UseVisualStyleBackColor = true;
            this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(687, 41);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(75, 23);
            this.btnSession.TabIndex = 12;
            this.btnSession.Text = "Get Session";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnTestCode
            // 
            this.btnTestCode.Location = new System.Drawing.Point(687, 175);
            this.btnTestCode.Name = "btnTestCode";
            this.btnTestCode.Size = new System.Drawing.Size(75, 23);
            this.btnTestCode.TabIndex = 13;
            this.btnTestCode.Text = "Test Code";
            this.btnTestCode.UseVisualStyleBackColor = true;
            this.btnTestCode.Click += new System.EventHandler(this.btnTestCode_Click);
            // 
            // txtRunRFile
            // 
            this.txtRunRFile.Location = new System.Drawing.Point(12, 205);
            this.txtRunRFile.Name = "txtRunRFile";
            this.txtRunRFile.Size = new System.Drawing.Size(365, 20);
            this.txtRunRFile.TabIndex = 14;
            // 
            // btnRunPgm
            // 
            this.btnRunPgm.Location = new System.Drawing.Point(485, 205);
            this.btnRunPgm.Name = "btnRunPgm";
            this.btnRunPgm.Size = new System.Drawing.Size(75, 23);
            this.btnRunPgm.TabIndex = 15;
            this.btnRunPgm.Text = "Run r file";
            this.btnRunPgm.UseVisualStyleBackColor = true;
            this.btnRunPgm.Click += new System.EventHandler(this.btnRunPgm_Click);
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Location = new System.Drawing.Point(397, 205);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFileSearch.TabIndex = 16;
            this.btnFileSearch.Text = "Find R code";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.btnFileSearch_Click);
            // 
            // ofdRPath
            // 
            this.ofdRPath.FileName = "rfile";
            this.ofdRPath.InitialDirectory = "C:\\";
            // 
            // btnExamples
            // 
            this.btnExamples.Location = new System.Drawing.Point(150, 236);
            this.btnExamples.Name = "btnExamples";
            this.btnExamples.Size = new System.Drawing.Size(112, 23);
            this.btnExamples.TabIndex = 17;
            this.btnExamples.Text = "Click for examples";
            this.btnExamples.UseVisualStyleBackColor = true;
            this.btnExamples.Click += new System.EventHandler(this.btnExamples_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 448);
            this.Controls.Add(this.btnExamples);
            this.Controls.Add(this.btnFileSearch);
            this.Controls.Add(this.btnRunPgm);
            this.Controls.Add(this.txtRunRFile);
            this.Controls.Add(this.btnTestCode);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.btnClearResults);
            this.Controls.Add(this.lblRResults);
            this.Controls.Add(this.txtboxResults);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblRCmdBox);
            this.Controls.Add(this.txtboxRCommands);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtboxFName);
            this.Name = "frm1";
            this.Text = "EI7_R_test";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxFName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtboxRCommands;
        private System.Windows.Forms.Label lblRCmdBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtboxResults;
        private System.Windows.Forms.Label lblRResults;
        private System.Windows.Forms.Button btnClearResults;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnTestCode;
        private System.Windows.Forms.TextBox txtRunRFile;
        private System.Windows.Forms.Button btnRunPgm;
        private System.Windows.Forms.Button btnFileSearch;
        private System.Windows.Forms.OpenFileDialog ofdRPath;
        private System.Windows.Forms.Button btnExamples;
    }
}

