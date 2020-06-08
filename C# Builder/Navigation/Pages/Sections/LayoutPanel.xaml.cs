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

namespace Shelly
{
    /// <summary>
    /// Interaktionslogik für LayoutPanel
    /// </summary>
    public partial class LayoutPanel : Page
    {
        public LayoutPanel(Storage Store)
        {
            InitializeComponent();
            this.DataContext = Store.DataBinding;
        }

    }
}
