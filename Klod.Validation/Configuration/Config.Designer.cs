﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klod.Validation.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Config : global::System.Configuration.ApplicationSettingsBase {
        
        private static Config defaultInstance = ((Config)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Config())));
        
        public static Config Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("z:\\me\\Documents\\Projects\\RulesEngineValidator\\Klod.Validation.Classes\\bin\\Klod.Va" +
            "lidation.Classes.dll")]
        public string RulesValidationClassesAssembly {
            get {
                return ((string)(this["RulesValidationClassesAssembly"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Klod.Validation.Classes.Management.RuleManager,Klod.Validation.Classes.Management" +
            "")]
        public string RuleManagerClass {
            get {
                return ((string)(this["RuleManagerClass"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Klod.Validation.Classes.Mapping.XmlRuleMap,Klod.Validation.Classes.Mapping")]
        public string RuleMapClass {
            get {
                return ((string)(this["RuleMapClass"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Klod.Validation.Classes.Mapping.XmlRulesRepository,Klod.Validation.Classes.Mappin" +
            "g")]
        public string RulesRepositoryClass {
            get {
                return ((string)(this["RulesRepositoryClass"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\mappings\\rulesMap.xml")]
        public string FilesMapAddresss {
            get {
                return ((string)(this["FilesMapAddresss"]));
            }
        }
    }
}