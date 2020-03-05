using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace black_h0le
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String wURL = textBox1.Text;
            String UserIn = textBox1.Text;
            //item detaction and filter
            if (wURL.Contains("https://") || wURL.Contains("http://"))
            {
                wURL = textBox1.Text;
            }
            else if (!wURL.Contains(".com") || !wURL.Contains(".cz") || !wURL.Contains(".org") || !wURL.Contains(".eu"))
            {
                wURL = "https://google.com/search?q=" + textBox1.Text;
            }
            else
            {
                wURL = "https://"+textBox1.Text;
            }
            webBrowser2.Url = new System.Uri(wURL);
            //tabs 
            ToolStripButton tabButton = new ToolStripButton();
            tabButton.Text = UserIn;
            tabButton.Click += new EventHandler(this.tabButton_Click);
            toolStrip1.Items.Add(tabButton);
        }
        //menu click
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser2.ScriptErrorsSuppressed = true;
            helpProvider1.SetShowHelp(textBox1, true);
            helpProvider1.SetHelpString(textBox1, "Enter a valid text here.");
        }
        //button menu click handle
        private void tabButton_Click(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            String TabQry = item.Text;
            String BrowserURl = "";
            if (TabQry.Contains("https://") || TabQry.Contains("http://"))
            {
                BrowserURl = TabQry;
            }
            else if (!TabQry.Contains(".com") || !TabQry.Contains(".cz") || !TabQry.Contains(".org") || !TabQry.Contains(".eu"))
            {
                BrowserURl = "https://google.com/search?q=" + TabQry;
            }
            else
            {
                BrowserURl = "https://" + TabQry;
            }

            webBrowser2.Url = new System.Uri(BrowserURl);

        }
        
        private void toolStripButton_Click(object senderm, EventArgs e)
        {
            MessageBox.Show("clickd");
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
