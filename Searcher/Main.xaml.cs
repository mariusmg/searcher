using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace Searcher
{
    public partial class Main : PhoneApplicationPage
    {
        public Main()
        {
            InitializeComponent();

            listEngines.Items.Add("Google");
            listEngines.Items.Add("Bing");
            listEngines.Items.Add("Amazon");
            listEngines.Items.Add("Wikipedia");
            listEngines.Items.Add("DuckDuckGo");
            listEngines.Items.Add("Facebook");

            webBrowser.IsScriptEnabled = true;
        }

        private string GetUrl()
        {
            return Search.GetSearchString(listEngines.SelectedIndex, textBoxTerm.Text);
        }

        private void LaunchBrowser(string url)
        {
            try
            {
                webBrowser.Navigate(new Uri(url));
            }
            catch
            {
            }
        }

        private void textBoxTerm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key != Key.Enter)
                {
                    return;
                }

                if (textBoxTerm.Text.Trim().Length == 0)
                {
                    MessageBox.Show(" Please enter a search term ");
                    return;
                }

                DoSearch();
            }
            catch
            {
            }
        }

        private void DoSearch()
        {
            try
            {
                string url = GetUrl();

                LaunchBrowser(url);
            }
            catch
            {
                
            }
        }
    }
}