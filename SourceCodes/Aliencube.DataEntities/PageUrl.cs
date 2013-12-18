using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a URL belongs to a page.
    /// </summary>
    public class PageUrl
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a page URL.
        /// </summary>
        public int PageUrlId { get; set; }

        /// <summary>
        /// Gets or sets the page Id which this belongs to.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the page slug.
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether this is the main URL or not.
        /// </summary>
        public bool IsMainUrl { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether this is an active URL or not.
        /// </summary>
        public bool IsActiveUrl { get; set; }

        /// <summary>
        /// Gets or sets the date when the page URL is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has created the page URL.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the page URL is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has updated the page URL.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the page instance.
        /// </summary>
        public virtual Page Page { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has created this.
        /// </summary>
        public virtual User CreatedByUser { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has updated this.
        /// </summary>
        public virtual User UpdatedByUser { get; set; }

        #endregion Relations
    }
}