using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinEFTest.Model;

namespace XamarinEFTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var db = new CuttingUnitContext();
            db.AddCruise();
            db.SaveChanges();

            BindingContext = db;
        }
    }
}