using MarqPontoExtension.Commands;
using MarqPontoExtension.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarqPontoExtension.Requests
{
    public class DataRequest
    {
        private const string Error = "Tivemos algum problema com o servidor, não se preocupe, nosso exército de robos já está fixando o erro: ";

        public static async Task<dynamic> GetById(string endpoint, string id)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(endpoint + id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<Employe>(json);
                    }
                    else
                    {
                        throw new Exception(Error + response.StatusCode);
                    }
                }
            }
        }

        public static async Task<dynamic> GetAll(string endpoint, string token = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(endpoint);

                    if (!string.IsNullOrEmpty(token))
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                      //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    using (var response = await client.GetAsync(endpoint))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject(json);
                        }
                        else
                        {
                            throw new Exception(Error + response.StatusCode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro com servidor");
                return null;
            }
        }

        public static async Task<dynamic> Post(string endpoint, dynamic command)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var serialize = JsonConvert.SerializeObject(command);
                    var content = new StringContent(serialize, Encoding.UTF8, "application/json");
                    using (var response = await client.PostAsync(endpoint, content))

                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject(json);
                        }
                        else
                        {
                            throw new Exception(Error + response.StatusCode);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Error + e, "Erro com servidor");
                return null;
            }
        }

        public static async Task<SecurityCommand> Authenticate(string endpoint, string login, string pass)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = TimeSpan.FromMinutes(30);

                    var request = new HttpRequestMessage(HttpMethod.Post, endpoint);

                    var command = new List<KeyValuePair<string, string>>();

                    command.Add(new KeyValuePair<string, string>("grant_type", "password"));
                    command.Add(new KeyValuePair<string, string>("username", login));
                    command.Add(new KeyValuePair<string, string>("password", pass));

                    request.Content = new FormUrlEncodedContent(command);

                    using (var response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            return JsonConvert.DeserializeObject<SecurityCommand>(json);
                        }
                        else
                        {
                            throw new Exception(response.StatusCode.ToString());
                        }
                    }                
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Error + Environment.NewLine + Environment.NewLine + e, "Erro com servidor");
                return null;
            }
        }
    }
}
