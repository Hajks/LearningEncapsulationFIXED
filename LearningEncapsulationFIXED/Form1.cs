using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEncapsulationFIXED
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(); // { NumberOfPeople = 5 }; old part, not working because we set NumberOfPeople to private
            dinnerParty.SetHealthyOption(false);
            dinnerParty.SetPartyOptions((int) numericUpDown1.Value, true);
            DisplayDinnerPartyCost();

        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            totalCostLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, fancyBox.Checked); //now it updates NumberOfPeople properly
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {

            if (healthyBox.Checked == true)
            {
                dinnerParty.SetHealthyOption(true);
            }
            else
            {
                dinnerParty.SetHealthyOption(false);
            }

            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {

            if (fancyBox.Checked == true)
            {
                dinnerParty.CalculateCostOfDecorations(true);
            }
            else
            {
                dinnerParty.CalculateCostOfDecorations(false);
            }

            DisplayDinnerPartyCost();
        }
    }
}