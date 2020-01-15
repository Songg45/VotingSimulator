<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoterBuild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoterBuild))
        Me.ExcelData = New System.Data.DataSet()
        Me.ProcessButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.WriteButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.PartyLabel = New System.Windows.Forms.Label()
        Me.DistrictNumberLabel = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.AgeText = New System.Windows.Forms.TextBox()
        Me.PartyText = New System.Windows.Forms.TextBox()
        Me.DistrictText = New System.Windows.Forms.TextBox()
        Me.SeedLabel = New System.Windows.Forms.Label()
        Me.SeedBox = New System.Windows.Forms.TextBox()
        CType(Me.ExcelData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExcelData
        '
        Me.ExcelData.DataSetName = "NewDataSet"
        '
        'ProcessButton
        '
        Me.ProcessButton.Location = New System.Drawing.Point(13, 126)
        Me.ProcessButton.Name = "ProcessButton"
        Me.ProcessButton.Size = New System.Drawing.Size(110, 36)
        Me.ProcessButton.TabIndex = 0
        Me.ProcessButton.Text = "Process"
        Me.ProcessButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(157, 126)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(110, 36)
        Me.NextButton.TabIndex = 1
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(157, 188)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(110, 36)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'WriteButton
        '
        Me.WriteButton.Location = New System.Drawing.Point(13, 188)
        Me.WriteButton.Name = "WriteButton"
        Me.WriteButton.Size = New System.Drawing.Size(110, 36)
        Me.WriteButton.TabIndex = 3
        Me.WriteButton.Text = "Write"
        Me.WriteButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(13, 13)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(53, 16)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Name:"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(13, 46)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(40, 16)
        Me.AgeLabel.TabIndex = 5
        Me.AgeLabel.Text = "Age:"
        '
        'PartyLabel
        '
        Me.PartyLabel.AutoSize = True
        Me.PartyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartyLabel.Location = New System.Drawing.Point(13, 73)
        Me.PartyLabel.Name = "PartyLabel"
        Me.PartyLabel.Size = New System.Drawing.Size(48, 16)
        Me.PartyLabel.TabIndex = 6
        Me.PartyLabel.Text = "Party:"
        '
        'DistrictNumberLabel
        '
        Me.DistrictNumberLabel.AutoSize = True
        Me.DistrictNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistrictNumberLabel.Location = New System.Drawing.Point(13, 101)
        Me.DistrictNumberLabel.Name = "DistrictNumberLabel"
        Me.DistrictNumberLabel.Size = New System.Drawing.Size(80, 16)
        Me.DistrictNumberLabel.TabIndex = 7
        Me.DistrictNumberLabel.Text = "Disctrict #:"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(90, 9)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(100, 20)
        Me.NameText.TabIndex = 8
        '
        'AgeText
        '
        Me.AgeText.Location = New System.Drawing.Point(90, 42)
        Me.AgeText.Name = "AgeText"
        Me.AgeText.Size = New System.Drawing.Size(100, 20)
        Me.AgeText.TabIndex = 9
        '
        'PartyText
        '
        Me.PartyText.Location = New System.Drawing.Point(90, 71)
        Me.PartyText.Name = "PartyText"
        Me.PartyText.Size = New System.Drawing.Size(100, 20)
        Me.PartyText.TabIndex = 10
        '
        'DistrictText
        '
        Me.DistrictText.Location = New System.Drawing.Point(90, 97)
        Me.DistrictText.Name = "DistrictText"
        Me.DistrictText.Size = New System.Drawing.Size(100, 20)
        Me.DistrictText.TabIndex = 11
        '
        'SeedLabel
        '
        Me.SeedLabel.AutoSize = True
        Me.SeedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeedLabel.Location = New System.Drawing.Point(16, 238)
        Me.SeedLabel.Name = "SeedLabel"
        Me.SeedLabel.Size = New System.Drawing.Size(53, 16)
        Me.SeedLabel.TabIndex = 12
        Me.SeedLabel.Text = "SEED:"
        '
        'SeedBox
        '
        Me.SeedBox.Location = New System.Drawing.Point(67, 238)
        Me.SeedBox.Name = "SeedBox"
        Me.SeedBox.Size = New System.Drawing.Size(205, 20)
        Me.SeedBox.TabIndex = 13
        '
        'VoterBuild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 289)
        Me.Controls.Add(Me.SeedBox)
        Me.Controls.Add(Me.SeedLabel)
        Me.Controls.Add(Me.DistrictText)
        Me.Controls.Add(Me.PartyText)
        Me.Controls.Add(Me.AgeText)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.DistrictNumberLabel)
        Me.Controls.Add(Me.PartyLabel)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.WriteButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.ProcessButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VoterBuild"
        Me.Text = "Voter Build"
        CType(Me.ExcelData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExcelData As DataSet
    Friend WithEvents ProcessButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents WriteButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents PartyLabel As Label
    Friend WithEvents DistrictNumberLabel As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents AgeText As TextBox
    Friend WithEvents PartyText As TextBox
    Friend WithEvents DistrictText As TextBox
    Friend WithEvents SeedLabel As Label
    Friend WithEvents SeedBox As TextBox
End Class
