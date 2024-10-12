using Photos.Model;
using Photos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos.Controller
{
    internal class PhotoController
    {
        Display myDisplay = new Display();
        Photo myPhoto = new Photo();

        public PhotoController()
        {
            myDisplay.Input();
            myPhoto.Count = myDisplay.Count;
            myPhoto.Size = myDisplay.Size;
            myPhoto.OrderMethod = myDisplay.OrderMethod;
            myPhoto.Sum = myDisplay.Sum;
            myPhoto.Discount = myDisplay.Discount;
            myPhoto.TotalSum = myDisplay.TotalSum;
            myDisplay.Sum = myPhoto.CalculateSum();
            myDisplay.Discount = myPhoto.CalculateDiscount();
            myDisplay.TotalSum = myPhoto.CalculateTotalSum();
            myDisplay.Output();
        }

    }
}
