using HotelManagement.Context;
using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;


namespace HotelManagement
{
    public partial class FrontEnd : Form,IDisposable
    {
        FrontEndReservationContext Context = new();

        string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
        string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
        string RecvPhoneNumber = string.Empty;

        public void Dispose()
        {    // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
        public FrontEnd()
        {
            InitializeComponent();
            CenterToScreen();
            entryDatePicker.MinDate = DateTime.Today;
            depDatePicker.MinDate = DateTime.Today.AddDays(1);

            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();

            //this.roomOccupiedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            //this.roomOccupiedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomOccupiedListBox_DrawItem);
            //this.roomReservedListBox.DrawMode = DrawMode.OwnerDrawFixed;
            //this.roomReservedListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.roomReservedListBox_DrawItem);

        }


        private string getval;

        public string Getval
        {
            get { return getval; }
            set { getval = value; }
        }

        public string towelS, cleaningS, surpriseS;

        public int foodBill;
        public string birthday = string.Empty;

        public string food_menu = string.Empty;
        public int totalAmount = 0;
        public int checkin = 0;
        public int foodStatus = 0;
        public Int32 primartyID = 0;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;
        public string FPayment, FCnumber, FcardExpOne, FcardExpTwo, FCardCVC;
        private double finalizedTotalAmount = 0.0;
        private string paymentType;
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;
        private int dinner = 0;
        private string cleaning; private string towel;
        private string surprise;

        private int lunch = 0; private int breakfast = 0;
        Reservation reservation = new();

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 149;
                floorComboBox.SelectedItem = "1";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 299;
                floorComboBox.SelectedItem = "2";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Twin"))
            {
                totalAmount = 349;
                floorComboBox.SelectedItem = "3";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Duplex"))
            {
                totalAmount = 399;
                floorComboBox.SelectedItem = "4";
            }
            else if (roomTypeComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 499;
                floorComboBox.SelectedItem = "5";
            }
            int selectedTemp = 0;
            string selected;
            bool temp = int.TryParse(qtGuestComboBox.SelectedItem.ToString(), out selectedTemp);
            if (!temp)
            {
                MessageBox.Show(this, "Enter # of guests first", "Error parsing", MessageBoxButtons.OK);
            }
            else
            {
                selected = qtGuestComboBox.SelectedItem.ToString();
                selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    totalAmount += (selectedTemp * 5);
                }
            }

        }
        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
            entryDatePicker.MinDate = new DateTime(2014, 4, 1);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Format = DateTimePickerFormat.Custom;

            depDatePicker.MinDate = new DateTime(2014, 4, 1);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Format = DateTimePickerFormat.Custom;

            btnSubmit.Visible = false;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            resEditButton.Visible = true;

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
        }
        private void newButton_Click(object sender, EventArgs e)
        {

            btnSubmit.Visible = true;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            resEditButton.Visible = false;
            reset_frontend();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            birthday = (monthComboBox.SelectedItem) + "-" + (dayComboBox.SelectedIndex + 1) + "-" + yearTextBox.Text;
            Int32 getIDBack = 0;

            reservation.FirstName = firstNameTextBox.Text;
            reservation.LastName = lastNameTextBox.Text;
            reservation.BirthDay = birthday;
            reservation.Gender = genderComboBox.SelectedItem.ToString();
            reservation.PhoneNumber = phoneNumberTextBox.Text;
            reservation.EmailAddress = emailTextBox.Text;
            reservation.NumberGuest = qtGuestComboBox.SelectedIndex + 1;
            reservation.StreetAddress = addLabel.Text;
            reservation.AptSuite = aptTextBox.Text;
            reservation.City = cityTextBox.Text;
            reservation.State = stateComboBox.SelectedItem.ToString();
            reservation.ZipCode = zipTexBox.Text;
            reservation.RoomType = roomTypeComboBox.SelectedItem.ToString();
            reservation.RoomFloor = floorComboBox.SelectedItem.ToString();
            reservation.RoomNumber = roomNComboBox.SelectedItem.ToString();
            reservation.TotalBill = finalizedTotalAmount;
            reservation.PaymentType = paymentType;
            reservation.CardType = CardType;
            reservation.CardNumber = paymentCardNumber;
            reservation.CardExp = MM_YY_Of_Card;
            reservation.CardCvc = CVC_Of_Card;
            reservation.ArrivalTime = entryDatePicker.Value;
            reservation.LeavingTime = depDatePicker.Value;
            reservation.CheckIn = Convert.ToBoolean(checkin);
            reservation.BreakFast = breakfast;
            reservation.Lunch = lunch;
            reservation.Dinner = dinner;
            reservation.SupplyStatus = Convert.ToBoolean(foodStatus);
            reservation.Cleaning = Convert.ToBoolean(Convert.ToInt32(cleaning));
            reservation.Towel = Convert.ToBoolean(Convert.ToInt32(towel));
            reservation.SSurprise = Convert.ToBoolean(Convert.ToInt32(surprise));
            reservation.FoodBill = foodBill;
            
            Context.Add(reservation);
            Context.SaveChanges();
            try
            {
                getIDBack = (from R in Context.Reservations
                             orderby R.Id
                             select R.Id).Last();
                string userID = Convert.ToString(getIDBack);
                SendSMS(getIDBack);
                MessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                    "Provide this unique ID to the customer." + "\n\n" +
                "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        private void FrontEnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(primartyID>1000)
            {
                var result=(from R in Context.Reservations
                            where R.Id==primartyID
                            select R).FirstOrDefault();
           
                Context.Reservations.Remove(result);
                Context.SaveChanges();
                try
                {

                    MessageBox.Show(this, "Reservation For the UNIQUE USER ID of: " + "\n\n" +
                " " + primartyID + " is DELETED.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Selected ID doesn't exist." + ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_frontend();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();


        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            var result = (from R in Context.Reservations
                          where R.Id == primartyID
                          select R).First();
            result.FirstName = firstNameTextBox.Text;
            result.LastName = lastNameTextBox.Text;
            result.BirthDay = birthday;
            result.Gender = genderComboBox.SelectedItem.ToString();
            result.PhoneNumber = phoneNumberTextBox.Text;
            result.EmailAddress = emailTextBox.Text;
            result.NumberGuest = qtGuestComboBox.SelectedIndex + 1;
            result.StreetAddress = addLabel.Text;
            result.AptSuite = aptTextBox.Text;
            result.City = cityTextBox.Text;
            result.State = stateComboBox.SelectedItem.ToString();
            result.ZipCode = zipTexBox.Text;
            result.RoomType = roomTypeComboBox.SelectedItem.ToString();
            result.RoomFloor = floorComboBox.SelectedItem.ToString();
            result.RoomNumber = roomNComboBox.SelectedItem.ToString();
            result.TotalBill = finalizedTotalAmount;
            result.PaymentType = paymentType;
            result.CardType = CardType;
            result.CardNumber = paymentCardNumber;
            result.CardExp = MM_YY_Of_Card;
            result.CardCvc = CVC_Of_Card;
            result.ArrivalTime = entryDatePicker.Value;
            result.LeavingTime = depDatePicker.Value;
            result.CheckIn = Convert.ToBoolean(checkin);
            result.BreakFast = breakfast;
            result.Lunch = lunch;
            result.Dinner = dinner;
            result.SupplyStatus = Convert.ToBoolean(foodStatus);
            result.Cleaning = Convert.ToBoolean(Convert.ToInt32(cleaning));
            result.Towel = Convert.ToBoolean(Convert.ToInt32(towel));
            result.SSurprise = Convert.ToBoolean(Convert.ToInt32(surprise));
            result.FoodBill = foodBill;

            Context.SaveChanges();
            try
            {
                string userID = Convert.ToString(primartyID);
                

                MessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                SendSMS(primartyID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();

            reset_frontend();
            LoadForDataGridView();
            GetOccupiedRoom();
            ReservedRoom();
            getChecked();
        }
        private void checkinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinCheckBox.Checked)
            {
                checkinCheckBox.Text = "Checked in";
                checkin = 1;
            }
            else
            {
                checkin = 0;
                checkinCheckBox.Text = "Check in ?";
            }
        }
        private void resEditButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            getChecked();
            string getQuerystring = resEditButton.Text.Substring(0, 4).Replace(" ", string.Empty);
            var query = (from R in Context.Reservations
                            where R.Id==int.Parse(getQuerystring)
                            select R).ToList();

            try
            {
                foreach(var item in query)                {
                    taskFinder = true;
                    string ID = item.Id.ToString();
                    string first_name = item.FirstName.ToString();
                    string last_name = item.LastName.ToString();
                    string birth_day = item.BirthDay.ToString();
                    string gender = item.Gender.ToString();
                    string phone_number = item.PhoneNumber.ToString();
                    string email_address = item.EmailAddress.ToString();
                    string number_guest = item.NumberGuest.ToString();
                    string street_address = item.StreetAddress.ToString();
                    string apt_suite = item.AptSuite.ToString();
                    string city = item.City.ToString();
                    string state = item.State.ToString();
                    string zip_code = item.ZipCode.ToString();

                    string room_type = item.RoomType.ToString();
                    string room_floor = item.RoomFloor.ToString();
                    string room_number = item.RoomNumber.ToString();

                    string payment_type = item.CardType.ToString();
                    string card_number = item.CardNumber.ToString();
                    string card_exp = item.CardExp.ToString();
                    string card_cvc = item.CardCvc.ToString();

                    string _cleaning = item.Cleaning.ToString();
                    string _towel = item.Towel.ToString();
                    string _surprise = item.SSurprise.ToString();
                    if (_cleaning == "True")
                    {
                        cleaning = "1";
                    }
                    else { cleaning = "0"; }

                    if (_towel == "True")
                    {
                        towel = "1";
                    }
                    else { towel = "0"; }
                    if (_surprise == "True")
                    {
                        surprise = "1";
                    }
                    else
                    {
                        surprise = "0";
                    }
                    roomNComboBox.Items.Add(room_number);
                    roomNComboBox.SelectedItem = room_number;

                    FPayment = payment_type; FCnumber = card_number;
                    FCardCVC = card_cvc; FcardExpOne = card_exp.Substring(0, card_exp.IndexOf('/'));
                    FcardExpTwo = card_exp.Substring(card_exp.Length - Math.Min(2, card_exp.Length));
                    string check_in = item.CheckIn.ToString();

                    string supply_status = item.SupplyStatus.ToString();
                    string food_billD = item.FoodBill.ToString();

                    string arrival_date = Convert.ToDateTime(item.ArrivalTime).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                    entryDatePicker.Value = Convert.ToDateTime(arrival_date);

                    string leaving_date = Convert.ToDateTime(item.LeavingTime).ToString("MM-dd-yyyy").Replace(" ", string.Empty);
                    depDatePicker.Value = Convert.ToDateTime(leaving_date);
                    entryDatePicker.Value.ToShortDateString();
                    depDatePicker.Value.ToShortDateString();

                    string _breakfast = item.BreakFast.ToString();
                    string _lunch = item.Lunch.ToString();
                    string _dinner = item.Dinner.ToString();

                    double Num;
                    bool isNum = double.TryParse(_lunch, out Num);
                    if (isNum)
                    {
                        lunch = Int32.Parse(_lunch);
                    }
                    else
                    {
                        lunch = 0;
                    }
                    isNum = double.TryParse(_breakfast, out Num);
                    if (isNum)
                    {
                        breakfast = Int32.Parse(_breakfast);
                    }
                    else
                    {
                        breakfast = 0;
                    }
                    isNum = double.TryParse(_dinner, out Num);
                    if (isNum)
                    {
                        dinner = Int32.Parse(_dinner);
                    }
                    else
                    {
                        dinner = 0;
                    }



                    foodBill = Convert.ToInt32(food_billD);

                    if (supply_status == "True")
                    {
                        foodSupplyCheckBox.Checked = true;
                    }
                    else
                    {
                        foodSupplyCheckBox.Checked = false;
                    }


                    firstNameTextBox.Text = first_name;
                    lastNameTextBox.Text = last_name;
                    phoneNumberTextBox.Text = phone_number;
                    genderComboBox.SelectedItem = gender;

                    monthComboBox.SelectedItem = birth_day.Substring(0, birth_day.IndexOf('-'));
                    dayComboBox.SelectedItem = birth_day.Substring(birth_day.IndexOf('-') + 1, 2);
                    yearTextBox.Text = birth_day.Substring(birth_day.Length - Math.Min(4, birth_day.Length));

                    emailTextBox.Text = email_address;
                    qtGuestComboBox.SelectedItem = number_guest;
                    addLabel.Text = street_address;
                    aptTextBox.Text = apt_suite;
                    cityTextBox.Text = city;
                    stateComboBox.SelectedItem = state;
                    zipTexBox.Text = zip_code;
                    roomTypeComboBox.SelectedItem = room_type.Replace(" ", string.Empty);
                    floorComboBox.SelectedItem = room_floor.Replace(" ", string.Empty);
                    roomNComboBox.SelectedItem = room_number.Replace(" ", string.Empty);

                    if (check_in == "True")
                    {
                        checkinCheckBox.Checked = true;
                    }
                    else
                    {
                        checkinCheckBox.Checked = false;
                    }


                    primartyID = Convert.ToInt32(ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("COMBOBOX Selection: + " + ex.Message);
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypeComboBox)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                resEditButton.Items.Clear();
                checkinCheckBox.Checked = false;
                foodSupplyCheckBox.Checked = false;

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);

                ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void foodSupplyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (foodSupplyCheckBox.Checked)
            {
                foodSupplyCheckBox.Text = "Food/Supply: Complete";
                foodStatus = 1;
            }
            else
            {
                foodStatus = 0;
                foodSupplyCheckBox.Text = "Food/Supply status?";
            }
        }
        private void GetOccupiedRoom()
        {
           // roomOccupiedListBox.Items.Clear();
            var query = (from F in Context.Reservations
                         where F.CheckIn == true
                         select new{F.RoomNumber,F.RoomType,F.Id, FullName = F.FirstName + " " + F.LastName, F.PhoneNumber }).ToList();
            try
            {
                //foreach(var item in query)
                //{
                //    string room_number = item.RoomNumber.ToString();
                //    string room_type = item.RoomType.ToString();
                //    string ID = item.Id.ToString();
                //    string first_name = item.FirstName.ToString();
                //    string last_name = item.LastName.ToString();
                //    string phone_number = item.PhoneNumber.ToString();
                //    string arrival_time = item.ArrivalTime.ToString();
                //    string dep_time = item.LeavingTime.ToString();
                //    roomOccupiedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                //        " " + room_type.Replace(" ", string.Empty) +
                //        " " + ID.Replace(" ", string.Empty) +
                //        " " + "[" + first_name.Replace(" ", string.Empty) +
                //        " " + last_name.Replace(" ", string.Empty) + "]" +
                //        " " + phone_number.Replace(" ", string.Empty));
                dataGridViewOccupied.DataSource=query;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //private void roomOccupiedListBox_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    this.roomOccupiedListBox.IntegralHeight = false;
        //    this.roomOccupiedListBox.ItemHeight = 25;
        //    e.DrawBackground();
        //    Font listBoxFont;
        //    Brush brush;

        //    int i = e.Index;

        //    listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
        //    brush = Brushes.Black;
        //    e.Graphics.DrawString(roomOccupiedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        //}

        //private void roomReservedListBox_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    this.roomReservedListBox.IntegralHeight = false;
        //    this.roomReservedListBox.ItemHeight = 25;
        //    e.DrawBackground();
        //    Font listBoxFont;
        //    Brush brush;

        //    int i = e.Index;

        //    listBoxFont = new Font("Segoe UI Symbol", 12.0f, FontStyle.Regular);
        //    brush = Brushes.Black;
        //    e.Graphics.DrawString(roomReservedListBox.Items[i].ToString(), listBoxFont, brush, e.Bounds, StringFormat.GenericTypographic);

        //}
        private void ReservedRoom()
        {
            //roomReservedListBox.Items.Clear();

            var query = (from F in Context.Reservations
                         where F.CheckIn == false
                         select new { F.RoomNumber, F.RoomType, F.Id, FullName=F.FirstName+" "+F.LastName, F.PhoneNumber }).ToList();
            try
            {
                //foreach (var item in query)
                //{
                //    string room_number = item.RoomNumber.ToString();
                //    string room_type = item.RoomType.ToString();
                //    string ID = item.Id.ToString();
                //    string first_name = item.FirstName.ToString();
                //    string last_name = item.LastName.ToString();
                //    string phone_number = item.PhoneNumber.ToString();
                //    string arrival_time = item.ArrivalTime.ToString();
                //    string dep_time = item.LeavingTime.ToString();
                //    roomOccupiedListBox.Items.Add("[" + room_number.Replace(" ", string.Empty) + "]" +
                //        " " + room_type.Replace(" ", string.Empty) +
                //        " " + ID.Replace(" ", string.Empty) +
                //        " " + "[" + first_name.Replace(" ", string.Empty) +
                //        " " + last_name.Replace(" ", string.Empty) + "]" +
                //        " " + phone_number.Replace(" ", string.Empty));
                //}
                dataGridViewReversed.DataSource=query;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void getChecked()
        {
            List<string> TakenRoomList = new List<string>();


            var query = (from F in Context.Reservations
                         where F.CheckIn == true
                         select F).ToList();
            try
            {

                foreach (var item in query)
                {
                    string room_number = item.RoomNumber.ToString();
                    TakenRoomList.Add(room_number.Replace(" ", string.Empty));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (string roomList in TakenRoomList)
            {
                if (roomNComboBox.Items.Contains(roomList))
                {

                    int temp = roomNComboBox.Items.IndexOf(roomList);
                    roomNComboBox.Items.RemoveAt(temp);
                }
            }
        }
        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            RecvPhoneNumber = "+1" + phoneNumberTextBox.Text.Replace(" ", string.Empty);
            long getphn = Convert.ToInt64(phoneNumberTextBox.Text);
            string formatString = String.Format("{0:(000)000-0000}", getphn);
            phoneNumberTextBox.Text = formatString;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {

            var query = (from R in Context.Reservations
                         where R.Id.ToString().Contains(searchTextBox.Text) || R.LastName.Contains(searchTextBox.Text)
                         || R.FirstName.Contains(searchTextBox.Text) || R.Gender.Contains(searchTextBox.Text)
                         || R.State.Contains(searchTextBox.Text) || R.City.Contains(searchTextBox.Text)
                         || R.RoomNumber.Contains(searchTextBox.Text) || R.RoomType.Contains(searchTextBox.Text)
                         || R.EmailAddress.Contains(searchTextBox.Text) || R.PhoneNumber.Contains(searchTextBox.Text)
                         select R).ToList();
            searchDataGridView.DataSource = query;

            if (query.Count>0)
            {
                searchButton.Location = new Point(752, 20);
                searchTextBox.Location = new Point(68, 25);
                searchDataGridView.Visible = true;
                SearchError.Visible = false;

            }
            else
            {
                searchDataGridView.Visible = false;
                SearchError.Visible = true;
                SearchError.Text = "SORRY DUDE :(" + "\n"
                    + "I ran out of gas trying to search for " + searchTextBox.Text + "\n"
                + "I sure will find it next time.";
            }
        }
        private void finalizeButton_Click(object sender, EventArgs e)
        {
            if (breakfast == 0 && lunch == 0 && dinner == 0 && cleaning == "0" && towel == "0" && surprise == "0")
            {
                foodSupplyCheckBox.Checked = true;
            }
            updateButton.Enabled = true;

            FinalizePayment finalizebil = new FinalizePayment();
            finalizebil.totalAmountFromFrontend = totalAmount;
            finalizebil.foodBill = foodBill;
            if (taskFinder)
            {
                finalizebil.paymentComboBox.SelectedItem = FPayment.Replace(" ", string.Empty);
                finalizebil.phoneTextBox.Text = FCnumber;
                finalizebil.monthComboBox.SelectedItem = FcardExpOne;
                finalizebil.yearComboBox.SelectedItem = FcardExpTwo;
                finalizebil.CVCTextBox.Text = FCardCVC;
            }

            finalizebil.ShowDialog();

            finalizedTotalAmount = finalizebil.FinalTotalFinalized;
            paymentType = finalizebil.PaymentType;
            paymentCardNumber = finalizebil.PaymentCardNumber;
            MM_YY_Of_Card = finalizebil.MM_YY_Of_Card1;
            CVC_Of_Card = finalizebil.CVC_Of_Card1;
            CardType = finalizebil.CardType1;

            if (!editClicked)
            {
                btnSubmit.Visible = true;
            }
        }
        private void FrontEnd_Load(object sender, EventArgs e)
        {
            foodSupplyCheckBox.Enabled = false;

        }
        private void foodMenuButton_Click(object sender, EventArgs e)
        {

            FoodMenu food_menu = new FoodMenu();
            if (taskFinder)
            {
                if (breakfast > 0)
                {
                    food_menu.breakfastCheckBox.Checked = true;
                    food_menu.breakfastQTY.Text = Convert.ToString(breakfast);
                }
                if (lunch > 0)
                {
                    food_menu.lunchCheckBox.Checked = true;

                    food_menu.lunchQTY.Text = Convert.ToString(lunch);
                }
                if (dinner > 0)
                {
                    food_menu.dinnerCheckBox.Checked = true;
                    food_menu.dinnerQTY.Text = Convert.ToString(dinner);
                }
                if (cleaning == "1")
                {
                    food_menu.cleaningCheckBox.Checked = true;
                }
                if (towel == "1")
                {
                    food_menu.towelsCheckBox.Checked = true;
                }
                if (surprise == "1")
                {
                    food_menu.surpriseCheckBox.Checked = true;
                }
            }
            food_menu.ShowDialog();

            breakfast = food_menu.BreakfastQ;
            lunch = food_menu.LunchQ;
            dinner = food_menu.DinnerQ;

            cleaning = food_menu.Cleaning.Replace(" ", string.Empty) == "Cleaning" ? "1" : "0";
            towel = food_menu.Towel.Replace(" ", string.Empty) == "Towels" ? "1" : "0";

            surprise = food_menu.Surprise.Replace(" ", string.Empty) == "Sweetestsurprise" ? "1" : "0";

            if (breakfast > 0 || lunch > 0 || dinner > 0)
            {
                int bfast = 7 * breakfast;
                int Lnch = 15 * lunch;
                int di_ner = 15 * dinner;
                foodBill = bfast + Lnch + di_ner;
            }

        }
        private void ComboBoxItemsFromDataBase()
        {
            var query = (from R in Context.Reservations
                            select R).ToList();
            try
            {
                foreach(var item in query)
                {
                    string ID = item.Id.ToString();
                    string first_name = item.FirstName.ToString();
                    string last_name = item.LastName.ToString();
                    string phone_number = item.PhoneNumber.ToString();
                    resEditButton.Items.Add(ID + "  | " + first_name + "  " + last_name + " | " + phone_number);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SendSMS(int secondUserID)
        {
            //creating an instance of twilio rest
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            string end_num = paymentCardNumber.Substring(paymentCardNumber.Length - Math.Min(4, paymentCardNumber.Length));

            if (smsCheckBox.Checked)
            {
                //building message for twilio
                string buildMesage = "Hello " + name + "! Your unique ID# " + secondUserID + " Total bill of $" + finalizedTotalAmount + " is charged on your card # ending-" + end_num;
                //creating message 
                var message = MessageResource.Create("+12034562736", RecvPhoneNumber, buildMesage, "");
                //sending message
                Console.WriteLine(message.Sid);
                smsCheckBox.Text = "SMS Sent";
            }
        }
        private void LoadForDataGridView()
        {
            var results = (from F in Context.Reservations
                           where F.CheckIn == true && F.SupplyStatus == false
                           select F).ToList();

           try
            {
                resTotalDataGridView.DataSource = results; 
           
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }
        }


    }
}
