using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using System;
using System.Windows.Forms;

namespace Sender
{
    public partial class SendFrm : Form
    {
        public SendFrm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ePatient patient = new ePatient();
            patient.Id = txtId.Text;
            patient.PId = txtPId.Text;
            patient.FName = txtName.Text;
            patient.Address = txtAddr.Text;

            IConnectionFactory connectionFactory = new ConnectionFactory("tcp://localhost:61616");
            IConnection connection = connectionFactory.CreateConnection("admin","admin");
            connection.Start();
            ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue queue = new ActiveMQQueue("myQ");
            IMessageProducer producer = session.CreateProducer(queue);
            string xml = new XMLObjConverter<ePatient>().object2XML(patient);
            IMessage message = new ActiveMQTextMessage(xml);
            producer.Send(message);
            session.Close();
            connection.Close();
            MessageBox.Show("Gửi thành công!");

        }
    }
}
