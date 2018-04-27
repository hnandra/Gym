<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pintextbox = New System.Windows.Forms.TextBox()
        Me.Firsttextbox = New System.Windows.Forms.TextBox()
        Me.Lastextbox = New System.Windows.Forms.TextBox()
        Me.password2 = New System.Windows.Forms.TextBox()
        Me.passwordconfirm2 = New System.Windows.Forms.TextBox()
        Me.address2 = New System.Windows.Forms.TextBox()
        Me.postcode2 = New System.Windows.Forms.TextBox()
        Me.email2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ManagerCheck = New System.Windows.Forms.RadioButton()
        Me.CustomerCheck = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Creating an account:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PIN (Managers Only):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(170, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Birth*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(173, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Address*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(170, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Postcode*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(170, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Email*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(243, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Are you a manager or a customer?*"
        '
        'pintextbox
        '
        Me.pintextbox.Location = New System.Drawing.Point(123, 284)
        Me.pintextbox.Name = "pintextbox"
        Me.pintextbox.Size = New System.Drawing.Size(122, 20)
        Me.pintextbox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.pintextbox, "Only for Managers")
        '
        'Firsttextbox
        '
        Me.Firsttextbox.Location = New System.Drawing.Point(14, 70)
        Me.Firsttextbox.Name = "Firsttextbox"
        Me.Firsttextbox.Size = New System.Drawing.Size(124, 20)
        Me.Firsttextbox.TabIndex = 15
        '
        'Lastextbox
        '
        Me.Lastextbox.Location = New System.Drawing.Point(14, 112)
        Me.Lastextbox.Name = "Lastextbox"
        Me.Lastextbox.Size = New System.Drawing.Size(124, 20)
        Me.Lastextbox.TabIndex = 16
        '
        'password2
        '
        Me.password2.Location = New System.Drawing.Point(14, 152)
        Me.password2.Name = "password2"
        Me.password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password2.Size = New System.Drawing.Size(124, 20)
        Me.password2.TabIndex = 17
        Me.ToolTip2.SetToolTip(Me.password2, "Passwords must be greater than 8 chaarcters, Must contain atleast 1 number. Passw" &
        "ord will be invalid if it contains your first name or last name. Case Senstive ")
        Me.ToolTip1.SetToolTip(Me.password2, "Passwordas must be greater than 8 chaarcters, Must contain atleast 1 symbol, 1 nu" &
        "mber. Password will be invalid if it contains your first name or last name. Case" &
        " Senstive ")
        '
        'passwordconfirm2
        '
        Me.passwordconfirm2.Location = New System.Drawing.Point(12, 194)
        Me.passwordconfirm2.Name = "passwordconfirm2"
        Me.passwordconfirm2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordconfirm2.Size = New System.Drawing.Size(126, 20)
        Me.passwordconfirm2.TabIndex = 18
        '
        'address2
        '
        Me.address2.Location = New System.Drawing.Point(173, 70)
        Me.address2.Name = "address2"
        Me.address2.Size = New System.Drawing.Size(124, 20)
        Me.address2.TabIndex = 19
        '
        'postcode2
        '
        Me.postcode2.Location = New System.Drawing.Point(173, 112)
        Me.postcode2.Name = "postcode2"
        Me.postcode2.Size = New System.Drawing.Size(124, 20)
        Me.postcode2.TabIndex = 20
        '
        'email2
        '
        Me.email2.Location = New System.Drawing.Point(173, 152)
        Me.email2.Name = "email2"
        Me.email2.Size = New System.Drawing.Size(124, 20)
        Me.email2.TabIndex = 21
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(173, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 22
        Me.DateTimePicker1.Value = New Date(2016, 12, 9, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(161, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 33)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Sign up"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to proceed")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(104, 363)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 33)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Button2, "Clear All Textboxes")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(27, 324)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 33)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.Button3, "Return to Home Page")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ManagerCheck
        '
        Me.ManagerCheck.AutoSize = True
        Me.ManagerCheck.Location = New System.Drawing.Point(12, 258)
        Me.ManagerCheck.Name = "ManagerCheck"
        Me.ManagerCheck.Size = New System.Drawing.Size(67, 17)
        Me.ManagerCheck.TabIndex = 27
        Me.ManagerCheck.TabStop = True
        Me.ManagerCheck.Text = "Manager"
        Me.ManagerCheck.UseVisualStyleBackColor = True
        '
        'CustomerCheck
        '
        Me.CustomerCheck.AutoSize = True
        Me.CustomerCheck.Location = New System.Drawing.Point(13, 284)
        Me.CustomerCheck.Name = "CustomerCheck"
        Me.CustomerCheck.Size = New System.Drawing.Size(69, 17)
        Me.CustomerCheck.TabIndex = 28
        Me.CustomerCheck.TabStop = True
        Me.CustomerCheck.Text = "Customer"
        Me.CustomerCheck.UseVisualStyleBackColor = True
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(311, 405)
        Me.Controls.Add(Me.CustomerCheck)
        Me.Controls.Add(Me.ManagerCheck)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.email2)
        Me.Controls.Add(Me.postcode2)
        Me.Controls.Add(Me.address2)
        Me.Controls.Add(Me.passwordconfirm2)
        Me.Controls.Add(Me.password2)
        Me.Controls.Add(Me.Lastextbox)
        Me.Controls.Add(Me.Firsttextbox)
        Me.Controls.Add(Me.pintextbox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateAccount"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pintextbox As System.Windows.Forms.TextBox
    Friend WithEvents Firsttextbox As System.Windows.Forms.TextBox
    Friend WithEvents Lastextbox As System.Windows.Forms.TextBox
    Friend WithEvents password2 As System.Windows.Forms.TextBox
    Friend WithEvents passwordconfirm2 As System.Windows.Forms.TextBox
    Friend WithEvents address2 As System.Windows.Forms.TextBox
    Friend WithEvents postcode2 As System.Windows.Forms.TextBox
    Friend WithEvents email2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As Button
    Friend WithEvents ManagerCheck As RadioButton
    Friend WithEvents CustomerCheck As RadioButton
End Class
