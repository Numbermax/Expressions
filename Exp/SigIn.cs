using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exp.Logic;

namespace Exp
{
    public partial class SigIn : Form
    {
        public SigIn()
        {
            InitializeComponent();
        }

      
        private void Button1_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Login or password is empty");
                return;
            }
            operations.SigIn(textBox1.Text, textBox3.Text, textBox2.Text.GetHashCode());
            operations.LogIn(textBox1.Text, textBox2.Text.GetHashCode());

            MainForm form = new MainForm
            {
                Visible = true
            };
            this.Visible = false;
        }
    }
}
