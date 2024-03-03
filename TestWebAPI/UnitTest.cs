using WebAPI.Controllers;
using WebAPI;
using Newtonsoft.Json;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using Moq;

namespace TestWebAPI
{
    public class UnitTest
    {
        public const string BaseURL = "https://localhost:7233/api/KnowledgeBase";

        /// <summary>
        /// �������� ���������� ������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseAdd_Success()
        {
            var context = new ItsmWorkContext();
            var knowledgeMock = new Mock<KnowledgeRepo>(context);
            var knowledgeController = new KnowledgeBaseController(knowledgeMock.Object);

            var knowledgeBase = TestTools.GetKnowledgeBase();
            knowledgeMock.Setup(repo => repo.CreateKnowledgeBase(knowledgeBase)).Returns(knowledgeBase.Id);

            var result = knowledgeController.AddKnowledgeBase(knowledgeBase);

            knowledgeMock.Verify(x => x.CreateKnowledgeBase(knowledgeBase), Times.Once);
            Assert.IsType<Guid>(result);
            Assert.Equal(result, TestTools.Guid1);
        }

        /// <summary>
        /// ���������� � ������ ����������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseAddNull_Exception()
        {
            var context = new ItsmWorkContext();
            var knowledgeController = new KnowledgeBaseController(new KnowledgeRepo(context));

            var ex = Assert.Throws<ArgumentNullException>(() => knowledgeController.AddKnowledgeBase(null));

            Assert.Contains("����������� ������ �� ������.", ex.Message);
        }

        /// <summary>
        /// �������� ���������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseGet_Success()
        {
            var context = new ItsmWorkContext();
            var knowledgeMock = new Mock<KnowledgeRepo>(context);
            var knowledgeController = new KnowledgeBaseController(knowledgeMock.Object);

            var knowledgeBase = TestTools.GetKnowledgeBase();
            knowledgeMock.Setup(repo => repo.GetById(knowledgeBase.Id)).Returns(knowledgeBase);

            var result = knowledgeController.GetKnowledgeBaseById(TestTools.Guid1);

            knowledgeMock.Verify(x => x.GetById(TestTools.Guid1), Times.Once);
            Assert.IsType<KnowledgeBase>(result);
            Assert.Equal(knowledgeBase.Id, result.Id);
            Assert.Equal(knowledgeBase.Name, result.Name);
        }

        /// <summary>
        /// ��������� � ������ ����������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseGetWithoutId_Exception()
        {
            var context = new ItsmWorkContext();
            var knowledgeController = new KnowledgeBaseController(new KnowledgeRepo(context));

            var ex = Assert.Throws<ArgumentNullException>(() => knowledgeController.GetKnowledgeBaseById(Guid.Empty));

            Assert.Contains("������������� �� ��������.", ex.Message);
        }

        /// <summary>
        /// �������� ����������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseUpdate_Success()
        {
            var context = new ItsmWorkContext();
            var knowledgeMock = new Mock<KnowledgeRepo>(context);
            var knowledgeController = new KnowledgeBaseController(knowledgeMock.Object);

            var knowledgeBase = TestTools.GetKnowledgeBase();
            knowledgeMock.Setup(repo => repo.Update(knowledgeBase)).Returns(true);

            var result = knowledgeController.UpdateKnowledgeBase(knowledgeBase);

            knowledgeMock.Verify(x => x.Update(knowledgeBase), Times.Once);
            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        /// <summary>
        /// ���������� � ������ ����������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseUpdateWithoutObject_Exception()
        {
            var context = new ItsmWorkContext();
            var knowledgeController = new KnowledgeBaseController(new KnowledgeRepo(context));

            var ex = Assert.Throws<ArgumentNullException>(() => knowledgeController.UpdateKnowledgeBase(null));

            Assert.Contains("����������� ������ �� ������.", ex.Message);
        }

        /// <summary>
        /// �������� ��������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseDelete_Success()
        {
            var context = new ItsmWorkContext();
            var knowledgeMock = new Mock<KnowledgeRepo>(context);
            var knowledgeController = new KnowledgeBaseController(knowledgeMock.Object);

            var knowledgeBase = TestTools.GetKnowledgeBase();
            knowledgeMock.Setup(repo => repo.DeleteById(knowledgeBase.Id)).Returns(true);

            var result = knowledgeController.DeleteKnowledgeBase(knowledgeBase.Id);

            knowledgeMock.Verify(x => x.DeleteById(knowledgeBase.Id), Times.Once);
            Assert.IsType<bool>(result);
            Assert.True(result);
        }

        /// <summary>
        /// �������� � ������ ����������.
        /// </summary>
        [Fact]
        public void KnowledgeBaseDeleteWithEmptyGuid_Exception()
        {
            var context = new ItsmWorkContext();
            var knowledgeController = new KnowledgeBaseController(new KnowledgeRepo(context));

            var ex = Assert.Throws<ArgumentNullException>(() => knowledgeController.DeleteKnowledgeBase(Guid.Empty));

            Assert.Contains("������������� �� ��������.", ex.Message);
        }
    }
}