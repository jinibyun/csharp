using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace newVersionCSharp._7._0
{
    public class asyncReturnType: TestMain
    {
        private Dictionary<int, int> cache = new Dictionary<int, int>();
        public async override void Test()
        {
            base.Test();
            int result =await GetCache(1000);
            Console.WriteLine(result);
        }
        // old: async can have Task, Task<T> and void (not recommended)
        // new: + ValueTask<T>: T + Task<T> 
        // advantage: 
        // In case of "synchronous process", return T (without Task)
        // In case of "asynchronous process", return Task 
        private async ValueTask<int> GetCache(int id)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (cache.ContainsKey(id))
            {
                // synchronous
                return cache[id];
            }
            else
            {
                // asynchronous : Task object
                int res = await Fetch(id);
                cache.Add(id, res);
                return res;
            }
        }

        private async Task<int> Fetch(int id)
        {
            await Task.Run(() => id);
            return id;
        }
    }
}
