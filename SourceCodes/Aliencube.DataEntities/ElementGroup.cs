using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity for a group of page element.
    /// </summary>
    public partial class ElementGroup
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing an element group.
        /// </summary>
        public int ElementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the page schema Id which this belongs to.
        /// </summary>
        public int PageSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the name to be displayed.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name when to generate a strongly typed object as a class.
        /// </summary>
        public string StronglyTypedName { get; set; }

        /// <summary>
        /// Gets or sets the description of the element group.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value that determines the order of the element group appearing in a page schema.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the date when the element group is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that creates the element group.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the element group is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that updates the element group.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion

        #region Relations
        #endregion
    }
}
