using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Wpf.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Playground.Forms.Wpf
{
    public class Setup : MvxFormsWpfSetup
    {
        public Setup(Dispatcher uiThreadDispatcher, ContentControl root) : base(uiThreadDispatcher, root)
        {
        }



        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
