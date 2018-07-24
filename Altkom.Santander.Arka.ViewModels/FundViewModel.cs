using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.MockServices;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.ViewModels
{
    public class FundViewModel : BaseViewModel
    {
        public Fund Fund { get; set; }

        private readonly IFundsService fundsService;

        public FundViewModel()
            : this(new MockFundsService())
        {

        }

        public FundViewModel(IFundsService fundsService)
        {
            this.fundsService = fundsService;

            Load();
        }

        public void Load()
        {
            Fund = fundsService.Get(1);
        }
    }
}
