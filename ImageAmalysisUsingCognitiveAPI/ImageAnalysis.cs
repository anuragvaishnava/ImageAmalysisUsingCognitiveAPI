using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAmalysisUsingCognitiveAPI
{
    public partial class LabelKeys : Form
    {
        
        public LabelKeys()
        {
            InitializeComponent();

        }

        private void ButtonAnalyze_Click(object sender, EventArgs e)
        {
            string imageFilePath = TextFilePath.Text;
            string Keys = TextKeys.Text;
            MakeRequest(imageFilePath, Keys);
        }

        private byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }


        private string CreateRequestParams()
        {
            string urlAppend = "";
            if (RadioButtonAnalyze.Checked)
            {
                urlAppend = "analyze?visualFeatures=Categories&language=en";

            }
            else if (RadioButtonDescr.Checked)
            { 
                urlAppend="describe?maxCandidates=1";

            }
            else 
            {
               urlAppend= "recognizeText?handwriting=true";

            }
            return urlAppend;
        }

        private async void MakeRequest(string imageFilePath,string Keys)
        {
            var client = new HttpClient();

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "7c8a61c749a84d6e98698c435001e2b6");
            string uri = "https://westus.api.cognitive.microsoft.com/vision/v1.0/" + CreateRequestParams();

            HttpResponseMessage response;
            string responseContent;

            // Request body. Try this sample with a locally stored JPEG image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (var content = new ByteArrayContent(byteData))
            {
                // This example uses content type "application/octet-stream".
                // The other content types you can use are "application/json" and "multipart/form-data".
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                
                response = await client.PostAsync(uri, content);
                responseContent = response.Content.ReadAsStringAsync().Result;
            }

            //A peak at the JSON response.
            LabelResult.Text=responseContent;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            FileDialog.InitialDirectory = @"C:\databackup h157077\Anurag\Development\ImageAmalysisUsingCognitiveAPI\Images";
            FileDialog.Title = "Browse Images";

            FileDialog.CheckFileExists = true;
            FileDialog.CheckPathExists = true;

            if (FileDialog.ShowDialog()==DialogResult.OK)
            {
                TextFilePath.Text = FileDialog.FileName;
                picture.ImageLocation = FileDialog.FileName;
            }            

        }

     
    }
}
