﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_Tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Line = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Rectangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Polygon = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_PointSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_Pan = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_Rotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_Scale = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstElem = New System.Windows.Forms.ListBox()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(0, 27)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(292, 247)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool, Me.m_Tranform})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_Tool
        '
        Me.m_Tool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool_Line, Me.m_Tool_Rectangle, Me.m_Tool_Polygon, Me.m_Tool_PointSelect})
        Me.m_Tool.Name = "m_Tool"
        Me.m_Tool.Size = New System.Drawing.Size(41, 20)
        Me.m_Tool.Text = "工具"
        '
        'm_Tool_Line
        '
        Me.m_Tool_Line.Name = "m_Tool_Line"
        Me.m_Tool_Line.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_Line.Text = "线段"
        '
        'm_Tool_Rectangle
        '
        Me.m_Tool_Rectangle.Name = "m_Tool_Rectangle"
        Me.m_Tool_Rectangle.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_Rectangle.Text = "矩形"
        '
        'm_Tool_Polygon
        '
        Me.m_Tool_Polygon.Name = "m_Tool_Polygon"
        Me.m_Tool_Polygon.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_Polygon.Text = "多边形"
        '
        'm_Tool_PointSelect
        '
        Me.m_Tool_PointSelect.Name = "m_Tool_PointSelect"
        Me.m_Tool_PointSelect.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_PointSelect.Text = "选择"
        '
        'm_Tranform
        '
        Me.m_Tranform.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tranform_Pan, Me.m_Tranform_Rotate, Me.m_Tranform_Scale})
        Me.m_Tranform.Name = "m_Tranform"
        Me.m_Tranform.Size = New System.Drawing.Size(41, 20)
        Me.m_Tranform.Text = "变换"
        '
        'm_Tranform_Pan
        '
        Me.m_Tranform_Pan.Name = "m_Tranform_Pan"
        Me.m_Tranform_Pan.Size = New System.Drawing.Size(152, 22)
        Me.m_Tranform_Pan.Text = "平移"
        '
        'm_Tranform_Rotate
        '
        Me.m_Tranform_Rotate.Name = "m_Tranform_Rotate"
        Me.m_Tranform_Rotate.Size = New System.Drawing.Size(152, 22)
        Me.m_Tranform_Rotate.Text = "旋转"
        '
        'm_Tranform_Scale
        '
        Me.m_Tranform_Scale.Name = "m_Tranform_Scale"
        Me.m_Tranform_Scale.Size = New System.Drawing.Size(152, 22)
        Me.m_Tranform_Scale.Text = "缩放"
        '
        'lstElem
        '
        Me.lstElem.FormattingEnabled = True
        Me.lstElem.ItemHeight = 12
        Me.lstElem.Location = New System.Drawing.Point(298, 27)
        Me.lstElem.Name = "lstElem"
        Me.lstElem.Size = New System.Drawing.Size(284, 244)
        Me.lstElem.TabIndex = 4
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 348)
        Me.Controls.Add(Me.lstElem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picCanvas)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_Tool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_Line As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_Rectangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstElem As System.Windows.Forms.ListBox
    Friend WithEvents m_Tool_Polygon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_PointSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_Pan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_Rotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_Scale As System.Windows.Forms.ToolStripMenuItem

End Class
