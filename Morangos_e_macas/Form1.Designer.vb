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
        Me.Lblmaca = New System.Windows.Forms.Label()
        Me.TxtqntdMaca = New System.Windows.Forms.TextBox()
        Me.TxtqntdMorango = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.LblTotalMorango = New System.Windows.Forms.Label()
        Me.LblTotalmaca = New System.Windows.Forms.Label()
        Me.LblValorMaca = New System.Windows.Forms.Label()
        Me.LblValorMorango = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTotalCompra = New System.Windows.Forms.Label()
        Me.PctMorango = New System.Windows.Forms.PictureBox()
        Me.PctMaca = New System.Windows.Forms.PictureBox()
        CType(Me.PctMorango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctMaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblmaca
        '
        Me.Lblmaca.AutoSize = True
        Me.Lblmaca.Location = New System.Drawing.Point(12, 22)
        Me.Lblmaca.Name = "Lblmaca"
        Me.Lblmaca.Size = New System.Drawing.Size(81, 13)
        Me.Lblmaca.TabIndex = 0
        Me.Lblmaca.Text = "Maçãs (por kg):"
        '
        'TxtqntdMaca
        '
        Me.TxtqntdMaca.Location = New System.Drawing.Point(15, 38)
        Me.TxtqntdMaca.Name = "TxtqntdMaca"
        Me.TxtqntdMaca.Size = New System.Drawing.Size(74, 20)
        Me.TxtqntdMaca.TabIndex = 1
        '
        'TxtqntdMorango
        '
        Me.TxtqntdMorango.Location = New System.Drawing.Point(148, 38)
        Me.TxtqntdMorango.Name = "TxtqntdMorango"
        Me.TxtqntdMorango.Size = New System.Drawing.Size(74, 20)
        Me.TxtqntdMorango.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Morangos (por kg):"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Location = New System.Drawing.Point(15, 76)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(124, 32)
        Me.BtnCalcular.TabIndex = 4
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(148, 76)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(123, 32)
        Me.BtnSair.TabIndex = 5
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'LblTotalMorango
        '
        Me.LblTotalMorango.AutoSize = True
        Me.LblTotalMorango.Location = New System.Drawing.Point(143, 167)
        Me.LblTotalMorango.Name = "LblTotalMorango"
        Me.LblTotalMorango.Size = New System.Drawing.Size(126, 13)
        Me.LblTotalMorango.TabIndex = 6
        Me.LblTotalMorango.Text = "Valor total dos morangos:"
        '
        'LblTotalmaca
        '
        Me.LblTotalmaca.AutoSize = True
        Me.LblTotalmaca.Location = New System.Drawing.Point(12, 167)
        Me.LblTotalmaca.Name = "LblTotalmaca"
        Me.LblTotalmaca.Size = New System.Drawing.Size(111, 13)
        Me.LblTotalmaca.TabIndex = 7
        Me.LblTotalmaca.Text = "Valor total das maçãs:"
        '
        'LblValorMaca
        '
        Me.LblValorMaca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblValorMaca.Location = New System.Drawing.Point(15, 191)
        Me.LblValorMaca.Name = "LblValorMaca"
        Me.LblValorMaca.Size = New System.Drawing.Size(125, 20)
        Me.LblValorMaca.TabIndex = 8
        '
        'LblValorMorango
        '
        Me.LblValorMorango.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblValorMorango.Location = New System.Drawing.Point(146, 191)
        Me.LblValorMorango.Name = "LblValorMorango"
        Me.LblValorMorango.Size = New System.Drawing.Size(125, 20)
        Me.LblValorMorango.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Valor total das compras:"
        '
        'LblTotalCompra
        '
        Me.LblTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalCompra.Location = New System.Drawing.Point(136, 130)
        Me.LblTotalCompra.Name = "LblTotalCompra"
        Me.LblTotalCompra.Size = New System.Drawing.Size(135, 20)
        Me.LblTotalCompra.TabIndex = 13
        '
        'PctMorango
        '
        Me.PctMorango.ErrorImage = Nothing
        Me.PctMorango.InitialImage = Nothing
        Me.PctMorango.Location = New System.Drawing.Point(148, 220)
        Me.PctMorango.Name = "PctMorango"
        Me.PctMorango.Size = New System.Drawing.Size(122, 95)
        Me.PctMorango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctMorango.TabIndex = 14
        Me.PctMorango.TabStop = False
        '
        'PctMaca
        '
        Me.PctMaca.Location = New System.Drawing.Point(16, 220)
        Me.PctMaca.Name = "PctMaca"
        Me.PctMaca.Size = New System.Drawing.Size(123, 95)
        Me.PctMaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctMaca.TabIndex = 10
        Me.PctMaca.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 327)
        Me.Controls.Add(Me.PctMorango)
        Me.Controls.Add(Me.LblTotalCompra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PctMaca)
        Me.Controls.Add(Me.LblValorMorango)
        Me.Controls.Add(Me.LblValorMaca)
        Me.Controls.Add(Me.LblTotalmaca)
        Me.Controls.Add(Me.LblTotalMorango)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtqntdMorango)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtqntdMaca)
        Me.Controls.Add(Me.Lblmaca)
        Me.Name = "Form1"
        Me.Text = "Maçãs"
        CType(Me.PctMorango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctMaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblmaca As System.Windows.Forms.Label
    Friend WithEvents TxtqntdMaca As System.Windows.Forms.TextBox
    Friend WithEvents TxtqntdMorango As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents LblTotalMorango As System.Windows.Forms.Label
    Friend WithEvents LblTotalmaca As System.Windows.Forms.Label
    Friend WithEvents LblValorMaca As System.Windows.Forms.Label
    Friend WithEvents LblValorMorango As System.Windows.Forms.Label
    Friend WithEvents PctMaca As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotalCompra As System.Windows.Forms.Label
    Friend WithEvents PctMorango As System.Windows.Forms.PictureBox

End Class
