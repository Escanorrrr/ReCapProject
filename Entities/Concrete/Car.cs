using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz.
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int ModelYear { get; set; }
        public Decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }

    }
}
