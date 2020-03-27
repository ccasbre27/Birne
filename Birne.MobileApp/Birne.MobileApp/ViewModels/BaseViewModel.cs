using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Birne.MobileApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public static readonly string CosmosEndpointUrl = "https://birne.documents.azure.com:443/";

        public static readonly string CosmosAuthKey = "pAihnyqfkeRQNjSFx3yz3MrhyXUfnXCOTfeLuajlO49YvTVtwHo80jYIf3DDYwTNO9Ke9pXkizBUlqBeIlYJ9g==";
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


        public BaseViewModel()
        {
        }
    }

}
