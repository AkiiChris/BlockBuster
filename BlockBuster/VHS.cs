using System;
using System.Collections.Generic;

namespace BlockBuster
{
    public class VHS
    {
        public class VHS : Movie
        {
            public int CurrenTime { get; set; }

            public VHS(string title, Genere category, int runTime, List<string> scences) : base(title, category, runTime, scenes)
            {

            }

            public override void Play()
            {
                CurrenTime++;
            }

            public void Rewind()
            {
                CurrenTime = 0;
            }
        }

        public static explicit operator lockBuster.VHS(Movie v)
        {
            throw new NotImplementedException();
        }
    }
}
