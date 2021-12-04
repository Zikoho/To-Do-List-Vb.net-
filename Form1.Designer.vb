<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtodoselect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtodoselect))
        Me.Btncreate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.lbllist1disabled = New System.Windows.Forms.Label()
        Me.lbllist2disabled = New System.Windows.Forms.Label()
        Me.lbllist3disabled = New System.Windows.Forms.Label()
        Me.pboxclose0 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pboxclose0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btncreate
        '
        Me.Btncreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncreate.Location = New System.Drawing.Point(672, 419)
        Me.Btncreate.Name = "Btncreate"
        Me.Btncreate.Size = New System.Drawing.Size(49, 45)
        Me.Btncreate.TabIndex = 0
        Me.Btncreate.Text = "+"
        Me.Btncreate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(495, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Create list"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(495, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Create list"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(495, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Create list"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(452, 510)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 16
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'lbllist1disabled
        '
        Me.lbllist1disabled.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbllist1disabled.Location = New System.Drawing.Point(32, 39)
        Me.lbllist1disabled.Name = "lbllist1disabled"
        Me.lbllist1disabled.Size = New System.Drawing.Size(495, 41)
        Me.lbllist1disabled.TabIndex = 17
        Me.lbllist1disabled.Text = "List 1 is active, you will not be allowed to create another list. Try keeping you" &
    "r todolist minimized until you are done with it."
        Me.lbllist1disabled.Visible = False
        '
        'lbllist2disabled
        '
        Me.lbllist2disabled.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbllist2disabled.Location = New System.Drawing.Point(32, 210)
        Me.lbllist2disabled.Name = "lbllist2disabled"
        Me.lbllist2disabled.Size = New System.Drawing.Size(495, 41)
        Me.lbllist2disabled.TabIndex = 18
        Me.lbllist2disabled.Text = "List 2 is active, you will not be allowed to create another list. Try keeping you" &
    "r todolist minimized until you are done with it."
        Me.lbllist2disabled.Visible = False
        '
        'lbllist3disabled
        '
        Me.lbllist3disabled.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbllist3disabled.Location = New System.Drawing.Point(32, 394)
        Me.lbllist3disabled.Name = "lbllist3disabled"
        Me.lbllist3disabled.Size = New System.Drawing.Size(495, 41)
        Me.lbllist3disabled.TabIndex = 19
        Me.lbllist3disabled.Text = "List 3 is active, you will not be allowed to create another list. Try keeping you" &
    "r todolist minimized until you are done with it."
        Me.lbllist3disabled.Visible = False
        '
        'pboxclose0
        '
        Me.pboxclose0.Image = CType(resources.GetObject("pboxclose0.Image"), System.Drawing.Image)
        Me.pboxclose0.Location = New System.Drawing.Point(738, 2)
        Me.pboxclose0.Name = "pboxclose0"
        Me.pboxclose0.Size = New System.Drawing.Size(41, 32)
        Me.pboxclose0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxclose0.TabIndex = 21
        Me.pboxclose0.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "To-Do-List Select"
        '
        'frmtodoselect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pboxclose0)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Btncreate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbllist1disabled)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbllist3disabled)
        Me.Controls.Add(Me.lbllist2disabled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmtodoselect"
        Me.Text = "To do List"
        CType(Me.pboxclose0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btncreate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents lbllist1disabled As Label
    Friend WithEvents lbllist2disabled As Label
    Friend WithEvents lbllist3disabled As Label
    Friend WithEvents pboxclose0 As PictureBox
    Friend WithEvents Label1 As Label
End Class
