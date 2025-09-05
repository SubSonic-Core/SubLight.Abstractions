
namespace SubLight.Data;

[Flags]
public enum DataOperationType
{
    Insert = 1 << 0,
    Update = 1 << 1,
    Delete = 1 << 2,
    SoftDelete = 1 << 3,
    Upsert = Insert | Update    
}