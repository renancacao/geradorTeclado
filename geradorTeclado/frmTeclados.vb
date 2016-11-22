Imports System.Text.RegularExpressions

Public Class frmTeclados



    Private Sub frmTeclados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        nLetras.Value = My.Settings.totalLetras

    End Sub

    Private Sub btGerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGerar.Click

        'salva settings
        My.Settings.totalLetras = nLetras.Value
        My.Settings.Save()

        limpa()


        Dim letras(25) As Integer

        pegaLetras(txtRespostas.Text, letras)

        'percorro as letras

        For i As Integer = 0 To letras.Length - 1
            If letras(i) >= 1 Then
                txtNecessarias.Text &= Chr(i + 65)
                If letras(i) = 1 Then
                    txtExclusivas.Text &= Chr(i + 65)
                End If
            End If
        Next

        lblExclusivas.Text = txtExclusivas.Text.Length
        lblNecessarias.Text = txtNecessarias.Text.Length
        If CInt(lblNecessarias.Text) >= nLetras.Text Then lblNecessarias.BackColor = Color.Red

        'agora vou gerar as letras aleatorias



        Dim totAleatoria As Integer = nLetras.Value - txtNecessarias.Text.Length - 1
        Dim totvog As Integer = totAleatoria * 0.4
        Dim vogs() As Integer = {0, 4, 7, 8, 14, 20, 24}

        'focando primeiro nas 'vogais' a e i o u h y

        Randomize()
        Dim l As Integer

        For i As Integer = 0 To totvog - 1
            l = Rnd() * (vogs.Length - 1)
            If letras(vogs(l)) = 0 Then
                letras(vogs(l)) = 1
                txtAleatorias.Text &= Chr(vogs(l) + 65)
                totAleatoria -= 1
            End If
        Next

        For i As Integer = 0 To totAleatoria

            l = (Rnd() * 25)
            While letras(l) > 0
                l += 1
                If l >= 26 Then
                    l = 0
                End If
            End While

            letras(l) = 1
            txtAleatorias.Text &= Chr(l + 65)

        Next

        lblAleatorias.Text = txtAleatorias.Text.Length

        txtFinal.Text = montaTeclado(letras)

    End Sub

    Function montaTeclado(ByVal l() As Integer) As String

        'Dim ordem() As Integer = {81, 87, 69, 82, 84, 89, 85, 73, 79, 80, 65, 83, 68, 70, 71, 72, 74, 75, 76, 90, 88, 67, 86, 66, 78, 77}
        Dim ordem() As Integer = {16, 22, 4, 17, 19, 24, 20, 8, 14, 15, 0, 18, 3, 5, 6, 7, 9, 10, 11, 25, 23, 2, 21, 1, 13, 12}
        Dim str As String = ""

        For i As Integer = 0 To ordem.Length - 1

            If l(ordem(i)) > 0 Then
                str &= Chr(ordem(i) + 65)
            End If

        Next

        Return str

    End Function

    Sub limpa()

        txtNecessarias.Text = ""
        txtAleatorias.Text = ""
        txtExclusivas.Text = ""
        txtFinal.Text = ""
        lblAleatorias.Text = ""
        lblExclusivas.Text = ""
        lblNecessarias.Text = ""

        lblNecessarias.BackColor = lblExclusivas.BackColor

    End Sub



    Sub pegaLetras(ByVal texto As String, ByRef l() As Integer)

        Dim t As String = Regex.Replace(texto.ToUpper, "[^A-Z]", "")
        For Each c As Char In t
            l(Asc(c) - 65) += 1
        Next

    End Sub



End Class
