using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Views;
using MvvmCross.Forms.Wpf.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using System;
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
using Xamarin.Forms.Platform.WPF;

namespace Playground.Forms.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Xamarin.Forms.Forms.Init();

            var iocProvider = MvxSimpleIoCContainer.Initialize();
            Mvx.RegisterSingleton(iocProvider);

            var presenter = new MvxFormsWpfViewPresenter(this);
            Mvx.RegisterSingleton<IMvxFormsViewPresenter>(presenter);
            var setup = new Setup(Dispatcher, presenter);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();


            LoadApplication(new FormsApp());  

        }

        protected override void Appearing()
        {
            base.Appearing();
            ;
        }

        private void FormsApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
