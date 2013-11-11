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
        /// Gets or sets the page URL ID.
        /// </summary>
        public int PageUrlId { get; set; }

        /// <summary>
        /// Gets or sets the page ID that holds the page URL.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the URL of the page.
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether this is the main URL or not.
        /// </summary>
        public bool IsMainUrl { get; set; }

        /// <summary>
        /// Gets or sets the date when the URL is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has created the URL.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the page URL is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has updated the page URL.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion Properties

        #region Relations

        /// <summary>
        /// Gets or sets the page instance.
        /// </summary>
        public virtual Page Page { get; set; }

        #endregion Relations
    }
}