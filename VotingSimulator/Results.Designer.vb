<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsForm))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.District2 = New System.Windows.Forms.PictureBox()
        Me.District5 = New System.Windows.Forms.PictureBox()
        Me.District4 = New System.Windows.Forms.PictureBox()
        Me.District9 = New System.Windows.Forms.PictureBox()
        Me.District10 = New System.Windows.Forms.PictureBox()
        Me.District8 = New System.Windows.Forms.PictureBox()
        Me.District6 = New System.Windows.Forms.PictureBox()
        Me.District7 = New System.Windows.Forms.PictureBox()
        Me.District11 = New System.Windows.Forms.PictureBox()
        Me.District3 = New System.Windows.Forms.PictureBox()
        Me.District1 = New System.Windows.Forms.PictureBox()
        Me.District12 = New System.Windows.Forms.PictureBox()
        Me.VoteTotalLabel = New System.Windows.Forms.Label()
        Me.VoteTotalsBox = New System.Windows.Forms.TextBox()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.PurpleLabel = New System.Windows.Forms.Label()
        Me.YellowLabel = New System.Windows.Forms.Label()
        Me.BlueVotesBox = New System.Windows.Forms.TextBox()
        Me.RedVotesBox = New System.Windows.Forms.TextBox()
        Me.GreenVotesBox = New System.Windows.Forms.TextBox()
        Me.PurpleVotesBox = New System.Windows.Forms.TextBox()
        Me.YellowVotesBox = New System.Windows.Forms.TextBox()
        Me.BeginButton = New System.Windows.Forms.Button()
        Me.ElectionFraudButton = New System.Windows.Forms.Button()
        Me.DistrictTally = New System.Windows.Forms.ToolTip(Me.components)
        Me.ResultsTally = New System.Data.DataSet()
        Me.VoterResultsTable = New System.Data.DataTable()
        Me.ExpectedTallyTable = New System.Data.DataTable()
        Me.ActualVoterTallyTable = New System.Data.DataTable()
        Me.LogLabel = New System.Windows.Forms.Label()
        Me.LogText = New System.Windows.Forms.RichTextBox()
        Me.District910Timer = New System.Windows.Forms.Timer(Me.components)
        Me.District1611Timer = New System.Windows.Forms.Timer(Me.components)
        Me.District1272Timer = New System.Windows.Forms.Timer(Me.components)
        Me.District3Timer = New System.Windows.Forms.Timer(Me.components)
        Me.District8Timer = New System.Windows.Forms.Timer(Me.components)
        Me.District5Timer = New System.Windows.Forms.Timer(Me.components)
        Me.District4Timer = New System.Windows.Forms.Timer(Me.components)
        Me.DistrictVoter1 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter2 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter3 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter4 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter5 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter6 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter7 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter8 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter9 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter10 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter11 = New System.ComponentModel.BackgroundWorker()
        Me.DistrictVoter12 = New System.ComponentModel.BackgroundWorker()
        Me.VotersByDistrict = New System.Data.DataSet()
        Me.District1TBL = New System.Data.DataTable()
        Me.District2TBL = New System.Data.DataTable()
        Me.District3TBL = New System.Data.DataTable()
        Me.District4TBL = New System.Data.DataTable()
        Me.District5TBL = New System.Data.DataTable()
        Me.District6TBL = New System.Data.DataTable()
        Me.District7TBL = New System.Data.DataTable()
        Me.District8TBL = New System.Data.DataTable()
        Me.District9TBL = New System.Data.DataTable()
        Me.District10TBL = New System.Data.DataTable()
        Me.DataTable11 = New System.Data.DataTable()
        Me.District12TBL = New System.Data.DataTable()
        CType(Me.District2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTally, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoterResultsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedTallyTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualVoterTallyTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotersByDistrict, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District1TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District2TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District3TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District4TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District5TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District6TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District7TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District8TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District9TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District10TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.District12TBL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(388, 409)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(101, 39)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'District2
        '
        Me.District2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District2.Cursor = System.Windows.Forms.Cursors.Default
        Me.District2.Image = CType(resources.GetObject("District2.Image"), System.Drawing.Image)
        Me.District2.ImageLocation = ""
        Me.District2.Location = New System.Drawing.Point(12, 12)
        Me.District2.Name = "District2"
        Me.District2.Size = New System.Drawing.Size(146, 140)
        Me.District2.TabIndex = 2
        Me.District2.TabStop = False
        '
        'District5
        '
        Me.District5.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\5.png"
        Me.District5.Location = New System.Drawing.Point(74, 67)
        Me.District5.Name = "District5"
        Me.District5.Size = New System.Drawing.Size(140, 140)
        Me.District5.TabIndex = 3
        Me.District5.TabStop = False
        '
        'District4
        '
        Me.District4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District4.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\4.png"
        Me.District4.Location = New System.Drawing.Point(211, 82)
        Me.District4.Name = "District4"
        Me.District4.Size = New System.Drawing.Size(120, 125)
        Me.District4.TabIndex = 4
        Me.District4.TabStop = False
        '
        'District9
        '
        Me.District9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District9.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\9.png"
        Me.District9.Location = New System.Drawing.Point(327, 82)
        Me.District9.Name = "District9"
        Me.District9.Size = New System.Drawing.Size(79, 56)
        Me.District9.TabIndex = 5
        Me.District9.TabStop = False
        '
        'District10
        '
        Me.District10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District10.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\10.png"
        Me.District10.Location = New System.Drawing.Point(327, 137)
        Me.District10.Name = "District10"
        Me.District10.Size = New System.Drawing.Size(79, 70)
        Me.District10.TabIndex = 6
        Me.District10.TabStop = False
        '
        'District8
        '
        Me.District8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District8.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\8.png"
        Me.District8.Location = New System.Drawing.Point(403, 82)
        Me.District8.Name = "District8"
        Me.District8.Size = New System.Drawing.Size(83, 125)
        Me.District8.TabIndex = 7
        Me.District8.TabStop = False
        '
        'District6
        '
        Me.District6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District6.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\6.png"
        Me.District6.Location = New System.Drawing.Point(323, 202)
        Me.District6.Name = "District6"
        Me.District6.Size = New System.Drawing.Size(79, 63)
        Me.District6.TabIndex = 8
        Me.District6.TabStop = False
        '
        'District7
        '
        Me.District7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District7.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\7.png"
        Me.District7.Location = New System.Drawing.Point(323, 258)
        Me.District7.Name = "District7"
        Me.District7.Size = New System.Drawing.Size(83, 63)
        Me.District7.TabIndex = 9
        Me.District7.TabStop = False
        '
        'District11
        '
        Me.District11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District11.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\11.png"
        Me.District11.Location = New System.Drawing.Point(211, 202)
        Me.District11.Name = "District11"
        Me.District11.Size = New System.Drawing.Size(120, 63)
        Me.District11.TabIndex = 10
        Me.District11.TabStop = False
        '
        'District3
        '
        Me.District3.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\3.png"
        Me.District3.Location = New System.Drawing.Point(74, 202)
        Me.District3.Name = "District3"
        Me.District3.Size = New System.Drawing.Size(140, 119)
        Me.District3.TabIndex = 12
        Me.District3.TabStop = False
        '
        'District1
        '
        Me.District1.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\1.png"
        Me.District1.Location = New System.Drawing.Point(74, 202)
        Me.District1.Name = "District1"
        Me.District1.Size = New System.Drawing.Size(90, 128)
        Me.District1.TabIndex = 13
        Me.District1.TabStop = False
        '
        'District12
        '
        Me.District12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.District12.ImageLocation = "C:\Users\NetWorkShare\Desktop\Districts\12.png"
        Me.District12.Location = New System.Drawing.Point(211, 258)
        Me.District12.Name = "District12"
        Me.District12.Size = New System.Drawing.Size(120, 63)
        Me.District12.TabIndex = 11
        Me.District12.TabStop = False
        '
        'VoteTotalLabel
        '
        Me.VoteTotalLabel.AutoSize = True
        Me.VoteTotalLabel.Location = New System.Drawing.Point(319, 12)
        Me.VoteTotalLabel.Name = "VoteTotalLabel"
        Me.VoteTotalLabel.Size = New System.Drawing.Size(64, 13)
        Me.VoteTotalLabel.TabIndex = 14
        Me.VoteTotalLabel.Text = "Vote Totals:"
        '
        'VoteTotalsBox
        '
        Me.VoteTotalsBox.Location = New System.Drawing.Point(389, 9)
        Me.VoteTotalsBox.Name = "VoteTotalsBox"
        Me.VoteTotalsBox.ReadOnly = True
        Me.VoteTotalsBox.Size = New System.Drawing.Size(100, 20)
        Me.VoteTotalsBox.TabIndex = 15
        Me.VoteTotalsBox.TabStop = False
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedLabel.Location = New System.Drawing.Point(5, 383)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(41, 16)
        Me.RedLabel.TabIndex = 16
        Me.RedLabel.Text = "Red:"
        '
        'BlueLabel
        '
        Me.BlueLabel.AutoSize = True
        Me.BlueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueLabel.Location = New System.Drawing.Point(5, 359)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(43, 16)
        Me.BlueLabel.TabIndex = 17
        Me.BlueLabel.Text = "Blue:"
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenLabel.Location = New System.Drawing.Point(110, 359)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(54, 16)
        Me.GreenLabel.TabIndex = 18
        Me.GreenLabel.Text = "Green:"
        '
        'PurpleLabel
        '
        Me.PurpleLabel.AutoSize = True
        Me.PurpleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurpleLabel.Location = New System.Drawing.Point(110, 383)
        Me.PurpleLabel.Name = "PurpleLabel"
        Me.PurpleLabel.Size = New System.Drawing.Size(57, 16)
        Me.PurpleLabel.TabIndex = 19
        Me.PurpleLabel.Text = "Purple:"
        '
        'YellowLabel
        '
        Me.YellowLabel.AutoSize = True
        Me.YellowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YellowLabel.Location = New System.Drawing.Point(231, 359)
        Me.YellowLabel.Name = "YellowLabel"
        Me.YellowLabel.Size = New System.Drawing.Size(58, 16)
        Me.YellowLabel.TabIndex = 20
        Me.YellowLabel.Text = "Yellow:"
        '
        'BlueVotesBox
        '
        Me.BlueVotesBox.Location = New System.Drawing.Point(42, 359)
        Me.BlueVotesBox.Name = "BlueVotesBox"
        Me.BlueVotesBox.ReadOnly = True
        Me.BlueVotesBox.Size = New System.Drawing.Size(64, 20)
        Me.BlueVotesBox.TabIndex = 21
        Me.BlueVotesBox.TabStop = False
        '
        'RedVotesBox
        '
        Me.RedVotesBox.Location = New System.Drawing.Point(42, 383)
        Me.RedVotesBox.Name = "RedVotesBox"
        Me.RedVotesBox.ReadOnly = True
        Me.RedVotesBox.Size = New System.Drawing.Size(64, 20)
        Me.RedVotesBox.TabIndex = 22
        Me.RedVotesBox.TabStop = False
        '
        'GreenVotesBox
        '
        Me.GreenVotesBox.Location = New System.Drawing.Point(161, 360)
        Me.GreenVotesBox.Name = "GreenVotesBox"
        Me.GreenVotesBox.ReadOnly = True
        Me.GreenVotesBox.Size = New System.Drawing.Size(64, 20)
        Me.GreenVotesBox.TabIndex = 23
        Me.GreenVotesBox.TabStop = False
        '
        'PurpleVotesBox
        '
        Me.PurpleVotesBox.Location = New System.Drawing.Point(161, 383)
        Me.PurpleVotesBox.Name = "PurpleVotesBox"
        Me.PurpleVotesBox.ReadOnly = True
        Me.PurpleVotesBox.Size = New System.Drawing.Size(64, 20)
        Me.PurpleVotesBox.TabIndex = 24
        Me.PurpleVotesBox.TabStop = False
        '
        'YellowVotesBox
        '
        Me.YellowVotesBox.Location = New System.Drawing.Point(285, 358)
        Me.YellowVotesBox.Name = "YellowVotesBox"
        Me.YellowVotesBox.ReadOnly = True
        Me.YellowVotesBox.Size = New System.Drawing.Size(64, 20)
        Me.YellowVotesBox.TabIndex = 25
        Me.YellowVotesBox.TabStop = False
        '
        'BeginButton
        '
        Me.BeginButton.Location = New System.Drawing.Point(12, 409)
        Me.BeginButton.Name = "BeginButton"
        Me.BeginButton.Size = New System.Drawing.Size(101, 39)
        Me.BeginButton.TabIndex = 26
        Me.BeginButton.Text = "BEGIN"
        Me.BeginButton.UseVisualStyleBackColor = True
        '
        'ElectionFraudButton
        '
        Me.ElectionFraudButton.BackColor = System.Drawing.Color.Red
        Me.ElectionFraudButton.Cursor = System.Windows.Forms.Cursors.No
        Me.ElectionFraudButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElectionFraudButton.Location = New System.Drawing.Point(119, 409)
        Me.ElectionFraudButton.Name = "ElectionFraudButton"
        Me.ElectionFraudButton.Size = New System.Drawing.Size(101, 39)
        Me.ElectionFraudButton.TabIndex = 27
        Me.ElectionFraudButton.Text = "ELECTION FRAUD"
        Me.ElectionFraudButton.UseVisualStyleBackColor = False
        '
        'ResultsTally
        '
        Me.ResultsTally.DataSetName = "ResultsDataSet"
        Me.ResultsTally.Tables.AddRange(New System.Data.DataTable() {Me.VoterResultsTable, Me.ExpectedTallyTable, Me.ActualVoterTallyTable})
        '
        'VoterResultsTable
        '
        Me.VoterResultsTable.TableName = "VoterResults"
        '
        'ExpectedTallyTable
        '
        Me.ExpectedTallyTable.TableName = "ExpectedVoters"
        '
        'ActualVoterTallyTable
        '
        Me.ActualVoterTallyTable.TableName = "ActualVoters"
        '
        'LogLabel
        '
        Me.LogLabel.AutoSize = True
        Me.LogLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogLabel.Location = New System.Drawing.Point(9, 451)
        Me.LogLabel.Name = "LogLabel"
        Me.LogLabel.Size = New System.Drawing.Size(42, 16)
        Me.LogLabel.TabIndex = 28
        Me.LogLabel.Text = "LOG:"
        '
        'LogText
        '
        Me.LogText.HideSelection = False
        Me.LogText.Location = New System.Drawing.Point(12, 471)
        Me.LogText.Name = "LogText"
        Me.LogText.ReadOnly = True
        Me.LogText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.LogText.Size = New System.Drawing.Size(474, 48)
        Me.LogText.TabIndex = 29
        Me.LogText.Text = ""
        '
        'District910Timer
        '
        Me.District910Timer.Interval = 1
        '
        'District1611Timer
        '
        Me.District1611Timer.Interval = 1
        '
        'District1272Timer
        '
        Me.District1272Timer.Interval = 1
        '
        'District3Timer
        '
        Me.District3Timer.Interval = 1
        '
        'District8Timer
        '
        Me.District8Timer.Interval = 1
        '
        'District5Timer
        '
        Me.District5Timer.Interval = 1
        '
        'District4Timer
        '
        Me.District4Timer.Interval = 1
        '
        'DistrictVoter1
        '
        '
        'DistrictVoter2
        '
        '
        'DistrictVoter3
        '
        '
        'DistrictVoter4
        '
        '
        'DistrictVoter5
        '
        '
        'DistrictVoter6
        '
        '
        'DistrictVoter7
        '
        '
        'DistrictVoter8
        '
        '
        'DistrictVoter9
        '
        '
        'DistrictVoter10
        '
        '
        'DistrictVoter11
        '
        '
        'DistrictVoter12
        '
        '
        'VotersByDistrict
        '
        Me.VotersByDistrict.DataSetName = "VoterByDistrictDS"
        Me.VotersByDistrict.Tables.AddRange(New System.Data.DataTable() {Me.District1TBL, Me.District2TBL, Me.District3TBL, Me.District4TBL, Me.District5TBL, Me.District6TBL, Me.District7TBL, Me.District8TBL, Me.District9TBL, Me.District10TBL, Me.DataTable11, Me.District12TBL})
        '
        'District1TBL
        '
        Me.District1TBL.TableName = "District1Table"
        '
        'District2TBL
        '
        Me.District2TBL.TableName = "District2Table"
        '
        'District3TBL
        '
        Me.District3TBL.TableName = "District3Table"
        '
        'District4TBL
        '
        Me.District4TBL.TableName = "District4Table"
        '
        'District5TBL
        '
        Me.District5TBL.TableName = "District5Table"
        '
        'District6TBL
        '
        Me.District6TBL.TableName = "District6Table"
        '
        'District7TBL
        '
        Me.District7TBL.TableName = "District7Table"
        '
        'District8TBL
        '
        Me.District8TBL.TableName = "District8Table"
        '
        'District9TBL
        '
        Me.District9TBL.TableName = "District9Table"
        '
        'District10TBL
        '
        Me.District10TBL.TableName = "District10Table"
        '
        'DataTable11
        '
        Me.DataTable11.TableName = "District11Table"
        '
        'District12TBL
        '
        Me.District12TBL.TableName = "District12Table"
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(501, 531)
        Me.Controls.Add(Me.LogText)
        Me.Controls.Add(Me.LogLabel)
        Me.Controls.Add(Me.ElectionFraudButton)
        Me.Controls.Add(Me.BeginButton)
        Me.Controls.Add(Me.YellowVotesBox)
        Me.Controls.Add(Me.PurpleVotesBox)
        Me.Controls.Add(Me.GreenVotesBox)
        Me.Controls.Add(Me.RedVotesBox)
        Me.Controls.Add(Me.BlueVotesBox)
        Me.Controls.Add(Me.YellowLabel)
        Me.Controls.Add(Me.PurpleLabel)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.BlueLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.VoteTotalsBox)
        Me.Controls.Add(Me.VoteTotalLabel)
        Me.Controls.Add(Me.District12)
        Me.Controls.Add(Me.District11)
        Me.Controls.Add(Me.District7)
        Me.Controls.Add(Me.District6)
        Me.Controls.Add(Me.District8)
        Me.Controls.Add(Me.District10)
        Me.Controls.Add(Me.District9)
        Me.Controls.Add(Me.District4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.District2)
        Me.Controls.Add(Me.District5)
        Me.Controls.Add(Me.District1)
        Me.Controls.Add(Me.District3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResultsForm"
        Me.Text = "Results Page"
        CType(Me.District2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTally, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoterResultsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedTallyTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualVoterTallyTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotersByDistrict, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District1TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District2TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District3TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District4TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District5TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District6TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District7TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District8TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District9TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District10TBL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.District12TBL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents District2 As PictureBox
    Friend WithEvents District5 As PictureBox
    Friend WithEvents District4 As PictureBox
    Friend WithEvents District9 As PictureBox
    Friend WithEvents District10 As PictureBox
    Friend WithEvents District8 As PictureBox
    Friend WithEvents District6 As PictureBox
    Friend WithEvents District7 As PictureBox
    Friend WithEvents District11 As PictureBox
    Friend WithEvents District3 As PictureBox
    Friend WithEvents District1 As PictureBox
    Friend WithEvents District12 As PictureBox
    Friend WithEvents VoteTotalLabel As Label
    Friend WithEvents VoteTotalsBox As TextBox
    Friend WithEvents RedLabel As Label
    Friend WithEvents BlueLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents PurpleLabel As Label
    Friend WithEvents YellowLabel As Label
    Friend WithEvents BlueVotesBox As TextBox
    Friend WithEvents RedVotesBox As TextBox
    Friend WithEvents GreenVotesBox As TextBox
    Friend WithEvents PurpleVotesBox As TextBox
    Friend WithEvents YellowVotesBox As TextBox
    Friend WithEvents BeginButton As Button
    Friend WithEvents ElectionFraudButton As Button
    Friend WithEvents DistrictTally As ToolTip
    Friend WithEvents ResultsTally As DataSet
    Friend WithEvents VoterResultsTable As DataTable
    Friend WithEvents LogLabel As Label
    Friend WithEvents LogText As RichTextBox
    Friend WithEvents District910Timer As Timer
    Friend WithEvents District1611Timer As Timer
    Friend WithEvents District1272Timer As Timer
    Friend WithEvents District3Timer As Timer
    Friend WithEvents District8Timer As Timer
    Friend WithEvents District5Timer As Timer
    Friend WithEvents District4Timer As Timer
    Friend WithEvents ExpectedTallyTable As DataTable
    Friend WithEvents ActualVoterTallyTable As DataTable
    Friend WithEvents DistrictVoter1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter6 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter7 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter8 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter9 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter10 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter11 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DistrictVoter12 As System.ComponentModel.BackgroundWorker
    Friend WithEvents VotersByDistrict As DataSet
    Friend WithEvents District1TBL As DataTable
    Friend WithEvents District2TBL As DataTable
    Friend WithEvents District3TBL As DataTable
    Friend WithEvents District4TBL As DataTable
    Friend WithEvents District5TBL As DataTable
    Friend WithEvents District6TBL As DataTable
    Friend WithEvents District7TBL As DataTable
    Friend WithEvents District8TBL As DataTable
    Friend WithEvents District9TBL As DataTable
    Friend WithEvents District10TBL As DataTable
    Friend WithEvents DataTable11 As DataTable
    Friend WithEvents District12TBL As DataTable
End Class
