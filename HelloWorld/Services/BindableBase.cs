using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorld.Services
{
    public class BindableBase : INotifyPropertyChanged
    {
        protected BindableBase() { }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChenged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(field, value)) { return false; }

            field = value;

            this.OnPropertyChenged(propertyName);
            return true;
        }
    }
}
