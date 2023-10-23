using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstTum.Items.Count; i++)
            {
                if (lstTum.Items[i].ToString() == "VİŞNE" ||
                    lstTum.Items[i].ToString() == "MUZ" ||
                    lstTum.Items[i].ToString() == "KAVUN")
                {
                    lstMeyveler.Items.Add(lstTum.Items[i]);
                }
                else
                {
                    lstSebzeler.Items.Add(lstTum.Items[i]);
                }
                
            }
            

        }
    }
}