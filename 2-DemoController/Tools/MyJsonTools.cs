using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace _2_DemoController.Tools
{
    public class MyJsonTools
    {
        public static string ToJson<T>(T obj)
        {
            string resultat = null;

            DataContractJsonSerializer serialise = new DataContractJsonSerializer(typeof(T));

            using (MemoryStream stream = new MemoryStream())
            {
                serialise.WriteObject(stream, obj);
                resultat = Encoding.UTF8.GetString(stream.ToArray());
            }

                return resultat;
        }
    }
}