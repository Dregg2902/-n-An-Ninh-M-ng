using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace RSA_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string BytesToHexaString(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return string.Empty;

            StringBuilder hexString = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                hexString.AppendFormat("{0:X2}", b);
            }

            return hexString.ToString();
        }

        private byte[] HexaStringToBytes(string hexString)
        {
            if (string.IsNullOrEmpty(hexString))
                return new byte[0];

            int length = hexString.Length;
            byte[] bytes = new byte[length / 2];

            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            return bytes;
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            var rsa = RSA.Create();
            var para = rsa.ExportParameters(true);

            txtP.Text = BytesToHexaString(para.P);
            txtQ.Text = BytesToHexaString(para.Q);
            txtModulus.Text = BytesToHexaString(para.Modulus);
            txtD.Text = BytesToHexaString(para.D);
            txtDP.Text = BytesToHexaString(para.DP);
            txtDQ.Text = BytesToHexaString(para.DQ);
            txtInverseQ.Text = BytesToHexaString(para.InverseQ);
            txtExponent.Text = BytesToHexaString(para.Exponent);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine(txtP.Text);
                        sw.WriteLine(txtQ.Text);
                        sw.WriteLine(txtModulus.Text);
                        sw.WriteLine(txtD.Text);
                        sw.WriteLine(txtDP.Text);
                        sw.WriteLine(txtDQ.Text);
                        sw.WriteLine(txtInverseQ.Text);
                        sw.WriteLine(txtExponent.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu thông tin khóa: {ex.Message}");
                }
            }
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string P = sr.ReadLine();
                        string Q = sr.ReadLine();
                        string Modulus = sr.ReadLine();
                        string D = sr.ReadLine();
                        string DP = sr.ReadLine();
                        string DQ = sr.ReadLine();
                        string InverseQ = sr.ReadLine();
                        string Exponent = sr.ReadLine();

                        txtP.Text = P;
                        txtQ.Text = Q;
                        txtModulus.Text = Modulus;
                        txtD.Text = D;
                        txtDP.Text = DP;
                        txtDQ.Text = DQ;
                        txtInverseQ.Text = InverseQ;
                        txtExponent.Text = Exponent;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi nạp thông tin khóa: {ex.Message}");
                }
            }
        }

        private void btnChonFileBanDau_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileBanDau.Text = openFileDialog.FileName;
            }
        }

        private void btnChonFileMaHoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileMaHoa.Text = openFileDialog.FileName;
            }
        }

        private void btnMahoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richtxtFileBanDau.Text))
                {
                    string encryptedText = EncryptText(richtxtFileBanDau.Text, txtModulus.Text, txtExponent.Text);
                    richtxtFileMaHoa.Text = encryptedText;
                    MessageBox.Show("Mã hóa văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!string.IsNullOrEmpty(txtFileBanDau.Text))
                {               
                    string inputFileName = txtFileBanDau.Text;
                    string fileExtension = Path.GetExtension(inputFileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFileName);

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = $"Encrypted Files (*{fileExtension})|*{fileExtension}|All Files (*.*)|*.*";
                        saveFileDialog.FileName = $"{fileNameWithoutExtension}_encrypted{fileExtension}";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            EncryptFile(inputFileName, saveFileDialog.FileName, txtModulus.Text, txtExponent.Text);
                            MessageBox.Show("Mã hóa file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập văn bản hoặc chọn file để mã hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGiaima_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richtxtFileMaHoa.Text))
                {
                    string decryptedText = DecryptText(richtxtFileMaHoa.Text, txtModulus.Text, txtExponent.Text, txtP.Text, txtQ.Text, txtD.Text, txtDP.Text, txtDQ.Text, txtInverseQ.Text);
                    richtxtFileBanDau.Text = decryptedText;
                    MessageBox.Show("Giải mã văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!string.IsNullOrEmpty(txtFileMaHoa.Text))
                {
                    string inputFileName = txtFileMaHoa.Text;
                    string fileExtension = Path.GetExtension(inputFileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFileName);

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = $"Decrypted Files (*{fileExtension})|*{fileExtension}|All Files (*.*)|*.*";
                        saveFileDialog.FileName = $"{fileNameWithoutExtension}_decrypted{fileExtension}";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DecryptFile(inputFileName, saveFileDialog.FileName, txtModulus.Text, txtExponent.Text, txtP.Text, txtQ.Text, txtD.Text, txtDP.Text, txtDQ.Text, txtInverseQ.Text);
                            MessageBox.Show("Giải mã file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập văn bản hoặc chọn file để giải mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EncryptFile(string inputFile, string outputFile, string modulus, string exponent)
        {
            using (var fsIn = new FileStream(inputFile, FileMode.Open))
            using (var fsOut = new FileStream(outputFile, FileMode.Create))
            {
                var rsa = RSA.Create();
                var para = new RSAParameters
                {
                    Modulus = HexaStringToBytes(modulus),
                    Exponent = HexaStringToBytes(exponent)
                };
                rsa.ImportParameters(para);

                int len = (int)fsIn.Length;
                byte[] data = new byte[len];
                fsIn.Read(data, 0, len);
                byte[] encryptedData = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
                fsOut.Write(encryptedData, 0, encryptedData.Length);
            }
        }

        private void DecryptFile(string inputFile, string outputFile, string modulus, string exponent, string p, string q, string d, string dp, string dq, string inverseQ)
        {
            using (var fsIn = new FileStream(inputFile, FileMode.Open))
            using (var fsOut = new FileStream(outputFile, FileMode.Create))
            {
                var rsa = RSA.Create();
                var para = new RSAParameters
                {
                    P = HexaStringToBytes(p),
                    Q = HexaStringToBytes(q),
                    Modulus = HexaStringToBytes(modulus),
                    D = HexaStringToBytes(d),
                    DP = HexaStringToBytes(dp),
                    DQ = HexaStringToBytes(dq),
                    InverseQ = HexaStringToBytes(inverseQ),
                    Exponent = HexaStringToBytes(exponent)
                };
                rsa.ImportParameters(para);

                int len = (int)fsIn.Length;
                byte[] encryptedData = new byte[len];
                fsIn.Read(encryptedData, 0, len);
                byte[] decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
                fsOut.Write(decryptedData, 0, decryptedData.Length);
            }
        }

        private string EncryptText(string plainText, string modulus, string exponent)
        {
            var rsa = RSA.Create();
            var para = new RSAParameters
            {
                Modulus = HexaStringToBytes(modulus),
                Exponent = HexaStringToBytes(exponent)
            };
            rsa.ImportParameters(para);

            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
            return BytesToHexaString(encryptedData);
        }

        private string DecryptText(string encryptedText, string modulus, string exponent, string p, string q, string d, string dp, string dq, string inverseQ)
        {
            var rsa = RSA.Create();
            var para = new RSAParameters
            {
                P = HexaStringToBytes(p),
                Q = HexaStringToBytes(q),
                Modulus = HexaStringToBytes(modulus),
                D = HexaStringToBytes(d),
                DP = HexaStringToBytes(dp),
                DQ = HexaStringToBytes(dq),
                InverseQ = HexaStringToBytes(inverseQ),
                Exponent = HexaStringToBytes(exponent)
            };
            rsa.ImportParameters(para);

            byte[] encryptedData = HexaStringToBytes(encryptedText);
            byte[] decryptedData = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
            return Encoding.UTF8.GetString(decryptedData);
        }

        private void btnPublicKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine($"Modulus: {txtModulus.Text}");
                        sw.WriteLine($"Exponent: {txtExponent.Text}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu thông tin khóa: {ex.Message}");
                }
            }
        }

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.WriteLine($"D: {txtD.Text}");
                        sw.WriteLine($"Exponent: {txtExponent.Text}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu thông tin khóa: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;  
            this.FormBorderStyle = FormBorderStyle.Sizable; 
            this.Bounds = Screen.PrimaryScreen.Bounds;  
        }
    }
}
