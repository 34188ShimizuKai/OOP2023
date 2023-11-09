using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //メートル単位を表すクラス
    public class MetricUnit : WeightUnit{
        private static List<MetricUnit> units = new List<MetricUnit>
        {
             new MetricUnit{Name="g",Coefficient= 1},
             new MetricUnit{Name="kg",Coefficient=1000}
        };
        public static ICollection<MetricUnit> Units { get{ return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns>変換値</returns>

        public double FromImperialUnit(ImperialUnit unit,double value) {
            return (value * unit.Coefficient) * 28.35 / this.Coefficient;
        }
    }
}
