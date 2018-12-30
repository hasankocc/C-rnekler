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
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Import_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        denemeEntities db = new denemeEntities();

        private string filePath = "";
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Import işlemi yapmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (filePath == "")
                    {
                        MessageBox.Show("Dosya Seçiniz!");
                        return;
                    }
                    PRM_MASTER info = new PRM_MASTER();
                    //Create COM Objects. Create a COM object for everything that is referenced
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Excel.Range xlRange = xlWorksheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;

                    //iterate over the rows and columns and print to the console as it appears in the file
                    //excel is not zero based!!
                    for (int i = 1; i <= rowCount; i++)
                    {
                        info.DELETED = 1;
                        info.NAME = xlRange.Cells[i, 1].Value.ToString().Trim();
                        info.DSCR = xlRange.Cells[i, 2].Value.ToString().Trim();
                        db.PRM_MASTER.Add(info);
                        db.SaveChanges();
                    }
                    //cleanup
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //release com objects to fully kill excel process from running in the background
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);
                    //close and release
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);
                    //quit and release
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                    MessageBox.Show("Dışa Aktarma Başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dışa Aktarma Başarısız! Hata: " +ex.Message);
            }
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
                openFile.Title = "Excel Dosyası Seçiniz..";
                openFile.FilterIndex = 1;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFile.FileName;
                    string fileName = openFile.SafeFileName;
                    lblStatus.Text = fileName + " dosyasını seçtiniz!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                Excel.Workbook excelWorkBook = excel.Workbooks.Add(Type.Missing);
                Excel.Worksheet excelSheet = excelWorkBook.ActiveSheet;
                excelSheet.Name = "Sheet1";
                for (int i = 1; i < dgvPrmMaster.Columns.Count + 1; i++)
                {
                    excelSheet.Cells[1, i] = dgvPrmMaster.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvPrmMaster.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvPrmMaster.Columns.Count; j++)
                    {
                        excelSheet.Cells[i + 2, j + 1] = dgvPrmMaster.Rows[i].Cells[j].Value.ToString();
                    }

                }
                // save the application  
                excelWorkBook.SaveAs("C:\\Users\\TT-HASAN\\Desktop\\output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                excel.Quit();
                MessageBox.Show("İçe Aktarım Başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPrmMaster.DataSource = db.PRM_MASTER.Select(p=> new {p.DELETED,p.NAME,p.DSCR}).Where(p=>p.DELETED==1).ToList();
        }
    }
    }