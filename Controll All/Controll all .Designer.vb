<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Serial_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Serial_Data))
        Me.Errors = New System.Windows.Forms.Label()
        Me.AA = New System.Windows.Forms.Label()
        Me.RichTextBoxInput = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxOutput = New System.Windows.Forms.RichTextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ComboBoxUSB = New System.Windows.Forms.ComboBox()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.ButtonConnectDisconnect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.AutoScroll = New System.Windows.Forms.CheckBox()
        Me.Errors2 = New System.Windows.Forms.Label()
        Me.RichTextBoxOutputb = New System.Windows.Forms.RichTextBox()
        Me.StartChar = New System.Windows.Forms.TextBox()
        Me.StopChar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.HScrollBar20 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar19 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar18 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar17 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar16 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar15 = New System.Windows.Forms.HScrollBar()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.HScrollBar14 = New System.Windows.Forms.HScrollBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.HScrollBar13 = New System.Windows.Forms.HScrollBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HScrollBar12 = New System.Windows.Forms.HScrollBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.HScrollBar11 = New System.Windows.Forms.HScrollBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HScrollBar10 = New System.Windows.Forms.HScrollBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HScrollBar9 = New System.Windows.Forms.HScrollBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HScrollBar8 = New System.Windows.Forms.HScrollBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HScrollBar7 = New System.Windows.Forms.HScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HScrollBar6 = New System.Windows.Forms.HScrollBar()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.HScrollBar5 = New System.Windows.Forms.HScrollBar()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.HScrollBar4 = New System.Windows.Forms.HScrollBar()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.AutoReload = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Errors
        '
        resources.ApplyResources(Me.Errors, "Errors")
        Me.Errors.Cursor = System.Windows.Forms.Cursors.Default
        Me.Errors.ForeColor = System.Drawing.Color.Red
        Me.Errors.Name = "Errors"
        '
        'AA
        '
        resources.ApplyResources(Me.AA, "AA")
        Me.AA.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.AA.Name = "AA"
        Me.AA.UseWaitCursor = True
        '
        'RichTextBoxInput
        '
        resources.ApplyResources(Me.RichTextBoxInput, "RichTextBoxInput")
        Me.RichTextBoxInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBoxInput.Name = "RichTextBoxInput"
        Me.RichTextBoxInput.ReadOnly = True
        Me.RichTextBoxInput.TabStop = False
        '
        'RichTextBoxOutput
        '
        resources.ApplyResources(Me.RichTextBoxOutput, "RichTextBoxOutput")
        Me.RichTextBoxOutput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBoxOutput.Name = "RichTextBoxOutput"
        Me.RichTextBoxOutput.ReadOnly = True
        Me.RichTextBoxOutput.TabStop = False
        '
        'ButtonSend
        '
        Me.ButtonSend.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ButtonSend, "ButtonSend")
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ComboBoxUSB
        '
        Me.ComboBoxUSB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxUSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBoxUSB, "ComboBoxUSB")
        Me.ComboBoxUSB.FormattingEnabled = True
        Me.ComboBoxUSB.Name = "ComboBoxUSB"
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.TextBoxInput, "TextBoxInput")
        Me.TextBoxInput.Name = "TextBoxInput"
        '
        'ButtonConnectDisconnect
        '
        Me.ButtonConnectDisconnect.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ButtonConnectDisconnect, "ButtonConnectDisconnect")
        Me.ButtonConnectDisconnect.ForeColor = System.Drawing.Color.Green
        Me.ButtonConnectDisconnect.Name = "ButtonConnectDisconnect"
        Me.ButtonConnectDisconnect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'AutoScroll
        '
        resources.ApplyResources(Me.AutoScroll, "AutoScroll")
        Me.AutoScroll.Checked = True
        Me.AutoScroll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoScroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AutoScroll.Name = "AutoScroll"
        Me.AutoScroll.UseMnemonic = False
        Me.AutoScroll.UseVisualStyleBackColor = True
        '
        'Errors2
        '
        resources.ApplyResources(Me.Errors2, "Errors2")
        Me.Errors2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Errors2.ForeColor = System.Drawing.Color.Red
        Me.Errors2.Name = "Errors2"
        '
        'RichTextBoxOutputb
        '
        resources.ApplyResources(Me.RichTextBoxOutputb, "RichTextBoxOutputb")
        Me.RichTextBoxOutputb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBoxOutputb.Name = "RichTextBoxOutputb"
        Me.RichTextBoxOutputb.ReadOnly = True
        Me.RichTextBoxOutputb.TabStop = False
        '
        'StartChar
        '
        Me.StartChar.AcceptsReturn = True
        Me.StartChar.AcceptsTab = True
        Me.StartChar.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.StartChar, "StartChar")
        Me.StartChar.Name = "StartChar"
        '
        'StopChar
        '
        Me.StopChar.Cursor = System.Windows.Forms.Cursors.IBeam
        resources.ApplyResources(Me.StopChar, "StopChar")
        Me.StopChar.Name = "StopChar"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'SerialPort2
        '
        Me.SerialPort2.PortName = "COM6"
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.Name = "Label35"
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.Name = "Label36"
        '
        'Label37
        '
        resources.ApplyResources(Me.Label37, "Label37")
        Me.Label37.Name = "Label37"
        '
        'Label38
        '
        resources.ApplyResources(Me.Label38, "Label38")
        Me.Label38.Name = "Label38"
        '
        'Label39
        '
        resources.ApplyResources(Me.Label39, "Label39")
        Me.Label39.Name = "Label39"
        '
        'Label40
        '
        resources.ApplyResources(Me.Label40, "Label40")
        Me.Label40.Name = "Label40"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'HScrollBar20
        '
        resources.ApplyResources(Me.HScrollBar20, "HScrollBar20")
        Me.HScrollBar20.LargeChange = 32
        Me.HScrollBar20.Maximum = 1054
        Me.HScrollBar20.Name = "HScrollBar20"
        '
        'HScrollBar19
        '
        resources.ApplyResources(Me.HScrollBar19, "HScrollBar19")
        Me.HScrollBar19.LargeChange = 32
        Me.HScrollBar19.Maximum = 1054
        Me.HScrollBar19.Name = "HScrollBar19"
        '
        'HScrollBar18
        '
        resources.ApplyResources(Me.HScrollBar18, "HScrollBar18")
        Me.HScrollBar18.LargeChange = 32
        Me.HScrollBar18.Maximum = 1054
        Me.HScrollBar18.Name = "HScrollBar18"
        '
        'HScrollBar17
        '
        resources.ApplyResources(Me.HScrollBar17, "HScrollBar17")
        Me.HScrollBar17.LargeChange = 32
        Me.HScrollBar17.Maximum = 1054
        Me.HScrollBar17.Name = "HScrollBar17"
        '
        'HScrollBar16
        '
        resources.ApplyResources(Me.HScrollBar16, "HScrollBar16")
        Me.HScrollBar16.LargeChange = 32
        Me.HScrollBar16.Maximum = 1054
        Me.HScrollBar16.Name = "HScrollBar16"
        '
        'HScrollBar15
        '
        resources.ApplyResources(Me.HScrollBar15, "HScrollBar15")
        Me.HScrollBar15.LargeChange = 32
        Me.HScrollBar15.Maximum = 1054
        Me.HScrollBar15.Name = "HScrollBar15"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'HScrollBar14
        '
        resources.ApplyResources(Me.HScrollBar14, "HScrollBar14")
        Me.HScrollBar14.LargeChange = 1
        Me.HScrollBar14.Maximum = 1
        Me.HScrollBar14.Name = "HScrollBar14"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'HScrollBar13
        '
        resources.ApplyResources(Me.HScrollBar13, "HScrollBar13")
        Me.HScrollBar13.LargeChange = 1
        Me.HScrollBar13.Maximum = 1
        Me.HScrollBar13.Name = "HScrollBar13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'HScrollBar12
        '
        resources.ApplyResources(Me.HScrollBar12, "HScrollBar12")
        Me.HScrollBar12.LargeChange = 64
        Me.HScrollBar12.Maximum = 286
        Me.HScrollBar12.Name = "HScrollBar12"
        Me.HScrollBar12.SmallChange = 16
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'HScrollBar11
        '
        resources.ApplyResources(Me.HScrollBar11, "HScrollBar11")
        Me.HScrollBar11.LargeChange = 64
        Me.HScrollBar11.Maximum = 286
        Me.HScrollBar11.Name = "HScrollBar11"
        Me.HScrollBar11.SmallChange = 16
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'HScrollBar10
        '
        resources.ApplyResources(Me.HScrollBar10, "HScrollBar10")
        Me.HScrollBar10.LargeChange = 64
        Me.HScrollBar10.Maximum = 286
        Me.HScrollBar10.Name = "HScrollBar10"
        Me.HScrollBar10.SmallChange = 16
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'HScrollBar9
        '
        resources.ApplyResources(Me.HScrollBar9, "HScrollBar9")
        Me.HScrollBar9.LargeChange = 1
        Me.HScrollBar9.Maximum = 1
        Me.HScrollBar9.Name = "HScrollBar9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'HScrollBar8
        '
        resources.ApplyResources(Me.HScrollBar8, "HScrollBar8")
        Me.HScrollBar8.LargeChange = 1
        Me.HScrollBar8.Maximum = 1
        Me.HScrollBar8.Name = "HScrollBar8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'HScrollBar7
        '
        resources.ApplyResources(Me.HScrollBar7, "HScrollBar7")
        Me.HScrollBar7.LargeChange = 64
        Me.HScrollBar7.Maximum = 286
        Me.HScrollBar7.Name = "HScrollBar7"
        Me.HScrollBar7.SmallChange = 16
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'HScrollBar6
        '
        resources.ApplyResources(Me.HScrollBar6, "HScrollBar6")
        Me.HScrollBar6.LargeChange = 64
        Me.HScrollBar6.Maximum = 286
        Me.HScrollBar6.Name = "HScrollBar6"
        Me.HScrollBar6.SmallChange = 16
        '
        'Label41
        '
        resources.ApplyResources(Me.Label41, "Label41")
        Me.Label41.Name = "Label41"
        '
        'HScrollBar5
        '
        resources.ApplyResources(Me.HScrollBar5, "HScrollBar5")
        Me.HScrollBar5.LargeChange = 1
        Me.HScrollBar5.Maximum = 1
        Me.HScrollBar5.Name = "HScrollBar5"
        '
        'Label42
        '
        resources.ApplyResources(Me.Label42, "Label42")
        Me.Label42.Name = "Label42"
        '
        'HScrollBar4
        '
        resources.ApplyResources(Me.HScrollBar4, "HScrollBar4")
        Me.HScrollBar4.LargeChange = 64
        Me.HScrollBar4.Maximum = 286
        Me.HScrollBar4.Name = "HScrollBar4"
        Me.HScrollBar4.SmallChange = 16
        '
        'Label43
        '
        resources.ApplyResources(Me.Label43, "Label43")
        Me.Label43.Name = "Label43"
        '
        'HScrollBar3
        '
        resources.ApplyResources(Me.HScrollBar3, "HScrollBar3")
        Me.HScrollBar3.LargeChange = 1
        Me.HScrollBar3.Maximum = 1
        Me.HScrollBar3.Name = "HScrollBar3"
        '
        'Label44
        '
        resources.ApplyResources(Me.Label44, "Label44")
        Me.Label44.Name = "Label44"
        '
        'HScrollBar2
        '
        resources.ApplyResources(Me.HScrollBar2, "HScrollBar2")
        Me.HScrollBar2.LargeChange = 1
        Me.HScrollBar2.Maximum = 1
        Me.HScrollBar2.Name = "HScrollBar2"
        '
        'Label45
        '
        resources.ApplyResources(Me.Label45, "Label45")
        Me.Label45.Name = "Label45"
        '
        'HScrollBar1
        '
        resources.ApplyResources(Me.HScrollBar1, "HScrollBar1")
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Maximum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        '
        'AutoReload
        '
        resources.ApplyResources(Me.AutoReload, "AutoReload")
        Me.AutoReload.Name = "AutoReload"
        Me.AutoReload.UseMnemonic = False
        Me.AutoReload.UseVisualStyleBackColor = True
        '
        'Serial_Data
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AutoReload)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.HScrollBar20)
        Me.Controls.Add(Me.HScrollBar19)
        Me.Controls.Add(Me.HScrollBar18)
        Me.Controls.Add(Me.HScrollBar17)
        Me.Controls.Add(Me.HScrollBar16)
        Me.Controls.Add(Me.HScrollBar15)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.HScrollBar14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.HScrollBar13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.HScrollBar12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.HScrollBar11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.HScrollBar10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.HScrollBar9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.HScrollBar8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.HScrollBar7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HScrollBar6)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.HScrollBar5)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.HScrollBar4)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StopChar)
        Me.Controls.Add(Me.StartChar)
        Me.Controls.Add(Me.RichTextBoxOutputb)
        Me.Controls.Add(Me.Errors2)
        Me.Controls.Add(Me.Errors)
        Me.Controls.Add(Me.AA)
        Me.Controls.Add(Me.RichTextBoxInput)
        Me.Controls.Add(Me.RichTextBoxOutput)
        Me.Controls.Add(Me.ButtonSend)
        Me.Controls.Add(Me.ComboBoxUSB)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Controls.Add(Me.ButtonConnectDisconnect)
        Me.Controls.Add(Me.AutoScroll)
        Me.Name = "Serial_Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Errors As Label
    Friend WithEvents AA As Label
    Public WithEvents RichTextBoxInput As RichTextBox
    Public WithEvents RichTextBoxOutput As RichTextBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents ComboBoxUSB As ComboBox
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents ButtonConnectDisconnect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents AutoScroll As CheckBox
    Friend WithEvents Errors2 As Label
    Public WithEvents RichTextBoxOutputb As RichTextBox
    Friend WithEvents StartChar As TextBox
    Friend WithEvents StopChar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents HScrollBar20 As HScrollBar
    Friend WithEvents HScrollBar19 As HScrollBar
    Friend WithEvents HScrollBar18 As HScrollBar
    Friend WithEvents HScrollBar17 As HScrollBar
    Friend WithEvents HScrollBar16 As HScrollBar
    Friend WithEvents HScrollBar15 As HScrollBar
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents HScrollBar14 As HScrollBar
    Friend WithEvents Label13 As Label
    Friend WithEvents HScrollBar13 As HScrollBar
    Friend WithEvents Label12 As Label
    Friend WithEvents HScrollBar12 As HScrollBar
    Friend WithEvents Label11 As Label
    Friend WithEvents HScrollBar11 As HScrollBar
    Friend WithEvents Label10 As Label
    Friend WithEvents HScrollBar10 As HScrollBar
    Friend WithEvents Label9 As Label
    Friend WithEvents HScrollBar9 As HScrollBar
    Friend WithEvents Label8 As Label
    Friend WithEvents HScrollBar8 As HScrollBar
    Friend WithEvents Label7 As Label
    Friend WithEvents HScrollBar7 As HScrollBar
    Friend WithEvents Label6 As Label
    Friend WithEvents HScrollBar6 As HScrollBar
    Friend WithEvents Label41 As Label
    Friend WithEvents HScrollBar5 As HScrollBar
    Friend WithEvents Label42 As Label
    Friend WithEvents HScrollBar4 As HScrollBar
    Friend WithEvents Label43 As Label
    Friend WithEvents HScrollBar3 As HScrollBar
    Friend WithEvents Label44 As Label
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents Label45 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents AutoReload As CheckBox
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
End Class
