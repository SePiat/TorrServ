using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TorrServCore;
using Newtonsoft.Json;
using Serilog;

namespace AFINNService
{
    public class AFINN : IAFINNService
    {
        public Dictionary<string, string> GetDictionary()
        {
            try
            {                
                var afinnData = File.ReadAllText(@"..\AFINNService\AFINN.json");
                var afinnDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(afinnData);
                return afinnDictionary;
            }
            catch (Exception ex)
            {
                Log.Error($"AFINNService.AFINN.GetDictionary() error { DateTime.Now}{ Environment.NewLine}{ex}");
                return null;
            }
        }

    }
}
