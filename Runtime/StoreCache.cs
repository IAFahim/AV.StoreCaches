using UnityEngine;

namespace AV.StoreCaches.Runtime
{
    public abstract class StoreCache<T, TKey> : ScriptableObject where TKey: IChangeAble
    {
        public T data;
        public abstract void Set(TKey key);
        public abstract void Update();
    }
}