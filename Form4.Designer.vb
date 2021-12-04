<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmlist3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlist3))
        Me.lbllivetime = New System.Windows.Forms.Label()
        Me.grpalarm = New System.Windows.Forms.GroupBox()
        Me.rbtnreminder4 = New System.Windows.Forms.RadioButton()
        Me.rbtnreminder3 = New System.Windows.Forms.RadioButton()
        Me.rbtnreminder2 = New System.Windows.Forms.RadioButton()
        Me.rbtnreminder1 = New System.Windows.Forms.RadioButton()
        Me.txtreminder1 = New System.Windows.Forms.TextBox()
        Me.txtreminder4 = New System.Windows.Forms.TextBox()
        Me.btnremind4clear = New System.Windows.Forms.Button()
        Me.txtreminder3 = New System.Windows.Forms.TextBox()
        Me.btnremind1start = New System.Windows.Forms.Button()
        Me.txtreminder2 = New System.Windows.Forms.TextBox()
        Me.btnremind4start = New System.Windows.Forms.Button()
        Me.btnremind3clear = New System.Windows.Forms.Button()
        Me.btnremind3start = New System.Windows.Forms.Button()
        Me.btnremind1clear = New System.Windows.Forms.Button()
        Me.btnremind2clear = New System.Windows.Forms.Button()
        Me.btnremind2start = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.Label()
        Me.pboxclose = New System.Windows.Forms.PictureBox()
        Me.pboxmin = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxtime = New System.Windows.Forms.ComboBox()
        Me.msktime = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvTasks = New System.Windows.Forms.ListView()
        Me.tasks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Date1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txttask = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnaddtask = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.list1noty = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrlivetime = New System.Windows.Forms.Timer(Me.components)
        Me.grpalarm.SuspendLayout()
        CType(Me.pboxclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbllivetime
        '
        Me.lbllivetime.AutoSize = True
        Me.lbllivetime.Location = New System.Drawing.Point(25, 7)
        Me.lbllivetime.Name = "lbllivetime"
        Me.lbllivetime.Size = New System.Drawing.Size(0, 17)
        Me.lbllivetime.TabIndex = 49
        '
        'grpalarm
        '
        Me.grpalarm.Controls.Add(Me.rbtnreminder4)
        Me.grpalarm.Controls.Add(Me.rbtnreminder3)
        Me.grpalarm.Controls.Add(Me.rbtnreminder2)
        Me.grpalarm.Controls.Add(Me.rbtnreminder1)
        Me.grpalarm.Controls.Add(Me.txtreminder1)
        Me.grpalarm.Controls.Add(Me.txtreminder4)
        Me.grpalarm.Controls.Add(Me.btnremind4clear)
        Me.grpalarm.Controls.Add(Me.txtreminder3)
        Me.grpalarm.Controls.Add(Me.btnremind1start)
        Me.grpalarm.Controls.Add(Me.txtreminder2)
        Me.grpalarm.Controls.Add(Me.btnremind4start)
        Me.grpalarm.Controls.Add(Me.btnremind3clear)
        Me.grpalarm.Controls.Add(Me.btnremind3start)
        Me.grpalarm.Controls.Add(Me.btnremind1clear)
        Me.grpalarm.Controls.Add(Me.btnremind2clear)
        Me.grpalarm.Controls.Add(Me.btnremind2start)
        Me.grpalarm.Location = New System.Drawing.Point(792, 386)
        Me.grpalarm.Name = "grpalarm"
        Me.grpalarm.Size = New System.Drawing.Size(343, 244)
        Me.grpalarm.TabIndex = 48
        Me.grpalarm.TabStop = False
        Me.grpalarm.Text = "Choose a remineder and select which task you would like to be reminded for."
        '
        'rbtnreminder4
        '
        Me.rbtnreminder4.AutoSize = True
        Me.rbtnreminder4.Location = New System.Drawing.Point(6, 160)
        Me.rbtnreminder4.Name = "rbtnreminder4"
        Me.rbtnreminder4.Size = New System.Drawing.Size(17, 16)
        Me.rbtnreminder4.TabIndex = 33
        Me.rbtnreminder4.TabStop = True
        Me.rbtnreminder4.UseVisualStyleBackColor = True
        '
        'rbtnreminder3
        '
        Me.rbtnreminder3.AutoSize = True
        Me.rbtnreminder3.Location = New System.Drawing.Point(6, 121)
        Me.rbtnreminder3.Name = "rbtnreminder3"
        Me.rbtnreminder3.Size = New System.Drawing.Size(17, 16)
        Me.rbtnreminder3.TabIndex = 33
        Me.rbtnreminder3.TabStop = True
        Me.rbtnreminder3.UseVisualStyleBackColor = True
        '
        'rbtnreminder2
        '
        Me.rbtnreminder2.AutoSize = True
        Me.rbtnreminder2.Location = New System.Drawing.Point(6, 81)
        Me.rbtnreminder2.Name = "rbtnreminder2"
        Me.rbtnreminder2.Size = New System.Drawing.Size(17, 16)
        Me.rbtnreminder2.TabIndex = 33
        Me.rbtnreminder2.TabStop = True
        Me.rbtnreminder2.UseVisualStyleBackColor = True
        '
        'rbtnreminder1
        '
        Me.rbtnreminder1.AutoSize = True
        Me.rbtnreminder1.Location = New System.Drawing.Point(6, 42)
        Me.rbtnreminder1.Name = "rbtnreminder1"
        Me.rbtnreminder1.Size = New System.Drawing.Size(17, 16)
        Me.rbtnreminder1.TabIndex = 32
        Me.rbtnreminder1.TabStop = True
        Me.rbtnreminder1.UseVisualStyleBackColor = True
        '
        'txtreminder1
        '
        Me.txtreminder1.Location = New System.Drawing.Point(29, 42)
        Me.txtreminder1.Name = "txtreminder1"
        Me.txtreminder1.ReadOnly = True
        Me.txtreminder1.Size = New System.Drawing.Size(198, 22)
        Me.txtreminder1.TabIndex = 21
        '
        'txtreminder4
        '
        Me.txtreminder4.Location = New System.Drawing.Point(29, 160)
        Me.txtreminder4.Name = "txtreminder4"
        Me.txtreminder4.ReadOnly = True
        Me.txtreminder4.Size = New System.Drawing.Size(198, 22)
        Me.txtreminder4.TabIndex = 23
        '
        'btnremind4clear
        '
        Me.btnremind4clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind4clear.Location = New System.Drawing.Point(280, 160)
        Me.btnremind4clear.Name = "btnremind4clear"
        Me.btnremind4clear.Size = New System.Drawing.Size(57, 22)
        Me.btnremind4clear.TabIndex = 31
        Me.btnremind4clear.Text = "clear"
        Me.btnremind4clear.UseVisualStyleBackColor = True
        '
        'txtreminder3
        '
        Me.txtreminder3.Location = New System.Drawing.Point(29, 118)
        Me.txtreminder3.Name = "txtreminder3"
        Me.txtreminder3.ReadOnly = True
        Me.txtreminder3.Size = New System.Drawing.Size(198, 22)
        Me.txtreminder3.TabIndex = 22
        '
        'btnremind1start
        '
        Me.btnremind1start.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind1start.Location = New System.Drawing.Point(233, 39)
        Me.btnremind1start.Name = "btnremind1start"
        Me.btnremind1start.Size = New System.Drawing.Size(51, 25)
        Me.btnremind1start.TabIndex = 24
        Me.btnremind1start.Text = "Set"
        Me.btnremind1start.UseVisualStyleBackColor = True
        '
        'txtreminder2
        '
        Me.txtreminder2.Location = New System.Drawing.Point(29, 81)
        Me.txtreminder2.Name = "txtreminder2"
        Me.txtreminder2.ReadOnly = True
        Me.txtreminder2.Size = New System.Drawing.Size(198, 22)
        Me.txtreminder2.TabIndex = 20
        '
        'btnremind4start
        '
        Me.btnremind4start.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind4start.Location = New System.Drawing.Point(233, 160)
        Me.btnremind4start.Name = "btnremind4start"
        Me.btnremind4start.Size = New System.Drawing.Size(51, 22)
        Me.btnremind4start.TabIndex = 25
        Me.btnremind4start.Text = "Set"
        Me.btnremind4start.UseVisualStyleBackColor = True
        '
        'btnremind3clear
        '
        Me.btnremind3clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind3clear.Location = New System.Drawing.Point(280, 118)
        Me.btnremind3clear.Name = "btnremind3clear"
        Me.btnremind3clear.Size = New System.Drawing.Size(57, 25)
        Me.btnremind3clear.TabIndex = 26
        Me.btnremind3clear.Text = "clear"
        Me.btnremind3clear.UseVisualStyleBackColor = True
        '
        'btnremind3start
        '
        Me.btnremind3start.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind3start.Location = New System.Drawing.Point(233, 118)
        Me.btnremind3start.Name = "btnremind3start"
        Me.btnremind3start.Size = New System.Drawing.Size(51, 25)
        Me.btnremind3start.TabIndex = 30
        Me.btnremind3start.Text = "Set"
        Me.btnremind3start.UseVisualStyleBackColor = True
        '
        'btnremind1clear
        '
        Me.btnremind1clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind1clear.Location = New System.Drawing.Point(280, 39)
        Me.btnremind1clear.Name = "btnremind1clear"
        Me.btnremind1clear.Size = New System.Drawing.Size(57, 25)
        Me.btnremind1clear.TabIndex = 28
        Me.btnremind1clear.Text = "clear"
        Me.btnremind1clear.UseVisualStyleBackColor = True
        '
        'btnremind2clear
        '
        Me.btnremind2clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind2clear.Location = New System.Drawing.Point(280, 81)
        Me.btnremind2clear.Name = "btnremind2clear"
        Me.btnremind2clear.Size = New System.Drawing.Size(57, 23)
        Me.btnremind2clear.TabIndex = 29
        Me.btnremind2clear.Text = "clear"
        Me.btnremind2clear.UseVisualStyleBackColor = True
        '
        'btnremind2start
        '
        Me.btnremind2start.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnremind2start.Location = New System.Drawing.Point(233, 81)
        Me.btnremind2start.Name = "btnremind2start"
        Me.btnremind2start.Size = New System.Drawing.Size(51, 23)
        Me.btnremind2start.TabIndex = 27
        Me.btnremind2start.Text = "Set"
        Me.btnremind2start.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(895, 635)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 47
        Me.btnclear.Text = "Delete"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(1025, 635)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 46
        Me.btnback.Text = "Back "
        Me.btnback.UseVisualStyleBackColor = True
        '
        'List1
        '
        Me.List1.AutoSize = True
        Me.List1.Location = New System.Drawing.Point(483, 7)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(110, 17)
        Me.List1.TabIndex = 45
        Me.List1.Text = "Name of list one"
        '
        'pboxclose
        '
        Me.pboxclose.Image = CType(resources.GetObject("pboxclose.Image"), System.Drawing.Image)
        Me.pboxclose.Location = New System.Drawing.Point(1072, 7)
        Me.pboxclose.Name = "pboxclose"
        Me.pboxclose.Size = New System.Drawing.Size(41, 32)
        Me.pboxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxclose.TabIndex = 44
        Me.pboxclose.TabStop = False
        '
        'pboxmin
        '
        Me.pboxmin.Image = CType(resources.GetObject("pboxmin.Image"), System.Drawing.Image)
        Me.pboxmin.Location = New System.Drawing.Point(1025, 7)
        Me.pboxmin.Name = "pboxmin"
        Me.pboxmin.Size = New System.Drawing.Size(38, 32)
        Me.pboxmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxmin.TabIndex = 43
        Me.pboxmin.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(785, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(789, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Task"
        '
        'cboxtime
        '
        Me.cboxtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxtime.FormattingEnabled = True
        Me.cboxtime.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboxtime.Location = New System.Drawing.Point(918, 350)
        Me.cboxtime.Name = "cboxtime"
        Me.cboxtime.Size = New System.Drawing.Size(51, 24)
        Me.cboxtime.TabIndex = 40
        '
        'msktime
        '
        Me.msktime.Location = New System.Drawing.Point(786, 352)
        Me.msktime.Mask = "90:00"
        Me.msktime.Name = "msktime"
        Me.msktime.Size = New System.Drawing.Size(126, 22)
        Me.msktime.TabIndex = 39
        Me.msktime.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(789, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 39)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Please click on the date you would like the task to be set for:"
        '
        'lsvTasks
        '
        Me.lsvTasks.CheckBoxes = True
        Me.lsvTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tasks, Me.time, Me.Date1})
        Me.lsvTasks.FullRowSelect = True
        Me.lsvTasks.HideSelection = False
        Me.lsvTasks.Location = New System.Drawing.Point(12, 27)
        Me.lsvTasks.Name = "lsvTasks"
        Me.lsvTasks.Size = New System.Drawing.Size(767, 603)
        Me.lsvTasks.TabIndex = 37
        Me.lsvTasks.UseCompatibleStateImageBehavior = False
        Me.lsvTasks.View = System.Windows.Forms.View.Details
        '
        'tasks
        '
        Me.tasks.Text = "Tasks"
        Me.tasks.Width = 100
        '
        'time
        '
        Me.time.Text = "Time"
        Me.time.Width = 191
        '
        'Date1
        '
        Me.Date1.Text = "Date"
        Me.Date1.Width = 195
        '
        'txttask
        '
        Me.txttask.Location = New System.Drawing.Point(786, 305)
        Me.txttask.Name = "txttask"
        Me.txttask.Size = New System.Drawing.Size(184, 22)
        Me.txttask.TabIndex = 36
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(792, 76)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 35
        '
        'btnaddtask
        '
        Me.btnaddtask.Location = New System.Drawing.Point(976, 301)
        Me.btnaddtask.Name = "btnaddtask"
        Me.btnaddtask.Size = New System.Drawing.Size(88, 79)
        Me.btnaddtask.TabIndex = 34
        Me.btnaddtask.Text = "Add task"
        Me.btnaddtask.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'list1noty
        '
        Me.list1noty.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.list1noty.BalloonTipTitle = "To do list"
        Me.list1noty.Icon = CType(resources.GetObject("list1noty.Icon"), System.Drawing.Icon)
        '
        'Timer2
        '
        '
        'Timer4
        '
        '
        'Tmrlivetime
        '
        Me.Tmrlivetime.Enabled = True
        '
        'Frmlist3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 674)
        Me.Controls.Add(Me.lbllivetime)
        Me.Controls.Add(Me.grpalarm)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.pboxclose)
        Me.Controls.Add(Me.pboxmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxtime)
        Me.Controls.Add(Me.msktime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvTasks)
        Me.Controls.Add(Me.txttask)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btnaddtask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmlist3"
        Me.Text = "Form4"
        Me.grpalarm.ResumeLayout(False)
        Me.grpalarm.PerformLayout()
        CType(Me.pboxclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllivetime As Label
    Friend WithEvents grpalarm As GroupBox
    Friend WithEvents rbtnreminder4 As RadioButton
    Friend WithEvents rbtnreminder3 As RadioButton
    Friend WithEvents rbtnreminder2 As RadioButton
    Friend WithEvents rbtnreminder1 As RadioButton
    Friend WithEvents txtreminder1 As TextBox
    Friend WithEvents txtreminder4 As TextBox
    Friend WithEvents btnremind4clear As Button
    Friend WithEvents txtreminder3 As TextBox
    Friend WithEvents btnremind1start As Button
    Friend WithEvents txtreminder2 As TextBox
    Friend WithEvents btnremind4start As Button
    Friend WithEvents btnremind3clear As Button
    Friend WithEvents btnremind3start As Button
    Friend WithEvents btnremind1clear As Button
    Friend WithEvents btnremind2clear As Button
    Friend WithEvents btnremind2start As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnback As Button
    Friend WithEvents List1 As Label
    Friend WithEvents pboxclose As PictureBox
    Friend WithEvents pboxmin As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxtime As ComboBox
    Friend WithEvents msktime As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lsvTasks As ListView
    Friend WithEvents tasks As ColumnHeader
    Friend WithEvents time As ColumnHeader
    Friend WithEvents Date1 As ColumnHeader
    Friend WithEvents txttask As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnaddtask As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents list1noty As NotifyIcon
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Tmrlivetime As Timer
End Class
