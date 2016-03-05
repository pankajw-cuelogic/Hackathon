using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.DMS.Windows
{
    public class FileModel
    {
        public string FileName { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileMime { get; set; }
    }
}
