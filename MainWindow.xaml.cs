﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace gClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private bool clockWhite;        
        public MainWindow()
        {
            InitializeComponent();
            // 色判定の初期化
            clockWhite = true;
            // タイマー生成
            timer = CreateTimer();
            timer.Start();
        }

        private void Clock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Application.Current.Shutdown();
            if (clockWhite)
            {
                clock.Foreground = new SolidColorBrush(Colors.Black);
                calender.Foreground = new SolidColorBrush(Colors.Black);
                clockWhite = false;
            }
            else
            {
                clock.Foreground = new SolidColorBrush(Colors.White);
                calender.Foreground = new SolidColorBrush(Colors.White);
                clockWhite = true;
            }
        }

        private DispatcherTimer CreateTimer()
        {
            // タイマー生成(優先度はアイドル時に設定)
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);

            // 1000ミリ秒のTick(そんなに正確じゃなくていいっしょ。)
            t.Interval = TimeSpan.FromMilliseconds(1000);

            // タイマーイベントの定義
            t.Tick += (sender, e) => {
                clock.Text = DateTime.Now.ToString("HH:mm:ss");
                calender.Text = DateTime.Now.ToString("yyyy/MM/dd(ddd)");
            };

            // 生成したタイマーを返す
            return t;
        }
    }
}
