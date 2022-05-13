using RaceCarÁdám_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RaceCarÁdám_2
{
    /// <summary>
    /// Interaction logic for AddOrEditWindow.xaml
    /// </summary>
    public partial class AddOrEditWindow : Window
    {
        public RaceCar RaceCar { get { return (this.DataContext as RaceCar); } }

        //drop-down list nem betűnkénti kiíratása
        public List<string> Brands = new List<string> { "Audi", "Skoda", "BMW" };

        public AddOrEditWindow()
        {
            InitializeComponent();
            combo.ItemsSource = Brands;
           
        }

        public AddOrEditWindow(RaceCar car) : this()
        {
            this.DataContext = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaceCar.Brand = combo.SelectedItem.ToString();
            this.DialogResult = true;
        }
    }
}
