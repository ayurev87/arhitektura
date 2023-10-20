using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.InMemoryModel
{
    //Интерфейс смены модели
    internal interface IModelChanger
    {
        public void NotifyChange(IModelChanger sender);
    }
}