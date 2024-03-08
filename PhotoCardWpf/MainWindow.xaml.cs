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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhotoCardWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
          
        }

        private void b1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation()
            {
                From = 200,
                To = 600,
                Duration = TimeSpan.FromSeconds(0.5)
            };
            b1.BeginAnimation(Border.WidthProperty, animation1);

            if (b2.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b2.BeginAnimation(Border.WidthProperty, animation);

            }
            if (b3.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b3.BeginAnimation(Border.WidthProperty, animation);
            }
            if (b4.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b4.BeginAnimation(Border.WidthProperty, animation);
            }
           
        }

        private void b2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation()
            {
                From = 200,
                To = 600,
                Duration = TimeSpan.FromSeconds(0.5)
            };
            b2.BeginAnimation(Border.WidthProperty, animation1);

            if (b1.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b1.BeginAnimation(Border.WidthProperty, animation);

            }
            if (b3.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b3.BeginAnimation(Border.WidthProperty, animation);
            }
            if (b4.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b4.BeginAnimation(Border.WidthProperty, animation);
            }
        }

        private void b3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation()
            {
                From = 200,
                To = 600,
                Duration = TimeSpan.FromSeconds(0.5)
            };
            b3.BeginAnimation(Border.WidthProperty, animation1);

            if (b2.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b2.BeginAnimation(Border.WidthProperty, animation);

            }
            if (b1.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b1.BeginAnimation(Border.WidthProperty, animation);
            }
            if (b4.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b4.BeginAnimation(Border.WidthProperty, animation);
            }
        }

        private void b4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation()
            {
                From = 200,
                To = 600,
                Duration = TimeSpan.FromSeconds(0.5)
            };
            b4.BeginAnimation(Border.WidthProperty, animation1);

            if (b2.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b2.BeginAnimation(Border.WidthProperty, animation);

            }
            if (b3.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b3.BeginAnimation(Border.WidthProperty, animation);
            }
            if (b1.ActualWidth == 600)
            {
                DoubleAnimation animation = new DoubleAnimation()
                {
                    From = 600,
                    To = 200,
                    Duration = TimeSpan.FromSeconds(0.5)
                };
                b1.BeginAnimation(Border.WidthProperty, animation);
            }
        }
    }
}
