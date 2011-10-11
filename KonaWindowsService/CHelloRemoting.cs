﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;

namespace KonaWindowsService
{
    public class CHelloRemoting : MarshalByRefObject, KonaRemotingLib.IHelloRemoting
    {
        public CHelloRemoting()
        {
        }

        public string[] test(int i, ArrayList ss)
        {
            KonaRemotingLib.Data dd1 = (KonaRemotingLib.Data)ss[0];
            KonaRemotingLib.Data dd2 = (KonaRemotingLib.Data)ss[1];
            Console.WriteLine("incoming " + i + ", " + dd1.sss);
            string[] a = new string[] { "svc got " + i, dd2.sss };
            return a;
        }
    }
}
