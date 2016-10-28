using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class TransactionProcessor
    {
        public Func<IRequest, bool> Check;
        public Func<IRequest, IAction> Register;
        public Action<IAction> Save;
        public IAction Process(IRequest request)
        {
            if (!(bool)Check?.Invoke(request))
                throw new ArgumentException();
            var result = Register?.Invoke(request);
            Save?.Invoke(result);
            return result;
        }
    }
}
