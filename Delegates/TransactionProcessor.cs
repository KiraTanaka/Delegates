using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public abstract class TransactionProcessor<Request,Action>
    {
        Func<Request, bool> Check;
        Func<Request, Action> Register;
        Action<Action> Save;
        public Action Process(Request request)
        {
            if (!Check(request))
                throw new ArgumentException();
            var result = Register(request);
            Save(result);
            return result;
        }
    }
}
