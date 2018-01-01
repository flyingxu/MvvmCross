using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Wpf.Platform;
using MvvmCross.Wpf.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Playground.Forms.Wpf
{
    public class Setup : MvxFormsWpfSetup
    {

        public Setup(Dispatcher uiThreadDispatcher, IMvxWpfViewPresenter presenter)
            : base(uiThreadDispatcher, presenter)
        {
        }


        public Setup(Dispatcher uiThreadDispatcher, ContentControl root) : base(uiThreadDispatcher, root)
        {
        }



        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IEnumerable<Assembly> GetViewAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies().Union(new[] { typeof(FormsApp).GetTypeInfo().Assembly }));
        }
    }
}
