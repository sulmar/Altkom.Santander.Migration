using Altkom.Santander.Arka.IServices;
using Altkom.Santander.Arka.MockServices;
using Altkom.Santander.Arka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Altkom.Santander.Arka.ViewModels
{
    public class FundsViewModel : BaseViewModel
    {
        public ICollection<Fund> Funds { get; set; }

        public Fund SelectedFund { get; set; }

        private IFundsService fundsService;


        public bool IsBusy { get; set; }

        public FundsViewModel()
            : this(new MockFundsService())
        {

        }

        public FundsViewModel(IFundsService fundsService)
        {
            this.fundsService = fundsService;

            Load();

            CalculateCommand = new RelayCommand(p => Calculate(p), p => CanCalculate);

            IsBusy = true;
        }

        public void Load()
        {
            Funds = this.fundsService.Get();
        }

        public bool IsSelected => SelectedFund != null;


        public ICommand CalculateCommand { get; set; } 

        public void Calculate(object arg)
        {
            Console.WriteLine($"Calculating... {SelectedFund.Name}");
        }


        public bool CanCalculate => IsSelected && SelectedFund.Id > 20;

        

    }
}
