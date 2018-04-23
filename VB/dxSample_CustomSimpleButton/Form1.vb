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
        End Sub
        Private Sub InitSimpleButton()
            Dim skin = GetCurrentSkin()
            SetElementImage(skin, GetImage())
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        End Sub
        Private Sub SetElementImage(ByVal skin As Skin, ByVal img As Image)
            If img Is Nothing Then
                Return
            End If
            Dim element = skin(CommonSkins.SkinButton)
            element.Image.SetImage(img, System.Drawing.Color.Empty)
        End Sub
        Private Function GetImage() As Image
            Return My.Resources.button1
        End Function
        Private Function GetCurrentSkin() As Skin
            Return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel)
        End Function
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitSimpleButton()
        End Sub
    End Class
End Namespace
