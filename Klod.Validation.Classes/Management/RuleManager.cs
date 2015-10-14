using Klod.Validation.Classes.Mapping;

namespace Klod.Validation.Classes.Management
{
    public class RuleManager:RulesManagerBase
	{
		public RuleManager() : base() { }

		protected override RulesRepository MakeRulesRepository()
		{
			return new XmlRulesRepository();
		}

	
	}
}
