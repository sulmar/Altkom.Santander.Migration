﻿namespace Altkom.Santander.Arka.Models
{
    public class FundGroup : Base
    {
        public FundGroup(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }


        protected FundGroup()
        {

        }
    }


}
