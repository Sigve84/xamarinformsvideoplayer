using System;
using AVFoundation;
using AVKit;
using UIKit;
using videotest.VideoLibrary;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


using System.ComponentModel;
using System.IO;
using CoreMedia;
using Foundation;


[assembly: ExportRenderer(typeof(VideoPlayer),typeof(videotest.iOS.Renderers.VideoPlayerRenderer))]
namespace videotest.iOS.Renderers
{
  
    public class VideoPlayerRenderer : ViewRenderer<VideoPlayer, UIView>
    {
        AVPlayer _player;
        AVPlayerItem _playerItem;
        AVPlayerViewController _playerViewController;
        VideoPlayer _videoPlayer;

        public override UIViewController ViewController => _playerViewController;

        public VideoPlayerRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<VideoPlayer> e)
        {

            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    // Create AVPlayerViewController
                    _playerViewController = new AVPlayerViewController
                    {
                        //ExitsFullScreenWhenPlaybackEnds = true
                    };
                    // Set Player property to AVPlayer
                    _player = new AVPlayer();
                    _playerViewController.Player = _player;

                    // Use the View from the controller as the native control
                    SetNativeControl(_playerViewController.View);
                }

                _videoPlayer = e.NewElement;
            }

            if (e.OldElement != null)
            {
                
            }
        }
    }
}
