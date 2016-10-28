using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DataModelEventArgs
{
    public class DataModelInsertColumnEventArgs : EventArgs
    {
        public int ColumnIndex { get; set; }
        public DataModelInsertColumnEventArgs(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }
    }
}
