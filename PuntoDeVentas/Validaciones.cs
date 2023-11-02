using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    internal class Validaciones
    {
        public string esNum(string num)
        {
            if (Regex.IsMatch(num, @"^\d+$")) {
                return "int";
            }
            else if (Regex.IsMatch(num, @"^\d+.\d+$"))
            {
                return "dec";
            }

            return null;
        }
    }
}
