
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.ModelElements
{
    internal class Scene
    {
        public int id;
        public List<PoligonalModel> Models;
        public List<Flash> Flashes;
        public List<Camera> Cameras;

        public Scene(int id, List<PoligonalModel> Models, List<Flash> Flashes, List<Camera> Cameras)
        {
            this.id = id;
            if (Models.Count > 1)
            { this.Models = Models; }
            else { throw new ArgumentNullException(nameof(Models)); }
            this.Flashes = Flashes;
            if (Cameras.Count > 1)
            { this.Cameras = Cameras; }
            else { throw new ArgumentNullException(nameof(Cameras)); }
        }
        public T method<T>(T model)
        {
            return model;
        }

        public K method<T, K>(T model, K camera)
        {
            return camera;
        }



    }
}