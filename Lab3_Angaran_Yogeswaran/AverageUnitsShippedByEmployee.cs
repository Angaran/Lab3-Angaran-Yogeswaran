//Nama:Angaran Yogeswaran
//Date:Feb.25th.2021
//Assignment:NETD2292-Lab1
//Purpose:Calculate Average of units shipped each day


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Angaran_Yogeswaran
{
    public partial class AverageUnitsShippedByEmployee : Form
    {
        //Some constant definitions
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;

        //Class Level variable declarations
        int currentEmployee = 1;
        int currentDay = 1;


        //2D Intger Array that stores number of employees and number of days
        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];


        //Make arrays for output controls
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;

        public AverageUnitsShippedByEmployee()
        {
            InitializeComponent();
            //TextBox and Label Objects that store textboxes and labels
            employeeTextBoxes = new TextBox[] { textBoxEmployee1Entries, textBoxEmployee2Entries, textBoxEmployee3Entries };
            employeeAverages = new Label[] { labelEmployee1Average, labelEmployee2Average, labelEmployee3Average };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// We say here what the enter button does.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            //Declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;


            // Validate that the number entered is a whole number
            if (int.TryParse(textboxEntryNumber.Text, out entryArray[currentEmployee-1,currentDay-1]))
            {
                //validate that the number entered is between 0 and 5000
                if (entryArray[currentEmployee - 1, currentDay - 1] >= MinimumUnits && entryArray[currentEmployee - 1, currentDay - 1] <= MaximumUnits)
                {
                    employeeTextBoxes[currentEmployee-1].Text += entryArray[currentEmployee - 1, currentDay - 1] + "\r\n";
                    
                    
                    // Check if we have entered day 7
                    if (currentDay++ >= NumberOfDays) 
                    {
                        int employeeTotal = 0;

                        //Calculate and display employee 1s average
                        for (int day = 0; day < NumberOfDays; day++) 
                        {
                            employeeTotal += entryArray[currentEmployee - 1, day];
                        }

                        //Outputting Average to application
                        employeeAverages[currentEmployee-1].Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2);


                        //Calculate and display employee 1s average
                        // We have entered day 7! Reset the dat and go to the next employee.
                        currentDay = 1;
                        currentEmployee++;
                        
                    }
                    //Check if we have entered all employees
                    if (currentEmployee > NumberOfEmployees) 
                    {
                        double average1 = 0;
                        double overallaverage;
                        
                       //for loop used to output the overall avergae for all three users
                        for (int average = 0; average < NumberOfEmployees; average++)
                        {
                            for (int finalaverage=0; finalaverage < NumberOfDays; finalaverage++)
                            {
                                average1 += entryArray[average,finalaverage];

                            }
                            //Here we are dividing the average the nummber of entry in the entry array
                            overallaverage = average1 / entryArray.Length;
                            labelAverageOutput.Text = "The overall average for all three employees is " + overallaverage;
                        }
                        //Setting Current day and current employee to 1
                        currentDay = 1;
                        currentEmployee = 1;
                        //We have entered all workers! Disable the input controls and set focus apporipriately. 

                        //Setting textbox entry number and the enter button to false.
                        textboxEntryNumber.Enabled = false;
                        buttonEnter.Enabled = false;
                        //Set focus to the reset button
                        buttonReset.Focus();
                    }
                    //Set the day counter
                    labelDay.Text = "Day " + currentDay.ToString();

                }
                else
                {
                    //The vlaue entered is  less than 0 or greater than 5000
                    MessageBox.Show("Enter a vlaue between " + MinimumUnits + " and " + MaximumUnits
                        + ".","Invalid Entry!");
                    textboxEntryNumber.SelectAll();
                    textboxEntryNumber.Focus();

                }


            }
            else
            {
                //The value entered is not an integer
                MessageBox.Show("Entry must be a numeric value", "Invalid Entry");
                textboxEntryNumber.SelectAll();
                textboxEntryNumber.Focus();
            }
        }
       
        private void ButtonResetClick(object sender, EventArgs e)
        {
            ResetForm();
        }
        /// <summary>
        /// Resets the form for new data entry, including resetting class variables and re-enabling
        /// controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetForm() 
        {
            // Clear the input and output fields
            textboxEntryNumber.Clear();
            textBoxEmployee1Entries.Clear();
            textBoxEmployee2Entries.Clear();
            textBoxEmployee3Entries.Clear();
            labelEmployee1Average.Text = String.Empty;
            labelEmployee2Average.Text = String.Empty;
            labelEmployee3Average.Text = String.Empty;
            labelAverageOutput.Text = String.Empty;

            //Reset the global variables
            currentDay = 1;
            labelDay.Text = "Day " + currentDay;

            //Resets the font to their default states.
            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Regular);

            //Re-enable any controls that may be disabled
            textboxEntryNumber.Enabled = true;
            buttonEnter.Enabled = true;

            //Set focus for easy data entry
            textboxEntryNumber.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

