using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentReposioty
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription (Student student);
    }
}