using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using YoutubeHelper;

namespace YoutubeBackLinker
{
    public partial class FormMain : Form
    {
        private string ApiKey;
        public List<MyVideo> VideoList;

        public List<MyVideo> SelectedVideos
        {
            get { return VideoList.Where(video => video.Selected).ToList(); }
        }

        public FormMain()
        {
            InitializeComponent();

            GetConfig();
        }

        public void GetConfig()
        {
            //TODO: from app settings file
            ApiKey = "AIzaSyCEIiLqNF_LHUcIk52GJkG0u9u9Af7Tc7c";
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: confirmation text
            Application.Exit();
        }

        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            var maxValueDecimal = numericUpDownMaxResults.Value;
            var maxValue = (int)maxValueDecimal;
            try
            {
                VideoList = await new Search().Run(ApiKey, textBoxSearchTerm.Text, maxValue);
                DisplaySearchResults2();
                EnableSelectionButtons();
            }
            catch
            {
                MessageBox.Show("Something went wrong, please check internet connection and try again");
            }
        }

        private void EnableSelectionButtons()
        {
            var enable = VideoList.Count > 0;
            buttonSelectTop10.Enabled = enable;
            buttonSelectTop20.Enabled = enable;
            buttonSelectAll.Enabled = enable;
            buttonDeselectAll.Enabled = enable;
        }

        private void EnableDownloadButtons()
        {
            buttonDownloadAll.Enabled = VideoList.Count > 0;
            buttonDownloadSelection.Enabled = SelectedVideos.Count > 0;
            buttonDownloadSelection.Text = $"Download {SelectedVideos.Count}";
        }

        private void DisplaySearchResults()
        {
            DataSet dataSet = new DataSet();
            DataTable searchResultDataTable = dataSet.Tables.Add("searchResults");


            searchResultDataTable.Columns.Add("Selected", typeof(bool));
            searchResultDataTable.Columns.Add("ChannelTitle");
            searchResultDataTable.Columns.Add("Description");
            searchResultDataTable.Columns.Add("PublishedAtRaw");
            searchResultDataTable.Columns.Add("PublishedAt");
            searchResultDataTable.Columns.Add("Title");

            searchResultDataTable.Columns.Add("CommentCount");
            searchResultDataTable.Columns.Add("DislikeCount");
            searchResultDataTable.Columns.Add("FavoriteCount");
            searchResultDataTable.Columns.Add("LikeCount");
            searchResultDataTable.Columns.Add("ViewCount");


            foreach (var myVideo in VideoList)
            {
                dataSet.Tables[0].Rows.Add(
                    myVideo.Selected,
                    myVideo.ChannelTitle,
                    myVideo.Description,
                    myVideo.PublishedAtRaw,
                    myVideo.PublishedAt,
                    myVideo.Title,

                    myVideo.CommentCount,
                    myVideo.DislikeCount,
                    myVideo.FavoriteCount,
                    myVideo.LikeCount,
                    myVideo.ViewCount
                    );
                Debug.WriteLine(myVideo.Title);
            }

            dataGridViewSearchResults.DataSource = null;
            dataGridViewSearchResults.DataSource = dataSet.Tables[0];
            toolStripStatusLabelMain.Text = $"Found {VideoList.Count} videos";
        }

        private void DisplaySearchResults2()
        {
            dataGridViewSearchResults.DataSource = null;
            dataGridViewSearchResults.DataSource = VideoList;
            toolStripStatusLabelMain.Text = $"Found {VideoList.Count} videos;";
            var count = VideoList.Count(vd => vd.Selected);
            toolStripStatusLabelSelectedCount.Text = $"Selected {count};";
            toolStripStatusLabelSelectedCount.Visible = count > 0;
            EnableDownloadButtons();
        }

        private void TextBoxSearchTerm_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = textBoxSearchTerm.Text.Length > 0;
        }

        private void DataGridViewSearchResults_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dataGridViewSearchResults.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0) return;
            VideoList[hit.RowIndex].Selected = !VideoList[hit.RowIndex].Selected;
            DisplaySearchResults2();
        }

        private void ButtonSelectTop10_Click(object sender, EventArgs e)
        {
            DeselectAll();
            SelectTopN(10);
            DisplaySearchResults2();
        }

        private void DeselectAll()
        {
            foreach (var myVideo in VideoList)
            {
                myVideo.Selected = false;
            }
        }

        private void SelectTopN(int n)
        {
            for (var index = 0; index < n; index++)
            {
                VideoList[index].Selected = true;

            }
        }

        private void ButtonSelectTop20_Click(object sender, EventArgs e)
        {
            DeselectAll();
            SelectTopN(20);
            DisplaySearchResults2();
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            DeselectAll();
            SelectTopN(VideoList.Count);
            DisplaySearchResults2();
        }

        private void ButtonDeselectAll_Click(object sender, EventArgs e)
        {
            DeselectAll();
            DisplaySearchResults2();
        }

        private void ButtonDeselectSelection_Click(object sender, EventArgs e)
        {
            var downloader = new Downloader(VideoList.Take(2).ToList(), @"C:\TEMP");
            downloader.OnDownload += Downloader_OnDownload;
            downloader.Get();
        }

        private void Downloader_OnDownload(string id, double percentage)
        {
            Debug.WriteLine($"{id} -> {percentage}");
        }
    }
}
