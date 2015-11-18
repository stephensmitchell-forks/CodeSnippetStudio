﻿Imports System.ComponentModel

Public Class SnippetFile

    <Category("Properties")>
    <DisplayName("Author")>
    <Description("Author of code snippet. This is a required value.")>
    Public Property Author As String

    <Category("Properties")>
    <DisplayName("Title")>
    <Description("Title of code snippet. This is a required value.")>
    Public Property Title As String

    <Category("Properties")>
    <DisplayName("Description")>
    <Description("Description of code snippet. This is a required value.")>
    Public Property Description As String

    <Category("Properties")>
    <DisplayName("HelpUrl")>
    <Description("URL where users can find help. This is an optional value.")>
    Public Property HelpUrl As String

    <Category("Properties")>
    <DisplayName("Shortcut")>
    <Description("Keyboard shortcut for IntelliSense. This is an optional value.")>
    Public Property Shortcut As String

    <Category("Properties")>
    <DisplayName("Keywords")>
    <Description("Comma separated list of keywords that help identifying a code snippet.")>
    Public Property Keywords As String

    <Category("Properties")>
    <DisplayName("Kind")>
    <Description("Determine the kind of code snippet.")>
    Public Property Kind As CodeSnippetTypes
End Class

Public Enum CodeSnippetTypes
    MethodBody
    MethodDeclaration
    TypeDeclaration
    File
    Any
End Enum