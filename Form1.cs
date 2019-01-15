using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//TeamSize
//Team0Score
//Team1Score
//Goals
//HighLights
//PlayerStats
//- Name
//- Platform
//- OnlineID
//- Team
//- Score
//- Goals
//- Assists
//- Saves
//- Shots
//- bBot
//ReplayName
//ReplayVersion
//GameVersion
//BuildID
//Changelist
//BuildVersion
//RecordFPS
//KeyframeDelay
//MaxChannels
//MaxReplaySizeMB
//Id
//MapName
//Date
//NumFrames
//MatchType
//PlayerName

namespace RL_ReplayManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.ReplayList_dataGridView.SelectionChanged += ReplayList_dataGridView_SelectionChanged;
            this.UploadVisibility_comboBox.TextChanged += UploadVisibility_comboBox_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetPlayerStatsGrid();
            RefreshReplayList();
        }

        //
        //EVENTS
        //

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //e.Cancel = true;
            //this.Hide();
        }

        //selected replay changes
        private void ReplayList_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            UpdatePlayerStatsGrid();
        }

        private void UploadVisibility_comboBox_TextChanged(object sender, EventArgs e)
        {
            Upload_button.Enabled = true;
        }

        //
        //FUNCTIONS
        //

        //--Logger--
        public void LogAddText(string text)
        {
            Log_textBox.AppendText(text);
        }
        public void LogClear()
        {
            Log_textBox.Text = "-----> Logger <-----";
        }

        public string ReadToken()
        {
            return Token_textBox.Text;
        }

        //--Grids--
        private Task RRL;
        public static Dictionary<string, RocketLeagueReplayParser.PropertyDictionary> SavedReplayInfo = new Dictionary<string, RocketLeagueReplayParser.PropertyDictionary>();
        public void RefreshReplayList()
        {
            if (RRL != null)
                return;

            this.ReplayLRefresh_button.Enabled = false;

            RRL = Task.Factory.StartNew(() =>
            {

                this.InvokeEx(f => f.ReplayList_dataGridView.Rows.Clear());

                string SourcePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Rocket League\TAGame\Demos";

                if (!Directory.Exists(SourcePath))
                    return;

                int ReplayFiles_max = Directory.GetFiles(SourcePath).Length;

                this.InvokeEx(f => f.ReplayLoad_progressBar.Minimum = 0);
                this.InvokeEx(f => f.ReplayLoad_progressBar.Maximum = ReplayFiles_max);

                SavedReplayInfo.Clear();

                int ReplayFiles_current = 0;
                foreach (string newPath in Directory.GetFiles(SourcePath))
                {
                    string fileName = newPath.Replace(SourcePath + @"\", "");

                    RocketLeagueReplayParser.PropertyDictionary replayInfo = RocketLeagueReplayParser.Replay.Deserialize(newPath).Properties;

                    SavedReplayInfo.Add(fileName, replayInfo);

                    if (replayInfo.ContainsKey("ReplayName") && replayInfo.ContainsKey("Date") && replayInfo.ContainsKey("TeamSize"))
                    {
                        this.InvokeEx(f => f.ReplayList_dataGridView.Rows.Add(new object[] { replayInfo["ReplayName"], replayInfo["Date"], replayInfo["TeamSize"] + "v" + replayInfo["MatchType"], fileName }));
                    }

                    //set current progressbar
                    ReplayFiles_current++;

                    this.InvokeEx(f => f.ReplayLoad_progressBar.Value = ReplayFiles_current);
                }
                RRL = null;
                this.InvokeEx(f => { f.UpdatePlayerStatsGrid();
                f.ReplayLRefresh_button.Enabled = true;
                f.ReplayLoad_progressBar.Value = 0; });
            });
        }

        private void ResetPlayerStatsGrid()
        {

            object TeamBGoals = "0";
            object TeamRGoals = "0";

            if (ReplayList_dataGridView.SelectedRows.Count >= 1)
            {
                string fileName = (string)ReplayList_dataGridView.SelectedRows[0].Cells[3].Value;

                if(SavedReplayInfo[fileName].ContainsKey("Team0Score"))
                    TeamBGoals = SavedReplayInfo[fileName]["Team0Score"];

                if (SavedReplayInfo[fileName].ContainsKey("Team1Score"))
                    TeamRGoals = SavedReplayInfo[fileName]["Team1Score"];
            }

            //replay blue setup
            ReplayBlue_dataGridView.Rows.Clear();
            ReplayBlue_dataGridView.Rows.Add(new object[] { TeamBGoals, "Score", "Goals", "Assists", "Saves", "Shots" });
            ReplayBlue_dataGridView.Rows[0].DefaultCellStyle.BackColor = Color.DarkBlue;
            ReplayBlue_dataGridView.Rows[0].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

            //replay red setup
            ReplayRed_dataGridView.Rows.Clear();
            ReplayRed_dataGridView.Rows.Add(new object[] { TeamRGoals, "Score", "Goals", "Assists", "Saves", "Shots" });
            ReplayRed_dataGridView.Rows[0].DefaultCellStyle.BackColor = Color.DarkRed;
            ReplayRed_dataGridView.Rows[0].DefaultCellStyle.SelectionBackColor = Color.DarkRed;

        }

        private void UpdatePlayerStatsGrid()
        {
            ResetPlayerStatsGrid();

            if (ReplayList_dataGridView.SelectedRows.Count < 1)
                return;

            string fileName = (string)ReplayList_dataGridView.SelectedRows[0].Cells[3].Value;
            int StatsCount = ((RocketLeagueReplayParser.ArrayProperty)SavedReplayInfo[fileName]["PlayerStats"]).Count();

            foreach (int PlayerNumb in Enumerable.Range(0, StatsCount)) {
                
                RocketLeagueReplayParser.ArrayProperty PlayerStats = (RocketLeagueReplayParser.ArrayProperty) SavedReplayInfo[fileName]["PlayerStats"];
                
                if (PlayerStats[PlayerNumb]["Team"].ToString() == "0")
                {
                    object PlayerName = PlayerStats[PlayerNumb]["Name"];
                    int rowNumb = ReplayBlue_dataGridView.Rows.Add(new object[] { PlayerName, PlayerStats[PlayerNumb]["Score"], PlayerStats[PlayerNumb]["Goals"], PlayerStats[PlayerNumb]["Assists"], PlayerStats[PlayerNumb]["Saves"], PlayerStats[PlayerNumb]["Shots"] });
                    ReplayBlue_dataGridView.Rows[rowNumb].DefaultCellStyle.ForeColor = Color.Black;
                    ReplayBlue_dataGridView.Rows[rowNumb].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (PlayerStats[PlayerNumb]["Team"].ToString() == "1")
                {
                    object PlayerName = PlayerStats[PlayerNumb]["Name"];
                    int rowNumb = ReplayRed_dataGridView.Rows.Add(new object[] { PlayerName, PlayerStats[PlayerNumb]["Score"], PlayerStats[PlayerNumb]["Goals"], PlayerStats[PlayerNumb]["Assists"], PlayerStats[PlayerNumb]["Saves"], PlayerStats[PlayerNumb]["Shots"] });
                    ReplayRed_dataGridView.Rows[rowNumb].DefaultCellStyle.ForeColor = Color.Black;
                    ReplayRed_dataGridView.Rows[rowNumb].DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        //
        //BUTTONS
        //

        private async void Ping_button_Click(object sender, EventArgs e)
        {
            LogAddText(Environment.NewLine + "> Waiting for response...");
            await BallChasing.PingAsync();

        }

        private void LogClear_button_Click(object sender, EventArgs e)
        {
            LogClear();
        }

        private void ReplayLRefresh_button_Click(object sender, EventArgs e)
        {
            RefreshReplayList();
        }

        private async void Upload_button_Click(object sender, EventArgs e)
        {
            string Visibility = UploadVisibility_comboBox.Text;
            Console.WriteLine(Visibility);
            if (Visibility == "Public" || Visibility == "Private" || Visibility == "Unlisted")
            {
                if (ReplayList_dataGridView.SelectedRows.Count >= 1)
                {
                    string FileName = (string) ReplayList_dataGridView.SelectedRows[0].Cells[3].Value;
                    string FilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Rocket League\TAGame\Demos\" + FileName;

                    LogAddText(Environment.NewLine + "> Uploading replay \"" + FileName + "\"...");

                    Upload_button.Enabled = false;
                    UploadVisibility_comboBox.Enabled = false;

                    await BallChasing.UploadAsync(Visibility.ToLower(), FilePath);
                    LogAddText(Environment.NewLine + "- - - - -");

                    Upload_button.Enabled = true;
                    UploadVisibility_comboBox.Enabled = true;

                }
            }
        }
    }
}
