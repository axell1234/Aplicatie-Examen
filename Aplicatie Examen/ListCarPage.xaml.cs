
using Aplicatie_Examen;
using Aplicatie_Examen.Models;
using System;

async void OnSaveButtonClicked(object sender,
    EventArgs e)
{
    var slist = (CarList)BindingContext;
    slist.Date = DateTime.UtcNow;
    await App.Database.SaveShopListAsync(slist);
    object Navigation = null;
    await Navigation.PopAsync();
}
async void OnDeleteButtonClicked(object sender, EventArgs e)
{
    CarList BindingContext = null;
    var slist = (CarList)BindingContext;
    await App.Database.DeleteShopListAsync(slist);

    async void OnChooseButtonClicked(
        object sender, EventArgs e)
    {
        if (sender is null)
        {
            throw new ArgumentNullException(nameof(sender));
        }

        object Navigation = null;
        await Navigation.PushAsync(new ProductPage((CarList)this.BindingContext)
        {
            BindingContext = new Product()
        });


        protected override async void OnAppearing()
{
    base.OnAppearing();