using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page version.
    /// </summary>
    public partial class PageVersionTypeConfiguration : EntityTypeConfiguration<PageVersion>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PageVersionTypeConfiguration class.
        /// </summary>
        public PageVersionTypeConfiguration()
        {
            //  Sets the PK on PageVersionId.
            this.HasKey(p => p.PageVersionId);
            //  Sets the auto increment and identity on PageVersionId.
            this.Property(p => p.PageVersionId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.IsNewest).IsRequired();
            this.Property(p => p.IsPublished).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DatePublished).IsRequired();

            //  Sets the relation between PageVersion and Page.
            this.HasRequired(p => p.Page)
                .WithMany(p => p.PageVersions)
                .HasForeignKey(p => p.PageId)
                .WillCascadeOnDelete();

            //  Sets the relation between PageVersion and User that has created this.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.PageVersions)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between PageVersion and User that has updated this.
            this.HasRequired(p => p.PublishedByUser)
                .WithMany(p => p.PageVersions)
                .HasForeignKey(p => p.PublishedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}