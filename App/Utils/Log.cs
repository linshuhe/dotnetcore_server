using NLog;

public class Log{
    private static Logger logger = LogManager.GetLogger("Logger"); //初始化日志类

    public static void Info(string msg){
        logger.Info(msg);
    }

}