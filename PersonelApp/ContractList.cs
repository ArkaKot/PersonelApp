using System.Collections.Generic;

namespace PersonelApp
{
    public class ContractList
    {
        public static List<Contract> GetPersonContractList(string NameContract)
        {
            return new List<Contract>
            {
                new Contract { Id = 0, Name = NameContract },
                new Contract { Id = 1, Name = "Umowa o Dzieło" },
                new Contract { Id = 2, Name = "Umowa zlecenie"},
                new Contract { Id = 3, Name = "Umowa o pracę"}
            };
        }
    }
}

