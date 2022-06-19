using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List_View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage( string ImageLink, string Name, string Address)
        {
            InitializeComponent();
            EmpName.Text = Name;
            EmpAddress.Text = Address;
            EmpImage.Source = ImageLink;
        }
    }
}