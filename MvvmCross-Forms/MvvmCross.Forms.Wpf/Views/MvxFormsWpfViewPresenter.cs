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

namespace MvvmCross.Forms.Wpf.Views
{
    //WPF + Forms
    public class MvxFormsWpfViewPresenter : MvxWpfViewPresenter, IMvxFormsViewPresenter
    {

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

        public virtual bool ClosePlatformViews()
        {
            MvxTrace.Trace($"Closing of native Views in Forms is not supported on Wpf.");
            return false;
        }
    }
}
