using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdWatcher
{
    public partial class Form2 : Form
    {
        public Form2(List<BirdData> bd)
        {
            InitializeComponent();
            dataGridView1.DataSource = bd;

            //this is a guid to hide it
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
