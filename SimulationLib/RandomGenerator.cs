using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib
{
    public static class RandomGenerator
    {        

    }

    public static class MixedCongruentialGenerator
    {
        public static List<double> GetNumbers(int count,int z0,int a,int c,int m,bool zeroToOne)
        {
            List<double> l = new List<double>();

            double init = z0;
            for(int i=0;i< count; i++)
            {
                double num = (a * init + c) % m;
                double numTmp = num;
                if (zeroToOne)
                    num = num / m;
                l.Add(num);
                init = numTmp;
            }

            return l;
        }
        public static List<MixedCongruentialGeneratorParameters> FindFullPeriodParameters(int z0, int m)
        {
            List<MixedCongruentialGeneratorParameters> l = new List<MixedCongruentialGeneratorParameters>();
            List<int> listTmp = new List<int>();
            int init = z0;
            int a = 2;
            int c = 2;
            for(int i=1;i<m;i++)
            {
                a = i;
                for (int j = 1; j < m; j++)
                {
                    c = j;

                    init = z0;
                    listTmp = new List<int>();
                    for (int h = 0; h < m; h++)
                    {
                        int num = (a * init + c) % m;
                        listTmp.Add(num);
                        init = num;
                    }
                    if (listTmp.Count == listTmp.Distinct().Count())
                    {
                        MixedCongruentialGeneratorParameters p = new MixedCongruentialGeneratorParameters();
                        p.a = a;
                        p.c = c;
                        l.Add(p);
                    }
                }
            }
            return l;
        }



    }
    public static class MultiplicativeCongruentialGenerator
    {
        public static List<double> GetNumbers(int count, int z0, int a, int m, bool zeroToOne)
        {
            List<double> l = new List<double>();

            double init = z0;
            for (int i = 0; i < count; i++)
            {
                double num = (a * init) % m;
                double numTmp = num;
                if (zeroToOne)
                    num = num / m;
                l.Add(num);
                init = numTmp;
            }

            return l;
        }
        public static List<int> FindFullPeriodParameters(int z0, int m)
        {
            List<int> l = new List<int>();
            List<int> listTmp = new List<int>();
            int init = z0;
            int a = 2;
            for (int i = 1; i < m; i++)
            {
                a = i;
                
                    init = z0;
                    listTmp = new List<int>();
                    for (int h = 0; h < m-1; h++)
                    {
                        int num = (a * init) % m;
                        listTmp.Add(num);
                        init = num;
                    }
                    if (listTmp.Count == listTmp.Distinct().Count())
                    {
                        l.Add(a);
                    }                
            }
            return l;
        }



    }
}
