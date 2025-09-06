
using SubLight.Data.Migrations.Builder;

namespace SubLight.Data.Migrations;

public interface IMigrationRunner
{
    IReadOnlyList<Migration> GetAvailableMigrations();
    IReadOnlyList<string> GetAppliedMigrationIds();
    void ApplyMigration(Migration migration, IMigrationBuilder builder);
    void RollbackMigration(Migration migration, IMigrationBuilder builder);
}