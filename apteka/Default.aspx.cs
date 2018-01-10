using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace apteka
{
    public partial class _Default : Page
    {

        List<CheckBoxList> categoriesLists = new List<CheckBoxList>();

        protected void Page_Load(object sender, EventArgs e)
        {
            categoriesLists.Add(CheckBoxList1);
            categoriesLists.Add(CheckBoxList2);
            categoriesLists.Add(CheckBoxList3);
            PopulateLists();
        }

        protected void productsCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void categoriesRadioBtnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;
            value = Int32.Parse(categoriesRadioBtnList.SelectedValue);
            
            foreach(CheckBoxList list in categoriesLists)
            {
                list.Visible = false;
            }

            categoriesLists[value - 1].Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(CheckBoxList list in categoriesLists)
            {
                foreach(ListItem item in list.Items)
                {
                    if (item.Selected)
                    {
                        App.cart.Add(item.Text, 1);
                    }
                }
            }

            Server.Transfer("ShoppingCart.aspx");
        }

        private void PopulateLists()
        {
            if (App.initialized) return;
            String[] items = new String[App.products.Count];
            App.products.Keys.CopyTo(items, 0);
            int k = 0;
            int i = 1;
            foreach(String item in items)
            {
                if(i == 5 && k < 2)
                {
                    k++;
                    i = 1;
                }
                categoriesLists[k].Items.Add(item);
                i++;
            }

            App.initialized = true;
        }
    }
}