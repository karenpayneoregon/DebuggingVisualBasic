<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GetPersonButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GetPersonButton
        '
        Me.GetPersonButton.Location = New System.Drawing.Point(66, 16)
        Me.GetPersonButton.Name = "GetPersonButton"
        Me.GetPersonButton.Size = New System.Drawing.Size(146, 23)
        Me.GetPersonButton.TabIndex = 0
        Me.GetPersonButton.Text = "Get Person"
        Me.GetPersonButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 55)
        Me.Controls.Add(Me.GetPersonButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppDomain.AssemblyResolve"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GetPersonButton As Button
End Class
