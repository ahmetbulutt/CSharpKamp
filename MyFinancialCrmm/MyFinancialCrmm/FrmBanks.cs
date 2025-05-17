using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrmm.Models;
namespace MyFinancialCrmm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //BANKA BAKİYELERİ
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(x => x.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(x => x.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(x => x.BankBalance).FirstOrDefault();
            lblİsBankBalance.Text = isBankBalance.ToString() + "₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + "₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + "₺";

            // BANKA HAREKETLERİ
            var bankProcess1=db.BankProcesses.OrderBy(x=>x.BankProccesId).Take(1).FirstOrDefault();
            lblBankProcess1.Text= bankProcess1.Description+ " / " + bankProcess1.Amount+ " / " + bankProcess1.ProcessDate;


            var bankProcess2 = db.BankProcesses.OrderBy(x => x.BankProccesId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " / " + bankProcess2.Amount + " / " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderBy(x => x.BankProccesId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " / " + bankProcess3.Amount + " / " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderBy(x => x.BankProccesId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " / " + bankProcess4.Amount + " / " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderBy(x => x.BankProccesId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " / " + bankProcess5.Amount + " / " + bankProcess5.ProcessDate;


        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }
    }
}
