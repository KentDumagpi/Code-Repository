using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSequence_Dumagpi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNum.Items.Clear();
            for (int i = 1; i <= 10; i++) { 
                cboNum.Items.Add(i.ToString());
            }
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            cboNum.Items.Clear();
            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++) {
                cboNum.Items.Add(i.ToString());
                lstNum.Items.Add(i.ToString());
            }
        }

        private void cboNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkList.Checked)
                lstNum.Visible = true;
            else
                lstNum.Visible = false;

        }

        private void chkCbo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCbo.Checked)
                cboNum.Visible = true;
            else
                cboNum.Visible = false;
        }

        private void rbtnEven_CheckedChanged(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            cboNum.Items.Clear();

            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                if (i % 2 == 0)
                    lstNum.Items.Add(i.ToString());

            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                if (i % 2 == 0)
                    cboNum.Items.Add(i.ToString());
        }

        private void rbtnDiv_CheckedChanged(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            cboNum.Items.Clear();

            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                if (i % 5 == 0 )
                    lstNum.Items.Add(i.ToString());

            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                if (i % 5 == 0)
                    cboNum.Items.Add(i.ToString());
        }

        private void rbtnOdd_CheckedChanged(object sender, EventArgs e)
        {
            lstNum.Items.Clear();
            cboNum.Items.Clear();

            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                if (i % 2 != 0)
                    lstNum.Items.Add(i.ToString());

            for (int i = int.Parse(txtStart.Text); i <= int.Parse(txtEnd.Text); i++)
                if (i % 2 != 0)
                    cboNum.Items.Add(i.ToString());
        }
    }
}
