using System.Collections.Generic;
using System.Linq;

namespace PatternsExamples.Structural.Adapter
{
	/// <summary>
	/// Adapter via inheritance
	/// </summary>
	class VendorAdapter : Vendor, ITarget
    {
	    public List<string> GetProducts() => GetStuff().ToList();
    }

	/// <summary>
	/// Adapter via composition
	/// </summary>
	class VendorAdapterComposition : ITarget
	{
		public List<string> GetProducts() => new Vendor().GetStuff().ToList();
	}

}
