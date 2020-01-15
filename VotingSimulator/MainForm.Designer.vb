<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.VoterBuildButton = New System.Windows.Forms.Button()
        Me.ResultsButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'VoterBuildButton
        '
        Me.VoterBuildButton.Location = New System.Drawing.Point(12, 346)
        Me.VoterBuildButton.Name = "VoterBuildButton"
        Me.VoterBuildButton.Size = New System.Drawing.Size(108, 46)
        Me.VoterBuildButton.TabIndex = 1
        Me.VoterBuildButton.Text = "Build Voter Database"
        Me.VoterBuildButton.UseVisualStyleBackColor = True
        '
        'ResultsButton
        '
        Me.ResultsButton.Location = New System.Drawing.Point(312, 346)
        Me.ResultsButton.Name = "ResultsButton"
        Me.ResultsButton.Size = New System.Drawing.Size(108, 46)
        Me.ResultsButton.TabIndex = 3
        Me.ResultsButton.Text = "Open Results Form"
        Me.ResultsButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameColumn, Me.AgeColumn, Me.LocationColumn, Me.PartyColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(736, 327)
        Me.DataGridView1.TabIndex = 4
        '
        'NameColumn
        '
        Me.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameColumn.HeaderText = "Name"
        Me.NameColumn.Name = "NameColumn"
        Me.NameColumn.ReadOnly = True
        '
        'AgeColumn
        '
        Me.AgeColumn.HeaderText = "Age"
        Me.AgeColumn.Name = "AgeColumn"
        Me.AgeColumn.ReadOnly = True
        '
        'LocationColumn
        '
        Me.LocationColumn.HeaderText = "Location"
        Me.LocationColumn.Name = "LocationColumn"
        Me.LocationColumn.ReadOnly = True
        '
        'PartyColumn
        '
        Me.PartyColumn.HeaderText = "Party"
        Me.PartyColumn.Name = "PartyColumn"
        Me.PartyColumn.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(760, 404)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ResultsButton)
        Me.Controls.Add(Me.VoterBuildButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents VoterBuildButton As Button
    Friend WithEvents ResultsButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartyColumn As DataGridViewTextBoxColumn
End Class
