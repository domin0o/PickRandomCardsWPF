using PickRandomCards;
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

namespace PickRandomCardsWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputCardNumber = inputCard.Text;
            if (int.TryParse(inputCardNumber, out int numberOfCards))
            {
                string[] pickedCards = CardPicker.PickSomeCards(numberOfCards);

                foreach(string card in pickedCards)
                {
                    listOfCards.Items.Add(card); 
                }
            }
            else
            {
                test.Text = "Możesz wybrać tylko liczbę większą od 0!";
            }
        }
    }
}
