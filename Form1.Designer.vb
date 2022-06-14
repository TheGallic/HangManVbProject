<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxDifficult = New System.Windows.Forms.ComboBox()
        Me.lblDifficult = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.lblFaultNumber = New System.Windows.Forms.Label()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HangManVbProject.My.Resources.Resources._0
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cbxDifficult
        '
        Me.cbxDifficult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDifficult.FormattingEnabled = True
        Me.cbxDifficult.Items.AddRange(New Object() {"Facile", "Intermediaire", "Difficile", "Expert"})
        Me.cbxDifficult.Location = New System.Drawing.Point(439, 36)
        Me.cbxDifficult.Name = "cbxDifficult"
        Me.cbxDifficult.Size = New System.Drawing.Size(227, 23)
        Me.cbxDifficult.TabIndex = 1
        '
        'lblDifficult
        '
        Me.lblDifficult.AutoSize = True
        Me.lblDifficult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDifficult.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDifficult.Location = New System.Drawing.Point(439, 9)
        Me.lblDifficult.Name = "lblDifficult"
        Me.lblDifficult.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDifficult.Size = New System.Drawing.Size(176, 21)
        Me.lblDifficult.TabIndex = 2
        Me.lblDifficult.Text = "Sélectionner la difficulté"
        '
        'btnA
        '
        Me.btnA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnA.Location = New System.Drawing.Point(12, 273)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(60, 45)
        Me.btnA.TabIndex = 3
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'lblFaultNumber
        '
        Me.lblFaultNumber.AutoSize = True
        Me.lblFaultNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFaultNumber.ForeColor = System.Drawing.Color.Red
        Me.lblFaultNumber.Location = New System.Drawing.Point(12, 215)
        Me.lblFaultNumber.Name = "lblFaultNumber"
        Me.lblFaultNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFaultNumber.Size = New System.Drawing.Size(157, 21)
        Me.lblFaultNumber.TabIndex = 4
        Me.lblFaultNumber.Text = "Vous avez fait 0 faute"
        '
        'btnB
        '
        Me.btnB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnB.Location = New System.Drawing.Point(78, 273)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(60, 45)
        Me.btnB.TabIndex = 5
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnC.Location = New System.Drawing.Point(144, 273)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(60, 45)
        Me.btnC.TabIndex = 6
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnD.Location = New System.Drawing.Point(210, 273)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(60, 45)
        Me.btnD.TabIndex = 7
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnE.Location = New System.Drawing.Point(276, 273)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(60, 45)
        Me.btnE.TabIndex = 8
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnF.Location = New System.Drawing.Point(342, 273)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(60, 45)
        Me.btnF.TabIndex = 9
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnG.Location = New System.Drawing.Point(408, 273)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(60, 45)
        Me.btnG.TabIndex = 10
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'btnH
        '
        Me.btnH.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnH.Location = New System.Drawing.Point(474, 273)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(60, 45)
        Me.btnH.TabIndex = 11
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnI.Location = New System.Drawing.Point(540, 273)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(60, 45)
        Me.btnI.TabIndex = 12
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnJ.Location = New System.Drawing.Point(606, 273)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(60, 45)
        Me.btnJ.TabIndex = 13
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnK.Location = New System.Drawing.Point(12, 324)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(60, 45)
        Me.btnK.TabIndex = 14
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnL.Location = New System.Drawing.Point(78, 324)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(60, 45)
        Me.btnL.TabIndex = 15
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnM.Location = New System.Drawing.Point(144, 324)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(60, 45)
        Me.btnM.TabIndex = 16
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnN.Location = New System.Drawing.Point(210, 324)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(60, 45)
        Me.btnN.TabIndex = 17
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnO.Location = New System.Drawing.Point(276, 324)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(60, 45)
        Me.btnO.TabIndex = 18
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnP
        '
        Me.btnP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnP.Location = New System.Drawing.Point(342, 324)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(60, 45)
        Me.btnP.TabIndex = 19
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnQ.Location = New System.Drawing.Point(408, 324)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(60, 45)
        Me.btnQ.TabIndex = 20
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnR.Location = New System.Drawing.Point(474, 324)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(60, 45)
        Me.btnR.TabIndex = 21
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnS.Location = New System.Drawing.Point(540, 324)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(60, 45)
        Me.btnS.TabIndex = 22
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnT.Location = New System.Drawing.Point(606, 324)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(60, 45)
        Me.btnT.TabIndex = 23
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnU.Location = New System.Drawing.Point(144, 375)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(60, 45)
        Me.btnU.TabIndex = 24
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnV.Location = New System.Drawing.Point(210, 375)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(60, 45)
        Me.btnV.TabIndex = 25
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnW.Location = New System.Drawing.Point(276, 373)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(60, 45)
        Me.btnW.TabIndex = 26
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnX.Location = New System.Drawing.Point(342, 373)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(60, 45)
        Me.btnX.TabIndex = 27
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnY.Location = New System.Drawing.Point(408, 373)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(60, 45)
        Me.btnY.TabIndex = 28
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'btnZ
        '
        Me.btnZ.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnZ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnZ.Location = New System.Drawing.Point(474, 375)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(60, 45)
        Me.btnZ.TabIndex = 29
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = True
        '
        'btnStartGame
        '
        Me.btnStartGame.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStartGame.Location = New System.Drawing.Point(439, 110)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(227, 36)
        Me.btnStartGame.TabIndex = 30
        Me.btnStartGame.Text = "Jouer"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'lblWord
        '
        Me.lblWord.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWord.Location = New System.Drawing.Point(218, 215)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(448, 37)
        Me.lblWord.TabIndex = 31
        Me.lblWord.Text = "HangMan"
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfo.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblInfo.Location = New System.Drawing.Point(218, 174)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(448, 23)
        Me.lblInfo.TabIndex = 32
        Me.lblInfo.Text = "Jouer"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 430)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.btnZ)
        Me.Controls.Add(Me.btnY)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnW)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.btnK)
        Me.Controls.Add(Me.btnJ)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.btnH)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.lblFaultNumber)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.lblDifficult)
        Me.Controls.Add(Me.cbxDifficult)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu du pendu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbxDifficult As ComboBox
    Friend WithEvents lblDifficult As Label
    Friend WithEvents btnA As Button
    Friend WithEvents lblFaultNumber As Label
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnStartGame As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents lblInfo As Label
End Class
