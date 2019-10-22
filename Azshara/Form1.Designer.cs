namespace Azshara
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
            this.btnRun = new System.Windows.Forms.Button();
            this.dgvSoaks = new System.Windows.Forms.DataGridView();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cboSwapIn = new System.Windows.Forms.ComboBox();
            this.cboSwapOut = new System.Windows.Forms.ComboBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.dgvPickTeam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1264, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 50);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // dgvSoaks
            // 
            this.dgvSoaks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSoaks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoaks.Location = new System.Drawing.Point(12, 12);
            this.dgvSoaks.Name = "dgvSoaks";
            this.dgvSoaks.Size = new System.Drawing.Size(669, 676);
            this.dgvSoaks.TabIndex = 1;
            // 
            // txtOutPut
            // 
            this.txtOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutPut.Location = new System.Drawing.Point(1264, 68);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(491, 620);
            this.txtOutPut.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1638, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // cboSwapIn
            // 
            this.cboSwapIn.FormattingEnabled = true;
            this.cboSwapIn.Location = new System.Drawing.Point(1511, 41);
            this.cboSwapIn.Name = "cboSwapIn";
            this.cboSwapIn.Size = new System.Drawing.Size(121, 21);
            this.cboSwapIn.TabIndex = 7;
            // 
            // cboSwapOut
            // 
            this.cboSwapOut.FormattingEnabled = true;
            this.cboSwapOut.Location = new System.Drawing.Point(1511, 12);
            this.cboSwapOut.Name = "cboSwapOut";
            this.cboSwapOut.Size = new System.Drawing.Size(121, 21);
            this.cboSwapOut.TabIndex = 8;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(1418, 17);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(54, 13);
            this.lblOut.TabIndex = 9;
            this.lblOut.Text = "Swap Out";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(1418, 44);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(46, 13);
            this.lblIn.TabIndex = 10;
            this.lblIn.Text = "Swap In";
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(1638, 39);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 11;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // dgvPickTeam
            // 
            this.dgvPickTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPickTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPickTeam.Location = new System.Drawing.Point(687, 12);
            this.dgvPickTeam.Name = "dgvPickTeam";
            this.dgvPickTeam.Size = new System.Drawing.Size(571, 676);
            this.dgvPickTeam.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 700);
            this.Controls.Add(this.dgvPickTeam);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.cboSwapOut);
            this.Controls.Add(this.cboSwapIn);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.dgvSoaks);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dgvSoaks;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cboSwapIn;
        private System.Windows.Forms.ComboBox cboSwapOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.DataGridView dgvPickTeam;
    }
}

