using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamFormsNativePages;
using XamFormsNativePages.iOS;

[assembly: ExportRenderer(typeof(MainPage), typeof(MainPageRenderer))]
namespace XamFormsNativePages.iOS
{
    public partial class MainPageRenderer : PageRenderer
    {
        private MainPage Page
        {
            get { return Element as MainPage; }
        }


        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var oldPage = e.OldElement as MainPage;
            if(oldPage != null)
            {
                oldPage.PropertyChanged -= OnPagePropertyChanged;
            }

            var newPage = e.NewElement as MainPage;
            if (newPage != null)
            {
                newPage.PropertyChanged += OnPagePropertyChanged;
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UpdateButtonText();
        }

        private void OnPagePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == MainPage.RandomNumberProperty.PropertyName)
            {
                UpdateButtonText();
            }
        }

        private void UpdateButtonText()
        {
            if(IsViewLoaded && Page != null)
            {
                button.SetTitle(Page.RandomNumber.ToString(), UIControlState.Normal);
            }
        }

        partial void ButtonPressed(UIButton sender)
        {
            if(Page != null)
            {
                Page.OnButtonPressed();
            }
        }

        public MainPageRenderer()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }
    }
}