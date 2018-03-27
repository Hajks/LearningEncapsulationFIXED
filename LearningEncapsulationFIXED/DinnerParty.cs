using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEncapsulationFIXED
{
    class DinnerParty
    {
        private int NumberOfPeople; //we sets NumberOfPeople to private
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool HealthyOption)
        {
            if (HealthyOption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }
        public void SetPartyOptions(int people, bool fancy) //New method which sets NumberOfPeople
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
       
        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = NumberOfPeople * 15M + 50;
            }
            else
            {
                CostOfDecorations = NumberOfPeople * 7.5M + 30;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal TotalCost;
            TotalCost = ((NumberOfPeople * CostOfBeveragesPerPerson) + CostOfDecorations + (NumberOfPeople * CostOfFoodPerPerson));

            if (healthyOption)
            {
                return TotalCost * 0.95M;
            }
            else
            {
                return TotalCost;
            }
        }



    }


}