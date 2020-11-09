using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_WInForm
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        Account account = new Account();

        SaleHistory sale = new SaleHistory();


        private void btAccount_Click(object sender, EventArgs e)
        {
            selectButtonChange(btAccount, btPayment);
            CallToChildForm(account);
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            selectButtonChange(btPayment, btAccount);
            CallToChildForm(sale);
        }

        private void Admin_Load(object sender, EventArgs e)
        {



            resize();
            selectButtonChange(btAccount, btPayment);
            CallToChildForm(account);
        }


        private void selectButtonChange(Button selected, Button deselected)
        {
            selected.BackColor = Color.White;
            selected.ForeColor = Color.Black;
            deselected.BackColor = Color.Black;
            deselected.ForeColor = Color.White;
        }

        private void resize()
        {

            pnlToolbox.Height = Convert.ToInt32(this.Height * 0.1);
            pnlToolbox.Width = this.Width;
            pnlMain.Height = this.Height - pnlToolbox.Height;
            pnlMain.Width = this.Width;
            btAccount.Width = Convert.ToInt32(pnlToolbox.Width / 2);
            btAccount.Height = pnlToolbox.Height;
            btAccount.Location = new Point(0, 0);
            btPayment.Height = btAccount.Height;
            btPayment.Width = btAccount.Width;
            btPayment.Location = new Point(btPayment.Width, 0);


        }



        private void CallToChildForm(object form)
        {

            if (pnlMain.Controls.Count > 0)
            {
                pnlMain.Controls.RemoveAt(0);
            }

            Form l = form as Form;
            l.TopLevel = false;
            l.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(l);
            l.Show();


        }

        private void Admin_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt chứ ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Environment.Exit(1);
            }
        }
    }
}
