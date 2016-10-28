using Delegates.DataModelEventArgs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{   
    public class DataModel
    {
        private List<List<int>> table = new List<List<int>>();

        public delegate void PutEventHandler(object sender,DataModelPutEventArgs e);
        public delegate void InsertRowEventHandler(object sender, DataModelInsertRowEventArgs e);
        public delegate void InsertColumnEventHandler(object sender, DataModelInsertColumnEventArgs e);

        public event PutEventHandler OnPut;
        public event InsertRowEventHandler OnInsertRow;
        public event InsertColumnEventHandler OnInsertColumn;
        
        public void Put(int row, int column, int value)
        {
            //помещает значение в соответствующую ячейку
            if (row < table.Count && column < table.First().Count)
            {
                table[row][column] = value;
                OnPut?.Invoke(this, new DataModelPutEventArgs(value, row, column));
            }
            else
                throw new ArgumentException();
        }
        public void InsertRow(int rowIndex)
        {
            if (rowIndex <= table.Count)
            {
                if (rowIndex < table.Count)
                    table.Insert(rowIndex, new List<int>());
                else
                    table.Add(new List<int>());
                OnInsertRow?.Invoke(this, new DataModelInsertRowEventArgs(rowIndex));
            }
            else
                throw new ArgumentException();
            
        }
        public void InsertColumn(int columnIndex)
        {
            if (columnIndex <= table.First().Count)
            {
                foreach (var row in table)
                {
                    if (columnIndex < row.Count)
                        row.Insert(columnIndex, 0);
                    else
                        row.Add(0);                           
                }
                OnInsertColumn?.Invoke(this, new DataModelInsertColumnEventArgs(columnIndex));
            }
            else
                throw new ArgumentException();
        }
        public int Get(int row, int column)
        {
            if (row < table.Count && column < table.First().Count)
                return table[row][column];
            else
                throw new ArgumentException();
        }
        
    }
}
