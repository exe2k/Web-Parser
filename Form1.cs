using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace Web_Parser
{
    public partial class Form1 : Form
    {
        Core core;

        public Form1()
        {
            InitializeComponent();
            core = new Core(Output);

            core.Notify += StatusTxt;
            encodingBox.SelectedIndex = 0;
        }

        private void StatusTxt(string s)
        {
            StatusText.Text = s;
        }

        private void ParseBtn_Click(object sender, EventArgs e)
        {
            core.Parse(URLText.Text,ElementText.Text,ElementInnerText.Text);
        }

        private void incrementBtn_Click(object sender, EventArgs e)
        {
            var urlTxt = URLText.Text;
            Regex r = new Regex(@"\d+$");
            MatchCollection res = r.Matches(urlTxt);
            if (res.Count>0)
            {
                string lastChars = res[res.Count - 1].ToString();
                if(int.TryParse(lastChars, out int lastNum))
                {
                    lastNum++;

                    string newURL = urlTxt.Substring(0, urlTxt.Length - lastChars.Length);
                    newURL += lastNum.ToString();
                    URLText.Text = newURL;
                }
            }
        }

        private void encodingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            core.encoding = encodingBox.SelectedText;
        }

        private void checkBox_clear_CheckedChanged(object sender, EventArgs e)
        {
            core.isClear = checkBox_clear.Checked;
        }
    }
}
