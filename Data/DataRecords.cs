namespace SubLight.Data
{
    public record DataKey(string EntityType, IReadOnlyDictionary<string, object> KeyValues);
    public record DataEnvelope(DataKey Key, object Payload, DataOperationType DataOperation = DataOperationType.Upsert);
    public record BulkDataEnvelope(IReadOnlyList<DataEnvelope> Envelopes);
}