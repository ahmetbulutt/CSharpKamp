using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi.EF
{
    public partial class FrmStatiscticcs : Form
    {
        public FrmStatiscticcs()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db= new EgitimKampiEFTravelDbEntities();

        private void FrmStatiscticcs_Load(object sender, EventArgs e)
        {
            

            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text=db.Location.Sum(x=>x.LocationCapacity).ToString();
            lblGuideCount.Text=db.Guide.Count().ToString();
            lblAvgCapacity.Text=db.Location.Average(x=>x.LocationCapacity).ToString();
            lblAvgLocationPrice.Text=db.Location.Average(x=>x.LocationCapacity).ToString();
            
            
            int lastCountryId=db.Location.Max(x=>x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.LocationCountry).FirstOrDefault();


            lblCapadociaLocationCapacity.Text=db.Location.Where(x=>x.LocationCity=="Kapadokya").Select(y=>y.LocationCapacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.LocationCountry=="Türkiye").Average(y=>y.LocationCapacity).ToString();

            var romeGuideId=db.Location.Where(x=>x.LocationCity== "Roma Tusristik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName + " " + y.GuideSurname).FirstOrDefault();

            var maxCapacity=db.Location.Max(x=>x.LocationCapacity);
            lblMaxCapacityLocation.Text=db.Location.Where(x=>x.LocationCapacity==maxCapacity).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text=db.Location.Where(x=>x.LocationPrice==maxPrice).Select(y=>y.LocationCity).FirstOrDefault().ToString();

            var guideIdByNameAhmetBulut=db.Guide.Where(x=>x.GuideName=="Ahmet"  && x.GuideSurname== "Bulut").Select(y=>y.GuideId).FirstOrDefault();
            lblAhmetBulutTurSayısı.Text=db.Location.Where(x=>x.GuideId==guideIdByNameAhmetBulut).Count().ToString();









            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
