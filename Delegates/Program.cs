using Delegates.DataModelEventArgs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class observer
    {
        public void Change(object sender, DataModelPutEventArgs e)
        {
            Console.WriteLine(e.ProposedValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataModel model = new DataModel();
            observer ob = new observer();
            model.OnPut += ob.Change;
            model.InsertRow(0);
            model.InsertColumn(0);
            model.InsertColumn(1);
            model.Put(0,1,4);
            Console.ReadLine();
        }
    }
}
