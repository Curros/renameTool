using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renameTool.Data
{
    public class Language : Selectable
    {
        public Language()
        {
            this.Lang2Code = string.Empty;
            this.Lang3Code = string.Empty;
        }

        public string Lang { get; set; }

        /// <summary>
        /// ISO 639-2
        /// </summary>
        public string Lang2Code { get; set; }

        /// <summary>
        /// ISO 639-3
        /// </summary>
        public string Lang3Code { get; set; }

    }
}
