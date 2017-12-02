using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Прогр2
{
    //7
    class AquOverflowException:Exception
    {
        public AquOverflowException() : base("В аквариуме нет мест") { }
    }
    //7
}
