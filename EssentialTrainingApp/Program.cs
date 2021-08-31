using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{

    
        public class Program
        {
            public static Logger logger = LogManager.GetCurrentClassLogger();
            public static List<string> Words;
            static void Main(string[] args)
            {
                logger.Trace("The program Started");
                Words = new List<string>();
                Words.Add("Bread");
                Words.Add("Milk");
                Words.Add("Cheese");

            //crazyMathProblem();
                ReadTextFile();
                Console.ReadLine();
            }

            private static void ReadTextFile()
            {

                try
                {


                    using (var sr =new StreamReader(@"c:\temp\Test.txt"))
                    {
                        string contents = sr.ReadToEnd();
                        Console.WriteLine(contents);
                    }
                }
                catch(System.IO.DirectoryNotFoundException ex)
                {
                    Console.WriteLine("couldn't find the directory.");
                    logger.Error("The directory was not found." + ex.Message);
                }
                catch(System.IO.FileNotFoundException ex)
                {
                    Console.WriteLine("could not find the file");
                    logger.Error(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An Unknown error occured" + ex.Message);

                }
            }
        }


    }

