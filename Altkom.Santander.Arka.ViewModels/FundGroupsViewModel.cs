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

    public class EntitiesViewModel<TEntity>
        where TEntity : Base
    {
        public ICollection<TEntity> Entities { get; set; }

        public TEntity SelectedEntity { get; set; }

        private readonly IEntitiesService<TEntity> entitiesService;


        public EntitiesViewModel(IEntitiesService<TEntity> entitiesService)
        {
            this.entitiesService = entitiesService;
        }

        public void Load()
        {
            Entities = entitiesService.Get();
        }
    }


    public class FundGroups2ViewModel : EntitiesViewModel<FundGroup>
    {
        public FundGroups2ViewModel(IEntitiesService<FundGroup> entitiesService) : base(entitiesService)
        {
        }
    }

    public class FundGroupsViewModel : BaseViewModel
    {
        public ICollection<FundGroup> FundGroups { get; set; }

        public FundGroup SelectedFundGroup { get; set; }

        private readonly IFundGroupsService fundGroupsService;


        public FundGroupsViewModel()
            : this(new MockFundGroupsService())
        {

        }

        public FundGroupsViewModel(IFundGroupsService fundGroupsService)
        {
            this.fundGroupsService = fundGroupsService;

            Load();
        }

        public void Load()
        {
            FundGroups = this.fundGroupsService.Get();
        }
    }
}
