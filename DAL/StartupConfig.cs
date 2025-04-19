using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StartupConfig
    {
        public CultureInfo Culture { get; set; } = new CultureInfo("en");
        public TournamentType Tournament { get; set; } = TournamentType.Men;
    }
}
