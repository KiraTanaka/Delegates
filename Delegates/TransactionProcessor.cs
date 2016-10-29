using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class TransactionProcessor<TProcess, TRequest> where TProcess : class
                                                            where TRequest : class
    {
        Func<TRequest, bool> Check;
        Func<TRequest, TProcess> Register;
        Action<TProcess> Save;
        public TransactionProcessor() { }
        public TransactionProcessor(Func<TRequest, bool> check, Func<TRequest, TProcess> register, Action<TProcess> save)
        {
            Check = check;
            Register = register;
            Save = save;
        }
        public TProcess Process(TRequest request)
        {
            if (!(bool)Check?.Invoke(request))
                throw new ArgumentException();
            var result = Register?.Invoke(request);
            Save?.Invoke(result);
            return result;
        }
    }
}
