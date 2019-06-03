using _2D.windows;
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

namespace _2D
{
    public partial class MainWindow : Window
    {
  public MainWindow()
  {
      InitializeComponent();
  }
  private void Btn01_Click(object sender, RoutedEventArgs e)
  {
      Window01 sW = new Window01();
      sW.Show();    
  }
  private void Btn02_Click(object sender, RoutedEventArgs e)
  {
      Window02 sW = new Window02();
      sW.Show();
  }
  private void Btn03_Click(object sender, RoutedEventArgs e)
  {
      Window03 sW = new Window03();
      sW.Show();
  }
  private void Btn04_Click(object sender, RoutedEventArgs e)
  {
      Window04 sW = new Window04();
      sW.Show();
  }

        private void Btn05_Click(object sender, RoutedEventArgs e)
        {
            Window05 sW = new Window05();
            sW.Show();
        }

        private void Btn06_Click(object sender, RoutedEventArgs e)
        {
            Window06 sW = new Window06();
            sW.Show();
        }
    }
    }
    

