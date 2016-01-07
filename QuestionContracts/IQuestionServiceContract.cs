using System.ServiceModel;

namespace QuestionContracts
{
    [ServiceContract]
    public interface IQuestionServiceContract
    {
        [OperationContract]
        QuestionDataContract ClientQuestion();
        [OperationContract]
        void ClientAnswer(int index);
    }
}
