using System.Collections.Generic;

namespace PersonelApp
{
    public class EmploymentStatusList
    {
        public static List<EmploymentStatus>  GetPersonEmploymentStatusList(string defaultName )
        {
            return new List<EmploymentStatus>
            {
                new EmploymentStatus { Id = 0, Name = defaultName },
                new EmploymentStatus { Id = 1, Name = "Zatrudniony/a" },
                new EmploymentStatus { Id = 2, Name = "Zwolniony/a" }
            };
        }
    }
}
