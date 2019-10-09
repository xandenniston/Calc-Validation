using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxInfix_Click(object sender, EventArgs e)
        {
            if (InfixValidation())
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");

            }
        }

        private void uxPostFix_Click(object sender, EventArgs e)
        {

        }

        private void uxPrefix_Click(object sender, EventArgs e)
        {

        }

        private bool InfixValidation()
        {
            String input = uxInputBox.Text;
            input = input.Replace(" ", string.Empty);//remove all spaces
            Stack<char> parentheses = new Stack<char>();//hopefully reminiscent of parentheses lab
            if(input.Length == 0) { return false; }
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    parentheses.Push('(');
                }
                else if (input[i] == ')')
                {
                    if (i == 0){ return false; }// an expression cannot begin with a close parentheses
                    if (input[i - 1] == '(') { return false; }// "()" is not valid
                    if (parentheses.Count == 0) { return false; } // if the parentheses have run out
                    else { parentheses.Pop(); }

                }

                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')//in infix, all signs should have a number after it
                {
                    if (i == 0) { return false; }// an expression cannot begin with a sign in infix
                    if((input[i-1] < '0' || input[i-1] > '9') && input[i-1] != ')') { return false; }

                }
            }
            if (parentheses.Count != 0)//if the stack has not been emptied, there are extra parentheses
            {
                Console.WriteLine("too many close parentheses");
                return false;
            }
            return true;
        }
        private bool PostfixValidation()
        {

        }
    }
}
