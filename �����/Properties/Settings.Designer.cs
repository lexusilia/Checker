﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.1
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Шашки.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Игрок 1")]
        public string Player1 {
            get {
                return ((string)(this["Player1"]));
            }
            set {
                this["Player1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Игрок 2")]
        public string Player2 {
            get {
                return ((string)(this["Player2"]));
            }
            set {
                this["Player2"] = value;
            }
        }
        
        /// <summary>
        /// 0 - компьютер; 1 - человек
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("0 - компьютер; 1 - человек")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int Game_type {
            get {
                return ((int)(this["Game_type"]));
            }
            set {
                this["Game_type"] = value;
            }
        }
        
        /// <summary>
        /// False - нижние на столе
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("False - нижние на столе")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Player1_color {
            get {
                return ((bool)(this["Player1_color"]));
            }
            set {
                this["Player1_color"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveGameBeforeExit {
            get {
                return ((bool)(this["SaveGameBeforeExit"]));
            }
            set {
                this["SaveGameBeforeExit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PlaySound {
            get {
                return ((bool)(this["PlaySound"]));
            }
            set {
                this["PlaySound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PlayBackgroundMusic {
            get {
                return ((bool)(this["PlayBackgroundMusic"]));
            }
            set {
                this["PlayBackgroundMusic"] = value;
            }
        }
        
        /// <summary>
        /// Уровень сложности 0-3
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Уровень сложности 0-3")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int HardLevel {
            get {
                return ((int)(this["HardLevel"]));
            }
            set {
                this["HardLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HighlightedMove {
            get {
                return ((bool)(this["HighlightedMove"]));
            }
            set {
                this["HighlightedMove"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstStart {
            get {
                return ((bool)(this["FirstStart"]));
            }
            set {
                this["FirstStart"] = value;
            }
        }
        
        /// <summary>
        /// Уровень сложности 0-2
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Уровень сложности 0-2")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string Difficult {
            get {
                return ((string)(this["Difficult"]));
            }
            set {
                this["Difficult"] = value;
            }
        }
    }
}
