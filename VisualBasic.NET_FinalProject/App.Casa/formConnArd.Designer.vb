<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formConnArd
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
        Me.cbPorts = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnShowPorts = New System.Windows.Forms.Button()
        Me.lbInfoPort = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.btnDataSend = New System.Windows.Forms.Button()
        Me.tbDataSend = New System.Windows.Forms.TextBox()
        Me.tbDataReceive = New System.Windows.Forms.TextBox()
        Me.TimerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAccao = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxPlanta = New System.Windows.Forms.PictureBox()
        Me.PanelLigacao = New System.Windows.Forms.Panel()
        Me.PanelPlanta = New System.Windows.Forms.Panel()
        Me.pbQuarto1Off = New System.Windows.Forms.PictureBox()
        Me.pbQuarto3Off = New System.Windows.Forms.PictureBox()
        Me.pbQuarto1On = New System.Windows.Forms.PictureBox()
        Me.pbCasaDeBanho2On = New System.Windows.Forms.PictureBox()
        Me.pbCorredorOff = New System.Windows.Forms.PictureBox()
        Me.pbQuarto3On = New System.Windows.Forms.PictureBox()
        Me.pbSalaOff = New System.Windows.Forms.PictureBox()
        Me.pbCorredorOn = New System.Windows.Forms.PictureBox()
        Me.pbCasaDeBanho1Off = New System.Windows.Forms.PictureBox()
        Me.pbSalaOn = New System.Windows.Forms.PictureBox()
        Me.pbCasaDeBanho2Off = New System.Windows.Forms.PictureBox()
        Me.pbQuarto2On = New System.Windows.Forms.PictureBox()
        Me.pbCozinhaOff = New System.Windows.Forms.PictureBox()
        Me.pbCasaDeBanho1On = New System.Windows.Forms.PictureBox()
        Me.pbQuarto2Off = New System.Windows.Forms.PictureBox()
        Me.pbCozinhaOn = New System.Windows.Forms.PictureBox()
        Me.TimerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerEnviarPedidos = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAgendamentoInfo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxPlanta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLigacao.SuspendLayout()
        Me.PanelPlanta.SuspendLayout()
        CType(Me.pbQuarto1Off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuarto3Off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuarto1On, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCasaDeBanho2On, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCorredorOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuarto3On, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalaOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCorredorOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCasaDeBanho1Off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalaOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCasaDeBanho2Off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuarto2On, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCozinhaOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCasaDeBanho1On, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbQuarto2Off, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCozinhaOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPorts
        '
        Me.cbPorts.FormattingEnabled = True
        Me.cbPorts.Location = New System.Drawing.Point(26, 129)
        Me.cbPorts.Name = "cbPorts"
        Me.cbPorts.Size = New System.Drawing.Size(198, 24)
        Me.cbPorts.TabIndex = 5
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(88, 36)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 46)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'btnShowPorts
        '
        Me.btnShowPorts.ForeColor = System.Drawing.Color.Red
        Me.btnShowPorts.Location = New System.Drawing.Point(88, 36)
        Me.btnShowPorts.Name = "btnShowPorts"
        Me.btnShowPorts.Size = New System.Drawing.Size(75, 46)
        Me.btnShowPorts.TabIndex = 3
        Me.btnShowPorts.Text = "Show Ports"
        Me.btnShowPorts.UseVisualStyleBackColor = True
        '
        'lbInfoPort
        '
        Me.lbInfoPort.AutoSize = True
        Me.lbInfoPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfoPort.Location = New System.Drawing.Point(21, 188)
        Me.lbInfoPort.Name = "lbInfoPort"
        Me.lbInfoPort.Size = New System.Drawing.Size(203, 29)
        Me.lbInfoPort.TabIndex = 6
        Me.lbInfoPort.Text = "Escolher COM 3"
        Me.lbInfoPort.Visible = False
        '
        'btnDataSend
        '
        Me.btnDataSend.Location = New System.Drawing.Point(427, 7)
        Me.btnDataSend.Name = "btnDataSend"
        Me.btnDataSend.Size = New System.Drawing.Size(75, 23)
        Me.btnDataSend.TabIndex = 97
        Me.btnDataSend.Text = "Send"
        Me.btnDataSend.UseVisualStyleBackColor = True
        Me.btnDataSend.Visible = False
        '
        'tbDataSend
        '
        Me.tbDataSend.Location = New System.Drawing.Point(60, 7)
        Me.tbDataSend.Name = "tbDataSend"
        Me.tbDataSend.ReadOnly = True
        Me.tbDataSend.Size = New System.Drawing.Size(200, 22)
        Me.tbDataSend.TabIndex = 94
        '
        'tbDataReceive
        '
        Me.tbDataReceive.Location = New System.Drawing.Point(686, 7)
        Me.tbDataReceive.Name = "tbDataReceive"
        Me.tbDataReceive.ReadOnly = True
        Me.tbDataReceive.Size = New System.Drawing.Size(200, 22)
        Me.tbDataReceive.TabIndex = 93
        '
        'TimerUpdate
        '
        '
        'TimerAccao
        '
        '
        'PictureBoxPlanta
        '
        Me.PictureBoxPlanta.Image = Global.App.Casa.My.Resources.Resources.planta_de_casa_com_3_quartos_5
        Me.PictureBoxPlanta.Location = New System.Drawing.Point(0, 39)
        Me.PictureBoxPlanta.Name = "PictureBoxPlanta"
        Me.PictureBoxPlanta.Size = New System.Drawing.Size(949, 361)
        Me.PictureBoxPlanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPlanta.TabIndex = 98
        Me.PictureBoxPlanta.TabStop = False
        '
        'PanelLigacao
        '
        Me.PanelLigacao.Controls.Add(Me.lbInfoPort)
        Me.PanelLigacao.Controls.Add(Me.cbPorts)
        Me.PanelLigacao.Controls.Add(Me.btnStart)
        Me.PanelLigacao.Controls.Add(Me.btnShowPorts)
        Me.PanelLigacao.Location = New System.Drawing.Point(0, 2)
        Me.PanelLigacao.Name = "PanelLigacao"
        Me.PanelLigacao.Size = New System.Drawing.Size(250, 250)
        Me.PanelLigacao.TabIndex = 115
        '
        'PanelPlanta
        '
        Me.PanelPlanta.Controls.Add(Me.pbQuarto1Off)
        Me.PanelPlanta.Controls.Add(Me.pbQuarto3Off)
        Me.PanelPlanta.Controls.Add(Me.pbQuarto1On)
        Me.PanelPlanta.Controls.Add(Me.pbCasaDeBanho2On)
        Me.PanelPlanta.Controls.Add(Me.pbCorredorOff)
        Me.PanelPlanta.Controls.Add(Me.pbQuarto3On)
        Me.PanelPlanta.Controls.Add(Me.pbSalaOff)
        Me.PanelPlanta.Controls.Add(Me.pbCorredorOn)
        Me.PanelPlanta.Controls.Add(Me.pbCasaDeBanho1Off)
        Me.PanelPlanta.Controls.Add(Me.pbSalaOn)
        Me.PanelPlanta.Controls.Add(Me.pbCasaDeBanho2Off)
        Me.PanelPlanta.Controls.Add(Me.pbQuarto2On)
        Me.PanelPlanta.Controls.Add(Me.pbCozinhaOff)
        Me.PanelPlanta.Controls.Add(Me.pbCasaDeBanho1On)
        Me.PanelPlanta.Controls.Add(Me.pbQuarto2Off)
        Me.PanelPlanta.Controls.Add(Me.pbCozinhaOn)
        Me.PanelPlanta.Controls.Add(Me.btnDataSend)
        Me.PanelPlanta.Controls.Add(Me.PictureBoxPlanta)
        Me.PanelPlanta.Controls.Add(Me.tbDataReceive)
        Me.PanelPlanta.Controls.Add(Me.tbDataSend)
        Me.PanelPlanta.Location = New System.Drawing.Point(256, 2)
        Me.PanelPlanta.Name = "PanelPlanta"
        Me.PanelPlanta.Size = New System.Drawing.Size(949, 400)
        Me.PanelPlanta.TabIndex = 116
        '
        'pbQuarto1Off
        '
        Me.pbQuarto1Off.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbQuarto1Off.Location = New System.Drawing.Point(178, 98)
        Me.pbQuarto1Off.Name = "pbQuarto1Off"
        Me.pbQuarto1Off.Size = New System.Drawing.Size(50, 50)
        Me.pbQuarto1Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuarto1Off.TabIndex = 115
        Me.pbQuarto1Off.TabStop = False
        '
        'pbQuarto3Off
        '
        Me.pbQuarto3Off.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbQuarto3Off.Location = New System.Drawing.Point(198, 292)
        Me.pbQuarto3Off.Name = "pbQuarto3Off"
        Me.pbQuarto3Off.Size = New System.Drawing.Size(50, 50)
        Me.pbQuarto3Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuarto3Off.TabIndex = 117
        Me.pbQuarto3Off.TabStop = False
        '
        'pbQuarto1On
        '
        Me.pbQuarto1On.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbQuarto1On.Location = New System.Drawing.Point(113, 98)
        Me.pbQuarto1On.Name = "pbQuarto1On"
        Me.pbQuarto1On.Size = New System.Drawing.Size(50, 50)
        Me.pbQuarto1On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuarto1On.TabIndex = 116
        Me.pbQuarto1On.TabStop = False
        Me.pbQuarto1On.Visible = False
        '
        'pbCasaDeBanho2On
        '
        Me.pbCasaDeBanho2On.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbCasaDeBanho2On.Location = New System.Drawing.Point(345, 317)
        Me.pbCasaDeBanho2On.Name = "pbCasaDeBanho2On"
        Me.pbCasaDeBanho2On.Size = New System.Drawing.Size(50, 50)
        Me.pbCasaDeBanho2On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCasaDeBanho2On.TabIndex = 127
        Me.pbCasaDeBanho2On.TabStop = False
        Me.pbCasaDeBanho2On.Visible = False
        '
        'pbCorredorOff
        '
        Me.pbCorredorOff.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbCorredorOff.Location = New System.Drawing.Point(441, 225)
        Me.pbCorredorOff.Name = "pbCorredorOff"
        Me.pbCorredorOff.Size = New System.Drawing.Size(50, 50)
        Me.pbCorredorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCorredorOff.TabIndex = 122
        Me.pbCorredorOff.TabStop = False
        '
        'pbQuarto3On
        '
        Me.pbQuarto3On.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbQuarto3On.Location = New System.Drawing.Point(125, 292)
        Me.pbQuarto3On.Name = "pbQuarto3On"
        Me.pbQuarto3On.Size = New System.Drawing.Size(50, 50)
        Me.pbQuarto3On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuarto3On.TabIndex = 124
        Me.pbQuarto3On.TabStop = False
        Me.pbQuarto3On.Visible = False
        '
        'pbSalaOff
        '
        Me.pbSalaOff.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbSalaOff.Location = New System.Drawing.Point(739, 274)
        Me.pbSalaOff.Name = "pbSalaOff"
        Me.pbSalaOff.Size = New System.Drawing.Size(50, 50)
        Me.pbSalaOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSalaOff.TabIndex = 121
        Me.pbSalaOff.TabStop = False
        '
        'pbCorredorOn
        '
        Me.pbCorredorOn.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbCorredorOn.Location = New System.Drawing.Point(369, 225)
        Me.pbCorredorOn.Name = "pbCorredorOn"
        Me.pbCorredorOn.Size = New System.Drawing.Size(50, 50)
        Me.pbCorredorOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCorredorOn.TabIndex = 126
        Me.pbCorredorOn.TabStop = False
        Me.pbCorredorOn.Visible = False
        '
        'pbCasaDeBanho1Off
        '
        Me.pbCasaDeBanho1Off.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbCasaDeBanho1Off.Location = New System.Drawing.Point(369, 75)
        Me.pbCasaDeBanho1Off.Name = "pbCasaDeBanho1Off"
        Me.pbCasaDeBanho1Off.Size = New System.Drawing.Size(50, 50)
        Me.pbCasaDeBanho1Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCasaDeBanho1Off.TabIndex = 118
        Me.pbCasaDeBanho1Off.TabStop = False
        '
        'pbSalaOn
        '
        Me.pbSalaOn.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbSalaOn.Location = New System.Drawing.Point(662, 274)
        Me.pbSalaOn.Name = "pbSalaOn"
        Me.pbSalaOn.Size = New System.Drawing.Size(50, 50)
        Me.pbSalaOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSalaOn.TabIndex = 128
        Me.pbSalaOn.TabStop = False
        Me.pbSalaOn.Visible = False
        '
        'pbCasaDeBanho2Off
        '
        Me.pbCasaDeBanho2Off.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbCasaDeBanho2Off.Location = New System.Drawing.Point(401, 317)
        Me.pbCasaDeBanho2Off.Name = "pbCasaDeBanho2Off"
        Me.pbCasaDeBanho2Off.Size = New System.Drawing.Size(50, 50)
        Me.pbCasaDeBanho2Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCasaDeBanho2Off.TabIndex = 123
        Me.pbCasaDeBanho2Off.TabStop = False
        '
        'pbQuarto2On
        '
        Me.pbQuarto2On.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbQuarto2On.Location = New System.Drawing.Point(508, 98)
        Me.pbQuarto2On.Name = "pbQuarto2On"
        Me.pbQuarto2On.Size = New System.Drawing.Size(50, 50)
        Me.pbQuarto2On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuarto2On.TabIndex = 130
        Me.pbQuarto2On.TabStop = False
        Me.pbQuarto2On.Visible = False
        '
        'pbCozinhaOff
        '
        Me.pbCozinhaOff.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbCozinhaOff.Location = New System.Drawing.Point(808, 98)
        Me.pbCozinhaOff.Name = "pbCozinhaOff"
        Me.pbCozinhaOff.Size = New System.Drawing.Size(50, 50)
        Me.pbCozinhaOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCozinhaOff.TabIndex = 120
        Me.pbCozinhaOff.TabStop = False
        '
        'pbCasaDeBanho1On
        '
        Me.pbCasaDeBanho1On.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbCasaDeBanho1On.Location = New System.Drawing.Point(313, 75)
        Me.pbCasaDeBanho1On.Name = "pbCasaDeBanho1On"
        Me.pbCasaDeBanho1On.Size = New System.Drawing.Size(50, 50)
        Me.pbCasaDeBanho1On.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCasaDeBanho1On.TabIndex = 125
        Me.pbCasaDeBanho1On.TabStop = False
        Me.pbCasaDeBanho1On.Visible = False
        '
        'pbQuarto2Off
        '
        Me.pbQuarto2Off.Image = Global.App.Casa.My.Resources.Resources.lampada_off
        Me.pbQuarto2Off.Location = New System.Drawing.Point(588, 98)
        Me.pbQuarto2Off.Name = "pbQuarto2Off"
        Me.pbQuarto2Off.Size = New System.Drawing.Size(50, 50)
        Me.pbQuarto2Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbQuarto2Off.TabIndex = 119
        Me.pbQuarto2Off.TabStop = False
        '
        'pbCozinhaOn
        '
        Me.pbCozinhaOn.Image = Global.App.Casa.My.Resources.Resources.lampada_on
        Me.pbCozinhaOn.Location = New System.Drawing.Point(739, 98)
        Me.pbCozinhaOn.Name = "pbCozinhaOn"
        Me.pbCozinhaOn.Size = New System.Drawing.Size(50, 50)
        Me.pbCozinhaOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCozinhaOn.TabIndex = 129
        Me.pbCozinhaOn.TabStop = False
        Me.pbCozinhaOn.Visible = False
        '
        'TimerDateTime
        '
        Me.TimerDateTime.Interval = 15000
        '
        'TimerEnviarPedidos
        '
        '
        'TimerAgendamentoInfo
        '
        Me.TimerAgendamentoInfo.Interval = 240000
        '
        'formConnArd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 420)
        Me.Controls.Add(Me.PanelPlanta)
        Me.Controls.Add(Me.PanelLigacao)
        Me.Name = "formConnArd"
        Me.Text = "formConnArd"
        CType(Me.PictureBoxPlanta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLigacao.ResumeLayout(False)
        Me.PanelLigacao.PerformLayout()
        Me.PanelPlanta.ResumeLayout(False)
        Me.PanelPlanta.PerformLayout()
        CType(Me.pbQuarto1Off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuarto3Off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuarto1On, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCasaDeBanho2On, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCorredorOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuarto3On, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSalaOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCorredorOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCasaDeBanho1Off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSalaOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCasaDeBanho2Off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuarto2On, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCozinhaOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCasaDeBanho1On, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbQuarto2Off, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCozinhaOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbPorts As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnShowPorts As Button
    Friend WithEvents lbInfoPort As Label
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents btnDataSend As Button
    Friend WithEvents tbDataSend As TextBox
    Friend WithEvents tbDataReceive As TextBox
    Friend WithEvents TimerUpdate As Timer
    Friend WithEvents TimerAccao As Timer
    Friend WithEvents PictureBoxPlanta As PictureBox
    Friend WithEvents PanelLigacao As Panel
    Friend WithEvents PanelPlanta As Panel
    Friend WithEvents pbQuarto1Off As PictureBox
    Friend WithEvents pbQuarto3Off As PictureBox
    Friend WithEvents pbQuarto1On As PictureBox
    Friend WithEvents pbCasaDeBanho2On As PictureBox
    Friend WithEvents pbCorredorOff As PictureBox
    Friend WithEvents pbQuarto3On As PictureBox
    Friend WithEvents pbSalaOff As PictureBox
    Friend WithEvents pbCorredorOn As PictureBox
    Friend WithEvents pbCasaDeBanho1Off As PictureBox
    Friend WithEvents pbSalaOn As PictureBox
    Friend WithEvents pbCasaDeBanho2Off As PictureBox
    Friend WithEvents pbQuarto2On As PictureBox
    Friend WithEvents pbCozinhaOff As PictureBox
    Friend WithEvents pbCasaDeBanho1On As PictureBox
    Friend WithEvents pbQuarto2Off As PictureBox
    Friend WithEvents pbCozinhaOn As PictureBox
    Friend WithEvents TimerDateTime As Timer
    Friend WithEvents TimerEnviarPedidos As Timer
    Friend WithEvents TimerAgendamentoInfo As Timer
End Class
