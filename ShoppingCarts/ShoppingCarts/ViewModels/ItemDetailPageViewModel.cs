using MvvmHelpers;
using ShoppingCarts.Helpers;
using ShoppingCarts.Model;
using System;
using Xamarin.Forms;

namespace ShoppingCarts.ViewModels
{
    public class ItemDetailPageViewModel : BaseViewModel
    {
        public string imageSource;

        public string ImageSource
        {
            get { return imageSource; }
            set { SetProperty(ref imageSource, value); }
        }

        public string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { SetProperty(ref itemName, value); }
        }

        public string custName1;

        public string CustName1
        {
            get { return custName1; }
            set { SetProperty(ref custName1, value); }
        }
        public string custName2;

        public string CustName2
        {
            get { return custName2; }
            set { SetProperty(ref custName2, value); }
        }
        public string custName3;

        public string CustName3
        {
            get { return custName3; }
            set { SetProperty(ref custName3, value); }
        }

        public string buttonName;

        public string ButtonName
        {
            get { return buttonName; }
            set { SetProperty(ref buttonName, value); }
        }

        public string description;

        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        public int customPrice;

        public int CustomPrice
        {
            get { return customPrice; }
            set { SetProperty(ref customPrice, value); }
        }

        public Command ButtonClicked { get; set; }

        public ItemDetailPageViewModel(Item ShoppingItem)
        {
            ImageSource = ShoppingItem.Image;
            ItemName = ShoppingItem.Name;
            //ButtonClicked = new Command(() => OnButtonClickedCommand(ShoppingItem));

            if (ShoppingItem.CustomStatus)
            {
                ButtonName = "Remove customization";
            }
            else
            {
                ButtonName = "Add customization";
            }
            //ButtonName = ShoppingItem.ButtonText;
            Description = ShoppingItem.Description;
            CustomPrice = ShoppingItem.CustomPrice;
            CustName1 = ShoppingItem.CustomName1;
            CustName2 = ShoppingItem.CustomName2;
            CustName3 = ShoppingItem.CustomName3;

            ButtonClicked = new Command(() => OnButtonClickedCommand(ShoppingItem));
        }

        private void OnButtonClickedCommand(Item ShoppingItem)
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                if (!ShoppingItem.CustomStatus)
                {
                    ButtonName = "Remove customization";
                }
                else
                {
                    ButtonName = "Add customization";
                }

                var index = ShoppingItem.Index;
                if (index == 1)
                    Settings.ItemCustomStatus1 = !Settings.ItemCustomStatus1;
                if (index == 2)
                    Settings.ItemCustomStatus2 = !Settings.ItemCustomStatus2;
                if (index == 3)
                    Settings.ItemCustomStatus3 = !Settings.ItemCustomStatus3;
                if (index == 4)
                    Settings.ItemCustomStatus4 = !Settings.ItemCustomStatus4;
                if (index == 5)
                    Settings.ItemCustomStatus5 = !Settings.ItemCustomStatus5;
                if (index == 6)
                    Settings.ItemCustomStatus6 = !Settings.ItemCustomStatus6;
                if (index == 7)
                    Settings.ItemCustomStatus7 = !Settings.ItemCustomStatus7;
                if (index == 8)
                    Settings.ItemCustomStatus8 = !Settings.ItemCustomStatus8;
                if (index == 9)
                    Settings.ItemCustomStatus9 = !Settings.ItemCustomStatus9;
                if (index == 10)
                    Settings.ItemCustomStatus10 = !Settings.ItemCustomStatus10;
                if (index == 11)
                    Settings.ItemCustomStatus11 = !Settings.ItemCustomStatus11;
                if (index == 12)
                    Settings.ItemCustomStatus12 = !Settings.ItemCustomStatus12;
                if (index == 13)
                    Settings.ItemCustomStatus13 = !Settings.ItemCustomStatus13;
                if (index == 14)
                    Settings.ItemCustomStatus14 = !Settings.ItemCustomStatus14;
                if (index == 15)
                    Settings.ItemCustomStatus15 = !Settings.ItemCustomStatus15;

                ShoppingItem.CustomStatus = !ShoppingItem.CustomStatus;

                //GenericMethods.CartCount();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception is " + ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}