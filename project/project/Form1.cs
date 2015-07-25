using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    struct Concept
    {
        public SmallSet Ext;
        public SmallSet Int;//obj
    };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void setSizeBtn_DSM_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(sizeRows_DSM.Text);
            int j = Convert.ToInt32(sizeCols_DSM.Text);
            objects.RowCount = i;
            objects.ColumnCount = 1;
            attributes.RowCount = 1;
            attributes.ColumnCount = j;
            In_Sets.RowCount = i;
            In_Sets.ColumnCount = j;
        }
        private bool indexSet_IsIn(int ind, SmallSet y)
        {
            return y[ind];
        }
        private bool Canonic(int ind, List<SmallSet> u)
        {
            for (int i = 0; i < ind; i++)
            {
                if (u[ind]<=u[i])
                    return false;
            }
            return true;
        }
        private bool RelCanonic(int ind, List<SmallSet> u, SmallSet Y, SmallSet z)
        {
            for (int i = 0; i < ind; i++)
            {
                if (!indexSet_IsIn(i, Y) && (z * u[i]) == z)
                {
                    return false;
                }
            }
            return true;
        }
        private int set_indexOf(SmallSet x, List<SmallSet> u)
        {
            for (int i = 0; i < u.Count; i++)
            {
                if (x == u[i])
                {
                    return i;
                }
            }
            return -1;
        }
        private void AddToListOfConcepts(int ind, List<Concept> L, List<SmallSet> u)
        {
            int n = L.Count;
            for (int i = 0; i < n; i++)
            {
                if (L[i].Int <= u[ind])
                {
                    Concept c = L[i];
                    SmallSet a = new SmallSet(ind);
                    c.Ext = L[i].Ext + a;
                    L[i] = c;
                }
                else
                {
                    SmallSet z = L[i].Int * u[ind];
                    if (RelCanonic(ind, u, L[i].Ext, z))
                    {
                        Concept c = new Concept();
                        SmallSet a = new SmallSet(ind);
                        c.Ext = L[i].Ext + a;
                        c.Int = z;
                        L.Add(c);
                    }
                }
            }
            if (Canonic(ind, u))
            {
                Concept c = new Concept();
                SmallSet a = new SmallSet(ind);
                c.Ext = a;
                c.Int = u[ind];
                L.Add(c);
            }
        }
        private List<Concept> Norris(List<SmallSet> u)
        {
            List<Concept> L = new List<Concept>();
            for (int i = 0; i < u.Count; i++)
            {
                AddToListOfConcepts(i, L, u);
            }
            return L;
        }
        private string concept_toString(Concept a, Context c)
        {
            string b = "<{";
            for (int i = 0; i < c.unAtr.Count; i++)
                if (a.Ext[i] == true)
                    b += c.unAtr[i] + " "; 
            b+= "}, {";
            for (int i = 0; i < c.unObj.Count; i++)
                if (a.Int[i] == true)
                    b += c.unObj[i] + " ";
            b+="}>";
            return b;
        }

        private void norrisbtn_Click(object sender, EventArgs e)
        {
            List<Concept> L = new List<Concept>();
            Context a = new Context(In_Sets, objects, attributes);
            L = Norris(a.body);
            string str = NorrisToString(L, a);
            hyp_out.Text = str;
            Console.Write(str);

        }
        private string NorrisToString(List<Concept> L, Context a)
        {
            string str = "";
            for (int j = 0; j < L.Count; j++)
                str += concept_toString(L[j], a);
            return str;
        }


        private void setsizeBtn1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(sizeRows_DSM.Text);
            int j = Convert.ToInt32(sizeCols_DSM.Text);
            attributes1.RowCount = i;
            attributes1.ColumnCount = 1;
            objects1.RowCount = 1;
            objects1.ColumnCount = j;
            Out_Sets.RowCount = i;
            Out_Sets.ColumnCount = j;
            for (int a=0; a<j; a++)
                objects1[a, 0].Value = attributes[a, 0].Value;
        }
        private void setsizeBtn2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(sizeRows_DSM.Text);
            int j = Convert.ToInt32(sizeCols_DSM.Text);
            objects2.RowCount = i;
            objects2.ColumnCount = 1;
            attributes2.RowCount = 1;
            attributes2.ColumnCount = j;
            tau.RowCount = i;
            tau.ColumnCount = j;
            for (int a = 0; a < j; a++)
                attributes2[a, 0].Value = attributes[a, 0].Value;
        }
        private void dsm_btn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            Context plus = new Context(In_Sets, objects, attributes);
            Context minus = new Context(Out_Sets, attributes1, objects1);
            List<SmallSet> L = new List<SmallSet>();

            for (int i = 0; i < tau.RowCount; i++)
            {
                SmallSet a = new SmallSet(tau, i);
                L.Add(a);
            }
            List<String> Obj=new List<String>();
            for (int i=0; i<objects2.RowCount; i++)
            {
                String a=Convert.ToString(objects2[0, i].Value);
                Obj.Add(a);
            }
            List<Concept> plus_hyp = new List<Concept>();
            List<Concept> minus_hyp = new List<Concept>();
            bool diff = true;
            while (diff)
            {
                counter++;
                int d = 0;
                plus_hyp = Norris(plus.body);
                minus_hyp = Norris(minus.body);
                string str = NorrisToString(plus_hyp, plus);
                string str1 = NorrisToString(minus_hyp, minus);
                str1 += "||||||";
                str1 += str;
                hypothesis.Text = str1;
                for (int j = 0; j < L.Count; j++)
                {
                    bool ind_plus = check(L[j], plus_hyp);
                    bool ind_minus = check(L[j], minus_hyp);
                    if (ind_plus && !ind_minus)
                    {
                        plus.body.Add(L[j]);
                        plus.unAtr.Add(Obj[j]);
                        d++;
                    }
                    if (!ind_plus && ind_minus)
                    {
                        minus.body.Add(L[j]);
                        minus.unAtr.Add(Obj[j]);
                        d++;
                    }
                    if (ind_plus || ind_minus)
                    {
                        L.Remove(L[j]);
                        Obj.Remove(Obj[j]);
                        j--;
                        d++;
                    }
                }
                if (d == 0)
                    diff = false;
            }
            plus.toDataGridView(In_Sets, objects);
            minus.toDataGridView(Out_Sets, attributes1);
            objects2.RowCount = Obj.Count;
            tau.RowCount = L.Count;
            for (int i = 0; i < Obj.Count; i++)
                objects2[0, i].Value = Obj[i];
            for (int i = 0; i < L.Count; i++)
                L[i].ToDataGridView(tau, i);
            norrisout.Text = counter.ToString();
        }

        bool check(SmallSet cur, List<Concept> a)
        {
            for (int i = 0; i < a.Count; i++)
                if ((a[i].Int <= cur)&&(a[i].Int.body!=0))
                    return true;
            return false;
        }

        private void fill_default_Click(object sender, EventArgs e)
        {
            //Set sets sizes
            sizeCols_DSM.Text = "18";
            sizeRows_DSM.Text = "3";
            setSizeBtn_DSM_Click(sender, e);
            setsizeBtn1_Click(sender, e);
            sizeRows_DSM.Text = "24";
            setsizeBtn2_Click(sender, e);
            //Fill in attributes
            int i = 0;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "лук"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "копье"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "меч"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "арбалет"; i++;//3
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "шпага"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "мушкет"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "пистолет"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "ружье"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "винтовка"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "пулемет"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "револьвер"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "мотыга"; i++; //11
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "серп"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "соха"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "коса"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "плуг"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "косилка"; i++;
            attributes[i, 0].Value = objects1[i, 0].Value = attributes2[i, 0].Value = "трактор"; i++;
            //fill in plus-examples
            objects[0, 0].Value = "лук, меч";
            In_Sets[0, 0].Value = In_Sets[2, 0].Value = 1;
            objects[0, 1].Value = "лук, копье";
            In_Sets[0, 1].Value = In_Sets[1, 1].Value = 1;
            objects[0, 2].Value = "меч, копье";
            In_Sets[2, 2].Value = In_Sets[1, 2].Value = 1;
            //fill in minus-examples
            attributes1[0, 0].Value = "мотыга, серп";
            Out_Sets[11, 0].Value = Out_Sets[12, 0].Value = 1;
            attributes1[0, 1].Value = "серп,  соха";
            Out_Sets[12, 1].Value = Out_Sets[13, 1].Value = 1;
            attributes1[0, 2].Value = "соха, мотыга";
            Out_Sets[13, 2].Value = Out_Sets[11, 2].Value = 1;
            //fill in tau-examples
            i=0;
            objects2[0, i].Value = "лук, арбалет";
            tau[0, i].Value = tau[3, i].Value = 1; i++;
            objects2[0, i].Value = "меч, арбалет";
            tau[2, i].Value = tau[3, i].Value = 1; i++;
            objects2[0, i].Value = "арбалет, шпага";
            tau[3, i].Value = tau[4, i].Value = 1; i++;
            objects2[0, i].Value = "меч, шпага";
            tau[2, i].Value = tau[4, i].Value = 1; i++;
            objects2[0, i].Value = "шпага, мушкет";
            tau[4, i].Value = tau[5, i].Value = 1; i++;
            objects2[0, i].Value = "шпага, пистолет";
            tau[4, i].Value = tau[6, i].Value = 1; i++;
            objects2[0, i].Value = "арбалет, мушкет";
            tau[3, i].Value = tau[5, i].Value = 1; i++;
            objects2[0, i].Value = "арбалет, пистолет";
            tau[3, i].Value = tau[6, i].Value = 1; i++;
            objects2[0, i].Value = "мушкет, ружье";
            tau[5, i].Value = tau[7, i].Value = 1; i++;
            objects2[0, i].Value = "пистолет, ружье";
            tau[6, i].Value = tau[7, i].Value = 1; i++;
            objects2[0, i].Value = "ружье, винтовка";
            tau[7, i].Value = tau[8, i].Value = 1; i++;
            objects2[0, i].Value = "пистолет,  винтовка";
            tau[6, i].Value = tau[8, i].Value = 1; i++;
            objects2[0, i].Value = "винтовка,  пулемет";
            tau[8, i].Value = tau[9, i].Value = 1; i++;
            objects2[0, i].Value = "пистолет,  пулемет";
            tau[6, i].Value = tau[9, i].Value = 1; i++;
            objects2[0, i].Value = "пистолет, револьвер";
            tau[6, i].Value = tau[10, i].Value = 1; i++;
            objects2[0, i].Value = "винтовка, револьвер";
            tau[8, i].Value = tau[10, i].Value = 1; i++;
            objects2[0, i].Value = "серп,  коса";
            tau[12, i].Value = tau[14, i].Value = 1; i++;
            objects2[0, i].Value = "мотыга, коса";
            tau[11, i].Value = tau[14, i].Value = 1; i++;
            objects2[0, i].Value = "мотыга,  плуг";
            tau[11, i].Value = tau[15, i].Value = 1; i++;
            objects2[0, i].Value = "соха, плуг";
            tau[13, i].Value = tau[15, i].Value = 1; i++;
            objects2[0, i].Value = "коса,  косилка";
            tau[14, i].Value = tau[16, i].Value = 1; i++;
            objects2[0, i].Value = "плуг, косилка";
            tau[15, i].Value = tau[16, i].Value = 1; i++;
            objects2[0, i].Value = "плуг, трактор";
            tau[15, i].Value = tau[17, i].Value = 1; i++;
            objects2[0, i].Value = "косилка, трактор";
            tau[16, i].Value = tau[17, i].Value = 1;
        }

        private void nerd_on_Click(object sender, EventArgs e)
        {
            hyp_out.Visible = true;
            hypothesis.Visible = true;

        }

    }
}
