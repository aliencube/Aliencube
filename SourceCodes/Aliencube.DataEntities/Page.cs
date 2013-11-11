using System;
using System.Collections.Generic;
using System.Linq;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// Thi represents the entity of a page.
    /// </summary>
    public class Page
    {
        #region Properties

        /// <summary>
        /// Gets or sets the page ID.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the list of page IDs representing the page hierarchy, delimited by commas.
        /// </summary>
        public string PageHierarchy { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether the page is published or not.
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets or sets the date when the page is published.
        /// </summary>
        public DateTime? DatePublished { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has published the page.
        /// </summary>
        public int? PublishedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the page is updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has updated the page.
        /// </summary>
        public int? UpdatedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the list of content instances.
        /// </summary>
        public virtual ICollection<Content> Contents { get; set; }

        #endregion Relations
    }
}