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
using FourRectangle;

namespace FourRectangle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawFourRectangles(foxDraw);
        }

        public static void DrawFourRectangles(FoxDraw foxDraw)
        {
            for (int i = 1; i < 5; i++)
            {
                foxDraw.DrawRectangle(20*i*i, 17*i*i, 30*i, 10*i);
            }
        }
    }
}
