Imports System

Module Program
    Sub Main(args As String())
        If args.Length < 1 Then
            System.Console.WriteLine("scExtractQR - scConverter VB sample application")
            System.Console.WriteLine("Usage: scExtractQR inputfile")
        ElseIf args.Length > 0 Then
            Dim filehandle As Integer
            Dim qrCount As Integer
            Dim myconverter As New scConverterLib.Converter
            myconverter.OpenFileEx(args(0), filehandle)
            myconverter.DetectQREx(filehandle, -1, qrCount)
            If (qrCount > 0) Then
                For i = 0 To qrCount - 1
                    Dim Text As String
                    Text = ""
                    myconverter.GetQRTextEx(filehandle, i, Text)
                    Console.WriteLine(Text)
                Next
            End If
            myconverter.CloseFileEx(filehandle)
        End If
    End Sub
End Module
