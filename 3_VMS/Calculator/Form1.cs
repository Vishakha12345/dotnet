﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;

namespace Calculator
{
    //reference
    //it should match signature of functions
    //such as add, sub, mult, and div
    delegate void ArithmaticOpeation(int op1, int op2);

    public partial class Form1 : Form
    {

        string fnOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
             //fnOperator= cmdOperator.SelectedValue.ToString();

            MathLib.Calculator calc = new MathLib.Calculator();

           
            switch (fnOperator)
            {
                case "+":
                    //early binding
                    calc.Add(num1, num2);

                    //late binding
                    //1.Create a delegate object
                    //2.Register function name with delegate
                    //3.Invoke delegate by passing parameters
                    ArithmaticOpeation opn = new ArithmaticOpeation(calc.Add);
                    opn(num1, num2);
                    break;
                case "-":
                    calc.Sub(num1, num2);
                    break;

                case "*":
                    calc.Mult(num1, num2);
                    break;
                case "/":
                    calc.Div(num1, num2);
                    break;

            }

            int result = calc.Result;
            lblResult.Text = result.ToString();


        }

        private void cmdOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
         fnOperator =cmdOperator.SelectedItem.ToString();

         

        }
    }
}
