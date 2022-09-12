using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Web_Parser
{
    public class Core
    {
        public delegate void Status(string message);
        public event Status Notify;

        public Core(RichTextBox rtb)
        {
            output = rtb;
        }

        RichTextBox output;

        public void Parse(string url, string el, string el2)
        {
            output.Text = string.Empty;
            if (url.Length < 1)
            {
                Notify?.Invoke("URL is empty!");
                return;
            }

            string source = GetHTML(url);
            source = source.Replace("\r\n", string.Empty);
            if (source.Length <= 0)
            {
                Notify?.Invoke("Source code is empty!");
                return;
            }


            Regex regex = new Regex($"{el}(.*?){el2}");
            MatchCollection matches = regex.Matches(source);
            string result = string.Empty;

            int lines = 0;

            foreach (var m in matches)
            {
                string s = m.ToString();
                s = s.Replace(el, string.Empty);
                s = s.Replace(el2, string.Empty);
                result += s.Trim() + "\r\n";
                lines++;
            }

            output.Text = result;
            Notify?.Invoke("DONE! Lines: " + lines);

        }

        string GetHTML(string url)
        {
            try
            {
                WebRequest req = HttpWebRequest.Create(url);
                req.Method = "GET";

                string source = string.Empty;
                using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
                {
                    source = reader.ReadToEnd();
                }

                Notify?.Invoke("Source code downloaded!");
                return source;

            }
            catch
            {
                Notify?.Invoke("URL reading failed!");
                return string.Empty;
            }
        }

    }
}
