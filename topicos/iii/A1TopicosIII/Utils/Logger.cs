using A1TopicosIII.Data;
using A1TopicosIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TopicosIII.Utils
{
    public class Logger
    {
        public static void logWrapper(string texto, string usuario) {
            Context ctx = new Context();
            Log log = new Log(texto, usuario);
            log.logDateTime = DateTime.Now;
            ctx.logs.Add(log);
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
