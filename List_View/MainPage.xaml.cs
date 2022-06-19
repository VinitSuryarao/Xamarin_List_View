using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace List_View
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageLink { get; set; }
    }
    public partial class MainPage 
    {
        public List<Employee> emp = new List<Employee>
        {
            new Employee{Name="Vinit", Address="Mumbai", ImageLink="Boy.png"},
            new Employee{Name="Durga", Address="Hydrabad", ImageLink="Girl.png"},
            new Employee{Name="Lohit", Address="Banglore", ImageLink="Boy.png"}
        };
        public MainPage()
        {
            InitializeComponent();
            // Normal List View
            simpleCityList.ItemsSource = new List<string>
            {
                "Mumbai","Pune","Hydrabad"
            };

            // Data Binding & Item Binding in View Cell
            viewCellEmpList.ItemsSource = emp;

            // Text Cell Data Bind
            textCellEmpList.ItemsSource = emp;

            // Image Cell Data Bind
            imageCellEmpList.ItemsSource = emp;

            // Get Data From Selected Item of List
            getDataEmpList.ItemsSource = emp;
        }

        private void clicked_ListView(object sender, ItemTappedEventArgs e)
        {
            var detail = e.Item as Employee;
            Navigation.PushAsync(new DetailPage(detail.ImageLink, detail.Name, detail.Address));
        }
    }
}
