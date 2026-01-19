using UnityEngine;

namespace AV.StoreCaches.Runtime
{
    /// <summary>
    ///     ScriptableObject-based container for cached data.
    ///     This is a pure data container (Layer A) - any logic should be in separate Logic classes.
    /// </summary>
    /// <typeparam name="T">The type of data being stored.</typeparam>
    /// <typeparam name="TKey">The key type used to identify when to refresh the cache.</typeparam>
    public class StoreCache<T, TKey> : ScriptableObject where TKey : IChangeAble
    {
        [Tooltip("The cached data value")]
        public T data;

        /// <summary>
        ///     Checks if the cached data needs to be refreshed based on the key.
        ///     This should be called by external logic, not contain logic itself.
        /// </summary>
        public bool ShouldRefresh(TKey key)
        {
            return key != null && key.HasChanged;
        }
    }

    /// <summary>
    ///     Interface for objects that can track change state.
    /// </summary>
    public interface IChangeAble
    {
        bool HasChanged { get; }
    }
}
