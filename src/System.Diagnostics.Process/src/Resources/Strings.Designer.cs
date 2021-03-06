﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    using System.Reflection;
    
    
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Diagnostics.Process.Resources.Strings", typeof(Strings).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Maximum working set size is invalid. It must be greater than or equal to the minimum working set size..
        /// </summary>
        internal static string BadMaxWorkset {
            get {
                return ResourceManager.GetString("BadMaxWorkset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minimum working set size is invalid. It must be less than or equal to the maximum working set size..
        /// </summary>
        internal static string BadMinWorkset {
            get {
                return ResourceManager.GetString("BadMinWorkset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve process identifier from the process handle..
        /// </summary>
        internal static string CantGetProcessId {
            get {
                return ResourceManager.GetString("CantGetProcessId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardError has not been redirected..
        /// </summary>
        internal static string CantGetStandardError {
            get {
                return ResourceManager.GetString("CantGetStandardError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardIn has not been redirected..
        /// </summary>
        internal static string CantGetStandardIn {
            get {
                return ResourceManager.GetString("CantGetStandardIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardOut has not been redirected or the process hasn&apos;t started yet..
        /// </summary>
        internal static string CantGetStandardOut {
            get {
                return ResourceManager.GetString("CantGetStandardOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  Cannot mix synchronous and asynchronous operation on process stream..
        /// </summary>
        internal static string CantMixSyncAsyncOperation {
            get {
                return ResourceManager.GetString("CantMixSyncAsyncOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Process object must have the UseShellExecute property set to false in order to redirect IO streams..
        /// </summary>
        internal static string CantRedirectStreams {
            get {
                return ResourceManager.GetString("CantRedirectStreams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Process object must have the UseShellExecute property set to false in order to use environment variables..
        /// </summary>
        internal static string CantUseEnvVars {
            get {
                return ResourceManager.GetString("CantUseEnvVars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load Category Help data because an invalid index &apos;{0}&apos; was read from the registry..
        /// </summary>
        internal static string CategoryHelpCorrupt {
            get {
                return ResourceManager.GetString("CategoryHelpCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t connect to remote machine..
        /// </summary>
        internal static string CouldntConnectToRemoteMachine {
            get {
                return ResourceManager.GetString("CouldntConnectToRemoteMachine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Couldn&apos;t get process information from performance counter..
        /// </summary>
        internal static string CouldntGetProcessInfos {
            get {
                return ResourceManager.GetString("CouldntGetProcessInfos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load Performance Counter data because an unexpected registry key value type was read from &apos;{0}&apos;..
        /// </summary>
        internal static string CounterDataCorrupt {
            get {
                return ResourceManager.GetString("CounterDataCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load Counter Name data because an invalid index &apos;{0}&apos; was read from the registry..
        /// </summary>
        internal static string CounterNameCorrupt {
            get {
                return ResourceManager.GetString("CounterNameCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to enumerate the process modules..
        /// </summary>
        internal static string EnumProcessModuleFailed {
            get {
                return ResourceManager.GetString("EnumProcessModuleFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A 32 bit processes cannot access modules of a 64 bit process..
        /// </summary>
        internal static string EnumProcessModuleFailedDueToWow {
            get {
                return ResourceManager.GetString("EnumProcessModuleFailedDueToWow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The environment block used to start a process cannot be longer than 65535 bytes.  Your environment block is {0} bytes long.  Remove some environment variables and try again..
        /// </summary>
        internal static string EnvironmentBlockTooLong {
            get {
                return ResourceManager.GetString("EnvironmentBlockTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot start process because a file name has not been provided..
        /// </summary>
        internal static string FileNameMissing {
            get {
                return ResourceManager.GetString("FileNameMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WaitForInputIdle failed.  This could be because the process does not have a graphical interface..
        /// </summary>
        internal static string InputIdleUnkownError {
            get {
                return ResourceManager.GetString("InputIdleUnkownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified executable is not a valid application for this OS platform..
        /// </summary>
        internal static string InvalidApplication {
            get {
                return ResourceManager.GetString("InvalidApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of argument &apos;{0}&apos; ({1}) is invalid for Enum type &apos;{2}&apos;..
        /// </summary>
        internal static string InvalidEnumArgument {
            get {
                return ResourceManager.GetString("InvalidEnumArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid value &apos;{1}&apos; for parameter &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidParameter {
            get {
                return ResourceManager.GetString("InvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process with an Id of {0} is not running..
        /// </summary>
        internal static string MissingProccess {
            get {
                return ResourceManager.GetString("MissingProccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No process is associated with this object..
        /// </summary>
        internal static string NoAssociatedProcess {
            get {
                return ResourceManager.GetString("NoAssociatedProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No async read operation is in progress on the stream..
        /// </summary>
        internal static string NoAsyncOperation {
            get {
                return ResourceManager.GetString("NoAsyncOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process was not started by this object, so requested information cannot be determined..
        /// </summary>
        internal static string NoProcessHandle {
            get {
                return ResourceManager.GetString("NoProcessHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process has exited, so the requested information is not available..
        /// </summary>
        internal static string NoProcessInfo {
            get {
                return ResourceManager.GetString("NoProcessInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Feature is not supported for remote machines..
        /// </summary>
        internal static string NotSupportedRemote {
            get {
                return ResourceManager.GetString("NotSupportedRemote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Feature is not supported for threads on remote computers..
        /// </summary>
        internal static string NotSupportedRemoteThread {
            get {
                return ResourceManager.GetString("NotSupportedRemoteThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An async read operation has already been started on the stream..
        /// </summary>
        internal static string PendingAsyncOperation {
            get {
                return ResourceManager.GetString("PendingAsyncOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AboveNormal and BelowNormal priority classes are not available on this platform..
        /// </summary>
        internal static string PriorityClassNotSupported {
            get {
                return ResourceManager.GetString("PriorityClassNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process performance counter is disabled, so the requested operation cannot be performed..
        /// </summary>
        internal static string ProcessDisabled {
            get {
                return ResourceManager.GetString("ProcessDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process request because the process ({0}) has exited..
        /// </summary>
        internal static string ProcessHasExited {
            get {
                return ResourceManager.GetString("ProcessHasExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process request because the process has exited..
        /// </summary>
        internal static string ProcessHasExitedNoId {
            get {
                return ResourceManager.GetString("ProcessHasExitedNoId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Feature requires a process identifier..
        /// </summary>
        internal static string ProcessIdRequired {
            get {
                return ResourceManager.GetString("ProcessIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thread {0} found, but no process {1} found..
        /// </summary>
        internal static string ProcessNotFound {
            get {
                return ResourceManager.GetString("ProcessNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardErrorEncoding is only supported when standard error is redirected..
        /// </summary>
        internal static string StandardErrorEncodingNotAllowed {
            get {
                return ResourceManager.GetString("StandardErrorEncodingNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StandardOutputEncoding is only supported when standard output is redirected..
        /// </summary>
        internal static string StandardOutputEncodingNotAllowed {
            get {
                return ResourceManager.GetString("StandardOutputEncodingNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request cannot be processed because the thread ({0}) has exited..
        /// </summary>
        internal static string ThreadExited {
            get {
                return ResourceManager.GetString("ThreadExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  UseShellExecute must always be set to false..
        /// </summary>
        internal static string UseShellExecute {
            get {
                return ResourceManager.GetString("UseShellExecute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WaitReason is only available if the ThreadState is Wait..
        /// </summary>
        internal static string WaitReasonUnavailable {
            get {
                return ResourceManager.GetString("WaitReasonUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process must exit before requested information can be determined..
        /// </summary>
        internal static string WaitTillExit {
            get {
                return ResourceManager.GetString("WaitTillExit", resourceCulture);
            }
        }
    }
}
