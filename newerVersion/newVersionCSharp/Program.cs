using newVersionCSharp._6._0;
using newVersionCSharp._7._0;
using System;

namespace newVersionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------  c# 6.0  --------------------
            // var obj6 = new StringInterpolation();
            // NullConditionalOperator
            // nameOfOperator
            // awaitWithCatch
            // var obj6 = new DictionaryInitializer();
            // var obj6 = new autoPropertyInitializer();
            var obj6 = new expressionBodiedMember();

            Console.WriteLine("========= New features on c# 6.0 =========");
            obj6.Test();
            Console.WriteLine("End of c# 6.0 Test");


            // ----------------  c# 7.0  --------------------
            // var obj7 = new isPatternMaching();
            // var obj7 = new tupleTest();
            // var obj7 = new localFunction();
            // var obj7 = new outParameterOption();
            // var obj7 = new DeconstructorTest();
            // var obj7 = new refLocal();
            // expressionBodiedMemberMore
            // var obj7 = new asyncReturnType();
            var obj7 = new throwExpression();

            Console.WriteLine("========= New features on c# 7.0 =========");
            obj7.Test();
            Console.WriteLine("End of c# 7.0 Test");
        }
    }
}
