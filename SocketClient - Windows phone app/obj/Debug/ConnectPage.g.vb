﻿

#ExternalChecksum("F:\Windows Phone Development\Pratice Projects\SocketClient\ConnectPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "F0F6CB704B07BA759CCB6E13995FCB40")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.SocketClient

    Partial Class ConnectPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            If(connectionId = 1) Then
                #ExternalSource("..\..\ConnectPage.xaml",24)
                AddHandler CType(target,Global.Windows.UI.Xaml.Controls.Primitives.ButtonBase).Click, AddressOf Me.ConnectButton_Click
                #End ExternalSource
            End If
            Me._contentLoaded = true
        End Sub
    End Class

End Namespace


