using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_Tsvetkov_Zhukov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string sort;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.userAgeTableAdapter.Fill(this._374_lab12_Tsvetkov_ZhukovDataSet.UserAge);
            for (int i = 0; i < this._374_lab12_Tsvetkov_ZhukovDataSet.UserAge.Columns.Count; i++)
            {
                this.comboBox1.Items.Add(this._374_lab12_Tsvetkov_ZhukovDataSet.UserAge.Columns[i].ToString());
            }
            this.Vozr.Checked = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.userAgeBindingSource.Sort = this.comboBox1.Text + sort;
        }

        private void Vozr_Click(object sender, EventArgs e)
        {

            if (Ubiv.Checked)
            {
                Ubiv.Checked = false;
            }
            sort = " ASC";

            Vozr.Checked = true;
           
            
        }

        private void Ubiv_Click(object sender, EventArgs e)
        {
            if (Vozr.Checked)
            {
                Vozr.Checked = false;
            }
            sort = " DESC";
            Ubiv.Checked = true;
           
        }
    }
}
