/*
 K9195
 CIS 199-02
 October 16th, 2019
 Program 2
 This program will take a user's information about their credit hours and last name and tell them their registration date and time based on UofLs Spring 2020 criteria
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prorgam_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this is the button event the user will execute after entering in information
        private void RegCalcBtn_Click(object sender, EventArgs e)
        {
            const string FIRST_TIME_SLOT = "8:30AM",//constant for the firse time slot 
                SECOND_TIME_SLOT = "10:00AM",//constant for the second time slot 
                THIRD_TIME_SLOT = "11:30AM",//constant for the third time slot 
                FOURTH_TIME_SLOT = "2:00PM",//constant for the fourth time slot 
                LAST_TIME_SLOT = "4:00PM";//constant for the fifth and final time slot 
            const string FIRST_DAY = "November 4th",//constant for the first day of registration
                SECOND_DAY = "November 5th",//constant for the second day of registration
                THIRD_DAY = "November 6th",//constant for the third day of registration
                FOURTH_DAY = "November 7th",//constant for the fourth day of registration
                FIFTH_DAY = "November 8th",//constant for the fifth day of registration
                SIXTH_DAY = "November 11th";//constant for the sixth and final day of registration
            const int UPPER_CLASS = 60,//classification of student based on 60 credit hours
                LOWER_CLASS = 30,//classification of student based on 90 credit hours
                SENIOR = 90;//classification of upperclass student to senior based on 90 hours

            char last;//the last name variable for the student user
            float credit;//credit hours for the student user

            if (nameTxt.Text.Length > 0)//will ensure there is actually an input
            {
                last = nameTxt.Text[0];//reads the first letter of the Text box
                if (char.IsLetter(last))//verifies there is a letter then makes it uppercase
                {
                    last = char.ToUpper(last);

                    if (float.TryParse(creditTxt.Text, out credit))//requires the credit text box to be a float type 




                    {
                        if (credit >= UPPER_CLASS)//tests for 60+ hours
                        {
                            if (credit >= SENIOR)//assigns time slots for all credit hours 90+
                            {
                                dayOutputLbl.Text = $"{FIRST_DAY}";
                                if (last <= 'D')
                                    timeOutputLbl.Text = $"{THIRD_TIME_SLOT}";
                                else if (last <= 'I')
                                    timeOutputLbl.Text = $"{FOURTH_TIME_SLOT}";
                                else if (last <= 'O')
                                    timeOutputLbl.Text = $"{LAST_TIME_SLOT}";
                                else if (last <= 'S')
                                    timeOutputLbl.Text = $"{FIRST_TIME_SLOT}";
                                else timeOutputLbl.Text = $"{SECOND_TIME_SLOT}";
                            }



                            else//tests for 60-90 credit hours
                            {
                                dayOutputLbl.Text = $"{SECOND_DAY}";
                                if (last <= 'D')
                                    timeOutputLbl.Text = $"{THIRD_TIME_SLOT}";
                                else if (last <= 'I')
                                    timeOutputLbl.Text = $"{FOURTH_TIME_SLOT}";
                                else if (last <= 'O')
                                    timeOutputLbl.Text = $"{LAST_TIME_SLOT}";
                                else if (last <= 'S')
                                    timeOutputLbl.Text = $"{FIRST_TIME_SLOT}";
                                else timeOutputLbl.Text = $"{SECOND_TIME_SLOT}";
                            }
                        }



                        else//finds the all students above 30 hours but less than 60 for their intial day 
                        {
                            if ((credit >= LOWER_CLASS) && (last <= 'B' || last >= 'P'))
                            {
                                dayOutputLbl.Text = $"{THIRD_DAY}";

                                if (last <= 'B')
                                    timeOutputLbl.Text = $"{LAST_TIME_SLOT}";
                                else if (last <= 'Q')
                                    timeOutputLbl.Text = $"{FIRST_TIME_SLOT}";
                                else if (last <= 'S')
                                    timeOutputLbl.Text = $"{SECOND_TIME_SLOT}";
                                else if (last <= 'V')
                                    timeOutputLbl.Text = $"{THIRD_TIME_SLOT}";
                                else timeOutputLbl.Text = $"{FOURTH_TIME_SLOT}";
                            }
                            else if ((credit >= LOWER_CLASS) && (last <= 'O' && last >= 'C'))
                            {
                                dayOutputLbl.Text = $"{FOURTH_DAY}";
                                if (last <= 'D')
                                    timeOutputLbl.Text = $"{FIRST_TIME_SLOT}";
                                else if (last <= 'F')
                                    timeOutputLbl.Text = $"{SECOND_TIME_SLOT}";
                                else if (last <= 'I')
                                    timeOutputLbl.Text = $"{THIRD_TIME_SLOT}";
                                else if (last <= 'L')
                                    timeOutputLbl.Text = $"{FOURTH_TIME_SLOT}";
                                else timeOutputLbl.Text = $"{LAST_TIME_SLOT}";
                            }
                            else if ((credit < LOWER_CLASS) && (last <= 'B' || last >= 'P'))//based on all freshman split into 2 days
                            {
                                dayOutputLbl.Text = $"{FIFTH_DAY}";
                                if (last <= 'B')
                                    timeOutputLbl.Text = $"{LAST_TIME_SLOT}";
                                else if (last <= 'Q')
                                    timeOutputLbl.Text = $"{FIRST_TIME_SLOT}";
                                else if (last <= 'S')
                                    timeOutputLbl.Text = $"{SECOND_TIME_SLOT}";
                                else if (last <= 'V')
                                    timeOutputLbl.Text = $"{THIRD_TIME_SLOT}";
                                else timeOutputLbl.Text = $"{FOURTH_TIME_SLOT}";
                            }
                            else
                            {
                                dayOutputLbl.Text = $"{SIXTH_DAY}";
                                if (last <= 'D')
                                    timeOutputLbl.Text = $"{FIRST_TIME_SLOT}";
                                else if (last <= 'F')
                                    timeOutputLbl.Text = $"{SECOND_TIME_SLOT}";
                                else if (last <= 'I')
                                    timeOutputLbl.Text = $"{THIRD_TIME_SLOT}";
                                else if (last <= 'L')
                                    timeOutputLbl.Text = $"{FOURTH_TIME_SLOT}";
                                else timeOutputLbl.Text = $"{LAST_TIME_SLOT}";
                            }
                        }
                    }
                    else MessageBox.Show("Please enter a proper credit hour");
                } 

                else MessageBox.Show("Please enter a a valid last name");
            }
            else MessageBox.Show("Please enter a valid last name");
        
        }
        
    }
}
