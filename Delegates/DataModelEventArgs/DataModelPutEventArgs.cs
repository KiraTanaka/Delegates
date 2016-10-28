using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DataModelEventArgs
{
    public class DataModelPutEventArgs : EventArgs
    {
        public int ProposedValue { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public DataModelPutEventArgs(int proposedValue, int rowIndex, int columnIndex)
        {
            ProposedValue = proposedValue;
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
        }
    }
}
