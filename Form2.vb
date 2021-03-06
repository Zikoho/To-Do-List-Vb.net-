Imports To_do_list.Form_names 'Importing names of the list form other forms so they can be used here

Public Class Frmlist1
    'Variables are decleared
    Dim currenttime As String ' for the time that is displayed in the top left
    Dim remindernotification1 As String ' For notification
    Dim remindernotification2 As String ' For notification
    Dim remindernotification3 As String ' For notification
    Dim remindernotification4 As String ' For notification
    Dim CurrentItem As Integer = 0 'for adding items to list view 
    Dim alarmon As Integer = 0 ' for the enabling of the groupbox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaddtask.Click

        If txttask.Text.Length = 0 And msktime.MaskCompleted = False And cboxtime.SelectedIndex = -1 Then
            MessageBox.Show("Please the information for your To do list.")
        ElseIf msktime.MaskCompleted = False Or cboxtime.SelectedIndex = -1 Then
            MessageBox.Show("Please enter the time of the task")
        ElseIf txttask.Text.Length = 0 Then
            MessageBox.Show("Please enter the name of the task")
        Else
            'When button is clicked items form the task details objects are added to lists and groupbox is enabled
            Dim date1 As String
            date1 = MonthCalendar1.SelectionRange.Start.ToLongDateString()
            lsvTasks.Items.Add(txttask.Text)
            lsvTasks.Items(CurrentItem).SubItems.Add(msktime.Text & " " & cboxtime.SelectedItem)
            lsvTasks.Items(CurrentItem).SubItems.Add(date1)
            txttask.Clear()
            CurrentItem += 1
            alarmon = 1

            If alarmon = 1 Then
                grpalarm.Enabled = True
            End If
        End If
    End Sub

    Private Sub pboxmin_Click(sender As Object, e As EventArgs) Handles pboxmin.Click
        'When the minimise picbox is clicked this form is minimised and a notification is popped up
        Me.Hide()
        list1noty.Visible = True
        list1noty.Text = Name_of_list1
        list1noty.BalloonTipText = Name_of_list1 & " has been minimized"
        list1noty.ShowBalloonTip(3000)

    End Sub

    Private Sub list1noty_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles list1noty.MouseDoubleClick
        'in the task bar when the icon is clicked the form will pop up
        Me.Show()
        list1noty.Visible = False
    End Sub

    Private Sub pboxclose_Click(sender As Object, e As EventArgs) Handles pboxclose.Click
        'When the close picbox is clicked a message box shows up 'Since as of writing this i dont know how to have items be saved when the applictaion is closed, when the exit picbox is clicked a message box appears warning that items will not be saved when the app is closed
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit you list will not be saved.(Try minimizing instead).", "Exit application?",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Me.Close()
            frmtodoselect.Close()
        ElseIf response = vbNo Then

        End If

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        'This takes you back to the form select an minizes this form and shows a notification
        Me.Hide()
        list1noty.Visible = True
        list1noty.Text = Name_of_list1
        list1noty.BalloonTipText = Name_of_list1 & " has been minimized"
        list1noty.ShowBalloonTip(3000)
        frmtodoselect.Show()
        frmtodoselect.Button1.Visible = False
        frmtodoselect.lbllist1disabled.Visible = True
    End Sub
    Private Sub lsvTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvTasks.SelectedIndexChanged
        'WHen the radio box is selected the time and date of the task is put in the textbox
        For i As Integer = 0 To lsvTasks.SelectedItems.Count - 1
            If rbtnreminder1.Checked = True Then
                Dim x As Integer = CInt(lsvTasks.SelectedItems(i).Index)
                Dim combined_dates As Date
                combined_dates = CDate(lsvTasks.Items(x).SubItems(1).Text & " " & lsvTasks.Items(x).SubItems(2).Text).ToString("g")
                txtreminder1.Text = combined_dates
            ElseIf rbtnreminder2.Checked = True Then
                Dim x As Integer = CInt(lsvTasks.SelectedItems(i).Index)
                Dim combined_dates As Date
                combined_dates = CDate(lsvTasks.Items(x).SubItems(1).Text & " " & lsvTasks.Items(x).SubItems(2).Text).ToString("g")
                txtreminder2.Text = combined_dates
            ElseIf rbtnreminder3.Checked = True Then
                Dim x As Integer = CInt(lsvTasks.SelectedItems(i).Index)
                Dim combined_dates As Date
                combined_dates = CDate(lsvTasks.Items(x).SubItems(1).Text & " " & lsvTasks.Items(x).SubItems(2).Text).ToString("g")
                txtreminder3.Text = combined_dates
            ElseIf rbtnreminder4.Checked = True Then
                Dim x As Integer = CInt(lsvTasks.SelectedItems(i).Index)
                Dim combined_dates As Date
                combined_dates = CDate(lsvTasks.Items(x).SubItems(1).Text & " " & lsvTasks.Items(x).SubItems(2).Text).ToString("g")
                txtreminder4.Text = combined_dates
            End If
        Next
    End Sub
    Private Sub Frmlist1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form is loaded the name of the list is set to a label box and objects are disabled
        List1.Text = Name_of_list1
        txtreminder1.Enabled = False
        btnremind1clear.Enabled = False
        btnremind1start.Enabled = False
        txtreminder2.Enabled = False
        btnremind2clear.Enabled = False
        btnremind2start.Enabled = False
        txtreminder3.Enabled = False
        btnremind3clear.Enabled = False
        btnremind3start.Enabled = False
        txtreminder4.Enabled = False
        btnremind4clear.Enabled = False
        btnremind4start.Enabled = False
        grpalarm.Enabled = False
    End Sub
    Private Sub lsvTasks_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lsvTasks.ItemChecked
        'When the check box is clicked the item and subitems and turned gainsboro
        For Each listviewItem As ListViewItem In lsvTasks.CheckedItems
            Dim index As Integer = lsvTasks.Items.IndexOf(listviewItem)
            lsvTasks.Items(index).ForeColor = Color.Gainsboro
        Next
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'When this button is clicked the checked items are removed
        For Each listviewItem As ListViewItem In lsvTasks.CheckedItems
            Dim index As Integer = lsvTasks.Items.IndexOf(listviewItem)
            lsvTasks.Items(index).Remove()
            CurrentItem -= 1
        Next
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnreminder2.CheckedChanged
        'When the radiobutton is clicked the textbox and "set" button are enabled
        If rbtnreminder2.Checked = True Then
            txtreminder2.Enabled = True
            btnremind2start.Enabled = True
        ElseIf rbtnreminder2.Checked = False Then
            txtreminder2.Enabled = False
            btnremind2start.Enabled = False
        End If
    End Sub
    Private Sub rbtnreminder1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnreminder1.CheckedChanged
        If rbtnreminder1.Checked = True Then
            txtreminder1.Enabled = True
            btnremind1start.Enabled = True
        ElseIf rbtnreminder1.Checked = False Then
            txtreminder1.Enabled = False
            btnremind1start.Enabled = False
        End If
    End Sub
    Private Sub rbtnreminder3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnreminder3.CheckedChanged
        If rbtnreminder3.Checked = True Then
            txtreminder3.Enabled = True
            btnremind3start.Enabled = True
        ElseIf rbtnreminder3.Checked = False Then
            txtreminder3.Enabled = False
            btnremind3start.Enabled = False
        End If
    End Sub
    Private Sub rbtnreminder4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnreminder4.CheckedChanged
        If rbtnreminder4.Checked Then
            txtreminder4.Enabled = True
            btnremind4start.Enabled = True
        ElseIf rbtnreminder4.Checked = False Then
            txtreminder4.Enabled = False
            btnremind4start.Enabled = False
        End If
    End Sub
    Private Sub Tmrlivetime_Tick(sender As Object, e As EventArgs) Handles Tmrlivetime.Tick
        'The time and date of the computer is show to in the label
        currenttime = DateTime.Now.ToString
        lbllivetime.Text = currenttime
    End Sub
    Private Sub btnremind1start_Click(sender As Object, e As EventArgs) Handles btnremind1start.Click
        'When the set button is clicked the timer is started and the clear button is now enabled
        Timer1.Start()
        btnremind1start.Enabled = False
        btnremind1clear.Enabled = True

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'When the time  is equal to the reminder time a message box appears reminding of the task. the timer is stopped and the textbox is cleared 
        remindernotification1 = CDate(txtreminder1.Text)
        If remindernotification1 = currenttime Then
            Timer1.Stop()
            MsgBox("Check " & List1.Text & " you have something you need to do", vbInformation, "You have a reminder!")
            btnremind1start.Enabled = True
            btnremind1clear.Enabled = False
            txtreminder1.Clear()
        End If
    End Sub

    Private Sub btnremind1clear_Click(sender As Object, e As EventArgs) Handles btnremind1clear.Click
        'When the clear button is clicked the timer is stopped and the textbox is cleared and the start button is enabled
        Timer1.Stop()
        btnremind1start.Enabled = True
        btnremind1clear.Enabled = False
        txtreminder1.Clear()

    End Sub
    'This is the timer for notification 2
    Private Sub btnremind2start_Click(sender As Object, e As EventArgs) Handles btnremind2start.Click
        Timer2.Start()
        btnremind2start.Enabled = False
        btnremind2clear.Enabled = True

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        remindernotification2 = CDate(txtreminder2.Text)
        If remindernotification2 = currenttime Then
            Timer2.Stop()
            MsgBox("Check " & List1.Text & " you have something you need to do", vbInformation, "You have a reminder!")
            btnremind2start.Enabled = True
            btnremind2clear.Enabled = False
            txtreminder2.Clear()
        End If
    End Sub

    Private Sub btnremind2clear_Click(sender As Object, e As EventArgs) Handles btnremind2clear.Click
        Timer2.Stop()
        btnremind2start.Enabled = True
        btnremind2clear.Enabled = False
        txtreminder2.Clear()

    End Sub
    'This is for reminder 3
    Private Sub btnremind3start_Click(sender As Object, e As EventArgs) Handles btnremind3start.Click
        Timer3.Start()
        btnremind3start.Enabled = False
        btnremind3clear.Enabled = True

    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        remindernotification3 = CDate(txtreminder3.Text)
        If remindernotification3 = currenttime Then
            Timer3.Stop()
            MsgBox("Check " & List1.Text & " you have something you need to do", vbInformation, "You have a reminder!")
            btnremind3start.Enabled = True
            btnremind3clear.Enabled = False
            txtreminder3.Clear()
        End If
    End Sub

    Private Sub btnremind3clear_Click(sender As Object, e As EventArgs) Handles btnremind3clear.Click
        Timer3.Stop()
        btnremind3start.Enabled = True
        btnremind3clear.Enabled = False
        txtreminder3.Clear()

    End Sub
    'This is for reminder 4
    Private Sub btnremind4start_Click(sender As Object, e As EventArgs) Handles btnremind4start.Click
        Timer4.Start()
        btnremind4start.Enabled = False
        btnremind4clear.Enabled = True

    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        remindernotification4 = CDate(txtreminder4.Text)
        If remindernotification4 = currenttime Then
            Timer4.Stop()
            MsgBox("Check " & List1.Text & " you have something you need to do", vbInformation, "You have a reminder!")
            btnremind4start.Enabled = True
            btnremind4clear.Enabled = False
            txtreminder4.Clear()
        End If
    End Sub

    Private Sub btnremind4clear_Click(sender As Object, e As EventArgs) Handles btnremind4clear.Click
        Timer4.Stop()
        btnremind4start.Enabled = True
        btnremind4clear.Enabled = False
        txtreminder4.Clear()

    End Sub
    'the code for the other forms is exatly the same
End Class