using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Cinema
    {
        private DateTime data;
        public Cinema(DateTime data) {
            this.data = data;
        }
        public void SetDia(DateTime data) {
            this.data = data;
        }
        public double GetInteira() {
            double p = 20;
            switch(data.DayOfWeek) {
                case DayOfWeek.Wednesday: return 8;
                case DayOfWeek.Monday :
                case DayOfWeek.Tuesday :
                case DayOfWeek.Thursday : p = 16; break;
            }
            if (data.Hour >= 17) p *= 1.5;
            return p;
        }
        public double GetMeiaEntrada() {
            if (data.DayOfWeek == DayOfWeek.Wednesday) return 8;
            return GetInteira() / 2;
        }
        public override string ToString() {
            return $"{data:dddd} {data:HH:mm}";
        }
    }
}
