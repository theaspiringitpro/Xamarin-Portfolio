using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace FormsMenu
{
    public class StopWatchApp : ContentPage
    {
        private readonly Stopwatch _sw = new Stopwatch();
        //View
        public StopWatchApp()
        {
            //  Labels
            var heading = new Label
            {
                Text = "StopWatch App",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 50,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic
            };

            var timer = new Label
            {
                FontSize = 60,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };

            //  Buttons
            var startButton = new Button
            {
                Text = "Start",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Button)),
                BorderWidth = 1
            };

            var stopButton = new Button
            {
                Text = "Stop",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Button)),
                BorderWidth = 1
            };

            var resetButton = new Button
            {
                Text = "Reset",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Button)),
                BorderWidth = 1
            };

            //  Button Event Handlers
            startButton.Clicked += (sender, args) => { _sw.Start(); };

            stopButton.Clicked += (sender, args) => { _sw.Stop(); };

            resetButton.Clicked += (sender, args) => { _sw.Reset(); };

            //  Time Initializer
            {
                Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
                {
                    var ts = _sw.Elapsed;

                    //  Format timer Value
                    timer.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds/10);
                    return true;
                }
                    );

                //  Button Layout
                var buttonLayout = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        startButton,
                        stopButton,
                        resetButton
                    }
                };

                //  Load Content
                var appLayout = new StackLayout
                {
                    Children =
                    {
                        heading,
                        timer,
                        buttonLayout
                    }
                };

                Content = appLayout;
            }
        }
    }
}