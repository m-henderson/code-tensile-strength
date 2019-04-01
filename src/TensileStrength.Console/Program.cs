using System;

namespace TensileStrength.Console
{
    // this project will be the test bed for making api calls and verify what the project hopes to achieve. 
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(args);

            if (args.Length > 1)
            {
                BeginExecution(args);
            } else
            {
                System.Console.WriteLine("You must provide two parameters. EX: TensileStrength.exe ado login. The first parameter gives the console app context and the second is the action");
            }
           
        }

        private static void BeginExecution(string[] args)
        {
            var context = args[0];
            var action = args[1];

            if(context == "ado" && action == "login")
            {
                AdoLogin();
            }
          
        }

        private static void AdoLogin()
        {

            string clientAppId;
            string clientAppSecret;
            string scope;
            string callBackUrl;

            while (true)
            {
                WriteConsoleLine("Azure Dev Ops Client App Id: ");
                clientAppId = ReadConsoleLine();
                WriteConsoleLine("Azure Dev Ops Client App Secret: ");
                clientAppSecret = ReadConsoleLine();
                WriteConsoleLine("Azure Dev Ops Scope: ");
                scope = ReadConsoleLine();
                WriteConsoleLine("Azure Dev Ops Callback URL: ");
                callBackUrl = ReadConsoleLine();
                WriteConsoleLine("Connection to Azure Dev Ops Successful...", status: "success");
                break;
            }
        }

        private static string ReadConsoleLine()
        {
            string line = System.Console.ReadLine();
            return line;
        }

        private static void WriteConsoleLine(string output, string status = null)
        {
            if(status == "success")
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
            }
            System.Console.WriteLine(output);
            System.Console.ResetColor();
        }
    }
}
