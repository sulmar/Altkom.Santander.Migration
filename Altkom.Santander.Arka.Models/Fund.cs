using System;

namespace Altkom.Santander.Arka.Models
{
    public class Fund : Base
    {
        private string _name;

        public Fund(int id, string name, string fullName, string code, FundGroup group)
        {
            Id = id;
            Name = name;
            FullName = fullName;
            Code = code;
            Group = group;
        }

        public int Id { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;

                OnPropertyChanged(nameof(Name));
            }
        }
        public string FullName { get; set; }
        public string Code { get; set; }


        public int FundGroupId { get; set; }
        public FundGroup Group { get; set; }

    }


}
