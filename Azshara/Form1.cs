﻿using Azshara.Models;
using Azshara.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Azshara
{
    public partial class MainPage : Form
    {
        DataTable dtTimers = new DataTable();
        DataTable dtRaiders = new DataTable();
        DataTable dtSetup = new DataTable();
        DataTable dtLiveTeam = new DataTable();
        DataSet dataSet = new DataSet();
        string header = "";
        string midd = "";
        public MainPage()
        {
            InitializeComponent();
            dataSet.Tables.Add(dtSetup);
#if DEBUG
            btnCheck.Visible = true;
#else
    btnCheck.Visible = false;
#endif
            GenerateTeamPicker();
            GenerateHeader();
            GenerateMid();
            SetupGrid();
            LoadData();
            dgvSoaks.DataSource = dtTimers;
            List<RaidersM> swapOutRaidersModels = new List<RaidersM>(RaidersModels.GetRaiders());
            List<RaidersM> swapInListRaidersModels = new List<RaidersM>(RaidersModels.GetRaiders());
            cboSwapIn.DataSource = swapInListRaidersModels;
            cboSwapIn.ValueMember = "name";
            cboSwapOut.DataSource = swapOutRaidersModels;
            cboSwapOut.ValueMember = "name";
        }

        private void GenerateTeamPicker()
        {
            List<RaidersM> raidTeam = new List<RaidersM>(RaidersModels.GetRaiders());
            DataGridViewCheckBoxColumn chkCol1 = new DataGridViewCheckBoxColumn();
            
            chkCol1.HeaderText = "Picked";
            chkCol1.Name = "enabled";
            dtLiveTeam.Columns.Add("Raider",typeof(string));
            dtLiveTeam.Columns.Add("Debuff End", typeof(int));
            foreach (var record in raidTeam)
            {
                if (record.name == "")
                { }
                else
                {
                    DataRow dRow = dtLiveTeam.NewRow();
                    dRow[0] = record.name;

                    dtLiveTeam.Rows.Add(dRow);
                    
                }
                
            }
            dtLiveTeam.Columns.Add("Pick", typeof(bool));
            //dtLiveTeam.AcceptChanges;
            dgvPickTeam.DataSource = dtLiveTeam;
            
        }

        private void GenerateMid()
        {
            midd = "";
            midd = midd + "sound1 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound2 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound3 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound4 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound5 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound6 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound7 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "sound8 = \"Interface\\AddOns\\WeakAuras\\Media\\Sounds\\Circle.ogg\"" + Environment.NewLine;
            midd = midd + "channel = \"Master\"--Channel to play through\"" + Environment.NewLine;
            midd = midd + "--Don't edit below unless you want to assign different sounds and duration" + Environment.NewLine;
            midd = midd + "tval = ceil((GetTime() - aura_env.timer))" + Environment.NewLine;
        }

        private void GenerateHeader()
        {
            header = "";
            header = header + "function()" + Environment.NewLine;
            header = header + "test = \"false\"" + Environment.NewLine;
            header = header + "if test == \"true\"" + Environment.NewLine;
            header = header + "then" + Environment.NewLine;
            header = header + "cd01_time = 5" + Environment.NewLine;
            header = header + "cd02_time = 10" + Environment.NewLine;
            header = header + "cd03_time = 15" + Environment.NewLine;
            header = header + "cd04_time = 20" + Environment.NewLine;
            header = header + "cd05_time = 25" + Environment.NewLine;
            header = header + "cd06_time = 30" + Environment.NewLine;
            header = header + "cd07_time = 35" + Environment.NewLine;
            header = header + "cd08_time = 40" + Environment.NewLine;
            header = header + "cd09_time = 45" + Environment.NewLine;
            header = header + "else " + Environment.NewLine;
        }

        private void SetupGrid()
        {
            dtRaiders.Columns.Add("name", typeof(string));                        
            dtTimers.Columns.Add("Timer", typeof(double));
            dtTimers.Columns.Add("Soak", typeof(double));

            DataGridViewComboBoxColumn cmb1 = new DataGridViewComboBoxColumn();
            cmb1.HeaderText = "Select Raider";
            cmb1.Name = "name1";
            cmb1.DataSource = dtRaiders;
            cmb1.ValueMember = "name";

            DataGridViewComboBoxColumn cmb2 = new DataGridViewComboBoxColumn();
            cmb2.HeaderText = "Select Raider";
            cmb2.Name = "name2";
            cmb2.DataSource = dtRaiders;
            cmb2.ValueMember = "name";

            DataGridViewComboBoxColumn cmb3 = new DataGridViewComboBoxColumn();
            cmb3.HeaderText = "Select Raider";
            cmb3.Name = "name3";
            cmb3.DataSource = dtRaiders;
            cmb3.ValueMember = "name";

            DataGridViewComboBoxColumn cmb4 = new DataGridViewComboBoxColumn();
            cmb4.HeaderText = "Select Raider";
            cmb4.Name = "name4";
            cmb4.DataSource = dtRaiders;
            cmb4.ValueMember = "name";

            DataGridViewComboBoxColumn cmb5 = new DataGridViewComboBoxColumn();
            cmb5.HeaderText = "Select Raider";
            cmb5.Name = "name5";
            cmb5.DataSource = dtRaiders;
            cmb5.ValueMember = "name";

            dgvSoaks.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvSoaks_EditingControlShowing);
            dgvSoaks.CellValueChanged += new DataGridViewCellEventHandler(dgvSoaks_CellValueChanged);
            dgvSoaks.CurrentCellDirtyStateChanged += new EventHandler(dgvSoaks_CurrentCellDirtyStateChanged);
            
            dgvSoaks.Columns.Add(cmb1);
            dgvSoaks.Columns.Add(cmb2);
            dgvSoaks.Columns.Add(cmb3);
            dgvSoaks.Columns.Add(cmb4);
            dgvSoaks.Columns.Add(cmb5);

            //DataGridViewTextBoxColumn counter = new DataGridViewTextBoxColumn();
            //counter.HeaderText = "Soak No.";
            //counter.Name = "counter";
            //int countVal = 0;
            //foreach (DataGridViewRow cRow in dgvSoaks.Rows)
            //{
            //    cRow.Cells[6].Value = countVal + 1;
            //    countVal = countVal + 1;
            //}
            //dgvSoaks.Columns.Add(counter);
        }

        private void dgvSoaks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSoaks.IsCurrentCellDirty)
            {
                dgvSoaks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvSoaks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            { }
            else
            {
                DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dgvSoaks.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cb.Value != null)
                {
                    try {
                        string nameR = cb.Value.ToString();                        
                        dtSetup = new DataTable();
                        foreach (DataGridViewColumn col in dgvSoaks.Columns)
                        {
                            dtSetup.Columns.Add(col.Name);
                        }
                        foreach (DataGridViewRow row in dgvSoaks.Rows)
                        {
                            DataRow dRow = dtSetup.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                            }
                            dtSetup.Rows.Add(dRow);
                        }
                        int liveRowTime = Convert.ToInt32(dgvSoaks.Rows[e.RowIndex].Cells[5].Value);
                        int liveDebuffStart = 120 + liveRowTime;
                        
                        foreach (DataRow liveRow in dtLiveTeam.Rows)
                        {
                            if (liveRow.ItemArray[0].ToString() == nameR)
                            {
                                liveRow[1] = liveDebuffStart;
                            }
                            //dtLiveTeam.AcceptChanges();
                        }
                        //dgvPickTeam.Refresh();
                        foreach (DataRow row in dtSetup.Rows)
                        {
                            if (nameR == row.ItemArray[0].ToString() || nameR == row.ItemArray[1].ToString() || 
                                nameR == row.ItemArray[2].ToString() || nameR == row.ItemArray[3].ToString() || 
                                nameR == row.ItemArray[4].ToString())
                            {
                                int rowTime = Convert.ToInt32(dgvSoaks.Rows[e.RowIndex].Cells[5].Value);
                                int timeAssigned = Convert.ToInt32(row.ItemArray[5]);
                                int expireDebuff = timeAssigned + 120;
                                int index = dtSetup.Rows.IndexOf(row);
                                if (rowTime <= expireDebuff && e.RowIndex != index)
                                {
                                    MessageBox.Show("Error", "Previous Debuff Still Active");
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }

        private void dgvSoaks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            CreateBase();
            DoWorkCreateWeakaura();
        }
        List<SetCounter> setCounters = new List<SetCounter>();
        private void CreateBase()
        {
            setCounters.Clear();
            cdTimersString = "";
            cdRaidersString = "";
            dtSetup = new DataTable();
            foreach (DataGridViewColumn col in dgvSoaks.Columns)
            {
                dtSetup.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dgvSoaks.Rows)
            {
                DataRow dRow = dtSetup.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dtSetup.Rows.Add(dRow);
            }
            int counter = 0;
            foreach (DataRow dtRowOut in dtSetup.Rows)
            {
                //Console.WriteLine(dtRowOut.ItemArray[0] + " : " + dtRowOut.ItemArray[1] + " : " + dtRowOut.ItemArray[2] + " : " + dtRowOut.ItemArray[3] + " : " + dtRowOut.ItemArray[4] + " : " + dtRowOut.ItemArray[5]);
                int rowCount = dtSetup.Rows.Count;
                counter = counter + 1;
                if (counter >= 38)
                {
                    return;
                }
                //Console.WriteLine(counter.ToString() + " :: " + rowCount.ToString());
                cdTimers("cd0" + counter.ToString() + "_time = " + dtRowOut.ItemArray[5]);
                cdRaiders("cd0" + counter.ToString() + "_text = \"" + dtRowOut.ItemArray[0] + "," + dtRowOut.ItemArray[1] + "," + dtRowOut.ItemArray[2] + "," + dtRowOut.ItemArray[3] + "," + dtRowOut.ItemArray[4] + "\"");
                setCounters.Add(new SetCounter
                {
                    SetC1T = "cd0" + counter.ToString() +"_time",
                    SetC1R = "cd0" + counter.ToString() + "_text",
                });
            }
            dgvLoad.DataSource = dtSetup;
        }

        string cdTimersString = "";
        public void cdTimers(string input)
        {
            cdTimersString = cdTimersString + System.Environment.NewLine + input;
        }
        string cdRaidersString = "";
        public void cdRaiders(string input)
        {
            cdRaidersString = cdRaidersString + System.Environment.NewLine + input;
        }
        string output = "";

        public string ImportFileNameXML { get; private set; }

        public void DoWorkCreateWeakaura()
        {
            output = "";
            output = header;
            output = header + cdTimersString + System.Environment.NewLine + "end" + Environment.NewLine + cdRaidersString + Environment.NewLine;
            output = output + Environment.NewLine + midd;
            int counter = 0;
            int totalCount = setCounters.Count;
            foreach (var row in setCounters)
            {
                counter = counter + 1;
                if (row.SetC1T == "cd01_time")
                {
                    string baseSetsOpener = CreateOpenerStat(row.SetC1T, row.SetC1R);
                    output = output + baseSetsOpener;
                }
                else
                {
                    //if (counter == totalCount)
                    //{
                    //    baseSetsMid = CreateLastStat(row.SetC1T, row.SetC1R);
                    //}
                    //else
                    //{
                    string baseSetsMid = CreateBaseStat(row.SetC1T, row.SetC1R);
                    //}

                    output = output + baseSetsMid;
                }
            }
            output = output + CreateFooter();
            txtOutPut.Text = output;
        }

        //private string CreateLastStat(string setC1T, string setC1R)
        //{
        //    string var = "";
        //    var = "elseif aura_env.timer and(tval > " + setC1T + " " + Environment.NewLine; // and tval < " + setC1T + " + 4)
        //    var = var + "then" + Environment.NewLine;
        //    var = var + "if not aura_env.soundPlayed then" + Environment.NewLine;
        //    var = var + "SendChatMessage(" + setC1R + ", \"RAID_WARNING\")" + Environment.NewLine;
        //    var = var + "aura_env.soundPlayed = true" + Environment.NewLine;
        //    var = var + "end" + Environment.NewLine;
        //    var = var + "return " + setC1R + Environment.NewLine;
        //    return var;
        //}

        private string CreateFooter()
        {
            string data = "";
            data = "elseif aura_env.timer and tval ~= "; //cd01_time and tval ~= cd02_time and tval ~= cd03_time and tval ~= cd04_time and tval ~= cd05_time and tval ~= cd06_time and tval ~= cd07_time and tval ~= cd08_time and tval ~= cd08_time and tval ~= cd09_time and tval ~= cd010_time and tval ~= cd011_time and tval ~= cd012_time and tval ~= cd013_time and tval ~= cd014_time and tval ~= cd015_time and tval ~= cd016_time and tval ~= cd017_time and tval ~= cd018_time and tval ~= cd019_time and tval ~= cd020_time and tval ~= cd021_time and tval ~= cd022_time and tval ~= cd023_time" + Environment.NewLine;
            int counter = 0;
            int total = setCounters.Count;
            foreach (var record in setCounters)
            {
                counter = counter + 1;
                if (counter == total)
                {
                    data = data + record.SetC1T + "";
                }
                else
                {
                    data = data + record.SetC1T + " and tval ~= ";
                }
                
            }
            data = data + Environment.NewLine;
            data = data + "then aura_env.soundPlayed = nil" + Environment.NewLine;
            data = data + "end" + Environment.NewLine;
            data = data + "if WeakAuras.IsOptionsOpen() then" + Environment.NewLine;
            data = data + "return \"Text Do Something\"" + Environment.NewLine;
            data = data + "end" + Environment.NewLine;
            data = data + "return \" \"" + Environment.NewLine;
            data = data + "end" + Environment.NewLine;
            return data;
        }

        private string CreateOpenerStat(string setC1T, string setC1R)
        {
            string var = "";
            var = "if aura_env.timer and(tval > " + setC1T + " and tval < " + setC1T + " + 4)" + Environment.NewLine;
            var = var + "then" + Environment.NewLine;
            var = var + "if not aura_env.soundPlayed then" + Environment.NewLine;
            var = var + "SendChatMessage(" + setC1R + ", \"RAID_WARNING\")" + Environment.NewLine;
            var = var + "aura_env.soundPlayed = true" + Environment.NewLine;
            var = var + "end" + Environment.NewLine;
            var = var + "return " + setC1R + Environment.NewLine;
            return var;
        }

        private string CreateBaseStat(string setC1T, string setC1R)
        {
            string var2 = "";
            var2 = "elseif aura_env.timer and(tval > " + setC1T + " and tval < " + setC1T + " + 4)" + Environment.NewLine;
            var2 = var2 + "then" + Environment.NewLine;
            var2 = var2 + "if not aura_env.soundPlayed then" + Environment.NewLine;
            var2 = var2 + "SendChatMessage(" + setC1R + ", \"RAID_WARNING\")" + Environment.NewLine;
            var2 = var2 + "aura_env.soundPlayed = true" + Environment.NewLine;
            var2 = var2 + "end" + Environment.NewLine;
            var2 = var2 + "return " + setC1R + Environment.NewLine;
            return var2;
        }

        private void BtnDefaultTimers_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            List<RaidersM> raidersMs = RaidersModels.GetRaiders();
            foreach (var record in raidersMs)
            {
                dtRaiders.Rows.Add(record.name);
            }
            List<Timers> timers = RaidersModels.GetTimers();
            foreach (var rec in timers)
            {
                dtTimers.Rows.Add(rec.timers, rec.soak);
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            dgvSoaks.CellClick -= DgvSoaks_RowEnter;
            dgvSoaks.CellValueChanged -= dgvSoaks_CellValueChanged;
            foreach (DataRow row in dtSetup.Rows)
            {
                int rowIndex = dtSetup.Rows.IndexOf(row);
                foreach (DataColumn col in dtSetup.Columns)
                {
                    int colIndex = dtSetup.Columns.IndexOf(col);
                    Console.WriteLine(row.ItemArray[colIndex]);

                    try
                    {
                        dgvSoaks.Rows[rowIndex].Cells[colIndex].Value = row.ItemArray[colIndex];
                    }
                    catch { }
                }
            }
            dgvSoaks.CellClick += DgvSoaks_RowEnter;
            dgvSoaks.CellValueChanged += dgvSoaks_CellValueChanged;
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            
            string swapOut = cboSwapOut.Text;
            string swapIn = cboSwapIn.Text;
            foreach (DataGridViewColumn col in dgvSoaks.Columns)
            {
                int colIndex = dgvSoaks.Columns.IndexOf(col);
                foreach (DataGridViewRow row in dgvSoaks.Rows)
                {
                    Console.WriteLine(row.Cells[colIndex].Value);
                    if (Convert.ToString(row.Cells[colIndex].Value) == swapOut)
                    {
                        row.Cells[colIndex].Value = swapIn;
                    }
                }
            }
            foreach (DataRow row in dtLiveTeam.Rows)
            {
                if (row.ItemArray[0].ToString() == swapOut)
                {
                    row[1] = 0;
                }
            }
            
        }

        private void DgvSoaks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////MessageBox.Show(e.RowIndex.ToString());
            //int selectedRow = Convert.ToInt32(e.RowIndex);
            ////foreach (DataGridViewColumn col in dgvSoaks.Columns)
            ////{
            ////    Console.WriteLine(col);
            ////}
            //dgvSoaks.CellClick -= DgvSoaks_CellClick;
            //foreach (DataGridViewRow row in dgvSoaks.Rows)
            //{
            //    if (row.Index == selectedRow)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            if (cell.Value != null)
            //            {
            //                Console.WriteLine(cell.Value.ToString());
            //            }
            //        }
            //    }
            //}
            //dgvSoaks.CellClick += DgvSoaks_CellClick;
        }

        private void DgvSoaks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = Convert.ToInt32(e.RowIndex);
            dgvSoaks.CellClick -= DgvSoaks_RowEnter;
            foreach (DataGridViewRow row in dgvSoaks.Rows)
            {
                if (row.Index == selectedRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                           // Console.WriteLine(cell.Value.ToString());

                        }
                    }
                }
            }
            dgvSoaks.CellClick += DgvSoaks_RowEnter;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataSet dsXml = new DataSet();
            try { dsXml.Tables.Add(dtSetup); }
            catch { }

            string strDsXml = dsXml.GetXml();
            string datetimenowSave = DateTime.Now.ToString();
            datetimenowSave = CleanFileName(datetimenowSave);
            string pathtosave = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string subPath = pathtosave + "\\Azshara"; // your code goes here

            Directory.CreateDirectory(subPath);

            string xmlFile = "SetUp" + datetimenowSave + ".xml";
            string savedFilePath = subPath + "\\" + xmlFile;
            using (StreamWriter fs = new StreamWriter(savedFilePath)) // XML File Path
            {
                dtSetup.WriteXml(fs, XmlWriteMode.WriteSchema);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string pathtosave = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string subPath = pathtosave + "\\Azshara";
                openFileDialogImportSheet.InitialDirectory = subPath;
            }
            catch { }
            DialogResult result = openFileDialogImportSheet.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                ImportFileNameXML = openFileDialogImportSheet.FileName;
                dtSetup.Clear();
                DataSet dsXml = new DataSet();
                try { dsXml.Tables.Add(dtSetup); }
                catch { }
                dtSetup.ReadXml(ImportFileNameXML);
                dgvLoad.DataSource = dtSetup;
                dgvLoad.Refresh();
                //dgvLoad.Sort(dgvLoad.Columns["Row"], ListSortDirection.Ascending);
            }
            //Console.WriteLine(result);
        }
        private static string CleanFileName(string fileName)
        {
            return Regex.Replace(fileName, "[^a-zA-Z0-9_]+", "_", RegexOptions.Compiled);
        }
    }
}
