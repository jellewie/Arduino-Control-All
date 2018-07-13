' This code is written by JelleWho
' Pc -> Arduino
' "+000"   = Enable auto send analog data
' "-000"   = Disable auto send analog data
' ",000"   = Send analog data once
' "&$$$" &= Set amount of min difference between Analog to resync them with the PC
'      $$$ = Amount of min difference, between 000 And 999 (Default 10)
' "#$$$" # = Pin number, A=pin0 B=pin1 see https://www.arduino.cc/en/Reference/ASCIIchart (numer-64=pin)
'      $$$ = Value to write to pin, between 000 And 255
'
'  Arduino -> PC
'  "EE"     = Error, please resend last data
'  "#$$$" # = Analog Pin number who has changed, A=pin0 B=pin1 see https://www.arduino.cc/en/Reference/ASCIIchart (numer-64=pin)
'       $$$ = Value

Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Public Class Serial_Data

    Dim PrefPoort As String
    Dim Poort As String
    Dim Value As String
    Dim Potmeter As String


    'Put above this line your own strings

    '==================================================
    '==================================================
    '==========          Core V8             ==========
    '==================================================
    '==================================================
    Dim RecievedText As String
    Dim StartBit As String = "["
    Dim StopBit As String = "]"
    Dim MSGBoxName As String
    Dim MSG As String
    Dim myPort As Array
    Dim ArduinoAnswer As String
    Dim ButtonSelected As String
    Dim PrefUSB As String

    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
    'Action - when closing application
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ButtonConnectDisconnect.Text = "Disconnect" Then
            Threading.Thread.Sleep(100) ' 1000 milliseconds = 1 second
            Disconnect()               ' disconnect arduino, Tried to fix the Frees here
            Threading.Thread.Sleep(100) ' 1000 milliseconds = 1 second
        End If
    End Sub
    'Action - (when) Starting up
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReloadUSB()
        MSGBoxName = "JelleWho"
        ButtonConnectDisconnect.Select()
        StartBit = StartChar.Text
        StopBit = StopChar.Text
        RunOnStartup()
    End Sub
    'Button - Reload USB
    Private Sub ComboBoxPoort_USBIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUSB.Click
        ReloadUSB()
    End Sub
    'Code   - Reload USB
    Sub ReloadUSB()
        PrefUSB = ComboBoxUSB.SelectedItem
        ComboBoxUSB.Items.Clear()
        On Error GoTo ErrHand
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxUSB.Items.AddRange(myPort)
        ComboBoxUSB.SelectionStart.ToString()
        ComboBoxUSB.SelectedItem = PrefUSB
        If ComboBoxUSB.SelectedItem = "" Then   'Try autoselect an port
            ComboBoxUSB.SelectedItem = "COM10"
            ComboBoxUSB.SelectedItem = "COM9"
            ComboBoxUSB.SelectedItem = "COM8"
            ComboBoxUSB.SelectedItem = "COM7"
            ComboBoxUSB.SelectedItem = "COM6"
            ComboBoxUSB.SelectedItem = "COM5"
            ComboBoxUSB.SelectedItem = "COM4"
            ComboBoxUSB.SelectedItem = "COM3"
            ComboBoxUSB.SelectedItem = "COM2"
            ComboBoxUSB.SelectedItem = "COM1"
            ComboBoxUSB.SelectedItem = "COM0"
        End If
ErrHand:
    End Sub
    'Button - Send
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        SerialSend(TextBoxInput.Text)
    End Sub
    'Button - Enter Pressed (Send)
    Private Sub TextBoxInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            SerialSend(TextBoxInput.Text)
        End If
    End Sub
    'Code   - Serial send
    Sub SerialSend(Text As String)
        TextBoxInput.Text = ""
        On Error GoTo ErrHand
        SerialPort1.Write(Text)
        RichTextBoxInput.Text &= Text + Chr(13)
        Exit Sub
ErrHand:
        MsgBox("You couldn't resist to remove the cable didn't you?", , MSGBoxName)
        Disconnect()
    End Sub
    'Button - Connect and Disconnect
    Private Sub ButtonButtonConnectDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConnectDisconnect.Click
        If ButtonConnectDisconnect.Text = "Connect" Then
            'Connect
            Connect()
        Else
            'Disconnect
            ButtonConnectDisconnect.Text = "Connect"
            ButtonConnectDisconnect.ForeColor = Color.Green
            Disconnect()
        End If
    End Sub
    'Code   - Connect
    Sub Connect()
        If ComboBoxUSB.Text <> "" Then
            On Error GoTo ErrHand
            ''SerialPort1.Close()
            SerialPort1.PortName = ComboBoxUSB.Text
            SerialPort1.BaudRate = 9600

            'Added the next lines
            SerialPort1.DataBits = 8
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Encoding = System.Text.Encoding.Default
            SerialPort1.ReadTimeout = 1

            SerialPort1.Open()
            ComboBoxUSB.Enabled = False
            ButtonSend.Enabled = True
            TextBoxInput.Enabled = True
            ButtonConnectDisconnect.Text = "Disconnect"
            ButtonConnectDisconnect.ForeColor = Color.Red
            TextBoxInput.Select()
            RunOnConnect()
        Else
            MsgBox("I can not connect to nothing! what where you thinking..." + Chr(13) + "Please give me a COM poort to connect to, before letting me try to connect to it", , MSGBoxName)
            ReloadUSB()
        End If
        Exit Sub
ErrHand:
        MsgBox("The COM Port your trying to use, does not seems to work anymore" + Chr(13) + "Did you remove the cable again?", , MSGBoxName)
        ReloadUSB()
        ButtonConnectDisconnect.Select()
    End Sub
    'Code   - Disconnect
    Sub Disconnect()
        RunOnDisconnect()
        ComboBoxUSB.Enabled = True
        ButtonSend.Enabled = False
        TextBoxInput.Enabled = False
        ButtonConnectDisconnect.Text = "Connect"
        ButtonConnectDisconnect.ForeColor = Color.Green
        ButtonConnectDisconnect.Select()
        On Error GoTo ErrHand
        SerialPort1.Close()
        Exit Sub
ErrHand:
        ReloadUSB()
    End Sub
    'Action - Recieved serial data
    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        System.Threading.Thread.Sleep(10)    'Minimal 4
        ReceivedText(SerialPort1.ReadExisting())
    End Sub
    'Code   - Recieved serial data
    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        If Me.RichTextBoxOutput.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            RecievedText = [text]
            Dim A = 10
            'Cut end send if we have a valid command "<StartBit> <some random data> <StopBit>"
            Do While InStr(1, RecievedText, StartBit) > 0 And InStr(2, RecievedText, StopBit) > 0 And A > 0
                A = A - 1
                Dim StartBitPos = InStr(1, RecievedText, StartBit)
                Dim StopBitPos = InStr(2, RecievedText, StopBit)
                If (StopBitPos > StartBitPos) Then
                    Dim TheText = Microsoft.VisualBasic.Left(RecievedText, StopBitPos - 1)
                    Dim TheText2 = Microsoft.VisualBasic.Right(TheText, StopBitPos - 1 - StartBitPos)
                    RecievedText = Microsoft.VisualBasic.Right(RecievedText, Microsoft.VisualBasic.Len(RecievedText) - StopBitPos)
                    RunOnDataRecieved(TheText2)
                    RichTextBoxOutputb.Text &= TheText2 + Chr(13)
                Else
                    RecievedText = Microsoft.VisualBasic.Right(RecievedText, Microsoft.VisualBasic.Len(RecievedText) - StopBitPos)
                End If
            Loop
            Me.RichTextBoxOutput.Text = [text] 'append text to all past command list
            If AutoScroll.Checked = True Then
                RichTextBoxOutput.SelectionStart = RichTextBoxOutput.TextLength
                RichTextBoxOutput.ScrollToCaret()
                RichTextBoxInput.SelectionStart = RichTextBoxInput.TextLength
                RichTextBoxInput.ScrollToCaret()
                RichTextBoxOutputb.SelectionStart = RichTextBoxOutputb.TextLength
                RichTextBoxOutputb.ScrollToCaret()
            End If
        End If
        Exit Sub
    End Sub
    'Button - Clear output
    Private Sub RichTextBoxOutput_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBoxOutput.DoubleClick
        RichTextBoxOutput.Text = ""
    End Sub
    'Button - Clear Outputb
    Private Sub RichTextBoxOutputb_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBoxOutputb.DoubleClick
        RichTextBoxOutputb.Text = ""
    End Sub
    'Button - Clear inputbox
    Private Sub RichTextBoxInput_DoubleClick(sender As Object, e As EventArgs) Handles RichTextBoxInput.DoubleClick
        RichTextBoxInput.Text = ""
    End Sub
    'Button - Update startbit
    Private Sub StartChar_TextChanged(sender As Object, e As EventArgs) Handles StartChar.TextChanged
        StartBit = StartChar.Text
    End Sub
    'Button - Update Stoptbit
    Private Sub StopChar_TextChanged(sender As Object, e As EventArgs) Handles StopChar.TextChanged
        StopBit = StopChar.Text
    End Sub
    '==================================================
    '==================================================
    '==========          Your Codes          ==========
    '==================================================
    '==================================================
    'Action - (when) starting up
    Sub RunOnStartup()
        'Connect()
        'if you enable the above line (by removing the ' char) it will try to auto connect on startup
    End Sub
    'Action - (when) Connect
    Sub RunOnConnect()
        HScrollBar1.Enabled = True
        HScrollBar2.Enabled = True
        HScrollBar3.Enabled = True
        HScrollBar4.Enabled = True
        HScrollBar5.Enabled = True
        HScrollBar6.Enabled = True
        HScrollBar7.Enabled = True
        HScrollBar8.Enabled = True
        HScrollBar9.Enabled = True
        HScrollBar10.Enabled = True
        HScrollBar11.Enabled = True
        HScrollBar12.Enabled = True
        HScrollBar13.Enabled = True
        HScrollBar14.Enabled = True
        AutoReload.Enabled = True
        SetmanualAnalog()
    End Sub
    'Action - (when) Disconnect
    Sub RunOnDisconnect()
        HScrollBar1.Enabled = False
        HScrollBar2.Enabled = False
        HScrollBar3.Enabled = False
        HScrollBar4.Enabled = False
        HScrollBar5.Enabled = False
        HScrollBar6.Enabled = False
        HScrollBar7.Enabled = False
        HScrollBar8.Enabled = False
        HScrollBar9.Enabled = False
        HScrollBar10.Enabled = False
        HScrollBar11.Enabled = False
        HScrollBar12.Enabled = False
        HScrollBar13.Enabled = False
        HScrollBar14.Enabled = False
        AutoReload.Enabled = False
    End Sub
    'Action - (when) Serial data recieved
    Sub RunOnDataRecieved(Text As String)
        Try
            Dim CMD1 As String = Microsoft.VisualBasic.Left(Text, 1)
            Dim CMD2 As Int16 = Microsoft.VisualBasic.Right(Text, Microsoft.VisualBasic.Len(Text) - 1)
            If CMD2 >= 0 And CMD2 < 1024 Then
                If CMD1 = "A" Then
                    Label29.Text = CMD2
                    HScrollBar15.Value = Label29.Text
                ElseIf CMD1 = "B" Then
                    Label30.Text = CMD2
                    HScrollBar16.Value = Label30.Text
                ElseIf CMD1 = "C" Then
                    Label31.Text = CMD2
                    HScrollBar17.Value = Label31.Text
                ElseIf CMD1 = "D" Then
                    Label32.Text = CMD2
                    HScrollBar18.Value = Label32.Text
                ElseIf CMD1 = "E" Then
                    Label33.Text = CMD2
                    HScrollBar19.Value = Label33.Text
                ElseIf CMD1 = "F" Then
                    Label34.Text = CMD2
                    HScrollBar20.Value = Label34.Text
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    '==================================================
    '==================================================
    '==========          More Codes          ==========
    '==================================================
    '==================================================
    'Code   - Decode
    Sub Decode()
        If Value = 0 Then
            Value = "000"
        ElseIf Value * 10 < 100 Then
            Value = "00" & Value
        ElseIf Value < 100 Then
            Value = "0" & Value
        Else
            Value = Value
        End If
        TextBoxInput.Text = Poort & Value
        SerialSend(TextBoxInput.Text)
    End Sub
    'Code   - Reload Analog pins
    Sub ReloadAnalogPins()
        If ButtonConnectDisconnect.Text = "Disconnect" Then
            SetmanualAnalog()
        End If
    End Sub
    '==================================================
    '==================================================
    '==========         Scroll Bars          ==========
    '==================================================
    '==================================================
    '0
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label1.Text = HScrollBar1.Value
    End Sub
    Private Sub HScrollBar1_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar1.MouseCaptureChanged
        Label1.Text = HScrollBar1.Value
        Poort = "A"
        Value = Label1.Text
        Value = Value * 255
        Decode()
    End Sub
    '1
    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label2.Text = HScrollBar2.Value
    End Sub
    Private Sub HScrollBar2_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar2.MouseCaptureChanged
        Label2.Text = HScrollBar2.Value
        Poort = "B"
        Value = Label2.Text
        Value = Value * 255
        Decode()
    End Sub
    '2
    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll
        Label3.Text = HScrollBar3.Value
    End Sub
    Private Sub HScrollBar3_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar3.MouseCaptureChanged
        Label3.Text = HScrollBar3.Value
        Poort = "C"
        Value = Label3.Text
        Value = Value * 255
        Decode()
    End Sub
    '3
    Private Sub HScrollBar4_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar4.Scroll
        Label4.Text = HScrollBar4.Value
    End Sub
    Private Sub HScrollBar4_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar4.MouseCaptureChanged
        Label4.Text = HScrollBar4.Value
        Poort = "D"
        Value = Label4.Text
        Decode()
    End Sub
    '4
    Private Sub HScrollBar5_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar5.Scroll
        Label5.Text = HScrollBar5.Value
    End Sub
    Private Sub HScrollBar5_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar5.MouseCaptureChanged
        Label5.Text = HScrollBar5.Value
        Poort = "E"
        Value = Label5.Text
        Value = Value * 255
        Decode()
    End Sub
    '5
    Private Sub HScrollBar6_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar6.Scroll
        Label6.Text = HScrollBar6.Value
    End Sub
    Private Sub HScrollBar6_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar6.MouseCaptureChanged
        Label6.Text = HScrollBar6.Value
        Poort = "F"
        Value = Label6.Text
        Decode()
    End Sub
    '6
    Private Sub HScrollBar7_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar7.Scroll
        Label7.Text = HScrollBar7.Value
    End Sub
    Private Sub HScrollBar7_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar7.MouseCaptureChanged
        Label7.Text = HScrollBar7.Value
        Poort = "G"
        Value = Label7.Text
        Decode()
    End Sub
    '7
    Private Sub HScrollBar8_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar8.Scroll
        Label8.Text = HScrollBar8.Value
    End Sub
    Private Sub HScrollBar8_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar8.MouseCaptureChanged
        Label8.Text = HScrollBar8.Value
        Poort = "H"
        Value = Label8.Text
        Value = Value * 255
        Decode()
    End Sub
    '8
    Private Sub HScrollBar9_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar9.Scroll
        Label9.Text = HScrollBar9.Value
    End Sub
    Private Sub HScrollBar9_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar9.MouseCaptureChanged
        Label9.Text = HScrollBar9.Value
        Poort = "I"
        Value = Label9.Text
        Value = Value * 255
        Decode()
    End Sub
    '9
    Private Sub HScrollBar10_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar10.Scroll
        Label10.Text = HScrollBar10.Value
    End Sub
    Private Sub HScrollBar10_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar10.MouseCaptureChanged
        Label10.Text = HScrollBar10.Value
        Poort = "J"
        Value = Label10.Text
        Decode()
    End Sub
    '10
    Private Sub HScrollBar11_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar11.Scroll
        Label11.Text = HScrollBar11.Value
    End Sub
    Private Sub HScrollBar11_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar11.MouseCaptureChanged
        Label11.Text = HScrollBar11.Value
        Poort = "K"
        Value = Label11.Text
        Decode()
    End Sub
    '11
    Private Sub HScrollBar12_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar12.Scroll
        Label12.Text = HScrollBar12.Value
    End Sub
    Private Sub HScrollBar12_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar12.MouseCaptureChanged
        Label12.Text = HScrollBar12.Value
        Poort = "L"
        Value = Label12.Text
        Decode()
    End Sub
    '12
    Private Sub HScrollBar13_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar13.Scroll
        Label13.Text = HScrollBar13.Value
    End Sub
    Private Sub HScrollBar13_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar13.MouseCaptureChanged
        Label13.Text = HScrollBar13.Value
        Poort = "M"
        Value = Label13.Text
        Value = Value * 255
        Decode()
    End Sub
    '13
    Private Sub HScrollBar14_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar14.Scroll
        Label14.Text = HScrollBar14.Value
    End Sub
    Private Sub HScrollBar14_MouseLeave(sender As Object, e As EventArgs) Handles HScrollBar14.MouseCaptureChanged
        Label14.Text = HScrollBar14.Value
        Poort = "N"
        Value = Label14.Text
        Value = Value * 255
        Decode()
    End Sub
    '==================================================
    '==================================================
    '==========          Analog Bars         ==========
    '==================================================
    '==================================================
    'Cancel change when clicking on A0
    Private Sub HScrollBar15_MouseCaptureChanged(sender As Object, e As EventArgs) Handles HScrollBar15.MouseCaptureChanged
        ReloadAnalogPins()
    End Sub
    'Cancel change when clicking on A1
    Private Sub HScrollBar16_MouseCaptureChanged(sender As Object, e As EventArgs) Handles HScrollBar16.MouseCaptureChanged
        ReloadAnalogPins()
    End Sub
    'Cancel change when clicking on A2
    Private Sub HScrollBar17_MouseCaptureChanged(sender As Object, e As EventArgs) Handles HScrollBar17.MouseCaptureChanged
        ReloadAnalogPins()
    End Sub
    'Cancel change when clicking on A3
    Private Sub HScrollBar18_MouseCaptureChanged(sender As Object, e As EventArgs) Handles HScrollBar18.MouseCaptureChanged
        ReloadAnalogPins()
    End Sub
    'Cancel change when clicking on A4
    Private Sub HScrollBar19_MouseCaptureChanged(sender As Object, e As EventArgs) Handles HScrollBar18.MouseCaptureChanged
        ReloadAnalogPins()
    End Sub
    'Cancel change when clicking on A5
    Private Sub HScrollBar20_MouseCaptureChanged(sender As Object, e As EventArgs) Handles HScrollBar20.MouseCaptureChanged
        ReloadAnalogPins()
    End Sub
    'Sync A0
    Private Sub HScrollBar15_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar15.ValueChanged
        HScrollBar15.Value = Label29.Text
    End Sub
    'Sync A1
    Private Sub HScrollBar16_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar16.ValueChanged
        HScrollBar16.Value = Label30.Text
    End Sub
    'Sync A2
    Private Sub HScrollBar17_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar17.ValueChanged
        HScrollBar17.Value = Label31.Text
    End Sub
    'Sync A3
    Private Sub HScrollBar18_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar18.ValueChanged
        HScrollBar18.Value = Label32.Text
    End Sub
    'Sync A4
    Private Sub HScrollBar19_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar19.ValueChanged
        HScrollBar19.Value = Label33.Text
    End Sub
    'Sync A5
    Private Sub HScrollBar20_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar20.ValueChanged
        HScrollBar20.Value = Label34.Text
    End Sub


    'button - Set Auto Analog
    Private Sub AutoReload_CheckedChanged(sender As Object, e As EventArgs) Handles AutoReload.CheckedChanged
        SetAutoAnalog()
    End Sub
    'Code   - Set Auto Analog
    Sub SetAutoAnalog()
        If AutoReload.Checked = False Then
            TextBoxInput.Text = "+   "
            SerialSend(TextBoxInput.Text)
        Else
            TextBoxInput.Text = "-   "
            SerialSend(TextBoxInput.Text)
        End If
    End Sub
    'Code   - Set manual Analog
    Sub SetmanualAnalog()
        TextBoxInput.Text = "+,  "
        If AutoReload.Checked = True Then
            TextBoxInput.Text = "--  "
        End If
        SerialSend(TextBoxInput.Text)
    End Sub
End Class
