using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class QuestionService : IQuestionServiceContract
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

        public string ClientAnswer(int index)
        {
            switch (index)
            {
                case 1:
                    return "Client Liked Pizza";
                    
                case 2:
                    return "Client Liked Noodles";
                    
                case 3:
                    return "Client Liked Fruit";
                    
                case 4:
                    return "Client Liked Veggies";
                    
                default:
                    return "Error Bliep!";
                    
            }

        }
    }
}
