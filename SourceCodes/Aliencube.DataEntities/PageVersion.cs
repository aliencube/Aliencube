using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the page version entity.
    /// </summary>
    public partial class PageVersion
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a page version.
        /// </summary>
        public int PageVersionId { get; set; }

        /// <summary>
        /// Gets or sets the page Id which this belongs to.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether this version of a page is the newest or not.
        /// </summary>
        public bool IsNewest { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether this version of a page is published or not.
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets or sets the date when the page is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has created the page.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the page is published.
        /// </summary>
        public DateTime? DatePublished { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has published the page.
        /// </summary>
        public int? PublishedBy { get; set; }

        #endregion

        #region Relations
        #endregion
    }
}
