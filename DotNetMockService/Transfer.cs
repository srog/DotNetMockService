using Newtonsoft.Json;

namespace DotNetMockService
{
    public class TransferWrapper
    {
        public Transfer Transfer;
    }
    [JsonObject("transfer")]
    public class Transfer
    {
        [JsonProperty("voucher")]
        public string Voucher;

        [JsonProperty("reference")]
        public int Reference;
    }
}