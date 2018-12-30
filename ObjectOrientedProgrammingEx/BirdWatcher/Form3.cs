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
    public partial class Form3 : Form
    {
        //add a delagate
        public delegate void BirdNameUpdateHandler(object sender, BirdNameUpdateEventArgs e);

        public event BirdNameUpdateHandler BirdNameUpdated;

        public Form3(List<BirdData> bd)
        {
            InitializeComponent();

            //iterate the bird data to add each bird name to the bird name Listbox contrl
            foreach (BirdData bird in bd)
                listBox1.Items.Add(bird.BirdName);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //populate the argument list with the bird name
            BirdNameUpdateEventArgs args = new BirdNameUpdateEventArgs(listBox1.SelectedItems.ToString());
            BirdNameUpdated(this, args);

        }

        public class BirdNameUpdateEventArgs : System.EventArgs
        {
            private string mBirdName;
            public BirdNameUpdateEventArgs(string sBirdName) 
            {
                this.mBirdName = sBirdName;
            }

            public string BirdName
            {
                get 
                {
                    return mBirdName;
                }

            }
        }
    }
}
