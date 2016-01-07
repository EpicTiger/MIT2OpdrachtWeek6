using System;
using System.Windows.Forms;
using QuestionContracts;
using EntityBase;

namespace QuestionServer
{
    public class QuestionService:IQuestionServiceContract
    {
        
        //contracts
        /// <summary>
        /// If client asks for a question he gets it
        /// </summary>
        /// <returns></returns>
        public QuestionDataContract ClientQuestion()
        {
            //do magic return a questiondatacontract..
            try
            {
                return Data.QDC;
            }
            catch
            {
                throw new Exception("Couldnt make QuestionDataContract for CLient");
            }
        }

        public void ClientAnswer(int index)
        {
            switch (index)
            {
                case 1:
                    MessageBox.Show("Client Liked Pizza");
                    break;
                case 2:
                    MessageBox.Show("Client Liked Noodles");
                    break;
                case 3:
                    MessageBox.Show("Client Liked Fruit");
                    break;
                case 4:
                    MessageBox.Show("Client Liked Veggies");
                    break;
                default:
                    MessageBox.Show("Error Bliep!");
                    break;
            }
            
        }
    }
}
