<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Input_H = New System.Windows.Forms.TextBox()
        Me.Input_S = New System.Windows.Forms.TextBox()
        Me.Input_L = New System.Windows.Forms.TextBox()
        Me.Output_H = New System.Windows.Forms.TextBox()
        Me.Output_S = New System.Windows.Forms.TextBox()
        Me.Output_L = New System.Windows.Forms.TextBox()
        Me.Clear_Input_H = New System.Windows.Forms.Button()
        Me.Clear_Input_S = New System.Windows.Forms.Button()
        Me.Clear_Input_L = New System.Windows.Forms.Button()
        Me.H = New System.Windows.Forms.Label()
        Me.S = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.ColorConverter = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Input_H
        '
        Me.Input_H.Location = New System.Drawing.Point(114, 14)
        Me.Input_H.Name = "Input_H"
        Me.Input_H.Size = New System.Drawing.Size(100, 20)
        Me.Input_H.TabIndex = 0
        Me.Input_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Input_S
        '
        Me.Input_S.Location = New System.Drawing.Point(114, 43)
        Me.Input_S.Name = "Input_S"
        Me.Input_S.Size = New System.Drawing.Size(100, 20)
        Me.Input_S.TabIndex = 1
        Me.Input_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Input_L
        '
        Me.Input_L.Location = New System.Drawing.Point(114, 72)
        Me.Input_L.Name = "Input_L"
        Me.Input_L.Size = New System.Drawing.Size(100, 20)
        Me.Input_L.TabIndex = 2
        Me.Input_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Output_H
        '
        Me.Output_H.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Output_H.Location = New System.Drawing.Point(220, 14)
        Me.Output_H.Name = "Output_H"
        Me.Output_H.Size = New System.Drawing.Size(100, 20)
        Me.Output_H.TabIndex = 3
        Me.Output_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Output_S
        '
        Me.Output_S.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Output_S.Location = New System.Drawing.Point(220, 43)
        Me.Output_S.Name = "Output_S"
        Me.Output_S.Size = New System.Drawing.Size(100, 20)
        Me.Output_S.TabIndex = 4
        Me.Output_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Output_L
        '
        Me.Output_L.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Output_L.Location = New System.Drawing.Point(220, 72)
        Me.Output_L.Name = "Output_L"
        Me.Output_L.Size = New System.Drawing.Size(100, 20)
        Me.Output_L.TabIndex = 5
        Me.Output_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Clear_Input_H
        '
        Me.Clear_Input_H.Location = New System.Drawing.Point(12, 12)
        Me.Clear_Input_H.Name = "Clear_Input_H"
        Me.Clear_Input_H.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Input_H.TabIndex = 6
        Me.Clear_Input_H.Text = "Clear"
        Me.Clear_Input_H.UseVisualStyleBackColor = True
        '
        'Clear_Input_S
        '
        Me.Clear_Input_S.Location = New System.Drawing.Point(12, 41)
        Me.Clear_Input_S.Name = "Clear_Input_S"
        Me.Clear_Input_S.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Input_S.TabIndex = 7
        Me.Clear_Input_S.Text = "Clear"
        Me.Clear_Input_S.UseVisualStyleBackColor = True
        '
        'Clear_Input_L
        '
        Me.Clear_Input_L.Location = New System.Drawing.Point(12, 70)
        Me.Clear_Input_L.Name = "Clear_Input_L"
        Me.Clear_Input_L.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Input_L.TabIndex = 8
        Me.Clear_Input_L.Text = "Clear"
        Me.Clear_Input_L.UseVisualStyleBackColor = True
        '
        'H
        '
        Me.H.AutoSize = True
        Me.H.Location = New System.Drawing.Point(93, 17)
        Me.H.Name = "H"
        Me.H.Size = New System.Drawing.Size(15, 13)
        Me.H.TabIndex = 9
        Me.H.Text = "H"
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.Location = New System.Drawing.Point(93, 46)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(14, 13)
        Me.S.TabIndex = 10
        Me.S.Text = "S"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(93, 75)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(13, 13)
        Me.L.TabIndex = 11
        Me.L.Text = "L"
        '
        'ColorConverter
        '
        Me.ColorConverter.AutoSize = True
        Me.ColorConverter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorConverter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ColorConverter.Location = New System.Drawing.Point(262, 118)
        Me.ColorConverter.Name = "ColorConverter"
        Me.ColorConverter.Size = New System.Drawing.Size(80, 13)
        Me.ColorConverter.TabIndex = 12
        Me.ColorConverter.TabStop = True
        Me.ColorConverter.Text = "Color Converter"
        Me.ColorConverter.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Convert the color you want to HSL with the color converter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Put your converted HSL values in the left boxes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 140)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColorConverter)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.S)
        Me.Controls.Add(Me.H)
        Me.Controls.Add(Me.Clear_Input_L)
        Me.Controls.Add(Me.Clear_Input_S)
        Me.Controls.Add(Me.Clear_Input_H)
        Me.Controls.Add(Me.Output_L)
        Me.Controls.Add(Me.Output_S)
        Me.Controls.Add(Me.Output_H)
        Me.Controls.Add(Me.Input_L)
        Me.Controls.Add(Me.Input_S)
        Me.Controls.Add(Me.Input_H)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(370, 179)
        Me.MinimumSize = New System.Drawing.Size(370, 179)
        Me.Name = "Form1"
        Me.Text = "idk what im doing OwO notices y..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input_H As TextBox
    Friend WithEvents Input_S As TextBox
    Friend WithEvents Input_L As TextBox
    Friend WithEvents Output_H As TextBox
    Friend WithEvents Output_S As TextBox
    Friend WithEvents Output_L As TextBox
    Friend WithEvents Clear_Input_H As Button
    Friend WithEvents Clear_Input_S As Button
    Friend WithEvents Clear_Input_L As Button
    Friend WithEvents H As Label
    Friend WithEvents S As Label
    Friend WithEvents L As Label
    Friend WithEvents ColorConverter As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
