using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using YoutubeHelper;

namespace YoutubeBackLinker
{
    public partial class FormMain : Form
    {
        private string ApiKey;

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
            decimal maxValueDecimal = numericUpDownMaxResults.Value;
            int maxValue = (int) maxValueDecimal;
            List<MyVideo> list = await new Search().Run(ApiKey, textBoxSearchTerm.Text, maxValue);
            DisplaySearchResults(list);
        }

        private void DisplaySearchResults(List<MyVideo> list)
        {
            DataSet dataSet = new DataSet();
            DataTable searchResultDataTable = dataSet.Tables.Add("searchResults");

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


            foreach (var myVideo in list)
            {
                dataSet.Tables[0].Rows.Add(
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
            toolStripStatusLabelMain.Text = $"Found {list.Count} videos";
        }

        private void TextBoxSearchTerm_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = textBoxSearchTerm.Text.Length > 0;
        }
    }
}
