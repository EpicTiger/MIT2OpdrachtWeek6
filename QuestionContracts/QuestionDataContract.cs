using System.Runtime.Serialization;

namespace QuestionContracts
{
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
