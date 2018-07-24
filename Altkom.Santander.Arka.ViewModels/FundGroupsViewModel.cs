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
    public class FundGroupsViewModel
    {
        public ICollection<FundGroup> FundGroups { get; set; }

        private readonly IFundGroupsService fundGroupsService;


        public FundGroupsViewModel()
            : this(new MockFundGroupsService())
        {

        }

        public FundGroupsViewModel(IFundGroupsService fundGroupsService)
        {
            this.fundGroupsService = fundGroupsService;

            FundGroups = this.fundGroupsService.Get();
        }
    }
}
