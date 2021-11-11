using AppKit;
using CoreGraphics;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;
using SparkleBindingSample;

namespace SparkleBindingSample.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        private readonly NSWindow window;

        public AppDelegate()
        {
            this.window = new NSWindow(new CGRect(100, 100, 1024, 768), NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled, NSBackingStore.Buffered, false)
            {
                Title = "Test window",
                TitleVisibility = NSWindowTitleVisibility.Hidden
            };
        }

        public override NSWindow MainWindow => this.window;

        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();

            this.LoadApplication(new App(Configuration.DI.ServiceCollectionFactory.AddServices));

            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
