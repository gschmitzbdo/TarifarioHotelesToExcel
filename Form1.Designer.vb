<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TbRutaPDF = New System.Windows.Forms.TextBox()
        Me.LbRutaPDF = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExaminarArchivos = New System.Windows.Forms.Button()
        Me.BuscadorDeArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbSeleccionarHotel = New System.Windows.Forms.ComboBox()
        Me.BtnGenerarExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbRutaPDF
        '
        Me.TbRutaPDF.Location = New System.Drawing.Point(125, 149)
        Me.TbRutaPDF.Name = "TbRutaPDF"
        Me.TbRutaPDF.Size = New System.Drawing.Size(178, 20)
        Me.TbRutaPDF.TabIndex = 0
        '
        'LbRutaPDF
        '
        Me.LbRutaPDF.AutoSize = True
        Me.LbRutaPDF.Location = New System.Drawing.Point(65, 152)
        Me.LbRutaPDF.Name = "LbRutaPDF"
        Me.LbRutaPDF.Size = New System.Drawing.Size(54, 13)
        Me.LbRutaPDF.TabIndex = 1
        Me.LbRutaPDF.Text = "Ruta PDF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(109, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Conversor Tarifario a Excel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnExaminarArchivos
        '
        Me.BtnExaminarArchivos.Location = New System.Drawing.Point(309, 147)
        Me.BtnExaminarArchivos.Name = "BtnExaminarArchivos"
        Me.BtnExaminarArchivos.Size = New System.Drawing.Size(75, 23)
        Me.BtnExaminarArchivos.TabIndex = 3
        Me.BtnExaminarArchivos.Text = "Examinar"
        Me.BtnExaminarArchivos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hotel"
        '
        'CbSeleccionarHotel
        '
        Me.CbSeleccionarHotel.FormattingEnabled = True
        Me.CbSeleccionarHotel.Location = New System.Drawing.Point(125, 122)
        Me.CbSeleccionarHotel.Name = "CbSeleccionarHotel"
        Me.CbSeleccionarHotel.Size = New System.Drawing.Size(98, 21)
        Me.CbSeleccionarHotel.TabIndex = 5
        '
        'BtnGenerarExcel
        '
        Me.BtnGenerarExcel.Location = New System.Drawing.Point(125, 175)
        Me.BtnGenerarExcel.Name = "BtnGenerarExcel"
        Me.BtnGenerarExcel.Size = New System.Drawing.Size(178, 23)
        Me.BtnGenerarExcel.TabIndex = 6
        Me.BtnGenerarExcel.Text = "Generar Excel"
        Me.BtnGenerarExcel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 450)
        Me.Controls.Add(Me.BtnGenerarExcel)
        Me.Controls.Add(Me.CbSeleccionarHotel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnExaminarArchivos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbRutaPDF)
        Me.Controls.Add(Me.TbRutaPDF)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbRutaPDF As TextBox
    Friend WithEvents LbRutaPDF As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExaminarArchivos As Button
    Friend WithEvents BuscadorDeArchivos As OpenFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents CbSeleccionarHotel As ComboBox
    Friend WithEvents BtnGenerarExcel As Button
End Class
