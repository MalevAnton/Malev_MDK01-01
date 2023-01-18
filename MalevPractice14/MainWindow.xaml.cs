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

namespace MalevPractice14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbArif = TBArif;
            Model.tbResult = TBResult;
            CmbArifmet.ItemsSource = Model.datalist;
        }

        private void CmbArifmet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.Combo = CmbArifmet.SelectedIndex;
        }

        private void TboxArif1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Model.a1 = TboxArif1;
        }

        private void TboxArif2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Model.a2 = TboxArif2;
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            Model.tbResult = TBResult;
        }
    }
}
