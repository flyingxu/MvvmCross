using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AppKit;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.iOS;
using MvvmCross.Mac.Platform;
using MvvmCross.Platform.Platform;

namespace Playground.Forms.Mac
{
    public class Setup : MvxFormsMacSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, NSWindow window)
            : base(applicationDelegate, window)
        {
        }

        protected override MvvmCross.Forms.Platform.MvxFormsApplication CreateFormsApplication()
        {
            return new FormsApp();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IEnumerable<Assembly> GetViewAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies().Union(new[] { typeof(FormsApp).GetTypeInfo().Assembly }));
        }
    }
}
