using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MonoGame.Wpf
{
    public class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        ///     Make main window class as Prism shell
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }

        /// <summary>
        ///     Set the application's window to the current shell and display it
        /// </summary>
        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
