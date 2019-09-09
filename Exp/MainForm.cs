using Exp.Base;
using Exp.Logic;
using Exp.Repositories;
using ExspressionWorks;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label3.Text = $"User name: {Autorisation.GetName()}";
            if ( !Autorisation.IsAdmin() )tabControl1.TabPages.Remove(Settings);
            UpdateCalculations();
            UpdateCosts();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Application.Exit();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Perform_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();
            ResultOut.Text = operations.GetResultCalculation(Autorisation.GetUserId(),expressionInput.Text);
            UpdateCalculations();
        }
        /// <summary>
        /// Обновляет список Calculations можно реализовать 
        /// ограничение отображения вычислений только авторизованного пользователя 
        /// </summary>
        private  void UpdateCalculations()
        {
            var calcEntitties = new CalculationsEntityRepository();

            var calculations = calcEntitties.GetCalculationEntities();
            listView1.Items.Clear();

            foreach (CalculationEntity calulation in calculations)
            {
                var row = new string[] {calulation.Id.ToString(),
                                        calulation.CreateDate.ToString("dd.MM.yyyy"),
                                        calulation.Formula,
                                        calulation.User,
                                        calulation.CalcTime.ToString(),
                                        calulation.Cost
                                        };
                var lv = new ListViewItem(row)
                {
                    Tag = calulation
                };
                listView1.Items.Add(lv);
            }

        }

        private void AddCost_Click(object sender, EventArgs e)
        {
            NewCost form = new NewCost { Visible = true };
            UpdateCosts();
        }
        private void UpdateCosts()
        {
            var costs = new CostRepository().GetAll();

            listView2.Items.Clear();

            foreach (Cost cost in costs)
            {
                var row = new string[] 
                {
                    cost.Id.ToString(),
                    cost.CreateDate.ToString("dd.MM.yyy"),
                    cost.DateStart.ToString("dd.MM.yyy"),
                    cost.DateEnd.ToString("dd.MM.yyy"),
                    cost.CostValue.ToString()

                };
                var lv = new ListViewItem(row)
                {
                    Tag = cost
                };
                listView2.Items.Add(lv);
            }

        }

    }
}
