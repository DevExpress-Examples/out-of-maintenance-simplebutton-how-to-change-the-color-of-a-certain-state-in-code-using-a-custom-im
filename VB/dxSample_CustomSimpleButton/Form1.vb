Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins

Namespace dxSample_CustomSimpleButton
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Dim skin = GetCurrentSkin()
            SetElementImage(skin, GetImage())
        End Sub
        Private Sub SetElementImage(ByVal skin As Skin, ByVal img As Image)
            If img Is Nothing Then
                Return
            End If
            Dim element = skin(CommonSkins.SkinButton)
            element.SetActualImage(img, False)
        End Sub
        Private Function GetImage() As Image
            Return My.Resources.button1
        End Function
        Private Function GetCurrentSkin() As Skin
            Return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel)
        End Function
    End Class
End Namespace
