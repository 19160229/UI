﻿Imports System.Math

Public Class clsPolygon
    Private points As List(Of PointF)
    Private boxHalfWidth As Integer = 2, boxHalfHeight As Integer = 2
    Private ActiveIDs As List(Of Integer)  '当前点下标的集合
    Event ActiveVertexChanged()

    Public Sub New(ByVal points As List(Of PointF))
        Me.points = points
        ActiveIDs = New List(Of Integer)
    End Sub

    Sub Draw(ByVal g As Graphics)
        Dim CommonPen As Pen = New Pen(Color.Black)
        Dim ActivePen As Pen = New Pen(Color.Red)
        g.DrawPolygon(CommonPen, points.ToArray)
        For i = 0 To points.Count - 1
            If ActiveIDs.Contains(i) Then
                g.DrawRectangle(ActivePen, points(i).X - boxHalfWidth, points(i).Y - boxHalfHeight, 2 * boxHalfWidth, 2 * boxHalfHeight)
            Else
                g.DrawRectangle(CommonPen, points(i).X - boxHalfWidth, points(i).Y - boxHalfHeight, 2 * boxHalfWidth, 2 * boxHalfHeight)
            End If
        Next
    End Sub

    Sub SelectVertex(ByVal p As PointF)
        Dim minv As Single = Abs(points(0).X - p.X) + Abs(points(0).Y - p.Y)
        Dim minID As Integer = 0  '最近的点的下标
        For i = 1 To points.Count - 1
            Dim v As Single = Abs(points(i).X - p.X) + Abs(points(i).Y - p.Y) '棋盘距离
            If v < minv Then
                minv = v : minID = i
            End If
        Next
        If minv < 10 Then
            If ActiveIDs.Contains(minID) Then
                ActiveIDs.Remove(minID)
            Else
                ActiveIDs.Add(minID)
            End If
            RaiseEvent ActiveVertexChanged()
        End If
    End Sub

    Public Sub VertexMove(ByVal offset As PointF)
        For i = 0 To ActiveIDs.Count - 1
            Dim ActiveID As Integer = ActiveIDs(i)
            Dim newLoc As PointF = New PointF(points(ActiveID).X + offset.X, points(ActiveID).Y + offset.Y)
            points.Insert(ActiveID + 1, newLoc)
            points.RemoveAt(ActiveID)
        Next
        If ActiveIDs.Count > 0 Then RaiseEvent ActiveVertexChanged()
    End Sub

    Public Sub VertexRemove()
        ActiveIDs.Sort()
        Dim n As Integer = ActiveIDs.Count
        For i = n - 1 To 0 Step -1
            Dim ActiveID As Integer = ActiveIDs(i)
            points.RemoveAt(ActiveID)
        Next
        ActiveIDs.Clear()
        If n > 0 Then RaiseEvent ActiveVertexChanged()
    End Sub

End Class
