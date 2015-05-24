Imports MySql.Data.MySqlClient

Public Class inicio
    Public contador As Integer = 0


    

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If (existeUsuario(txtUsuario.Text, txtPass.Text)) Then
            Me.Hide()
            formPrincipal.Show()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Function existeUsuario(ByVal usuario As String, ByVal pass As String) As Boolean
        Dim conexion As New MySqlConnection
        Dim dataAdapter As New MySqlDataAdapter
        Dim dataSet As New DataSet

        Dim sql As String
        Dim bandera As Boolean = False

        Try
            conexion.ConnectionString = "server=localhost;database=interhome;user id=root;password=root;"
            sql = "SELECT * FROM empresa WHERE idUsuario='" & usuario & "' and passE='" & pass & "' "

            dataAdapter = New MySqlDataAdapter(sql, conexion)
            conexion.Open()

            dataAdapter.Fill(dataSet, "empresa")


            If (dataSet.Tables("empresa").Rows.Count() = 0) Then

                If contador = 3 Then
                    MessageBox.Show("No puede ingresar al sistema, intentos limite", "sistema")
                    Me.Close()
                Else
                    MessageBox.Show("usario y/o password invalidos", "sistema")
                    bandera = True
                    txtUsuario.Text = ""
                    txtPass.Text = ""
                    contador = contador + 1
                    txtUsuario.Focus()

                End If
                bandera = False

            Else
                MessageBox.Show("Bienvenidos", "sistema")
                bandera = True
            End If

        Catch ex As Exception

        End Try
        Return bandera
    End Function


End Class
