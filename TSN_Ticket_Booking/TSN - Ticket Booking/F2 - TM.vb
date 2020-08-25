Public Class F2___TM
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolBarButton18 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton17 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(F2___TM))
        Me.ToolBarButton18 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton17 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ToolBarButton18
        '
        Me.ToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 9
        Me.ToolBarButton3.ToolTipText = "Delete"
        '
        'ToolBarButton17
        '
        Me.ToolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 1
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 0
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 4
        Me.ToolBarButton11.ToolTipText = "Exit"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 3
        '
        'ToolBar1
        '
        Me.ToolBar1.AllowDrop = True
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton14, Me.ToolBarButton13, Me.ToolBarButton1, Me.ToolBarButton4, Me.ToolBarButton15, Me.ToolBarButton2, Me.ToolBarButton16, Me.ToolBarButton17, Me.ToolBarButton3, Me.ToolBarButton18, Me.ToolBarButton5, Me.ToolBarButton12, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton10, Me.ToolBarButton11})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(42, 42)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(584, 33)
        Me.ToolBar1.TabIndex = 121
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 8
        Me.ToolBarButton1.ToolTipText = "Insert Value"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 7
        Me.ToolBarButton4.ToolTipText = "Save"
        '
        'ToolBarButton15
        '
        Me.ToolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 6
        Me.ToolBarButton2.ToolTipText = "Modify"
        '
        'ToolBarButton16
        '
        Me.ToolBarButton16.ImageIndex = 7
        Me.ToolBarButton16.ToolTipText = "Update"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 5
        Me.ToolBarButton5.ToolTipText = "Search"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 2
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 32)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Transport  Master"
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp2.Location = New System.Drawing.Point(448, 216)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(104, 20)
        Me.dtp2.TabIndex = 211
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp1.Location = New System.Drawing.Point(448, 184)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(104, 20)
        Me.dtp1.TabIndex = 210
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(448, 120)
        Me.TextBox7.MaxLength = 20
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.TabIndex = 207
        Me.TextBox7.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(184, 248)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.TabIndex = 205
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(184, 216)
        Me.TextBox4.MaxLength = 20
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.TabIndex = 204
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(184, 184)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 203
        Me.TextBox3.Text = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(448, 280)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox2.TabIndex = 209
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(448, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 208
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(184, 280)
        Me.TextBox6.MaxLength = 20
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.TabIndex = 206
        Me.TextBox6.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(304, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 18)
        Me.Label12.TabIndex = 202
        Me.Label12.Text = "Route Id"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(304, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 18)
        Me.Label11.TabIndex = 201
        Me.Label11.Text = "Transport Type Id"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 200
        Me.Label10.Text = "Reach Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "Start Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "Destination"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Start Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 18)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Rate Major"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 195
        Me.Label5.Text = "Rate Minor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Capacity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Transport Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 192
        Me.Label2.Text = "Transport Id"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 120)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 190
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 152)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 191
        Me.TextBox2.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 18)
        Me.Label13.TabIndex = 212
        Me.Label13.Text = "Measuring Units"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(448, 152)
        Me.TextBox8.MaxLength = 20
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.TabIndex = 213
        Me.TextBox8.Text = ""
        '
        'F2___TM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 333)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox8, Me.Label13, Me.dtp2, Me.dtp1, Me.TextBox7, Me.TextBox5, Me.TextBox4, Me.TextBox3, Me.ComboBox2, Me.ComboBox1, Me.TextBox6, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.TextBox1, Me.TextBox2, Me.ToolBar1, Me.Label1})
        Me.Name = "F2___TM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transport Master"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim i As Integer
    Dim rs As New ADODB.Recordset()
    Dim rs1 As New ADODB.Recordset()
    Dim k As Integer
    Dim kk As String

    Private Sub ShowRS()
        If rs.EOF Or rs.BOF Then
            'MessageBox.Show("Record Does Not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TextBox1.Text = rs.Fields(0).Value
            TextBox2.Text = rs.Fields(1).Value
            TextBox3.Text = rs.Fields(2).Value
            TextBox4.Text = rs.Fields(3).Value
            TextBox5.Text = rs.Fields(4).Value
            TextBox6.Text = rs.Fields(5).Value
            TextBox7.Text = rs.Fields(6).Value
            TextBox8.Text = rs.Fields(7).Value
            dtp1.Value = rs.Fields(8).Value
            dtp2.Value = rs.Fields(9).Value
            ComboBox1.Text = rs.Fields(10).Value
            ComboBox2.Text = rs.Fields(11).Value
        End If
    End Sub

    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub F2___TM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            rs.Open("select * from trans_mast", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            ShowRS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If ToolBar1.Buttons.IndexOf(e.Button) = 2 Then
            'Add
            Clear()
            rs1.Open("select nvl(max(tid),0) from trans_mast", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            k = rs1.Fields(0).Value
            k = k + 1
            TextBox1.Text = k
            TextBox1.Enabled = False
            TextBox2.Focus()
            rs1.Close()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 3 Then
            'Save
            If TextBox2.Text = "" Then
                MessageBox.Show("Enter all the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.Focus()
            Else
                rs.AddNew()
                rs.Fields(0).Value = CInt(TextBox1.Text)
                rs.Fields(1).Value = TextBox2.Text.ToString
                rs.Fields(2).Value = TextBox3.Text.ToString
                rs.Fields(3).Value = TextBox4.Text.ToString
                rs.Fields(4).Value = TextBox5.Text.ToString
                rs.Fields(5).Value = TextBox6.Text.ToString
                rs.Fields(6).Value = TextBox7.Text.ToString
                rs.Fields(7).Value = TextBox8.Text.ToString
                rs.Fields(8).Value = dtp1.Value
                rs.Fields(9).Value = dtp2.Value
                rs.Fields(10).Value = ComboBox1.Text
                rs.Fields(11).Value = ComboBox2.Text
                rs.Update()
                TextBox1.Enabled = True
                Clear()
                MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 5 Then
            'Modify
            Dim id As Integer
            Try
                id = InputBox("Enter the trans Code")
                rs.Requery()
                rs.MoveFirst()
                rs.Find("tid=" & id)
                If rs.EOF Then
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ShowRS()
                    TextBox1.Enabled = False
                End If
            Catch e2 As Exception
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 6 Then
            'Update
            rs.Fields(0).Value = CInt(TextBox1.Text)
            rs.Fields(1).Value = TextBox2.Text.ToString
            rs.Fields(2).Value = TextBox3.Text.ToString
            rs.Fields(3).Value = TextBox4.Text.ToString
            rs.Fields(4).Value = TextBox5.Text.ToString
            rs.Fields(5).Value = TextBox6.Text.ToString
            rs.Fields(6).Value = TextBox7.Text.ToString
            rs.Fields(7).Value = TextBox8.Text.ToString
            rs.Fields(8).Value = dtp1.Value
            rs.Fields(9).Value = dtp2.Value
            rs.Fields(10).Value = ComboBox1.Text
            rs.Fields(11).Value = ComboBox2.Text
            rs.Update()
            TextBox1.Enabled = True
            MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 8 Then
            'Delete
            Dim id1 As Integer
            Dim msg As String
            Try
                id1 = InputBox("Enter the trans Code")
                rs.Requery()
                rs.MoveFirst()
                rs.Find("tid=" & id1)
                If rs.EOF Then
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ShowRS()
                    msg = MessageBox.Show("Are u sure to delete the record", "Validate", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    If msg = vbYes Then
                        rs.Delete()
                        MessageBox.Show("Record Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clear()
                    Else
                        ShowRS()
                    End If
                End If
            Catch e2 As Exception
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 10 Then
            'Search
            Dim id As Integer
            Try
                id = InputBox("Enter the trans Code")
                rs.Requery()
                rs.MoveFirst()
                rs.Find("tid=" & id)
                If rs.EOF Then
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ShowRS()
                End If
            Catch e2 As Exception
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 12 Then
            'Move Previous
            Try
                rs.Requery()
                rs.MovePrevious()
                If rs.BOF Then
                    rs.MoveFirst()
                End If
                ShowRS()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 13 Then
            'Move First
            Try
                rs.Requery()
                rs.MoveFirst()
                ShowRS()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 14 Then
            'Move Last
            Try
                rs.Requery()
                rs.MoveLast()
                ShowRS()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 15 Then
            'Move Next
            Try
                rs.Requery()
                rs.MoveNext()
                If rs.EOF Then
                    rs.MoveLast()
                End If
                ShowRS()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 17 Then
            'Exit
            Me.Close()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then e.Handled = True
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then e.Handled = True
    End Sub
End Class
