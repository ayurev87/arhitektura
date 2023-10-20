using HW1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.ModelElements
{
    internal abstract class Vector3DMoveRotate
    {
        public Point3D location;
        public Angle3D angle;


        public virtual void Rotate(Angle3D angle)
        {

        }
        public virtual void Move(Point3D point) { }
    }
}
