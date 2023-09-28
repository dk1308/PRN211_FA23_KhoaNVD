class Exercise2
{
    static void Main(string[] args)
    {
        double volume = 0;
        int side=0;
        Console.WriteLine("Input side of a cube:");
      
        if(int.TryParse(Console.ReadLine(), out side) && side>0)
        {
            calVolume(side, out volume);
            Console.WriteLine($"volume is: {volume}");
        } else { 
            Console.WriteLine("invalid side!");
            return;
        }

        void calVolume(int side, out double volume)
        {
            volume= Math.Pow(side, 3);
        }
    }
}