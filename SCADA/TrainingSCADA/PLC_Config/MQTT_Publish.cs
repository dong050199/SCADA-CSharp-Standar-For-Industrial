using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json;

namespace PLC_Config
{
    public class MQTT_Publish
    {
        
        public void MQTT_PublishObject(string ipbroker, int port,string clientID,string topic,string usename,string password,object data)
        {
            MqttClient mqttClient = new MqttClient(System.Net.IPAddress.Parse(ipbroker), port, false, null, null, MqttSslProtocols.TLSv1_2);
            mqttClient.Connect(clientID, usename, password);
            if(mqttClient != null && mqttClient.IsConnected)
            {
                var jsonString = JsonConvert.SerializeObject(data);
                mqttClient.Publish(topic, Encoding.UTF8.GetBytes(jsonString));
            }
        }

        public void MQTT_PublicJsonString(string ipbroker, int port, string clientID, string topic, string usename, string password, string data)
        {
            MqttClient mqttClient = new MqttClient(System.Net.IPAddress.Parse(ipbroker), port, false, null, null, MqttSslProtocols.TLSv1_2);
            mqttClient.Connect(clientID, usename, password);
            if (mqttClient != null && mqttClient.IsConnected)
            {
                var jsonString = data;
                mqttClient.Publish(topic, Encoding.UTF8.GetBytes(jsonString));
            }
        }
    }
}
