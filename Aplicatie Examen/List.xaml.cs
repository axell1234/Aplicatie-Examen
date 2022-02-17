using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicatie_Examen;
using Aplicatie_Examen.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicatie_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List : ContentPage
    {
        public List()
        {
            InitializeComponent();
        }

        public object ListCarPage { get; private set; }

        private void InitializeComponent()
        {
            throw new NotImplementedException();

            async void OnSaveButtonClicked(object sender, EventArgs e)
            {
                var LisrCarPage = (LisrCarPage)BindingContext;
                ListCarPage.Date = DateTime.Now;
                await App.Database.SaveShopListAsync(LisrCarPage);
                await Navigation.PopAsync();
            }
            async void OnDeleteButtonClicked(object sender, EventArgs e)
            {
                var slist = (CarList)BindingContext;
                await App.Database.DeleteCarListAsync(slist);
                await Navigation.PopAsync();
            }



        }
    }
}
