using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;

namespace Altkom.Santander.Arka.MockServices
{
    public class MockFundGroupsService : IFundGroupsService
    {
        private ICollection<FundGroup> entities;

        public MockFundGroupsService()
        {
            entities = new List<FundGroup>
            {
                new FundGroup(1, "Grupa 1"),
                new FundGroup(2, "Grupa 2"),
                new FundGroup(3, "Grupa 3"),
                new FundGroup(4, "Grupa 4"),
            };
        }

        public void Add(FundGroup entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<FundGroup> Get() => entities;

        public FundGroup Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(FundGroup entity)
        {
            throw new NotImplementedException();
        }

        public void Update(FundGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
