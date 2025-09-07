#region Copyright (c) 2025
// RM / Hybrid ORM: Resource Manager / Hybrid ORM
//
// License: Dual-license
//  - Free for educational, research, personal, or nonprofit projects that are not directly or indirectly used to generate revenue
//  - Commercial use requires a per-service paid license
//
// Disclaimer: Provided "as-is"; no warranty; author not liable for any damages, data loss, or business interruptions.
// Production use must be fully tested and validated within the enterprise environment.
//
// Contributions: All contributions are voluntary and licensed under this project’s dual-license; may be included in commercial releases.
// See CLA.md for Contributor License Agreement.
//
// For commercial licensing or paid support inquiries: Kenneth Carter
#endregion
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
	ValueTask<BulkOperationResult<TEntity>> BulkPersistAsync(BulkDataEnvelope<TEntity> bulkEnvelope, CancellationToken cancellationToken = default);
}