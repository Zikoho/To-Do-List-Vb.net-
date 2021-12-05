Imports To_do_list.Form_names
'Bjhon
'November 29 2021
'This is a to dolist application that gives the user the ability to create three different to-do-list. 
'Intructions: Click a create list button in the first form to add another list click the "+" button in the bottom right. You will then be prompted to enter the name of your to-do-list
'in an inputbox, enter the name. When in the to-do list click a date on the calender you would like your to-do-list to be set for. After in the text box input the name of the task
'Below that there is an input for time enter the time for the task and in the combo box next to it choose the time of day. After you input all the details of the task click the "Add task" button
'The task will be entered in a listview. If you want to set a reminder for your task click one of the radio buttons in the bottom right of the text form. After, choose the task you would 
'like to to set a reminder for. After it appears in the textbox click the "set" button to start the timer. If you want to cancel the timer click the clear button.
'If you want to maek a task completed click the chexk box next to the task. The task and its details will get dim to show to the user that it is completed.
'If you want to delete a task click the delete button and all the tasks that are marked checked will be deleted.
Public Class frmtodoselect
    'Variables are decleared which control the adding and subtracting of the create list buttons
    Dim btnclick As Integer = 1
    Dim delete As Integer = 5
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles Btncreate.Click
        'When the add button is clicked a button is created and both variables are+1 
        btnclick = btnclick + 1
        delete = delete + 1
        If btnclick > 1 Then
            btndelete.Visible = True
        ElseIf btnclick = 1 Then
            btndelete.Visible = False
        End If
        Select Case btnclick
            Case 2
                Button2.Visible = True

            Case 3
                Button3.Visible = True

                Btncreate.Enabled = False
        End Select
    End Sub
    Private Sub frmtodoselect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'These objects are made not visible when the form is first form is loaded
        Button2.Visible = False
        Button3.Visible = False
        btndelete.Visible = False



    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'When the add button is clicked a button is removed and both variables are -1 
        delete = delete - 1
        btnclick = btnclick - 1
        Select Case delete
            Case 6
                Button3.Visible = False

                Btncreate.Enabled = True
            Case 5
                Button2.Visible = False

                btndelete.Visible = False
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'When the create button is clicked an inputbox pops up and asks for the name of the list and after that is done a to-do list is created 
        Dim prompt, title As String
        prompt = "Please enter the name of you To-Do-List"
        title = "Name of To-Do-List"
        Name_of_list1 = InputBox(prompt, title)
        If Name_of_list1 <> "" Then
            Button1.Text = Name_of_list1
            Frmlist1.Text = Name_of_list1
            Frmlist1.Show()
            Me.Hide()
        ElseIf Name_of_list1 = "" Then
            Dim msg As Integer
            msg = MsgBox("Please enter a name for list", vbRetryCancel + vbExclamation, "Forgot something?")
            If msg = 4 Then
                MessageBox.Show("Click on create list then type the name of you list in the inputbox that appears")
            End If
        Else
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'When the create button is clicked an inputbox pops up and asks for the name of the list and after that is done a to-do list is created 
        Dim prompt2, title2 As String
        prompt2 = "Please enter the name of you To-Do-List"
        title2 = "Name of To-Do-List"
        Name_of_list2 = InputBox(prompt2, title2)
        If Name_of_list2 <> "" Then
            Button1.Text = Name_of_list2
            Frmlist2.Text = Name_of_list2
            Frmlist2.Show()
            Me.Hide()
        ElseIf Name_of_list2 = "" Then
            Dim msg As Integer
            msg = MsgBox("Please enter a name for list", vbRetryCancel + vbExclamation, "Forgot something?")
            If msg = 4 Then
                MessageBox.Show("Click on create list then type the name of you list in the inputbox that appears")
            End If
        Else
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'When the create button is clicked an inputbox pops up and asks for the name of the list and after that is done a to-do list is created 
        Dim prompt3, title3 As String
        prompt3 = "Please enter the name of you To-Do-List"
        title3 = "Name of To-Do-List"
        Name_of_list3 = InputBox(prompt3, title3)
        If Name_of_list3 <> "" Then
            Button1.Text = Name_of_list3
            Frmlist3.Text = Name_of_list3
            Frmlist3.Show()
            Me.Hide()
        ElseIf Name_of_list3 = "" Then
            Dim msg As Integer
            msg = MsgBox("Please enter a name for list", vbRetryCancel + vbExclamation, "Forgot something?")
            If msg = 4 Then
                MessageBox.Show("Click on create list then type the name of you list in the inputbox that appears")
            End If
        Else
        End If

    End Sub

    Private Sub pboxclose0_Click(sender As Object, e As EventArgs) Handles pboxclose0.Click
        'Since as of writing this i dont know how to have items be saved when the applictaion is closed, when the exit picbox is clicked a message box appears warning that items will not be saved when the app is closed
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit you list will not be saved.(Try minimizing instead).", "Exit application?",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Me.Close()
        ElseIf response = vbNo Then

        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)

    End Sub
End Class
