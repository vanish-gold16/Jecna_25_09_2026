struct Currency
{
    static decimal EurToCzk = 25;
    static decimal UsdToCzk = 22;

    public decimal Amount { get; set; }
    public String Code { get; set; }

    public Currency(decimal amount, String code)
    {
        Amount = amount;
        Code = code;
    }

    public override string ToString()
    {
        return $"{Amount} {Code}";
    }

    public decimal ConvertToCZ()
    {
        switch(Code)
        {
            case "USD":
                return Amount * UsdToCzk;
            case "EUR":
                return Amount * EurToCzk;
            case "CZK":
                return Amount;
            default: 
                throw new Exception("Unknown currency");    
        }
    }
}