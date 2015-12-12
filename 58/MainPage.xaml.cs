using _58.HouseProperty;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace _58
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //启动一个timer，在设定的时间后跳转到首页
            DispatcherTimer navTimer = new DispatcherTimer();
            navTimer.Tick += NavTimer_Tick;
            navTimer.Interval = new TimeSpan(0,0,5);
            navTimer.Start();
        }

        private int i = 0;
        private void NavTimer_Tick(object sender, object e)
        {
            if (i == 1)
            {
                DispatcherTimer timer = (DispatcherTimer)sender;
                timer.Stop();
                this.Frame.Navigate(typeof(HouseIndex));
            }
            i++;
        }
    }
}
