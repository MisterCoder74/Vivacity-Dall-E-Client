<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DallEClient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DallEClient))
        Me.btnSend = New System.Windows.Forms.Button()
        Me.PromptTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.ApiKeyTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSend.Location = New System.Drawing.Point(722, 108)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(102, 25)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send request"
        Me.ToolTip1.SetToolTip(Me.btnSend, "Send Prompt")
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'PromptTextBox
        '
        Me.PromptTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PromptTextBox.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptTextBox.Location = New System.Drawing.Point(0, 0)
        Me.PromptTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PromptTextBox.Multiline = True
        Me.PromptTextBox.Name = "PromptTextBox"
        Me.PromptTextBox.Size = New System.Drawing.Size(829, 72)
        Me.PromptTextBox.TabIndex = 1
        Me.PromptTextBox.Text = "Insert prompt here"
        '
        'saveBtn
        '
        Me.saveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.saveBtn.BackColor = System.Drawing.Color.Transparent
        Me.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveBtn.Location = New System.Drawing.Point(415, 174)
        Me.saveBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(102, 25)
        Me.saveBtn.TabIndex = 25
        Me.saveBtn.Text = "Save Image"
        Me.ToolTip1.SetToolTip(Me.saveBtn, "Send Prompt")
        Me.saveBtn.UseVisualStyleBackColor = False
        Me.saveBtn.Visible = False
        '
        'ApiKeyTextBox
        '
        Me.ApiKeyTextBox.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApiKeyTextBox.Location = New System.Drawing.Point(4, 107)
        Me.ApiKeyTextBox.Name = "ApiKeyTextBox"
        Me.ApiKeyTextBox.Size = New System.Drawing.Size(461, 25)
        Me.ApiKeyTextBox.TabIndex = 19
        Me.ApiKeyTextBox.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-314, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "API Key"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(4, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 459)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(4, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "OpenAI API Key:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(4, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Image preview"
        '
        'logTxt
        '
        Me.logTxt.BackColor = System.Drawing.Color.White
        Me.logTxt.Location = New System.Drawing.Point(525, 202)
        Me.logTxt.Multiline = True
        Me.logTxt.Name = "logTxt"
        Me.logTxt.ReadOnly = True
        Me.logTxt.Size = New System.Drawing.Size(299, 455)
        Me.logTxt.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(522, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Activity log:"
        '
        'DallEClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 669)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.logTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ApiKeyTextBox)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.PromptTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "DallEClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vivacity Dall-E Client"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents PromptTextBox As TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ApiKeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents saveBtn As System.Windows.Forms.Button
End Class
