namespace SubLight.Data
{
    public record BulkOperationResult<TEntity>(
        int SuccessCount, 
        IReadOnlyList<DataKey<TEntity>> FailedKeys, 
        IReadOnlyDictionary<DataKey<TEntity>, string>? ErrorMessages = null
    );
}
