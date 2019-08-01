using System;
using System.Collections.Generic;

namespace PatternsExamples.Creational.Factory
{
	class ModelFactory
	{
		private Dictionary<Type, IModel> _dict;

		public ModelFactory()
		{
			_dict = new Dictionary<Type, IModel>
			{
				[typeof(ModelA)] = new ModelA(),
				[typeof(ModelB)] = new ModelB()
			};
		}

		public TModel GetModel<TModel>() where TModel : IModel
		{
			return (TModel) _dict[typeof(TModel)];
		}
	}
}