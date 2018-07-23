﻿using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.MockServices;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Santander.Arka.ViewModels
{
    public class FundsViewModel
    {
        public ICollection<Fund> Funds { get; set; }

        public Fund SelectedFund { get; set; }

        private IFundsService fundsService;

        public FundsViewModel()
            : this(new MockFundsService())
        {

        }

        public FundsViewModel(IFundsService fundsService)
        {
            this.fundsService = fundsService;

            Funds = this.fundsService.Get();
        }

    }
}