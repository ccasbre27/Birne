using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Birne.Core
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected internal void RaiseAndSetIfChanged<T>(ref T backingField, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (!(backingField?.Equals(newValue) ?? false) && !string.IsNullOrWhiteSpace(propertyName))
            {
                backingField = newValue;
                NotifyChanges(propertyName);
            }
        }

        protected internal void NotifyChanges([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
