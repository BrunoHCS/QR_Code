using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
            var texto = QR.CreateQrCode(txt_Texto.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(texto);
            pictureBox1.Image = code.GetGraphic(50);
            //txt_Texto.Text = null;
        }
    }
}
