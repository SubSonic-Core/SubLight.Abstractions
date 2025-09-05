
using SubLight.Data;

namespace SubLight;

public interface ISubLightDataProvider
{
	ValueTask<object?> RetrieveAsync(DataKey key, CancellationToken cancellationToken = default);
	ValueTask<bool> PersistAsync(DataEnvelope envelope, CancellationToken cancellationToken = default);
	ValueTask<bool> DeleteAsync(DataKey key, CancellationToken cancellationToken = default);
}

public interface ISubLightBulkDataProvider
	: ISubLightDataProvider
{
	ValueTask<BulkOperationResult> BulkPersistAsync(BulkDataEnvelope bulkEnvelope, CancellationToken cancellationToken = default);
}