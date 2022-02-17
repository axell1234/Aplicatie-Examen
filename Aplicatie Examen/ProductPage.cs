using Aplicatie_Examen;
using Aplicatie_Examen.Models;
using System;

public partial class ProductPage : Xamarin.Forms.ContentPage
{
    private object listView;
    CarList sl;

    public ProductPage(CarList slist)
    {
        InitializeComponent();
        sl = slist;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await Aplicatie_Examen.App.Database.SaveProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Database.DeleteProductAsync(product);
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetProductsAsync();
    }
}
