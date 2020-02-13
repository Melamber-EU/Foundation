namespace Azshara
{
    partial class MainPage
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
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cboSwapIn = new System.Windows.Forms.ComboBox();
            this.cboSwapOut = new System.Windows.Forms.ComboBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.dgvPickTeam = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tabCSetup = new System.Windows.Forms.TabControl();
            this.tpBuilder = new System.Windows.Forms.TabPage();
            this.dgvSoaks = new System.Windows.Forms.DataGridView();
            this.tpLive = new System.Windows.Forms.TabPage();
            this.dgvLoad = new System.Windows.Forms.DataGridView();
            this.tpDemo = new System.Windows.Forms.TabPage();
            this.tpHivemind = new System.Windows.Forms.TabPage();
            this.chkRaidWarn = new System.Windows.Forms.CheckBox();
            this.btnImportHiveMind = new System.Windows.Forms.Button();
            this.btnExportHive = new System.Windows.Forms.Button();
            this.btnImportHive = new System.Windows.Forms.Button();
            this.btnGenerateHivemind = new System.Windows.Forms.Button();
            this.dgvHiveMind = new System.Windows.Forms.DataGridView();
            this.openFileDialogImportSheet = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpERT = new System.Windows.Forms.TabPage();
            this.btnExportERT = new System.Windows.Forms.Button();
            this.txtERT = new System.Windows.Forms.TextBox();
            this.btnImportERT = new System.Windows.Forms.Button();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.tpRoster = new System.Windows.Forms.TabPage();
            this.dgvRoster = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickTeam)).BeginInit();
            this.tabCSetup.SuspendLayout();
            this.tpBuilder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoaks)).BeginInit();
            this.tpLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoad)).BeginInit();
            this.tpHivemind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHiveMind)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpERT.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tpRoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1082, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 50);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutPut.Location = new System.Drawing.Point(1082, 68);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(448, 620);
            this.txtOutPut.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1456, 12);
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
            this.cboSwapIn.Location = new System.Drawing.Point(1329, 41);
            this.cboSwapIn.Name = "cboSwapIn";
            this.cboSwapIn.Size = new System.Drawing.Size(121, 21);
            this.cboSwapIn.TabIndex = 7;
            // 
            // cboSwapOut
            // 
            this.cboSwapOut.FormattingEnabled = true;
            this.cboSwapOut.Location = new System.Drawing.Point(1329, 12);
            this.cboSwapOut.Name = "cboSwapOut";
            this.cboSwapOut.Size = new System.Drawing.Size(121, 21);
            this.cboSwapOut.TabIndex = 8;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(1236, 17);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(54, 13);
            this.lblOut.TabIndex = 9;
            this.lblOut.Text = "Swap Out";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(1236, 44);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(46, 13);
            this.lblIn.TabIndex = 10;
            this.lblIn.Text = "Swap In";
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(1456, 39);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 11;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // dgvPickTeam
            // 
            this.dgvPickTeam.AllowUserToAddRows = false;
            this.dgvPickTeam.AllowUserToDeleteRows = false;
            this.dgvPickTeam.AllowUserToResizeColumns = false;
            this.dgvPickTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPickTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPickTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPickTeam.Location = new System.Drawing.Point(6, 32);
            this.dgvPickTeam.Name = "dgvPickTeam";
            this.dgvPickTeam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPickTeam.Size = new System.Drawing.Size(369, 561);
            this.dgvPickTeam.TabIndex = 12;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(525, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(606, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // tabCSetup
            // 
            this.tabCSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabCSetup.Controls.Add(this.tpBuilder);
            this.tabCSetup.Controls.Add(this.tpLive);
            this.tabCSetup.Controls.Add(this.tpDemo);
            this.tabCSetup.Controls.Add(this.tpHivemind);
            this.tabCSetup.Location = new System.Drawing.Point(12, 41);
            this.tabCSetup.Name = "tabCSetup";
            this.tabCSetup.SelectedIndex = 0;
            this.tabCSetup.Size = new System.Drawing.Size(669, 647);
            this.tabCSetup.TabIndex = 15;
            // 
            // tpBuilder
            // 
            this.tpBuilder.Controls.Add(this.dgvSoaks);
            this.tpBuilder.Location = new System.Drawing.Point(4, 22);
            this.tpBuilder.Name = "tpBuilder";
            this.tpBuilder.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuilder.Size = new System.Drawing.Size(661, 621);
            this.tpBuilder.TabIndex = 0;
            this.tpBuilder.Text = "Builder";
            this.tpBuilder.UseVisualStyleBackColor = true;
            // 
            // dgvSoaks
            // 
            this.dgvSoaks.AllowUserToAddRows = false;
            this.dgvSoaks.AllowUserToDeleteRows = false;
            this.dgvSoaks.AllowUserToResizeColumns = false;
            this.dgvSoaks.AllowUserToResizeRows = false;
            this.dgvSoaks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSoaks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoaks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoaks.Location = new System.Drawing.Point(6, 6);
            this.dgvSoaks.Name = "dgvSoaks";
            this.dgvSoaks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSoaks.Size = new System.Drawing.Size(649, 609);
            this.dgvSoaks.TabIndex = 2;
            // 
            // tpLive
            // 
            this.tpLive.Controls.Add(this.dgvLoad);
            this.tpLive.Location = new System.Drawing.Point(4, 22);
            this.tpLive.Name = "tpLive";
            this.tpLive.Padding = new System.Windows.Forms.Padding(3);
            this.tpLive.Size = new System.Drawing.Size(661, 621);
            this.tpLive.TabIndex = 1;
            this.tpLive.Text = "Live";
            this.tpLive.UseVisualStyleBackColor = true;
            // 
            // dgvLoad
            // 
            this.dgvLoad.AllowUserToAddRows = false;
            this.dgvLoad.AllowUserToDeleteRows = false;
            this.dgvLoad.AllowUserToResizeColumns = false;
            this.dgvLoad.AllowUserToResizeRows = false;
            this.dgvLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLoad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoad.Location = new System.Drawing.Point(6, 6);
            this.dgvLoad.Name = "dgvLoad";
            this.dgvLoad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLoad.Size = new System.Drawing.Size(649, 609);
            this.dgvLoad.TabIndex = 3;
            // 
            // tpDemo
            // 
            this.tpDemo.Location = new System.Drawing.Point(4, 22);
            this.tpDemo.Name = "tpDemo";
            this.tpDemo.Padding = new System.Windows.Forms.Padding(3);
            this.tpDemo.Size = new System.Drawing.Size(661, 621);
            this.tpDemo.TabIndex = 2;
            this.tpDemo.Text = "Demo";
            this.tpDemo.UseVisualStyleBackColor = true;
            // 
            // tpHivemind
            // 
            this.tpHivemind.Controls.Add(this.chkRaidWarn);
            this.tpHivemind.Controls.Add(this.btnImportHiveMind);
            this.tpHivemind.Controls.Add(this.btnExportHive);
            this.tpHivemind.Controls.Add(this.btnImportHive);
            this.tpHivemind.Controls.Add(this.btnGenerateHivemind);
            this.tpHivemind.Controls.Add(this.dgvHiveMind);
            this.tpHivemind.Location = new System.Drawing.Point(4, 22);
            this.tpHivemind.Name = "tpHivemind";
            this.tpHivemind.Padding = new System.Windows.Forms.Padding(3);
            this.tpHivemind.Size = new System.Drawing.Size(661, 621);
            this.tpHivemind.TabIndex = 3;
            this.tpHivemind.Text = "Hivemind";
            this.tpHivemind.UseVisualStyleBackColor = true;
            // 
            // chkRaidWarn
            // 
            this.chkRaidWarn.AutoSize = true;
            this.chkRaidWarn.Location = new System.Drawing.Point(6, 12);
            this.chkRaidWarn.Name = "chkRaidWarn";
            this.chkRaidWarn.Size = new System.Drawing.Size(96, 17);
            this.chkRaidWarn.TabIndex = 8;
            this.chkRaidWarn.Text = "Raid Warnings";
            this.chkRaidWarn.UseVisualStyleBackColor = true;
            // 
            // btnImportHiveMind
            // 
            this.btnImportHiveMind.Location = new System.Drawing.Point(293, 3);
            this.btnImportHiveMind.Name = "btnImportHiveMind";
            this.btnImportHiveMind.Size = new System.Drawing.Size(75, 23);
            this.btnImportHiveMind.TabIndex = 7;
            this.btnImportHiveMind.Text = "Setup";
            this.btnImportHiveMind.UseVisualStyleBackColor = true;
            this.btnImportHiveMind.Click += new System.EventHandler(this.btnImportHiveMind_Click);
            // 
            // btnExportHive
            // 
            this.btnExportHive.Location = new System.Drawing.Point(455, 3);
            this.btnExportHive.Name = "btnExportHive";
            this.btnExportHive.Size = new System.Drawing.Size(75, 23);
            this.btnExportHive.TabIndex = 6;
            this.btnExportHive.Text = "Export";
            this.btnExportHive.UseVisualStyleBackColor = true;
            this.btnExportHive.Click += new System.EventHandler(this.btnExportHive_Click);
            // 
            // btnImportHive
            // 
            this.btnImportHive.Location = new System.Drawing.Point(374, 3);
            this.btnImportHive.Name = "btnImportHive";
            this.btnImportHive.Size = new System.Drawing.Size(75, 23);
            this.btnImportHive.TabIndex = 5;
            this.btnImportHive.Text = "Import";
            this.btnImportHive.UseVisualStyleBackColor = true;
            this.btnImportHive.Click += new System.EventHandler(this.btnImportHive_Click);
            // 
            // btnGenerateHivemind
            // 
            this.btnGenerateHivemind.Location = new System.Drawing.Point(590, 3);
            this.btnGenerateHivemind.Name = "btnGenerateHivemind";
            this.btnGenerateHivemind.Size = new System.Drawing.Size(65, 23);
            this.btnGenerateHivemind.TabIndex = 4;
            this.btnGenerateHivemind.Text = "Generate";
            this.btnGenerateHivemind.UseVisualStyleBackColor = true;
            this.btnGenerateHivemind.Click += new System.EventHandler(this.btnGenerateHivemind_Click);
            // 
            // dgvHiveMind
            // 
            this.dgvHiveMind.AllowUserToResizeColumns = false;
            this.dgvHiveMind.AllowUserToResizeRows = false;
            this.dgvHiveMind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHiveMind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHiveMind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHiveMind.Location = new System.Drawing.Point(6, 35);
            this.dgvHiveMind.Name = "dgvHiveMind";
            this.dgvHiveMind.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHiveMind.Size = new System.Drawing.Size(649, 580);
            this.dgvHiveMind.TabIndex = 3;
            // 
            // openFileDialogImportSheet
            // 
            this.openFileDialogImportSheet.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpERT);
            this.tabControl1.Controls.Add(this.tpInfo);
            this.tabControl1.Controls.Add(this.tpRoster);
            this.tabControl1.Location = new System.Drawing.Point(687, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 647);
            this.tabControl1.TabIndex = 16;
            // 
            // tpERT
            // 
            this.tpERT.Controls.Add(this.txtTitle);
            this.tpERT.Controls.Add(this.btnExportERT);
            this.tpERT.Controls.Add(this.txtERT);
            this.tpERT.Controls.Add(this.btnImportERT);
            this.tpERT.Location = new System.Drawing.Point(4, 22);
            this.tpERT.Name = "tpERT";
            this.tpERT.Padding = new System.Windows.Forms.Padding(3);
            this.tpERT.Size = new System.Drawing.Size(381, 621);
            this.tpERT.TabIndex = 2;
            this.tpERT.Text = "ERT Note";
            this.tpERT.UseVisualStyleBackColor = true;
            // 
            // btnExportERT
            // 
            this.btnExportERT.Location = new System.Drawing.Point(87, 3);
            this.btnExportERT.Name = "btnExportERT";
            this.btnExportERT.Size = new System.Drawing.Size(75, 23);
            this.btnExportERT.TabIndex = 10;
            this.btnExportERT.Text = "Export";
            this.btnExportERT.UseVisualStyleBackColor = true;
            this.btnExportERT.Click += new System.EventHandler(this.BtnExportERT_Click);
            // 
            // txtERT
            // 
            this.txtERT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtERT.Location = new System.Drawing.Point(6, 32);
            this.txtERT.Multiline = true;
            this.txtERT.Name = "txtERT";
            this.txtERT.Size = new System.Drawing.Size(369, 583);
            this.txtERT.TabIndex = 17;
            // 
            // btnImportERT
            // 
            this.btnImportERT.Location = new System.Drawing.Point(6, 3);
            this.btnImportERT.Name = "btnImportERT";
            this.btnImportERT.Size = new System.Drawing.Size(75, 23);
            this.btnImportERT.TabIndex = 9;
            this.btnImportERT.Text = "Import";
            this.btnImportERT.UseVisualStyleBackColor = true;
            this.btnImportERT.Click += new System.EventHandler(this.btnImportERT_Click);
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.btnSave);
            this.tpInfo.Controls.Add(this.dgvPickTeam);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(381, 621);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // tpRoster
            // 
            this.tpRoster.Controls.Add(this.dgvRoster);
            this.tpRoster.Location = new System.Drawing.Point(4, 22);
            this.tpRoster.Name = "tpRoster";
            this.tpRoster.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoster.Size = new System.Drawing.Size(381, 621);
            this.tpRoster.TabIndex = 1;
            this.tpRoster.Text = "Roster";
            this.tpRoster.UseVisualStyleBackColor = true;
            // 
            // dgvRoster
            // 
            this.dgvRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoster.Location = new System.Drawing.Point(7, 7);
            this.dgvRoster.Name = "dgvRoster";
            this.dgvRoster.Size = new System.Drawing.Size(368, 586);
            this.dgvRoster.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(168, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(207, 20);
            this.txtTitle.TabIndex = 18;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabCSetup);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.cboSwapOut);
            this.Controls.Add(this.cboSwapIn);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnRun);
            this.Name = "MainPage";
            this.Text = "WA Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickTeam)).EndInit();
            this.tabCSetup.ResumeLayout(false);
            this.tpBuilder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoaks)).EndInit();
            this.tpLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoad)).EndInit();
            this.tpHivemind.ResumeLayout(false);
            this.tpHivemind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHiveMind)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpERT.ResumeLayout(false);
            this.tpERT.PerformLayout();
            this.tpInfo.ResumeLayout(false);
            this.tpRoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cboSwapIn;
        private System.Windows.Forms.ComboBox cboSwapOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.DataGridView dgvPickTeam;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TabControl tabCSetup;
        private System.Windows.Forms.TabPage tpBuilder;
        private System.Windows.Forms.DataGridView dgvSoaks;
        private System.Windows.Forms.TabPage tpLive;
        private System.Windows.Forms.DataGridView dgvLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportSheet;
        private System.Windows.Forms.TabPage tpDemo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpRoster;
        private System.Windows.Forms.DataGridView dgvRoster;
        private System.Windows.Forms.TabPage tpHivemind;
        private System.Windows.Forms.Button btnGenerateHivemind;
        private System.Windows.Forms.DataGridView dgvHiveMind;
        private System.Windows.Forms.Button btnExportHive;
        private System.Windows.Forms.Button btnImportHive;
        private System.Windows.Forms.Button btnImportHiveMind;
        private System.Windows.Forms.CheckBox chkRaidWarn;
        private System.Windows.Forms.TabPage tpERT;
        private System.Windows.Forms.TextBox txtERT;
        private System.Windows.Forms.Button btnExportERT;
        private System.Windows.Forms.Button btnImportERT;
        private System.Windows.Forms.TextBox txtTitle;
    }
}

