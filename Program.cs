using System;

namespace Project {
    class First {
        static void Main(string[] args){
            Console.Write("Input Day of Week: ");
            int d = int.Parse(Console.ReadLine()); // X Position
            Console.Write("Input Time of Day: "); 
            int t = int.Parse(Console.ReadLine()); // Y Position

            int b = 5;
            int w = 2;
            int c = 3;

            bool end = false;
            while (!end) {
                Console.Write("Input Menu: "); 

                switch(Console.ReadLine()) {
                
                    case "Breakfast Set":
                        if (b > 0) {
                           if (t > 11) {
                            Console.WriteLine(" Sorry your order is not available");
                           } else {
                             Console.WriteLine("Order Surcess");
                             --b;
                           }

                        } else {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    case "Weekend Set":
                        if (w > 0) {
                           if (d < 6) {
                            Console.WriteLine("Sorry your order is not available");
                        
                           } else {
                             Console.WriteLine("Order Surcess");
                             --w;
                           }

                        } else {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;
                    case "Coffee":
                        if (c > 0) {
                           Console.WriteLine("Order Surcess");
                             --c;
                        } else {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        break;          
                    case "End":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;    
                }
            }
        }

    }
}