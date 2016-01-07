using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
     [ServiceContract]
    public interface IQuestionServiceContract
    {
        [OperationContract]
        QuestionDataContract ClientQuestion();
        [OperationContract]
        string ClientAnswer(int index);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class QuestionDataContract
    {
        [DataMember]
        public string Question { get; set; }
        [DataMember]
        public string AnswerA { get; set; }
        [DataMember]
        public string AnswerB { get; set; }
        [DataMember]
        public string AnswerC { get; set; }
        [DataMember]
        public string AnswerD { get; set; }
        [DataMember]
        public string FeedbackA { get; set; }
        [DataMember]
        public string FeedbackB { get; set; }
        [DataMember]
        public string FeedbackC { get; set; }
        [DataMember]
        public string FeedbackD { get; set; }
    }
}
