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
            txtId.Enabled = false;
            txtPId.Enabled = false;
            txtName.Enabled = false;
            txtAddr.Enabled = false;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtPId.Clear();
            txtName.Clear();
            txtAddr.Clear();

            txtId.Enabled = true;
            txtPId.Enabled = true;
            txtName.Enabled = true;
            txtAddr.Enabled = true;

            txtId.Focus();
        }
    }
}
