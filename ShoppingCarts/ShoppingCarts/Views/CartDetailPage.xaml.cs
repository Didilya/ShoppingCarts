﻿using ShoppingCarts.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//корзина
namespace ShoppingCarts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartDetailPage : ContentPage
    {
        public CartDetailPageViewModel _ViewModel;

        public CartDetailPage()
        {
            InitializeComponent();

            BindingContext = _ViewModel = new CartDetailPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ViewModel.GetData.Execute(null);
            //_ViewModel.Price;

        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}