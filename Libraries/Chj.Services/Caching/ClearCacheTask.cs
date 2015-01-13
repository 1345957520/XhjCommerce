using Chj.Core.Caching;
using Chj.Services.Tasks;

namespace Chj.Services.Caching
{
    /// <summary>
    /// Clear cache schedueled task implementation
    /// </summary>
    public partial class ClearCacheTask : ITask
    {
        /// <summary>
        /// Executes a task
        /// </summary>
        public void Execute()
        {
            var cacheManager = new MemoryCacheManager();
            cacheManager.Clear();
        }
    }
}
