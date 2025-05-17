using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AlreadyFavoriteException(string message) : Exception(message)
    {
    }
}
