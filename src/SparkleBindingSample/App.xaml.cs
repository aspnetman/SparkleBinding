using System;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using SparkleBindingSample.Configuration.DI;

namespace SparkleBindingSample
{
    public partial class App : Application
    {
        public App(Action<IServiceCollection> addPlatformServices)
        {
            InitializeComponent();

            ServiceProvider = ServiceCollectionFactory.SetupServices(addPlatformServices);

            this.MainPage = new MainPage();
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}