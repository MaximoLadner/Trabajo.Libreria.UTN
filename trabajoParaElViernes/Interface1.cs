using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoParaElViernes
{
    interface Interface1<t> where t : class
    {
        void AgregarLibro(t objeto);
    }
}
