Public Class Form1
    Dim medicament As medicament = New medicament

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        peremption.Text = "01/01/1900"

        conditionnement.Enabled = False
        quantite.Enabled = False

        'connString = "DSN=DSNORACL;Uid=PPE4;Pwd=estran;"
        Dim connString As String = "DSN=DNS-GSB-Thib; Uid=thibaud; Pwd=estran;"
        'connString = "DSN=DSNORACL;Uid=PPE4;Pwd=estran;"
        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try

        myReader = medicament.getMedicament()
        While myReader.Read
            nomMedicament.Items.Add(Trim(myReader.GetString(0)))
        End While

        myReader = medicament.getConditionnement()
        While myReader.Read
            conditionnementNew.Items.Add(Trim(myReader.GetString(0)))
        End While
    End Sub


#Region "Date placeholder"
    Private Sub peremption_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles peremption.GotFocus
        If peremption.Text <> "01/01/1900" Then
        Else
            peremption.Text = ""
        End If
    End Sub

    Private Sub peremption_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles peremption.LostFocus
        If peremption.Text = "" Then
            peremption.Text = "01/01/1900"
        End If
    End Sub
#End Region

#Region "Add/Remove Stock"
    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        recharge()
    End Sub

    'Affiche le(s) conditionnement(s) du medicament selectionne
    Private Sub nomMedicament_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nomMedicament.SelectedIndexChanged
        conditionnement.Enabled = True

        myReader = medicament.getCondtionnement(nomMedicament.SelectedItem)
        conditionnement.Items.Clear()
        While myReader.Read
            conditionnement.Items.Add(Trim(myReader.GetString(0)))
        End While
    End Sub

    'Affiche la quantite actuel dans le stock du medicament selectionne
    Private Sub conditionnement_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles conditionnement.SelectedIndexChanged
        quantite.Enabled = True
        'quantite.Text = medicament.getQuantite(nomMedic.SelectedItem, conditionnement.SelectedItem)
        quantiteActuel.Text = "La quantite actuel est de : " & medicament.getQuantite(nomMedicament.SelectedItem, conditionnement.SelectedItem)
    End Sub

    Private Sub enregistre_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistre.Click
        Dim nom As String = nomMedicament.SelectedItem
        Dim condition As String = conditionnement.SelectedItem()
        Dim datePeremp As String = peremption.Text
        Dim qt As String = quantite.Text

        If Trim(qt) = "" Or nom = "" Then
            MessageBox.Show("Remplissez tout les champs")
        Else
            If datePeremp = "01/01/1900" Then
                MessageBox.Show("Entrez une date de peremption valide")
            Else
                If radioAjouter.Checked Then
                    medicament.addQuantite(nom, condition, qt, datePeremp)
                ElseIf radioRetirer.Checked Then
                    medicament.removeQuantite(nom, condition, qt)

                End If
                test.Text = "La quantité à bien été mis à jour !"

                quantite.Clear()
                quantiteActuel.Text = "La quantite actuel est de : " & medicament.getQuantite(nomMedicament.SelectedItem, conditionnement.SelectedItem)
            End If
        End If

        


    End Sub
#End Region

#Region "Add Medicament"
    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter

    End Sub

    Private Sub EnregistrerNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerNew.Click
        If nomMedicNew.Text = "" Or conditionnementNew.Text = "" Or quantiteNew.Text = "" Or seuil.Text = "" Then
            MessageBox.Show("Remplir tout les champs")
        Else
            medicament.addMedicament(nomMedicNew.Text, conditionnementNew.SelectedItem, quantiteNew.Text, seuil.Text)
            test2.Text = "Le medicament à été ajouté avec succès !"
            nomMedicNew.Clear()
            conditionnementNew.SelectedItem = ""
            quantiteNew.Clear()
            seuil.Clear()
        End If
    End Sub

#End Region

#Region "Historique"
    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        myConnection.Close()
        Dim sql As String = "SELECT NOMMEDICAMENT, LADATE, QUANTITE FROM HISTORIQUE WHERE TYPEMOUVEMENT = 'Entree';"
        'Permet d' afficher le nom du medicament , la date entree dans le stocks et la quantité ajouté médicament.
        myConnection.Open()
        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(sql, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridStockEntree.DataSource = donnee
        DataGridStockEntree.Columns(0).HeaderText = "Nom du médicament"
        DataGridStockEntree.Columns(1).HeaderText = "Date"
        DataGridStockEntree.Columns(2).HeaderText = "Quantité"
        myConnection.Close()


        myConnection.Open()

        Dim sql2 As String = "SELECT NOMMEDICAMENT, LADATE, QUANTITE FROM HISTORIQUE WHERE TYPEMOUVEMENT = 'Sortie';"

        'Permet d' afficher le nom du medicament , la date de sortie du stocks et la quantité ajouté d'un médicament.

        myCommand.Connection = myConnection
        myCommand.CommandText = sql2
        myReader = myCommand.ExecuteReader
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(sql2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridStockSortie.DataSource = donnee
        DataGridStockSortie.Columns(0).HeaderText = "Nom du médicament" 'permet de changer le nom de la colonne
        DataGridStockSortie.Columns(1).HeaderText = "Date"
        DataGridStockSortie.Columns(2).HeaderText = "Quantité"
        myConnection.Close()
    End Sub

    Private Sub ButtonActualise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualise.Click
        myConnection.Open()

        'Permet d' afficher le nom du medicament , la date entree dans le stocks et la quantité ajouté médicament.
        Dim sql As String = "SELECT NOMMEDICAMENT, LADATE, QUANTITE FROM HISTORIQUE WHERE TYPEMOUVEMENT = 'Entree';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sql
        myReader = myCommand.ExecuteReader
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(sql, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridStockEntree.DataSource = donnee
        myConnection.Close()



        myConnection.Open()

        'Permet d' afficher le nom du medicament , la date de sortie du stocks et la quantité ajouté d'un médicament.
        Dim sql2 As String = "SELECT NOMMEDICAMENT, LADATE, QUANTITE FROM HISTORIQUE WHERE TYPEMOUVEMENT = 'Sortie';"

        myCommand.Connection = myConnection
        myCommand.CommandText = sql2
        myReader = myCommand.ExecuteReader
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(sql2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        DataGridStockSortie.DataSource = donnee
        myConnection.Close()
    End Sub

#End Region

#Region "Emplacement"
    Private Sub TabPage4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage4.Enter
        ListeConditionnement.Enabled = False
        myConnection.Close()
        myConnection.Open()

        Dim query As String = "SELECT UNIQUE NOM FROM MEDICAMENT"
        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeNomMedicament.Items.Add(Trim(myReader.GetString(0)))
        End While


        myConnection.Close()
        myConnection.Open()

        Dim query2 As String = "SELECT ID FROM EMPLACEMENT"
        myCommand.Connection = myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader

        While myReader.Read
            ListeEmplacement.Items.Add(Trim(myReader.GetString(0)))
        End While
    End Sub

    Private Sub ListeNomMedicament_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeNomMedicament.SelectedIndexChanged
        ListeConditionnement.Enabled = True

        myReader = medicament.getCondtionnement(ListeNomMedicament.SelectedItem)
        ListeConditionnement.Items.Clear()
        While myReader.Read
            ListeConditionnement.Items.Add(Trim(myReader.GetString(0)))
        End While
    End Sub

    Private Sub resultat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        myConnection.Close()                '' Connection BDD
        myConnection.Open()

        Dim nom = ListeNomMedicament.SelectedItem.ToString()                '' Récupération des données selectionnées 
        Dim condi = ListeConditionnement.SelectedItem.ToString()

        Dim query2 As String = "SELECT NOM, CONDITIONNEMENT, QUANTITE, EMPLACEMENT FROM MEDICAMENT WHERE NOM = '" & nom & "' AND CONDITIONNEMENT = '" & condi & "' ;"        '' Execution de la commande
        myCommand.Connection = myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        resultat.DataSource = donnee


        'While myReader.Read
        '    resultat.Items.Add(myReader.GetString(0))
        '    resultat.Items.Add(myReader.GetString(1))
        '    resultat.Items.Add(myReader.GetString(2))

        myConnection.Close()

        'End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListeNomMedicament.Text = ""
        ListeConditionnement.Text = ""
        ListeConditionnement.Enabled = False

        myConnection.Close()
        myConnection.Open()


        Dim emp = ListeEmplacement.SelectedItem.ToString()                '' Récupération des données selectionnées 


        Dim query2 As String = "SELECT NOM, CONDITIONNEMENT, QUANTITE, EMPLACEMENT FROM MEDICAMENT WHERE EMPLACEMENT = '" & emp & "' ;" '' Execution de la commande
        myCommand.Connection = myConnection
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader
        donnee = New DataTable
        myAdapter = New Odbc.OdbcDataAdapter(query2, myConnection)
        myBuilder = New Odbc.OdbcCommandBuilder(myAdapter)
        myAdapter.Fill(donnee)
        resultat.DataSource = donnee

    End Sub
#End Region




    'Recharge la liste des conditionnements du medicament selectionne
    Public Sub recharge()
        nomMedicament.Items.Clear()
        conditionnement.Items.Clear()
        nomMedicament.Text = ""
        conditionnement.Text = ""
        quantite.Text = ""
        conditionnement.Enabled = False
        quantite.Enabled = False
        quantiteActuel.Text = ""

        myReader = medicament.getMedicament()
        While myReader.Read
            nomMedicament.Items.Add(Trim(myReader.GetString(0)))
        End While
    End Sub

    ' Permet de fermer la connection à la base de donnée à la fermeture du programme
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        myConnection.Close()
    End Sub

    
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
