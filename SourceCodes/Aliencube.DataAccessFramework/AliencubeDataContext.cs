using Aliencube.DataAccessFramework.Interfaces;
using Aliencube.DataEntities;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;

namespace Aliencube.DataAccessFramework
{
    public class AliencubeDataContext : DbContext, IAliencubeDataContext
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the AliencubeDataContext object.
        /// </summary>
        public AliencubeDataContext()
            : base("Aliencube")
        {
        }

        /// <summary>
        /// Initialises a new instance of the AliencubeDataContext object.
        /// </summary>
        /// <param name="connectionString">SQL database connection string.</param>
        public AliencubeDataContext(string connectionString)
            : base(connectionString)
        {
        }

        /// <summary>
        /// Initialises a new instance of the AliencubeDataContext object.
        /// </summary>
        /// <param name="connection">SQL database connection</param>
        public AliencubeDataContext(DbConnection connection)
            : base(connection, true)
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets a set of contents.
        /// </summary>
        public DbSet<Content> Contents { get; set; }

        /// <summary>
        /// Gets or sets a set of pages.
        /// </summary>
        public DbSet<Page> Pages { get; set; }

        /// <summary>
        /// Gets or sets a set of page URLs.
        /// </summary>
        public DbSet<PageUrl> PageUrls { get; set; }

        /// <summary>
        /// Gets or sets a set of roles.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets a set of users.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets a set of user roles.
        /// </summary>
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// This method is called when the model for a derived context has been initialized,
        /// but before the model has been locked down and used to initialize the context.
        /// The default implementation of this method does nothing, but it can be overridden
        /// in a derived class such that the model can be further configured before it
        /// is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  Adds configurations automatically by scanning assembly.
            //  http://romiller.com/2012/03/26/dynamically-building-a-model-with-code-first

            //  Gets the MethodInfo instance for "Add".
            var addMethod = (typeof(ConfigurationRegistrar))
                .GetMethods()
                .Single(m => m.Name == "Add" && m.GetGenericArguments()
                                                 .Any(a => a.Name == "TEntityType"));

            //  Gets an assembly that contains entity type configurations.
            var assembly = AppDomain.CurrentDomain
                                    .GetAssemblies()
                                    .Single(p => p.GetName().Name.StartsWith("Aliencube.DataEntities"));

            //  Adds all types found within the assembly.
            foreach (var type in assembly.GetTypes()
                                         .Where(t => t.BaseType != null
                                                     && t.BaseType.IsGenericType
                                                     && t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)))
            {
                var entityType = type.BaseType.GetGenericArguments().Single();
                var entityConfig = assembly.CreateInstance(type.FullName);

                addMethod.MakeGenericMethod(entityType)
                         .Invoke(modelBuilder.Configurations, new object[] { entityConfig });
            }

            base.OnModelCreating(modelBuilder);
        }

        #endregion Methods
    }
}