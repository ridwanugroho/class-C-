using System;

using Logger;

namespace ProgLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log();
            log.info("this is info");
            log.emerg("this is emergency");
            log.alert("this is alert");
            log.crit("this is critical");
            log.err("this is error");
            log.warning("this is warning");
            log.notice("this is notice");
            log.debug("this is debug");

            log.generate("D:/");
            log.print();
        }
    }
}
