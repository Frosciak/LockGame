using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace zamek
{
  /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
  {
      List<int> liczby = new List<int>();
      int n = 0;
      public MainWindow()
        {
            
            InitializeComponent();
            losuj();
        }
      
      public void Window_KeyDown(object sender, KeyEventArgs e)
      { 
          string Pressedliczba = "";

          // ... Test for F1 key.
          if (e.Key == Key.Left)
          {
              Pressedliczba = "1";
           
          }else if (e.Key == Key.Right)
          {
            Pressedliczba = "0";
          }
          
              if (Pressedliczba == Convert.ToString(liczby[n]))
              {
                  n++;
                  Ellipse.Fill = Brushes.Green;
                  if (n >= liczby.Count)
                  {
                      Ellipse.Fill = Brushes.Yellow;
                      XImage.Source = new BitmapImage(new Uri("/images/Ochest.png", UriKind.Relative));
                  }
              
              }
              else
              {
              
                  Ellipse.Fill = Brushes.Red;
                  n = 0;
              }
      }

      void losuj()
      {
          Random rnd = new Random();
          int i;
          for (i = 0; i <= 3; i++)
          {
              liczby.Add(rnd.Next(0, 2));
          }
          
      }
      
  }
}