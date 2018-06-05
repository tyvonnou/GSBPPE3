Public Class medicament

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    'Dim connString As String = "DSN=DSNORACL;Uid=PPE4;Pwd=estran;"
    Dim connString As String = "DSN=DNS-GSB-Thib;Uid=thibaud;Pwd=estran;"
    Dim donnee As DataTable
    Dim thisDay As DateTime = DateTime.Today

    Public Function getMedicament()
        connect()

        Dim sql As String = "SELECT UNIQUE NOM FROM MEDICAMENT;"
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader

        Return myReader
    End Function


    ''' <summary>
    ''' Retourne les différents conditionnements du médicament
    ''' </summary>
    ''' <param name="medicament"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getCondtionnement(ByVal medicament As String)
        connect()

        Dim sql As String = "SELECT conditionnement FROM medicament WHERE nom = '" & medicament & "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader

        Return myReader
    End Function


    ''' <summary>
    ''' Retourne les conditionnements possible
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getConditionnement()
        connect()

        Dim sql As String = "SELECT type FROM conditionnement;"
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader

        Return myReader
    End Function


    ''' <summary>
    ''' Ajoute un nouveau medicament à la bdd
    ''' </summary>
    ''' <param name="medicament">Nom du nouveau medicament</param>
    ''' <param name="conditionnement">Le conditionnement du nouveau médicament</param>
    ''' <remarks></remarks>
    Public Sub addMedicament(ByVal medicament As String, ByVal conditionnement As String, ByVal quantite As Integer, ByVal seuil As Integer)
        connect()
        Dim sql As String = "SELECT nom FROM medicament WHERE nom LIKE '%" & medicament & "%' AND conditionnement = '" & conditionnement & "';"
        Dim exist As Boolean
        Dim emplacementLetter() As String = {"A", "B", "C", "D", "E"}
        Dim emplacement As String
        Dim rand As New Random()
        Dim number As Integer

        number = rand.Next(0, 5)
        emplacement = rand.Next(1, 2).ToString + emplacementLetter(number)



        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If Trim(myReader.GetString(0)) = medicament Then
                exist = True
            Else
                exist = False
            End If
        End While

        connect()
        sql = "INSERT INTO medicament (nom, conditionnement, quantite, seuilalerte, emplacement) VALUES ('" & medicament & "', '" & conditionnement & "', " & quantite & ", " & seuil & ", '" & emplacement & "');"

        If exist Then
            MessageBox.Show("Le medicament existe déjà !")
        Else
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myReader = myCommand.ExecuteReader
        End If
    End Sub


    ''' <summary>
    ''' Permet d'ajouter des medicaments au stock
    ''' </summary>
    ''' <param name="medicament">Nom du medicament</param>
    ''' <param name="conditionnement">Le conditionnement du medicament</param>
    ''' <param name="quantite">La quantite qui est ajouter au stock</param>
    ''' <remarks></remarks>
    Public Sub addQuantite(ByVal medicament As String, ByVal conditionnement As String, ByVal quantite As Integer, ByVal datePeremption As String)
        Dim thisDay As DateTime = DateTime.Today
        Dim sql As String
        Dim newQuantite As Integer = quantite + getQuantite(medicament, conditionnement)

        'Modification de la quantite total du medicament concernée
        connect()
        sql = "UPDATE medicament SET quantite=" & newQuantite & " WHERE nom='" & medicament & "' AND conditionnement='" & conditionnement & "';"
        'MessageBox.Show(sql)
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader


        'Ajout du mouvement dans l'historique
        connect()
        sql = "INSERT INTO historique (ladate, typemouvement, nommedicament, quantite) VALUES('" & thisDay.ToString("d") & "', 'Entree', '" & medicament & "', " & quantite & ");"
        'MessageBox.Show(sql)
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader


        'Ajout du medicament dans le stock
        'connect()
        'sql = "INSERT INTO stock (NOM, DATEENTREE, DATEPEREMPTION, QUANTITE) VALUES('" & medicament & "', '" & thisDay.ToString("d") & "', '" & datePeremption & "', " & quantite & ");"
        ''MessageBox.Show(sql)
        'myCommand.Connection = myConnection
        'myCommand.CommandText = sql
        'myReader = myCommand.ExecuteReader
    End Sub


    ''' <summary>
    ''' Permet de retirer des medicaments au stock
    ''' </summary>
    ''' <param name="medicament">Nom du medicament</param>
    ''' <param name="conditionnement">Le conditionnement du medicament</param>
    ''' <param name="quantite">La quantite qui est retirer au stock</param>
    ''' <remarks></remarks>
    Public Sub removeQuantite(ByVal medicament As String, ByVal conditionnement As String, ByVal quantite As Integer)
        Dim newQuantite As Integer = getQuantite(medicament, conditionnement) - quantite

        If newQuantite < 0 Then
            MessageBox.Show("La quantite ne peux pas être inférieur à 0")
        Else
            connect()

            Dim sql As String = "UPDATE medicament SET quantite=" & newQuantite & " WHERE nom='" & medicament & "' AND conditionnement='" & conditionnement & "';"

            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myReader = myCommand.ExecuteReader

            'Ajout du mouvement dans l'historique
            connect()
            sql = "INSERT INTO historique (ladate, typemouvement, nommedicament, quantite) VALUES('" & thisDay.ToString("d") & "', 'Sortie', '" & medicament & "', " & quantite & ");"
            'MessageBox.Show(sql)
            myCommand.Connection = myConnection
            myCommand.CommandText = sql
            myReader = myCommand.ExecuteReader
        End If
    End Sub


    Private Function getIndexMedicament(ByVal medicament As String)
        Dim index As Integer
        Dim sql = "SELECT id FROM medicament WHERE nom='" & medicament & "';"

        'Executer la requete

        Return index
    End Function


    ''' <summary>
    ''' Retourne vrai si le medicament existe deja dans la bdd
    ''' </summary>
    ''' <param name="nom">Nom du medicament</param>
    ''' <returns>True / False</returns>
    ''' <remarks></remarks>
    Private Function existMedicament(ByVal nom As String, ByVal conditionnement As String)
        connect()

        Dim sql As String = "SELECT nom FROM medicament WHERE nom LIKE '%" & nom & "%' AND conditionnement = '" & conditionnement & "';"
        Dim exist As Boolean
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader

        While myReader.Read
            If Trim(myReader.GetString(0)) = nom Then
                exist = True
            Else
                exist = False
            End If
        End While

        Return exist
    End Function

    Public Function getQuantite(ByVal medicament As String, ByVal conditionnement As String)
        connect()

        Dim quantiteActuel As Integer
        Dim sql As String = "SELECT quantite FROM medicament WHERE nom='" & medicament & "' AND conditionnement='" & conditionnement & "';"
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader

        While myReader.Read
            quantiteActuel = myReader.GetString(0)
        End While

        Return quantiteActuel
    End Function


    Private Sub connect()
        myConnection.Close()
        myConnection.ConnectionString = connString
        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub








End Class
