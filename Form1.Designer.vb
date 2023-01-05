<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TheApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheApp))
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SSHConfirmLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IPBox = New System.Windows.Forms.TextBox()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.IPLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.CopyClipboardButton = New System.Windows.Forms.Button()
        Me.ToolTipThing = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConnectButton
        '
        Me.ConnectButton.Enabled = False
        Me.ConnectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ConnectButton.Location = New System.Drawing.Point(217, 64)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 11
        Me.ConnectButton.Text = "Connect"
        Me.ToolTipThing.SetToolTip(Me.ConnectButton, "Execute SSH with the arguments.")
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSHConfirmLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 96)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(304, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.ToolTipThing.SetToolTip(Me.StatusStrip1, "Amogus.")
        '
        'SSHConfirmLabel
        '
        Me.SSHConfirmLabel.Name = "SSHConfirmLabel"
        Me.SSHConfirmLabel.Size = New System.Drawing.Size(90, 17)
        Me.SSHConfirmLabel.Text = "SSH Checking..."
        '
        'IPBox
        '
        Me.IPBox.Enabled = False
        Me.IPBox.Location = New System.Drawing.Point(74, 38)
        Me.IPBox.Name = "IPBox"
        Me.IPBox.Size = New System.Drawing.Size(218, 20)
        Me.IPBox.TabIndex = 9
        Me.ToolTipThing.SetToolTip(Me.IPBox, "Hostnames can also be used. If required, specify port as well.")
        '
        'UsernameBox
        '
        Me.UsernameBox.Enabled = False
        Me.UsernameBox.Location = New System.Drawing.Point(74, 12)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(218, 20)
        Me.UsernameBox.TabIndex = 8
        Me.ToolTipThing.SetToolTip(Me.UsernameBox, "If empty, 'root' is assumed as username.")
        '
        'IPLabel
        '
        Me.IPLabel.AutoSize = True
        Me.IPLabel.Enabled = False
        Me.IPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.IPLabel.Location = New System.Drawing.Point(10, 41)
        Me.IPLabel.Name = "IPLabel"
        Me.IPLabel.Size = New System.Drawing.Size(58, 13)
        Me.IPLabel.TabIndex = 7
        Me.IPLabel.Text = "IP Address"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Enabled = False
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.UsernameLabel.Location = New System.Drawing.Point(10, 15)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "Username"
        '
        'CopyClipboardButton
        '
        Me.CopyClipboardButton.Enabled = False
        Me.CopyClipboardButton.Location = New System.Drawing.Point(101, 64)
        Me.CopyClipboardButton.Name = "CopyClipboardButton"
        Me.CopyClipboardButton.Size = New System.Drawing.Size(110, 23)
        Me.CopyClipboardButton.TabIndex = 12
        Me.CopyClipboardButton.Text = "Copy To Clipboard"
        Me.ToolTipThing.SetToolTip(Me.CopyClipboardButton, "Copy command to clipboard.")
        Me.CopyClipboardButton.UseVisualStyleBackColor = True
        '
        'NotifIcon
        '
        Me.NotifIcon.Text = "NotifyIcon1"
        '
        'TheApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 118)
        Me.Controls.Add(Me.CopyClipboardButton)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.IPBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.IPLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TheApp"
        Me.Text = "SSHelper"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SSHConfirmLabel As ToolStripStatusLabel
    Friend WithEvents IPBox As TextBox
    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents IPLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents CopyClipboardButton As Button
    Friend WithEvents ToolTipThing As ToolTip
    Friend WithEvents NotifIcon As NotifyIcon
End Class
