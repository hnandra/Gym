Imports System.IO 'Required as we are reading and writing to files

Public Class CreateAccount
    Dim CustomersFile As String = "E:\Customers File.txt"
    Dim ManagersFile As String = "E:\Managers File.txt"
    Dim UsersFile As String = "E:\Users File File.txt"
    Dim temp As String

    Dim FirstName, LastName, Address, EmailAddress, Postcode, Password, PasswordConfirm, DateofBirth, Format_DateofBirth, pininput As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'IF Customers File Does Not Exist at this location, then create file and input heading
        If Not File.Exists(CustomersFile) Then

            Using NewLine As StreamWriter = File.CreateText(CustomersFile)
                NewLine.WriteLine("UserID" & ";" & " Password")
            End Using
        End If

        'IF Managers File Does Not Exist at this location, then create file and input the default pin for managers + headings.

        If Not File.Exists(ManagersFile) Then

            Using Newline As StreamWriter = File.CreateText(ManagersFile)
                Newline.WriteLine("UserID" & ";" & " Password")
            End Using
        End If

        'IF Managers File Does Not Exist at this location, then create file and input the default pin for managers + headings.

        If Not File.Exists(UsersFile) Then

            Using Newline As StreamWriter = File.CreateText(UsersFile)
                Newline.WriteLine("Username" + ";" + "FirstName" + ";" + "LastName" + ";" + "Address" + ";" + "EmailAddress" + ";" + "Postcode" + ";", "DateofBirth")
            End Using
        End If

    End Sub

    'Public Function User_ID_Create - Function 1
    Public Function User_ID_Create(ByVal FirstName As String, ByVal LastName As String, ByVal FDateofBirth As String)
        Return FirstName.Substring(0, 1) + LastName.Substring(0, 3) + "-" + Format_DateofBirth

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Local declaration as it will only be needed in this sub
        Dim Username As String
        Dim Validation As Boolean
        Validation = True

        'Save inputs from textboxes into variable names
        FirstName = Firsttextbox.Text
        LastName = Lastextbox.Text
        Address = Address2.Text
        EmailAddress = Email2.Text
        Postcode = Postcode2.Text
        Password = password2.Text
        PasswordConfirm = PasswordConfirm2.Text
        Format_DateofBirth = Format(DateTimePicker1.Value, "yyyy")
        pininput = pintextbox.text

        ' Checks if all textboxes have input in them
        Validation = False
        If FirstName = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
        ElseIf LastName = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
        ElseIf Address = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
        ElseIf EmailAddress = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
        ElseIf Postcode = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
        ElseIf (Password = "") Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
        End If


        If Password <> PasswordConfirm Then ' If passwords dont match then messagebox
            MsgBox("Passwords do not match, please try again")
            Validation = False

        ElseIf CustomerCheckBox.Checked And ManagerCheckbox.Checked Then
            MsgBox("Please only select one checkbox")
            Validation = False

        ElseIf Not CustomerCheckBox.Checked And Not ManagerCheckbox.Checked Then
            MsgBox("Pleaser declare yourself as a manager or customer")
            Validation = False

        ElseIf Len(Password) < 8 Then
            MsgBox("Password must be longer than 8 characters")
            Validation = False
        Else : Validation = True

        End If

        ' If user declares him/herself as a customer then:
        If Validation = True And CustomerCheckBox.Checked Then
            'Call Function, also provide three pieces of information
            Username = User_ID_Create(FirstName, LastName, Format_DateofBirth)
            MsgBox("Congratulations, you have successfuly created an Account with Hambrough Primary School as a Customer, Please note down your User ID:" + "" + Username)

            'Append all customer detail into Customers File
            Using Filewriter As StreamWriter = File.AppendText(CustomersFile)
                Filewriter.WriteLine(Username + ";" + Password)
            End Using

            'Append both Customer Personal data into one File
            Using Filewriter As StreamWriter = File.AppendText(UsersFile)
                Filewriter.WriteLine(Username + ";" + FirstName + ";" + LastName + ";" + Address + ";" + EmailAddress + ";" + Postcode + ";", DateTimePicker1)
            End Using

        End If

        If Validation = True And ManagerCheckbox.Checked And pininput <> "5758" Then

            MsgBox(" Incorrect Pin, please contact the headteacher to retrieve your pin")


        ElseIf Validation = True And ManagerCheckbox.Checked And pininput = "5758" Then

            'Call Function, also provide three pieces of information
            Username = User_ID_Create(FirstName, LastName, Format_DateofBirth)
            MsgBox("Congratulations, you have successfuly created an Account with Hambrough Primary School as a Manager, Please note down your User ID:" + "" + Username)
            'Append all managers login details into Managers File


            Using Filewriter As StreamWriter = File.AppendText(ManagersFile)
                Filewriter.WriteLine(Username + ";" + Password)
            End Using

            'Append both Customer and Managers Personal data into one File
            Using Filewriter As StreamWriter = File.AppendText(UsersFile)
                Filewriter.WriteLine(Username + ";" + FirstName + ";" + LastName + ";" + Address + ";" + EmailAddress + ";" + Postcode + ";", DateTimePicker1)
            End Using



            'If manager is signing up, however provides incorrect pin, then messagebox.


        End If
    End Sub

    
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Go back to previous form and hide this form
        My.Forms.LoginAccount.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' on button click, clear all the objects 
        Firsttextbox.Clear()
        Lastextbox.Clear()
        Address2.Clear()
        Email2.Clear()
        Postcode2.Clear()
        password2.Clear()
        PasswordConfirm2.Clear()
        pintextbox.Clear()
    End Sub
End Class

