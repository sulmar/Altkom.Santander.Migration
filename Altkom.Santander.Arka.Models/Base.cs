using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Altkom.Santander.Arka.Models
{
    // Polecam
    // Install-Package PropertyChanged.Fody
    // https://github.com/Fody/PropertyChanged

    public class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
