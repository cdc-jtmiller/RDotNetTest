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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxFName
            // 
            this.txtboxFName.Location = new System.Drawing.Point(12, 12);
            this.txtboxFName.Name = "txtboxFName";
            this.txtboxFName.Size = new System.Drawing.Size(391, 20);
            this.txtboxFName.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(430, 12);
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
            this.txtboxRCommands.Size = new System.Drawing.Size(493, 146);
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
            this.btnClear.Location = new System.Drawing.Point(328, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(430, 415);
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
            this.dataGridView1.Size = new System.Drawing.Size(493, 189);
            this.dataGridView1.TabIndex = 8;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 448);
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
    }
}

