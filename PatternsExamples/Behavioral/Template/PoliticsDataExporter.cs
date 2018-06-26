using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.Template
{
    class PoliticsDataExporter : DataExporter
    {
	    protected override void SetData()
	    {
		    this.data = "Politics data: Brexit";
	    }
    }
}
