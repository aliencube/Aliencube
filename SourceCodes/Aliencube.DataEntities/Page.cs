using System;
using System.Collections.Generic;
using System.Linq;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the page entity.
    /// </summary>
    public partial class Page
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a page.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the page schema Id which this belongs to.
        /// </summary>
        public int PageSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the list of page Ids representing the page hierarchy, delimited by commas.
        /// </summary>
        public string PageHierarchy { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the page is root or not.
        /// </summary>
        public bool IsRoot { get; set; }

        /// <summary>
        /// Gets or sets the value that determines the order of the page appearing in a page tree.
        /// </summary>
        public int SortOrder { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the page schema instance.
        /// </summary>
        public virtual PageSchema PageSchema { get; set; }

        /// <summary>
        /// Gets or sets the list of page URL instances.
        /// </summary>
        public virtual ICollection<PageUrl> PageUrls { get; set; }

        /// <summary>
        /// Gets or sets the list of element schema instances.
        /// </summary>
        public virtual ICollection<PageVersion> PageVersions { get; set; }

        #endregion Relations
    }
}