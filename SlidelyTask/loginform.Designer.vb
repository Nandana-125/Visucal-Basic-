<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        textUsername = New TextBox()
        textPassword = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(184, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 23)
        Label1.TabIndex = 0
        Label1.Text = "Login System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10.2F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(37, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 21)
        Label2.TabIndex = 1
        Label2.Text = "Username :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.2F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(37, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 21)
        Label3.TabIndex = 2
        Label3.Text = "Password  :"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' textUsername
        ' 
        textUsername.BorderStyle = BorderStyle.FixedSingle
        textUsername.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textUsername.Location = New Point(146, 68)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(313, 26)
        textUsername.TabIndex = 4
        ' 
        ' textPassword
        ' 
        textPassword.BorderStyle = BorderStyle.FixedSingle
        textPassword.Font = New Font("Wingdings", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        textPassword.Location = New Point(146, 113)
        textPassword.Name = "textPassword"
        textPassword.PasswordChar = "|"c
        textPassword.Size = New Size(313, 22)
        textPassword.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(191, 154)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(130, 35)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(344, 154)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(130, 35)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(486, 253)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(textPassword)
        Controls.Add(textUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "loginform"
        Text = "Login Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents textUsername As TextBox
    Friend WithEvents textPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button

End Class
