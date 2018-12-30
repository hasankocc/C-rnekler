using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PenaltyCalculation
{
    public partial class WebForm : System.Web.UI.Page
    {
        PenaltyCalEntities db = new PenaltyCalEntities();
        public List<DateTime> Dayoffs; // Tatil günlerini içinde bulunduran liste

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //Sayfa yenilense bile bu kısım birkez yüklenecek
            {
                ddlCountry.DataSource = db.Country.ToList();
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "id";
                ddlCountry.DataBind();
            }
            Dayoffs = new List<DateTime>(); 
            FillDayoffsList();
        }

        private void FillDayoffsList() //Dayoffs Listesi databaseden dolduruluyor.
        {
            int countryId = Convert.ToInt32(ddlCountry.Text);
            Dayoffs = db.CountryHoliday.Where(x => x.CountryId == countryId).Select(x => x.CountryHolidayDate).ToList();
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.Text = DateOperation.CalculateBusinessDay(clnCheckoutDate.SelectedDate, clnReturnedDate.SelectedDate, Dayoffs).ToString();
                if (lblResult.Text != "" && lblResult.Text != "0")
                {
                    Users user = new Users();
                    user.deleted = 0;
                    user.name = txtName.Text;
                    user.ip = HttpContext.Current.Request.FilePath;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Bir Hata oluştu! Hata: '" + ex.Message + ");</script>");
            }
        }
    }
}