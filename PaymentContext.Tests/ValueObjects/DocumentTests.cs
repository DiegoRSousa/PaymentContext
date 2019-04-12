using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests 
    {
        [TestMethod]
        public void ShouldReturnErrorWhenCnpjIsInvalid() 
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }
        [TestMethod]
        public void ShouldReturnSuccessWhenCnpjIsValid() 
        {
            var doc = new Document("14812581250147", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }
        [TestMethod]
        public void ShouldReturnErrorWhenCpfIsInvalid() 
        {
            var doc = new Document("033", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow("08554687521")]
        [DataRow("08585287895")]
        [DataRow("09854625887")]
        public void ShouldReturnSuccessWhenCpfIsValid(string cpf) 
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }

    }
}