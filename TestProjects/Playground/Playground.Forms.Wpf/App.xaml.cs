using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Wpf.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Playground.Forms.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        bool _setup = false;

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if (!_setup)
            {
                _setup = true;

            




            }
        }
    }
}
