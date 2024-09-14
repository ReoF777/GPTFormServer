using System.Text;
using System.Text.Json;
namespace frontend
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1 () {
            InitializeComponent();
        }

        private async void buttonSend_Click (object sender, EventArgs e) {
            string prompt = textBoxPrompt.Text;
            if(string.IsNullOrWhiteSpace(prompt))
            {
                MessageBox.Show("Prompt cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gbtResponse = await SendRequestToGPTAPI(prompt);

            textBoxResponse.Text = gbtResponse;
        }

        private async Task<string> SendRequestToGPTAPI(string prompt) {
            var url = "http://127.0.0.1:8000/gpt/";


            var requestData = new
            {
                prompt = prompt
            };

            var json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();

                // GPTの応答を取得
                var result = JsonSerializer.Deserialize<GPTResponse>(responseBody);
                if(result == null)
                {
                    return "エラーが発生";
                }
                else
                {
                    return result.Response;
                }
            }
            catch(Exception e)
            {
                return "エラーが発生";
            }
        }
    }

    public class GPTResponse
    {
        public required string Response { get; set; }
    }
}
