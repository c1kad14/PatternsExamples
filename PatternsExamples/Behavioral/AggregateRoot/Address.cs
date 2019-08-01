namespace PatternsExamples.Behavioral.AggregateRoot
{
    public class Address
    {
	    public string Street { get; set; }
	    public AddressType? Type { get; set; }
	    public string City { get; set; }
    }
}
