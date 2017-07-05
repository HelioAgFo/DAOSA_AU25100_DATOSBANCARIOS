'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Update1 = New Interop.SAF.SAFUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cBanco = New Interop.SAF.SAFCombo()
        Me.cMetodoPago = New Interop.SAF.SAFCombo()
        Me.cDigitosCuenta = New Interop.SAF.SAFMaskedText()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cMetodoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cDigitosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Enabled = True
        Me.Update1.Location = New System.Drawing.Point(243, 123)
        Me.Update1.Margin = New System.Windows.Forms.Padding(4)
        Me.Update1.Name = "Update1"
        Me.Update1.OcxState = CType(resources.GetObject("Update1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Update1.Size = New System.Drawing.Size(33, 33)
        Me.Update1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cDigitosCuenta)
        Me.GroupBox1.Controls.Add(Me.cMetodoPago)
        Me.GroupBox1.Controls.Add(Me.cBanco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 187)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Bancarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Últimos 4 Dígitos Cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Metodo Pago:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        '
        'cBanco
        '
        Me.cBanco.Location = New System.Drawing.Point(197, 35)
        Me.cBanco.Name = "cBanco"
        Me.cBanco.OcxState = CType(resources.GetObject("cBanco.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cBanco.Size = New System.Drawing.Size(260, 24)
        Me.cBanco.TabIndex = 6
        '
        'cMetodoPago
        '
        Me.cMetodoPago.Location = New System.Drawing.Point(197, 55)
        Me.cMetodoPago.Name = "cMetodoPago"
        Me.cMetodoPago.OcxState = CType(resources.GetObject("cMetodoPago.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cMetodoPago.Size = New System.Drawing.Size(260, 24)
        Me.cMetodoPago.TabIndex = 7
        '
        'cDigitosCuenta
        '
        Me.cDigitosCuenta.Location = New System.Drawing.Point(197, 80)
        Me.cDigitosCuenta.Name = "cDigitosCuenta"
        Me.cDigitosCuenta.OcxState = CType(resources.GetObject("cDigitosCuenta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cDigitosCuenta.Size = New System.Drawing.Size(201, 24)
        Me.cDigitosCuenta.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 210)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Datos Bancarios (AU.251.10)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cMetodoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cDigitosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Update1 As Interop.SAF.SAFUpdate
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cBanco As Interop.SAF.SAFCombo
    Friend WithEvents cMetodoPago As Interop.SAF.SAFCombo
    Friend WithEvents cDigitosCuenta As Interop.SAF.SAFMaskedText

End Class
