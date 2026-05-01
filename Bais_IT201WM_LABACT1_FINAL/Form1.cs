using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bais_IT201WM_LABACT1_FINAL
{
    public partial class Form1 : Form
    {
        private List<ParkingClass> records = new List<ParkingClass>();
        public Form1()
        {

            InitializeComponent();

            cbxvehicle.Items.AddRange(new string[] { "Car", "Motorcycle", "Van" });
            cbxdiscount.Items.AddRange(new string[] { "Student", "Senior", "PWD" });

            
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn &&
                        (btn.Name.StartsWith("A") || btn.Name.StartsWith("B") ||
                         btn.Name.StartsWith("C") || btn.Name.StartsWith("D") ||
                         btn.Name.StartsWith("E") || btn.Name.StartsWith("F") ||
                         btn.Name.StartsWith("G")))
                    {
                        btn.Click += Slot_Click;
                        btn.BackColor = Color.Lime;
                    }
                
            }
        }
        private void Slot_Click(object sender, EventArgs e)
        {
            ToggleSlotColor(sender as Button);
        }

        private void ToggleSlotColor(Button btn)
        {
            if (btn.BackColor == Color.Lime)
            {
                btn.BackColor = Color.Red;   
            }
            else
            {
                btn.BackColor = Color.Lime; 
            }

            
            txtslot.Text = btn.Text;
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

            displayplatenumber.Text = txtplate.Text;
            displayvehicle.Text = cbxvehicle.SelectedItem?.ToString();
            displayduration.Text = txthours.Text + " hours";
            displayslot.Text = txtslot.Text;
            displaystandardfee.Text = "₱" + record.ParkingFee.ToString("F2");
            displayservicecharge.Text = "₱20";


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string plate = txtplate.Text;

            ParkingClass record = records.FirstOrDefault(r => r.PlateNumber == plate);

            if (record != null)
            {
                record.VehicleType = cbxvehicle.SelectedItem.ToString();
                record.HoursParked = int.Parse(txthours.Text);
                record.SlotNumber = txtslot.Text;

                string discount = cbxdiscount.SelectedItem?.ToString();

          
                rtxtreceipt.Text = record.GenerateReceipt(discount);

               
                displayplatenumber.Text = record.PlateNumber;
                displayvehicle.Text = record.VehicleType;
                displayduration.Text = record.HoursParked + " hours";
                displayslot.Text = record.SlotNumber;
                displaystandardfee.Text = "₱" + record.ParkingFee.ToString("F2");
                displayservicecharge.Text = "₱20";

                MessageBox.Show("Record updated successfully!");
            }
            else
            {
                MessageBox.Show("No record found with plate number: " + plate);
            }
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
            txtplate.Clear();
            txthours.Clear();
            txtslot.Clear();
            txtpayamount.Clear();
            cbxvehicle.SelectedIndex = -1;
            cbxdiscount.SelectedIndex = -1;


            displaychange.Text = "";
            displaystandardfee.Text = "";
            displayservicecharge.Text = "";
            displayovertime.Text = "";
            displayplatenumber.Text = "";
            displayvehicle.Text = "";
            displayduration.Text = "";

           



        }

        private void button40_Click(object sender, EventArgs e)
        {
            string plate = txtplate.Text;
            string type = cbxvehicle.SelectedItem?.ToString();
            int hours = int.Parse(txthours.Text);
            string slot = txtslot.Text;
            string discount = cbxdiscount.SelectedItem?.ToString();

            ParkingClass record = new ParkingClass(plate, type, hours, slot);

            rtxtreceipt.Text = record.GenerateReceipt(discount);

        
            displayplatenumber.Text = plate;
            displayvehicle.Text = type;
            displayduration.Text = hours + " hours";
            displayslot.Text = slot;
            displaystandardfee.Text = "₱" + record.ParkingFee.ToString("F2");
            displayservicecharge.Text = "₱20";

      
            if (hours > 8)
                displayovertime.Text = "Overtime Fee: ₱100";
            else
                displayovertime.Text = "No Overtime";
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            string discount = cbxdiscount.SelectedItem?.ToString();
            ParkingClass record = new ParkingClass(
                txtplate.Text,
                cbxvehicle.SelectedItem.ToString(),
                int.Parse(txthours.Text),
                txtslot.Text
            );

            double finalFee = string.IsNullOrEmpty(discount) ? record.ParkingFee : record.ApplyDiscount(discount);

            decimal payAmount = decimal.Parse(txtpayamount.Text);
            decimal change = payAmount - (decimal)finalFee;

           
            displaychange.Text = "₱" + change;
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
            string discount = cbxdiscount.SelectedItem?.ToString();
            ParkingClass record = new ParkingClass(txtplate.Text, cbxvehicle.SelectedItem.ToString(), int.Parse(txthours.Text), txtslot.Text);
            double finalFee = string.IsNullOrEmpty(discount) ? record.ParkingFee : record.ApplyDiscount(discount);

            decimal payAmount = decimal.Parse(txtpayamount.Text);
            decimal change = payAmount - (decimal)finalFee;

            MessageBox.Show("₱" + change);
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
