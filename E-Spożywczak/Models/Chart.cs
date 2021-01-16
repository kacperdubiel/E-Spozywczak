using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class Chart
    {
        public int ChartId;
        ICollection<ProductInChart> ProductsInChartList;
    }
}
