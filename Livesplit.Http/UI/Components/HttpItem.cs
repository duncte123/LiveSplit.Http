
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livesplit.UI.Components
{
    class HttpItem
    {
    }

    public interface IHttpItem
    {
        string Url { get; }
        string Body { get; }
        List<Dictionary<string, List<string>>> Headers { get; }

        void Call();
    }
}
