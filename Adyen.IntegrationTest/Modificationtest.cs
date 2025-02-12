using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class ModificationTest : BaseTest
    {
        [TestMethod]
        public void TestCaptureSuccess()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Modification(client);
            //Send capture call with psp refernce
            var captureRequest = base.CreateCaptureTestRequest(paymentResultPspReference);
            var captureResult = modification.Capture(captureRequest);
            Assert.AreEqual(captureResult.Response, Adyen.Model.Enum.ResponseEnum.CaptureReceived);
        }

        [TestMethod]
        public void TestCancelOrRefundReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Modification(client);
            var cancelOrRefundRequest = base.CreateCancelOrRefundTestRequest(pspReference: paymentResultPspReference);
            var cancelOrRefundResult = modification.CancelOrRefund(cancelOrRefundRequest);
            Assert.AreEqual(cancelOrRefundResult.Response, Adyen.Model.Enum.ResponseEnum.CancelOrRefundReceived);
        }

        [TestMethod]
        public void TestRefundReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Modification(client);
            var refundRequest = base.CreateRefundTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Refund(refundRequest);
            Assert.AreEqual(refundResult.Response, Adyen.Model.Enum.ResponseEnum.RefundReceived);
        }

        [TestMethod]
        public void TestCancelReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Modification(client);
            var cancelRequest = base.CreateCancelTestRequest(pspReference: paymentResultPspReference);
            var refundResult = modification.Cancel(cancelRequest);
            Assert.AreEqual(refundResult.Response, Adyen.Model.Enum.ResponseEnum.CancelReceived);
        }

        [TestMethod]
        public void TestAdjustAuthorisationReceived()
        {
            var paymentResultPspReference = GetTestPspReference();
            //Call authorization test
            var client = base.CreateApiKeyTestClient();
            var modification = new Modification(client);
            var adjustAuthorisationtestRequest = base.CreateAdjustAuthorisationtestRequest(pspReference: paymentResultPspReference);
            var adjustAuthorisationtestResult = modification.AdjustAuthorisation(adjustAuthorisationtestRequest);
            Assert.AreEqual(adjustAuthorisationtestResult.Response, Adyen.Model.Enum.ResponseEnum.AdjustAuthorisationReceived);
         
        }
    }
}
