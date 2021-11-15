using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Concrete
{
    public class Veri : IBase
    {
        protected Stream _yol;
        public Stream Yol => _yol;
    }
}
