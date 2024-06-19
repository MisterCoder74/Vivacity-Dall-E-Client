Imports System.Net
Imports System.IO
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Net.SecurityProtocolType
Imports System.Threading.Tasks
Imports System.ComponentModel


Public Class DallEClient


    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        logTxt.Text = "Sending request..." & vbCrLf

        System.Net.ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)

        Dim apiEndpoint As String = "https://api.openai.com/v1/images/generations"
        Dim apiKey As String = ApiKeyTextBox.Text
        Dim prompt As String = PromptTextBox.Text
        Dim model As String = "dall-e-2"
        Dim numberofimages As String = "1"
        Dim imagesize As String = "512x512"

        ' Creation of HTTP request
        Dim request As HttpWebRequest = WebRequest.Create(apiEndpoint)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & apiKey)

        ' Creation of JSON request
        Dim data As String = "{"
        data += " ""model"": """ & model & ""","
        data += " ""prompt"": """ & prompt & ""","
        data += " ""n"": 1,"
        data += " ""size"": """ & imagesize & """"
        data += "}"
        logTxt.Text += "Request grammar: " & data.ToString & vbCrLf
        ' Write body of request
        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(data)

        End Using

        ' Getting a response
        Dim response As HttpWebResponse = Nothing

        Try
            response = CType(request.GetResponse(), HttpWebResponse)

            'Getting JSON format
            Dim responseStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(responseStream)
            Dim jsonResponse As String = reader.ReadToEnd()
            logTxt.Text += "Receiving response..." & vbCrLf

            reader.Close()
            responseStream.Close()

            'Deserializing JSON response
            Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
            Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(jsonResponse)
            logTxt.Text += "Response received: " & jsonResponse.ToString & vbCrLf

            'Extracting the image URL
            Dim imageUrl As String = oJson("data")(0)("url").ToString()

            ' Visualizing the image
            Dim imageClient As New WebClient()
            Dim imageData As Byte() = imageClient.DownloadData(imageUrl)

            Using ms As New MemoryStream(imageData)
                PictureBox1.Image = Image.FromStream(ms)
            End Using
            saveBtn.Visible = True

        Catch ex As WebException
            'simple error handling
            MessageBox.Show("Web error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If response IsNot Nothing Then
                response.Close()
            End If
        End Try

    End Sub

    Private Sub PromptTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromptTextBox.Click
        PromptTextBox.Text = ""
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveBtn.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "JPG Image|*.jpg"
            saveDialog.Title = "Save Image"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(saveDialog.FileName, Imaging.ImageFormat.Jpeg)
                MessageBox.Show("Imge saved correctly!", "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Image could not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
