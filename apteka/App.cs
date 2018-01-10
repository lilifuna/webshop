using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apteka
{

    public static class App
    {
        public static Boolean initialized = false;

        public static List<String> cart = new List<String>();


        public static Hashtable products = new Hashtable()
        {
            {"Acodin",10 },
            {"Thiocodin", 9 },
            {"Tussidex",8 },
            {"Dexacaps", 25},
            {"Antidol", 20},
            {"Mst 200", 15},
            {"Fentanyl Actavis", 10},
            {"OxyContin", 8},
            {"Morfini Sulfas", 150},
            {"Ibuprom", 5},
            {"Diazepam", 25},
            {"Karfentanyl", 100},
            {"Lidokaina", 50},
            {"Chloroform", 34},
            {"Eter", 5},
        };

        

    }
}