using System;
using System.Collections.Generic;
using System.Text;
using Klod.Validation.Configuration;
using Klod.Reflection;

namespace Klod.Validation
{
    public static class RulesValidationFactory
    {
        public static RulesManagerBase MakeRulesManager()
        {
            try
            {
                string[] args = Config.Default.RuleManagerClass.Split(',');
                return (RulesManagerBase)ClassLoader.LoadFrom(Config.Default.RulesValidationClassesAssembly, args[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot load a RulesManagerBase instance.", ex);
            }
        }

        public static RuleMap MakeRuleMap()
        {
            try
            {
                string[] args = Config.Default.RuleMapClass.Split(',');
                return (RuleMap)ClassLoader.LoadFrom(Config.Default.RulesValidationClassesAssembly, args[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot load a RuleMap instance.", ex);
            }
        }

        public static RulesRepository MakeRulesRepository()
        {
            try
            {
                string[] args = Config.Default.RuleMapClass.Split(',');
                return (RulesRepository)ClassLoader.LoadFrom(Config.Default.RulesValidationClassesAssembly, args[0]);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot load a RulesRepository instance.", ex);
            }
        }

        
    }
}
