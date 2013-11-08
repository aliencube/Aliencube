using System;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity of a content belongs to a page.
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or sets the content ID.
        /// </summary>
        public int ContentId { get; set; }

        /// <summary>
        /// Gets or sets the page ID that the content belongs to.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the content title.
        /// </summary>
        public string ContentTitle { get; set; }

        /// <summary>
        /// Gets or sets the content body.
        /// </summary>
        public string ContentBody { get; set; }

        /// <summary>
        /// Gets or sets the version number.
        /// </summary>
        public int VersionNumber { get; set; }

        /// <summary>
        /// Gets or sets the date when the content is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user ID that has created the content.
        /// </summary>
        public int CreatedBy { get; set; }
    }
}