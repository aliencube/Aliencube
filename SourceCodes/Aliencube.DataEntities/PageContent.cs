using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliencube.DataEntities
{
    /// <summary>
    /// This represents the page content entity.
    /// </summary>
    public partial class PageContent
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique Id representing a page content.
        /// </summary>
        public int PageContentId { get; set; }

        /// <summary>
        /// Gets or sets the page version Id which this belongs to.
        /// </summary>
        public int PageVersionId { get; set; }

        /// <summary>
        /// Gets or sets the content in XML format.
        /// </summary>
        public string ContentXml { get; set; }

        /// <summary>
        /// Gets or sets the content in JSON format.
        /// </summary>
        public string ContentJson { get; set; }

        #endregion

        #region Relations
        #endregion
    }
}
