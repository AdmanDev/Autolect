using System;
using System.Collections.Generic;
using System.Windows;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using System.ComponentModel;

namespace Autolect
{    
    public partial class AddYoutube_Window : Window
    {
        //Variables
        private const string apiKey = "AIzaSyD9AGr_GbfIeu2Sepfc9XpbMEpxvhGIlx0";
        private List<string> comments, pseudos;

        private bool addBasedCom = true;
        private int doubleOption = 1;
        private string videoID;
        private string com;

        //Constructor
        public AddYoutube_Window()
        {
            InitializeComponent();

            comments = new List<string>();
            pseudos = new List<string>();
        }

        private void BT_Add_Click(object sender, RoutedEventArgs e)
        {
            if (!this.TB_VideoLink.Text.Contains("youtube.com") || !this.TB_VideoLink.Text.Contains("="))
                return;

            addBasedCom = (bool)this.RB_AddBasedComments.IsChecked;
            com = this.TB_Comment.Text.ToLower();
            videoID = this.TB_VideoLink.Text.Split('=')[1];

            if (this.RB_JustOne.IsChecked == true)
                doubleOption = 1;
            else if (this.RB_Remove.IsChecked == true)
                doubleOption = 2;
            else
                doubleOption = 3;

            this.Visibility = Visibility.Collapsed;
            new LoadWidow(GetComments).ShowDialog();
            this.Visibility = Visibility.Visible;

            Global.participants = pseudos;
            Global.comments = comments;

            Global.mainWindow.EditFinish(false);
            this.Close();
        }

        public void GetComments(BackgroundWorker worker)
        {
            Global.mode = Mode.Normal;

            YouTubeService youtube = new YouTubeService(new BaseClientService.Initializer() { ApiKey = apiKey });

            var commentThreadsRequest = youtube.CommentThreads.List("replies,snippet");
            commentThreadsRequest.VideoId = videoID; // here real id
            commentThreadsRequest.MaxResults = 100; // 1 - 100;

            int i = 0;
            string nextPageToken = "";
            while (nextPageToken != null)
            {
                if (worker.CancellationPending)
                    return;

                commentThreadsRequest.PageToken = nextPageToken;
                var response = commentThreadsRequest.Execute();

                string currPseudo, currComment;
                foreach (var item in response.Items)
                {
                    currPseudo = item.Snippet.TopLevelComment.Snippet.AuthorDisplayName;
                    currComment = item.Snippet.TopLevelComment.Snippet.TextOriginal;

                    if(SelectPseudo(currPseudo, currComment))
                    {
                        pseudos.Add(currPseudo);
                        comments.Add(currComment);
                    }

                    i++;

                    if (nextPageToken != "")
                        worker.ReportProgress(i);

                    
                }

                nextPageToken = response.NextPageToken;
            }
        }

        private bool SelectPseudo(string _pseudo, string _currComment)
        {
            //Comments
            if(addBasedCom)
            {
                return (_currComment.ToLower().Contains(com) && CheckDouble());
            }else
            {
                return CheckDouble();
            }

            //Double
            bool CheckDouble()
            {
                if(doubleOption == 1)
                {
                    return !pseudos.Contains(_pseudo);
                }

                if(doubleOption == 2)
                {
                    if (pseudos.Contains(_pseudo))
                    {
                        pseudos.Remove(_pseudo);
                        return false;
                    }
                }

                return true;
            }

        }

        private void BT_PastLink_Click(object sender, RoutedEventArgs e)
        {
            this.TB_VideoLink.Paste();
        }

    }
}