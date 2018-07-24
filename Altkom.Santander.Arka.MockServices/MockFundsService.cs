using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.Santander.Arka.MockServices
{
    public class MockFundsService : IFundsService
    {
        private ICollection<Fund> entities;

        public MockFundsService()
        {
            entities = Enumerable.Range(0, 30)
                .Select(index => new Fund(index, $"Fund{index}", $"Fundusz {index}", $"FN{index}", null))
                .ToList();

            // $"Fund{index}" -> String.Format("Fund{0}", index) 
        }

        public void Add(Fund entity) => entities.Add(entity);

        public ICollection<Fund> Get() => entities;

        public Fund Get(int id) => entities.SingleOrDefault(e => e.Id == id);

        public void Remove(Fund entity) => entities.Remove(entity);

        public void Update(Fund entity)
        {
            throw new NotImplementedException();
        }
    }
}
