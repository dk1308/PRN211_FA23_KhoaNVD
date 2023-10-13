
using System.IO;
using System.Text;

class FileStreamDemo

{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Demo FileStream Class ****\n");

        //Obtain a FileStream object
        using FileStream fileStream = File.Open("MyFile.txt", FileMode.Create);

        //Encode a string  as an array of bytes
        string msg = "ABCD";
        byte[] msgAsByteArray= Encoding.Default.GetBytes(msg);

        //Write byte[] to file
        fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);

        //Reset internal position of stream
        fileStream.Position = 0;

        //Read the types from file and display to console
        Console.WriteLine("Print message as an array of bytes: ");
        byte[] bytesFromFile = new byte[msgAsByteArray.Length];
        for (int i = 0; i < msgAsByteArray.Length; i++)
        {
            bytesFromFile[i] = (byte)fileStream.ReadByte();
            Console.Write($"{bytesFromFile[i],5}");
        }

        //Display decoded message
        Console.Write("\n Decoded message:");
        Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
        Console.ReadLine();
    }
}