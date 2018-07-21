using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using YoutubeHelper;

namespace YoutubeBackLinker
{
    public partial class FormMain : Form
    {
        private string _apiKey;
        public List<MyVideo> VideoList = new List<MyVideo>();

        public List<int> SelectedVideoIndexes
        {
            get
            {
                var selectedOnes = new List<int>();
                for (var index = 0; index < dataGridViewSearchResults.Rows.Count; index++)
                {
                    var row = dataGridViewSearchResults.Rows[index];
                    if (row.Selected)
                    {
                        selectedOnes.Add(index);
                    }
                }

                Debug.WriteLine(selectedOnes.Count);
                return selectedOnes;
            }
        }

        public List<MyVideo> SelectedVideos
        {
            get
            {
                var selectedVideos = new List<MyVideo>();
                foreach (var selectedVideoIndex in SelectedVideoIndexes)
                {
                    selectedVideos.Add(VideoList[selectedVideoIndex]);
                }

                return selectedVideos;
            }
        }

        public FormMain()
        {
            InitializeComponent();

            GetConfig();
        }

        public void GetConfig()
        {
            //TODO: from app settings file
            _apiKey = "AIzaSyCEIiLqNF_LHUcIk52GJkG0u9u9Af7Tc7c";
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Application", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            buttonSearch.Enabled = false;

            var thread = new Thread(async () =>
            {
                var maxValueDecimal = numericUpDownMaxResults.Value;
                var maxValue = (int) maxValueDecimal;
                try
                {
                    VideoList = await new Search().Run(_apiKey, textBoxSearchTerm.Text, maxValue);
                    DisplaySearchResults();
                }
                catch (Exception exception)
                {
                    buttonSearch.Enabled = true;
                    MessageBox.Show("Something went wrong, please check internet connection and try again");
                }
            });
            thread.Start();
        }

        private void EnableSelectionButtons(bool enable)
        {
            var action = new Action(() =>
            {    
                buttonSelectTop10.Enabled = enable;
                buttonSelectTop20.Enabled = enable;
                buttonSelectAll.Enabled = enable;
                buttonDeselectAll.Enabled = enable;
                buttonSearch.Enabled = true;
            });
            if (buttonSelectTop10.InvokeRequired)
            {
                buttonSelectTop10.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void EnableDownloadButtons(bool enable)
        {
            var action = new Action(() =>
            {
                buttonDownloadAll.Enabled = enable;
                buttonDownloadSelection.Enabled = enable;
                buttonClearSearchResults.Enabled = VideoList.Count > 0;
            });
            if (buttonDownloadAll.InvokeRequired)
            {
                buttonDeselectAll.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void AdjustColumnWidth()
        {
            for (int index = 0; index < dataGridViewSearchResults.Columns.Count; index++)
            {
                var column = dataGridViewSearchResults.Columns[index];
                column.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 10;
            }
        }

        private void DisplaySearchResults()
        {
            var action = new Action(() =>
            {
                dataGridViewSearchResults.DataSource = null;
                dataGridViewSearchResults.DataSource = VideoList;
                AdjustColumnWidth();

                var selected = SelectedVideoIndexes.Count;
                UpdateStatusBar(selected);
                EnableSelectionButtons(selected > 0);
                EnableDownloadButtons(selected > 0);
            });

            if (dataGridViewSearchResults.InvokeRequired)
            {
                dataGridViewSearchResults.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void UpdateStatusBar(int selected)
        {
            toolStripStatusLabelMain.Text = $"Found {VideoList.Count} videos;";
            toolStripStatusLabelSelectedCount.Text = $"Selected {selected};";
            toolStripStatusLabelSelectedCount.Visible = selected > 0;
            buttonDownloadSelection.Text = $"Download {selected}";
        }

        private void TextBoxSearchTerm_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = textBoxSearchTerm.Text.Length > 0;
        }

        private void ButtonSelectTop10_Click(object sender, EventArgs e)
        {
            SelectTopN(10);
            UpdateStatusBar(10);
        }

        private void DeselectAll()
        {
            dataGridViewSearchResults.ClearSelection();
            UpdateStatusBar(VideoList.Count);
        }

        private void SelectTopN(int n)
        {
            DeselectAll();
            for (var index = 0; index < n; index++)
            {
                dataGridViewSearchResults.Rows[index].Selected = true;
            }

            if (n > 0)
            {
                EnableDownloadButtons(true);
            }
        }

        private void ButtonSelectTop20_Click(object sender, EventArgs e)
        {
            SelectTopN(20);
            UpdateStatusBar(20);
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            SelectTopN(VideoList.Count);
            UpdateStatusBar(VideoList.Count);
        }

        private void ButtonDeselectAll_Click(object sender, EventArgs e)
        {
            DeselectAll();
            UpdateStatusBar(0);
            EnableDownloadButtons(false);
        }

        private void ButtonDownloadAll_Click(object sender, EventArgs e)
        {
            Download(VideoList, (Button) sender);
        }

        private void ButtonDownloadSelection_Click(object sender, EventArgs e)
        {
            Download(SelectedVideos, (Button) sender);
        }

        private void Download(List<MyVideo> videos, Button sender)
        {
            sender.Enabled = false;
            dataGridViewSearchResults.Enabled = false;
            var thread = new Thread(() =>
            {
                var downloader = new Downloader(videos, AppSettings.VideoDownloadDir, AppSettings.VideoBaseUrl);
                downloader.OnDownload += Downloader_OnDownload;
                downloader.Get();
            });
            thread.Start();
        }

        private void Downloader_OnDownload(string id, double percentage)
        {
            Debug.WriteLine($"{id} -> {percentage}");
        }

        private void ButtonClearSearchResults_Click(object sender, EventArgs e)
        {
            VideoList = new List<MyVideo>();
            dataGridViewSearchResults.DataSource = null;
            EnableSelectionButtons(false);
            EnableDownloadButtons(false);
            UpdateStatusBar(0);
        }

        private void DataGridViewSearchResults_MouseUp(object sender, MouseEventArgs e)
        {
            var selected = SelectedVideoIndexes.Count;
            UpdateStatusBar(selected);
            EnableDownloadButtons(selected > 0);
        }
    }
}