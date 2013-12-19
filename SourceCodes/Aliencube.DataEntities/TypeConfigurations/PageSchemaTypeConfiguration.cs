using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page schema.
    /// </summary>
    public partial class PageSchemaTypeConfiguration : EntityTypeConfiguration<PageSchema>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PageSchemaTypeConfiguration class.
        /// </summary>
        public PageSchemaTypeConfiguration()
        {
            //  Sets the PK on PageSchemaId.
            this.HasKey(p => p.PageSchemaId);
            //  Sets the auto increment and identity on PageSchemaId.
            this.Property(p => p.PageSchemaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.DisplayName).IsRequired().HasMaxLength(128);
            this.Property(p => p.StronglyTypedName).IsRequired().HasMaxLength(128);
            this.Property(p => p.Description).IsOptional().HasMaxLength(null);
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between PageSchema and parent PageSchema.
            this.HasRequired(p => p.ParentPageSchema)
                .WithMany(p => p.ChildPageSchemata)
                .HasForeignKey(p => p.ParentPageSchemaId)
                .WillCascadeOnDelete();

            //  Sets the relation between PageSchema and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.PageSchemata)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between PageSchema and User that has updated this.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.PageSchemata)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}