using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RL_ReplayManager
{
    class BallChasing
    {

        public static string PingResponse = "";
        public static async Task PingAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://ballchasing.com/api/"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", Program.form.ReadToken());

                    var response = await httpClient.SendAsync(request);

                    // Get the response content.
                    HttpContent responseContent = response.Content;

                    // Get the stream of the content.
                    using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                    {
                        // Write the output.
                        PingResponse = await reader.ReadToEndAsync();
                        Console.WriteLine(PingResponse);

                        Program.form.LogAddText(Environment.NewLine + "> " + PingResponse);
                        Program.form.LogAddText(Environment.NewLine + "- - - - -");

                    }
                }
            }

        }

        public static async Task UploadAsync(string Visibility, string FilePath)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://ballchasing.com/api/upload?visibility=" + Visibility))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", Program.form.ReadToken());

                    var multipartContent = new MultipartFormDataContent();
                    multipartContent.Add(new ByteArrayContent(File.ReadAllBytes(FilePath)), "file", Path.GetFileName(FilePath));
                    request.Content = multipartContent;

                    var response = await httpClient.SendAsync(request);

                    // Get the response content.
                    HttpContent responseContent = response.Content;
                    Console.WriteLine("!");
                    // Get the stream of the content.
                    using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                    {
                        Console.WriteLine("!!");
                        // Write the output.
                        PingResponse = await reader.ReadToEndAsync();
                        
                        Console.WriteLine(PingResponse);
                        if(PingResponse == "")
                        {
                            Program.form.LogAddText(Environment.NewLine + "> Sucessfully uploaded file to BallChasing.com");
                        }
                        else
                        {
                            Program.form.LogAddText(Environment.NewLine + "> " + PingResponse);
                        }

                    }
                }
            }

        }

    }
}
