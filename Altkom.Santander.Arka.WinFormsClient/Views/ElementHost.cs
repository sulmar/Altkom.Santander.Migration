using System.Windows.Forms.Integration;

namespace Altkom.Santander.Arka.WinFormsClient.Views
{
    public class ElementHost<T> : ElementHost
        where T : System.Windows.UIElement, new()
    {
        private T view = new T();

        public ElementHost()
        {
            base.Child = view;
        }
    }
}
