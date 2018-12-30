using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbDenemesi.Poly;
using ProbDenemesi.DependencyInjection;

namespace ProbDenemesi
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
            txtVATRate.Enabled = false;
            rdbConstruction.Checked=true;
        }
        private Degerler Degerler = new Degerler();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Degerler.sayi1 = Convert.ToInt32(textBox1.Text);
            Degerler.sayi2 = Convert.ToInt32(textBox2.Text);
            Degerler.totalsonuc();
            label1.Text = Degerler.righttoplamsonuc.ToString();
            //this.ForeColor = Color.AliceBlue;// Mevcut Classdaki tüm butonlar için 
            Button btn = (Button)sender;  // İki kod parçacığı ile  this arasındaki fark bulunduğu 
            btn.ForeColor = Color.AliceBlue;// button1 için
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Degerler.sayi1 = Convert.ToInt32(textBox1.Text);
            Degerler.sayi2 = Convert.ToInt32(textBox2.Text);
            Degerler.totalsonuc();
            label1.Text = Degerler.wrongtoplamsonuc.ToString();   
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            int deneme = StaticClass.count;         
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            var deneme = new InterfaceKullananClass();
            lbInterface.Items.Add(deneme.AnaBaslik());
            lbInterface.Items.Add(deneme.Marka);
            lbInterface.Items.Add(deneme.Isim());
            lbInterface.Items.Add("");
            lbInterface.Items.Add(deneme.En());
            lbInterface.Items.Add(deneme.Boy());
            lbInterface.Items.Add(deneme.Fiyat);          
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            FuncAndOperatorsOverloaded overloaded = new FuncAndOperatorsOverloaded();
            if (rdbConstruction.Checked)
                lblResult.Text = overloaded.ComputeVAT(Convert.ToDouble(txtPrice.Text), Enums.KDVTag.Construction).ToString();
            else if (rdbTechno.Checked)
                lblResult.Text = overloaded.ComputeVAT(Convert.ToDouble(txtPrice.Text), Enums.KDVTag.Technology).ToString();
            else if (rdbFoodTextile.Checked)
                lblResult.Text = overloaded.ComputeVAT(Convert.ToDouble(txtPrice.Text), Enums.KDVTag.Textile).ToString();
            else if (rdbManuel.Checked)
                lblResult.Text = overloaded.ComputeVAT(Convert.ToDouble(txtPrice.Text), Convert.ToDouble(txtVATRate.Text)).ToString();
        }

        private void rdbManuel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManuel.Checked == true)
                txtVATRate.Enabled = true;
        }

        private void rdbTechno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTechno.Checked == true)
                txtVATRate.Enabled = false;
        }

        private void rdbConstruction_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbConstruction.Checked == true)
                txtVATRate.Enabled = false;
        }

        private void rdbFoodTextile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFoodTextile.Checked == true)
                txtVATRate.Enabled = false;
        }

        private void btnShowVATs_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            Construction construction = new Construction();
            Technology technology = new Technology();
            lblRslt.Text = food.ProductName + " : " + (food.CalculateVAT(Convert.ToDouble(txtPrc.Text))).ToString() + Environment.NewLine +
                           construction.ProductName + " : " + (construction.CalculateVAT(Convert.ToDouble(txtPrc.Text))).ToString() + Environment.NewLine +
                           technology.ProductName +" : "+ (technology.CalculateVAT(Convert.ToDouble(txtPrc.Text))).ToString();
        }

        private void rdbHot_CheckedChanged(object sender, EventArgs e)
        {
            Insan insan = new Insan(new Ceket());
            lblRecommend.Text = "Öneri : " + insan.yaz();
        }

        private void rdbCold_CheckedChanged(object sender, EventArgs e)
        {
            Insan insan = new Insan(new Mont());
            lblRecommend.Text = "Öneri : " + insan.yaz();
        }

        private void rdbIce_CheckedChanged(object sender, EventArgs e)
        {
            Insan insan = new Insan(new Hirka());
            lblRecommend.Text = "Öneri : " + insan.yaz();
        }


    }
}
