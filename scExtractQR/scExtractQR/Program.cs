using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scExtractQR
{
   internal class Program
   {
      static void Main(string[] args)
      {
         if (args.Length < 1)
         {
            System.Console.WriteLine("scExtractQR - scConverter C# sample application");
            System.Console.WriteLine("");
            System.Console.WriteLine("Usage: scExtractQR inputfile outputfile");
            System.Console.WriteLine("The outputfile argument is optional, if not given the text will be output to the console");
            return;
         }

         scConverterLib.Converter myconverter = new scConverterLib.Converter();
         if (myconverter != null)
         {
            int fileHandle = 0, qrCount = 0;
            myconverter.SetSerialNumber("");
            myconverter.OpenFileEx(args[0], ref fileHandle);    //Open the input file
            if (fileHandle != -1)
            {
               myconverter.DetectQREx(fileHandle, -1, ref qrCount);
               if (qrCount > 0)
               {
                  string outputText = "";
                  //We found at least one QR code, output decoded text to console
                  for (int i = 0; i < qrCount; i++)
                  {
                     string qrText = "";
                     myconverter.GetQRTextEx(fileHandle, i, ref qrText);
                     outputText += qrText;
                     outputText += "\n";
                  }
                  //Dump found QR text to console or output file
                  if (args.Length == 1)
                  {
                     Console.Write(outputText);
                  }
                  else
                  {
                     using (StreamWriter outputFile = new StreamWriter(args[1]))
                     {
                        outputFile.Write(outputText);
                     }
                  }
               }
               else 
               {
                  System.Console.WriteLine("No QR codes found.");
               }
               myconverter.CloseFileEx(fileHandle);
            }
            else
            {
               System.Console.WriteLine("File not found.");
            }
         }
      }
   }
}
