/*
 * Created by: Allison Cook
 * Created on: 7 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - Find Max Value
 * This program finds the max value out of ten randomly generated numbers
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

namespace MaxValueAllisonC
{
    public partial class frmMaxValue : Form
    {
        //creating golbal constant
        const int ARRAY_SIZE = 10;

        public frmMaxValue()
        {
            InitializeComponent();
        }

        private int GetMaxValue(int[] tmpArrayOfNumbers)
        {
            //declare local variables
            int tmpmaxValue = 0;
            int currentValue;
            int counter;

            for (counter = 0;  counter < ARRAY_SIZE; counter++)
            {
                //getting the current number from array
                currentValue = tmpArrayOfNumbers[counter];
                if (tmpmaxValue < currentValue)
                {
                    //setting the maxVAlue to be the higher number
                    tmpmaxValue = currentValue;
                }
            }

            return tmpmaxValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declaring local variables and constants
            const int MAX_RANDOM_NUMBER = 500;
            int randomNumber;
            int counter;
            int maxValue;
            Random randomNumberGenerator = new Random();

            //creating an array
            int[] arrayOfNumbers = new int[ARRAY_SIZE];

            //clearing the list box
            lstNumbers.Items.Clear();

            //creating random numbers and adding them to the array
            for (counter = 0; counter < ARRAY_SIZE; counter++)
            {
                //generate the random number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER);

                //assign the random number to the array at the index of counter
                arrayOfNumbers[counter] = randomNumber;

                //add the random number to the list box
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form to show the updated list box
                this.Refresh();
            }

            //calling the function to find max value
            maxValue = GetMaxValue(arrayOfNumbers);

            //showing the maxValue
            this.lblMax.Text = "The max value is " + maxValue;

        }
    }
}
