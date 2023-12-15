Public Class Form2
    Private Medocontent() As Form1.AddMedicament
    Public Sub New(Medocontent() As Form1.AddMedicament)
        InitializeComponent()
        Me.Medocontent = Medocontent
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurez le DataGridView pour afficher les données
        DataGridView1.AutoGenerateColumns = True ' Génère automatiquement les colonnes à partir des propriétés de la classe FormRegister
        ' Configurez le DataGridView pour afficher les données
        DataGridView1.AutoGenerateColumns = True ' Génère automatiquement les colonnes à partir des propriétés de la classe FormRegister
        DataGridView1.DataSource = Medocontent ' Définissez le tableau comme source de données du DataGridView
    End Sub
End Class