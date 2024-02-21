using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renameTool.Data
{
    public class SubtitleType : Selectable
    {
        /// <summary>
        /// String showing the ExtensionName
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// Some subtitles have multiple files for one cap.
        /// </summary>
        /// <example>.idx,.sub</example>
        public string[] Extensions { get; set; }
    }
}
