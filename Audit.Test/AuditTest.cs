using System;
using NUnit.Framework;
using AuditMvc.Controllers;
using AuditCore.BusinessLogic;
using Moq;


namespace AuditCore.Test
{
    [TestFixture]
    public class AuditTest
    {
        [Test]
        public void Test_GivenProcessType_ShouldReturnProcessAudit()
        {
            var factory = new AuditFactory();
            var result = factory.Create(AuditMvc.Models.AuditType.Process);

            Assert.AreEqual(result.GetType(), typeof(ProcessAudit));
        }

        [Test]
        public void Test_GivenSystemType_ShouldReturnSystemAudit()
        {
            var factory = new AuditFactory();
            var result = factory.Create(AuditMvc.Models.AuditType.Process);

            Assert.AreEqual(result.GetType(), typeof(SystemAudit));
        }

        [Test]
        public void Test_GivenValidProcessType_ShouldHaveCalledCreate()
        {
            var factory = new Mock<AuditFactory>();


            factory
                .Setup(a => a.Create(AuditMvc.Models.AuditType.Process))
                .Returns(() => {
                    var audit = new ProcessAudit();
                    audit.AuditItems = new System.Collections.Generic.List<AuditItem>();
                    var auditItem = new AuditItem();
                    audit.AuditItems.Add(auditItem);
                    return audit;
                });

            

            var controller = new AuditController(factory.Object);
            var result = controller.Create(new object());

            factory.Verify(a => a.Create(AuditMvc.Models.AuditType.Process));
        }
    }
}
