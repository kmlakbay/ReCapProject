using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static readonly string CarsListed = "Araçlar listelendi.";
        public static readonly string CarsAdded = "Araç eklendi.";
        public static readonly string InsufficientDescription = "Açıklama alanı yetersiz.";
        public static readonly string WrongPrice = "Hatalı ücret.";

        //Brand
        public static readonly string BrandAdded = "Marka eklendi.";
        public static readonly string BrandDeleted = "Marka Silindi.";
        public static readonly string BrandsListed = "Markalar Listelendi.";
        public static readonly string BrandUpdated = "Marka Güncellendi.";

        //Color
        public static readonly string ColorAdded = "Renk eklendi.";
        public static readonly string ColorDeleted = "Renk Silindi.";
        public static readonly string ColorsListed = "Renkler Listelendi.";
        public static readonly string ColorUpdated = "Renk Güncellendi.";

        //Rental
        public static readonly string CarIsBusy = "Araba kiralanmış durumda.";
        public static readonly string CarRented = "Araba kiralandı.";
    }
}
