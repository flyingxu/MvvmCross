using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Platform;
using MvvmCross.Forms.Wpf.Bindings;
using MvvmCross.Wpf.Platform;
using MvvmCross.Wpf.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

        protected MvxFormsWpfSetup(Dispatcher uiThreadDispatcher, ContentControl root)
            : base(uiThreadDispatcher, root)
        {

        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            MvxFormsSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);
        }

        protected override void FillBindingNames(Binding.BindingContext.IMvxBindingNameRegistry registry)
        {
            MvxFormsSetupHelper.FillBindingNames(registry);
            base.FillBindingNames(registry);
        }

        protected override MvxBindingBuilder CreateBindingBuilder() => new MvxFormsWpfBindingBuilder();

    }
}
