using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the page element schema entity.
    /// </summary>
    public partial class ElementSchema
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing an element schema.
        /// </summary>
        public int ElementSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the element data type Id which this belongs to.
        /// </summary>
        public int ElementDataTypeId { get; set; }

        /// <summary>
        /// Gets or sets the element group Id which this belongs to.
        /// </summary>
        public int ElementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name to be displayed.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the name when to generate a strongly typed object as a property.
        /// </summary>
        public string StronglyTypedName { get; set; }

        /// <summary>
        /// Gets or sets the description of the element schema.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value that specifies whether this is mandatory or not.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the rule to validate this element value.
        /// </summary>
        public string ValidationRule { get; set; }

        /// <summary>
        /// Gets or sets the value that determines the order of the element schema appearing in an element group.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the date when the element schema is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has created the element schema.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the element schema is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has updated the element schema.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// Gets or sets the element group instance.
        /// </summary>
        public virtual ElementGroup ElementGroup { get; set; }

        /// <summary>
        /// Gets or sets the element data type instance.
        /// </summary>
        public virtual ElementDataType ElementDataType { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has created this.
        /// </summary>
        public virtual User CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has updated this.
        /// </summary>
        public virtual User UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the list of page element instances.
        /// </summary>
        public virtual ICollection<PageElement> PageElements { get; set; }

        /// <summary>
        /// Gets or sets the list of element schema instances.
        /// </summary>
        public virtual ICollection<PredefinedElementDataValue> PredefinedElementDataValues { get; set; }

        #endregion
    }
}
