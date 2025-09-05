namespace SubLight.Data
{
    public record BulkOperationResult(
        int SuccessCount, 
        IReadOnlyList<DataKey> FailedKeys, 
        IReadOnlyDictionary<DataKey, string>? ErrorMessages = null
    );
}
