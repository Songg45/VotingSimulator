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
        Me.VoterBuildButton = New System.Windows.Forms.Button()
        Me.ResultsButton = New System.Windows.Forms.Button()
        Me.VoterGridView = New System.Windows.Forms.DataGridView()
        CType(Me.VoterGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(760, 404)
        Me.Controls.Add(Me.VoterGridView)
        Me.Controls.Add(Me.ResultsButton)
        Me.Controls.Add(Me.VoterBuildButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        CType(Me.VoterGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents VoterBuildButton As Button
    Friend WithEvents ResultsButton As Button
    Friend WithEvents VoterGridView As DataGridView
End Class
