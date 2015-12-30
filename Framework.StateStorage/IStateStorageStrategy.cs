using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.StateStorage
{
    public interface IStateStorageStrategy<in TKey, TValue>
    {
        void Put(TKey key, TValue value);

        TValue Get(TKey key);

        void Remove(TKey key);
    }
}
