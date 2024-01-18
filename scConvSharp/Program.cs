//**************************************************************************************************
//*** scConvSharp 
//*** scConverter SDK c# sample application
//*** Simple command line converter 
//**************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace scConvSharp
{
   class Program
   {
      static void Main(string[] args)
      {

         if (args.Length < 3)
         {
            System.Console.WriteLine("sConvSharp - scConverter SDK c# sample application");
            System.Console.WriteLine("");
            System.Console.WriteLine("Usage: scConvSharp inputfile outputfile fileformat");
         }
         else
         {
            scConverterLib.Converter myconverter = new scConverterLib.Converter();
            if (myconverter != null)
            {
               myconverter.PDFLargeFormat = 1;
               myconverter.PDFWriteFormat = 0;
               myconverter.PDFLayers = 1;
               myconverter.MonochromeMode =  true;
               myconverter.TIFFSingleStrip = 1;
               myconverter.Convert(args[0],     //Input file name
                                    args[1],    //Output file name
                                    args[2],    //Format, e.g.: TIFF, PDF, CALS
                                    1.0,        //Scale
                                    1,          //Bits per pixel - used only for raster output formats
                                    200);       //Resolution (dots per inch) - used only for raster output formats
            }
         }
      }
   }
}
