using AVFoundation;
using AVKit;
using Foundation;
using System;
using UIKit;

namespace videotest
{
    public partial class ViewController : UIViewController
    {
        AVPlayer avplayer;
        AVPlayerLayer avplayerLayer;
        AVAsset avasset;
        AVPlayerItem avplayerItem;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //avasset = AVAsset.FromUrl(NSUrl.FromFilename("Introduction.mp4"));
            //avplayerItem = new AVPlayerItem(avasset);
            avplayer = new AVPlayer(avplayerItem);
           

            var avplayerController = new AVPlayerViewController();
            avplayerController.Player = avplayer;

            avplayerController.ShowsPlaybackControls = true;

            AddChildViewController(avplayerController);
            View.AddSubview(avplayerController.View);
            avplayerController.View.Frame = this.View.Frame;

            avplayer.Play();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}