using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DataModelEventArgs
{
    public class DataModelInsertRowEventArgs : EventArgs
    {
        public int RowIndex { get; set; }
        public DataModelInsertRowEventArgs(int rowIndex)
        {
            RowIndex = rowIndex;
        }

    }
}
