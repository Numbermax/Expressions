using Exp.Base;
using Exp.Logic;
using Exp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ValidateSchema validate = new ValidateSchema();
            validate.Go();
        }
        
        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text =="" || textBox2.Text == "")
            {
                MessageBox.Show("Login or password is empty");
                return;
            }
            Operations operations = new Operations();
            if (operations.LogIn(textBox1.Text, textBox2.Text.GetHashCode()))
            {
                operations.LogIn(textBox1.Text, textBox2.Text.GetHashCode());

                MainForm form = new MainForm
                {
                    Visible = true
                };
                this.Visible = false;
               
            }
            else
            {
                MessageBox.Show("Login or password invalid. Try again, or Login as guest.");
                return;
            }   
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            operations.LogIn("Guest", "Guest".GetHashCode());
            MainForm form = new MainForm
            {
                Visible = true
            };
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SigIn sigInForm = new SigIn()
            {
                Visible = true
            };
            Visible = false;
        }
    }
}
