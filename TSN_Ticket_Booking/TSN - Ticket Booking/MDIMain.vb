Public Class MDIMain

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MDIMain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem11, Me.MenuItem12})
        Me.MainMenu1.RightToLeft = CType(resources.GetObject("MainMenu1.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = CType(resources.GetObject("MenuItem1.Enabled"), Boolean)
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem10})
        Me.MenuItem1.Shortcut = CType(resources.GetObject("MenuItem1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem1.ShowShortcut = CType(resources.GetObject("MenuItem1.ShowShortcut"), Boolean)
        Me.MenuItem1.Text = resources.GetString("MenuItem1.Text")
        Me.MenuItem1.Visible = CType(resources.GetObject("MenuItem1.Visible"), Boolean)
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = CType(resources.GetObject("MenuItem2.Enabled"), Boolean)
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = CType(resources.GetObject("MenuItem2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem2.ShowShortcut = CType(resources.GetObject("MenuItem2.ShowShortcut"), Boolean)
        Me.MenuItem2.Text = resources.GetString("MenuItem2.Text")
        Me.MenuItem2.Visible = CType(resources.GetObject("MenuItem2.Visible"), Boolean)
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = CType(resources.GetObject("MenuItem3.Enabled"), Boolean)
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = CType(resources.GetObject("MenuItem3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem3.ShowShortcut = CType(resources.GetObject("MenuItem3.ShowShortcut"), Boolean)
        Me.MenuItem3.Text = resources.GetString("MenuItem3.Text")
        Me.MenuItem3.Visible = CType(resources.GetObject("MenuItem3.Visible"), Boolean)
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = CType(resources.GetObject("MenuItem4.Enabled"), Boolean)
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = CType(resources.GetObject("MenuItem4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem4.ShowShortcut = CType(resources.GetObject("MenuItem4.ShowShortcut"), Boolean)
        Me.MenuItem4.Text = resources.GetString("MenuItem4.Text")
        Me.MenuItem4.Visible = CType(resources.GetObject("MenuItem4.Visible"), Boolean)
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = CType(resources.GetObject("MenuItem5.Enabled"), Boolean)
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Shortcut = CType(resources.GetObject("MenuItem5.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem5.ShowShortcut = CType(resources.GetObject("MenuItem5.ShowShortcut"), Boolean)
        Me.MenuItem5.Text = resources.GetString("MenuItem5.Text")
        Me.MenuItem5.Visible = CType(resources.GetObject("MenuItem5.Visible"), Boolean)
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = CType(resources.GetObject("MenuItem6.Enabled"), Boolean)
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Shortcut = CType(resources.GetObject("MenuItem6.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem6.ShowShortcut = CType(resources.GetObject("MenuItem6.ShowShortcut"), Boolean)
        Me.MenuItem6.Text = resources.GetString("MenuItem6.Text")
        Me.MenuItem6.Visible = CType(resources.GetObject("MenuItem6.Visible"), Boolean)
        '
        'MenuItem7
        '
        Me.MenuItem7.Enabled = CType(resources.GetObject("MenuItem7.Enabled"), Boolean)
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Shortcut = CType(resources.GetObject("MenuItem7.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem7.ShowShortcut = CType(resources.GetObject("MenuItem7.ShowShortcut"), Boolean)
        Me.MenuItem7.Text = resources.GetString("MenuItem7.Text")
        Me.MenuItem7.Visible = CType(resources.GetObject("MenuItem7.Visible"), Boolean)
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = CType(resources.GetObject("MenuItem8.Enabled"), Boolean)
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Shortcut = CType(resources.GetObject("MenuItem8.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem8.ShowShortcut = CType(resources.GetObject("MenuItem8.ShowShortcut"), Boolean)
        Me.MenuItem8.Text = resources.GetString("MenuItem8.Text")
        Me.MenuItem8.Visible = CType(resources.GetObject("MenuItem8.Visible"), Boolean)
        '
        'MenuItem9
        '
        Me.MenuItem9.Enabled = CType(resources.GetObject("MenuItem9.Enabled"), Boolean)
        Me.MenuItem9.Index = 7
        Me.MenuItem9.Shortcut = CType(resources.GetObject("MenuItem9.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem9.ShowShortcut = CType(resources.GetObject("MenuItem9.ShowShortcut"), Boolean)
        Me.MenuItem9.Text = resources.GetString("MenuItem9.Text")
        Me.MenuItem9.Visible = CType(resources.GetObject("MenuItem9.Visible"), Boolean)
        '
        'MenuItem10
        '
        Me.MenuItem10.Enabled = CType(resources.GetObject("MenuItem10.Enabled"), Boolean)
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Shortcut = CType(resources.GetObject("MenuItem10.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem10.ShowShortcut = CType(resources.GetObject("MenuItem10.ShowShortcut"), Boolean)
        Me.MenuItem10.Text = resources.GetString("MenuItem10.Text")
        Me.MenuItem10.Visible = CType(resources.GetObject("MenuItem10.Visible"), Boolean)
        '
        'MenuItem11
        '
        Me.MenuItem11.Enabled = CType(resources.GetObject("MenuItem11.Enabled"), Boolean)
        Me.MenuItem11.Index = 1
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18})
        Me.MenuItem11.Shortcut = CType(resources.GetObject("MenuItem11.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem11.ShowShortcut = CType(resources.GetObject("MenuItem11.ShowShortcut"), Boolean)
        Me.MenuItem11.Text = resources.GetString("MenuItem11.Text")
        Me.MenuItem11.Visible = CType(resources.GetObject("MenuItem11.Visible"), Boolean)
        '
        'MenuItem13
        '
        Me.MenuItem13.Enabled = CType(resources.GetObject("MenuItem13.Enabled"), Boolean)
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = CType(resources.GetObject("MenuItem13.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem13.ShowShortcut = CType(resources.GetObject("MenuItem13.ShowShortcut"), Boolean)
        Me.MenuItem13.Text = resources.GetString("MenuItem13.Text")
        Me.MenuItem13.Visible = CType(resources.GetObject("MenuItem13.Visible"), Boolean)
        '
        'MenuItem14
        '
        Me.MenuItem14.Enabled = CType(resources.GetObject("MenuItem14.Enabled"), Boolean)
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = CType(resources.GetObject("MenuItem14.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem14.ShowShortcut = CType(resources.GetObject("MenuItem14.ShowShortcut"), Boolean)
        Me.MenuItem14.Text = resources.GetString("MenuItem14.Text")
        Me.MenuItem14.Visible = CType(resources.GetObject("MenuItem14.Visible"), Boolean)
        '
        'MenuItem15
        '
        Me.MenuItem15.Enabled = CType(resources.GetObject("MenuItem15.Enabled"), Boolean)
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Shortcut = CType(resources.GetObject("MenuItem15.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem15.ShowShortcut = CType(resources.GetObject("MenuItem15.ShowShortcut"), Boolean)
        Me.MenuItem15.Text = resources.GetString("MenuItem15.Text")
        Me.MenuItem15.Visible = CType(resources.GetObject("MenuItem15.Visible"), Boolean)
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = CType(resources.GetObject("MenuItem16.Enabled"), Boolean)
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = CType(resources.GetObject("MenuItem16.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem16.ShowShortcut = CType(resources.GetObject("MenuItem16.ShowShortcut"), Boolean)
        Me.MenuItem16.Text = resources.GetString("MenuItem16.Text")
        Me.MenuItem16.Visible = CType(resources.GetObject("MenuItem16.Visible"), Boolean)
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = CType(resources.GetObject("MenuItem17.Enabled"), Boolean)
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = CType(resources.GetObject("MenuItem17.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem17.ShowShortcut = CType(resources.GetObject("MenuItem17.ShowShortcut"), Boolean)
        Me.MenuItem17.Text = resources.GetString("MenuItem17.Text")
        Me.MenuItem17.Visible = CType(resources.GetObject("MenuItem17.Visible"), Boolean)
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = CType(resources.GetObject("MenuItem18.Enabled"), Boolean)
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = CType(resources.GetObject("MenuItem18.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem18.ShowShortcut = CType(resources.GetObject("MenuItem18.ShowShortcut"), Boolean)
        Me.MenuItem18.Text = resources.GetString("MenuItem18.Text")
        Me.MenuItem18.Visible = CType(resources.GetObject("MenuItem18.Visible"), Boolean)
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = CType(resources.GetObject("MenuItem12.Enabled"), Boolean)
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Shortcut = CType(resources.GetObject("MenuItem12.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem12.ShowShortcut = CType(resources.GetObject("MenuItem12.ShowShortcut"), Boolean)
        Me.MenuItem12.Text = resources.GetString("MenuItem12.Text")
        Me.MenuItem12.Visible = CType(resources.GetObject("MenuItem12.Visible"), Boolean)
        '
        'MDIMain
        '
        Me.AccessibleDescription = CType(resources.GetObject("$this.AccessibleDescription"), String)
        Me.AccessibleName = CType(resources.GetObject("$this.AccessibleName"), String)
        Me.Anchor = CType(resources.GetObject("$this.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Dock = CType(resources.GetObject("$this.Dock"), System.Windows.Forms.DockStyle)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.IsMdiContainer = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "MDIMain"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.Visible = CType(resources.GetObject("$this.Visible"), Boolean)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

#End Region

    Dim ttm As New F1___TTM()
    Dim tm As New F2___TM()
    Dim tmd As New F3___TMD()
    Dim pmd As New F4___PMD()
    Dim cmd As New F5___CMD()
    Dim rmd As New F6__RMD()
    Dim sm As New F7___SM()
    Dim cm As New F8___CM()
    Dim stm As New F9___STM()
    Dim r11 As New R1()
    Dim r22 As New R2()
    Dim r33 As New R3()
    Dim r44 As New R4()
    Dim r55 As New R5()
    Dim r66 As New R6()

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        End
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        ttm.MdiParent = Me
        ttm.Show()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        sm.MdiParent = Me
        sm.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        cm.MdiParent = Me
        cm.Show()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        stm.MdiParent = Me
        stm.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        tm.MdiParent = Me
        tm.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        tmd.MdiParent = Me
        tmd.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        pmd.MdiParent = Me
        pmd.Show()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        cmd.MdiParent = Me
        cmd.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        rmd.MdiParent = Me
        rmd.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        r11.MdiParent = Me
        r11.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        r22.MdiParent = Me
        r22.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Me.r33.MdiParent = Me
        Me.r33.Show()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Me.r44.MdiParent = Me
        Me.r44.Show()
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Me.r55.MdiParent = Me
        Me.r55.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Me.r66.MdiParent = Me
        Me.r66.Show()
    End Sub

End Class
