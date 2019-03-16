<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Edit_User_Control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Course = New System.Windows.Forms.TextBox()
        Me.Name2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Search_Click = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Research_Interest = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Search_Panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(133, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 42)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "No Record Present"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(82, 255)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(519, 126)
        Me.ListBox1.TabIndex = 22
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(483, 423)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(33, 4)
        Me.ListBox2.TabIndex = 23
        '
        'Back_Button
        '
        Me.Back_Button.BackColor = System.Drawing.Color.OrangeRed
        Me.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Back_Button.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Back_Button.Location = New System.Drawing.Point(277, 521)
        Me.Back_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(89, 30)
        Me.Back_Button.TabIndex = 25
        Me.Back_Button.Text = "Go Back"
        Me.Back_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(160, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 42)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Record of Teachers"
        '
        'Course
        '
        Me.Course.Location = New System.Drawing.Point(545, 69)
        Me.Course.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(89, 20)
        Me.Course.TabIndex = 40
        '
        'Name2
        '
        Me.Name2.Location = New System.Drawing.Point(108, 69)
        Me.Name2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(89, 20)
        Me.Name2.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 22)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Research Interest"
        '
        'Search_Click
        '
        Me.Search_Click.BackColor = System.Drawing.Color.OrangeRed
        Me.Search_Click.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Search_Click.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.Search_Click.ForeColor = System.Drawing.Color.White
        Me.Search_Click.Location = New System.Drawing.Point(260, 171)
        Me.Search_Click.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Search_Click.Name = "Search_Click"
        Me.Search_Click.Size = New System.Drawing.Size(149, 39)
        Me.Search_Click.TabIndex = 42
        Me.Search_Click.Text = "Search"
        Me.Search_Click.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(468, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Course"
        '
        'Dept
        '
        Me.Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dept.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept.FormattingEnabled = True
        Me.Dept.Items.AddRange(New Object() {"None", "Biotechnology", "Chemical", "Chemistry", "Civil", "CSE", "Design", "ECE and EEE", "HSS", "Mathematics", "Mechancial", "Physics"})
        Me.Dept.Location = New System.Drawing.Point(328, 69)
        Me.Dept.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(135, 25)
        Me.Dept.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 22)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Department"
        '
        'Research_Interest
        '
        Me.Research_Interest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Research_Interest.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Research_Interest.FormattingEnabled = True
        Me.Research_Interest.Items.AddRange(New Object() {"None", "Biodiversity", "Genetics", "Chemical Equilbrium", "Thermodynamics", "Cementious Materil", "Structural Mechanics", "Artificial Intelligence", "DS and Algorithms", "Networking", "Operating Systems", "Systems and Databases", "Architecture", "Ergonomics Research", "Communication Networks", "Speech and Image Processing", "Literature And Culture", "Economics", "Psychology", "Algebra and Geometry", "Cryptography and Finance", "Number Theory and Probabilty", "Machine Design", "Materials", "High Energy Physics", "Matter Physics", "Photonics", "Other(s)"})
        Me.Research_Interest.Location = New System.Drawing.Point(302, 119)
        Me.Research_Interest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Research_Interest.Name = "Research_Interest"
        Me.Research_Interest.Size = New System.Drawing.Size(259, 25)
        Me.Research_Interest.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Name"
        '
        'Search_Panel
        '
        Me.Search_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Search_Panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Search_Panel.Name = "Search_Panel"
        Me.Search_Panel.Size = New System.Drawing.Size(678, 515)
        Me.Search_Panel.TabIndex = 47
        '
        'Admin_Edit_User_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Search_Panel)
        Me.Controls.Add(Me.Course)
        Me.Controls.Add(Me.Name2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Search_Click)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dept)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Research_Interest)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Admin_Edit_User_Control"
        Me.Size = New System.Drawing.Size(682, 553)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Course As System.Windows.Forms.TextBox
    Friend WithEvents Name2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Search_Click As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Dept As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Research_Interest As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Search_Panel As System.Windows.Forms.Panel

End Class
