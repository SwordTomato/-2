class Program {

    static void Main(string[] args) {
        Console.Write("Day of Week : ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Time of Day : ");
         int y = int.Parse(Console.ReadLine());
        
         int Breakfast = 5;
         int Weekend = 2;
         int Coffee = 3;
         
    while(true) {
        Console.Write("ชุดที่สั่งซื้อ : ");
         string z = (Console.ReadLine());

        if (z == "Breakfast Set") {
            if (y <= 11) {
                Breakfast--;
            } else {Console.WriteLine("Sorry your order is not available");}

            if (Breakfast < 0 ) {
                Console.WriteLine("Sorry your order is out of stock");
            }
        } else if (z == "Weekend Set") {
            if (x == 6 || x == 7) {
                Weekend--;
            } else {Console.WriteLine("Sorry your order is not available");}

            if (Weekend < 0 ) {
                Console.WriteLine("Sorry your order is out of stock");
            }
        } else if (z == "Coffee") {
            if (Coffee > 0) {
                Coffee--;
            } else {Console.WriteLine("Sorry your order is out of stock");}

    } if (z == "End") {
        break;
         } else if( z != "Breakfast Set" && z != "Weekend Set" && z != "Coffee") {Console.WriteLine("Please enter a vaild menu");}
            }
        }
}