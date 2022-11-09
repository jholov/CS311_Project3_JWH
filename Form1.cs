namespace CS311_Project3_JWH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//end Form1

        //Method to restate order and calculate cost
        private void Summarize()
        {
            String tData = "";
            String cData = "";
            String sData = cboSize.GetItemText(cboSize.SelectedItem);
            double tCost = 0;
            double subTot = 0;
            double sCost = 0;
            double tax = 0;
            double total;


                switch (sData)
                {
                    case "Small":
                        sCost = 2.00;
                        break;

                    case "Medium":
                        sCost = 5.00;
                        break;

                    case "Large":
                        sCost = 10.00;
                        break;

                    case "X-Large":
                        sCost = 15.00;
                        break;

                    case "Ginormous":
                        sCost = 20.00;
                        break;

                }//end Size switch


                if (rdoThin.Checked)
                {
                    cData = "Thin";

                }
                else if (rdoThick.Checked)
                {
                    cData = "Thick";

                }
                else if (rdoReg.Checked)
                {
                    cData = "Regular";

                }//end Crust if statement


                if (ckbPep.Checked)
                {
                    tData += "\u2022Pepperoni\n";
                    tCost += 2.00;
                }
                if (ckbSausage.Checked)
                {
                    tData += "\u2022Sausage\n";
                    tCost += 2.00;
                }
                if (ckbCbacon.Checked)
                {
                    tData += "\u2022Canadian Bacon\n";
                    tCost += 2.00;
                }
                if (ckbSpicy_Saus.Checked)
                {
                    tData += "\u2022Spicy Italian Sausage\n";
                    tCost += 2.00;
                }
                if (ckbOnion.Checked)
                {
                    tData += "\u2022Onion\n";
                    tCost += 1.00;
                }
                if (ckbG_Pepper.Checked)
                {
                    tData += "\u2022Green Pepper\n";
                    tCost += 1.00;
                }
                if (ckbB_Olives.Checked)
                {
                    tData += "\u2022Black Olives\n";
                    tCost += 1.00;
                }
                if (ckbG_Olives.Checked)
                {
                    tData += "\u2022Green Olives\n";
                    tCost += 1.00;
                }
                if (ckbB_Peppers.Checked)
                {
                    tData += "\u2022Banana Peppers\n";
                    tCost += 1.00;
                }
                if (ckbJalepeno.Checked)
                {
                    tData += "\u2022Jalepeno\n";
                    tCost += 1.00;
                }
                if (ckbX_Cheese.Checked)
                {
                    tData += "\u2022Extra Cheese\n";
                    tCost += 1.00;
                }
                if (ckbMushroom.Checked)
                {
                    tData += "\u2022Mushroom\n";
                    tCost += 1.00;
                }//end Topping if statement

                
                    rtfOrder_Sum.Text = "You ordered a " + sData + " pizza with " + cData + " crust and the following toppings:\n" + tData;
                    subTot = tCost + sCost;
                    tax = subTot * .06;
                    total = subTot + tax;

                    txtTax.Text = tax.ToString("C2");
                    txtSub_Total.Text = subTot.ToString("C2");
                    txtTotal.Text = total.ToString("C2");
               
        }//end Summarize

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }//end btnCalculate_Click

    }//end Class

}//end Namespace