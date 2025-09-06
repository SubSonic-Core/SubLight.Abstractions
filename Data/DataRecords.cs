using System.Linq.Expressions;

namespace SubLight.Data
{
    public record DataKey<TEntity>(IReadOnlyDictionary<string, object> KeyValues);    
    public record DataEnvelope<TEntity>(DataKey<TEntity> Key, object Payload, DataOperationType DataOperation = DataOperationType.Upsert);
    public record BulkDataEnvelope<TEntity>(IReadOnlyList<DataEnvelope<TEntity>> Envelopes);
}