using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Swgoh
{
    public class GenericProcessor<T>
    {
        public static async Task<T> LoadRecord(string url)
        {
            if (!ApiHelper.IsInitialized)
                ApiHelper.InitializeClient();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsAsync<T>();
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }
    }
    public class Processor
    {
        public static async Task<PlayerModel> LoadPlayerInfo(int allyCode = 0)
        {
            string url = $"https://swgoh.gg/api/player/{allyCode}/";
            return await GenericProcessor<PlayerModel>.LoadRecord(url);
        }

        public static async Task<CharacterModel> LoadCharacterInfo(int characterId)
        {
            string url = $"https://swgoh.gg/api/characters/{characterId}/";
            return await GenericProcessor<CharacterModel>.LoadRecord(url);
        }

        public static async Task<CharacterModel[]> LoadCharacterList()
        {
            string url = $"https://swgoh.gg/api/characters/";
            return await GenericProcessor<CharacterModel[]>.LoadRecord(url);
        }
    }
}
