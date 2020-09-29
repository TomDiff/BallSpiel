﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace BallSpiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _animantionsTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            _animantionsTimer.Interval = TimeSpan.FromMilliseconds(50);
            _animantionsTimer.Tick += PositioniereBall;
        }

        private void PositioniereBall(object sender, EventArgs e)
        {
            var x = Canvas.GetLeft(Ball);
            Canvas.SetLeft(Ball, x + 5);
        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (_animantionsTimer.IsEnabled)
            {
                _animantionsTimer.Stop();
            }
            else
            {
                _animantionsTimer.Start();
            }
        }
    }
}
