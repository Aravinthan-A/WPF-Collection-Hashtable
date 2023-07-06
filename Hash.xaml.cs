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
using System.Collections;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace String_Function
{
    /// <summary>
    /// Interaction logic for Hash.xaml
    /// </summary>
    public partial class Hash : Window
    {
        public Hash()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string role = "";
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Name", txtname.Text);
            hashtable.Add("College", txtclg.Text);
            hashtable.Add("Mark1", txtmark1.Text);
            hashtable.Add("Mark2", txtmark2.Text);
            hashtable.Add("Total", txttotal.Text);
            cmbname.ItemsSource=hashtable;
            cmbname.DisplayMemberPath = "Value";
            foreach (DictionaryEntry item in hashtable)
            {
                role += $"\n{item.Key.ToString()}" + ":" + $"{item.Value.ToString()}";
            }
            MessageBox.Show(role,"Information",MessageBoxButton.OK,MessageBoxImage.Information);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         



             


        }
    }
}
