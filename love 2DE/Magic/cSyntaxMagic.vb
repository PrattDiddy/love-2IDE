Public Class cSyntaxMagic

#Region "Key Words"
    Public Sub set_words()
        'maybe split by word length instead of category
        '1
        key_words_one.Add("+")
        key_words_one.Add("-")
        key_words_one.Add("*")
        key_words_one.Add("/")
        key_words_one.Add("%")
        key_words_one.Add("^")
        key_words_one.Add("#")
        key_words_one.Add("<")
        key_words_one.Add(">")
        key_words_one.Add("=")
        key_words_one.Add("(")
        key_words_one.Add(")")
        key_words_one.Add("{")
        key_words_one.Add("}")
        key_words_one.Add("[")
        key_words_one.Add("]")
        key_words_one.Add(";")
        key_words_one.Add(":")
        key_words_one.Add(",")
        key_words_one.Add(".")
        '2,3
        key_words_two.Add("and")
        key_words_two.Add("do")
        key_words_two.Add("end")
        key_words_two.Add("for")
        key_words_two.Add("if")
        key_words_two.Add("in")
        key_words_two.Add("nil")
        key_words_two.Add("not")
        key_words_two.Add("or")
        key_words_two.Add("==")
        key_words_two.Add("~=")
        key_words_two.Add("<=")
        key_words_two.Add(">=")
        key_words_two.Add("..")
        key_words_two.Add("...")
        '>4
        key_words_three.Add("break")
        key_words_three.Add("else")
        key_words_three.Add("elseif")
        key_words_three.Add("false")
        key_words_three.Add("function")
        key_words_three.Add("local")
        key_words_three.Add("repeat")
        key_words_three.Add("return")
        key_words_three.Add("then")
        key_words_three.Add("true")
        key_words_three.Add("until")
        key_words_three.Add("while")
        '''''''''''''''''''''''''''''

        'key_words.Add("and")
        'key_words.Add("break")
        'key_words.Add("do")
        'key_words.Add("else")
        'key_words.Add("elseif")
        'key_words.Add("end")
        'key_words.Add("false")
        'key_words.Add("for")
        'key_words.Add("function")
        'key_words.Add("if")
        'key_words.Add("in")
        'key_words.Add("local")
        'key_words.Add("nil")
        'key_words.Add("not")
        'key_words.Add("or")
        'key_words.Add("repeat")
        'key_words.Add("return")
        'key_words.Add("then")
        'key_words.Add("true")
        'key_words.Add("until")
        'key_words.Add("while")

        'key_symbols_math.Add("+")
        'key_symbols_math.Add("-")
        'key_symbols_math.Add("*")
        'key_symbols_math.Add("/")
        'key_symbols_math.Add("%")
        'key_symbols_math.Add("^")
        'key_symbols_math.Add("#")
        'key_symbols_math.Add("==")
        'key_symbols_math.Add("~=")
        'key_symbols_math.Add("<=")
        'key_symbols_math.Add(">=")
        'key_symbols_math.Add("<")
        'key_symbols_math.Add(">")
        'key_symbols_math.Add("=")

        ''THESE PROBABLY WON'T WORK, SINCE WE CHECK BETWEEN SPACES (ALSO RETURNS)
        'key_symbols.Add("(")
        'key_symbols.Add(")")
        'key_symbols.Add("{")
        'key_symbols.Add("}")
        'key_symbols.Add("[")
        'key_symbols.Add("]")
        'key_symbols.Add(";")
        'key_symbols.Add(":")
        'key_symbols.Add(",")
        'key_symbols.Add(".")
        'key_symbols.Add("..")
        'key_symbols.Add("...")
    End Sub
#End Region

#Region "Whilst Typing"
    '' THIS ONLY WORKS ON LAST WORD OF TEXT!
    '//MDD 4/24/2013 - highlights the word now.
    Public Sub highlight_last_word(ByRef rtb As RichTextBox)
        Dim txtCode As String = rtb.Text.Trim
        Dim strArray As String() = txtCode.Replace(Chr(10), " ").Split(" ")
        Dim last_typed_word As String = strArray(strArray.Length - 1)

        For Each oneWord As String In key_words
            If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
                'Highlight
                rtb.Select(txtCode.LastIndexOf(last_typed_word), last_typed_word.Length)
                rtb.SelectionColor = color_code_syntax_current
            End If
        Next

        rtb.SelectionStart = rtb.TextLength
        rtb.SelectionLength = 0
        rtb.SelectionColor = color_code_text_current
    End Sub

    Public Sub highlight_last_word2(ByRef rtb As RichTextBox)
        Dim p As Point = rtb.GetPositionFromCharIndex(rtb.SelectionStart - 2) 'Needs to get in front of last char
        Dim i As Integer = rtb.GetCharIndexFromPosition(p)
        Dim iCharPos As Integer = i + 1
        Dim first_part As String = rtb.Text.Substring(0, iCharPos)
        Dim iSpacePos As Integer = InStrRev(first_part.Replace(Chr(10), " "), " ")
        Dim iWordLength As Integer = iCharPos - iSpacePos
        Dim last_typed_word As String = rtb.Text.Substring(iSpacePos, iWordLength)
        Dim found As Boolean = False

        rtb.Select(iSpacePos, iWordLength)
        rtb.SelectionColor = color_code_comment_current

        rtb.Select(iCharPos + 1, 0) 'plus 1 for space
        rtb.SelectionColor = color_code_text_current
    End Sub

    'Public Sub highlight_comment()
    '    'detect -- then change font color until a return or up or down arrow key
    'End Sub

    Public Sub highlight_last_word3(ByRef rtb As RichTextBox)
        Dim p As Point = rtb.GetPositionFromCharIndex(rtb.SelectionStart - 2) 'Needs to get in front of last char
        Dim i As Integer = rtb.GetCharIndexFromPosition(p)
        Dim iCharPos As Integer = i + 1
        Dim sFirst_part As String = rtb.Text.Substring(0, iCharPos)
        Dim iSpacePos As Integer = InStrRev(sFirst_part.Replace(Chr(10), " "), " ")
        Dim iWordLength As Integer = iCharPos - iSpacePos
        'Dim last_typed_word As String = rtb.Text.Substring(iSpacePos, iWordLength)
        Dim last_typed_word As String = rtb.Text.Substring(iSpacePos, iWordLength).Trim

        Select Case last_typed_word.Length
            Case 1
                If IsNumeric(last_typed_word) Then 'colored numbers would be cool, right?
                    rtb.Select(iSpacePos, iWordLength)
                    'rtb.SelectionColor = color_code_comment_current

                    'SHOULD SET NUMBERS TO THE INVERSE OF THE CODE BACKGROUND
                    rtb.SelectionColor = Color.FromArgb((255 - rtb.BackColor.R), (255 - rtb.BackColor.G), (255 - rtb.BackColor.B))
                Else
                    For Each oneWord As String In key_words_one
                        If Trim(oneWord) = last_typed_word Then
                            rtb.Select(iSpacePos, iWordLength)
                            rtb.SelectionColor = color_code_syntax_current
                        End If
                    Next
                End If
            Case 2, 3
                For Each oneWord As String In key_words_two
                    If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
                        rtb.Select(iSpacePos, iWordLength)
                        rtb.SelectionColor = color_code_syntax_current
                    End If
                Next
            Case Else
                For Each oneWord As String In key_words_three
                    If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
                        rtb.Select(iSpacePos, iWordLength)
                        rtb.SelectionColor = color_code_syntax_current
                    End If
                Next
        End Select

        rtb.Select(iCharPos + 1, 0) 'plus 1 to account for space
        rtb.SelectionColor = color_code_text_current
    End Sub

    'Public Sub highlight_last_word2(ByRef rtb As RichTextBox)
    '    Dim p As Point = rtb.GetPositionFromCharIndex(rtb.SelectionStart - 2) 'Needs to get in front of last char
    '    Dim i As Integer = rtb.GetCharIndexFromPosition(p)
    '    Dim iCharPos As Integer = i + 1
    '    Dim first_part As String = rtb.Text.Substring(0, iCharPos)
    '    Dim iSpacePos As Integer = InStrRev(first_part.Replace(Chr(10), " "), " ")
    '    Dim iWordLength As Integer = iCharPos - iSpacePos
    '    Dim last_typed_word As String = rtb.Text.Substring(iSpacePos, iWordLength)
    '    Dim found As Boolean = False

    '    If IsNumeric(last_typed_word) Then 'colored numbers would be cool, right?
    '        rtb.Select(iSpacePos, iWordLength)
    '        rtb.SelectionColor = color_code_comment_current
    '        found = True
    '    End If

    '    For Each oneWord As String In key_words
    '        If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
    '            rtb.Select(iSpacePos, iWordLength)
    '            rtb.SelectionColor = color_code_syntax_current
    '            found = True
    '        End If
    '    Next

    '    If Not found Then
    '        For Each oneWord As String In key_symbols_math
    '            If Trim(oneWord) = last_typed_word Then
    '                rtb.Select(iSpacePos, iWordLength)
    '                rtb.SelectionColor = color_code_syntax_current
    '                found = True
    '            End If
    '        Next
    '    End If

    '    If Not found Then
    '        For Each oneWord As String In key_symbols
    '            If Trim(oneWord) = last_typed_word Then
    '                rtb.Select(iSpacePos, iWordLength)
    '                rtb.SelectionColor = color_code_syntax_current
    '                found = True
    '            End If
    '        Next
    '    End If

    '    If found Then
    '        rtb.Select(iCharPos + 1, 0) 'plus 1 for space
    '        rtb.SelectionColor = color_code_text_current
    '    End If
    'End Sub

    'Public Sub highlight_last_word3(ByRef rtb As RichTextBox)
    '    'chr(10) = return
    '    '''
    '    Dim p As Point = rtb.GetPositionFromCharIndex(rtb.SelectionStart - 2)
    '    'Dim tempChar As Char = rtb.GetCharFromPosition(p)
    '    ' Determine whether the character is an empty space.
    '    'If tempChar <> " " Then
    '    ' Display the character in a message box.
    '    'MessageBox.Show(("The character at the specified position is '" + tempChar + "'."))
    '    'End If
    '    '''

    '    Dim iChar As Integer = rtb.GetCharIndexFromPosition(p)
    '    Dim iCharPos As Integer = iChar + 1

    '    'cut string to here
    '    Dim first_part As String = rtb.Text.Substring(0, iCharPos)

    '    'instrrev(.net equiv)
    '    Dim iSpace As Integer = InStrRev(first_part.Replace(Chr(10), " "), " ")

    '    Dim iLength As Integer = iCharPos - iSpace

    '    'copy from last space to end
    '    'Dim str As String = first_part.Substring(iSpace - 1, iChar - 1)
    '    Dim str As String = rtb.Text.Substring(iSpace, iLength)

    '    'length of word
    '    'new p selection start - 2(?) - length
    '    'get getcharindexfromposition
    '    'select 

    '    'MsgBox("The word at the specified position is """ + str + """.")

    '    rtb.Select(iSpace, iLength)
    '    rtb.SelectionColor = color_code_syntax_current

    '    'rtb.SelectionStart = iChar + 2 'original subtraction, also it would be like iCharPos + 1 'rtb.TextLength
    '    'rtb.SelectionLength = 0
    '    rtb.Select(iChar + 2, 0) 'original subtraction, also it would be like iCharPos + 1
    '    rtb.SelectionColor = color_code_text_current

    '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '    'Dim txtCode As String = rtb.Text.Trim
    '    'Dim strArray As String() = txtCode.Replace(Chr(10), " ").Split(" ")
    '    ''Dim last_typed_word As String = strArray(strArray.Length - 1)
    '    'Dim last_typed_word As String = strArray(strArray.Length - 1)
    '    'Dim found As Boolean = False

    '    'If last_typed_word.Length = 1 Then
    '    '    'Use key_symbols_math
    '    'End If

    '    ''key_symbols

    '    'For Each oneWord As String In key_words
    '    '    If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
    '    '        'Highlight
    '    '        rtb.Select(txtCode.LastIndexOf(last_typed_word), last_typed_word.Length)
    '    '        rtb.SelectionColor = color_code_syntax_current
    '    '        found = True
    '    '    End If
    '    'Next

    '    'If Not found Then
    '    '    For Each oneWord As String In key_symbols_math
    '    '        If Trim(oneWord) = last_typed_word Then
    '    '            'Highlight
    '    '            rtb.Select(txtCode.LastIndexOf(last_typed_word), last_typed_word.Length)
    '    '            rtb.SelectionColor = color_code_syntax_current
    '    '            found = True
    '    '        End If
    '    '    Next
    '    'End If

    '    'If Not found Then
    '    '    If IsNumeric(last_typed_word) Then 'colored numbers would be cool, right?
    '    '        rtb.Select(txtCode.LastIndexOf(last_typed_word), last_typed_word.Length)
    '    '        rtb.SelectionColor = color_code_comment_current
    '    '        found = True
    '    '    End If
    '    'End If

    '    'rtb.SelectionStart = rtb.TextLength
    '    'rtb.SelectionLength = 0
    '    'rtb.SelectionColor = color_code_text_current
    'End Sub
#End Region

#Region "On Load"
    Public Sub highlight_text(ByRef rtb As RichTextBox)
        Dim iCharPos As Integer = rtb.Text.Length

        Do Until iCharPos = 0
            If iCharPos > rtb.Text.Length Then iCharPos = rtb.Text.Length 'ONE STUPID SOLUTION TO AVOID INFINITE LOOP AT SPACE

            Dim sFirst_part As String = rtb.Text.Substring(0, iCharPos)
            Dim iSpacePos As Integer = InStrRev(sFirst_part.Replace(Chr(10), " "), " ")
            Dim iWordLength As Integer = iCharPos - iSpacePos
            'Dim last_typed_word As String = rtb.Text.Substring(iSpacePos, iWordLength)
            Dim last_typed_word As String = rtb.Text.Substring(iSpacePos, iWordLength).Trim

            Select Case last_typed_word.Length
                Case 0
                    iWordLength += 1 'ONE STUPID SOLUTION TO AVOID INFINITE LOOP AT SPACE
                Case 1
                    If IsNumeric(last_typed_word) Then 'colored numbers would be cool, right?
                        rtb.Select(iSpacePos, iWordLength)
                        'rtb.SelectionColor = color_code_comment_current

                        'Dim r As Integer = 255 - rtb.BackColor.R
                        'Dim g As Integer = 255 - rtb.BackColor.G
                        'Dim b As Integer = 255 - rtb.BackColor.B
                        'rtb.SelectionColor = Color.FromArgb(r, g, b)

                        'SHOULD SET NUMBERS TO THE INVERSE OF THE CODE BACKGROUND
                        rtb.SelectionColor = Color.FromArgb((255 - rtb.BackColor.R), (255 - rtb.BackColor.G), (255 - rtb.BackColor.B))
                    Else
                        For Each oneWord As String In key_words_one
                            If Trim(oneWord) = last_typed_word Then
                                rtb.Select(iSpacePos, iWordLength)
                                rtb.SelectionColor = color_code_syntax_current
                            End If
                        Next
                    End If
                Case 2, 3
                    For Each oneWord As String In key_words_two
                        If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
                            rtb.Select(iSpacePos, iWordLength)
                            rtb.SelectionColor = color_code_syntax_current
                        End If
                    Next
                Case Else
                    For Each oneWord As String In key_words_three
                        If Trim(oneWord).ToUpper = last_typed_word.ToUpper Then
                            rtb.Select(iSpacePos, iWordLength)
                            rtb.SelectionColor = color_code_syntax_current
                        End If
                    Next
            End Select

            rtb.Select(iCharPos + 1, 0) 'plus 1 to account for space
            rtb.SelectionColor = color_code_text_current

            'Decrement
            iCharPos = iCharPos - iWordLength
        Loop
    End Sub
#End Region

#Region "Theme Selection"

#End Region

End Class
