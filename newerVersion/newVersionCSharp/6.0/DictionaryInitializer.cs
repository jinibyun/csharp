using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._6._0
{
    public class DictionaryInitializer: TestMain
    {
        public override void Test()
        {
            base.Test();
            // old
            var scores = new Dictionary<string, int>()
            {
                { "kim", 100 },
                { "lee",  90 }
            };
            int sc = scores["lee"];
            Console.WriteLine(sc);

            // new
            var scores2 = new Dictionary<string, int>()
            {
                ["kim"] = 100,
                ["lee"] = 90
            };
            int sc2 = scores2["lee"];
            Console.WriteLine(sc2);
        }        
    }
}
