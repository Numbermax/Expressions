namespace Exp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.expressionInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultOut = new System.Windows.Forms.TextBox();
            this.perform = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Expressions = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Formula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalcTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Settings = new System.Windows.Forms.TabPage();
            this.AddCost = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.CostId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CostCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Expressions.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your  expression:";
            // 
            // expressionInput
            // 
            this.expressionInput.Location = new System.Drawing.Point(136, 11);
            this.expressionInput.Name = "expressionInput";
            this.expressionInput.Size = new System.Drawing.Size(1288, 22);
            this.expressionInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ResultOut);
            this.panel1.Controls.Add(this.perform);
            this.panel1.Controls.Add(this.expressionInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1434, 114);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // ResultOut
            // 
            this.ResultOut.Location = new System.Drawing.Point(136, 74);
            this.ResultOut.Name = "ResultOut";
            this.ResultOut.ReadOnly = true;
            this.ResultOut.Size = new System.Drawing.Size(1291, 22);
            this.ResultOut.TabIndex = 3;
            // 
            // perform
            // 
            this.perform.Location = new System.Drawing.Point(384, 39);
            this.perform.Name = "perform";
            this.perform.Size = new System.Drawing.Size(75, 23);
            this.perform.TabIndex = 2;
            this.perform.Text = "Perform";
            this.perform.UseVisualStyleBackColor = true;
            this.perform.Click += new System.EventHandler(this.Perform_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(15, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 465);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Expressions);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1425, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // Expressions
            // 
            this.Expressions.Controls.Add(this.listView1);
            this.Expressions.Location = new System.Drawing.Point(4, 25);
            this.Expressions.Name = "Expressions";
            this.Expressions.Padding = new System.Windows.Forms.Padding(3);
            this.Expressions.Size = new System.Drawing.Size(1417, 381);
            this.Expressions.TabIndex = 0;
            this.Expressions.Text = "Expressions";
            this.Expressions.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CreateDate,
            this.Formula,
            this.User,
            this.CalcTime,
            this.Cost});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1414, 381);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 62;
            // 
            // CreateDate
            // 
            this.CreateDate.Text = "CreateDate";
            this.CreateDate.Width = 92;
            // 
            // Formula
            // 
            this.Formula.Text = "Formula";
            this.Formula.Width = 247;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 259;
            // 
            // CalcTime
            // 
            this.CalcTime.Text = "CalcTime";
            this.CalcTime.Width = 102;
            // 
            // Cost
            // 
            this.Cost.Text = "Cost";
            this.Cost.Width = 87;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.AddCost);
            this.Settings.Controls.Add(this.listView2);
            this.Settings.Location = new System.Drawing.Point(4, 25);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1417, 381);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // AddCost
            // 
            this.AddCost.Location = new System.Drawing.Point(168, 303);
            this.AddCost.Name = "AddCost";
            this.AddCost.Size = new System.Drawing.Size(75, 23);
            this.AddCost.TabIndex = 2;
            this.AddCost.Text = "Add";
            this.AddCost.UseVisualStyleBackColor = true;
            this.AddCost.Click += new System.EventHandler(this.AddCost_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CostId,
            this.CostCreateDate,
            this.DateStart,
            this.DateEnd,
            this.Value});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 1);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1417, 290);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // CostId
            // 
            this.CostId.Text = "Id";
            // 
            // CostCreateDate
            // 
            this.CostCreateDate.Text = "CreateDate";
            this.CostCreateDate.Width = 132;
            // 
            // DateStart
            // 
            this.DateStart.Text = "DateStart";
            this.DateStart.Width = 149;
            // 
            // DateEnd
            // 
            this.DateEnd.Text = "DateEnd";
            this.DateEnd.Width = 111;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 648);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Expressions.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expressionInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResultOut;
        private System.Windows.Forms.Button perform;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Expressions;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader CreateDate;
        private System.Windows.Forms.ColumnHeader Formula;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader CalcTime;
        private System.Windows.Forms.ColumnHeader Cost;
        private System.Windows.Forms.Button AddCost;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader CostId;
        private System.Windows.Forms.ColumnHeader CostCreateDate;
        private System.Windows.Forms.ColumnHeader DateStart;
        private System.Windows.Forms.ColumnHeader DateEnd;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Label label3;
    }
}