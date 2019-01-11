using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Swgoh
{
    public class Processor
    {
        public static async Task<PlayerModel> LoadPlayerInfo(int allyCode = 0)
        {
            //429-716-858
            string url = $"https://swgoh.gg/api/player/{allyCode}/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    PlayerModel player = await response.Content.ReadAsAsync<PlayerModel>();

                    return player;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<CharacterModel> LoadCharacterInfo(int characterId)
        {
            string url = $"https://swgoh.gg/api/characters/{characterId}/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CharacterModel character = await response.Content.ReadAsAsync<CharacterModel>();

                    return character;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
