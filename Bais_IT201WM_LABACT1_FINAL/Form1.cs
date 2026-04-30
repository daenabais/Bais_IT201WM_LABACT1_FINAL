using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bais_IT201WM_LABACT1_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbxvehicle.Items.AddRange(new string[] { "Car", "Motorcycle", "Van" });
            cbxdiscount.Items.AddRange(new string[] { "Student", "Senior", "PWD" });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {


        }

        private void displayvehicle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void G5_Click(object sender, EventArgs e)
        {

        }

        private void G4_Click(object sender, EventArgs e)
        {

        }

        private void G3_Click(object sender, EventArgs e)
        {

        }

        private void G2_Click(object sender, EventArgs e)
        {

        }

        private void G1_Click(object sender, EventArgs e)
        {

        }

        private void E5_Click(object sender, EventArgs e)
        {

        }

        private void E4_Click(object sender, EventArgs e)
        {

        }

        private void E3_Click(object sender, EventArgs e)
        {

        }

        private void E2_Click(object sender, EventArgs e)
        {

        }

        private void E1_Click(object sender, EventArgs e)
        {

        }

        private void D5_Click(object sender, EventArgs e)
        {

        }

        private void D4_Click(object sender, EventArgs e)
        {

        }

        private void D3_Click(object sender, EventArgs e)
        {

        }

        private void D2_Click(object sender, EventArgs e)
        {

        }

        private void C5_Click(object sender, EventArgs e)
        {

        }

        private void C4_Click(object sender, EventArgs e)
        {

        }

        private void C3_Click(object sender, EventArgs e)
        {

        }

        private void C2_Click(object sender, EventArgs e)
        {

        }

        private void C1_Click(object sender, EventArgs e)
        {

        }

        private void B5_Click(object sender, EventArgs e)
        {

        }

        private void B4_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void B2_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void A5_Click(object sender, EventArgs e)
        {

        }

        private void A4_Click(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {

        }

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {

        }

        private void F5_Click(object sender, EventArgs e)
        {

        }

        private void F4_Click(object sender, EventArgs e)
        {

        }

        private void F3_Click(object sender, EventArgs e)
        {

        }

        private void F2_Click(object sender, EventArgs e)
        {

        }

        private void btnregistervehicle_Click(object sender, EventArgs e)
        {
            string plate = txtplate.Text;
            string type = cbxvehicle.SelectedItem.ToString();
            int hours = int.Parse(txthours.Text);
            string slot = txtslot.Text;
            string discount = cbxdiscount.SelectedItem?.ToString();

  
            ParkingClass record = new ParkingClass(plate, type, hours, slot);


            rtxtreceipt.Text = record.GenerateReceipt(discount);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void txtslot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthours_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxvehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtplate_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayservicecharge_Click(object sender, EventArgs e)
        {

        }

        private void displaystandardfee_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void btnprocess_Click(object sender, EventArgs e)
        {

        }

        private void rtxtreceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpayamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxdiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void displaychange_Click(object sender, EventArgs e)
        {

        }

        private void displayovertime_Click(object sender, EventArgs e)
        {

        }

        private void displayslot_Click(object sender, EventArgs e)
        {

        }

        private void displayduration_Click(object sender, EventArgs e)
        {

        }

        private void displayplatenumber_Click(object sender, EventArgs e)
        {

        }

        private void F1_Click(object sender, EventArgs e)
        {

        }
    }
}
