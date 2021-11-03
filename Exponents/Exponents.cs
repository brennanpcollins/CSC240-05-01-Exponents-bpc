﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Brennan Collins
 * Date:11/2/2021
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Exponents : Form
    {
        public Exponents()
        {
            InitializeComponent();
        }

        private void UxGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num; // square, cube;

            // INPUT
            num = Convert.ToInt32(UxInputTextBox.Text);

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            //square = num * num;
            void Square_method()
            {
                UxOutputLabel.Text = String.Format("Square = {0}", Square(num));
            }
            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            //cube = num * num * num;
            
            void Cube_method()
            {
                UxOutputLabel.Text += String.Format("\nCube = {0}", Cube(num));
            }
            // OUTPUT
            Square_method();
            Cube_method();

            // set the output to visible
            UxOutputLabel.Visible = true;

            // turn the Go button off
            UxGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            return num * num; // we will create this code in class
        }

        public int Cube(int num)
        {
            return num * num * num; // we will create this code in class
        }

        private void UxResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
            ResetText();
            UxOutputLabel.Visible = false;
            UxGoButton.Enabled = true;

            
                }

    }
}