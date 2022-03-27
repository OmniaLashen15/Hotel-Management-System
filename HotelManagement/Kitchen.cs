using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginEF;
using EFDay15;
using LoginEF.Context;
using EFDay15.Context;
using HotelManagement.Context;

namespace HotelManagement
{

    public partial class Kitchen : Form
    {
    int breakfast, lunch, dinner, foodBill;
        string cleaning, towel, surprise, queryString;
        public Int32 primaryID;
        double totalBill;

        bool supply_status = false;

        public Kitchen()
        {
            InitializeComponent();
        }
        FrontEndReservationContext Context = new();
       

        private void Kitchen_Load(object sender, EventArgs e)
        {
            OverviewDataGridView();
            listBoxDataBase();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
                if (primaryID > 1000)
                {
                    var result = (from R in Context.Reservations
                                  where R.Id == primaryID
                                  select R).FirstOrDefault();

            try
            {
                        result.TotalBill = totalBill + foodBill;
                        result.BreakFast = breakfast;
                        result.Lunch = lunch;
                        result.Dinner = dinner;
                        result.SupplyStatus = supply_status;
                        result.Cleaning = Convert.ToBoolean(Convert.ToInt32(cleaning));
                        result.Towel = Convert.ToBoolean(Convert.ToInt32(towel));
                        result.SSurprise = Convert.ToBoolean(Convert.ToInt32(surprise));
                        result.FoodBill = foodBill;
                    Context.SaveChanges();
                    
                    string userID = Convert.ToString(primaryID);

                    MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                    " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    listBoxDataBase();
                    OverviewDataGridView();
                    resetEntries(this);

                }

             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                else
                {
                    MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        
    }
        }

        private void OverviewDataGridView()
        {
            var results = (from F in Context.Reservations
                           where F.CheckIn == true && F.SupplyStatus == false
                           select F).ToList();

            overviewDataGridView.DataSource = results;
        }
        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }

        private void queueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetEntries(this);
            var getQuerstring = queueListBox.Text.Substring(0, 4).Replace(" ", String.Empty);
            var result = (from F in Context.Reservations
                          where F.Id.ToString() == getQuerstring
                          select F).ToList();
            foreach (var item in result)
            {
                string ID = item.Id.ToString();
                string first_name = item.FirstName.ToString();
                string last_name = item.LastName.ToString();
                string phone_number = item.PhoneNumber.ToString();
                string foodBillD = item.FoodBill.ToString();
                string total_bill = item.TotalBill.ToString().Replace(" ", string.Empty);
                string room_type = item.RoomType.ToString();
                string room_floor = item.RoomFloor.ToString();
                string room_number = item.RoomNumber.ToString();

                string _cleaning = item.Cleaning.ToString();
                string _towel = item.Towel.ToString();
                string _surprise = item.SSurprise.ToString();

                if (_cleaning == "True")
                {
                    cleaning = "1";
                    cleaningCheckBox.Checked = true;
                }
                else { cleaning = "0"; }

                if (_towel == "True")
                {
                    towel = "1";
                    towelCheckBox.Checked = true;
                }
                else { towel = "0"; }
                if (_surprise == "True")
                {
                    surprise = "1";
                    surpriseCheckBox.Checked = true;
                }
                else
                {
                    surprise = "0";
                }
                string supply_status = item.SupplyStatus.ToString();
                string food_billD = item.FoodBill.ToString();

                string _breakfast = item.BreakFast.ToString();
                string _lunch = item.Lunch.ToString();
                string _dinner =item.Dinner.ToString();
                double Num;
                bool isNum = double.TryParse(_lunch, out Num);
                if (isNum)
                {
                    lunch = Int32.Parse(_lunch);
                    lunchTextBox.Text = Convert.ToString(lunch);
                }
                else
                {
                    lunch = 0;
                    lunchTextBox.Text = "NONE";
                }
                isNum = double.TryParse(_breakfast, out Num);
                if (isNum)
                {
                    breakfast = Int32.Parse(_breakfast);
                    breakfastTextBox.Text = Convert.ToString(breakfast);
                }
                else
                {
                    breakfast = 0;
                    breakfastTextBox.Text = "NONE";
                }
                isNum = double.TryParse(_dinner, out Num);
                if (isNum)
                {
                    dinner = Int32.Parse(_dinner);
                    dinnerTextBox.Text = Convert.ToString(dinner);
                }
                else
                {
                    dinner = 0;
                    dinnerTextBox.Text = "NONE";
                }

                if (supply_status == "True")
                {
                    supplyCheckBox.Checked = true;
                }
                else
                {
                    supplyCheckBox.Checked = false;
                }

                firstNameTextBox.Text = first_name;
                lastNameTextBox.Text = last_name;
                PhoneNumberTextBox.Text = phone_number;
                RoomTypeTextBox.Text = room_type;
                floorTextBox.Text = room_floor;
                Roomtextbox.Text = room_number;
                totalBill = Convert.ToDouble(total_bill);
                foodBill = Convert.ToInt32(foodBillD);
                totalBill -= foodBill;
                primaryID = Convert.ToInt32(ID);

            }
        }
        private void listBoxDataBase()
        {
            var result = (from F in Context.Reservations
                          where F.CheckIn == true && F.SupplyStatus == false
                          select F).ToList();
            foreach(var item in result)
            {
                queueListBox.Items.Add(item.Id + " | "+item.FirstName+" | "+item.LastName+" | "+item.PhoneNumber);
            }
        }
        private void  foodSelectionButton_Click(object sender, EventArgs e)
        {
            FoodMenu menu = new FoodMenu();
            menu.needPanel.Visible = false;
            menu.ShowDialog();

            breakfast = menu.BreakfastQ;
            lunch = menu.LunchQ;
            dinner = menu.DinnerQ;


            int bfast = 0, Lnch = 0, di_ner = 0;
            if (breakfast > 0)
            {
                bfast = 7 * breakfast;
            }
            if (lunch > 0)
            {
                Lnch = 15 * lunch;
            }
            if (dinner > 0)
            {
                di_ner = 15 * dinner;
            }
            foodBill += (bfast + Lnch + di_ner);

        }

        private void supplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cleaningCheckBox.Checked = false;
            cleaningCheckBox.Text = "Cleaned";
            towelCheckBox.Checked = false;
            towelCheckBox.Text = "Toweled";
            surpriseCheckBox.Checked = false;
            surpriseCheckBox.Text = "Surprised";
            supply_status = true;
        }
    }
}
