using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_platform
{
    class ProductClass : PromotionClass, Iproducts
    {
        // private Iproducts _products;
        //private string keyOfIndex1;
        //private string keyOfIndex2;
        //private string keyOfIndex3;
        //private string keyOfIndex4;
        //public void a(Iproducts i)
        //{
        //    i = _products;
        //}
        private int sumA = 0;
        private int sumB = 0;
        private int sumCD = 0;

        private string keyOfIndex1
            {
                get;
                set;
            }


        private string keyOfIndex2
        {
            get;
            set;
        }

        private string keyOfIndex3
        {
            get;
            set;
        }


        private string keyOfIndex4
        {
            get;
            set;
        }


        public int sumproduct(Dictionary<string, int> quantity)
        {
            var aVal = 50;
            var bVal = 30;
            var cVal = 20;
            var dVal = 15;
            //for (int i = 0; i < quantity.Count; i++)
            //{
                keyOfIndex1 = quantity.ElementAt(0).Key;
                keyOfIndex2 = quantity.ElementAt(1).Key;
                keyOfIndex3 = quantity.ElementAt(2).Key;
                keyOfIndex4 = quantity.ElementAt(3).Key;

                sumA = (quantity[keyOfIndex1] / 3) * 130 + (quantity[keyOfIndex1] % 3) * aVal;
                sumB = (quantity[keyOfIndex2] / 2) * 45 + (quantity[keyOfIndex2] % 2) * bVal;
                if (quantity[keyOfIndex3] > 0 && quantity[keyOfIndex4] > 0)
                {
                    if (quantity[keyOfIndex3] > quantity[keyOfIndex4])
                    {
                        sumCD = quantity[keyOfIndex4] * 30 + (quantity[keyOfIndex3] - quantity[keyOfIndex4]) * cVal;
                       
                    }
                    else if (quantity[keyOfIndex4] < quantity[keyOfIndex3])
                    {
                        sumCD = quantity[keyOfIndex4] * 30 + (quantity[keyOfIndex4] - quantity[keyOfIndex3]) * dVal;
                    }
                    else
                    {
                        sumCD = quantity[keyOfIndex3] * 30;
                    }
                }

                else
                {
                    sumCD = quantity[keyOfIndex3] * cVal + quantity[keyOfIndex4] * dVal;
                }

               
          //  }
            return sumA + sumB + sumCD;
        }

        }

    

      


    }


  
