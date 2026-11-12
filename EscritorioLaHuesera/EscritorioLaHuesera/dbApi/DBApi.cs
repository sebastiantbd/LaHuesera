using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace EscritorioLaHuesera.dbApi
{
    public class DBApi
    {
        public static dynamic Get(string urlApi)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101" +
"Firefox / 23.0";
            //objPedido.CookieContainer = myCookie; 
            objPedido.Credentials = CredentialCache.DefaultCredentials;
            objPedido.Proxy = null;
            HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
            Stream objFlujo = objRespuesta.GetResponseStream();
            StreamReader objFlujoLectura = new StreamReader(objFlujo);
            //Leemos los datos 
            string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
            dynamic datos = JsonConvert.DeserializeObject(datosJson);
            return datos;
        }
        public static dynamic Post(string urlApi, object objeto)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);

            objPedido.Method = "POST";
            objPedido.ContentType = "application/json";
            objPedido.Accept = "application/json";

            string datosJson = JsonConvert.SerializeObject(objeto);

            byte[] datos = Encoding.UTF8.GetBytes(datosJson);

            objPedido.ContentLength = datos.Length;

            using (Stream flujo = objPedido.GetRequestStream())
            {
                flujo.Write(datos, 0, datos.Length);
            }

            HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();

            using (StreamReader lector = new StreamReader(objRespuesta.GetResponseStream()))
            {
                string respuesta = lector.ReadToEnd();

                if (string.IsNullOrWhiteSpace(respuesta))
                    return objRespuesta.StatusCode;

                return JsonConvert.DeserializeObject(respuesta);
            }
        }
        public static dynamic Put(string urlApi, object objeto)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);

            objPedido.Method = "PUT";
            objPedido.ContentType = "application/json";
            objPedido.Accept = "application/json";

            string datosJson = JsonConvert.SerializeObject(objeto);

            byte[] datos = Encoding.UTF8.GetBytes(datosJson);

            objPedido.ContentLength = datos.Length;

            using (Stream flujo = objPedido.GetRequestStream())
            {
                flujo.Write(datos, 0, datos.Length);
            }

            HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();

            using (StreamReader lector = new StreamReader(objRespuesta.GetResponseStream()))
            {
                string respuesta = lector.ReadToEnd();

                if (string.IsNullOrWhiteSpace(respuesta))
                    return objRespuesta.StatusCode;

                return JsonConvert.DeserializeObject(respuesta);
            }
        }
    }
}
