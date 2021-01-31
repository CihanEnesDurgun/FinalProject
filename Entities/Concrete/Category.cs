using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
    //Tanıması için gelen ampülden using     dememiz lazım. Bunun sonucunda "namespace Entities.Concrete" bloğunu ekler.
{
    //Çıplak Class Kalmasın :D
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
