using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace BirdWatcher
{
    //
    class FileSerializer
    {
        public static void Serialize(string strPath, List<BirdData> myFile) 
        {
            FileStream fs = new FileStream(strPath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, myFile);
                fs.Close();
            }
            catch(SerializationException ex) 
            {
                MessageBox.Show(ex.Message + ":" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<BirdData> Deserialize(string strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Open);
            List<BirdData> myFile = new List<BirdData>();

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                myFile = ((List<BirdData>)(formatter.Deserialize(fs)));
                fs.Close();
                return myFile;
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return myFile;
            }
        }
    }
}
