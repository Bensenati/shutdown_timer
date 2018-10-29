using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutDownTimer_v1._0
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (checkMinuten.Checked)
            {
                string befehl1 = "shutdown";
                string befehl2 = "/s /t ";
                int minuten = Convert.ToInt32(eingabe.Text);
                minuten = minuten * 60;
                Convert.ToString(minuten);
                befehl2 += minuten;
                Process.Start(befehl1, befehl2);
            }
            else if (checkUhrzeit.Checked)
            {
                string befehl1 = "shutdown";
                string befehl2 = "/s /t ";
                string date1 = System.DateTime.Now.ToShortTimeString();
                string[] date1s = date1.Split(':');
                int[] date1i = Array.ConvertAll<string, int>(date1s, int.Parse);
                string[] date2 = eingabe.Text.Split(':');
                int[] date2i = Array.ConvertAll<string, int>(date2, int.Parse);
                if (date1i[0] < date2i[0])
                {
                    int std, min, sek;
                    std = date2i[0] - date1i[0];
                    std = std * 60;
                    min = date2i[1] - date1i[1];
                    min = min + std;
                    sek = min * 60;
                    Convert.ToString(sek);
                    befehl2 += sek;
                    Process.Start(befehl1, befehl2);
                }
                else if (date1i[0] == date2i[0] && date1i[1] < date2i[1])
                {
                    int min, sek;
                    min = date2i[1] - date1i[1];
                    sek = min * 60;
                    Convert.ToString(sek);
                    befehl2 += sek;
                    Process.Start(befehl1, befehl2);
                }
                else
                {
                    eingabe.Text = "Uhrzeit abgelaufen";
                }
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            string befehl1 = "shutdown";
            string befehl2 = "/a";
            Process.Start(befehl1,befehl2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            //if (this.FormBorderStyle == FormBorderStyle.None)
            //{
            //    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //}
            //else
            //{
            //    this.FormBorderStyle = FormBorderStyle.None;
            //}
        }

        private void checkRahmen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRahmen.Checked == true)
            {
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void eingabe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkMinuten_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMinuten.Checked)
            {
                eingabe.ForeColor = Color.DimGray;
                eingabe.Text = "Minuten eingeben";
            }
            else
            {
                eingabe.ForeColor = Color.DimGray;
                eingabe.Text = "Uhrzeit eingeben";
            }
        }

        private void eingabe_MouseClick(object sender, MouseEventArgs e)
        {
            eingabe.Text = "";
            eingabe.ForeColor = Color.Black;
        }
    }
}
