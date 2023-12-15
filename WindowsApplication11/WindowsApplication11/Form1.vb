Public Class Form1
    Public Class AddMedicament
        Public Nom As String
        Public DosageJour As String
        Public DosageNuit As String
        Public Prix As String

        Function Length() As Integer
            Throw New NotImplementedException
        End Function

    End Class

    'tableau pour ajouter les nuveaux medicament
    Private NewMedoc() As AddMedicament
    Dim Medocontent As AddMedicament

  

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2(NewMedoc)
        form2.DataGridView1.DataSource = NewMedoc
        form2.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Medocontent = New AddMedicament()

        Medocontent.Nom = TextBox1.Text
        Medocontent.DosageJour = ComboBox1.SelectedIndex
        Medocontent.DosageNuit = ComboBox2.SelectedIndex
        Medocontent.Prix = TextBox2.Text

        If NewMedoc Is Nothing Then
            ReDim NewMedoc(0)
        Else
            ReDim Preserve NewMedoc(NewMedoc.Length)
        End If
        NewMedoc(NewMedoc.Length - 1) = Medocontent
    End Sub



End Class
