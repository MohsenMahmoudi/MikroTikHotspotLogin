using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            StopBTN.Enabled = true;
            StartBTN.Enabled = false;
            SelectDataFileBTN.Enabled = false;
            reCheckTimer.Start();
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            StopBTN.Enabled = false;
            StartBTN.Enabled = true;
            SelectDataFileBTN.Enabled = true;
            reCheckTimer.Stop();
        }

        private int accountindex = 0;
        private int totalfaildattmp = 0;

        private int failcount = 0;
        private void reCheckTimer_Tick(object sender, EventArgs e)
        {
            if (totalfaildattmp > 100)
            {
                StopBTN_Click(sender, e);
            }
            else
            {
                if (!PingHost("4.2.2.4"))
                {
                    failcount++;
                    this.Text = "Login Bot - Unable to connect!";
                    if (failcount > 5)
                    {
                        try
                        {
                            for (int attmp = 0; attmp < 5; attmp++)
                            {
                                if (accountLst[accountindex].Length > 0)
                                {
                                    string[] user = accountLst[accountindex].Split('-');
                                    HttpPost(ServerAdrsCB.Text, "username=" + user[0] + "&password=" + user[1]);
                                }
                                if (PingHost("4.2.2.4"))
                                    break;
                                else
                                {
                                    Console.Beep(500, 500);
                                    totalfaildattmp++;
                                    accountindex++;
                                    if (accountindex > accountLst.Length - 1)
                                    {
                                        accountindex = 0;
                                    }
                                }
                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else
                {
                    this.Text = "Login Bot - connected!";
                    failcount = 0;
                    totalfaildattmp -= 10;
                    if (totalfaildattmp < 0)
                        totalfaildattmp = 0;
                }
            }
        }


        static string HttpPost(string URI, string Parameters)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(URI);
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";
            //We need to count how many bytes we're sending. Post'ed Faked Forms should be name=value&
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(Parameters.ToString());
            req.ContentLength = bytes.Length;
            System.IO.Stream os = null;
            try
            {
                os = req.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);
                os.Close();
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());

                string towritestring = sr.ReadToEnd().Trim();
                return towritestring;
            }
            catch
            {
                return null;
            }

        }


        static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();

            try
            {
                PingReply reply = pinger.Send(nameOrAddress);

                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                return false;
            }

            return pingable;
        }

        String[] accountLst = null;
        private void SelectDataFileBTN_Click(object sender, EventArgs e)
        {
            try
            {
                AccountListRTB.Clear();
                AccountListFileOFD.ShowDialog();
                StreamReader strm = new StreamReader(AccountListFileOFD.FileName);
                string buffer = null;
                while ((buffer = strm.ReadLine()) != null)
                {
                    AccountListRTB.Text += buffer + '\n';
                }
                accountLst = AccountListRTB.Text.Split('\n');
                StartBTN.Enabled = true;
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
