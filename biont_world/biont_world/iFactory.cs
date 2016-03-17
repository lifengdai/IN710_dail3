using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biont_world
{
    public interface iFactory
    {
        Biont create(int code);
    }
}
