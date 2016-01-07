using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuestionContracts;
using EntityBase;

namespace QuestionServer
{
    public partial class Form1 : Form
    {
        
        private Server server;
        private Thread serverThread;
        public Form1()
        {
            InitializeComponent();
            
            server = new Server();
            serverThread = new Thread(new ThreadStart(server.StartServices));
            serverThread.Start();
            
        }
        ~Form1()
        {
            serverThread.Abort();
            serverThread.Join();   
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            Data.QDC = new QuestionDataContract
            {
                Question = TxQuestion.Text.Trim(),
                AnswerA = TxAnswerA.Text.Trim(),
                AnswerB = TxAnswerB.Text.Trim(),
                AnswerC = TxAnswerC.Text.Trim(),
                AnswerD = TxAnswerD.Text.Trim(),
                FeedbackA = TxFeedbackA.Text.Trim(),
                FeedbackB = TxFeedbackB.Text.Trim(),
                FeedbackC = TxFeedbackC.Text.Trim(),
                FeedbackD = TxFeedbackD.Text.Trim(),
            };
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            TxQuestion.Text = string.Empty;
            TxAnswerA.Text = string.Empty;
            TxAnswerB.Text = string.Empty;
            TxAnswerC.Text = string.Empty;
            TxAnswerD.Text = string.Empty;
            TxFeedbackA.Text = string.Empty;
            TxFeedbackB.Text = string.Empty;
            TxFeedbackC.Text = string.Empty;
            TxFeedbackD.Text = string.Empty;
        }
    }

    public class Server
    {
        public void StartServices()
        {
            using (var host = new ServiceHost(typeof(QuestionService)))
            {
                host.Open();
                MessageBox.Show("QuestionService has started press ok To end the service");
            }
        }
    }
}
