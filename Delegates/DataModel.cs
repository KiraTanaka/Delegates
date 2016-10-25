using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void EventHandler();
    public class DataModel
    {
        public event EventHandler OnPut;
        public event EventHandler OnInsertRow;
        public event EventHandler OnInsertColumn;

        public void Put(int row, int column, int value)
        {
            OnPut?.Invoke();
        }
        public void InsertRow(int rowIndex)
        {
            OnInsertRow?.Invoke();
        }
        public void InsertColumn(int columnIndex)
        {
            OnInsertColumn?.Invoke();
        }
        public int Get(int row, int column)
        {
            return 0;
        }
        
    }
}
