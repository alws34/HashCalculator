using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography;

namespace ShaCalculator
{
    public partial class frmShaCalculator : Form
    {
        public frmShaCalculator()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {
            string text = tbPath.Text;
            Regex re = new Regex(@"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w ]+\\)*[\w ]+\.[\w]+$");
           //Regex re2 = new Regex(@"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$");
            if (string.IsNullOrEmpty(text) || !re.IsMatch(text))
            {
                lbConsole.Items.Add("Invalid file path provided");
                return;
            }

            if (!File.Exists(text))
            {
                lbConsole.Items.Add("File Does not exist");
                return;
            }
            tbHash1.Text = "";
            tbHash2.Text = "";
            pnlRes.Visible = false;

            string hash = GetHash(text);
            tbHash1.Text = hash;
            string fileName = Path.GetFileName(text);
            lbConsole.Items.Add($"Calculated hash for file {fileName}\nCapathed hash (SHA512):\t\t{hash}");
            string saveFile = $"{fileName}_SHA512.txt";
            if (!File.Exists(saveFile))
                File.Create(saveFile).Close();

            using (StreamWriter sw = new StreamWriter($"{fileName}_SHA512.txt"))
                sw.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm tt")}\n{text}\nSHA512 signature:\n{hash}");

        }


        public static string GetHash(string filePath)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    byte[] hash = sha512.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void tbHash1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null)
                return;
            string text = tb.Text;
            string msg;

            Regex hashRegex = new Regex(@"^[a-f0-9]{128}$");

            if (string.IsNullOrWhiteSpace(text))
            {
                lbConsole.Items.Add("Invalid input provided");
                return;
            }
            if (!hashRegex.IsMatch(text))
            {
                lbConsole.Items.Add("Input is not a valid sha512 hash");
                if (pnlRes.Visible) {
                    pnlRes.BackColor = Color.Red;
                    lblRes.ForeColor = Color.White;
                    msg = "Hashes DONT match!";
                    lblRes.Text = msg;
                    CenterLabelInPanel(lblRes, pnlRes);

                    if (!pnlRes.Visible)
                        pnlRes.Visible = true;
                }
                return;
            }

            if (!string.IsNullOrWhiteSpace(tbHash1.Text) && !string.IsNullOrWhiteSpace(tbHash2.Text))
            {
                if (tbHash1.Text == tbHash2.Text)
                {
                    pnlRes.BackColor = Color.Green;
                    lblRes.ForeColor = Color.Black;
                    msg = "Hashes match!";
                }
                else
                {
                    pnlRes.BackColor = Color.Red;
                    lblRes.ForeColor = Color.White;
                    msg = "Hashes DONT match!";
                }
                if (!pnlRes.Visible)
                    pnlRes.Visible = true;

                lblRes.Text = msg;
                lbConsole.Items.Add(msg);
                CenterLabelInPanel(lblRes, pnlRes);
            }

        }

        public static string GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public void CenterLabelInPanel(Label label, Panel panel)
        {
            label.AutoSize = true;
            label.Location = new Point((panel.Width - label.Width) / 2, (panel.Height - label.Height) / 2);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            tbPath.Text = GetFilePath();
        }
    }
}
