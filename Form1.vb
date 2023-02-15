Imports org.pdfbox.pdmodel
Imports org.pdfbox.util

Public Class Form1

    Private Const TREMUN As String = "Tremun"

    Private Const COL_VIGENCIA_DESDE As Integer = 0
    Private Const COL_VIGENCIA_HASTA As Integer = 1
    Private Const COL_TIPO_HABITACION As Integer = 2
    Private Const COL_TARIFA_HABITACION_SINGLE As Integer = 3
    Private Const COL_TARIFA_HABITACION_DOBLE As Integer = 4
    Private Const COL_TARIFA_HABITACION_TRIPLE As Integer = 5
    Private Const COL_TARIFA_HABITACION_FAMILY As Integer = 6

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CbSeleccionarHotel.Items.Add(TREMUN)

    End Sub
    Private Sub BtnExaminarArchivos_Click(sender As Object, e As EventArgs) Handles BtnExaminarArchivos.Click
        If BuscadorDeArchivos.ShowDialog = DialogResult.OK Then
            TbRutaPDF.Text = BuscadorDeArchivos.FileName
        End If
    End Sub

    Private Sub BtnGenerarExcel_Click(sender As Object, e As EventArgs) Handles BtnGenerarExcel.Click
        Dim DatosPDF As List(Of ItemExcel)
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        Select Case CbSeleccionarHotel.Text.Length > 0
            Case CbSeleccionarHotel.Text = TREMUN
                DatosPDF = ExtraerDatosTremun()
        End Select


        Try
            'MsgBox(DatosPDF(0, 0))
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add()
            oSheet = oBook.Worksheets(1)
            oSheet.Name = "Tarifario " + CbSeleccionarHotel.Text

            oSheet.Range("A1:C1").Font.Bold = True
            oSheet.Range("A1:C1").HorizontalAlignment = 3
            oSheet.Columns.Autofit()
            'TODO: Verificar como nombrar las columnas.
            oSheet.Cells(1, 1).value = "Descripcion Item"
            oSheet.Cells(1, 2).value = "Cantidad"
            oSheet.Cells(1, 3).value = "Valor Unitario"
            'MsgBox()
            For Fila As Integer = 0 To 19
                For Col As Integer = 0 To 2
                    oSheet.Cells(Fila + 2, Col + 1) = DatosPDF(Fila, Col)
                Next
            Next
            oExcel.DisplayAlerts = False
            oBook.Saveas(TbRutaPDF.Text.Substring(0, InStrRev(TbRutaPDF.Text, "\")) & "Tarifario" + CbSeleccionarHotel.Text + ".xlsx")
            oExcel.Quit()
            'Timer1.Enabled = False
            'Label2.Visible = False
            MsgBox("Excel generado correctamente.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function ExtraerDatosTremun() As List(Of ItemExcel)
        Dim Documento As New PDDocument
        Dim Stripper As New PDFTextStripper
        Dim Texto As String = ""
        Dim RutaArchivoPDF As String = TbRutaPDF.Text
        Documento = PDDocument.load(RutaArchivoPDF)

        Dim ListaDatosPDF As List(Of ItemExcel) = New List(Of ItemExcel)
        Dim Idx As Integer = 0

        For page As Integer = 1 To Documento.getNumberOfPages
            Stripper.setStartPage(page)
            Stripper.setEndPage(page)
            Stripper.setSortByPosition(True)
            Texto = Stripper.getText(Documento)

            Dim Lineas As Object
            Lineas = Split(Texto, vbCrLf)
            MsgBox(Texto)

            For x = LBound(Lineas) To UBound(Lineas)
                Dim LineaActual = Lineas(x).ToString

                If LineaActual.Contains("USD") Then
                    'MsgBox("Hay Tarifa")
                    Dim TipoHabitacion As String = Trim(LineaActual.Substring(0, InStr(LineaActual, "USD")))

                    Dim Item As ItemExcel = New ItemExcel()
                    ListaDatosPDF.Add(Item)
                    Idx += 1
                    'ElseIf (LineaActual.Contains("DEPARTAMENTO DE RESERVAS")) Then

                End If
            Next
        Next
        Return ListaDatosPDF
    End Function

    'Private Function GetCantidadItems(LineaTxt As String, CantidadVeces As Integer) As String
    'Dim CantidadItems As String = ""
    'Dim CadenaAux As String = LineaTxt
    'For i As Integer = 1 To CantidadVeces
    '       CadenaAux = CadenaAux.Substring(0, InStrRev(CadenaAux, " "))
    '      CadenaAux = Trim(CadenaAux)
    'Next
    '   CantidadItems = CadenaAux.Substring(InStrRev(CadenaAux, " "))
    'Return CantidadItems
    'End Function

    Private Function VigenciaPosible(CadenaDeTexto As String) As Boolean
        Dim MesesPosibles() As String =
        {
            "ENERO", "FEBRERO", "MARZO", "ABRIL",
            "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE",
            "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"
        }
        Dim MesEncontrado As Boolean = False
        Dim i As Integer = 0
        While MesEncontrado = False
            MesEncontrado = CadenaDeTexto.Contains(MesesPosibles(i))
        End While
        Return MesEncontrado
    End Function

End Class
