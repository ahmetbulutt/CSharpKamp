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
    public partial class FrmLocaiton : Form
    {
        public FrmLocaiton()
        {
            InitializeComponent();
        }
       
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
         

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());    
            location.LocationCity=txtName.Text;
            location.LocationCountry=txtCtry.Text;
            location.LocationPrice = decimal.Parse(textBox2.Text);
            location.DayNight=textDandN.Text;
            location.GuideId=int.Parse(cbmGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private void FrmLocaiton_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x=> new
            {
                FullName=x.GuideName+" " + x.GuideSurname,x.GuideId
            }).ToList();
            cbmGuide.DisplayMember = "FullName";
            cbmGuide.ValueMember = "GuideId";
            cbmGuide.DataSource= values;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedvalue = db.Location.Find(id);
            db.Location.Remove(deletedvalue);
            db.SaveChanges();
            MessageBox.Show("Silme İşemi Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtId.Text);
            var updatedValue=db.Location.Find(id);
            updatedValue.DayNight= textDandN.Text;
            updatedValue.LocationPrice= decimal.Parse(textBox2.Text);
            updatedValue.LocationCapacity= byte.Parse(nudCapacity.Value.ToString());
            updatedValue.LocationCity= txtName.Text;
            updatedValue.LocationCountry=txtCtry.Text;
            updatedValue.GuideId= int.Parse(cbmGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Günccelleme İşelmi Başarılı");



        }
    }
}
