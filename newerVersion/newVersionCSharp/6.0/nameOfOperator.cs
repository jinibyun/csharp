using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._6._0
{
    public class nameOfOperator: TestMain
    {
        public override void Test()
        {
            base.Test();
            // 1. name of parameter
            // throw new ArgumentException("Invalid argument", nameof(id));

            // 2. property name
            // Console.WriteLine("{0}: {1}", nameof(objPerson.Height), objPerson.Height);

            // 3. method name
            // Log(nameof(Test) + " : Started");
            
        }
    }
}
