<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ResultsButton = New System.Windows.Forms.Button()
        Me.VoterGridView = New System.Windows.Forms.DataGridView()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.SubmitNameButton = New System.Windows.Forms.Button()
        Me.SQLServerData = New System.Data.DataSet()
        Me.MasterVoterTable = New System.Data.DataTable()
        Me.VoterTally = New System.Data.DataTable()
        Me.VoterBuild = New System.ComponentModel.BackgroundWorker()
        CType(Me.VoterGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLServerData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterVoterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VoterTally, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(640, 346)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(108, 46)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ResultsButton
        '
        Me.ResultsButton.Location = New System.Drawing.Point(12, 346)
        Me.ResultsButton.Name = "ResultsButton"
        Me.ResultsButton.Size = New System.Drawing.Size(108, 46)
        Me.ResultsButton.TabIndex = 3
        Me.ResultsButton.Text = "Open Results Form"
        Me.ResultsButton.UseVisualStyleBackColor = True
        '
        'VoterGridView
        '
        Me.VoterGridView.AllowUserToAddRows = False
        Me.VoterGridView.AllowUserToDeleteRows = False
        Me.VoterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VoterGridView.Location = New System.Drawing.Point(12, 13)
        Me.VoterGridView.Name = "VoterGridView"
        Me.VoterGridView.ReadOnly = True
        Me.VoterGridView.Size = New System.Drawing.Size(736, 327)
        Me.VoterGridView.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(13, 399)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(63, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Your Name:"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(82, 396)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(258, 20)
        Me.NameText.TabIndex = 7
        '
        'SubmitNameButton
        '
        Me.SubmitNameButton.Location = New System.Drawing.Point(346, 393)
        Me.SubmitNameButton.Name = "SubmitNameButton"
        Me.SubmitNameButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitNameButton.TabIndex = 8
        Me.SubmitNameButton.Text = "Submit"
        Me.SubmitNameButton.UseVisualStyleBackColor = True
        '
        'SQLServerData
        '
        Me.SQLServerData.DataSetName = "SQLServerData"
        Me.SQLServerData.Tables.AddRange(New System.Data.DataTable() {Me.MasterVoterTable, Me.VoterTally})
        '
        'MasterVoterTable
        '
        Me.MasterVoterTable.TableName = "VoterTable"
        '
        'VoterTally
        '
        Me.VoterTally.TableName = "VoterNumbers"
        '
        'VoterBuild
        '
        Me.VoterBuild.WorkerReportsProgress = True
        Me.VoterBuild.WorkerSupportsCancellation = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(760, 420)
        Me.Controls.Add(Me.SubmitNameButton)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.VoterGridView)
        Me.Controls.Add(Me.ResultsButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        CType(Me.VoterGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLServerData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterVoterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VoterTally, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents ResultsButton As Button
    Friend WithEvents VoterGridView As DataGridView
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents SubmitNameButton As Button
    Friend WithEvents SQLServerData As DataSet
    Friend WithEvents MasterVoterTable As DataTable
    Friend WithEvents VoterTally As DataTable
    Friend WithEvents VoterBuild As System.ComponentModel.BackgroundWorker
End Class
