﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace CompactGUI.My {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsContextMenuEnabled {
            get {
                return ((bool)(this["IsContextMenuEnabled"]));
            }
            set {
                this["IsContextMenuEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int SavedCompressionOption {
            get {
                return ((int)(this["SavedCompressionOption"]));
            }
            set {
                this["SavedCompressionOption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MinimisetoTray {
            get {
                return ((bool)(this["MinimisetoTray"]));
            }
            set {
                this["MinimisetoTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowNotifications {
            get {
                return ((bool)(this["ShowNotifications"]));
            }
            set {
                this["ShowNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dl_; gif; jpg; jpeg; png; wmf; mkv; mp4; wmv; avi; bik; flv; ogg; mpg; m2v; m4v; " +
            "vob; mp3; aac; wma; flac; zip; xap; rar; 7z; cab; lzx; docx; xlsx; pptx; vssx; v" +
            "stx; onepkg")]
        public string NonCompressableList {
            get {
                return ((string)(this["NonCompressableList"]));
            }
            set {
                this["NonCompressableList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SkipNonCompressable {
            get {
                return ((bool)(this["SkipNonCompressable"]));
            }
            set {
                this["SkipNonCompressable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ResultsDB {
            get {
                return ((string)(this["ResultsDB"]));
            }
            set {
                this["ResultsDB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime ResultsDB_Date {
            get {
                return ((global::System.DateTime)(this["ResultsDB_Date"] ?? DateTime.Now));
            }
            set {
                this["ResultsDB_Date"] = value;
            }
        }
    }
}
