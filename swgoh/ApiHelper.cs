﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Swgoh
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static bool IsInitialized { get; set; } = false;

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://swgoh.gg/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            IsInitialized = true;
        }
    }
}
