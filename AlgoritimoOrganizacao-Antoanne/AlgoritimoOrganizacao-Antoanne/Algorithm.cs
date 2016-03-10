using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgoritimoOrganizacao_Antoanne
{
    class Algorithm
    {
        #region Properties
        List<int> nbrs = new List<int>();
        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();
        private long elapsed;
        #endregion

        #region Get/Set
        public long Elapsed
        {
            get
            {
                return elapsed;
            }
            set
            {
                elapsed = value;
            }
        }
        #endregion

        #region Methods
        public void AddRandomElements(int q, int min, int max, List<int> l)
        {
            int count = 0;
            while(count != q)
            {
                l.Add(random.Next(min, max));
                count++;
            }
        }

        public void BubbleSort(List<int> l)
        {
            stopwatch.Start();
            int temp = 0;
            int nxt = 0;

            for (int i = 0; i < l.Count; i++)
            {
                for (int j = 0; j < l.Count - 1; j++)
                {
                    nxt = j + 1;
                    if (l[j] > l[nxt]){
                        temp = l[nxt];
                        l[nxt] = l[j];
                        l[j] = temp;
                    }
                }
            }
            stopwatch.Stop();
            elapsed = stopwatch.ElapsedMilliseconds;
        }
        #endregion

    }
}
