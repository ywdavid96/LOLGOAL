using System;
using LoLGoal.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLGoal.API
{
    public class Match_V4:Api
    {
        public Match_V4():base()
        {

        }


        public List<MatchlistDto> GetPositions(string encryptedAccountId)
        {
            string path = "match/v4/matchlists/ by - account/" + encryptedAccountId;
           
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<MatchlistDto>>(content);
            }
            else
            {
                return null;
            }
        }



    }
}
