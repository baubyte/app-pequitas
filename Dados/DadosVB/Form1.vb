﻿Public Class Form1
    'Variable para Generar Numeros al Azar Predecibles o no
    Dim Azar As Boolean = True
    Dim ContadorTurnos As Integer = 0
    'Valores para los Dados
    Dim vDado1 As Integer = 0, vDado2 As Integer = 0, vDado3 As Integer = 0, vDado4 As Integer = 0, vDado5 As Integer = 0
    'Funcion para Generar Numeros al Azar
    Function NumDado(Random As Boolean) As Integer
        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)
    End Function

    'Verificar Turnos
    Public Sub Play1orPlay2()
        If (ContadorTurnos = 3 And lNombreJugador.Text = UCase(nombreJugadores.Jugador1Nombre)) Then
            lNombreJugador.Text = UCase(nombreJugadores.Jugador2Nombre)
            ContadorTurnos = 0
        ElseIf (ContadorTurnos = 3 And lNombreJugador.Text = UCase(nombreJugadores.Jugador2Nombre)) Then
            lNombreJugador.Text = UCase(nombreJugadores.Jugador1Nombre)
            ContadorTurnos = 0
        ElseIf (lNombreJugador.Text = "") Then
            lNombreJugador.Text = UCase(nombreJugadores.Jugador1Nombre)
        End If
        'Aumentamos la Cantidad de Turnos
        ContadorTurnos += 1
    End Sub
    'Generamos los Datos
    Private Sub Cubilete_Click(sender As Object, e As EventArgs) Handles Cubilete.Click
        Dim valorDado As Integer = 0
        CambiaDado(Dado1, valorDado) : vDado1 = valorDado
        CambiaDado(Dado2, valorDado) : vDado2 = valorDado
        CambiaDado(Dado3, valorDado) : vDado3 = valorDado
        CambiaDado(Dado4, valorDado) : vDado4 = valorDado
        CambiaDado(Dado5, valorDado) : vDado5 = valorDado
        Play1orPlay2()
        If (vDado1 = vDado2 And vDado1 = vDado3 And vDado1 = vDado4 And vDado1 = vDado5) Then
            MsgBox("Generala", MsgBoxStyle.Information, lNombreJugador.Text)
        End If
    End Sub
    Sub CambiaDado(ByRef DadoX As PictureBox, ByRef valorDado As Integer)
        'Generamos un Dado al Azar
        Dim Num As Integer = NumDado(Azar) : valorDado = Num
        'Buscamos la Imagen de Acuerdo al Numero Generado
        Select Case Num
            Case 1 : DadoX.Image = My.Resources.dado1
            Case 2 : DadoX.Image = My.Resources.dado2
            Case 3 : DadoX.Image = My.Resources.dado3
            Case 4 : DadoX.Image = My.Resources.dado4
            Case 5 : DadoX.Image = My.Resources.dado5
            Case 6 : DadoX.Image = My.Resources.dado6
        End Select
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro que Quieres Salir?", "Salir del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Play1orPlay2()
    End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim monto As Decimal = 1000
    '    Dim IVA As Decimal = 0, IIBB As Decimal = 0, Interes1 As Decimal = 0
    '    CalculaValores(monto, IVA, IIBB, Interes1)
    '    MessageBox.Show("Monto: " & monto & ",IVA: " & IVA & ", IIBB: " & IIBB & ", Interes1: " & Interes1)
    'End Sub
    'Sub CalculaValores(ByVal MontoX As Decimal, ByRef IVA As Decimal, ByRef IB As Decimal, ByRef Interes1 As Decimal)
    '    'IVA Es una Variable Local, que Hace Rferencia a IVA del Buttom2
    '    IVA = MontoX * 21 / 100
    '    IB = MontoX * 3 / 100
    '    Interes1 = MontoX * 9 / 100
    'End Sub
End Class
