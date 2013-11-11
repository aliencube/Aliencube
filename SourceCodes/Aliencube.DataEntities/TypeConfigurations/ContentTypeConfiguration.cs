using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the content type entity.
    /// </summary>
    public class ContentTypeConfiguration : EntityTypeConfiguration<Content>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the ContentTypeConfiguration class.
        /// </summary>
        public ContentTypeConfiguration()
        {
            //  Sets the PK on ContentId.
            this.HasKey(p => p.ContentId);
            //  Sets the auto increment and identity on ContentId.
            this.Property(p => p.ContentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //this.Property(p => p.PageId).IsRequired();

            this.Property(p => p.ContentTitle).IsRequired().HasMaxLength(256);
            this.Property(p => p.ContentBody).IsRequired();
            this.Property(p => p.VersionNumber).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.CreatedBy).IsRequired();

            //  Sets the relation between Page and Content.
            this.HasRequired(p => p.Page)
                .WithMany(p => p.Contents)
                .HasForeignKey(p => p.PageId)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}