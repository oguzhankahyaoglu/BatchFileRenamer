﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatchFileRenamer {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BatchFileRenamer.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Browse.
        /// </summary>
        internal static string btnBrowser {
            get {
                return ResourceManager.GetString("btnBrowser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start Renaming.
        /// </summary>
        internal static string btnStart {
            get {
                return ResourceManager.GetString("btnStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group files by extension?.
        /// </summary>
        internal static string cbGroupByExt {
            get {
                return ResourceManager.GetString("cbGroupByExt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include subfolders?.
        /// </summary>
        internal static string cbIncludeSubfolders {
            get {
                return ResourceManager.GetString("cbIncludeSubfolders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filter for files (*.mp4 is an extension filter, leave it blank if not sure).
        /// </summary>
        internal static string lblFilter {
            get {
                return ResourceManager.GetString("lblFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BatchFileRenamer: Renames all files in a folder starting by 1. Optionally, they can be grouped by extension, too..
        /// </summary>
        internal static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}