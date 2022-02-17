using Aplicatie_Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicatie_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarPage : ContentPage
    {
        private CarList sl;
        public CarPage(CarList slist)
        {
            InitializeComponent();
            sl = slist;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}