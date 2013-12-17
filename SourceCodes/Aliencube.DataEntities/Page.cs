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

        /// <summary>
        /// Gets or sets the value that specifies whether the page is published or not.
        /// </summary>
        public bool IsPublished { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the list of content instances.
        /// </summary>
        public virtual ICollection<Content> Contents { get; set; }

        /// <summary>
        /// Gets or sets the list of page URL instances.
        /// </summary>
        public virtual ICollection<PageUrl> PageUrls { get; set; }

        #endregion Relations
    }
}