using System;

#nullable enable

namespace CompactGUI.My
{
    // The following events are available for MyApplication:
    // Startup: Raised when the application starts, before the startup form is created.
    // Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    // UnhandledException: Raised if the application encounters an unhandled exception.
    // StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    // NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    internal partial class MyApplication
    {
        private void AppStart(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssemblies;
        }

        private System.Reflection.Assembly? ResolveAssemblies(object sender, ResolveEventArgs e)
        {
            var desiredAssembly = new System.Reflection.AssemblyName(e.Name);
            if ((desiredAssembly.Name ?? "") == "Ookii.Dialogs")
            {
                return System.Reflection.Assembly.Load(Resources.Resources.Ookii_Dialogs);
            }
            else
            {
                return null;
            }
        }
    }
}