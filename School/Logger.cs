using System;
using System.IO;
using School.Pages;

namespace School
{
    class Logger
    {
        string filePath = @"log.txt";

            Login lgin = new Login();

        public void WriteSignup(string value)
        {
            File.AppendAllText(filePath, value + "this file was created at --->" + DateTime.Now.ToString() + Environment.NewLine);
        }

        public void WriteLogin(string value)
        {
            
            File.AppendAllText( filePath, "\"" + value+ "\"" + "user logged in system at " + DateTime.Now.ToString() + Environment.NewLine);
        }
        public void WriteLogger()
        {
            File.AppendAllText(filePath, "\"" + /*lgin.getUserName()  +*/ "\"" + "user enterd log.txt" + DateTime.Now.ToString() + Environment.NewLine) ;
        }
        public void WriteExit()
        {
            File.AppendAllText(filePath, "\"" +/* lgin.getUserName() + */"\"" + "Closed Programm" + DateTime.Now.ToString() + Environment.NewLine + Environment.NewLine);
        }
        public void WriteProfile()
        {
            File.AppendAllText(filePath, "\"" + /*lgin.getUserName() +*/ "\""+ "entered profile" + DateTime.Now.ToString() + Environment.NewLine);
        }
        public void WriteClasses()
        {
            File.AppendAllText(filePath, "\"" /*+ lgin.getUserName() */+ "\"" + "entered Classes" + DateTime.Now.ToString() + Environment.NewLine );
        }

        public void WriteEnterSheadule(int value)
        {
            File.AppendAllText(filePath, "\"" + /*lgin.getUserName() +*/ "\"" + "entered " + value + " Classes" + DateTime.Now.ToString() + Environment.NewLine);
        }


    }
}
