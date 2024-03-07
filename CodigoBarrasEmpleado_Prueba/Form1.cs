using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using QRCoder;


namespace CodigoBarrasEmpleado_Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string numeroEmpleado = txtNumeroEmpleado.Text;

            if (!string.IsNullOrEmpty(numeroEmpleado))
            {
                GenerarCodigoBarras(numeroEmpleado);
                GenerarCodigoQR(numeroEmpleado);
            }
            else
            {
                MessageBox.Show("Ingrese un número de empleado válido.");
            }


        }
        private void GenerarCodigoBarras(string numeroEmpleado)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;

            Bitmap barcodeBitmap = barcodeWriter.Write(numeroEmpleado);

            // Mostrar el código de barras en el PictureBox
            pbCodigoBarras.Image = barcodeBitmap;
        }
        private void GenerarCodigoQR(string numeroEmpleado)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(numeroEmpleado, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeBitmap = qrCode.GetGraphic(20);

            pbCodigoQR.Image = qrCodeBitmap;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
