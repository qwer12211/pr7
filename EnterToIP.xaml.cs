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

namespace pr7
{
    /// <summary>
    /// Логика взаимодействия для IPEnterChat.xaml
    /// </summary>
    public partial class EnterToIP : Window
    {
        public EnterToIP()
        {
            InitializeComponent();
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string ip = IpTextBox.Text;

          
            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("Поле не может быть пустым");
                return;
            }

          
            if (!IsValidIP(ip))
            {
                MessageBox.Show("Введите корректный IP-адрес");
                return;
            }

        
        }

        private bool IsValidIP(string ip)
        {
      
            string[] arrOctets = ip.Split('.');
            if (arrOctets.Length != 4)
                return false;

            
            byte tempForParsing;
            return arrOctets.All(r => byte.TryParse(r, out tempForParsing) && tempForParsing >= 0 && tempForParsing <= 255);
        }

    }
}
