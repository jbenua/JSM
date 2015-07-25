using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class SmallSet
    {
        public ulong body;
        public int n;
        public bool this[int i]
        {
            get
            {
                ulong b = 1;
                b <<= i;
                if ((b & body) != 0)
                    return true;
                else
                    return false;
            }
            set
            {
                ulong b = 1;
                b <<= i;
                if (value)
                    body |= b;
            }
        }
        public SmallSet(params int[] indexes)
        {
            body = 0;
            for (int i = 0; i < indexes.Length; i++)
                this[indexes[i]] = true;
        }
        public SmallSet(System.Windows.Forms.DataGridView d)
        {
            if (d.RowCount != 1) return;
            n = d.ColumnCount;
            body = new ulong();
            for (int i = 0; i < d.ColumnCount; i++)
                this[i] = Convert.ToInt32(d[i, 0].Value) == 1 ? true : false;
        }
        public SmallSet(System.Windows.Forms.DataGridView d, int t)
        {
            n = d.ColumnCount;
            body = new ulong();
            for (int i = 0; i < d.ColumnCount; i++)
                this[i] = Convert.ToInt32(d[i, t].Value) == 1 ? true : false;
        }

        public static SmallSet operator +(SmallSet a, SmallSet b)
        {
            SmallSet r = new SmallSet();
            r.body = a.body | b.body;
            return r;
        }
        public static SmallSet operator *(SmallSet a, SmallSet b)
        {
            SmallSet r = new SmallSet();
            r.body = a.body & b.body;
            return r;
        }
        public static SmallSet operator -(SmallSet a, SmallSet b)
        {
            SmallSet r = new SmallSet();
            r.body = a.body &  ~b.body;
            return r;
        }
        public static SmallSet operator -(SmallSet a)
        {
            SmallSet r = new SmallSet();
            r.body = ~a.body;
            return r;
        }
        public static bool operator ==(SmallSet a, SmallSet b)
        {
            return a.body == b.body;
        }
        public static bool operator !=(SmallSet a, SmallSet b)
        {
            return a.body != b.body;
        }
        public bool IsASubSet(SmallSet a, SmallSet b)
        {
            if (a * b == a) return true;
            else return false;
        }
        public static bool operator <=(SmallSet a, SmallSet b)
        {
            return (a * b == a);
        }
        public static bool operator >=(SmallSet a, SmallSet b)
        {
            return (a * b == b);
        }

        public void ToDataGridView(System.Windows.Forms.DataGridView d)
        {
            for (int i = 0; i < n; i++)
                d[i, 0].Value = Convert.ToInt32(this[i]);
        }
        public void ToDataGridView(System.Windows.Forms.DataGridView d, int j)
        {
            for (int i = 0; i < n; i++)
                d[i, j].Value = Convert.ToInt32(this[i]);
        }
        public void ToStringView(String[] st, System.Windows.Forms.Label d)
        {
            String final="";
            for (int i = 0; i < n; i++)
                if (this[i] == true) final += st[i] + " ";
            d.Text = final;
        }
        public string ToString1()
        {
            String final = "";
            for (int i = 0; i < n; i++)
                if (this[i] == true) final += 1 + " ";
                else final += 0 + " ";
            return final;
        }


        public SmallSet compl(SmallSet a)
        {
            SmallSet r = new SmallSet();
            r.n = a.n;
            for (int i = 0; i < a.n; i++)
            {
                if (a[i] == true)
                    r[i] = false;
                else r[i] = true;
            }
            return r;
        }

        public int card_num()
        {
            int count=0;
            for (int i = 0; i < this.n; i++)
                if (this[i] == true)
                    count++;
            return count;
        }
    }





}

