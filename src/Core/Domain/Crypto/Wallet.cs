
using System.Text.Json.Serialization;

namespace FSH.WebApi.Domain.Crypto;
public class Wallet : BaseEntity<long>, IAggregateRoot
{
    public string Name { get; private set; } = default!;
    public string NameMethod { get; private set; } = default!;
    public Guid MarketId { get; private set; }
    public Market Market { get; private set; } = default!;

    public decimal CryptoAmount { get; private set; }
    public decimal EurAmount { get; private set; }

    public Wallet(string name, string nameMethod, decimal cryptoAmount, decimal eurAmount, Guid marketId)
    {
        Name = name;
        NameMethod = nameMethod;
        CryptoAmount = cryptoAmount;
        EurAmount = eurAmount;
        MarketId = marketId;
    }
}

public class Market : BaseEntity, IAggregateRoot
{
    public string MarketSymbol { get; private set; } = default!;
    public int CountDecimalNumberInPosition { get; private set; } = 2;
    public int CountDecimalNumberCryptoCurency { get; private set; } = 6!;
    public Wallet Wallet { get; private set; } = default!;

    public Market(string marketSymbol, int countDecimalNumberInPosition, int countDecimalNumberCryptoCurency)
    {
        MarketSymbol = marketSymbol;
        CountDecimalNumberInPosition = countDecimalNumberInPosition;
        CountDecimalNumberCryptoCurency = countDecimalNumberCryptoCurency;
    }
}
