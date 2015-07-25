using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class Context
    {
        private int m;
        public List<SmallSet> body;
        public List<string> unAtr;
        public List<string> unObj;

        public int RowCount
        {
            get
            {
                return m;
            }
            set
            {
                m=value;
            }
        }
   
        public SmallSet this[int i]
        {
            get
            {
                return body[i];
            }
            set
            {
                if (body.Count < i+1)
                {
                    SmallSet a = new SmallSet();
                    a = value;
                    body.Add(a);
                }
                else body[i] = value;
            }
        }

        public Context (int m)
        {
            this.RowCount = m;
            this.body = new List<SmallSet>();
        }

        public List<SmallSet> ColumnsToSets()
        {
            int n=this[0].n;
            List<SmallSet> a=new List<SmallSet>();
            for (int j = 0; j < n; j++)
            {
                SmallSet temp = new SmallSet();
                temp.n = m;
                for (int i = 0; i < m; i++)
                    temp[i] = this[i][j];
                a.Add(temp);
            }
            return a;
        }

        public Context(System.Windows.Forms.DataGridView d, System.Windows.Forms.DataGridView obj, System.Windows.Forms.DataGridView atr)
        {
            m = d.RowCount;
            int n = d.ColumnCount;
            this.body = new List<SmallSet>();
            for (int i = 0; i < m; i++)
                this[i] = new SmallSet(d, i);
            unObj = new List<string>();
            unAtr = new List<string>();
            for (int i = 0; i < obj.RowCount; i++)
                unAtr.Add(Convert.ToString(obj[0, i].Value));
            
            for (int i = 0; i < atr.ColumnCount; i++)
                unObj.Add(Convert.ToString(atr[i, 0].Value));
        }

        public void toDataGridView(System.Windows.Forms.DataGridView d, System.Windows.Forms.DataGridView atr)
        {
            d.RowCount = body.Count;
            atr.RowCount=unAtr.Count;
            for (int i = 0; i < body.Count; i++)
            {
                body[i].ToDataGridView(d, i);
            }
            for (int i = 0; i < unAtr.Count; i++)
                atr[0, i].Value = unAtr[i];
            
        }
    }
}
