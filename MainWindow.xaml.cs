using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace pr7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConnectClass client;
        private CancellationTokenSource canceledSource;

        public MainWindow()
        {
            InitializeComponent();
            canceledSource = new CancellationTokenSource();
            client = new ConnectClass("26.170.154.104", 5000);
 
        }

        private async void OnMessageReceived(object sender, string message)
        {
            pole_message.Items.Add(message);
        }

        private async void btn_send_Click(object sender, RoutedEventArgs e)
        {
            string message = your_message.Text;
            await client.SendMessageAsync(message);
            your_message.Clear();
        }

        private void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            canceledSource.Cancel();
            client.Close();
        }

    }
}