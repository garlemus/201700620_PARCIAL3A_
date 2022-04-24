Public Class Form1

    Public reservas(0 To 7) As Array
    Public totales(7) As Integer
    Public index As Integer
    Public id_busqueda As String

    Private Sub Financiera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        index = 0
        reservas(0) = {"", "", "", ""}
        reservas(1) = {"", "", "", ""}
        reservas(2) = {"", "", "", ""}
        reservas(3) = {"", "", "", ""}
        reservas(4) = {"", "", "", ""}
        reservas(5) = {"", "", "", ""}
        reservas(6) = {"", "", "", ""}
        totales(0) = 0
        totales(1) = 0
        totales(2) = 0
        totales(3) = 0
        totales(4) = 0
        totales(5) = 0
        totales(6) = 0

    End Sub

    Private Sub AceptarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem1.Click

        Dim id_cliente As String = TextBox_id.Text
        Dim dias As String = TextBox_dias.Text
        Dim viajeros As String = TextBox_viajeros.Text
        Dim tipo As String = ""

        If id_cliente = "" Or dias = "" Or viajeros = "" Then
            MsgBox("¡Error! Alguno de los campos está vacío.")
            Return
        End If

        Dim total As Integer = Integer.Parse(dias) * Integer.Parse(viajeros)
        If RadioButton_laguna.Checked Then
            total = total * 440
            tipo = "Laguna Brava (Huehuetenango)"
        ElseIf RadioButton_mirador.Checked Then
            total = total * 1190
            tipo = "Mirador (Petén)"
        ElseIf RadioButton_biotopo.Checked Then
            total = total * 255
            tipo = "Biotopo del Quetzal (Baja Verapaz)"
        Else
            MsgBox("¡Error! No se ha seleccionado el tipo de viaje.")
            Return
        End If

        If index = 7 Then
            MsgBox("¡Error! Las reservas están completas, elimina una reserva o limpia los vectores para poder guardar.")
            Return
        End If

        Dim reserva = {id_cliente, dias, viajeros, tipo, total}
        reservas(index)(0) = reserva(0)
        reservas(index)(1) = reserva(1)
        reservas(index)(2) = reserva(2)
        reservas(index)(3) = reserva(3)
        totales(index) = total
        index = index + 1

        TextBox_dias.Text = ""
        TextBox_id.Text = ""
        TextBox_viajeros.Text = ""

        MsgBox("¡Éxito! Reserva guardada exitosamente.")

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        DataGridView1.Rows.Clear()
        For i As Integer = 0 To index - 1
            Dim reserva = {reservas(i)(0), reservas(i)(1), reservas(i)(2), reservas(i)(3), totales(i)}
            DataGridView1.Rows.Add(reserva)
        Next

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        id_busqueda = TextBox_buscar.Text

        If id_busqueda = "" Then
            MsgBox("¡Error! El cuadro de búsqueda está vacío.")
            Return
        End If

        DataGridView1.Rows.Clear()
        For i As Integer = 0 To index - 1
            If reservas(i)(0) = id_busqueda Then
                Dim reserva = {reservas(i)(0), reservas(i)(1), reservas(i)(2), reservas(i)(3), totales(i)}
                DataGridView1.Rows.Add(reserva)
            End If
        Next

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No se ha encontrado ninguna reserva con el id del cliente indicado.")
        End If

        TextBox_buscar.Text = ""

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click

        DataGridView1.Rows.Clear()
        For i As Integer = 0 To index - 1
            If reservas(i)(0) = id_busqueda Then
                reservas(i) = {"", "", "", ""}
                totales(i) = 0
            End If
        Next
        MsgBox("¡Éxito! Reserva(s) eliminada(s) con éxito.")

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        index = 0
        reservas(0) = {"", "", "", ""}
        reservas(1) = {"", "", "", ""}
        reservas(2) = {"", "", "", ""}
        reservas(3) = {"", "", "", ""}
        reservas(4) = {"", "", "", ""}
        reservas(5) = {"", "", "", ""}
        reservas(6) = {"", "", "", ""}
        totales(0) = 0
        totales(1) = 0
        totales(2) = 0
        totales(3) = 0
        totales(4) = 0
        totales(5) = 0
        totales(6) = 0
        DataGridView1.Rows.Clear()

    End Sub
End Class
