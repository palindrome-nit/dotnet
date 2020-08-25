Public Class F1___TTM
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(F1___TTM))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Transport Type Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Transport Type Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Transport Type Id"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(264, 120)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(264, 152)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Transport Type Master"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(264, 184)
        Me.TextBox3.MaxLength = 30
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(152, 64)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = ""
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
        Me.ToolBar1.Size = New System.Drawing.Size(464, 33)
        Me.ToolBar1.TabIndex = 113
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
        'F1___TTM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 285)
        Me.ControlBox = False
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.Label3, Me.Label2, Me.TextBox1, Me.TextBox2, Me.Label1, Me.TextBox3, Me.ToolBar1})
        Me.Name = "F1___TTM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transport Type Master"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim rs As New ADODB.Recordset()
    Dim rs1 As New ADODB.Recordset()
    Dim k As Integer

    Private Sub F1___TTM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            rs.Open("select * from trans_type_mast", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            'FetchRecTTM()
        Catch rsex As Exception
            MessageBox.Show("Error : " & rsex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
        End Try

    End Sub

    Private Sub FetchRecTTM()
        Try
            TextBox1.Text = rs.Fields(0).Value
            TextBox2.Text = rs.Fields(1).Value
            TextBox3.Text = rs.Fields(2).Value
        Catch feterr As Exception
            MessageBox.Show("Error : " & feterr.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If ToolBar1.Buttons.IndexOf(e.Button) = 2 Then
            'Add
            Clear()
            rs1.Open("select nvl(max(ttid),0) from trans_type_mast", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
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
            ElseIf TextBox3.Text = "" Then
                MessageBox.Show("Enter all the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox3.Focus()
            Else
                rs.AddNew()
                rs.Fields(0).Value = CInt(TextBox1.Text)
                rs.Fields(1).Value = TextBox2.Text.ToString
                rs.Fields(2).Value = TextBox3.Text.ToString
                rs.Update()
                TextBox1.Enabled = True
                Clear()
                MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 5 Then
            'Modify
            Dim id As Integer
            Try
                id = InputBox("Enter the Transport Type Id")
                rs.MoveFirst()
                rs.Find("ttid=" & id)
                If rs.EOF Then
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FetchRecTTM()
                End If
            Catch e2 As Exception
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 6 Then
            'Update
            rs.Fields(0).Value = CInt(TextBox1.Text)
            rs.Fields(1).Value = TextBox2.Text.ToString
            rs.Fields(2).Value = TextBox3.Text.ToString
            rs.Update()
            MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clear()
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 8 Then
            'Delete
            Dim id1 As Integer
            Dim msg As String
            Try
                id1 = InputBox("Enter the Transport Type Id")
                rs.MoveFirst()
                rs.Find("ttid=" & id1)
                If rs.EOF Then
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FetchRecTTM()
                    msg = MessageBox.Show("Are u sure to delete the record", "Validate", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    If msg = vbYes Then
                        rs.Delete()
                        Clear()
                    Else
                        FetchRecTTM()
                    End If
                End If
            Catch e2 As Exception
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 10 Then
            'Search
            Dim id As Integer
            Try
                id = InputBox("Enter the Transport Type Id")
                rs.MoveFirst()
                rs.Find("ttid=" & id)
                If rs.EOF Then
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    FetchRecTTM()
                End If
            Catch e2 As Exception
                MessageBox.Show(e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 12 Then
            'Move Previous
            Try
                rs.MovePrevious()
                If rs.BOF Then
                    rs.MoveFirst()
                End If
                FetchRecTTM()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 13 Then
            'Move First
            Try
                rs.MoveFirst()
                FetchRecTTM()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 14 Then
            'Move Last
            Try
                rs.MoveLast()
                FetchRecTTM()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 15 Then
            'Move Next
            Try
                rs.MoveNext()
                If rs.EOF Then
                    rs.MoveLast()
                End If
                FetchRecTTM()
            Catch emp As Exception
                MessageBox.Show(emp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf ToolBar1.Buttons.IndexOf(e.Button) = 17 Then
                'Exit
            Me.Close()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then e.Handled = True
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then e.Handled = True
    End Sub

    Private Sub Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

End Class
