using System.Text;
using Newtonsoft.Json.Linq;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Termometro
{
    public partial class Termometro : Form
    {
        public Termometro()
        {
            InitializeComponent();

            var mqttClient = new MqttClient("au1.cloud.thethings.network");

            mqttClient.MqttMsgPublishReceived += (sender, e) =>
            {
                var mensagem = Encoding.UTF8.GetString(e.Message);

                JObject o = JObject.Parse(mensagem);
                var temperaturaBase64 = o["uplink_message"]["frm_payload"].Value<string>();
                var temperatura = Encoding.UTF8.GetString(Convert.FromBase64String(temperaturaBase64));

                Invoke(() => AtualizarTemperatura(temperatura));
            };

            mqttClient.Subscribe(new string[] { "v3/lmic@ttn/devices/#" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            mqttClient.Connect(Guid.NewGuid().ToString(), "lmic@ttn", "NNSXS.4U2IUVA7CRNUPYY6UXC7WB7GIKKSJLXUOREY6OI.GR5N3GEPVTUAHYEI3BCCAMU7HQCTT4HGUU7QC7FYVHM7YVKD4YVA");
        }

        void AtualizarTemperatura(string temperatura)
        {
            var temperaturaComVirgula = temperatura.Replace('.', ',');
            var temperaturaFormatada = $"{temperaturaComVirgula}ºC";

            if (decimal.TryParse(temperaturaComVirgula, out var temperaturaDecimal))
            {
                Log($"Recebido atualização de temperatura: {temperaturaFormatada}");
                
                labelTemperatura.Text = temperaturaFormatada;
                progressBar.Value = Convert.ToInt32(temperaturaDecimal) + 150;
            }
            else
            {
                Log($"Recebido temperatura inválida: {temperatura}");
            }
        }

        void Log(string message)
        {
            var entry = $"[{DateTime.Now:G}] {message}";
            if (log.Text.Contains("Aguardando"))
            {
                log.Text = entry;
            }
            else
            {
                log.Text = entry + Environment.NewLine + log.Text;
            }
        }
    }
}