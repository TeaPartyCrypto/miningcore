using Miningcore.Serialization;
using Newtonsoft.Json;

namespace Miningcore.Blockchain.Ethereum.DaemonRequests;

public class SendTransactionRequestEth : SendTransactionRequest
{
    /// <summary>
    /// Maximum fee per gas the sender is willing to pay to miners in wei.
    /// </summary>
    [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong>))]
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public ulong MaxPriorityFeePerGas { get; set; }

    /// <summary>
    /// The maximum total fee per gas the sender is willing to pay(includes the network / base fee and miner / priority fee) in wei
    /// </summary>
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong>))]
    public ulong MaxFeePerGas { get; set; }
}
