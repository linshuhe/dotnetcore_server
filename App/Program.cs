using System;
using Model;
using NLog;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello App!");
            Console.WriteLine(Model.Test.Msg);

            String AppType = "ddd";
            String AppId = "1";

            LogManager.Configuration.Variables["appType"] = $"{AppType}";
            LogManager.Configuration.Variables["appId"] = $"{AppId}";
            LogManager.Configuration.Variables["appTypeFormat"] = $"{AppType, -8}";
            LogManager.Configuration.Variables["appIdFormat"] = $"{AppId:0000}";

            Log.Info($"server start........................ {AppId} {AppType}");
        }
    }
}
