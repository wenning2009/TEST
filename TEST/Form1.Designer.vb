﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BbButton検索1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BbButton汎用1 As BB.BBButton汎用
    Friend WithEvents BbButton検索1 As BB.BBButton検索

End Class
