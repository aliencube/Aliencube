using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the page element entity.
    /// </summary>
    public partial class PageElement
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a page element.
        /// </summary>
        public int PageElementId { get; set; }

        /// <summary>
        /// Gets or sets the element schema Id which this belongs to.
        /// </summary>
        public int ElementSchemaId { get; set; }

        /// <summary>
        /// Gets or sets the page version Id which this belongs to.
        /// </summary>
        public int PageVersionId { get; set; }

        /// <summary>
        /// Gets or sets the element value.
        /// </summary>
        public string Value { get; set; }

        #endregion

        #region Relations
        #endregion
    }
}
