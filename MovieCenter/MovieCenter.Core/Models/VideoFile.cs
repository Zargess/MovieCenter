using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCenter.Core.Models
{
    public class VideoFile
    {
        public string Name { get; private set; }
        public Guid ID { get; set; }
        public string LogoUrl { get; private set; }

        public VideoFile(string name, Guid id, string logourl)
        {
            Name = name;
            ID = id;
            LogoUrl = logourl;
        }
    }
}
