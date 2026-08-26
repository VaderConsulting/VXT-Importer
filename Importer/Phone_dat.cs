using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VXT_Importer
{
    class Phone_dat
    {
        const string SEPARATOR_CHAR = "!";

        public void GetOUs(string strFilename)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(strFilename))
                {
                    String line;

                    // Initialise our Collections
                    System.Collections.Specialized.StringCollection colDepartments;
                    System.Collections.Specialized.StringCollection colDivisions;
                    
                    colDepartments = new System.Collections.Specialized.StringCollection();
                    colDivisions = new System.Collections.Specialized.StringCollection();

                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineData;
                        lineData = line.Split(Convert.ToChar(SEPARATOR_CHAR));
                        lineData[7] = lineData[7].Trim(); //Division
                        if (colDivisions.Contains (lineData[7]) != true)
                        {
                            colDivisions.Add(lineData[7]);
                        }

                        lineData[8] = lineData[8].Trim(); //Department
                        if (colDepartments.Contains(lineData[8]) != true)
                        {
                            colDepartments.Add(lineData[8]);
                        }
                    }
                    Console.WriteLine(colDivisions.Count + " Divisions");
                    Console.WriteLine(colDepartments.Count + " Departments");
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public void Import(string strFilename)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(strFilename))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        string[] lineData;
                        lineData = line.Split(Convert.ToChar(SEPARATOR_CHAR));
                        lineData[0] = lineData[0].Trim();
                        lineData[1] = lineData[1].Trim();
                        lineData[2] = lineData[2].Trim();
                        lineData[3] = lineData[3].Trim();
                        
                        if (lineData[0].Length == 0)
                        {
                            Console.WriteLine("****" + " " + lineData[1] + " " + lineData[2] + " <--- No number defined");
                        }
                            else
                        {
                            if (lineData[3].Length > 0)
                            {
                                Console.WriteLine(lineData[0] + " " + lineData[1] + " " + lineData[2]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        

        }
        
    }
}
