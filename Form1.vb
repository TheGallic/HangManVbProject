Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1

    Dim selectedWord As String = ""
    Dim selectedDifficult As String = ""
    Dim btnIsEnabled As Boolean = True
    Dim nbrFault As Integer = 0


    Dim facile = New String() {"Ado", "Bis", "Cor", "Fac", "Fla", "Gaz", "Git", "Glu", "Gos", "Goy", "Hip", "Hop", "Jet", "Kru", "Mai", "Ski", "Sot", "Ton", "Tic"}
    Dim intermediaire = New String() {"Ardu", "Atre", "Bits", "Buna", "Case", "Cire", "Clip", "Corse", "Dock", "Fado", "Four", "Gang", "Kaki", "Regs", "Rhum", "Taie", "Taux", "Thym", "Topa"}
    Dim difficile = New String() {"Ancre", "Alfas", "Banjo", "Escot", "Guipa", "Honni", "Houez", "Igloo", "Iodas", "Moult", "Mucha", "Muscs", "Nicol", "Seaux", "Seuil", "Smalt", "Toqua", "Tyran", "Volve"}
    Dim expert = New String() {"Acajou", "Azimut", "Burine", "Caiman", "Cornes", "Faucon", "Gospel", "Guenon", "Hormis", "Menthe", "Notais", "Nouais", "Pagine", "Pontil", "Sabord", "Seisme", "Whisky", "Yankee", "Zipper"}


    Private Sub btnSartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        If Me.cbxDifficult.Text = "" Then
            MessageBox.Show("Veuiller sélectionner un niveau de difficulté !!.")
            Exit Sub
        Else
            ' On reactive tous les boutons du clavier visuel
            If btnStartGame.Text = "Rejouer" And selectedWord = "" Then
                btnA.Enabled = True
                btnB.Enabled = True
                btnC.Enabled = True
                btnD.Enabled = True
                btnE.Enabled = True
                btnF.Enabled = True
                btnG.Enabled = True
                btnH.Enabled = True
                btnI.Enabled = True
                btnJ.Enabled = True
                btnK.Enabled = True
                btnL.Enabled = True
                btnM.Enabled = True
                btnN.Enabled = True
                btnO.Enabled = True
                btnP.Enabled = True
                btnQ.Enabled = True
                btnR.Enabled = True
                btnS.Enabled = True
                btnT.Enabled = True
                btnU.Enabled = True
                btnV.Enabled = True
                btnW.Enabled = True
                btnX.Enabled = True
                btnY.Enabled = True
                btnZ.Enabled = True
            End If
            nbrFault = 0
            getImage()
            lblInfo.Text = "Rejouer"
            lblFaultNumber.Text = "Vous avez fait 0 faute"
            If cbxDifficult.Text = "Facile" Or cbxDifficult.Text = "Intermediaire" Then
                btnIsEnabled = False
            Else
                btnIsEnabled = True
            End If

            btnStartGame.Enabled = False
            cbxDifficult.Enabled = False
            selectedDifficult = cbxDifficult.Text


            generatedWord()
        End If
    End Sub

    Public Sub generatedWord()
        Dim thisTable = New String(19) {}
        Dim rnd As New Random
        Dim roundedNbr As Integer

        Select Case selectedDifficult
            Case "Facile"
                thisTable = facile
                lblWord.Text = "***"
            Case "Intermediaire"
                thisTable = intermediaire
                lblWord.Text = "****"
            Case "Difficile"
                thisTable = difficile
                lblWord.Text = "*****"
            Case "Expert"
                thisTable = expert
                lblWord.Text = "******"
        End Select
        'On genere un nombre aleatoire et on va le chercher dan le tableau
        roundedNbr = rnd.Next(19)
        Dim thisword As String = thisTable.ElementAt(roundedNbr)
        selectedWord = thisword.ToUpper

        lblInfo.Text = "Un mot a été choisi, commencer la partie."
    End Sub
    Public Sub getImage()
        Dim thisImage As Bitmap = My.Resources._0
        If nbrFault = 0 Then
            thisImage = My.Resources._0
        ElseIf nbrFault = 1 Then
            thisImage = My.Resources._1
        ElseIf nbrFault = 2 Then
            thisImage = My.Resources._2
        ElseIf nbrFault = 3 Then
            thisImage = My.Resources._3
        ElseIf nbrFault = 4 Then
            thisImage = My.Resources._4
        ElseIf nbrFault = 5 Then
            thisImage = My.Resources._5
        ElseIf nbrFault = 6 Then
            thisImage = My.Resources._6
        End If
        PictureBox1.Image = thisImage
    End Sub

    Public Sub loosing()
        lblInfo.Text = "Vous avez perdu !!!"
        lblWord.Text = selectedWord
        btnStartGame.Enabled = True
        cbxDifficult.Enabled = True
        btnStartGame.Text = "Rejouer"
        selectedWord = ""
    End Sub

    Public Sub addChar(myLetter As Char)
        Dim thisWord As String = lblWord.Text
        Dim TempWord As New StringBuilder(thisWord)

        'On verifie que la partie n'est pas finie
        If nbrFault < 6 And lblWord.Text.Contains("*") = True Then

            Dim index2 As Integer = selectedWord.Contains(myLetter)

            If index2 = False Then
                nbrFault += 1
                lblFaultNumber.Text = "Vous avez fait " & nbrFault & " faute(s)"
                getImage()
                If nbrFault = 6 Then
                    loosing()
                    Return
                End If
            Else
                'On rajoute une ou plusieurs lettres au mot
                Dim i As Integer
                    Dim thisLetter As Char


                    While i < selectedWord.Length
                        thisLetter = selectedWord.Chars(i)
                        If thisLetter = myLetter Then
                            TempWord.Chars(i) = myLetter
                        End If
                        i += 1
                    End While


                    'On affiche le nouveau mot
                    Dim endString As String = TempWord.ToString
                    lblWord.Text = endString
                    thisWord = endString
                End If
                'La partie est perdu
                If nbrFault = 6 Then
                    loosing()
                    Return
                End If
            Else
                'La partie est perdu
                loosing()
            Return
        End If
        'On verifie si c'est gagné
        If selectedWord = thisWord Then
            lblInfo.Text = "Vous avez gagner !!"
            lblWord.Text = selectedWord
            cbxDifficult.Enabled = True
            btnStartGame.Enabled = True
            btnStartGame.Text = "Rejouer"
            selectedWord = ""
            Return
        End If

    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If selectedWord <> Nothing Then
            addChar("A")
            If btnIsEnabled = False Then
                btnA.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If selectedWord <> Nothing Then
            addChar("B")
            If btnIsEnabled = False Then
                btnB.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If selectedWord <> Nothing Then
            addChar("C")
            If btnIsEnabled = False Then
                btnC.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        If selectedWord <> Nothing Then
            addChar("D")
            If btnIsEnabled = False Then
                btnD.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        If selectedWord <> Nothing Then
            addChar("E")
            If btnIsEnabled = False Then
                btnE.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        If selectedWord <> Nothing Then
            addChar("F")
            If btnIsEnabled = False Then
                btnF.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        If selectedWord <> Nothing Then
            addChar("G")
            If btnIsEnabled = False Then
                btnG.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        If selectedWord <> Nothing Then
            addChar("H")
            If btnIsEnabled = False Then
                btnH.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        If selectedWord <> Nothing Then
            addChar("I")
            If btnIsEnabled = False Then
                btnI.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        If selectedWord <> Nothing Then
            addChar("J")
            If btnIsEnabled = False Then
                btnJ.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        If selectedWord <> Nothing Then
            addChar("K")
            If btnIsEnabled = False Then
                btnK.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        If selectedWord <> Nothing Then
            addChar("L")
            If btnIsEnabled = False Then
                btnL.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        If selectedWord <> Nothing Then
            addChar("M")
            If btnIsEnabled = False Then
                btnM.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        If selectedWord <> Nothing Then
            addChar("N")
            If btnIsEnabled = False Then
                btnN.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        If selectedWord <> Nothing Then
            addChar("O")
            If btnIsEnabled = False Then
                btnO.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        If selectedWord <> Nothing Then
            addChar("P")
            If btnIsEnabled = False Then
                btnP.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        If selectedWord <> Nothing Then
            addChar("Q")
            If btnIsEnabled = False Then
                btnQ.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        If selectedWord <> Nothing Then
            addChar("R")
            If btnIsEnabled = False Then
                btnR.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        If selectedWord <> Nothing Then
            addChar("S")
            If btnIsEnabled = False Then
                btnS.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        If selectedWord <> Nothing Then
            addChar("T")
            If btnIsEnabled = False Then
                btnT.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        If selectedWord <> Nothing Then
            addChar("U")
            If btnIsEnabled = False Then
                btnU.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        If selectedWord <> Nothing Then
            addChar("V")
            If btnIsEnabled = False Then
                btnV.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        If selectedWord <> Nothing Then
            addChar("W")
            If btnIsEnabled = False Then
                btnW.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        If selectedWord <> Nothing Then
            addChar("X")
            If btnIsEnabled = False Then
                btnX.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        If selectedWord <> Nothing Then
            addChar("Y")
            If btnIsEnabled = False Then
                btnY.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        If selectedWord <> Nothing Then
            addChar("Z")
            If btnIsEnabled = False Then
                btnZ.Enabled = False
            End If
        End If
    End Sub
End Class
