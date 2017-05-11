<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BbButton検索1 = New BB.BBButton検索()
        Me.BbButton検索2 = New BB.BBButton検索()
        Me.BbButton汎用2 = New BB.BBButton汎用()
        Me.SuspendLayout()
        '
        'BbButton検索1
        '
        Me.BbButton検索1.BBメッセージ表示名 = Nothing
        Me.BbButton検索1.Location = New System.Drawing.Point(117, 80)
        Me.BbButton検索1.Name = "BbButton検索1"
        Me.BbButton検索1.Size = New System.Drawing.Size(111, 53)
        Me.BbButton検索1.TabIndex = 0
        Me.BbButton検索1.Text = "検索"
        '
        'BbButton検索2
        '
        Me.BbButton検索2.BBメッセージ表示名 = Nothing
        Me.BbButton検索2.Location = New System.Drawing.Point(97, 148)
        Me.BbButton検索2.Name = "BbButton検索2"
        Me.BbButton検索2.Size = New System.Drawing.Size(106, 21)
        Me.BbButton検索2.TabIndex = 1
        Me.BbButton検索2.Text = "検索"
        '
        'BbButton汎用2
        '
        Me.BbButton汎用2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BbButton汎用2.BBメッセージ表示名 = Nothing
        Me.BbButton汎用2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BbButton汎用2.Location = New System.Drawing.Point(97, 210)
        Me.BbButton汎用2.Name = "BbButton汎用2"
        Me.BbButton汎用2.Size = New System.Drawing.Size(106, 14)
        Me.BbButton汎用2.TabIndex = 2
        Me.BbButton汎用2.Text = "BbButton汎用2"
        Me.BbButton汎用2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BbButton汎用2)
        Me.Controls.Add(Me.BbButton検索2)
        Me.Controls.Add(Me.BbButton検索1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbButton汎用1 As BB.BBButton汎用
    Friend WithEvents BbButton検索1 As BB.BBButton検索
    Friend WithEvents BbButton検索2 As BB.BBButton検索
    Friend WithEvents BbButton汎用2 As BB.BBButton汎用

End Class
