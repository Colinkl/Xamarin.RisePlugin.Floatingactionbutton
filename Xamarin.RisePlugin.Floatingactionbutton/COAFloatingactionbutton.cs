﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.RisePlugin.Floatingactionbutton
{
    public class COAFloatingactionbutton : INotifyPropertyChanged
    {

        public static IFloatActionButton Current
        {
            get
            {
                var ret = DependencyService.Get<IFloatActionButton>();
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("Error");
    }
}
