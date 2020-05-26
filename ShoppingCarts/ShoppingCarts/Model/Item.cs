using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCarts.Model
{
    public class Item
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string CustomName1 { get; set; }
        public string CustomName2 { get; set; }
        public string CustomName3 { get; set; }
        public int Price { get; set; }
        public int CustomPrice { get; set; }
        public bool Status { get; set; }
        public bool CustomStatus { get; set; }
        public string ButtonText { get; set; }
        public string CustButtonText1 { get; set; }
        public string CustButtonText2 { get; set; }
        public string CustButtonText3 { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }

        public string NameSort
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name) || Name.Length == 0)
                    return "?";

                return Name[0].ToString().ToUpper();
            }
        }
    }
}