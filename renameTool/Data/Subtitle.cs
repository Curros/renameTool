using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace renameTool.Data
{
    public class Subtitle : Language
    {
        /// <summary>
        /// Subtitle index assigned by the reaper.
        /// </summary>
        public int ID { get; set; }
        public long Size { get; set; }
        public string ParentFolder { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }

        public string Extension { get; set; }

        public string FullFileName { get; set; }
    }
}
