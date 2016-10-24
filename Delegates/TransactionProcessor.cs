using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public abstract class TransactionProcessor
    {
        Func<TransactionRequest, bool> Check;
        Func<TransactionRequest, Transaction> Register;
        Action<Transaction> Save;
        public Transaction Process(TransactionRequest request)
        {
            if (!Check(request))
                throw new ArgumentException();
            var result = Register(request);
            Save(result);
            return result;
        }
    }
}
