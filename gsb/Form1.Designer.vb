<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.peremption = New System.Windows.Forms.TextBox()
        Me.quantiteActuel = New System.Windows.Forms.Label()
        Me.radioRetirer = New System.Windows.Forms.RadioButton()
        Me.radioAjouter = New System.Windows.Forms.RadioButton()
        Me.test = New System.Windows.Forms.Label()
        Me.nomMedicament = New System.Windows.Forms.ComboBox()
        Me.quantite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.conditionnement = New System.Windows.Forms.ComboBox()
        Me.enregistre = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nomMedicNew = New System.Windows.Forms.TextBox()
        Me.test2 = New System.Windows.Forms.Label()
        Me.seuil = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.quantiteNew = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.conditionnementNew = New System.Windows.Forms.ComboBox()
        Me.EnregistrerNew = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridStockSortie = New System.Windows.Forms.DataGridView()
        Me.ButtonActualise = New System.Windows.Forms.Button()
        Me.DataGridStockEntree = New System.Windows.Forms.DataGridView()
        Me.LabelMouvementStock = New System.Windows.Forms.Label()
        Me.LabelSortie = New System.Windows.Forms.Label()
        Me.LabelEntree = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListeEmplacement = New System.Windows.Forms.ComboBox()
        Me.resultat = New System.Windows.Forms.DataGridView()
        Me.ListeNomMedicament = New System.Windows.Forms.ComboBox()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.ListeConditionnement = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridStockSortie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridStockEntree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.resultat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1031, 648)
        Me.TabControl.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1023, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ajout au stock"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.peremption)
        Me.GroupBox1.Controls.Add(Me.quantiteActuel)
        Me.GroupBox1.Controls.Add(Me.radioRetirer)
        Me.GroupBox1.Controls.Add(Me.radioAjouter)
        Me.GroupBox1.Controls.Add(Me.test)
        Me.GroupBox1.Controls.Add(Me.nomMedicament)
        Me.GroupBox1.Controls.Add(Me.quantite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.conditionnement)
        Me.GroupBox1.Controls.Add(Me.enregistre)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1011, 616)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter au stock"
        '
        'peremption
        '
        Me.peremption.Location = New System.Drawing.Point(100, 90)
        Me.peremption.Name = "peremption"
        Me.peremption.Size = New System.Drawing.Size(100, 20)
        Me.peremption.TabIndex = 18
        '
        'quantiteActuel
        '
        Me.quantiteActuel.AutoSize = True
        Me.quantiteActuel.Location = New System.Drawing.Point(206, 119)
        Me.quantiteActuel.Name = "quantiteActuel"
        Me.quantiteActuel.Size = New System.Drawing.Size(46, 13)
        Me.quantiteActuel.TabIndex = 17
        Me.quantiteActuel.Text = "QteActu"
        '
        'radioRetirer
        '
        Me.radioRetirer.AutoSize = True
        Me.radioRetirer.Location = New System.Drawing.Point(156, 142)
        Me.radioRetirer.Name = "radioRetirer"
        Me.radioRetirer.Size = New System.Drawing.Size(56, 17)
        Me.radioRetirer.TabIndex = 16
        Me.radioRetirer.TabStop = True
        Me.radioRetirer.Text = "Retirer"
        Me.radioRetirer.UseVisualStyleBackColor = True
        '
        'radioAjouter
        '
        Me.radioAjouter.AutoSize = True
        Me.radioAjouter.Location = New System.Drawing.Point(92, 142)
        Me.radioAjouter.Name = "radioAjouter"
        Me.radioAjouter.Size = New System.Drawing.Size(58, 17)
        Me.radioAjouter.TabIndex = 15
        Me.radioAjouter.TabStop = True
        Me.radioAjouter.Text = "Ajouter"
        Me.radioAjouter.UseVisualStyleBackColor = True
        '
        'test
        '
        Me.test.AutoSize = True
        Me.test.Location = New System.Drawing.Point(0, 176)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(39, 13)
        Me.test.TabIndex = 14
        Me.test.Text = "Label6"
        '
        'nomMedicament
        '
        Me.nomMedicament.FormattingEnabled = True
        Me.nomMedicament.Location = New System.Drawing.Point(100, 34)
        Me.nomMedicament.Name = "nomMedicament"
        Me.nomMedicament.Size = New System.Drawing.Size(100, 21)
        Me.nomMedicament.TabIndex = 13
        '
        'quantite
        '
        Me.quantite.Location = New System.Drawing.Point(100, 116)
        Me.quantite.Name = "quantite"
        Me.quantite.Size = New System.Drawing.Size(100, 20)
        Me.quantite.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantite:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date peremption:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Conditionnement:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Medicament:"
        '
        'conditionnement
        '
        Me.conditionnement.FormattingEnabled = True
        Me.conditionnement.Location = New System.Drawing.Point(100, 63)
        Me.conditionnement.Name = "conditionnement"
        Me.conditionnement.Size = New System.Drawing.Size(100, 21)
        Me.conditionnement.TabIndex = 0
        '
        'enregistre
        '
        Me.enregistre.Location = New System.Drawing.Point(930, 587)
        Me.enregistre.Name = "enregistre"
        Me.enregistre.Size = New System.Drawing.Size(75, 23)
        Me.enregistre.TabIndex = 1
        Me.enregistre.Text = "Enregistrer"
        Me.enregistre.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1023, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ajout medicament"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nomMedicNew)
        Me.GroupBox2.Controls.Add(Me.test2)
        Me.GroupBox2.Controls.Add(Me.seuil)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.quantiteNew)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.conditionnementNew)
        Me.GroupBox2.Controls.Add(Me.EnregistrerNew)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1011, 615)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ajouter medicament"
        '
        'nomMedicNew
        '
        Me.nomMedicNew.Location = New System.Drawing.Point(100, 34)
        Me.nomMedicNew.Name = "nomMedicNew"
        Me.nomMedicNew.Size = New System.Drawing.Size(100, 20)
        Me.nomMedicNew.TabIndex = 15
        '
        'test2
        '
        Me.test2.AutoSize = True
        Me.test2.Location = New System.Drawing.Point(0, 142)
        Me.test2.Name = "test2"
        Me.test2.Size = New System.Drawing.Size(39, 13)
        Me.test2.TabIndex = 14
        Me.test2.Text = "Label6"
        '
        'seuil
        '
        Me.seuil.Location = New System.Drawing.Point(369, 34)
        Me.seuil.Name = "seuil"
        Me.seuil.Size = New System.Drawing.Size(100, 20)
        Me.seuil.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Seuil réapprovisionnement:"
        '
        'quantiteNew
        '
        Me.quantiteNew.Location = New System.Drawing.Point(100, 90)
        Me.quantiteNew.Name = "quantiteNew"
        Me.quantiteNew.Size = New System.Drawing.Size(100, 20)
        Me.quantiteNew.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Quantite:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Conditionnement:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Medicament:"
        '
        'conditionnementNew
        '
        Me.conditionnementNew.FormattingEnabled = True
        Me.conditionnementNew.Location = New System.Drawing.Point(100, 63)
        Me.conditionnementNew.Name = "conditionnementNew"
        Me.conditionnementNew.Size = New System.Drawing.Size(100, 21)
        Me.conditionnementNew.TabIndex = 0
        '
        'EnregistrerNew
        '
        Me.EnregistrerNew.Location = New System.Drawing.Point(930, 586)
        Me.EnregistrerNew.Name = "EnregistrerNew"
        Me.EnregistrerNew.Size = New System.Drawing.Size(75, 23)
        Me.EnregistrerNew.TabIndex = 1
        Me.EnregistrerNew.Text = "Enregistrer"
        Me.EnregistrerNew.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1023, 622)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Historique"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridStockSortie)
        Me.GroupBox3.Controls.Add(Me.ButtonActualise)
        Me.GroupBox3.Controls.Add(Me.DataGridStockEntree)
        Me.GroupBox3.Controls.Add(Me.LabelMouvementStock)
        Me.GroupBox3.Controls.Add(Me.LabelSortie)
        Me.GroupBox3.Controls.Add(Me.LabelEntree)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1011, 610)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mouvement"
        '
        'DataGridStockSortie
        '
        Me.DataGridStockSortie.AllowUserToAddRows = False
        Me.DataGridStockSortie.AllowUserToDeleteRows = False
        Me.DataGridStockSortie.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridStockSortie.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridStockSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("OpenSymbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridStockSortie.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridStockSortie.Location = New System.Drawing.Point(571, 111)
        Me.DataGridStockSortie.Name = "DataGridStockSortie"
        Me.DataGridStockSortie.ReadOnly = True
        Me.DataGridStockSortie.Size = New System.Drawing.Size(343, 443)
        Me.DataGridStockSortie.TabIndex = 27
        '
        'ButtonActualise
        '
        Me.ButtonActualise.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualise.Location = New System.Drawing.Point(460, 571)
        Me.ButtonActualise.Name = "ButtonActualise"
        Me.ButtonActualise.Size = New System.Drawing.Size(97, 33)
        Me.ButtonActualise.TabIndex = 26
        Me.ButtonActualise.Text = "Actualiser"
        Me.ButtonActualise.UseVisualStyleBackColor = True
        '
        'DataGridStockEntree
        '
        Me.DataGridStockEntree.AllowUserToAddRows = False
        Me.DataGridStockEntree.AllowUserToDeleteRows = False
        Me.DataGridStockEntree.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridStockEntree.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridStockEntree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("OpenSymbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridStockEntree.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridStockEntree.Location = New System.Drawing.Point(100, 111)
        Me.DataGridStockEntree.Name = "DataGridStockEntree"
        Me.DataGridStockEntree.ReadOnly = True
        Me.DataGridStockEntree.Size = New System.Drawing.Size(343, 443)
        Me.DataGridStockEntree.TabIndex = 25
        '
        'LabelMouvementStock
        '
        Me.LabelMouvementStock.AutoSize = True
        Me.LabelMouvementStock.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMouvementStock.Location = New System.Drawing.Point(422, 12)
        Me.LabelMouvementStock.Name = "LabelMouvementStock"
        Me.LabelMouvementStock.Size = New System.Drawing.Size(181, 25)
        Me.LabelMouvementStock.TabIndex = 24
        Me.LabelMouvementStock.Text = "Mouvement stock"
        '
        'LabelSortie
        '
        Me.LabelSortie.AutoSize = True
        Me.LabelSortie.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSortie.Location = New System.Drawing.Point(717, 84)
        Me.LabelSortie.Name = "LabelSortie"
        Me.LabelSortie.Size = New System.Drawing.Size(59, 24)
        Me.LabelSortie.TabIndex = 23
        Me.LabelSortie.Text = "Sortie"
        '
        'LabelEntree
        '
        Me.LabelEntree.AutoSize = True
        Me.LabelEntree.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEntree.Location = New System.Drawing.Point(238, 84)
        Me.LabelEntree.Name = "LabelEntree"
        Me.LabelEntree.Size = New System.Drawing.Size(66, 24)
        Me.LabelEntree.TabIndex = 22
        Me.LabelEntree.Text = "Entrée"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1023, 622)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Emplacement"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.ListeEmplacement)
        Me.GroupBox4.Controls.Add(Me.resultat)
        Me.GroupBox4.Controls.Add(Me.ListeNomMedicament)
        Me.GroupBox4.Controls.Add(Me.Rechercher)
        Me.GroupBox4.Controls.Add(Me.ListeConditionnement)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1011, 610)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Emplacement"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 21)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Emplacement :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 21)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Recherche d'un emplacement :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 21)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Recherche d'un médicament :"
        '
        'ListeEmplacement
        '
        Me.ListeEmplacement.FormattingEnabled = True
        Me.ListeEmplacement.Location = New System.Drawing.Point(141, 277)
        Me.ListeEmplacement.Name = "ListeEmplacement"
        Me.ListeEmplacement.Size = New System.Drawing.Size(100, 21)
        Me.ListeEmplacement.TabIndex = 42
        '
        'resultat
        '
        Me.resultat.AllowUserToAddRows = False
        Me.resultat.AllowUserToDeleteRows = False
        Me.resultat.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.resultat.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.resultat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.resultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.resultat.DefaultCellStyle = DataGridViewCellStyle6
        Me.resultat.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.resultat.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.resultat.Location = New System.Drawing.Point(255, 71)
        Me.resultat.Name = "resultat"
        Me.resultat.ReadOnly = True
        Me.resultat.Size = New System.Drawing.Size(655, 369)
        Me.resultat.TabIndex = 41
        '
        'ListeNomMedicament
        '
        Me.ListeNomMedicament.FormattingEnabled = True
        Me.ListeNomMedicament.Location = New System.Drawing.Point(142, 69)
        Me.ListeNomMedicament.Name = "ListeNomMedicament"
        Me.ListeNomMedicament.Size = New System.Drawing.Size(100, 21)
        Me.ListeNomMedicament.TabIndex = 40
        '
        'Rechercher
        '
        Me.Rechercher.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rechercher.Location = New System.Drawing.Point(142, 156)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(100, 21)
        Me.Rechercher.TabIndex = 39
        Me.Rechercher.Text = "Recherche"
        Me.Rechercher.UseVisualStyleBackColor = True
        '
        'ListeConditionnement
        '
        Me.ListeConditionnement.FormattingEnabled = True
        Me.ListeConditionnement.Location = New System.Drawing.Point(142, 106)
        Me.ListeConditionnement.Name = "ListeConditionnement"
        Me.ListeConditionnement.Size = New System.Drawing.Size(100, 21)
        Me.ListeConditionnement.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 15)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Conditionnement :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Nom médicament :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 664)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Gestion des stocks"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridStockSortie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridStockEntree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.resultat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents peremption As System.Windows.Forms.TextBox
    Friend WithEvents quantiteActuel As System.Windows.Forms.Label
    Friend WithEvents radioRetirer As System.Windows.Forms.RadioButton
    Friend WithEvents radioAjouter As System.Windows.Forms.RadioButton
    Friend WithEvents test As System.Windows.Forms.Label
    Friend WithEvents nomMedicament As System.Windows.Forms.ComboBox
    Friend WithEvents quantite As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents conditionnement As System.Windows.Forms.ComboBox
    Friend WithEvents enregistre As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents nomMedicNew As System.Windows.Forms.TextBox
    Friend WithEvents test2 As System.Windows.Forms.Label
    Friend WithEvents seuil As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents quantiteNew As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents conditionnementNew As System.Windows.Forms.ComboBox
    Friend WithEvents EnregistrerNew As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridStockSortie As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonActualise As System.Windows.Forms.Button
    Friend WithEvents DataGridStockEntree As System.Windows.Forms.DataGridView
    Friend WithEvents LabelMouvementStock As System.Windows.Forms.Label
    Friend WithEvents LabelSortie As System.Windows.Forms.Label
    Friend WithEvents LabelEntree As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListeEmplacement As System.Windows.Forms.ComboBox
    Friend WithEvents resultat As System.Windows.Forms.DataGridView
    Friend WithEvents ListeNomMedicament As System.Windows.Forms.ComboBox
    Friend WithEvents Rechercher As System.Windows.Forms.Button
    Friend WithEvents ListeConditionnement As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
