using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Net.Http.Headers;

namespace FitFusion.Presentation.AI;

public class FitFusionAnalyzer
{
    private readonly string _apiUrl;
    private readonly string apiKey;
    private readonly RestClient _client;
    private readonly HttpClient _httpClient;
    private readonly string _geminiApi;
    public FitFusionAnalyzer()
    {
         
         apiKey = "AIzaSyDx_vjRV5wWp2owfGNmQ0TDD2TiFeLuGhI";
        _apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=AIzaSyDx_vjRV5wWp2owfGNmQ0TDD2TiFeLuGhI";
        _client = new RestClient(_apiUrl);

        _geminiApi = "https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=AIzaSyDx_vjRV5wWp2owfGNmQ0TDD2TiFeLuGhI";



        _httpClient = new HttpClient();
    }




    public async Task<string> SendRequestAndGetResponse(string userInput)
    {
        string jsonBody = $@"{{
                ""contents"": [
                    {{
                        ""role"": """",
                        ""parts"": [
                            {{
                                ""text"": ""{userInput}""
                            }}
                        ]
                    }}
                ],
                ""generationConfig"": {{
                    ""temperature"": 0.9,
                    ""topK"": 50,
                    ""topP"": 0.95,
                    ""maxOutputTokens"": 4096,
                    ""stopSequences"": []
                }},
                ""safetySettings"": [

                ]
            }}
        ";

        using var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.0-pro:generateContent?key={apiKey}");
        request.Content = new StringContent(jsonBody, Encoding.UTF8);
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await client.SendAsync(request).ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody.Substring(responseBody.IndexOf("\"text\": \"") + 9, responseBody.IndexOf("\"", responseBody.IndexOf("\"text\": \"") + 10) - responseBody.IndexOf("\"text\": \"") - 9);
        }
        else
        {
            return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
        }
    }

























    public async Task<string> GenerateContentAsync(string inputText)
    {
        var requestData = new
        {
            input = new
            {
                text = inputText
            }
        };

        var jsonRequest = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(_geminiApi, content);
        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return jsonResponse;
        }
        else
        {
            Console.WriteLine("Gem API request failed with status code: " + response.StatusCode);
            return null;
        }
    }
}



















//public string AnalyzeMeal(double proteinAmount, double fatAmount, double carbohydrateAmount, int caloriesAmount)
//    {
//        var request = new RestRequest("POST") ;
//        request.AddHeader("Authorization", "Bearer " + _apiKey);
//        request.AddHeader("Content-Type", "application/json");
//        request.AddParameter("protein", proteinAmount);
//        request.AddParameter("yağ", fatAmount);
//        request.AddParameter("karbonhidrat", carbohydrateAmount);
//        request.AddParameter("toplam kalori", caloriesAmount);

//        var fitFusionAnalysisResult = new FitFusionAnalysisResult()
//        {
//            Protein = proteinAmount,
//            Fat = fatAmount,
//            Carbonhydrate = carbohydrateAmount,
//            Calories=caloriesAmount
           
//        };
//        var jsonBody = JsonConvert.SerializeObject(fitFusionAnalysisResult);
//        request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

//        var response = _client.Execute(request);
//        if (response.IsSuccessful)
//        {
//            return response.Content;
//        }
//        else
//        {
//            MessageBox.Show("API isteği başarısız oldu. Hata kodu: " + response.StatusCode);
//            return null;
//        }
   //}


