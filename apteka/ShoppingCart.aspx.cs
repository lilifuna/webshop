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
            foreach (DictionaryEntry item in App.cart)
            {
                float price = (int)App.products[item.Key.ToString()] * (int)item.Value;
                cartList.Items.Add(item.Key.ToString() + "  " + item.Value.ToString() + "szt.  " + price + " zł" );
                itemListSubtract.Items.Add("-");
                itemsAddList.Items.Add("+");
            }

            if (App.cart.Count == 0) cartList.Items.Add("Koszyk jest pusty");
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
            foreach (DictionaryEntry item in App.cart)
            {
                price += (int)App.products[item.Key.ToString()] * (int)item.Value;
            }

            switch (RadioButtonList1.SelectedIndex)
            {
                case 0:
                    price += 10;
                    break;
                case 1:
                    price += 15;
                    break;
                case 2:
                    price += 8;
                    break;
            }

            totalTextBox.Text = price + "zł";

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Summary.aspx");
        }
    }

    
}