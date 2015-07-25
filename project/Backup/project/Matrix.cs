using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class Matrix
    {
        private int m;
        private int n;
        private double [,] body;

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
        public int ColCount
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        public double this[int i, int j]
        {
            get
            {
                return body[i, j];
            }
            set
            {
                body[i, j] = value;
            }
        }

        public Matrix(int m, int n)
        {
            this.RowCount = m;
            this.ColCount = n;
            this.body = new double[m, n];
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.RowCount != b.RowCount || a.ColCount != b.ColCount)
            {
                System.Windows.Forms.MessageBox.Show("WrOng sizEs!!1!11!");
                return a;
            }
            Matrix c = new Matrix(a.RowCount, a.ColCount);
            for (int i = 0; i < a.RowCount; i++)
                for (int j = 0; j < a.ColCount; j++)
                    c[i, j] = a[i, j] + b[i, j];
            return c;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.RowCount != b.RowCount || a.ColCount != b.ColCount)
            {
                System.Windows.Forms.MessageBox.Show("WrOng sizEs!!1!11!");
                return a;
            }
            Matrix c = new Matrix(a.RowCount, a.ColCount);
            for (int i = 0; i < a.RowCount; i++)
                for (int j = 0; j < a.ColCount; j++)
                    c[i, j] = a[i, j] - b[i, j];
            return c;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.ColCount != b.RowCount)
            {
                System.Windows.Forms.MessageBox.Show("WrOng sizEs!!1!11!");
                return a;
            }
            Matrix c = new Matrix(a.RowCount, b.ColCount);
            double n = 0;
            for (int i = 0; i < a.RowCount; i++)
            {
                for (int j = 0; j < b.ColCount; j++)
                {
                    n = 0;
                    for (int k = 0; k < a.ColCount; k++)
                        n = n + a[i, k] * b[k, j];
                    c[i, j] = n;
                }
            }
            return c;
        }

        public Matrix(System.Windows.Forms.DataGridView d)
        {
            this.RowCount = d.RowCount;
            this.ColCount = d.ColumnCount;
            this.body = new double[d.RowCount, d.ColumnCount];
            for (int i = 0; i < this.RowCount; i++)
                for (int j = 0; j < this.ColCount; j++)
                    this[i, j] = Convert.ToDouble(d[j, i].Value);
        }

        public void ToDataGridView(System.Windows.Forms.DataGridView d)
        {
            if (this.RowCount != d.RowCount || this.ColCount != d.ColumnCount)
                return;
            for (int i = 0; i < this.RowCount; i++)
                for (int j = 0; j < this.ColCount; j++)
                    d[j, i].Value = this[i, j];
        }
    }
}
