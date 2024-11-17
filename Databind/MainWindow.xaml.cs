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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Databind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       Person person = new Person()
          {
              FirstName = "Saif",
              LastName = "Mohammed",
              Adress = "6 october",
              Email = "mh288279@gmail.com",
              Phonenumber = "0155555555",
          };

        
        public MainWindow()
        {
            InitializeComponent();
         

            this.DataContext = person;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{person.FirstName}");
        }
    }
    public class Person
    {
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }




    }
}
