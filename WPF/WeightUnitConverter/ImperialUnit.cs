using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class ImperialUnit : WeightUnit{
        private static List<ImperialUnit> units = new List<ImperialUnit>
        {
             new ImperialUnit{Name="lb",Coefficient=16},
             new ImperialUnit{Name="oz",Coefficient=1},
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>

        public double FromMetricUnit(MetricUnit unit, double value) {
            return (value * unit.Coefficient) / 28.35 / this.Coefficient;
        }
    }
}
