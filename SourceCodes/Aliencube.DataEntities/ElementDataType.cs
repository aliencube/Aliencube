using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the element data type entity.
    /// </summary>
    public partial class ElementDataType
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing an element data type.
        /// </summary>
        public int ElementDataTypeId { get; set; }

        /// <summary>
        /// Gets or sets the data type.
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets the description of the element data type.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date when the element data type is created.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that creates the element data type.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the element data type is updated.
        /// </summary>
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user Id that updates the element data type.
        /// </summary>
        public int UpdatedBy { get; set; }

        #endregion

        #region Relations
        #endregion
    }
}
