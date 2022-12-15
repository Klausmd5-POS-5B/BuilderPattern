namespace BuilderPatternDemo;

public class Product
{
    private string _requiredA = null!;
    private string _requiredB = null!;
    private int _optionalC;
    private string? _optionalD;

    public string RequiredA => _requiredA;
    public string RequiredB => _requiredB;
    public int OptionalC => _optionalC;
    public string? OptionalD => _optionalD;

    private Product(Builder builder)
    {
        _requiredA = builder._requiredA;
        _requiredB = builder._requiredB;
        _optionalC = builder._optionalC;
        _optionalD = builder._optionalD;
    }

    public class Builder
    {
        internal string _requiredA = null!;
        internal string _requiredB = null!;
        internal int _optionalC;
        internal string? _optionalD;

        public Builder(string requiredA, string requiredB)
        {
            _requiredA = requiredA;
            _requiredB = requiredB;
        }

        public Builder SetOptionalC(int val)
        {
            _optionalC = val;
            return this;
        }

        public Builder SetOptionalD(string? val)
        {
            _optionalD = val;
            return this;
        }

        public Product Build()
        {
            var pr = new Product(this);
            if (pr.RequiredA == null || pr.RequiredB == null)
                throw new ArgumentNullException("RequiredA or RequiredB is null");

            return pr;
        }
    }
}