using System;
using System.Windows.Forms;
using System.ServiceModel;
using QuestionContracts;

namespace QuestionClient
{
    public partial class Form1 : Form
    {
        private readonly IQuestionServiceContract proxy;
        public Form1()
        {
            InitializeComponent();

            var channelFactory = new ChannelFactory<IQuestionServiceContract>("QuestionServiceEndpoint");
            proxy = channelFactory.CreateChannel();
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            waaromLabelA.Show();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            waaromLabelB.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            waaromLabelC.Show();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            waaromLabelD.Show();
        }
        
        private void btnLoadPage_Click(object sender, EventArgs e)
        {
            waaromLabelA.Hide();
            waaromLabelB.Hide();
            waaromLabelC.Hide();
            waaromLabelD.Hide();

            try
            {
                var entity = new QuestionDataContract();
                entity = proxy.ClientQuestion();
                vraagLabel.Text = entity.Question;
                antwoordLabelA.Text = entity.AnswerA;
                antwoordLabelB.Text = entity.AnswerB;
                antwoordLabelC.Text = entity.AnswerC;
                antwoordLabelD.Text = entity.AnswerD;
                waaromLabelA.Text = entity.FeedbackA;
                waaromLabelB.Text = entity.FeedbackB;
                waaromLabelC.Text = entity.FeedbackC;
                waaromLabelD.Text = entity.FeedbackD;
            }
            catch
            {
                MessageBox.Show("Server wasn't Ready");
            }
        }
      
    }
}
