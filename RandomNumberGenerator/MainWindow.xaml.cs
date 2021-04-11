using System;
using System.Windows;


namespace RandomNumberGenerator
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            txt.Text = string.Empty;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void draw_button_Click(object sender, RoutedEventArgs e)
        {
            int x, quantity = 6;
            Random rnd = new Random();

            txt.Text = "Your numbers: ";
            for(int i = 0; i < quantity; i++)
            {
                x = rnd.Next(0, 10);
                
                if(i != 5)
                    txt.Text += x + " ";
                
                if(i == 5)
                {
                    txt.Text +=  x + " ";
                    txt.Text += "\n\nEnd of first draw, let's click get it button and take next random numbers\n\n";
                }
            }

            
            
        }
    }
}
