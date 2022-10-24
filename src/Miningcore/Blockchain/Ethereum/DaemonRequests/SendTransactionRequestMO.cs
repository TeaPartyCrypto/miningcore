using Miningcore.Serialization;
using Newtonsoft.Json;

namespace Miningcore.Blockchain.Ethereum.DaemonRequests;

public class SendTransactionRequestMO : SendTransactionRequestEth
{
    /// <summary>
    /// The maximum total fee per gas the sender is willing to pay(includes the network / base fee and miner / priority fee) in wei
    /// </summary>
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong>))]
    public ulong gasPrice { get; set; }
}
