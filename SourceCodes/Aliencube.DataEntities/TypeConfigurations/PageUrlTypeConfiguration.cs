using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page URL type entity.
    /// </summary>
    public class PageUrlTypeConfiguration : EntityTypeConfiguration<PageUrl>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PageUrlTypeConfiguration class.
        /// </summary>
        public PageUrlTypeConfiguration()
        {
            //  Sets the PK on PageUrlId.
            this.HasKey(p => p.PageUrlId);
            //  Sets the auto increment and identity on PageUrlId.
            this.Property(p => p.PageUrlId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //this.Property(p => p.PageId).IsRequired();

            this.Property(p => p.Slug).IsRequired().HasMaxLength(1024);
            this.Property(p => p.IsMainUrl).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.CreatedBy).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();
            this.Property(p => p.UpdatedBy).IsRequired();

            //  Sets the relation between Page and PageUrl.
            this.HasRequired(p => p.Page)
                .WithMany(p => p.PageUrls)
                .HasForeignKey(p => p.PageId)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}