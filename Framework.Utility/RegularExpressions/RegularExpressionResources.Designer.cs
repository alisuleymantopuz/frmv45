﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Framework.Utility.RegularExpressions {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class RegularExpressionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RegularExpressionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Framework.Utility.RegularExpressions.RegularExpressionResources", typeof(RegularExpressionResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(?!0,?\d)([0-9]{2}[0-9]{0,}(\.[0-9]{2}))$.
        /// </summary>
        public static string CurrencyPattern {
            get {
                return ResourceManager.GetString("CurrencyPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^((?&gt;[a-zA-Z\d!#$%&amp;&apos;*+\-/=?^_`{|}~]+\x20*|&quot;((?=[\x01-\x7f])[^&quot;\\]|\\[\x01-\x7f])*&quot;\x20*)*(?&lt;angle&gt;&lt;))?((?!\.)(?&gt;\.?[a-zA-Z\d!#$%&amp;&apos;*+\-/=?^_`{|}~]+)+|&quot;((?=[\x01-\x7f])[^&quot;\\]|\\[\x01-\x7f])*&quot;)@(((?!-)[a-zA-Z\d\-]+(?&lt;!-)\.)+[a-zA-Z]{2,}|\[(((?(?&lt;!\[)\.)(25[0-5]|2[0-4]\d|[01]?\d?\d)){4}|[a-zA-Z\d\-]*[a-zA-Z\d]:((?=[\x01-\x7f])[^\\\[\]]|\\[\x01-\x7f])+)\])(?(angle)&gt;)$.
        /// </summary>
        public static string EmailPattern {
            get {
                return ResourceManager.GetString("EmailPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$.
        /// </summary>
        public static string PhonePattern {
            get {
                return ResourceManager.GetString("PhonePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (((0[1-9]|[12][0-9]|3[01])([/])(0[13578]|10|12)([/])(\d{4}))|(([0][1-9]|[12][0-9]|30)([/])(0[469]|11)([/])(\d{4}))|((0[1-9]|1[0-9]|2[0-8])([/])(02)([/])(\d{4}))|((29)(\.|-|\/)(02)([/])([02468][048]00))|((29)([/])(02)([/])([13579][26]00))|((29)([/])(02)([/])([0-9][0-9][0][48]))|((29)([/])(02)([/])([0-9][0-9][2468][048]))|((29)([/])(02)([/])([0-9][0-9][13579][26]))).
        /// </summary>
        public static string ShortDatePattern {
            get {
                return ResourceManager.GetString("ShortDatePattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(((ht|f)tp(s?))\://)?(www.|[a-zA-Z].)[a-zA-Z0-9\-\.]+\.(com|edu|gov|mil|net|org|biz|tr|info|name|museum|us|ca|uk)(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\;\?\&apos;\\\+&amp;amp;%\$#\=~_\-]+))*$.
        /// </summary>
        public static string UrlPattern {
            get {
                return ResourceManager.GetString("UrlPattern", resourceCulture);
            }
        }
    }
}
