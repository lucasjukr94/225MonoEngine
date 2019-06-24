using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoEngine.EngineUtil
{
    public enum ShapeType
    {
        Rectangle,
        Circle
    }
    public class Shape
    {
        public ShapeType ShapeType { get; set; }
    }
}
