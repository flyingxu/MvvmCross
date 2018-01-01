using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Forms.Bindings;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvxWpfBindingBuilder = MvvmCross.Binding.Wpf.MvxWindowsBindingBuilder;

namespace MvvmCross.Forms.Wpf.Bindings
{
    public class MvxFormsWpfBindingBuilder : MvxWpfBindingBuilder
    {

        public MvxFormsWpfBindingBuilder()
        {
        }

        protected override IMvxTargetBindingFactoryRegistry CreateTargetBindingRegistry()
        {
            return new MvxFormsTargetBindingFactoryRegistry();
        }

        public override void DoRegistration()
        {
            base.DoRegistration();
            InitializeBindingCreator();
        }

        private void InitializeBindingCreator()
        {
            var creator = CreateBindingCreator();
            Mvx.RegisterSingleton(creator);
        }

        protected new virtual Forms.Bindings.IMvxBindingCreator CreateBindingCreator()
        {
            return new MvxFormsBindingCreator();
        }
    }
}
