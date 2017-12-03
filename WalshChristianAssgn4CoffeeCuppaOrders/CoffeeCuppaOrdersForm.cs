using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalshChristianAssgn4CoffeeCuppaOrders
{
    public partial class CoffeeCuppaOrdersForm : Form
    {
        public CoffeeCuppaOrdersForm()
        {
            InitializeComponent();
        }
        //CUSTOMER INPUT DECLARATIONS::
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

        private void CoffeeCuppaOrdersForm_Load(object sender, EventArgs e)
        {
            material1RadioButton.Tag = materialMetalUpchargePercentDecimal;
            material2RadioButton.Tag = materialGlassUpchargePercentDecimal;
            material3RadioButton.Tag = materialCeramicUpchargePercentDecimal;
            material4RadioButton.Tag = materialPorcelainUpchargePercentDecimal;

            material1RadioButton.Text = "Metal: " + materialMetalUpchargePercentDecimal.ToString("p1");
            material2RadioButton.Text = "Glass: " + materialGlassUpchargePercentDecimal.ToString("p1"); ;
            material3RadioButton.Text = "Ceramic: " + materialCeramicUpchargePercentDecimal.ToString("p1"); 
            material4RadioButton.Text = "Porcelain: " + materialPorcelainUpchargePercentDecimal.ToString("p1"); 

            size1RadioButton.Tag = size1PriceDecimal;
            size2RadioButton.Tag = size2PriceDecimal;
            size3RadioButton.Tag = size3PriceDecimal;

            size1RadioButton.Text = "2 CUP @: " + size1PriceDecimal.ToString("C"); 
            size2RadioButton.Text = "4 CUP @: " + size2PriceDecimal.ToString("C");
            size3RadioButton.Text = "8 CUP @: " + size3PriceDecimal.ToString("C");

            orderTotalButton.Enabled = false;
            reportLabel.ResetText();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            ValidateInput();
            if (ValidationBoolean == true)
            { CalculateLineItem();
                AccumulateOrderTotals();
                OutputLineItem();
                ResetNewItemInput();
                orderTotalButton.Enabled = true;
                
            }
        }
      
        private void ValidateInput() //Checks for proper input
        {
            ValidationBoolean = false;
            if (restaurantNameTextBox.Text.Trim() != string.Empty) //restaurantName validation
            {
                if (restaurantAddressTextBox.Text.Trim() != string.Empty) //restaurantAddress validation
                {
                    if (contactNameTextBox.Text.Trim() != string.Empty) //contactName validation
                    {
                        if (contactNumberMaskedTextBox.TextLength == 14) //phone validation
                        {
                            if (size1RadioButton.Checked || size2RadioButton.Checked || size3RadioButton.Checked) //size selection validation
                            {
                                if (material1RadioButton.Checked || material2RadioButton.Checked || material3RadioButton.Checked || material4RadioButton.Checked)
                                { //material selection validation
                                    try
                                    {
                                        quantityOrderedInt = int.Parse(quantityTextBox.Text);
                                        if (0 < quantityOrderedInt && quantityOrderedInt < 100) //quantity validation
                                        {
                                            ValidationBoolean = true;
                                        }
                                        else //Quantity Error
                                        {
                                            MessageBox.Show("Input a valid quantity between 1 and 1000", "Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            quantityTextBox.Focus();
                                            quantityTextBox.SelectAll();
                                        }
                                    }
                                    catch  //Quantity Catch
                                    {
                                        MessageBox.Show("Quantity Input Error", "Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        quantityTextBox.Focus();
                                        quantityTextBox.SelectAll();
                                    }
                                }
                                else // Material Error
                                {
                                    MessageBox.Show("Select a Coffee Press Material.", "Material Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    materialTypeGroupBox.BackColor = Color.LightBlue;
                                }
                            }
                            else // Size Error
                            {
                                MessageBox.Show("Select a Coffee Press Size.", "Size Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                sizeGroupBox.BackColor = Color.LightBlue;

                            }
                        }
                        else //Phone Error
                        {
                            MessageBox.Show("Enter a valid contact number.",
                         "Phone Number Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            quantityTextBox.Focus();
                            quantityTextBox.SelectAll();
                        }
                    }

                    else //Contact Name Error
                    {
                        MessageBox.Show("Enter a valid contact name.", "Contact Name Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        quantityTextBox.Focus();
                        quantityTextBox.SelectAll();
                    }
                }
                else //Address Error
                {
                    MessageBox.Show("Enter a valid restaurant address.", "Restaurant Address Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }


            }
            else //Restauarant Name Error
            {
                MessageBox.Show("Enter a valid restaurant name.", "Restaurant Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
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

        private void pressSizesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pressSizeRadioButton = (RadioButton)sender;
            pressCostDecimal = (decimal)pressSizeRadioButton.Tag;
            sizeGroupBox.BackColor = Color.Transparent;
        }

        private void materialTypesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pressMaterialRadioButton = (RadioButton)sender;
            pressMaterialUpChargePercentDecimal = (decimal)pressMaterialRadioButton.Tag;
            materialTypeGroupBox.BackColor = Color.Transparent;
        }

        private void OutputLineItem()
        {
            int positionInteger = pressSizeRadioButton.Text.IndexOf(":");
            string sizeDescriptionString = pressSizeRadioButton.Text.Substring(0, positionInteger - 2);
            string sizePriceString = pressSizeRadioButton.Text.Substring(positionInteger + 1);

            positionInteger = pressMaterialRadioButton.Text.IndexOf(":");
            string materialDescriptionString = pressMaterialRadioButton.Text.Substring(0, positionInteger);
            string materialPriceString = pressMaterialRadioButton.Text.Substring(positionInteger + 1);

            if (reportLabel.Text == string.Empty)
            {
                reportLabel.Text = "Coffee Cuppa Press Sales  " + DateTime.Now.ToShortDateString() + Environment.NewLine +
                    "For: " + restaurantNameTextBox.Text + Environment.NewLine + "at: " + restaurantAddressTextBox +
                    Environment.NewLine + Environment.NewLine +
                    "Press Sz.".PadRight(6) +
                    " Box Price".PadRight(11) +
                    "Qty.".PadLeft(4) + 
                    " Material".PadRight(9) +
                    " Upcharge %".PadRight(1) +
                    " Upcharge".PadLeft(10) +
                    " Unit Price".PadLeft(11) +
                    " Ext. Price".PadLeft(11) +
                    Environment.NewLine + "".PadLeft(90, '-') +
                    Environment.NewLine + Environment.NewLine;
            }
            reportLabel.Text += sizeDescriptionString.PadRight(8) +
                sizePriceString.PadLeft(11) +
                quantityOrderedInt.ToString().PadLeft(4) +
                " " + materialDescriptionString.PadRight(9) +
                materialPriceString.PadLeft(10) +
                pressMaterialUpChargePercentDecimal.ToString("n").PadLeft(9) +
                unitPriceDecimal.ToString("n").PadLeft(12) +
                extendedPriceDecimal.ToString("C").PadLeft(12) + Environment.NewLine;        
        }
        private void ResetNewItemInput()
        {
            size1RadioButton.Checked = true;
            size1RadioButton.Checked = false;
            size1RadioButton.TabStop = true;

            material1RadioButton.Checked = true;
            material1RadioButton.Checked = false;
            material1RadioButton.TabStop = true;

            quantityTextBox.Clear();
            quantityTextBox.Focus();
        }
        private void DetermineAdditionalItems()
        {
            additionalItemsString = "";
            accumAddItemsDecimal = 0;
            accumCountAddItemsInteger = 0;

            if (item1CheckBox.Checked)
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
                case 1:
                    shippingCostPerBoxDecimal = SHIPPING_1_COST_Decimal;
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



        private void ClearInputs()
        { //Clears selections and input
            material1RadioButton.Checked = false;
            material2RadioButton.Checked = false;
            material3RadioButton.Checked = false;
            material4RadioButton.Checked = false;
            size1RadioButton.Checked = false;
            size2RadioButton.Checked = false;
            size3RadioButton.Checked = false;
            quantityTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void orderTotalButton_Click(object sender, EventArgs e)
        {
            DetermineAdditionalItems();
            DetermineShippingAndHandling();

            totalProductDueDecimal = accumExtendedPriceDecimal + accumAddItemsDecimal;
            shippingCostDecimal = shippingCostPerBoxDecimal * accumTotalBoxesInteger;

            if (discountCheckBox.Checked)
            {
                totalBeforeTaxDecimal = totalProductDueDecimal + shippingCostPerBoxDecimal - FREQUENT_CUST_DISCOUNT_Decimal;
            }
            else
            {
                totalBeforeTaxDecimal = totalProductDueDecimal + shippingCostDecimal;
            }
            taxesDueDecimal = Math.Round(totalBeforeTaxDecimal * TAX_RATE_Decimal, 2);
            finalTotalDecimal = totalBeforeTaxDecimal + taxesDueDecimal;
            OutputEndOfOrder();
            //AccumulateMgmtTotals();

            orderTotalButton.Enabled = false;
            addToOrderButton.Enabled = false;
        
        }
        private void OutputEndOfOrder()
        {
            reportLabel.Text += Environment.NewLine + Environment.NewLine + "ORDER TOTALS".PadRight(30)
                + Environment.NewLine + "".PadLeft(80, '-') + Environment.NewLine + Environment.NewLine +
                "Press Total:".PadRight(30) + accumExtendedPriceDecimal.ToString("C").PadLeft(12) + Environment.NewLine +
                "Total # of Boxes Ordered: ".PadRight(30) + accumTotalBoxesInteger.ToString().PadLeft(9) + Environment.NewLine;
            if (additionalItemsString != string.Empty)
            {
                reportLabel.Text += accumCountAddItemsInteger.ToString() +
                    " Additional Item(s) are: " + Environment.NewLine + additionalItemsString + "For a total of: ".PadRight(29)
                    + accumAddItemsDecimal.ToString("n").PadLeft(13) + Environment.NewLine;
            }

            reportLabel.Text += "Product Total: ".PadRight(30) + totalProductDueDecimal.ToString("n").PadLeft(12) + Environment.NewLine +
                "Shipping & Handling Charges: ".PadRight(30) + shippingCostDecimal.ToString("n").PadLeft(13) + Environment.NewLine;
            if (discountCheckBox.Checked)
                reportLabel.Text += "Discount of: ".PadRight(30) + FREQUENT_CUST_DISCOUNT_Decimal.ToString("n").PadLeft(12) + Environment.NewLine;
            reportLabel.Text += "Taxable Amount Due is: ".PadRight(30) + totalBeforeTaxDecimal.ToString("n").PadLeft(12) + Environment.NewLine +
                "Final Total Due is: ".PadRight(30) + finalTotalDecimal.ToString("c").PadLeft(12) + Environment.NewLine + Environment.NewLine;
            reportLabel.Text += Environment.NewLine + Environment.NewLine + "THANK YOU FOR YOUR ORDER" + Environment.NewLine + "HAVE A GREAT DAY!";

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

        }

        private void mgmtTotalButton_Click(object sender, EventArgs e)
        {
            string messageString;
            DialogResult resetTotalDialogResult;

            messageString = "Total # Customers:     " + mgmtTotalCustomersInteger.ToString().PadLeft(10) + Environment.NewLine +
                "Total # Boxes Sent:     " + mgmtTotalBoxesInteger.ToString().PadLeft(10) + Environment.NewLine +
                "Total Added Items:     " + mgmtTotalAdditionalItemsInteger.ToString().PadLeft(10) + Environment.NewLine +
                "Total of Presses Sold:     " + mgmtTotalPressDollarsDecimal.ToString().PadLeft(10) + Environment.NewLine +
                "Total Taxes Collected:     " + mgmtTotalTaxesDecimal.ToString().PadLeft(10) + Environment.NewLine +
                "Total Amt for S & H:     " + mgmtTotalShippingDecimal.ToString().PadLeft(10) + Environment.NewLine +
                "Total Income For Day:     " + mgmtTotalEarningsDecimal.ToString().PadLeft(10) + Environment.NewLine + Environment.NewLine +
                "Click YES to reset totals to ZERO";

            resetTotalDialogResult = MessageBox.Show(messageString, "MANAGEMENT TOTALS", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (resetTotalDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                mgmtTotalCustomersInteger=0;
                mgmtTotalBoxesInteger = 0;
                mgmtTotalAdditionalItemsInteger = 0;
                mgmtTotalPressDollarsDecimal = 0;
                mgmtTotalTaxesDecimal = 0;
                mgmtTotalShippingDecimal = 0;
                mgmtTotalEarningsDecimal = 0;
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            restaurantNameTextBox.Clear();
            restaurantNameTextBox.Focus();
            restaurantAddressTextBox.Clear();
            contactNameTextBox.Clear();
            contactNumberMaskedTextBox.Clear();
            discountCheckBox.Checked = false;
            reportLabel.Text = string.Empty;
            accumTotalBoxesInteger = 0;
            accumExtendedPriceDecimal = 0;
            addToOrderButton.Enabled = true;
            
            foreach (CheckBox ckbx in this.additionalItemGroupBox.Controls)
            { ckbx.Checked = false; }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            restaurantNameTextBox.Text = "Hot and Fast";
            restaurantAddressTextBox.Text = "123 Main St.";
            contactNameTextBox.Text = "Bob Bull";
            contactNumberMaskedTextBox.Text = "2693520349";
            size2RadioButton.Checked = true;
            material2RadioButton.Checked = true;
            quantityTextBox.Text = "2";
        }


    }
}
