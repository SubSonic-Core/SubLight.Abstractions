using SubLight.Data.Migrations.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubLight.Data.Migrations
{
    public abstract class Migration
    {
        /// <summary>
        /// Gets the unique identifier for the migration (e.g. timestamp or name).
        /// </summary>
        public abstract string Id { get; }
        public abstract string Description { get; }

        /// <summary>
        /// applies how to upgrade the data store to a migration builder.
        /// </summary>
        /// <remarks>This method is typically used to define the steps required to apply a migration to a database
        /// </remarks>
        public abstract void GenerateUp(Action<IMigrationBuilder> builder);
        /// <summary>
        /// Generates the necessary operations to revert the changes made by a migration.
        /// </summary>
        /// <remarks>This method is typically used to define the steps required to roll back a database
        /// schema  to its previous state. Implementations should specify the operations needed to undo the  changes
        /// introduced in the corresponding "up" migration.</remarks>
        public abstract void GenerateDown(Action<IMigrationBuilder> builder);
    }
}
