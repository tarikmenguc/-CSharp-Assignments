using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum EmployeeRole
    {
        Manager,
        Developer,
        Designer,
        Tester
    }
    public class CalisanRolleriVeMaasHesaplama
    {
        public decimal CalculateSalary(EmployeeRole role)
        {
            switch (role)
            {
                case EmployeeRole.Manager:
                    return 5000m; // Manager maaşı 5000
                case EmployeeRole.Developer:
                    return 4000m; // Developer maaşı 4000
                case EmployeeRole.Designer:
                    return 3500m; // Designer maaşı 3500
                case EmployeeRole.Tester:
                    return 3000m; // Tester maaşı 3000
                default:
                    return 0m; // Bilinmeyen rol için maaş 0
            }
        }
    }
}
