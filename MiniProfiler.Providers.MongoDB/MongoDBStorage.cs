using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Profiling;
using StackExchange.Profiling.Storage;

namespace MiniProfiler.Providers.MongoDB
{
    public class MongoDBStorage : DatabaseStorageBase
    {
        public override List<Guid> GetUnviewedIds(string user)
        {
            throw new NotImplementedException();
        }

        public override Task<List<Guid>> GetUnviewedIdsAsync(string user)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Guid> List(int maxResults, DateTime? start = null, DateTime? finish = null, ListResultsOrder orderBy = ListResultsOrder.Descending)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Guid>> ListAsync(int maxResults, DateTime? start = null, DateTime? finish = null, ListResultsOrder orderBy = ListResultsOrder.Descending)
        {
            throw new NotImplementedException();
        }

        public override StackExchange.Profiling.MiniProfiler Load(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<StackExchange.Profiling.MiniProfiler> LoadAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public override void Save(StackExchange.Profiling.MiniProfiler profiler)
        {
            throw new NotImplementedException();
        }

        public override Task SaveAsync(StackExchange.Profiling.MiniProfiler profiler)
        {
            throw new NotImplementedException();
        }

        public override void SetUnviewed(string user, Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task SetUnviewedAsync(string user, Guid id)
        {
            throw new NotImplementedException();
        }

        public override void SetViewed(string user, Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task SetViewedAsync(string user, Guid id)
        {
            throw new NotImplementedException();
        }

        protected override DbConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<string> GetTableCreationScripts()
        {
            throw new NotImplementedException();
        }
    }
}
