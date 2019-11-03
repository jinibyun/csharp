using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class refLocal : TestMain
    {
        public override void Test()
        {
            base.Test();
            int a = 1;

            Console.WriteLine("> ref local test");
            // ref local
            ref int b = ref a;
            b = 2;

            Console.WriteLine($"{a}, {b}");

            Console.WriteLine("> ref return test");
            // ref return call
            GameData _gameData = new GameData();


            // NOTE: when calling ref return method, don't forget "ref"
            ref int score10 = ref _gameData.GetScore(10);

            score10 = 99;

            Console.WriteLine(_gameData.GetScore(10));
        }
    }

    class GameData
    {
        private int[] scores = new int[100];

        // ref return
        // advantage: 
        // when returing specific element of data from big size of data, it would be useful
        public ref int GetScore(int id)
        {
            //...

            return ref scores[id];
        }
    }
}
