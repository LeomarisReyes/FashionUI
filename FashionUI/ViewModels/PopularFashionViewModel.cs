using System;
using System.Collections.ObjectModel;
using FashionUI.Models;
using FashionUI.Views;

namespace FashionUI.ViewModels
{
    public class PopularFashionViewModel
    {
        public ObservableCollection<Recommended> recommended { get; set; }
        public ObservableCollection<PopularFashion> popularFashion { get; set; }
        public PopularFashionViewModel()
        {
            popularFashion = new ObservableCollection<PopularFashion>
                {
                   new PopularFashion { Name="Casual T-Shirt", Price="$122.00", Picture="Model3" },
                   new PopularFashion { Name="Casual T-Shirt", Price="$122.00", Picture="Model2" },
                   new PopularFashion { Name="Casual T-Shirt", Price="$122.00", Picture="Model1" }
                };

            recommended = new ObservableCollection<Recommended>
            {
                new Recommended { Name="Casual Dress", Description="Modern Style", Picture="Model2" },
                new Recommended { Name="Casual Dress", Description="Modern Style", Picture="Model3" }
            };
        }
    }
}
