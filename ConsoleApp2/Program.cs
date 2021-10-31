using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var url = "https://ocw.mit.edu/ans7870/resources/Strang/Edited/Calculus/Calculus.pdf";  // Indirmek istenilen dosya url'si.
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, @"C:\Users\egesu\Desktop\downloaded.pdf");  // Indirilen dosyanin yeri. Ve ona ne ad vermek istiyorsak downloaded yerine yaziniz.

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
       
        }
    }
}
