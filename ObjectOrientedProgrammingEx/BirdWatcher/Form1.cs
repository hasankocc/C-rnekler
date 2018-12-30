using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BirdWatcher
{
    /// A simple project used to maintain data about a
    /// collection of birds (could be anything), and to
    /// display that data to the user, persist the data,
    /// and allow the user to recover and modify the
    /// data without using a database.  

    public partial class Form1 : Form
    {
        private List<BirdData> birds; // a cpntainer for the bird collection
        BirdData currentBird; // the current bird
        string currentFilePath; // the path to the bird data file
        int currentPosition; // the position within the bird list
        bool dirtyForm; // mark the form dirty when changed
        public Form1()
        {
            InitializeComponent();
            birds = new List<BirdData>(); // create a new bird data list
            currentBird = new BirdData();
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            cboGender.Items.Add("Dişi");
            cboGender.Items.Add("Erkek");
            currentPosition = 0;
            dirtyForm = false;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();
            currentBird = new BirdData();
            ClearForm();
            birds.Add(currentBird);
            dirtyForm = true;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(this, new EventArgs());
        }

        private void exitToolStripMenuItem_Click(Form1 form1, EventArgs eventArgs)
        {

            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data;" +
                    "would you like to save before exiting?", "Save Current Data",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(this, new EventArgs());

                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            
            }
        }

        public void ClearForm() 
        {
            txtBirdName.Text = string.Empty;
            txtBehavior.Text = string.Empty;
            txtLocation.Text = string.Empty;
            cboGender.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;
            picBird.Image = null;
        
        }

        private void saveAsToolStripMenuItem_Click(Form1 form1, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            dirtyForm = true;
            string imageFilePath = string.Empty;
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = "Open Image File";
            OpenFileDialog1.Filter = "JPEG Documents(*.jpg|*.jpg|Gif files|*.gif)";

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            imageFilePath = OpenFileDialog1.FileName;
            if (String.IsNullOrEmpty(imageFilePath))
                return;
            if (System.IO.File.Exists(imageFilePath) == false)
                return;

            byte[] barrImage = new byte[0];
            try
            {
                //convert image to byte and save in
                FileStream fsImage = null;
                fsImage = File.Open(imageFilePath, FileMode.Open, FileAccess.Read);
                barrImage = new byte[fsImage.Length];
                fsImage.Read(barrImage, 0, (int)fsImage.Length);
                fsImage.Close();

                currentBird.Picture = barrImage;
                currentBird.PictureName = imageFilePath;

                MemoryStream ms = new MemoryStream(barrImage);
                picBird.Image = Image.FromStream(ms);
                ms.Dispose();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error Storing Image");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data;" +
                    "would you like to save before starting a new" + "bird database?",
                    "Save Current Data", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {//discard and start new document
                    birds = new List<BirdData>();
                    ClearForm();
                }
            }
            else 
            {
                //start new document
                birds = new List<BirdData>();
                ClearForm();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; "
                   + "would you like to save before opening a different " +
                   "bird database?", "Save Current Data", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    Open();
                }
            }
            else 
            {
                Open();
            }
        }
        //Open an existing bird data file
        public void Open() 
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = "Open BRD Document";
            OpenFileDialog1.Filter = "BRD Documents(*.brd)|*.brd";
            if (OpenFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            currentFilePath = OpenFileDialog1.FileName;
            if (String.IsNullOrEmpty(currentFilePath)) 
                return;
            
            if (System.IO.File.Exists(currentFilePath) == false)
                return;
             birds = FileSerializer.Deserialize(currentFilePath);

            //load bird at position zero
            if (birds != null) 
            {
                currentBird = birds.ElementAt<BirdWatcher.BirdData>(0);
                LoadCurrentBird();
                dirtyForm = false;
            }
        }
        private void LoadCurrentBird() 
        {
            try 
            {
                txtBirdName.Text = currentBird.BirdName;
                txtLocation.Text = currentBird.Location;
                txtBehavior.Text = currentBird.BehaviorObserved;

            }
            catch{ }
            try
            {
                cboGender.Text = currentBird.Gender;
            }
            catch { }
            try
            {
                dtpDate.Value = currentBird.DateViewed;
            }
            catch { }

            try
            {
                dtpTime.Value = currentBird.TimeViewed;
            }
            catch { }
            try
            {
                if (currentBird.Picture != null)
                {
                    MemoryStream ms = new MemoryStream(currentBird.Picture);
                    picBird.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
                else 
                {
                    picBird.Image = null;
                }
            }
            catch 
            {
                picBird.Image = null;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();

            if (String.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                try
                {
                    SaveFileDialog1.Title = "Save BRD Document";
                    SaveFileDialog1.Filter = "BRD Documents(*.brd)|*.brd";

                    if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;
                }
                catch { return; }

                currentFilePath = SaveFileDialog1.FileName;
                if (String.IsNullOrEmpty(currentFilePath))
                    return;
            }
            FileSerializer.Serialize(currentFilePath, birds);
            MessageBox.Show("File" + currentFilePath + "saved,", "File Saved.");
            dirtyForm = false;
        }


        //set the current bird values to the form content;
        //if the user navigates off the current bird,it will save the content

        private void SaveCurrentBird()
        {
            if (!String.IsNullOrEmpty(txtBirdName.Text)) 
            {
                try
                {
                    currentBird.BirdName = txtBirdName.Text;
                    currentBird.Location = txtLocation.Text;
                    currentBird.BehaviorObserved = txtBehavior.Text;
                    currentBird.Gender = cboGender.Text;
                    currentBird.DateViewed = dtpDate.Value;
                    currentBird.TimeViewed = dtpTime.Value;
                    //Bird image byte array is set for current
                    //bird when image is set
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            try
            {
                saveFileDialog1.Title = "Save BRD Document";
                saveFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            catch { return; }
            currentFilePath = saveFileDialog1.FileName;
            if (String.IsNullOrEmpty(currentFilePath))
                return;
            FileSerializer.Serialize(currentFilePath, birds);
            MessageBox.Show("File" + currentFilePath + "saved." ,  "File Saved.");
            dirtyForm = false;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {

            if (currentPosition == 0)
                currentPosition++;
            else
                currentPosition--;
            birds.RemoveAt(currentPosition);
            currentBird = birds[currentPosition];
            LoadCurrentBird();
            dirtyForm = true;
        }

        //Find a specific bird
        private void tsbFindBird_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(birds);
            f.BirdNameUpdated += new Form3.BirdNameUpdateHandler(FindBird);
            f.Show();

        }

        //The bird finder code 
        private void FindBird(object sender, Form3.BirdNameUpdateEventArgs e) 
        {
            for (int i = 0; i < birds.Count; i++)
            {
                if (birds[i].BirdName == e.BirdName)
                {
                    currentBird = birds[i];
                    LoadCurrentBird();
                    currentPosition = i;
                }
            }

        }

        private void listAllBirdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(birds);
            f.Show();
        }

        private void tsbNavBack_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();
            if (currentPosition != 0)
            {
                currentPosition--;
                currentBird = birds[currentPosition];
                LoadCurrentBird();
            }

        }

        private void tsbNavForward_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();
            if(currentPosition <birds.Count-1)
            {
                currentPosition++;
                currentBird = birds[currentPosition];
                LoadCurrentBird();
            }

        }


        private void txtBirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }

        private void cboGender_MouseClick(object sender, MouseEventArgs e)
        {
            dirtyForm = true;
        }


        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }


        private void txtBehavior_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }


        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            dirtyForm = true;
        }

        private void dtpTime_CloseUp(object sender, EventArgs e)
        {
            dirtyForm = true;
        }
  

    }
}
