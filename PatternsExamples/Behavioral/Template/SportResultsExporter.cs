﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.Template
{
	class SportResultsExporter : DataExporter

	{
		protected override void SetData()
		{
			this.data = "Sport data: Argentina(1) - (0) Nigeria";
		}
	}
}
