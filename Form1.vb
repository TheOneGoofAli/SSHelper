Public Class TheApp
    Public Function GetOSVersion() As String
        'Where are we running?
        Select Case Environment.OSVersion.Platform
            Case PlatformID.Win32S
                Return "Win3.1x"
            Case PlatformID.Win32Windows
                Select Case Environment.OSVersion.Version.Minor
                    Case 0
                        Return "Win95"
                    Case 10
                        Return "Win98"
                    Case 90
                        Return "WinME"
                    Case Else
                        Return "Unknown"
                End Select
            Case PlatformID.Win32NT
                Select Case Environment.OSVersion.Version.Major
                    Case 3
                        Return "NT3.51"
                    Case 4
                        Return "NT4"
                    Case 5
                        Select Case _
                        Environment.OSVersion.Version.Minor
                            Case 0
                                Return "Win2000"
                            Case 1
                                Return "WinXP"
                            Case 2
                                Return "Win2003"
                        End Select
                    Case 6
                        Select Case _
                        Environment.OSVersion.Version.Minor
                            Case 0
                                Return "WinVista/2008"
                            Case 1
                                Return "Win7/2008R2"
                            Case 2
                                Return "Win8/2012"
                            Case 3
                                Return "Win8.1/2012R2+"
                        End Select
                    Case Else
                        Return "Unknown"
                End Select
            Case PlatformID.WinCE
                Return "WinCE"
            Case Else
                Return "Unknown"
        End Select
        Return "Unknown"
    End Function
    Public OSVersion As String = GetOSVersion()

    Private Sub TheApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SSHConfirmLabel.Image = My.Resources.ok.ToBitmap
        SSHConfirmLabel.Text = "Ready."
        UsernameBox.Enabled = True
        UsernameLabel.Enabled = True
        IPBox.Enabled = True
        IPLabel.Enabled = True
        NotifIcon.Icon = My.Resources.neticon
        NotifIcon.Text = "SSHelper"
        NotifIcon.Visible = True
    End Sub

    Private Sub IPBox_TextChanged(sender As Object, e As EventArgs) Handles IPBox.TextChanged
        If IPBox.Text = String.Empty Then
            ConnectButton.Enabled = False
            CopyClipboardButton.Enabled = False
        Else
            ConnectButton.Enabled = True
            CopyClipboardButton.Enabled = True
        End If
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Dim User As String
        Dim IP As String = IPBox.Text.ToString
        Dim ExecLine As String
        Dim sb As New System.Text.StringBuilder()
        If Not UsernameBox.Text = String.Empty Then
            User = UsernameBox.Text & "@"
        Else
            User = "root@"
        End If
        ExecLine = sb.Append("ssh").Append(" ").Append(User).Append(IP).ToString
        Try
            Shell(ExecLine, AppWinStyle.NormalFocus)
            SSHConfirmLabel.Image = My.Resources.run.ToBitmap
            SSHConfirmLabel.Text = "SSH instance started."
        Catch
            Dim Texty As String = "Error starting SSH."
            SSHConfirmLabel.Image = My.Resources.warn.ToBitmap
            'As we are using .NET Framework 2.0, we can be ran under older systems.
            'So, why not flavor in some text messages?
            Select Case OSVersion
                Case "Win95"
                    Texty = "SSH ain't budging on 95!"
                Case "Win98"
                    Texty = "Expected SSH to run on 98? Maybe with KernelEx..."
                Case "WinME"
                    Texty = "SSH couldn't start on Windows Millenium."
                Case "Win2000"
                    Texty = "Error starting SSH on Windows 2000."
                Case "WinXP"
                    Texty = "Couldn't eXPerience SSH on Windows XP."
                Case "Win2003"
                    Texty = "Error starting SSH on Windows Server 2003/XP x64."
            End Select
            SSHConfirmLabel.Text = Texty
        End Try
    End Sub

    Private Sub CopyClipboardButton_Click(sender As Object, e As EventArgs) Handles CopyClipboardButton.Click
        Dim User As String
        Dim IP As String = IPBox.Text.ToString
        Dim Output As String
        Dim sb As New System.Text.StringBuilder()
        If Not UsernameBox.Text = String.Empty Then
            User = sb.Append(UsernameBox.Text).Append("@").ToString
        Else
            User = "root@"
        End If
        Output = sb.Append("ssh").Append(" ").Append(User).Append(IP).ToString
        My.Computer.Clipboard.SetText(Output)
        SSHConfirmLabel.Image = My.Resources.write.ToBitmap
        SSHConfirmLabel.Text = "Copied command to clipboard."
    End Sub
End Class
