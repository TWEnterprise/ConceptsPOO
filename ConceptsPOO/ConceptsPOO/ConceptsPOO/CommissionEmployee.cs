using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee: Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sale { get; set; }

        public override decimal GetValueToPay()
        {
            return Sale * (decimal)CommissionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission percentaje:{$"{CommissionPercentaje:P2}", 18}" +
                $"\n\tSales................:{$"{Sale:C2}", 18}" +
                $"\n\tValue to pay.........:{$"{GetValueToPay():C2}", 18}";
        }
    }
}
