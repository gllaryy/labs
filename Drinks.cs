using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Drinks : MenuItem
    {
        public int VolumeMl { get; private set; }
        public bool IsAlcoholic { get; private set; }

        public Drinks(string name, decimal price, int volume, bool isAlcoholic)
            : base (name, price)
        {
            VolumeMl = volume;
            IsAlcoholic = isAlcoholic;
        }

        public override string GetInfo()
        {
            string alc;
            if (IsAlcoholic==true)
            {
                alc = "алк.";
            }
            else
            {
                alc = "без алк.";
            }

            return $"{Name} ({VolumeMl} мл, {alc}) -- {Price} грн";
        }
    }
}
