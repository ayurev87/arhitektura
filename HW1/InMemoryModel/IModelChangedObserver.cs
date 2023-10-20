using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.InMemoryModel
{
    //Интерфейс смены наблюдателя
    public interface IModelChangedObserver
    {
        public void ApplyUpdateModel();
    }
}