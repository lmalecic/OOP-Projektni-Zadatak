using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository
    {
        public StartupConfig LoadConfig();
        public void SaveConfig(StartupConfig config);
    }
}
