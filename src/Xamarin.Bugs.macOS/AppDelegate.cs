﻿using AppKit;
using Foundation;
using Xamarin.Forms.Platform.MacOS;

namespace Xamarin.Bugs.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        NSWindow window;
        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

            var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            window.Title = "Xamarin.Forms on Mac!";
            window.TitleVisibility = NSWindowTitleVisibility.Hidden;
            window.AcceptsMouseMovedEvents = true;
            window.AllowsToolTipsWhenApplicationIsInactive = true;
            window.Autodisplay = true;
            window.IsOpaque = true;
        }

        public override NSWindow MainWindow
        {
            get { return window; }
        }


        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Forms.Init();
            LoadApplication(new App());

            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
