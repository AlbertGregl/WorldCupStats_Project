﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopWPF.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class SettingsWPF : global::System.Configuration.ApplicationSettingsBase {
        
        private static SettingsWPF defaultInstance = ((SettingsWPF)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SettingsWPF())));
        
        public static SettingsWPF Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Small")]
        public string ScreenResolution {
            get {
                return ((string)(this["ScreenResolution"]));
            }
            set {
                this["ScreenResolution"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("cro")]
        public string AppLanguage {
            get {
                return ((string)(this["AppLanguage"]));
            }
            set {
                this["AppLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("men")]
        public string AppChampionship {
            get {
                return ((string)(this["AppChampionship"]));
            }
            set {
                this["AppChampionship"] = value;
            }
        }
    }
}
