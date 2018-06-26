﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;
using System.Globalization;


namespace WindowsFormsApp2
{
    public partial class Przegladarka : Form

        {

        public static String favXml = "favorits.xml", linksXml = "links.xml";
        List<String> urls = new List<String>();
        XmlDocument settings = new XmlDocument();
        String homePage;
        CultureInfo currentCulture;

        public Przegladarka()
        {
            InitializeComponent();
            currentCulture = CultureInfo.CurrentCulture;
        }

        WebBrowser web = new WebBrowser();
        int i = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentCompleted;

            tabControl1.TabPages.Add("Nowa Karta");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;

        }

                //addFavorit method
        private void addFavorit(String url, string name)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("favorit");
            el.SetAttribute("url", url);
            el.InnerText = name;
            if (!File.Exists(favXml))
            {
                XmlElement root = myXml.CreateElement("favorites");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load(favXml);
                myXml.DocumentElement.AppendChild(el);
            }
            if (favoritesPanel.Visible == true)
            {
                TreeNode node = new TreeNode(el.InnerText, faviconIndex(el.GetAttribute("url")), faviconIndex(el.GetAttribute("url")));
                node.ToolTipText = el.GetAttribute("url");
                node.Name = el.GetAttribute("url");
                node.ContextMenuStrip = favContextMenu;
                treeView1.Nodes.Add(node);
            }
            myXml.Save(favXml);
        }

        //addLink method
        private void addLink(String url, string name)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("link");
            el.SetAttribute("url", url);
            el.InnerText = name;

            if (!File.Exists(linksXml))
            {
                XmlElement root = myXml.CreateElement("links");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load(linksXml);
                myXml.DocumentElement.AppendChild(el);
            }
            if (linkBar.Visible == true)
            {
                ToolStripButton b =
                          new ToolStripButton(el.InnerText, getFavicon(url), items_Click, el.GetAttribute("url"));
                b.ToolTipText = el.GetAttribute("url");
                b.MouseUp += new MouseEventHandler(b_MouseUp);
                linkBar.Items.Add(b);
            }

            if (favoritesPanel.Visible == true)
            {
                TreeNode node = new TreeNode(el.InnerText, faviconIndex(url), faviconIndex(el.GetAttribute("url")));
                node.Name = el.GetAttribute("url");
                node.ToolTipText = el.GetAttribute("url");
                node.ContextMenuStrip = linkContextMenu;
                treeView1.Nodes[0].Nodes.Add(node);
            }
            myXml.Save(linksXml);
        }

        //click link button
        private void items_Click(object sender, EventArgs e)
        {
            ToolStripButton b = (ToolStripButton)sender;
            getCurrentBrowser().Navigate(b.ToolTipText);
        }
        //show context menu on button
        private void b_MouseUp(object sender, MouseEventArgs e)
        {
            ToolStripButton b = (ToolStripButton)sender;
            adress = b.ToolTipText;
            name = b.Text;

            if (e.Button == MouseButtons.Right)
                linkContextMenu.Show(MousePosition);
        }

        /*LINKS BAR*/

        string adress, name;

        // favicon
        public static Image favicon(String u, string file)
        {
            Uri url = new Uri(u);
            String iconurl = "http://" + url.Host + "/favicon.ico";

            WebRequest request = WebRequest.Create(iconurl);
            try
            {
                WebResponse response = request.GetResponse();

                Stream s = response.GetResponseStream();
                return Image.FromStream(s);
            }
            catch (Exception ex)
            {
                return Image.FromFile(file);
            }


        }
        
        //favicon index
        private int faviconIndex(string url)
        {
            Uri key = new Uri(url);
            if (!imgList.Images.ContainsKey(key.Host.ToString()))
                imgList.Images.Add(key.Host.ToString(), favicon(url, "link.png"));
            return imgList.Images.IndexOfKey(key.Host.ToString());
        }
        //getFavicon from key
        private Image getFavicon(string key)
        {
            Uri url = new Uri(key);
            if (!imgList.Images.ContainsKey(url.Host.ToString()))
                imgList.Images.Add(url.Host.ToString(), favicon(key
                    , "link.png"));
            return imgList.Images[url.Host.ToString()];
        }

        /*ADDRESS BAR*/

        private WebBrowser getCurrentBrowser()
        {
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];
        }
        //ENTER
        private void adrBarTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getCurrentBrowser().Navigate(toolStripComboBox1.Text);

            }
        }

        void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void przejdzToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripComboBox1.Text);
            if (!toolStripComboBox1.Items.Contains(toolStripComboBox1.Text)) ;
            File.AppendAllText("historia.txt", DateTime.Now.ToString() + " " + web.DocumentTitle + Environment.NewLine);
        }

        private void wsteczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void dodajKarteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentCompleted;

            tabControl1.TabPages.Add("Nowa Karta");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;

        }

        private void usuńKarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count - 1 > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (web.DocumentTitle.Length != 1)

            {
                toolStripComboBox1.Items.Add(toolStripComboBox1.Text);

               
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getCurrentBrowser().Url != null)
            {
                Ulubione dlg = new Ulubione(getCurrentBrowser().Url.ToString());
                DialogResult res = dlg.ShowDialog();

                if (res == DialogResult.OK)
                {
                    if (dlg.favFile == "Favorites")
                        addFavorit(getCurrentBrowser().Url.ToString(), dlg.favName);
                    else addLink(getCurrentBrowser().Url.ToString(), dlg.favName);
                }
                dlg.Close();
            }

        }



    }
    }


