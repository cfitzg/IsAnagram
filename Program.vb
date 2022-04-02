Imports System

Module Program
    Sub Main()
        Console.WriteLine("IsAnagram?")
        Dim answer As Boolean = IsAnagram("colin", "niloc")
        Console.WriteLine(IIf(answer, "YES!!! :)", "NOOooooo... :("))
        Console.WriteLine("Press any key to exit...")
        Console.Read()
    End Sub

    ' duhhhsnt have to match in sequence, just existance
    Function IsAnagram(ByRef wordA As String, ByRef wordB As String) As Boolean
        If wordA.Length <> wordB.Length Then
            Return False
        End If
        For Each c As Char In wordA.ToCharArray()
            If wordB.Contains(c) Then
                wordB = wordB.Replace(c, String.Empty)
            End If
        Next
        If wordB.Length = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
