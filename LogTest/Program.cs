using System;

public static class Program
{
    static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    public static void Main()
    {
        try
        {
           Logger.Info("Hello world");
           Logger.Debug("Hola Mundo");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }
    }
}  