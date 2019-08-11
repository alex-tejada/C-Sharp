using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace App1
{
    class ServerInfo
    {
        Encription encription = new Encription();
        public void writeJSON(string ip, string username, string password)
        {
            JObject jObject = new JObject(
                new JProperty("ip", ip),
                new JProperty("username", encription.encrypt(username,"CheckSystem")),
                new JProperty("password", encription.encrypt(password,"CheckSystem")));

            using (StreamWriter file = File.CreateText(@"server.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                jObject.WriteTo(writer);
            }
        }

        public string[] readJSON()
        {
            string[] serverInfo = null;
            //JObject jObject = JObject.Parse(File.ReadAllText(@"server.json"));
            
            using (StreamReader file = File.OpenText(@"server.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jObject = (JObject)JToken.ReadFrom(reader);
                serverInfo = new String[3];
                serverInfo[0] = jObject.GetValue("ip").ToString();
                serverInfo[1] = encription.decrypt(jObject.GetValue("username").ToString(),"CheckSystem");
                serverInfo[2] = encription.decrypt(jObject.GetValue("password").ToString(),"CheckSystem");
            }
            return serverInfo;
        }
    }
}
