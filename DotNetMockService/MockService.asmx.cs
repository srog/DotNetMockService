using System.Net;
using System.Web.Services;
using Newtonsoft.Json;

namespace DotNetMockService
{
    /// <summary>
    /// Summary description for MockService
    /// </summary>
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class MockService : WebService
    {
        [WebMethod]
        public HttpStatusCode GetMockServiceData(string payload)
        {
            var transfer = JsonConvert.DeserializeObject<TransferWrapper>(payload);

            if (transfer.Transfer != null && transfer.Transfer.Reference > 0)
            {
                return HttpStatusCode.OK;
            }
            else
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
