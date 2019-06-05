using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame.Wpf.ViewModels
{
    public class ViewModelBase : BindableBase, IDisposable
    {

        protected ViewModelBase() { }

        //-------------------------------------------------------------
        //  IDisposible Implementation
        //-------------------------------------------------------------
        public void Dispose() { OnDispose(); }
        protected virtual void OnDispose() { }
    }
}
