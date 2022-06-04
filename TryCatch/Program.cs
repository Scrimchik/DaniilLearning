using Liblary;
using System;
using System.Net.Http;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();

            string text = Console.ReadLine();
            string path = Console.ReadLine();

            try
            {
                writer.WriteMessage(text, path);
            }
            catch (Exception)
            {

            }
            catch ()

            #region
            //string url = Console.ReadLine();
            //try
            //{
            //    using (HttpClient client = new HttpClient())
            //    {
            //        client.GetAsync(url);
            //    }
            //}
            //catch (HttpRequestException ex)
            //{
            //    Console.WriteLine(ex.StatusCode);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{ex.}");
            //}
            //finally
            //{
            //    Console.WriteLine("Ты идиот");
            //}
            #endregion
        }
    }
}
