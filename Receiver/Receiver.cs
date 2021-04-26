using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using System.Windows.Forms;
using Sender;

namespace Receiver
{
    public partial class ReceiverFrm : Form
    {
        public ReceiverFrm()
        {
            InitializeComponent();
            receive();
        }

        public void receive()
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue destination2 = new ActiveMQQueue("myQ");
            IMessageConsumer cons = session.CreateConsumer(destination2);
            cons.Listener += new MessageListener(messageListen);
        }

        private void messageListen(IMessage message)
        {
            ITextMessage msg = message as ITextMessage;
            string content = msg.Text;

            ePatient patient = new XmlToObjConverter<ePatient>().XML2obj(content);
            addListBox(patient);

        }

        private void addListBox(ePatient patient)
        {

            lbxPatient.Invoke(new MethodInvoker(delegate ()
            {
                lbxPatient.Items.Add(patient);
            }));

        }

        private void lbxPatient_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ePatient p = (ePatient)lbxPatient.SelectedItem;
            if (p != null)
            {
                txtId.Text = p.Id;
                txtPId.Text = p.PId;
                txtName.Text = p.FName;
                txtAddr.Text = p.Address;
            }
            else
                MessageBox.Show("Hãy chọn một bệnh nhân");
            

        }

        private void btnCount_Click(object sender, System.EventArgs e)
        {
            int count = lbxPatient.Items.Count;
            btnCount.Text = "Số bệnh nhân: " + count;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
