﻿' Developer Express Code Central Example:
' How to merge adjacent appointments together
' 
' This example illustrates how to combine two adjacent appointments into one
' appointment by handling the XtraScheduler.AppointmentDrop event. Please drag the
' first appointment over the second one and drop it. As a result, the first
' appointment disappears and the second appointment's duration is increased.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2056

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
