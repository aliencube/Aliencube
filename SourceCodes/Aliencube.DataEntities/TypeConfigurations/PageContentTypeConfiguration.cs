using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Aliencube.DataEntities.TypeConfigurations
{
    /// <summary>
    /// This represents the configuration entity for the page content.
    /// </summary>
    public partial class PageContentTypeConfiguration : EntityTypeConfiguration<PageContent>
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the PageContentTypeConfiguration class.
        /// </summary>
        public PageContentTypeConfiguration()
        {
            //  Sets the PK on PageContentId.
            this.HasKey(p => p.PageContentId);
            //  Sets the auto increment and identity on PageContentId.
            this.Property(p => p.PageContentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.ContentXml).IsRequired().HasMaxLength(null);
            this.Property(p => p.ContentJson).IsRequired().HasMaxLength(null);

            //  Sets the relation between PageCotnent and PageVersion.
            this.HasRequired(p => p.PageVersion)
                .WithOptional(p => p.PageContent)
                .Map(p => p.MapKey("PageVersionId"))
                .WillCascadeOnDelete();
        }

        #endregion Constructors
    }
}