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
Option Explicit On
Option Strict Off
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
	End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ' Load all the forms needed for this application
        'Call LoadForm(fSL01001)

        ' Initialize the application as a Microsoft Dynamics SL Application
        Call ApplInit()


        ' Call Set Address for the tables that will have fields displayed on the scree,
        ' or that you would like customization manager to be able to use
        'Call SetAddr(LEVEL0, "bxSLSample", bxSLSample, nxSLSample)

        ' Define the cursors that are used by the application

        ' This is an example for a table in the System Database
        'Call SqlCursor(c1, LEVEL0 + SqlSystemDb)

        ' This is an example for a table in an Application Database
        'Call SqlCursor(c1, LEVEL0 )


        ' Call the screen init function
        Call ScreenInit()




    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

End Class
