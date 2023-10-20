using HW1.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.ModelElements
{
    internal class PoligonalModel
    {
        public List<Poligon> Poligons;
        public List<Texture> Textures;

        public PoligonalModel(List<Texture> textures)
        {
            this.Textures = textures;
            this.Poligons = new List<Poligon>{
                new Poligon()
        };
        }

    }
}