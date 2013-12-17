using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the page schema entity.
    /// </summary>
    public partial class PageSchema
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a page schema.
        /// </summary>
        public int PageSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the page schema Id that identifies a parent page schema this belongs to.
        /// </summary>
        public int BasePageSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the name to be displayed.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name when to generate a strongly typed object as a class.
        /// </summary>
        public string StronglyTypedName { get; set; }

        /// <summary>
        /// Gets or sets the description of the page schema.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date when the page schema is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that creates the page schema.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the page schema is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that updates the page schema.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion

        #region Relations
        #endregion
    }
}
