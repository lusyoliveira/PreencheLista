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
        Me.lstExemplo = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.lstMarcados = New System.Windows.Forms.ListBox
        Me.lstDesmarcados = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnEncaminhar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstExemplo
        '
        Me.lstExemplo.CheckBoxes = True
        Me.lstExemplo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstExemplo.FullRowSelect = True
        Me.lstExemplo.Location = New System.Drawing.Point(40, 23)
        Me.lstExemplo.Name = "lstExemplo"
        Me.lstExemplo.Size = New System.Drawing.Size(306, 260)
        Me.lstExemplo.TabIndex = 1
        Me.lstExemplo.UseCompatibleStateImageBehavior = False
        Me.lstExemplo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Permissão"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Usuário"
        Me.ColumnHeader2.Width = 200
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(40, 347)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(75, 23)
        Me.btnCarregar.TabIndex = 2
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(40, 289)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(109, 17)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "Selecionar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'lstMarcados
        '
        Me.lstMarcados.FormattingEnabled = True
        Me.lstMarcados.Location = New System.Drawing.Point(388, 26)
        Me.lstMarcados.Name = "lstMarcados"
        Me.lstMarcados.Size = New System.Drawing.Size(150, 186)
        Me.lstMarcados.TabIndex = 4
        '
        'lstDesmarcados
        '
        Me.lstDesmarcados.FormattingEnabled = True
        Me.lstDesmarcados.Location = New System.Drawing.Point(388, 250)
        Me.lstDesmarcados.Name = "lstDesmarcados"
        Me.lstDesmarcados.Size = New System.Drawing.Size(150, 186)
        Me.lstDesmarcados.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Marcados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Desmarcados"
        '
        'btnEncaminhar
        '
        Me.btnEncaminhar.Location = New System.Drawing.Point(271, 347)
        Me.btnEncaminhar.Name = "btnEncaminhar"
        Me.btnEncaminhar.Size = New System.Drawing.Size(75, 23)
        Me.btnEncaminhar.TabIndex = 8
        Me.btnEncaminhar.Text = "Encaminhar"
        Me.btnEncaminhar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 453)
        Me.Controls.Add(Me.btnEncaminhar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDesmarcados)
        Me.Controls.Add(Me.lstMarcados)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.lstExemplo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstExemplo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lstMarcados As System.Windows.Forms.ListBox
    Friend WithEvents lstDesmarcados As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEncaminhar As System.Windows.Forms.Button

End Class
