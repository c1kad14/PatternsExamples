using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.AggregateRoot
{
    public class Address
    {
	    public string Street { get; set; }
	    public AddressType? Type { get; set; }
	    public string City { get; set; }
    }
}
