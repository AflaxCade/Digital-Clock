using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Digitsl_Clock
{

    public partial class display : Form
    {

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont
            , IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;


        public display()
        {
            InitializeComponent();
        }

        private void display_Load(object sender, EventArgs e)
        {

            loadFont();
            AllocFont(font, this.time, 105);
            timer.Start();
            time.Text = DateTime.Now.ToString("hh:mm:ss");
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            period.Text = DateTime.Now.ToString("tt");
            day.Text = DateTime.Today.ToString("dddd");
            time.Location = new Point((this.ClientSize.Width - this.time.Width) / 2,
                         (this.ClientSize.Height - this.time.Height) / 2);
        }

        private void loadFont()
        {
            byte[] fontArray = Properties.Resources.Digital_Dismay;
            int dataLength = Properties.Resources.Digital_Dismay.Length;
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);
            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, dataLength);
            Marshal.FreeCoTaskMem(ptrData);
            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Regular);
        }
        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss");
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            period.Text = DateTime.Now.ToString("tt");
        }

        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void display_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                {
                    loadFont();
                    AllocFont(font, this.time, 190);
                    time.Location = new Point((this.ClientSize.Width - time.Width) / 2,
                                 (this.ClientSize.Height - time.Height) / 2);
                }
                if (WindowState == FormWindowState.Normal)
                {

                    loadFont();
                    AllocFont(font, this.time, 105);
                    time.Location = new Point((this.ClientSize.Width - time.Width) / 2,
                                 (this.ClientSize.Height - time.Height) / 2);
                }
            }
        }
    }
}
