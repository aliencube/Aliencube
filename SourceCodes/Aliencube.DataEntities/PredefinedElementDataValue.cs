using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the entity for pre-defined element data value.
    /// </summary>
    public partial class PredefinedElementDataValue
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a pre-defined element data value.
        /// </summary>
        public int PredefinedElementDataValueId { get; set; }

        /// <summary>
        /// Gets or sets the element schema Id which this belongs to.
        /// </summary>
        public int ElementSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the element data key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the element data value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the value that determines the order of the pre-defined element data value appearing in a set.
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Gets or sets the date when the pre-defined element data value is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has created the pre-defined element data value.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the pre-defined element data value is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that has updated the pre-defined element data value.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion

        #region Relations

        /// <summary>
        /// Gets or sets the user instance.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the element schema instance.
        /// </summary>
        public virtual ElementSchema ElementSchema { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has created this.
        /// </summary>
        public virtual User CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user instance that has updated this.
        /// </summary>
        public virtual User UpdatedBy { get; set; }

        #endregion
    }
}
