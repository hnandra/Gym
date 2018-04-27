Imports System.IO 'Required as we are reading and writing to files

Public Class CreateAccount
    Dim CustomersFile As String = Application.StartupPath & "\Customers File.txt"
    Dim ManagersFile As String = Application.StartupPath & "\Managers File.txt"
    Dim UsersFile As String = Application.StartupPath & "\Users File.txt"
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
                Newline.WriteLine("Username" + " ; " + "FirstName" + " ; " + "LastName" + " ; " + "Address" + " ; " + "Postcode" + " ; " + "EmailAddress" + " ; " + "DateofBirth")
            End Using
        End If

    End Sub

    'Public Function User_ID_Create - Function 1
    Public Function User_ID_Create(ByVal FirstName As String, ByVal LastName As String, ByVal FDateofBirth As String)
        Return FirstName.Substring(0, 1) + LastName.Substring(0, 3) + "-" + Format_DateofBirth

    End Function

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Local declaration as it will only be needed in this sub
        Dim Username As String
        Dim Validation As Boolean
        Validation = True
        Dim LastnameLength As Boolean = True
        Dim Age As Integer

        'Save inputs from textboxes into variable names
        FirstName = Firsttextbox.Text
        LastName = Lastextbox.Text
        Address = address2.Text
        EmailAddress = email2.Text
        Postcode = postcode2.Text
        Password = password2.Text
        PasswordConfirm = passwordconfirm2.Text
        Format_DateofBirth = Format(DateTimePicker1.Value, "yyyy")
        pininput = pintextbox.Text
        Age = Format(DateTimePicker1.Value, "yyyy")



        ' If last name is 2 characters, then add one x
        If LastName.Length = 2 Then
            LastName = LastName.Insert(2, "x")
            LastnameLength = True

            ' If last name is 1 character, then add two x's
        ElseIf LastName.Length = 1 Then
            LastName = LastName.Insert(1, "xx")
            LastnameLength = True

            'IF last name = 0 characters, message box to enter last name
        ElseIf LastName.Length = 0 Then
            MsgBox("Please check all relevant fields are filled")
            LastnameLength = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form


        End If

        ' Checks if all textboxes have input in them
        Validation = False
        If FirstName = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        ElseIf Address = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form 
        ElseIf Postcode = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")
            Validation = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If


        If Password <> PasswordConfirm Then ' If passwords dont match then messagebox
            MsgBox("Passwords do not match, please try again")
            Validation = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form

        ElseIf customercheck.Checked And Managercheck.Checked Then ' IF BOTH CHECKBOXES HAVE BEEN SELECTED
            MsgBox("Please only select one checkbox") ' MESSAGE BOX
            Validation = False                        ' SET VALIDATION TO FALSE TO HALT THE PROGRAM
            Return 'PROGRAM will stop executing the following code, user can only return back to the form

        ElseIf Not customercheck.Checked And Not Managercheck.Checked Then 'IF NO CHECKBOX IS CHECKED
            MsgBox("Pleaser declare yourself as a manager or customer") 'MESSAGEBOX TO MAKE USER AWARE OF THUS
            Validation = False                                          ' SET VALIDATION TO FALSE TO HALT THE PROGRAM
            Return 'PROGRAM will stop executing the following code, user can only return back to the form

        ElseIf Len(Password) < 8 Then
            MsgBox("Password must be longer than 8 characters")
            Validation = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        Else : Validation = True

        End If

        'Validation rule - The password entered cannot contain the first name or last name
        If Password.Contains(FirstName) Or Password.Contains(LastName) Then
            Validation = False
            MsgBox("Your password cannot contain your first name or last name")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        Else : Validation = True
        End If



        'Validation rule - The password entered must contain either of the following numbers
        If Password.Contains("1") Then
            Validation = True
        ElseIf Password.Contains("2") Then
            Validation = True
        ElseIf Password.Contains("3") Then
            Validation = True
        ElseIf Password.Contains("4") Then
            Validation = True
        ElseIf Password.Contains("5") Then
            Validation = True
        ElseIf Password.Contains("6") Then
            Validation = True
        ElseIf Password.Contains("7") Then
            Validation = True
        ElseIf Password.Contains("8") Then
            Validation = True
        ElseIf Password.Contains("9") Then
            Validation = True
        ElseIf Password.Contains("0") Then
            Validation = True
        Else
            MsgBox("Your password must contain a number")   ' Else an error message will appear
            Validation = False
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If




        'Validation rule - you must be greater than 18 to apply 
        If Age > 2000 Then
            Validation = False
            MsgBox(" You must be over 18 to apply")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If

        'If the email address does not contain the symbol @, then halt the program and display a messagebox.
        If Not EmailAddress.Contains("@") Then
            Validation = False   ' Set validation to false to prevent the program from continuing. 
            MsgBox("Please enter a valid email address.")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If






        ' If user declares him/herself as a customer then:
        If Validation = True And LastnameLength = True Then
            'Call Function, also provide three pieces of information
            Username = User_ID_Create(FirstName, LastName, Format_DateofBirth)
            MsgBox("Congratulations, you have successfuly created an Account with Hambrough Primary School as a Customer, Please note down your User ID:" + " " + Username)

            'Append all customer detail into Customers File
            Using Filewriter As StreamWriter = File.AppendText(CustomersFile)
                Filewriter.WriteLine(Username + ";" + Password)
            End Using

            'Append both Customer Personal data into one File
            Using Filewriter As StreamWriter = File.AppendText(UsersFile)
                Filewriter.WriteLine(Username + " ; " + FirstName + " ; " + LastName + " ; " + Address + " ; " + Postcode + " ; " + EmailAddress + " ; " + DateTimePicker1.Value)
            End Using

            Me.Hide() ' Hide the current form and display the login account as the user will not need to stay on this form any longer
            LoginAccount.Show()
        End If

        'If manager is signing up, however provides incorrect pin, then messagebox.
        If Validation = True And ManagerCheck.Checked And pininput <> "5758" Then

            MsgBox(" Incorrect Pin, please contact the headteacher to retrieve your pin")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form


        ElseIf Validation = True And Managercheck.Checked And pininput = "5758" And LastnameLength = True Then

            'Call Function, also provide three pieces of information
            Username = User_ID_Create(FirstName, LastName, Format_DateofBirth)
            MsgBox("Congratulations, you have successfuly created an Account with Hambrough Primary School as a Manager, Please note down your User ID:" + " " + Username)
            'Append all managers login details into Managers File


            Using Filewriter As StreamWriter = File.AppendText(ManagersFile)
                Filewriter.WriteLine(Username + ";" + Password)
            End Using

            'Append both Customer and Managers Personal data into one File
            Using Filewriter As StreamWriter = File.AppendText(UsersFile)
                Filewriter.WriteLine(Username + ";" + FirstName + ";" + LastName + ";" + Address + ";" + EmailAddress + ";" + Postcode + ";" + DateTimePicker1.Value)
            End Using
            Return
            Me.Hide() ' Hide the current form and display the login account as the user will not need to stay on this form any longer
            LoginAccount.Show()
        End If


    End Sub


    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' on button click, clear all the objects 
        Firsttextbox.Clear()
        pintextbox.Clear()
        Lastextbox.Clear()
        address2.Clear()
        email2.Clear()
        postcode2.Clear()
        password2.Clear()
        passwordconfirm2.Clear()
        pintextbox.Clear()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'Go back to previous form and hide this form
        My.Forms.LoginAccount.Show()
        Me.Hide()

    End Sub

    Private Sub password2_TextChanged(sender As System.Object, e As System.EventArgs) Handles password2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        'on button click, display help box. A gap will be added between each instruction.
        MsgBox("1) Only if you are a manager, please input the pin. If you are not aware of the pin, please contact your supervisor at Hambrough to retrieve your pin. Ignore this if you are a customer." & vbNewLine _
        & " " & vbNewLine _
        & "2) Please enter your first name and last name that appears on your passport." & vbNewLine _
        & " " & vbNewLine _
        & "3) Passwords must be greater than 8 chaarcters, Must contain atleast 1 number. Password will be invalid if it contains your first name or last name. Case Senstive." & vbNewLine _
        & " " & vbNewLine _
        & " 4) Please enter the identical password in the confirm textbox." & vbNewLine _
        & " " & vbNewLine _
        & "5) Please provide your date of birth - identical to the one on your passport, you must be over 18 to apply." & vbNewLine _
        & " " & vbNewLine _
        & "6) Please provide your first line of address where you are currently living, alongside the postcode." & vbNewLine _
        & " " & vbNewLine _
        & "7) Please input a valid email address as we may want to contact you later." & vbNewLine _
        & " " & vbNewLine _
        & "8) Please declare yourself as a manager or customer by checking the checkbox. " & vbNewLine _
        & " " & vbNewLine _
        & "8) If you require further help, please contact Hambrough Primary School. ")

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class