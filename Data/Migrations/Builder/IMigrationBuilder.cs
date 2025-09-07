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
namespace SubLight.Data.Migrations.Builder
{
    /// <summary>
    /// Marker interface for migration builders.
    /// <para>
    /// <b>Why is this interface empty?</b><br/>
    /// The <c>IMigrationBuilder</c> interface is intentionally left empty to provide a common type for all migration builder implementations.
    /// This enables the use of extension methods to define provider-specific migration operations (e.g., SQL, NoSQL, in-memory).
    /// </para>
    /// <para>
    /// By using extension methods, each data store provider can add its own migration capabilities without modifying the core abstraction.
    /// This approach supports future extensibility and allows migrations to remain provider-agnostic and flexible.
    /// </para>
    /// <para>
    /// Example usage:
    /// <code>
    /// builder.CreateTable("Customer", t => t.Column("Id", "INT", isPrimaryKey: true));
    /// builder.AddColumn("Customer", "Email", "VARCHAR(255)", isNullable: false);
    /// </code>
    /// The actual behavior depends on which provider's builder is passed in and which extension methods are available.
    /// </para>
    /// </summary>
    public interface IMigrationBuilder
    {
    }
}
