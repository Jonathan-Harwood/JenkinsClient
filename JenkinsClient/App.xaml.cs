namespace JenkinsClient
{
    using System.Windows;
    using Castle.Windsor;
    using Castle.Windsor.Installer;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IWindsorContainer ioc = new WindsorContainer();

        public static IWindsorContainer IOC
        {
            get
            {
                return ioc;
            }

            set
            {
                ioc = value;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            ioc.Install(FromAssembly.This());
        }
    }
}
