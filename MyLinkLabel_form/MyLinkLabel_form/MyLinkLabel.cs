using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
using System.Drawing.Design;

namespace MyLinkLabel_form
{
    /// <summary>
    /// mylinklabel isminde proje sınıfını oluşturuyor.
    /// </summary>
    public class mylinklabel : Label, IButtonControl
    {
        /// <summary>
        /// mylinklabel sınıfının yeni bir varsayılan örneğini başlatır.
        /// 
        /// mylinklabel companentinin BackColor, ForeColor, Font ve ActiveLinkColor özelliklerini ayarlar.
        /// </summary>
        public mylinklabel()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Blue;
            Font = new Font(Font, Font.Style ^ FontStyle.Underline);
            ActiveLinkColor = Color.Red;
        }

            /// <summary>
            /// System.Windows.Forms.Control.OnPaint(System.Windows.Forms.PaintEventArgs) olayını başlatır.
            /// </summary>
            /// <param name="pevent"></param>
            protected override void OnPaint(PaintEventArgs pevent)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, this.Height / 2), ForeColor, flags);
            }
            /// <summary>
            /// System.Windows.Forms.Control.OnPaint(System.Windows.Forms.PaintEventArgs) olayını başlatır.
            /// </summary>
            /// <returns></returns>
            protected override AccessibleObject CreateAccessibilityInstance()
            {
                return base.CreateAccessibilityInstance();
            }
            /// <summary>
            /// MyLinkLabel denetimi için yeni bir erişilebilirlik nesnesi oluşturur.
            /// </summary>
            protected override void CreateHandle()
            {
                base.CreateHandle();
            }
            /// <summary>
            /// System.Windows.Forms.Label.AutoSizeChanged olayını başlatır.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnAutoSizeChanged(EventArgs e)
            {
                base.OnAutoSizeChanged(e);
            }
            /// <summary>
            /// System.Windows.Forms.Control.EnabledChanged olayı için işleme sağlar.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnEnabledChanged(EventArgs e)
            {
                base.OnEnabledChanged(e);
            }
            /// <summary>
            /// System.Windows.Forms.Control.FontChanged olayını başlatır.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnFontChanged(EventArgs e)
            {
                base.OnFontChanged(e);
            }
            /// <summary>
            /// System.Windows.Forms.Control.GotFocus olayını başlatır.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnGotFocus(EventArgs e)
            {
                base.OnGotFocus(e);
            }
            /// <summary>
            /// Form üzerinde herhangi bir tuşa basıldığı anda tetiklenir.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnKeyDown(KeyEventArgs e)
            {
                base.OnKeyDown(e);
            }
            /// <summary>
            /// System.Windows.Forms.Control.PaddingChanged olayını başlatır.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnPaddingChanged(EventArgs e)
            {
                base.OnPaddingChanged(e);
            }
            /// <summary>
            /// Kontrolün arka planını boyar.
            /// </summary>
            /// <param name="pevent"></param>
            protected override void OnPaintBackground(PaintEventArgs pevent)
            {
                base.OnPaintBackground(pevent);
            }
            /// <summary>
            /// System.Windows.Forms.Label.TextAlignChanged olayını başlatır.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnTextAlignChanged(EventArgs e)
            {
                base.OnTextAlignChanged(e);
            }
            /// <summary>
            /// Olay, metin kutusunun içeriği sunucuya gönderimler arasında değiştiğinde tetiklenir.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnTextChanged(EventArgs e)
            {
                base.OnTextChanged(e);
            }
            /// <summary>
            /// Bir iletişim anahtarını işler.
            /// </summary>
            /// <param name="keyData"></param>
            /// <returns></returns>
            protected override bool ProcessDialogKey(Keys keyData)
            {
                return base.ProcessDialogKey(keyData);
            }
            /// <summary>
            /// İsteğe bağlı olarak, denetimi seçmek için sekme sırasında yönü belirtir.
            /// </summary>
            /// <param name="directed"></param>
            /// <param name="forward"></param>
            protected override void Select(bool directed, bool forward)
            {
                base.Select(directed, forward);
            }
            /// <summary>
            /// Bu kontrolün sınırlarını belirleme işini gerçekleştirir.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="width"></param>
            /// <param name="height"></param>
            /// <param name="specified"></param>
            protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
            {
                base.SetBoundsCore(x, y, width, height, specified);
            }
            /// <summary>
            /// Belirtilen Windows mesajını işler.
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
            }
            /// <summary>
            /// fare ile double click anında olan olayları kontrol eder.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseDoubleClick(MouseEventArgs e)
            {
                base.OnMouseDoubleClick(e);
            }
            /// <summary>
            /// Denetim, fare yakalamayı kaybettiğinde oluşur.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseCaptureChanged(EventArgs e)
            {
                base.OnMouseCaptureChanged(e);

            }
            /// <summary>
            /// Form alanına girmekle tetiklenen olayları kontrol eder.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);

            }
            /// <summary>
            /// Fare işaretçisi denetimin üzerine getirildiğinde gerçekleşir.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseHover(EventArgs e)
            {
                base.OnMouseHover(e);
            }
            /// <summary>
            /// farenin click anındaki olayları kontrol eder.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseClick(MouseEventArgs e)
            {
                base.OnMouseClick(e);
            }
            /// <summary>
            /// fare tuşuna basıldığında click olayından önce çalışan olayları kontrol eder.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                VisitedLinkColor = ForeColor;
                ForeColor = ActiveLinkColor;
            }
            /// <summary>
            ///  Form alanından ayrılındığında tetiklenen olayları kontrol eder.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
            }
            /// <summary>
            /// Fare bir kontrol üzerinde hareket ettirildiğinde çalışır.
            /// cursor özelliğini hand yapar.
            /// </summary>
            protected override void OnMouseMove(MouseEventArgs e)
            {
                base.OnMouseMove(e);
                Cursor = Cursors.Hand;
            }
            /// <summary>
            /// Farenin tuşu basılıyken bırakıldığı anda çalışır.
            /// forecolor özelliğini mavi yapar.
            /// </summary>
            protected override void OnMouseUp(MouseEventArgs e)
            {
                ForeColor = VisitedLinkColor;
                base.OnMouseUp(e);
            }


            DialogResult IButtonControl.DialogResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            void IButtonControl.NotifyDefault(bool value)
            {
                throw new NotImplementedException();
            }

            void IButtonControl.PerformClick()
            {
                throw new NotImplementedException();
            }



            /// <summary>
            /// Normal bir bağlantı görüntülerken kullanılan rengi alır veya ayarlar.
            /// </summary>
            [Category("Appearance")]
            [Description("MyLinkLabelLinkColorDescr")]
            public Color LinkColor { get; set; }

            /// <summary>
            /// Bir bağlantı olarak ele alınacak metindeki aralığı alır veya ayarlar.
            /// </summary>
            [Editor("System.Windows.Forms.Design.LinkAreaEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
            [Localizable(true)]
            [RefreshProperties(RefreshProperties.Repaint)]
            [Category("Behavior")]
            [Description("MyLinkLabelLinkAreaDescr")]
            public LinkArea LinkArea { get; set; }
            /// <summary>
            /// Etkin bir bağlantıyı görüntülemek için kullanılan rengi alır veya ayarlar.
            /// </summary>
            [Category("Appearance")]
            [Description("MyLinkLabelActiveLinkColorDescr")]
            public Color ActiveLinkColor { get; set; }

            /// <summary>
            /// Devre dışı bırakılmış bir bağlantı görüntülenirken kullanılan rengi alır veya ayarlar.
            /// </summary>
            [Category("Appearance")]
            [Description("MyLinkLabelDisabledLinkColorDescr")]
            public Color DisabledLinkColor { get; set; }

            /// <summary>
            /// Bir bağlantının davranışını temsil eden bir değer alır veya ayarlar.
            /// </summary>
            [DefaultValue(LinkBehavior.SystemDefault)]
            [Category("Behavior")]
            [Description("MyLinkLabelLinkBehaviorDescr")]
            public LinkBehavior LinkBehavior { get; set; }

            public bool IsDefault { get; private set; }

            /// <summary>
            /// Fare işaretçisi MyLinkLabel sınırları içinde olduğunda kullanılacak fare işaretçisini alır veya ayarlar.
            /// </summary>
            protected Cursor OverrideCursor { get; set; }

            /// <summary>
            /// MyLinkLabel tarafından görüntülenen metni alır veya ayarlar.
            /// </summary>
            [RefreshProperties(RefreshProperties.Repaint)]
            public override string Text { get; set; }

            /// <summary>
            /// Daha önce ziyaret edilmiş bir bağlantıyı görüntülerken kullanılan rengi alır veya ayarlar.
            /// </summary>
            [Category("Appearance")]
            [Description("MyLinkLabelVisitedLinkColorDescr")]
            public Color VisitedLinkColor { get; set; }

            /// <summary>
            /// Bir bağlantının ziyaret edilmiş gibi görüntülenip görüntülenmeyeceğini belirten bir değer alır veya ayarlar.
            /// </summary>
            [DefaultValue(false)]
            [Category("Appearance")]
            [Description("MyLinkLabelLinkVisitedDescr")]
            public bool LinkVisited { get; set; }


    }
}
