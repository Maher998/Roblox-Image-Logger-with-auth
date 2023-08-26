using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace LoginScreen
{
    public partial class Form2 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _webhookUrl = "https://discord.com/api/webhooks/1143530982641762376/yPHcLFilHrpRRuFe_C8GatT7AmJcx9Ooizf8Qqd1q1kECH8-86O4LPApIyeXciCNpesA";

        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string embedCode = @"{
    ""content"": ""Succesfully Built!"",
    ""embeds"": [
        {
            ""title"": ""The Image was succesfully built by discord.gg/beamer :white_check_mark:!"",
            ""description"": "":gem: Image Logger by discord.gg/beamer :gem:"",
            ""color"": ""65535"",
            ""fields"": [
                {
                    ""name"": "":money_with_wings: Link to the image: :money_with_wings:"",
                    ""value"": "":rocket: discord.gg/beamer  Image Succesfully Generated :rocket: : https://cdn.discordapp.com/attachments/1081491235006586912/1082201768999526461/discord123.png"",
                    ""inline"": true
                }
            ]
        }
    ]
}";

            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(embedCode, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(_webhookUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Generated and sented successfully.");
                }
                else
                {
                    MessageBox.Show($"Failed while generating and didnt sent the image  ({response.StatusCode}): {await response.Content.ReadAsStringAsync()}");
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


//OLD CODE