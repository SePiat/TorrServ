using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TorrServCore
{
    public interface ILemmatization
    {
        Dictionary<string, int> GetDictFromLemms(string text);
    }
}
