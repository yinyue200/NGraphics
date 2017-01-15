using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGraphics.UWP
{
    class D2DLayer:ILayer
    {
        public SharpDX.Direct2D1.Layer Layer { get; set; }
    }
}
