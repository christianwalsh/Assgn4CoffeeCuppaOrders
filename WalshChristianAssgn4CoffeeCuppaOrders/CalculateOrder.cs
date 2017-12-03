using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalshChristianAssgn4CoffeeCuppaOrders
{
    class CalculateOrder
    {      //CUSTOMER INPUT DECLARATIONS::
        private int quantityOrderedInt;

        //CALCULATED FOR LINE ITEMS:
        private decimal unitPriceDecimal;
        private decimal extendedPriceDecimal;

        //CALCULATED FOR EACH ORDER:
        private decimal totalProductDueDecimal;
        private decimal shippingCostDecimal;
        private decimal totalBeforeTaxDecimal;
        private decimal taxesDueDecimal;
        private decimal finalTotalDecimal;

        //DECISION STRUCTURE VARIABLES;
        private decimal materialCostDecimal;
        private decimal shippingCostPerBoxDecimal;

        //ACCUMULATOR & FINAL TOTALS:
        //LINE ITEM ACCUMULATORS
        private int accumTotalBoxesInteger = 0;
        private decimal accumExtendedPriceDecimal = 0;
        //END OF ORDER ACCUMULATORS
        private string additionalItemsString;
        private decimal accumAddItemsDecimal = 0;
        private int accumCountAddItemsInteger = 0;

        //MANAGEMENT ACCUMULATORS
        private int mgmtTotalCustomersInteger;
        private int mgmtTotalBoxesInteger; // TOTAL BOXES
        private decimal mgmtTotalAdditionalItemsInteger; // # ADDITIONAL ITEMS
        private decimal mgmtTotalPressDollarsDecimal = 0; // TOTAL PRICE OF PRESSES
        private decimal mgmtTotalTaxesDecimal = 0; //TAXES DUE
        private decimal mgmtTotalShippingDecimal = 0; // S&H INCOME
        private decimal mgmtTotalEarningsDecimal; //DAY's SUM

        //WORKING VARIABLES
        private Boolean ValidationBoolean;
        private DateTime currentDateTime;
        CalculateOrder anOrder;

        //SHARED EVENT HANDLER VARIABLES
        private RadioButton pressSizeRadioButton;
        private decimal pressCostDecimal;

        private RadioButton pressMaterialRadioButton;
        private decimal pressMaterialUpChargePercentDecimal;

        //CONSTANTS
        private const decimal FrequentDiscountDecimal = 5.00M;
        private const decimal SalesTaxDecimal = .05M;
        //PRESS TYPE UPCHARGES
        private const decimal materialMetalUpchargePercentDecimal = 1.00M;
        private const decimal materialGlassUpchargePercentDecimal = 1.1M;
        private const decimal materialCeramicUpchargePercentDecimal = 1.15M;
        private const decimal materialPorcelainUpchargePercentDecimal = 1.20M;
        //PRESS SIZE PRICE/BOX
        private const decimal size1PriceDecimal = 28m;
        private const decimal size2PriceDecimal = 40m;
        private const decimal size3PriceDecimal = 78.9m;
        //ADDITIONAL ITEM COSTS
        private const decimal ADDITIONAL_ITEMS_COASTERS_Decimal = 8.25m;
        private const decimal ADDITIONAL_ITEMS_NAPKINS_Decimal = 10.00m;
        private const decimal ADDITIONAL_ITEMS_STIR_STICKS_Decimal = 12.00m;
        private const decimal ADDITIONAL_ITEMS_SUGAR_PACKETS_Decimal = 25.00m;
        private const decimal ADDITIONAL_ITEMS_CUP_SLEEVES_Decimal = 20.00m;
        //S&H COSTS
        private const decimal SHIPPING_0_COST_Decimal = 5.00m;
        private const decimal SHIPPING_1_COST_Decimal = 4.25m;
        private const decimal SHIPPING_2_COST_Decimal = 3.00m;
        private const decimal SHIPPING_3_COST_Decimal = 2.00m;
        private const decimal SHIPPING_4_COST_Decimal = .50m;

        private const decimal TAX_RATE_Decimal = .05m;
        private const decimal FREQUENT_CUST_DISCOUNT_Decimal = 5m;
        //A.)BACKING FIELDS
        protected int _quantityOrderedInt;
        protected decimal _pressCostDecimal;
        protected decimal _upchargeDecimal;


        //CALCULATED VARIABLES
        protected decimal _materialCostDecimal;
        protected decimal _unitPriceDecimal;
        protected decimal _extendedPriceDecimal;

        //ORDER ACCUMULATORS
        private static int _accumBoxesInteger;
        private static decimal _accumExtendedPriceDecimal;
        private static decimal _accumAdditionalItemsDecimal;
        private static int _accumCountAdditionalItemsDecimal;

        //MGMT ACCUMULATORS


        //CONSTRUCTORS

        public  CalculateOrder (int qty, decimal basePrice)
        {
            UnitPrice = basePrice;
            Quantity = qty;
            CalculateMaterialPrice();
            
        }

        private void CalculateMaterialCost()

        { }

        //PROPERTIES
        public int Quantity
        {  set { _quantityOrderedInt = value; }
                }
        public decimal UnitPrice
        { set { _pressCostDecimal = value; }
        }
        public decimal UpchargePercent
        {
            set { _upchargeDecimal = value; }
        }

        //METHODS
        private void CalculateMaterialPrice()
        {

        }
        private void CalculateLineItem()
        {
            materialCostDecimal = Math.Round(pressMaterialUpChargePercentDecimal * pressCostDecimal, 2);
            unitPriceDecimal = pressCostDecimal + materialCostDecimal;
            extendedPriceDecimal = unitPriceDecimal * quantityOrderedInt;
        }

        private void AccumulateOrderTotals()
        {
            accumTotalBoxesInteger += quantityOrderedInt;
            accumExtendedPriceDecimal += extendedPriceDecimal;
        }
        private void AccumulateMgmtTotals()
        {
            mgmtTotalCustomersInteger++;
            mgmtTotalBoxesInteger += accumTotalBoxesInteger;
            mgmtTotalAdditionalItemsInteger += accumCountAddItemsInteger;
            mgmtTotalPressDollarsDecimal += accumExtendedPriceDecimal;
            mgmtTotalTaxesDecimal += taxesDueDecimal;
            mgmtTotalShippingDecimal += shippingCostDecimal;
            mgmtTotalEarningsDecimal += finalTotalDecimal;

        }        private void DetermineAdditionalItems()
                 {
                     additionalItemsString = "";
                     accumAddItemsDecimal = 0;
                     accumCountAddItemsInteger = 0;

            if (CoffeeCuppaOrdersForm.item1CheckBox.Checked)
            {
                additionalItemsString += item1CheckBox.Text.PadRight(13) + ADDITIONAL_ITEMS_COASTERS_Decimal.ToString("N").PadLeft(6) + Environment.NewLine;
                accumAddItemsDecimal += ADDITIONAL_ITEMS_COASTERS_Decimal;
                accumCountAddItemsInteger++;
            }
            if (item2CheckBox.Checked)
            {
                additionalItemsString += item2CheckBox.Text.PadRight(13) + ADDITIONAL_ITEMS_NAPKINS_Decimal.ToString("N").PadLeft(6) + Environment.NewLine;
                accumAddItemsDecimal += ADDITIONAL_ITEMS_NAPKINS_Decimal;
                accumCountAddItemsInteger++;
            }
            if (item3CheckBox.Checked)
            {
                additionalItemsString += item3CheckBox.Text.PadRight(13) + ADDITIONAL_ITEMS_STIR_STICKS_Decimal.ToString("N").PadLeft(6) + Environment.NewLine;
                accumAddItemsDecimal += ADDITIONAL_ITEMS_STIR_STICKS_Decimal;
                accumCountAddItemsInteger++;
            }
            if (item4CheckBox.Checked)
            {
                additionalItemsString += item4CheckBox.Text.PadRight(13) + ADDITIONAL_ITEMS_SUGAR_PACKETS_Decimal.ToString("N").PadLeft(6) + Environment.NewLine;
                accumAddItemsDecimal += ADDITIONAL_ITEMS_SUGAR_PACKETS_Decimal;
                accumCountAddItemsInteger++;
            }
            if (item5CheckBox.Checked)
            {
                additionalItemsString += item5CheckBox.Text.PadRight(13) + ADDITIONAL_ITEMS_CUP_SLEEVES_Decimal.ToString("N").PadLeft(6) + Environment.NewLine;
                accumAddItemsDecimal += ADDITIONAL_ITEMS_CUP_SLEEVES_Decimal;
                accumCountAddItemsInteger++;
            }
        }

        private void DetermineShippingAndHandling()
        {
            switch (accumTotalBoxesInteger / 10)
            {
                case 0:
                    shippingCostPerBoxDecimal = SHIPPING_0_COST_Decimal;
                    break;
                case 1: shippingCostPerBoxDecimal = SHIPPING_1_COST_Decimal;
                    break;
                case 2:
                    shippingCostPerBoxDecimal = SHIPPING_2_COST_Decimal;
                    break;
                case 3:
                    shippingCostPerBoxDecimal = SHIPPING_3_COST_Decimal;
                    break;
                    default:
                    shippingCostPerBoxDecimal = SHIPPING_4_COST_Decimal;
                    break;
            }
        }



    }
}
