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
    Dim sCustId As String
    Dim sShipToId As String

	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
	End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load


        Call ApplInit()
        Call Init_xSoAddress(LEVEL0, True)

        Call ScreenInit()

        Call InitBuffer()

        With Timer1
            .Interval = 10000
            .Enabled = True
            .Start()
        End With

        sCustId = ApplGetParmValue(PRMSECTION_VBRDT, "CustId")
        sShipToId = ApplGetParmValue(PRMSECTION_VBRDT, "ShipToId")


    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Update1_UpdateEvent(Level As Short, InsertFlg As Short, LevelsDone As Short, LevelsLeft As Short, ByRef RetVal As Short) Handles Update1.UpdateEvent
        Dim Custid As String
        Dim ShiptoId As String
        Dim Query As String
        'Stop
        Custid = "000000"
        ShiptoId = "000030"

        If Level = LEVEL0 Then
            Query = "Select * from xsoaddress where custid = " + SParm(RTrim(sCustId)) + "and shiptoid =" + SParm(RTrim(sShipToId))
            Call sql(CSR_xSoAddress, Query)
            serr1 = SFetch1(CSR_xSoAddress, bxSoAddress2)

            If serr1 = NOTFOUND Then
                Try
                    'Call TranBeg(True)
                    'Call SInsert1(CSR_xPld, "xPld", bxPld) 'Inserta
                Catch ex As Exception
                    TranAbort()
                Finally
                    TranEnd()
                End Try
            Else
                Try
                    Call TranBeg(True)
                    bxSoAddress2.Banco = bxSoAddress.Banco
                    bxSoAddress2.MetodoPago = bxSoAddress.MetodoPago
                    bxSoAddress2.DigitosCuenta = bxSoAddress.DigitosCuenta

                    Call SUpdate1(CSR_xSoAddress, "xsoAddress", bxSoAddress2) 'Actualiza
                Catch ex As Exception
                    TranAbort()
                Finally
                    TranEnd()
                End Try
            End If
            RetVal = NoAction

        End If

    End Sub

    Private Sub InitBuffer()

        With bxSoAddress
            .[Addr1] = " "
            .[Addr2] = " "
            .[ApellidoMaterno] = " "
            .[ApellidoPaterno] = " "
            .[Attn] = " "
            .[Banco] = " "
            .[City] = " "
            .[Ciudad] = " "
            .[Clave] = " "
            .[COGSAcct] = " "
            .[COGSSub] = " "
            .[Colonia] = " "
            .[Country] = " "
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .[CURP] = " "
            .[CustId] = " "
            .[Descr] = " "
            .[DigitosCuenta] = " "
            .[DiscAcct] = " "
            .[DiscSub] = " "
            .[Domicilio] = " "
            .[EmailAddr] = " "
            .[Escolaridad] = " "
            .[EstadoCivil] = " "
            .[Fax] = " "
            .[FechaNacimiento] = 0
            .[FOB] = " "
            .[FrghtCode] = " "
            .[FrtAcct] = " "
            .[FrtSub] = " "
            .[FrtTermsID] = " "
            .[GeoCode] = " "
            .[LadaCasa] = " "
            .[LadaOficina] = " "
            .[Lupd_DateTime] = bpes.Today
            .[Lupd_Prog] = bpes.ScrnNbr
            .[Lupd_User] = bpes.UserId
            .[MapLocation] = " "
            .[MetodoPago] = " "
            .[MiscAcct] = " "
            .[MiscSub] = " "
            .[Name] = " "
            .[Nombre] = " "
            .[NoteId] = 0
            .[Numero] = " "
            .[Phone] = " "
            .[RangoSocial] = " "
            .[RazonSocial] = " "
            .[s4Future01] = " "
            .[s4future02] = " "
            .[s4Future03] = 0
            .[s4Future04] = 0
            .[s4Future05] = 0
            .[s4Future06] = 0
            .[s4Future07] = 0
            .[s4Future08] = 0
            .[s4Future09] = 0
            .[s4Future10] = 0
            .[s4future11] = " "
            .[s4Future12] = " "
            .[Salut] = " "
            .[Sexo] = " "
            .[ShipToId] = " "
            .[ShipViaId] = " "
            .[SiteId] = " "
            .[SlsAcct] = " "
            .[SlsPerId] = " "
            .[SlsSub] = " "
            .[State] = " "
            .[Status] = " "
            .[TaxId00] = " "
            .[TaxId01] = " "
            .[TaxId02] = " "
            .[TaxId03] = " "
            .[TaxLocId] = " "
            .[TaxRegNbr] = " "
            .[TelefonoCasa] = " "
            .[TelefonoCelular] = " "
            .[TelefonoOficina] = " "
            .[TipoPersona] = " "
            .[User1] = " "
            .[User2] = " "
            .[User3] = 0
            .[User4] = 0
            .[User5] = " "
            .[User6] = " "
            .[User7] = 0
            .[User8] = 0
            .[Zip] = " "

        End With

    End Sub

End Class
