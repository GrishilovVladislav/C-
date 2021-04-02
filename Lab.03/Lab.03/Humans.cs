using System;
using System.Collections.Generic;


namespace Lab._03
{
    class Humans
    {
        List<Human> MyHumans;
        private int HowManyHumans = 0;
        public Humans()
        {
            MyHumans = new List<Human>();
            HowManyHumans = 0;
        }        
        public Human this[int ID]
        {
            get
            {
                if (ID < 0 || ID >= HowManyHumans)
                {
                    throw new Exception("There is no such index");
                }
                return MyHumans[ID];
            }
            set
            {
                MyHumans.Insert(ID, value);
                ++HowManyHumans;
            }
        }       
    }
}