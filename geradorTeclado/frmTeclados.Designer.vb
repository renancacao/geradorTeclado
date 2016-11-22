<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeclados
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
        Me.nLetras = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRespostas = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtExclusivas = New System.Windows.Forms.TextBox
        Me.txtNecessarias = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAleatorias = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFinal = New System.Windows.Forms.TextBox
        Me.btGerar = New System.Windows.Forms.Button
        Me.lblExclusivas = New System.Windows.Forms.Label
        Me.lblNecessarias = New System.Windows.Forms.Label
        Me.lblAleatorias = New System.Windows.Forms.Label
        CType(Me.nLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nLetras
        '
        Me.nLetras.Location = New System.Drawing.Point(130, 19)
        Me.nLetras.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        Me.nLetras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nLetras.Name = "nLetras"
        Me.nLetras.Size = New System.Drawing.Size(42, 20)
        Me.nLetras.TabIndex = 0
        Me.nLetras.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantidade de Letras:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Respostas:"
        '
        'txtRespostas
        '
        Me.txtRespostas.Location = New System.Drawing.Point(130, 45)
        Me.txtRespostas.Multiline = True
        Me.txtRespostas.Name = "txtRespostas"
        Me.txtRespostas.Size = New System.Drawing.Size(269, 63)
        Me.txtRespostas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Letras Exclusivas:"
        '
        'txtExclusivas
        '
        Me.txtExclusivas.Location = New System.Drawing.Point(130, 114)
        Me.txtExclusivas.Name = "txtExclusivas"
        Me.txtExclusivas.ReadOnly = True
        Me.txtExclusivas.Size = New System.Drawing.Size(195, 20)
        Me.txtExclusivas.TabIndex = 5
        '
        'txtNecessarias
        '
        Me.txtNecessarias.Location = New System.Drawing.Point(130, 140)
        Me.txtNecessarias.Name = "txtNecessarias"
        Me.txtNecessarias.ReadOnly = True
        Me.txtNecessarias.Size = New System.Drawing.Size(195, 20)
        Me.txtNecessarias.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Letras Necessárias:"
        '
        'txtAleatorias
        '
        Me.txtAleatorias.Location = New System.Drawing.Point(130, 166)
        Me.txtAleatorias.Name = "txtAleatorias"
        Me.txtAleatorias.ReadOnly = True
        Me.txtAleatorias.Size = New System.Drawing.Size(195, 20)
        Me.txtAleatorias.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Letras Aleatórias:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Teclado Final:"
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(130, 215)
        Me.txtFinal.Multiline = True
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.ReadOnly = True
        Me.txtFinal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFinal.Size = New System.Drawing.Size(269, 44)
        Me.txtFinal.TabIndex = 11
        '
        'btGerar
        '
        Me.btGerar.Location = New System.Drawing.Point(249, 274)
        Me.btGerar.Name = "btGerar"
        Me.btGerar.Size = New System.Drawing.Size(150, 35)
        Me.btGerar.TabIndex = 12
        Me.btGerar.Text = "Gerar"
        Me.btGerar.UseVisualStyleBackColor = True
        '
        'lblExclusivas
        '
        Me.lblExclusivas.Location = New System.Drawing.Point(331, 114)
        Me.lblExclusivas.Name = "lblExclusivas"
        Me.lblExclusivas.Size = New System.Drawing.Size(68, 17)
        Me.lblExclusivas.TabIndex = 13
        Me.lblExclusivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNecessarias
        '
        Me.lblNecessarias.Location = New System.Drawing.Point(331, 143)
        Me.lblNecessarias.Name = "lblNecessarias"
        Me.lblNecessarias.Size = New System.Drawing.Size(68, 17)
        Me.lblNecessarias.TabIndex = 14
        Me.lblNecessarias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAleatorias
        '
        Me.lblAleatorias.Location = New System.Drawing.Point(331, 169)
        Me.lblAleatorias.Name = "lblAleatorias"
        Me.lblAleatorias.Size = New System.Drawing.Size(68, 17)
        Me.lblAleatorias.TabIndex = 15
        Me.lblAleatorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTeclados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 321)
        Me.Controls.Add(Me.lblAleatorias)
        Me.Controls.Add(Me.lblNecessarias)
        Me.Controls.Add(Me.lblExclusivas)
        Me.Controls.Add(Me.btGerar)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAleatorias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNecessarias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtExclusivas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRespostas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nLetras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTeclados"
        Me.Text = "Gerador Teclados"
        CType(Me.nLetras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nLetras As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRespostas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExclusivas As System.Windows.Forms.TextBox
    Friend WithEvents txtNecessarias As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAleatorias As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents btGerar As System.Windows.Forms.Button
    Friend WithEvents lblExclusivas As System.Windows.Forms.Label
    Friend WithEvents lblNecessarias As System.Windows.Forms.Label
    Friend WithEvents lblAleatorias As System.Windows.Forms.Label

End Class
