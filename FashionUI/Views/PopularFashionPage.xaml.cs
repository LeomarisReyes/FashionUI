using System;
using System.Collections.Generic;
using FashionUI.ViewModels;
using Xamarin.Forms;

namespace FashionUI.Views
{
    public partial class PopularFashionPage : ContentPage
    {
        public PopularFashionPage()
        {
            InitializeComponent();
            BindingContext = new PopularFashionViewModel();
        }
    }
}
