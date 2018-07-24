using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.WinFormsClient.Views
{
    // Add-reference System.Windows.Forms.Integration.ElementHost
    // Add-rererence PresentationCore
    // Add-reference PresentationFramework
    //public class WPFFundsView : ElementHost
    //{
    //    private WPFViews.FundsView view = new WPFViews.FundsView();

    //    public WPFFundsView()
    //    {
    //        base.Child = new WPFViews.FundsView();

    //    }
    //}

    public class WPFFundsView : ElementHost<WPFViews.FundsView>
    {

    }
}
