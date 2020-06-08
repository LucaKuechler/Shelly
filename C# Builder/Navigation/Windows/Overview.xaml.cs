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
using System.Windows.Shapes;
using SourceWeave.Controls;


namespace Shelly
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Overview : SWWindow
    {
        Storage Store;

        public Overview()
        {
            InitializeComponent();

            Store = new Storage(this);

            this.DataContext = new OverviewData(Store);
        }
    }
}
