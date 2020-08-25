Public Class F5___CMD
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
    Public WithEvents Text2 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents Text1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents Text3 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents VScroll1 As System.Windows.Forms.VScrollBar
    Public WithEvents Picture2 As System.Windows.Forms.Panel
    Public WithEvents _Text3_0 As System.Windows.Forms.TextBox
    Public WithEvents _Text2_0 As System.Windows.Forms.TextBox
    Public WithEvents _Text1_0 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton15 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton16 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton17 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton18 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(F5___CMD))
        Me.Text2 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me._Text2_0 = New System.Windows.Forms.TextBox()
        Me.Text1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me._Text1_0 = New System.Windows.Forms.TextBox()
        Me.Text3 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        Me._Text3_0 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.VScroll1 = New System.Windows.Forms.VScrollBar()
        Me.Picture2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton15 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton16 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton17 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton18 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        CType(Me.Text2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture1.SuspendLayout()
        Me.Picture2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Text2_0
        '
        Me._Text2_0.AcceptsReturn = True
        Me._Text2_0.AutoSize = False
        Me._Text2_0.BackColor = System.Drawing.SystemColors.Window
        Me._Text2_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text2_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text2_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.SetIndex(Me._Text2_0, CType(0, Short))
        Me._Text2_0.Location = New System.Drawing.Point(82, 0)
        Me._Text2_0.MaxLength = 0
        Me._Text2_0.Name = "_Text2_0"
        Me._Text2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text2_0.Size = New System.Drawing.Size(81, 25)
        Me._Text2_0.TabIndex = 4
        Me._Text2_0.Text = ""
        '
        '_Text1_0
        '
        Me._Text1_0.AcceptsReturn = True
        Me._Text1_0.AutoSize = False
        Me._Text1_0.BackColor = System.Drawing.SystemColors.Window
        Me._Text1_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.SetIndex(Me._Text1_0, CType(0, Short))
        Me._Text1_0.MaxLength = 0
        Me._Text1_0.Name = "_Text1_0"
        Me._Text1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text1_0.Size = New System.Drawing.Size(81, 25)
        Me._Text1_0.TabIndex = 3
        Me._Text1_0.Text = ""
        '
        '_Text3_0
        '
        Me._Text3_0.AcceptsReturn = True
        Me._Text3_0.AutoSize = False
        Me._Text3_0.BackColor = System.Drawing.SystemColors.Window
        Me._Text3_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text3_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Text3_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.SetIndex(Me._Text3_0, CType(0, Short))
        Me._Text3_0.Location = New System.Drawing.Point(168, 0)
        Me._Text3_0.MaxLength = 0
        Me._Text3_0.Name = "_Text3_0"
        Me._Text3_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text3_0.Size = New System.Drawing.Size(81, 25)
        Me._Text3_0.TabIndex = 5
        Me._Text3_0.Text = ""
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.AddRange(New System.Windows.Forms.Control() {Me.VScroll1, Me.Picture2})
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(304, 120)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(280, 156)
        Me.Picture1.TabIndex = 10
        Me.Picture1.TabStop = True
        '
        'VScroll1
        '
        Me.VScroll1.Cursor = System.Windows.Forms.Cursors.Default
        Me.VScroll1.LargeChange = 1000
        Me.VScroll1.Location = New System.Drawing.Point(254, 0)
        Me.VScroll1.Maximum = 33766
        Me.VScroll1.Name = "VScroll1"
        Me.VScroll1.Size = New System.Drawing.Size(20, 152)
        Me.VScroll1.SmallChange = 500
        Me.VScroll1.TabIndex = 2
        Me.VScroll1.TabStop = True
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.SystemColors.Control
        Me.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture2.Controls.AddRange(New System.Windows.Forms.Control() {Me._Text3_0, Me._Text2_0, Me._Text1_0})
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(254, 30)
        Me.Picture2.TabIndex = 1
        Me.Picture2.TabStop = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(600, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 131
        Me.Button3.Text = "Unload"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(600, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 130
        Me.Button2.Text = "Load"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
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
        Me.ToolBar1.Size = New System.Drawing.Size(688, 33)
        Me.ToolBar1.TabIndex = 132
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
        'ToolBarButton17
        '
        Me.ToolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 9
        Me.ToolBarButton3.ToolTipText = "Delete"
        '
        'ToolBarButton18
        '
        Me.ToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 5
        Me.ToolBarButton5.ToolTipText = "Search"
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 1
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 3
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 2
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 0
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 4
        Me.ToolBarButton11.ToolTipText = "Exit"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(176, 280)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 140
        Me.TextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "City Code"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(176, 120)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 134
        Me.TextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Street Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Customer Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 32)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Customer Transaction"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(176, 152)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 135
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 18)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Customer Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "State Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Phone No"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(176, 184)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox1.TabIndex = 146
        '
        'ComboBox2
        '
        Me.ComboBox2.Location = New System.Drawing.Point(176, 216)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox2.TabIndex = 147
        '
        'ComboBox3
        '
        Me.ComboBox3.Location = New System.Drawing.Point(176, 248)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox3.TabIndex = 148
        '
        'F5___CMD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 325)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox3, Me.ComboBox2, Me.ComboBox1, Me.Label7, Me.Label6, Me.TextBox3, Me.Label5, Me.TextBox1, Me.Label4, Me.Label2, Me.Label1, Me.TextBox2, Me.Label3, Me.Button3, Me.Button2, Me.Picture1, Me.ToolBar1})
        Me.Name = "F5___CMD"
        Me.Text = "F5___CMD"
        CType(Me.Text2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture1.ResumeLayout(False)
        Me.Picture2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim i As Integer
    Dim cn As New ADODB.Connection()
    Dim rs As New ADODB.Recordset()
    Dim rs1 As New ADODB.Recordset()
    Dim rs2 As New ADODB.Recordset()
    Dim temp As New ADODB.Recordset()
    Dim k As Integer
    Dim kk As Integer
    Dim j As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call loader()
    End Sub
    Sub loader()
        Button3.Enabled = True
        Picture2.Height = Picture2.Height + Text1(0).Height
        VScroll1.Maximum = Picture2.Height - 100 + VScroll1.LargeChange - 1

        i = i + 1

        Text1.Load(i)
        Text1(i).Visible = True
        Text1(i).Top = Text1(i - 1).Top + Text1(i).Height

        Text2.Load(i)
        Text2(i).Visible = True
        Text2(i).Top = Text2(i - 1).Top + Text2(i).Height

        Text3.Load(i)
        Text3(i).Visible = True
        Text3(i).Top = Text3(i - 1).Top + Text3(i).Height


    End Sub
    Sub unloader()
        If i <> 0 Then
            Text1.Unload(i)
            Text2.Unload(i)
            Text3.Unload(i)
            i = i - 1
            Picture2.Height = Picture2.Height - Text1(0).Height
            VScroll1.Maximum = Picture2.Height + 150 - VScroll1.LargeChange - 1
        Else
            MsgBox("Cannot Unload Controls of Design Time")
            Button3.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call unloader()
    End Sub

    Private Sub VScroll1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScroll1.Scroll
        Picture2.Top = 0 - VScroll1.Value
    End Sub

    Private Sub F5___CMD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open("Provider=OraOLEDB.ORACLE;USer Id=akshay;Password=akshay;Data SOurce=orcl")
        rs.Open("Select * from cust_mast", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs1.Open("Select * from cust_det", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    End Sub
    Private Sub empary()
        While i <> 0
            Call unloader()
        End While
    End Sub
    Private Sub ShowRS()
        Call empary()
        TextBox1.Text = rs.Fields(0).Value
        TextBox2.Text = rs.Fields(1).Value
        ComboBox1.Text = rs.Fields(2).Value
        ComboBox2.Text = rs.Fields(3).Value
        ComboBox3.Text = rs.Fields(4).Value
        TextBox3.Text = rs.Fields(5).Value
        temp.Open("select * from cust_det where cust_code = " & TextBox1.Text, cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not temp.EOF
            Text1(i).Text = temp.Fields(1).Value
            Text2(i).Text = temp.Fields(2).Value
            Text3(i).Text = temp.Fields(3).Value
            temp.MoveNext()
            Call loader()
        End While
        Call unloader()
        temp.Close()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If ToolBar1.Buttons.IndexOf(e.Button) = 2 Then
            'Add
            Clear()
            Call empary()
            rs2.Open("select nvl(max(cust_code),0) from cust_mast", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            k = rs2.Fields(0).Value
            k = k + 1
            TextBox1.Text = k
            rs2.Close()
            TextBox1.Focus()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 3 Then
            'Save
            'Check()
            rs.AddNew()
            rs.Fields(0).Value = TextBox1.Text
            rs.Fields(1).Value = TextBox2.Text
            rs.Fields(2).Value = ComboBox1.Text
            rs.Fields(3).Value = ComboBox2.Text
            rs.Fields(4).Value = ComboBox3.Text
            rs.Fields(5).Value = TextBox3.Text
            rs.Update()

            For j = 0 To i
                rs1.AddNew()
                rs1.Fields(0).Value = TextBox1.Text
                rs1.Fields(1).Value = Text1(j).Text
                rs1.Fields(2).Value = Text2(j).Text
                rs1.Fields(3).Value = Text3(j).Text
                rs1.Update()
            Next
            Clear()
            Call empary()
            MessageBox.Show("Record Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 5 Then
            'Modify
            Dim i As Integer
            Try
                i = InputBox("Enter the  Customer Code", "Modify")
                rs.Requery()
                rs.MoveFirst()
                rs.Find("Cust_code=" & i)
                If rs.EOF Then
                    MessageBox.Show("Record not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ShowRS()
                End If
            Catch ex1 As Exception
                MessageBox.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 6 Then
            'Update
            rs.Fields(0).Value = TextBox1.Text
            rs.Fields(1).Value = TextBox2.Text
            rs.Fields(2).Value = ComboBox1.Text
            rs.Fields(3).Value = ComboBox2.Text
            rs.Fields(4).Value = ComboBox3.Text
            rs.Fields(5).Value = TextBox3.Text
            rs.Update()
            temp.Open("select * from Cust_det where cust_code = " & TextBox1.Text, cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            j = 0
            While Not temp.EOF
                temp.Fields(0).Value = TextBox1.Text
                temp.Fields(1).Value = Text1(j).Text
                temp.Fields(2).Value = Text2(j).Text
                temp.Fields(3).Value = Text3(j).Text
                temp.Update()
                temp.MoveNext()
                j = j + 1
            End While
            temp.Close()
            rs.Requery()
            rs1.Requery()
            Clear()
            Call empary()
            MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 8 Then
            'Delete
            Dim i As Integer
            Try
                i = InputBox("Enter the  Customer Code", "Modify")
                rs.Requery()
                rs.MoveFirst()
                rs.Find("cust_code=" & i)
                If rs.EOF Then
                    MessageBox.Show("Record not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ShowRS()
                    kk = MessageBox.Show("Are you sure to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    If kk = vbYes Then
                        temp.Open("select * from Cust_det where cust_code = " & TextBox1.Text, cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                        While Not temp.EOF
                            temp.Delete()
                            temp.MoveNext()
                        End While
                        temp.Close()
                        rs.Delete()
                        MessageBox.Show("Record Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clear()
                        Call empary()
                        rs.Requery()
                        rs1.Requery()
                    Else
                        ShowRS()
                    End If
                End If
            Catch ex1 As Exception
                MessageBox.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 10 Then
            'Search
            Dim i As Integer
            Try
                i = InputBox("Enter the  Customer Code", "Modify")
                rs.Requery()
                rs.MoveFirst()
                rs.Find("cust_code=" & i)
                If rs.EOF Then
                    MessageBox.Show("Record not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ShowRS()
                End If
            Catch ex1 As Exception
                MessageBox.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 12 Then
            'Move Previous
            rs.Requery()
            rs.MovePrevious()
            If rs.BOF Then
                rs.MoveFirst()
            End If
            ShowRS()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 13 Then
            'Move First
            rs.Requery()
            rs.MoveFirst()
            ShowRS()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 14 Then
            'Move Last
            rs.Requery()
            rs.MoveLast()
            ShowRS()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 15 Then
            'Move Next
            rs.Requery()
            rs.MoveNext()
            If rs.EOF Then
                rs.MoveLast()
            End If
            ShowRS()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 17 Then
            'Exit
            Me.Close()
        End If
    End Sub
    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Text1(0).Text = ""
        Text2(0).Text = ""
        Text3(0).Text = ""
    End Sub
End Class
