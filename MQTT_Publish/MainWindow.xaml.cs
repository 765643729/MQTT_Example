using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Publish
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

        MqttClient client;

        private void Button_StartService(object sender, RoutedEventArgs e)
        {
            string MQTT_BROKER_ADDRESS = "";

            this.MessageText.Text += "StartService\n";

            MqttClient client = new MqttClient(IPAddress.Parse(MQTT_BROKER_ADDRESS));
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            string value = "";

            string strValue = Convert.ToString(value);
        }

        private void Button_TestPublish(object sender, RoutedEventArgs e)
        {
            var strValue = "";

            client.Publish("/home/temperature", Encoding.UTF8.GetBytes(strValue), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            this.MessageText.Text += "TestPublish\n";
        }


    }
}
