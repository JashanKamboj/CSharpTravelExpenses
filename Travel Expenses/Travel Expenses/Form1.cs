using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Expenses
{
    public partial class travelExpenseForm : Form
    {
        const double regAmt = 2645.34;
        public travelExpenseForm()
        {
            InitializeComponent();
        }

        private void clearBttn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void travelExpenseForm_Load(object sender, EventArgs e)
        {
            eventsListBx.SetSelected(0, true);
            dayListBox.SetSelected(0, true);
            carRentalListBx.SetSelected(0,true);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double CalculateAirfare()
        {
            double airfare;
            double.TryParse(airfareTxtBx.Text, out airfare);
            return airfare;
        }

        private double CalculateTaxiFare()
        {
            double taxifare;
            double.TryParse(taxiFareTxtBx.Text, out taxifare);
            return taxifare;
        }

        private double CalculateCarRental()
        {
            double carRentPerDay;
            double parking;
            double.TryParse(carRentalDayTxtBox.Text,out carRentPerDay);
            double.TryParse(parkingTxtBx.Text, out parking);
            int days= Convert.ToInt16(carRentalListBx.SelectedItem.ToString().Split(' ').GetValue(0));
            return carRentPerDay * days + parking;
        }

        private double CalculateCarPrivate()
        {
            double privateMiles;
            double parking;
            double.TryParse(privateMilesTxtBx.Text, out privateMiles);
            double.TryParse(parking2TxtBx.Text, out parking);
            return (privateMiles*0.32) + parking;
        }

        private double CalculateEvent()
        {
            double eventAmt=0;
            if (eventsListBx.SelectedItem.ToString().Contains("Advanced Programming"))
                eventAmt = 472.93;
            else if (eventsListBx.SelectedItem.ToString().Contains("Cloud Computing"))
                eventAmt = 789.34;
            else if (eventsListBx.SelectedItem.ToString().Contains("NetWork Security"))
                eventAmt = 220.45;
            else if (eventsListBx.SelectedItem.ToString().Contains("IT Security Seminar"))
                eventAmt = CalculateITSeminar();
            return eventAmt;
        }

        private double CalculateITSeminar()
        {
            double itSeminarAmt = 0;
            if (encryptionCheckBx.Checked)
                itSeminarAmt += 250.23;
            if (OSSecurityCheckBx.Checked)
                itSeminarAmt += 347.51;
            if (typesOfAttackCheckBx.Checked)
                itSeminarAmt += 150.94;
            return itSeminarAmt;
        }

        private double CalculateLodging()
        {
            return Convert.ToDouble(amountDayTxtBox.Text) * Convert.ToInt16(dayListBox.SelectedItem.ToString().Split(' ').GetValue(0));
        }

        private double CalculateReimbursement(double amount,double regamount,double higheramount)
        {
            double reimburse;
            if (amount <= regAmt)
                reimburse = (9.6 * amount) / 100;
            else
                reimburse = ((9.6 * regamount) / 100) + ((14.8*(higheramount))/100);
            return reimburse;       
        }

        private void ClearITSecurity()
        {
            encryptionCheckBx.Checked = false;
            OSSecurityCheckBx.Checked = false;
            typesOfAttackCheckBx.Checked = false;
        }

        private void ClearTextBoxes()
        {
            amountDayTxtBox.Text = "";
            airfareTxtBx.Text = "";
            carRentalDayTxtBox.Text = "";
            parkingTxtBx.Text = "";
            parking2TxtBx.Text = "";
            privateMilesTxtBx.Text = "";
            taxiFareTxtBx.Text = "";
            encryptionCheckBx.Checked = false;
            OSSecurityCheckBx.Checked = false;
            typesOfAttackCheckBx.Checked = false;
        }

        private void AddDays(ref ListBox listAddress,string days)
        {
            var findNum = days.Split(' ');
            int numdays;
            int.TryParse(findNum[0],out numdays);
            listAddress.Items.Clear();
            for (int i = 0; i < numdays; i++)
                listAddress.Items.Add(i + 1 + " Day(s)");
        }

        private void dayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDays(ref carRentalListBx, dayListBox.SelectedItem.ToString());
            carRentalListBx.SetSelected(0, true);
        }

        private void eventsListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsListBx.SelectedItem.ToString().Equals("IT Security Seminar"))
            {
                ITSecurityGrpBx.Visible = true;
                encryptionCheckBx.Checked = true;
            }
            else
                ITSecurityGrpBx.Visible = false;
        }

        private void resetEventsBttn_Click(object sender, EventArgs e)
        {
            ClearITSecurity();
            ITSecurityGrpBx.Visible = false;
            eventsListBx.SetSelected(0, true);
        }

        private void calculateBttn_Click(object sender, EventArgs e)
        {
            bool dispErr = false;
            double amt;
            double higherAmt;
            double reimbursementAmt;
            if(eventsListBx.SelectedIndex!=-1)
            {
                amt = CalculateLodging() + CalculateAirfare() + CalculateEvent() + CalculateCarPrivate() + CalculateCarRental() + CalculateTaxiFare();
                higherAmt = amt - regAmt;
                reimbursementAmt = CalculateReimbursement(amt, regAmt, higherAmt);
            }
            else
            {
                amt = 0;
                reimbursementAmt = 0;
                dispErr = true;
            }
            
            totalExpensesTxtBx.Text = amt.ToString("c2");
            reimbursementTxtBx.Text = reimbursementAmt.ToString("c2");
            youPayTxtBx.Text = (amt - reimbursementAmt).ToString("c2");
            if (dispErr)
                MessageBox.Show("Please select an event");
        }
    }
}
