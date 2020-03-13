using System;

namespace Couple
{
    class Couple {
    
        private static Couple c1;
        private static Couple c2;

        public static Couple GetInstance(int value) {
            
            if (value == 1) {
                
                // check if c1 is instantiated
                if (c1 == null) {
                    c1 = new Couple();
                } 

                return c1;

            } else {

                // check if c2 is instantiated
                if (c2 == null) {
                    c2 = new Couple();
                }

                return c2;
            }

        }
    }
}
