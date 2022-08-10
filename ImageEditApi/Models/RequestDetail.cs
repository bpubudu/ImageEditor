using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageEditApi.Models
{
    public class RequestDetail
    {
        public string SourceLocation { get; set; }

        public bool Effect1 { get; set; }

        public bool Effect2 { get; set; }

        public bool Effect3 { get; set; }

        public int ResizeSize { get; set; }

        public float RadiusSize { get; set; }
    }
}
