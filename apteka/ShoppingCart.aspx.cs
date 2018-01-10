using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apteka
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        Hashtable cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateList();
            UpdatePrice();
        }

        private void PopulateList()
        {
            cartList.Items.Clear();
            itemListSubtract.Items.Clear();
            itemsAddList.Items.Clear();

            cart = (Hashtable)Session["cart"]; //czytam koszyk z sesji

            if (cart != null)
            {
                foreach (DictionaryEntry item in cart)
                {
                    float price = (int)App.products[item.Key.ToString()] * (int)item.Value;
                    cartList.Items.Add(item.Key.ToString() + "  " + item.Value.ToString() + "szt.  " + price + " zł");
                    itemListSubtract.Items.Add("-");
                    itemsAddList.Items.Add("+");
                }
            }
            else cartList.Items.Add("Koszyk jest pusty");
        }

        protected void itemsAddList_Click(object sender, BulletedListEventArgs e)
        {

            String productName = cartList.Items[e.Index].Text.Split(' ')[0];
            App.cart[productName] = (int)App.cart[productName] + 1;
            PopulateList();
            UpdatePrice();
        }

        protected void itemListSubtract_Click(object sender, BulletedListEventArgs e)
        {
            String productName = cartList.Items[e.Index].Text.Split(' ')[0];
            if ((int)App.cart[productName] > 0) App.cart[productName] = (int)App.cart[productName] - 1;
            PopulateList();
            UpdatePrice();
        }


        private void UpdatePrice()
        {
            float price = 0;
            string shipType = "";
            foreach (DictionaryEntry item in cart) //zmiana na sesyjny koszyk
            {
                price += (int)App.products[item.Key.ToString()] * (int)item.Value;
            }

            switch (RadioButtonList1.SelectedIndex)
            {
                case 0:
                    price += 10;
                    shipType = "Kurier";
                    break;
                case 1:
                    price += 15;
                    shipType = "Poczta";
                    break;
                case 2:
                    price += 8;
                    shipType = "Paczkomat";
                    break;
            }

            totalTextBox.Text = price + "zł";
            Session["totalCost"] = price;
            Session["shipType"] = shipType;  //dodaje informacje do sesji zeby wczytac w podsumowaniu


        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Summary.aspx"); //przechodze do podsumowania
        }
    }

    
}