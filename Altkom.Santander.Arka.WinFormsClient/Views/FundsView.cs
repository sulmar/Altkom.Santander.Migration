using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.MockServices;

namespace Altkom.Santander.Arka.WinFormsClient.Views
{
    public partial class FundsView : UserControl
    {
        private IFundsService fundsService;

        public FundsView(IFundsService fundsService)
        {
            this.fundsService = fundsService;
        }

        public FundsView()
            : this(new MockFundsService())
        {
            InitializeComponent();

            fundBindingSource.DataSource = fundsService.Get();
        }
    }
}
