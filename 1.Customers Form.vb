Imports System.IO

Public Class CustomersForm
    Dim BookingsFile As String = Application.StartupPath & "\Bookings File.txt"
    Dim CustomersFile As String = Application.StartupPath & "\Customers File.txt"
    Dim UsersFile As String = Application.StartupPath & "\Users File.txt"
    Dim Loggedinuser As String = LoginAccount.GlobalUserID ' collect vairable from login account form , I can now identify who has logged in
    Dim Totalcost As Decimal




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'IF Customers File Does Not Exist at this location, then create file and input heading
        If Not File.Exists(BookingsFile) Then

            Using NewLine As StreamWriter = File.CreateText(BookingsFile)
                NewLine.WriteLine(" UserID " & ";" & "Booking ID" & ";" & "Room" & ";" & "Size" & "; " & "Date" & ";" & "Arrival" & ";" & "Departure" & ";" & "ExtraFeatures" & ";" & "Total Cost")
            End Using
        End If

    End Sub
    'Public Function Booking ID - Function 1
    Public Function BookingID()
        Dim randomnum As Integer

        Randomize()
        ' The program will generate a number from 0 to 1000
        randomnum = Int(Rnd() * 1000) + 1

        Return randomnum
    End Function


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmBooking.Click
        Dim costoffeatures As Decimal
        Dim costofroom As Decimal
        Dim roombooked As String
        Dim mustinput As Boolean
        Dim Format_dateofbooking As String
        Dim Arrival As Integer
        Dim Departure As Integer
        Dim totaltime As Integer
        Dim totalcostofroom As String
        Loggedinuser = LoginAccount.GlobalUserID
        Dim NumbofBookings As Decimal


        
         

        Arrival = ArrivalUPdown.Value ' the value from this updown tool is stored in this variable
        Departure = DepartureUpdown.Value ' the value from this updown tool is stored in this variable
        totaltime = Departure - Arrival ' the total amount of time stayed is calculated by taking the departure time away from arrival 


        'only collects date and month of booking
        Format_dateofbooking = Format(DateTimePicker1.Value, "dd-dddd-MMM-yyyy")

        ' Code is used to check if booking already exists

        For Each Read As String In IO.File.ReadLines(BookingsFile) 'Each line in the bookings file will be read
            If Read.Contains(Format_dateofbooking) Then ' to check if the date already exists
                MsgBox("Booking already exists on this day, please select another day.") ' If it does, generate an error message and 
                Return ' halt the program
            End If
        Next
       

        ' Code is used to check if the User ID has already made a booking

        For Each Read As String In IO.File.ReadLines(BookingsFile) 'Each line in the bookings file will be read
            If Read.Contains(Loggedinuser) Then ' to check if the User ID already exists
                ' If it does, generate an error message 
                MsgBox("You are limited to a maximum of 1 booking, Please wait or delete your current booking to continue with this one.")
                Return ' halt the program
            End If
        Next


        mustinput = True

        ' Setting the cost of room variable corrosponding to the one seleted by customers
        If MainHall.Checked Then
            costofroom = 150
            roombooked = ("Main Hall ; Large")

        ElseIf MensGym.Checked Then  ' if this radio box is selected
            costofroom = 100         ' make cost of room equal to 100
            roombooked = ("Mens Gym ; Medium")   ' store the room information to this variable

        ElseIf FemalesGym.Checked Then
            costofroom = 100
            roombooked = ("Females Hall ; Medium")

        ElseIf O1Room.Checked Then
            costofroom = 50
            roombooked = ("O1 ; Small")

        ElseIf X6Room.Checked Then
            costofroom = 50
            roombooked = ("X6 ; Small")

        ElseIf O2Room.Checked Then
            costofroom = 50
            roombooked = ("O2 ; Small")

        ElseIf O3Room.Checked Then
            costofroom = 50
            roombooked = ("O3 ; Small")

        ElseIf O4Room.Checked Then
            costofroom = 50
            roombooked = ("O4 ; Small")


        ElseIf NumbofBookings > 1 Then
            MsgBox("You can only book 1 room, please uncheck some boxes.") ' if the number of bookings is greater than 1, error message
            mustinput = False
        Else : MsgBox("No room has been selected, please select one.") ' if number of bookings = 0 , error message
            mustinput = False
        End If

        'Total cost of room is equal to the total time of booking * costofperhourofroom
        totalcostofroom = (totaltime / 100) * costofroom


        ' Calculate the total cost of features
        If Wifi.Checked Then                     'If this checkbox is selected, add 10 to the total cost of features, replicate for all
            costoffeatures = costoffeatures + 10

        End If
        If Chair.Checked Then
            costoffeatures = costoffeatures + 10

        End If
        If Table.Checked Then
            costoffeatures = costoffeatures + 10

        End If
        If Speakers.Checked Then
            costoffeatures = costoffeatures + 20

        End If
        If Computers.Checked Then
            costoffeatures = costoffeatures + 20

        End If




        If mustinput = True Then

            Totalcost = costoffeatures + totalcostofroom
            Dim BookingIDnumber As String
            'Call Function, also provide three pieces of information
            BookingIDnumber = BookingID()
            MsgBox("Congratulations, you have successfuly completed a booking with Hambrough, your booking ID is:" & " " & BookingIDnumber & (".") + "The total cost of your booking is: £" & Totalcost & " .Please check the bookings tab to view all your bookings.")
            'Append all managers login details into Managers File
            Using Filewriter As StreamWriter = File.AppendText(BookingsFile)
                Filewriter.WriteLine(Loggedinuser & " ; " & BookingIDnumber & " ; " & roombooked & " ; " & " £" & Totalcost & " ; " & Format_dateofbooking & " ; " & Arrival & " ; " & Departure)
            End Using
        End If


    End Sub

    Private Sub checkbox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.Clear() ' if button is clicked more than once, everything initlly will be erased ( it will seem as if it got updated)
        ' Add below as heading
        ListBox1.Items.Add("Username ; FirstName ; LastName ; Address ; EmailAddress ; Postcode ; DateofBirth")


        Dim Loggedinuser As String
        Loggedinuser = LoginAccount.GlobalUserID ' collect vairable from login account form , I can now identify who has logged in

        Using reader As New StreamReader(UsersFile) ' read from users file
            While Not reader.EndOfStream                  ' until it isnt the end of the users file
                Dim line As String = reader.ReadLine() ' keep searching for the user id
                If line.Contains(Loggedinuser) Then ' if line contains the user ID
                    ListBox1.Items.Add(line) ' copy the line into the listbpx
                    Exit While
                End If
            End While
        End Using
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Loggedinuser As String
        Loggedinuser = LoginAccount.GlobalUserID ' collect vairable from login account form , I can now identify who has logged in

        ' on button click, delete user and add new information stored
        
        Dim TemporaryFile As New ArrayList
        Dim Lookingfor As StreamReader
        Lookingfor = File.OpenText(UsersFile)
        Dim line As String
        Dim Validation As Boolean
        Dim FirstName As String = TextBox1.Text
        Dim LastNAme As String = TextBox2.Text
        Dim Address As String = TextBox3.Text
        Dim EmailAddress As String = TextBox5.Text
        Dim Postcode As String = TextBox4.Text
        Dim Age As String = Format(DateTimePicker2.Value, "yyyy")

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
        MsgBox("You have successfuly amended your details. Please Click View to view the changes made")
        'Append both Customer and Managers Personal data into one File
        Using Filewriter As StreamWriter = File.AppendText(UsersFile)    ' append all new information file
            Filewriter.WriteLine(Loggedinuser + ";" + FirstName + ";" + LastNAme + ";" + Address + ";" + Postcode + ";" + EmailAddress + ";" + DateTimePicker2.Value)
        End Using
        Return


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim passwordinput, NewPass, NEwpassconfirm, Loggedinuser, loggedinuserspassword As String 'declare these values that will be used in this sub-section
        passwordinput = TextBox6.Text
        NewPass = TextBox7.Text
        NEwpassconfirm = TextBox8.Text

        Loggedinuser = LoginAccount.GlobalUserID ' collect value from login account form , I can now identify who has logged in
        loggedinuserspassword = LoginAccount.GlobalPassword ' collect value from the login account form, the correct password will be stored here.

        If loggedinuserspassword <> passwordinput Then   ' the password needs to match the one that was sucesfully entered in the login page
            MsgBox("You have provided the incorrect password for your account")
            Return
        End If

        If NewPass <> NEwpassconfirm Then ' If passwords dont match then messagebox
            MsgBox("Passwords do not match, please try again")
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If

        'Validation rule - The password entered must contain either of the following numbers
        If NewPass.Contains("1") Then
        ElseIf NewPass.Contains("2") Then
        ElseIf NewPass.Contains("3") Then
        ElseIf NewPass.Contains("4") Then
        ElseIf NewPass.Contains("5") Then
        ElseIf NewPass.Contains("6") Then
        ElseIf NewPass.Contains("7") Then
        ElseIf NewPass.Contains("8") Then
        ElseIf NewPass.Contains("9") Then
        ElseIf NewPass.Contains("0") Then
        Else
            MsgBox("Your password must contain a number")   ' Else an error message will appear
            Return 'PROGRAM will stop executing the following code, user can only return back to the form
        End If


        Dim TemporaryFile As New ArrayList
        Dim Lookingfor As StreamReader
        Lookingfor = File.OpenText(CustomersFile)
        Dim line As String


        While Lookingfor.Peek <> -1 ' Each line will be check in the file

            line = Lookingfor.ReadLine 'The consecuivitve/following line will be read in the file

            If Not line.Contains(Loggedinuser) Then  'Check to see if the line doesn't contain the user ID


                TemporaryFile.Add(line) ' If it doesnt contain the user ID, then add it temporarily to array 
            End If
        End While

        Lookingfor.Close()

        If File.Exists(CustomersFile) Then ' The file is then deleted.
            File.Delete(CustomersFile)
        End If



        Dim usersobjWriter As New System.IO.StreamWriter(CustomersFile, True) ' A streamwriter object will be used to create a file with the same filename

        ' Iterate through the ArrayList
        For Each item As String In TemporaryFile

            ' Write the current item in the ArrayList to the file.
            usersobjWriter.WriteLine(item)
        Next
        usersobjWriter.Flush()
        usersobjWriter.Close()
        ' End of removing from users file

        'Append both Customer and Managers Personal data into one File
        Using Filewriter As StreamWriter = File.AppendText(CustomersFile)    ' append all new information file
            Filewriter.WriteLine(Loggedinuser + ";" + NewPass)
        End Using
        MsgBox("You have sucesfully changed your password")
        loggedinuserspassword = NewPass ' The new password must be stored into this variable, as this is the current running password
        Return

    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub DeleteAccount_Click(sender As System.Object, e As System.EventArgs) Handles DeleteAccount.Click
        Dim PasswordInput, correctPassword As String
        PasswordInput = TextBox9.Text
        correctPassword = LoginAccount.GlobalPassword ' collect value from the login account form, the correct password will be stored here.
        Loggedinuser = LoginAccount.GlobalUserID ' collect value from login account form , I can now identify who has logged in

        Dim TemporaryFile As New ArrayList
        Dim Lookingfor As StreamReader
        Lookingfor = File.OpenText(CustomersFile)
        Dim line As String

        If PasswordInput <> correctPassword Then ' if the password that the user has provided is not identical to the correct one, then
            MsgBox("Incorrect Password")
            Return
        End If

        While Lookingfor.Peek <> -1 ' Each line will be check in the file
            line = Lookingfor.ReadLine 'The consecuivitve/following line will be read in the file
            If Not line.Contains(Loggedinuser) Then  'Check to see if the line doesn't contain the user ID
                TemporaryFile.Add(line) ' If it doesnt contain the user ID, then add it temporarily to array 
            End If
        End While

        Lookingfor.Close()

        If File.Exists(CustomersFile) Then ' The file is then deleted.
            File.Delete(CustomersFile)
        End If

        Dim usersobjWriter As New System.IO.StreamWriter(CustomersFile, True) ' A streamwriter object will be used to create a file with the same filename

        ' Iterate through the ArrayList
        For Each item As String In TemporaryFile
            ' Write the current item in the ArrayList to the file.
            usersobjWriter.WriteLine(item)
        Next
        usersobjWriter.Flush()
        usersobjWriter.Close()
        ' End of removing from users file
        MsgBox("You have sucesfully deleted your account, goodybye :)")
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim Lookingfor As StreamReader
        Lookingfor = File.OpenText(BookingsFile)
        Dim line As String
        Loggedinuser = LoginAccount.GlobalUserID


        ' the code below is used to read the bookings file, and find the bookings that have been booked by the logged in user.

        While Lookingfor.Peek <> -1 ' Each line will be check in the file
            line = Lookingfor.ReadLine 'The consecuivitve/following line will be read in the file
            If line.Contains(Loggedinuser) Then  'Check to see if the line contains the user ID
                ListBox2.Items.Clear() 'clear the listbox every time - so that any old data will not remain
                ListBox2.Items.Add("UserID ; Booking ID ; Room ; Size ; Total Cost ; Date ; Arrival ; Departure ; ExtraFeatures")  'add headings to the listbox
                ListBox2.Items.Add(line) ' add the identified line and implement it to the listbox

            End If
        End While
        Lookingfor.Close() 'The file will now be closed after it has been opened ( the bookings file will be closed
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' This button will delete desired User ID input
        Dim line As String
        Dim Find As StreamReader
        Dim TemporaryFile As New ArrayList
        Find = File.OpenText(BookingsFile)
        Dim Lookingfor As String = TextBox12.Text

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
        ListBox2.Items.Clear() 'this is used to clear the textbox once the textbox has been deleted.
        ListBox2.Items.Add("UserID ; Booking ID ; Room ; Size ; Date ; Arrival ; Departure ; ExtraFeatures ; Total Cost")  'add headings to the listbox

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'on button click, display help box. A gap will be added between each instruction.
        MsgBox("1) Click the 'View' button to review any information stored about you." & vbNewLine _
        & " " & vbNewLine _
        & "2) If you would like to amend any pieces of information, please eneter ALL pieces of information into the first column of textboxes. Same validation rules apply as when you created your account." & vbNewLine _
        & " " & vbNewLine _
        & "3) If you would like to change your password, please enter your current password into the second column, 1st textbox. Followed by enetering your new desired password. Same validation rules apply." & vbNewLine _
        & " " & vbNewLine _
        & " 4) If you would like to delete your account, please enter you current password and click the button." & vbNewLine _
        & " " & vbNewLine _
        & "5) To book a room, or view your bookings, please click on the other tabs.")
    End Sub


    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles RunningCost.Click
        ListBox3.Items.Clear() 'Clear the textbox everytime button is clicked

        Dim costoffeatures As Decimal
        Dim costofroom As Decimal
        Dim roombooked As String
        Dim mustinput As Boolean
        Dim Format_dateofbooking As String
        Dim Arrival As Integer
        Dim Departure As Integer
        Dim totaltime As Integer
        Dim totalcostofroom As String

        Arrival = ArrivalUPdown.Value ' the value from this updown tool is stored in this variable
        Departure = DepartureUpdown.Value ' the value from this updown tool is stored in this variable
        totaltime = Departure - Arrival ' the total amount of time stayed is calculated by taking the departure time away from arrival 
        'only collects date and month of booking
        Format_dateofbooking = Format(DateTimePicker1.Value, "dddd-MMM-yyyy")
        ' Code is used to check if booking already exists
        If BookingsFile.Contains(Format_dateofbooking) Then ' if the booking file already contains this date
            MsgBox("Booking is not available for this day, Please select another day")   'then show an error message
            Return  'and halt the program
        End If
        mustinput = True
        ' Setting the cost of room variable corrosponding to the one seleted by customers
        If MainHall.Checked Then
            costofroom = 150
            roombooked = ("Main Hall ; Large")
        ElseIf MensGym.Checked Then  ' if this radio box is selected
            costofroom = 100         ' make cost of room equal to 100
            roombooked = ("Mens Gym ; Medium")   ' store the room information to this variable
        ElseIf FemalesGym.Checked Then
            costofroom = 100
            roombooked = ("Females Hall ; Medium")
        ElseIf O1Room.Checked Then
            costofroom = 50
            roombooked = ("O1 ; Small")
        ElseIf X6Room.Checked Then
            costofroom = 50
            roombooked = ("X6 ; Small")
        ElseIf O2Room.Checked Then
            costofroom = 50
            roombooked = ("O2 ; Small")
        ElseIf O3Room.Checked Then
            costofroom = 50
            roombooked = ("O3 ; Small")
        ElseIf O4Room.Checked Then
            costofroom = 50
            roombooked = ("O4 ; Small")
        End If
        'Total cost of room is equal to the total time of booking * costofperhourofroom
        totalcostofroom = (totaltime / 100) * costofroom

        ' Calculate the total cost of features
        If Wifi.Checked Then                     'If this checkbox is selected, add 10 to the total cost of features, replicate for all
            costoffeatures = costoffeatures + 10
        End If
        If Chair.Checked Then
            costoffeatures = costoffeatures + 10
        End If
        If Table.Checked Then
            costoffeatures = costoffeatures + 10
        End If
        If Speakers.Checked Then
            costoffeatures = costoffeatures + 20
        End If
        If Computers.Checked Then
            costoffeatures = costoffeatures + 20
        End If
        If mustinput = True Then
            Totalcost = costoffeatures + totalcostofroom
        End If

        ListBox3.Items.Add("£ " & Totalcost) ' the total cost calculated earlier will be diplayed in the listbox
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        'To log out of the 
        Me.Hide()  ' hidet the current form
        LoginAccount.Show()   ' show the login form
    End Sub

    Private Sub Button8_Click_3(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        'To log out of the 
        Me.Hide()  ' hidet the current form
        LoginAccount.Show()   ' show the login form
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        'To log out of the 
        Me.Hide()  ' hidet the current form
        LoginAccount.Show()   ' show the login form
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainHall_CheckedChanged(sender As Object, e As EventArgs) Handles MainHall.CheckedChanged

    End Sub
End Class
