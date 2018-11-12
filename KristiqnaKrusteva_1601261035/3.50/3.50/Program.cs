using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._50
{
    class Program
    {
        static void Main(string[] args)
        {
            double gap = LocalDataStoreSlot.Length;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < LocalDataStoreSlot.Length)
                {
                    int igap = i + (int)gap;

                    if (LocalDataStoreSlot[i] > LocalDataStoreSlot[igap])
                    {
                        int temp = LocalDataStoreSlot[i];
                        LocalDataStoreSlot[i] = LocalDataStoreSlot[igap];
                        LocalDataStoreSlot[igap] = temp;
                        swaps = true;
                    }

                    ++i;
                }
    }
}
