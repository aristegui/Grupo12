Imports System.Net.NetworkCredentials
Imports System.Net.Mail
Class Class1
    Public Function enviarEmail(email As String, url As String
                                ) As Boolean
        Try
            Dim msg = New MailMessage()
            msg.To.Add(New MailAddress(email, "HADS"))
            msg.From = New MailAddress("xpersona001@ikasle.ehu.eus", "HADS")
            msg.Subject = "Confirmación de registro"
            msg.Body = url

            msg.IsBodyHtml = True
            Dim client = New SmtpClient()
            client.UseDefaultCredentials = False
            client.Credentials = New System.Net.NetworkCredential("839403", "RM3D2kt6")
            client.Port = 587
            client.Host = "smtp.ehu.eus"
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            client.EnableSsl = True
            client.Send(msg)
        Catch
            Return False
        End Try
        Return True
    End Function
    Public Function enviarPassNuevo(email As String) As Boolean
        Try
            Dim msg = New MailMessage()
            msg.To.Add(New MailAddress(email, "HADS"))
            msg.From = New MailAddress("xpersona001@ikasle.ehu.eus", "HADS")
            msg.Subject = "Recuperación del password"
            msg.Body = "Tú codigo para el cambio de contraseña es el siguiente: 123456"
            msg.IsBodyHtml = True
            Dim client = New SmtpClient()
            client.UseDefaultCredentials = False
            client.Credentials = New System.Net.NetworkCredential("839403", "RM3D2kt6")
            client.Port = 587
            client.Host = "smtp.ehu.eus"
            client.DeliveryMethod = SmtpDeliveryMethod.Network
            client.EnableSsl = True
            client.Send(msg)
        Catch
            Return False
        End Try
        Return True
    End Function
End Class
