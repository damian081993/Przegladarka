using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Ulubione : Form
    {
        String url;
        public String favName, favFile;

        public Ulubione(String url)
        {
            this.url = url;
            InitializeComponent();
        }

        private void AddFavorits_Load(object sender, EventArgs e)
        {
            textBox3.Text = url;
            comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            favName = textBox3.Text;
            favFile = comboBox1.SelectedItem.ToString();
        }
    }
}
