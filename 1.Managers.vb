Imports System.IO

Public Class Managers
    Dim CustomersFile As String = Application.StartupPath & "\Customers File.txt"
    Dim ManagersFile As String = Application.StartupPath & "\Managers File.txt"
    Dim UsersFile As String = Application.StartupPath & "\Users File.txt"
    Dim BookingsFile As String = Application.StartupPath & "\Bookings File.txt"
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        'Used to read from Users File and display all Users
        Dim lines() As String = IO.File.ReadAllLines(UsersFile)
        ListBox1.Items.AddRange(lines)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        ' This button will delete desired User ID input
        Dim line As String
        Dim Find As StreamReader
        Dim TemporaryFile As New ArrayList
        Find = File.OpenText(UsersFile)

        ' Check Each line in the file
        While Find.Peek <> -1
            ' Read the next available line
            line = Find.ReadLine
            ' Check to see if the next line doesnt contain the string
            If Not line.Contains(FindUserID.Text) Then

                ' If so, then add it temporarily to array 
                TemporaryFile.Add(line)
            End If
        End While

        Find.Close()
        ' The file is the deleted.
        If File.Exists(UsersFile) Then
            File.Delete(UsersFile)
        End If
        ' A streamwriter object will be used to create a file with the same filename

        Dim usersobjWriter As New System.IO.StreamWriter(UsersFile, True)
        ' Iterate through the ArrayList
        For Each item As String In TemporaryFile

            ' Write the current item in the ArrayList to the file.
            usersobjWriter.WriteLine(item)
        Next
        usersobjWriter.Flush()
        usersobjWriter.Close()
        ' End of removing from users file





        Dim CustomersLogin = IO.File.ReadAllText(CustomersFile)
        ' IF details exist in customers form. delete log in from customers file

        ' This button will delete desired User ID input
        Dim customersline As String
        Dim customerFind As StreamReader
        Dim customersTemporaryFile As New ArrayList
        customerFind = File.OpenText(CustomersFile)

        ' Only if the file customer login contains the user ID will this continue
        If CustomersLogin.Contains(FindUserID.Text) Then


            MsgBox("You have deleted a Customer user :" + FindUserID.Text)

            ' Check Each line in the file
            While customerFind.Peek <> -1
                ' Read the next available line
                customersline = customerFind.ReadLine
                ' Check to see if the next line doesnt contain the string
                If Not customersline.Contains(FindUserID.Text) Then

                    ' If so, then add it temporarily to array 
                    customersTemporaryFile.Add(customersline)
                End If
            End While

            customerFind.Close()
            ' The file is the deleted.
            If File.Exists(CustomersFile) Then
                File.Delete(CustomersFile)
            End If
            ' A streamwriter object will be used to create a file with the same filename

            Dim customersobjWriter As New System.IO.StreamWriter(CustomersFile, True)
            ' Iterate through the ArrayList
            For Each item As String In customersTemporaryFile

                ' Write the current item in the ArrayList to the file.
                customersobjWriter.WriteLine(item)
            Next
            customersobjWriter.Flush()
            customersobjWriter.Close()
            ' End of removing from customers file
        End If

        Dim ManagerLogin = IO.File.ReadAllText(ManagersFile)
        ' This button will delete desired User ID input
        Dim managersline As String
        Dim managersFind As StreamReader
        Dim managersTemporaryFile As New ArrayList
        managersFind = File.OpenText(ManagersFile)




        'IF details exist in MAnagers form, delete log in from managers file
        If ManagerLogin.Contains(FindUserID.Text) Then
            MsgBox("You have deleted a Manager user :" + FindUserID.Text)
            ' Check Each line in the file
            While managersFind.Peek <> -1
                ' Read the next available line
                managersline = managersFind.ReadLine
                ' Check to see if the next line doesnt contain the string
                If Not managersline.Contains(FindUserID.Text) Then

                    ' If so, then add it temporarily to array 
                    managersTemporaryFile.Add(managersline)
                End If
            End While

            managersFind.Close()
            ' The file is the deleted.
            If File.Exists(ManagersFile) Then
                File.Delete(ManagersFile)
            End If
            ' A streamwriter object will be used to create a file with the same filename

            Dim managersobjWriter As New System.IO.StreamWriter(ManagersFile, True)
            ' Iterate through the ArrayList
            For Each item As String In managersTemporaryFile

                ' Write the current item in the ArrayList to the file.
                managersobjWriter.WriteLine(item)
            Next
            managersobjWriter.Flush()
            managersobjWriter.Close()
            ' End of removing from customers file
        End If
            'Doo if statement to delete from managers file

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
       

        ' This button will delete desired User ID input
        Dim line As String
        Dim Find As StreamReader
        Dim TemporaryFile As New ArrayList
        Find = File.OpenText(BookingsFile)
        Dim Lookingfor As String = TextBox16.Text

        ' Check Each line in the file
        While Find.Peek <> -1
            ' Read the next available line
            line = Find.ReadLine
            ' Check to see if the next line doesnt contain the string
            If Not line.Contains(Lookingfor) Then

                ' If so, then add it temporarily to array 
                TemporaryFile.Add(line)
            End If
        End While

        Find.Close()
        ' The file is the deleted.
        If File.Exists(BookingsFile) Then

            File.Delete(BookingsFile)
        End If
        ' A streamwriter object will be used to create a file with the same filename

        Dim usersobjWriter As New System.IO.StreamWriter(BookingsFile, True)
        ' Iterate through the ArrayList
        For Each item As String In TemporaryFile

            ' Write the current item in the ArrayList to the file.
            usersobjWriter.WriteLine(item)
        Next
        usersobjWriter.Flush()
        usersobjWriter.Close()
        ' End of removing from users file
      

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        'Used to read from Users File and display all Users
        ListBox2.Items.Clear() ' clear the listbox items to remove any old contents before adding the ones below
        Dim lines() As String = IO.File.ReadAllLines(BookingsFile)
        ListBox2.Items.AddRange(lines)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FirstName, LastName, Address, Postcode, Email As String
        FirstName = TextBox1.Text
        LastName = TextBox2.Text
        Address = TextBox3.Text
        Postcode = TextBox7.Text
        Email = TextBox4.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim FirstName, LastName, Address, Postcode, Email As String
        FirstName = TextBox1.Text
        LastName = TextBox2.Text
        Address = TextBox3.Text
        Postcode = TextBox7.Text
        Email = TextBox4.Text

        Dim Lookingfor As StreamReader
        Lookingfor = File.OpenText(UsersFile)
        Dim line As String
        Dim TemporaryFile As New ArrayList
        Dim Loggedinuser As String = FindUserID.Text


        While Lookingfor.Peek <> -1 ' Each line will be check in the file
            line = Lookingfor.ReadLine 'The consecuivitve/following line will be read in the file
            If Not line.Contains(Loggedinuser) Then  'Check to see if the line doesn't contain the user ID
                TemporaryFile.Add(line) ' If it doesnt contain the user ID, then add it temporarily to array 
            End If
        End While

        Lookingfor.Close()

        If File.Exists(UsersFile) Then ' The file is then deleted.
            File.Delete(UsersFile)
        End If

        Dim usersobjWriter As New System.IO.StreamWriter(UsersFile, True) ' A streamwriter object will be used to create a file with the same filename

        ' Iterate through the ArrayList
        For Each item As String In TemporaryFile

            ' Write the current item in the ArrayList to the file.
            usersobjWriter.WriteLine(item)
        Next
        usersobjWriter.Flush()
        usersobjWriter.Close()
        ' End of removing from users file

        'Append new information into Users File
        Using Filewriter As StreamWriter = File.AppendText(UsersFile)    ' append all new information file
            Filewriter.WriteLine(FindUserID.Text + ";" + FirstName + ";" + LastName + ";" + Address + ";" + Postcode)
        End Using
        Return



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.Clear() ' Everytime this button is clicked, old contents will be removed before new ones will be added

        Dim FirstName, LastName, Address, Postcode, Email As String
        FirstName = TextBox1.Text
        LastName = TextBox2.Text
        Address = TextBox3.Text
        Postcode = TextBox7.Text
        Email = TextBox4.Text


        ' Checks if all textboxes have input in them
        If FirstName = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")

            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        ElseIf Address = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")

            Return 'PROGRAM will stop executing the following code, user can only return back to the form 
        ElseIf Postcode = "" Then ' Checks if information has been input
            MsgBox("Please check all relevant fields are filled")

            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If

        Dim Age As Integer
        Age = Format(DateTimePicker2.Value, "yyyy")
        'Validation rule - you must be greater than 18 to apply 
        If Age > 2000 Then

            MsgBox(" You must be over 18 to apply")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If

        'If the email address does not contain the symbol @, then halt the program and display a messagebox.
        If Not Email.Contains("@") Then
            MsgBox("Please enter a valid email address.")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If



        Dim Lookingfor As StreamReader
        Lookingfor = File.OpenText(UsersFile)
        Dim line As String
        Dim TemporaryFile As New ArrayList
        Dim Loggedinuser As String = TextBox1.Text


        While Lookingfor.Peek <> -1 ' Each line will be check in the file
            line = Lookingfor.ReadLine 'The consecuivitve/following line will be read in the file
            If Not line.Contains(Loggedinuser) Then  'Check to see if the line doesn't contain the user ID
                TemporaryFile.Add(line) ' If it doesnt contain the user ID, then add it temporarily to array 
            End If
        End While

        Lookingfor.Close()
        If File.Exists(UsersFile) Then ' The file is then deleted.
            File.Delete(UsersFile)
        End If

        Dim usersobjWriter As New System.IO.StreamWriter(UsersFile, True) ' A streamwriter object will be used to create a file with the same filename
        ' Iterate through the ArrayList
        For Each item As String In TemporaryFile
            ' Write the current item in the ArrayList to the file.
            usersobjWriter.WriteLine(item)
        Next
        usersobjWriter.Flush()
        usersobjWriter.Close()
        ' End of removing from users file


        'Append both Customer and Managers Personal data into one File
        Using Filewriter As StreamWriter = File.AppendText(UsersFile)    ' append all new information file
            Filewriter.WriteLine(Loggedinuser + ";" + FirstName + ";" + LastName + ";" + Address + ";" + Postcode + ";" + Format(DateTimePicker2.Value, "yyyy"))
        End Using
        Return
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'To log out of the 
        Me.Hide()  ' hidet the current form
        LoginAccount.Show()   ' show the login form
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        'To log out of the 
        Me.Hide()  ' hidet the current form
        LoginAccount.Show()   ' show the login form
    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub
End Class