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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DataTemplateExample.xaml
    /// </summary>
    public partial class DataTemplateExample : Window
    {
        public DataTemplateExample()
        {
            InitializeComponent();

            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Ali", Age = 27 });
            people.Add(new Person { Name = "Mike", Age = 62 });
            people.Add(new Person { Name = "Brian", Age = 12 });

            this.DataContext = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person selectedPerson = (Person)listbox.SelectedValue;
            if (selectedPerson != null)
            {
                string message = selectedPerson.Name + " is " + selectedPerson.Age + " years old";
                MessageBox.Show(message);
            }
        }

    }

    public class Person
    {
        private string nameValue;
        private double ageValue;

        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }


        public double Age
        {
            get { return ageValue; }
            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }
        }
    }
}
