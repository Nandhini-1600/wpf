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

namespace WpfApp6 {
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window {
      public MainWindow () {
         InitializeComponent ();
      }

      private void Button_Click (object sender, RoutedEventArgs e) {
         if (state.SelectedItem == null || city.SelectedItems == null) {
            MessageBox.Show ("Select all the fields");
         } else {
            string State = (state.SelectedItem as ComboBoxItem).Content.ToString ();
            string City = city.SelectedItem as string;
            MessageBox.Show ($"State : {State}\n City : {City}", "Selected Location");
         }
      }

      private void state_SelectionChanged (object sender, SelectionChangedEventArgs e) {
         city.Items.Clear ();
         AddCity ();
      }

      private void AddCity () {
         switch ((state.SelectedItem as ComboBoxItem).Content.ToString ()) {
            case "Tamilnadu":
               city.Items.Add ("Kanniyakumari");
               city.Items.Add ("Chennai");
               city.Items.Add ("Madurai");
               city.Items.Add ("Trichy");
               break;
            case "Kerala":
               city.Items.Add ("Trissur");
               city.Items.Add ("Aazhapuzha");
               city.Items.Add ("Ernakulam");
               city.Items.Add ("Paalakad");
               break;
         }
      }
   }
}
