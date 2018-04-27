Imports System.IO
Public Class LoginAccount
    Public Property GlobalUserID As String
    Public Property GlobalPassword As String


    Dim InputUserID, InputPassword As String
    Dim Reader As System.IO.TextReader
    Dim temp As String
    Dim CustomersFile As String = Application.StartupPath & "\Customers File.txt"
    Dim ManagersFile As String = Application.StartupPath & "\Managers File.txt"
    Dim UsersFile As String = Application.StartupPath & "\Users File.txt"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        InputUserID = UserIDtextbox.Text
        InputPassword = Passwordtextbox.Text

        ' Open the file to read from. 

        Dim Login = IO.File.ReadAllText(CustomersFile)
        Dim ManagerLogin = IO.File.ReadAllText(ManagersFile)
        Dim Allentered As Boolean
        Allentered = True

        'If either of the textboxes are empty, users will be told to enter missing info
        If InputUserID = "" Then
            Allentered = False
            MsgBox("Please Enter User-ID")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form

        ElseIf InputPassword = "" Then
            Allentered = False
            MsgBox("Please Enter Password")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form

        Else : Allentered = True


        End If
        'IF details provided exist in customersfile, then forward user to Customers Form
        If Allentered = True And Login.Contains(InputUserID + ";" + InputPassword) Then
            Me.Hide()
            My.Forms.CustomersForm.Show()
            MsgBox("Welcome")
            GlobalUserID = InputUserID 'if the login details exist, the user ID will be stored i this gloval variable so that it can be used in another form if needed.
            GlobalPassword = InputPassword 'if the login details exist, the user ID will be stored i this gloval variable so that it can be used in another form if needed.

            'If detailes provided exist in managers file, then forward user to managers form
        ElseIf Allentered = True And ManagerLogin.Contains(InputUserID + ";" + InputPassword) Then
            Me.Hide()
            My.Forms.Managers.Show()
            MsgBox("Welcome")

            'If details dont exist in either file, then tell user that credentials are incorrect.
        Else : MsgBox(" Your Log-In details are not recognised")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form

        End If



    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.CreateAccount.Show()
        Me.Hide()
    End Sub
End Class
