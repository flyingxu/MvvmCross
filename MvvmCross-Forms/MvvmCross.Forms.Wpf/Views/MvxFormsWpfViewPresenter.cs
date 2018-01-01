using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Platform;
using MvvmCross.Forms.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using MvvmCross.Wpf.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MvvmCross.Forms.Wpf.Views
{
    //WPF + Forms
    public class MvxFormsWpfViewPresenter : MvxWpfViewPresenter, IMvxFormsViewPresenter
    {
        public MvxFormsWpfViewPresenter(ContentControl mainWindow, MvxFormsApplication formsApplication)
            : base (mainWindow)
        {
            FormsApplication = formsApplication ?? throw new ArgumentNullException(nameof(formsApplication), "MvxFormsApplication cannot be null");
        }

        private MvxFormsApplication _formsApplication;
        public MvxFormsApplication FormsApplication
        {
            get { return _formsApplication; }
            set { _formsApplication = value; }
        }

        private IMvxFormsPagePresenter _formsPagePresenter;
        public virtual IMvxFormsPagePresenter FormsPagePresenter
        {
            get
            {
                if (_formsPagePresenter == null)
                {
                    _formsPagePresenter = new MvxFormsPagePresenter(FormsApplication, ViewsContainer, ViewModelTypeFinder, attributeTypesToActionsDictionary: AttributeTypesToActionsDictionary);
                    _formsPagePresenter.ClosePlatformViews = ClosePlatformViews;
                    Mvx.RegisterSingleton(_formsPagePresenter);
                }
                return _formsPagePresenter;
            }
            set
            {
                _formsPagePresenter = value;
            }
        }

        public override void RegisterAttributeTypes()
        {
            base.RegisterAttributeTypes();

            FormsPagePresenter.RegisterAttributeTypes();
        }

        public override void ChangePresentation(MvxPresentationHint hint)
        {
            FormsPagePresenter.ChangePresentation(hint);
        }

        public override MvxBasePresentationAttribute CreatePresentationAttribute(Type viewModelType, Type viewType)
        {
            var presentationAttribute = FormsPagePresenter.CreatePresentationAttribute(viewModelType, viewType);
            return presentationAttribute ?? base.CreatePresentationAttribute(viewModelType, viewType);
        }

        public virtual bool ClosePlatformViews()
        {
            MvxTrace.Trace($"Closing of native Views in Forms is not supported on Wpf.");
            return false;
        }

        public override void Show(MvxViewModelRequest request)
        {
            FormsPagePresenter.Show(request);
        }

        public override void Close(IMvxViewModel viewModel)
        {
            FormsPagePresenter.Close(viewModel);
        }
    }
}
