﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurierManagementSystemCSharp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\courier.mdf;I" +
            "ntegrated Security=True")]
        public string courierConnectionString {
            get {
                return ((string)(this["courierConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1" +
            "F8_URIERMANAGEMENTSYSTEMCSHA\\CURIERMANAGEMENTSYSTEMCSHARP\\CURIERMANAGEMENTSYSTEM" +
            "CSHARP\\COURIER.MDF;Integrated Security=True")]
        public string _3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA_CURIERMANAGEMENTSYSTEMCSHARP_CURIERMANAGEMENTSYSTEMCSHARP_COURIER_MDFConnectionString {
            get {
                return ((string)(this["_3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA_CURIERMANAGEMENTSYSTE" +
                    "MCSHARP_CURIERMANAGEMENTSYSTEMCSHARP_COURIER_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Not set")]
        public string purchasedatagridview {
            get {
                return ((string)(this["purchasedatagridview"]));
            }
            set {
                this["purchasedatagridview"] = value;
            }
        }
    }
}
