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
using Esri.ArcGISRuntime.UI;
using EsriDe.RuntimeExplorer.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace EsriDe.RuntimeExplorer.Controls
{
    /// <summary>
    /// Interaction logic for MapContentControl.xaml
    /// </summary>
    public partial class MapContentControl : UserControl
    {
        public MapContentControl()
        {
            InitializeComponent();
        }

        private void GeoView_OnDrawStatusChanged(object sender, DrawStatusChangedEventArgs e)
        {
            // TODO: Accessing the ServiceLocator here is not good practice..
            var mainViewModel = ServiceLocator.Current.GetInstance<MainViewModel>();
            mainViewModel.AppStatus = e.Status.ToString();
        }
    }
}