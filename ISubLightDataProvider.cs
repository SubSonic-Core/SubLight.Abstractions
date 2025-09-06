
using SubLight.Data;

namespace SubLight;

public interface ISubLightDataProvider<TEntity>
{
    /// <summary>
    /// Retrieves the data associated with the specified key.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<TEntity?> RetrieveAsync(DataKey<TEntity> key, CancellationToken cancellationToken = default);
	ValueTask<bool> PersistAsync(DataEnvelope<TEntity> envelope, CancellationToken cancellationToken = default);
	ValueTask<bool> DeleteAsync(DataKey<TEntity> key, CancellationToken cancellationToken = default);
}

public interface ISubLightBulkDataProvider<TEntity>
    : ISubLightDataProvider<TEntity>
{
	ValueTask<BulkOperationResult> BulkPersistAsync(BulkDataEnvelope<TEntity> bulkEnvelope, CancellationToken cancellationToken = default);
}