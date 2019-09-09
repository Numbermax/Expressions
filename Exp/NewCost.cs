using Exp.Base;
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
    public partial class NewCost : Form
    {
        public NewCost()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cost cost = new Cost
            {
                CostValue = float.Parse(textBox1.Text),
                DateStart = dateTimePicker1.Value,
                DateEnd=dateTimePicker2.Value,
                CreateDate =DateTime.Now
            };
            CostRepository costs = new CostRepository();
            costs.Add(cost);
            this.Close();

        }
        
    }
}
