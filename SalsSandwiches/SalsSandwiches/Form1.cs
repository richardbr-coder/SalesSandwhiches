using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalsSandwiches
{

    public partial class Form1 : Form
    {
        string sandwich = "";
        string breadType = "";
        string additions = ""; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideControls();

        }

        private void lstSandwich_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideControls();

            lblMessage.Text = "";
            lblbread.Visible = true;
            lstBreadType.Visible = true;
            sandwich = lstSandwich.Text;
        }

        private void lstBreadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAdditions.Visible = true;
            lstAdditions.Visible = true;
            breadType = lstBreadType.Text;

        }

        private void lstAdditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            additions = lstAdditions.Text;
            lblMessage.Text = String.Format("You choosen " + Environment.NewLine + " Sandwich :" + sandwich + Environment.NewLine + "Bread Type :" + breadType + Environment.NewLine + "Additions :" + additions);
            
            hideControls();

        }
        public void hideControls()
        {
            lblbread.Visible = false;
            lblAdditions.Visible = false;
            lstBreadType.Visible = false;
            lstAdditions.Visible = false;

        }

    }

}