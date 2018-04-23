using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace dxSample_CustomSimpleButton {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void InitSimpleButton() {
            var skin = GetCurrentSkin();
            SetElementImage(skin, GetImage());
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }
        private void SetElementImage(Skin skin, Image img) {
            if (img == null) {
                return;
            }
            var element = skin[CommonSkins.SkinButton];
            element.Image.SetImage(img, System.Drawing.Color.Empty);
        }
        private Image GetImage() {
            return global::dxSample_CustomSimpleButton.Properties.Resources.button1;
        }
        private Skin GetCurrentSkin() {
            return CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
        }
        private void Form1_Load(object sender, EventArgs e) {
            InitSimpleButton();
        }
    }
}
