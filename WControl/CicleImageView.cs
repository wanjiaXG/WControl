using System;
using System.Drawing;
using System.Windows.Forms;

namespace wanjia.Controls
{
    public partial class CicleImageView : Control
    {
        private EventHandler onImageChanged;
        private event EventHandler OnImageChanged
        {
            add
            {
                onImageChanged += value;
            }
            remove
            {
                onImageChanged -= value;
            }
        }

        private Image image;
        public Image Image
        {
            set
            {
                image = value;
                this.Invalidate();
            }
            get
            {
                return image;
            }
        }

        public CicleImageView()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if(Image != null)
            {
                try
                {
                    Graphics g = pe.Graphics;

                    using (TextureBrush brush = new TextureBrush(new Bitmap(Image, ClientSize)))
                    {
                        g.FillEllipse(brush, ClientRectangle);
                        onImageChanged?.Invoke(this, EventArgs.Empty);
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}
