using System;
using System.IO;

namespace Fehlerbehandlung
{
    internal class MyFileUtility
    {
        internal void Open(string fileName) //throws ... kein C# Feature
        {

            try
            {
                File.CreateText(fileName);
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                throw new MyFileException("Ordner existiert nicht");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}