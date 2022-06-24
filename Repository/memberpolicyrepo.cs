using policymicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Repository
{
    public class memberpolicyrepo
    {
        public static List<memberpolicy> m = new List<memberpolicy>()
        {
            new memberpolicy()
            {
              policyid=1,
              memberid=1,
              membername="Hariprasadh",
              subscriptiondate="XXX",
              locationid=1,
              locationname="Madurai",
              hospitalid=2,
              hospitalname="Velammal",
              topupFrequency=2
            },
            new memberpolicy()
            {
              policyid=1,
              memberid=2,
              membername="Charulatha",
              subscriptiondate="XXX",
              locationid=1,
              locationname="Chennai",
              hospitalid=3,
              hospitalname="GH",
              topupFrequency=1
            },
            new memberpolicy()
            {
              policyid=2,
              memberid=3,
              membername="Anjali",
              subscriptiondate="XXX",
              locationid=2,
              locationname="Kolkata",
              hospitalid=3,
              hospitalname="NRS",
              topupFrequency=0
            },
            new memberpolicy()
            {
              policyid=1,
              memberid=4,
              membername="Aiswarya",
              subscriptiondate="XXX",
              locationid=3,
              locationname="Coimabatore",
              hospitalid=1,
              hospitalname="CGH",
              topupFrequency=2
            },
            new memberpolicy()
            {
              policyid=2,
              memberid=5,//given
              membername="Hema",
              subscriptiondate="XXX",
              locationid=2,//
              locationname="Banglore",
              hospitalid=1,//
              hospitalname="AMIS"
            }
        };
        public List<int> gethosloc(int memberid)
        {
            memberpolicy ob = new memberpolicy();
            ob = m.Where(p => p.memberid == memberid).FirstOrDefault();//row
            int x = ob.hospitalid;
            int y = ob.locationid;
            List<int> n = new List<int>();
            n.Add(x);
            n.Add(y);
            return n;
        }
        public List<memberpolicy> fun()
        {
            return m;
        }
        public int receivepolicyid(int memberid)
        {
            int x;//we need to assign a value to x if x does not get value in forloop it will be nullable int ?x
            foreach (var item in m)
            {
                if (item.memberid == memberid)
                {
                    x = item.policyid;
                    return x;
                }
            }
            return 0;
        }
        public int gettopup(int memberid)
        {
            foreach(var item in m)
            {
                if (item.memberid == memberid)
                    return item.topupFrequency;
            }
            return 0;
        }

    }
}
