using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Platform;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MvvmCross.Forms.Wpf.Platform
{
    public abstract class MvxFormsWpfSetup : MvxWpfSetup
    {
        private MvxFormsApplication _formsApplication;


        protected MvxFormsWpfSetup(Dispatcher uiThreadDispatcher, IMvxWpfViewPresenter presenter)
            : base(uiThreadDispatcher, presenter)
        {
        }
    }
}
