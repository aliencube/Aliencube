using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page URL.
    /// </summary>
    public partial class PageUrlTypeConfiguration : EntityTypeConfiguration<PageUrl>
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

            this.Property(p => p.Slug).IsRequired().HasMaxLength(1024);
            this.Property(p => p.IsMainUrl).IsRequired();
            this.Property(p => p.IsActiveUrl).IsRequired();
            this.Property(p => p.DateCreated).IsRequired();
            this.Property(p => p.DateUpdated).IsRequired();

            //  Sets the relation between PageUrl and Page.
            this.HasRequired(p => p.Page)
                .WithMany(p => p.PageUrls)
                .HasForeignKey(p => p.PageId)
                .WillCascadeOnDelete();

            //  Sets the relation between PageUrl and User that has created this PageUrl.
            this.HasRequired(p => p.CreatedByUser)
                .WithMany(p => p.PageUrls)
                .HasForeignKey(p => p.CreatedBy)
                .WillCascadeOnDelete();

            //  Sets the relation between PageUrl and User that has updated this PageUrl.
            this.HasRequired(p => p.UpdatedByUser)
                .WithMany(p => p.PageUrls)
                .HasForeignKey(p => p.UpdatedBy)
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}