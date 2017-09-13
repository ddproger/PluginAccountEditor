using PluginAccountEditor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginAccountEditor
{
    public partial class Form1 : Form
    {
        RegeditService regService = new RegeditService();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchResourceFile_Click(object sender, EventArgs e)
        {
            txtPathResource.Text = getPathFromDisk();
            regService.setResourceFilePath(txtPathResource.Text);
            if (File.Exists(txtPathResource.Text))
                txtAccount.Text = getAccountFromPath(txtPathResource.Text).ToString();
        }

        private string getPathFromDisk()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = regService.getOpenFilePath();
            openFileDialog1.Filter = "dll library files (*.dll)|*.dll|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {                   
                    regService.setOpenFilePath(openFileDialog1.FileName);
                    string result = openFileDialog1.FileName;
                    openFileDialog1.Dispose();
                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error:\n " + ex.Message);
                }
            }
            return "";
        }

        private void btnSearchNewFile_Click(object sender, EventArgs e)
        {
            txtPathToNewFile.Text = getPathFromDisk();
            regService.setNewFilePath(txtPathToNewFile.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPathResource.Text))
            {
                if(!txtPathResource.Text.Equals(txtPathToNewFile.Text))
                File.Copy(txtPathResource.Text, txtPathToNewFile.Text,true);
                writeNewAccount(txtPathToNewFile.Text);
                MessageBox.Show("Акаунт успешно внедрен");
            }
        }
        private void writeNewAccount(string path)
        {
            try
            {
               
                long acc = 0;
                if (!long.TryParse(txtAccount.Text, out acc) && txtAccount.Text.Length > 10)
                {
                    MessageBox.Show("uncorrect account");
                    return;
                }
                string account = encryptAccount(acc);
                long seek = getIndexOfAccount(path);
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Write);
                if (file.CanWrite&&file.CanSeek)
                {
                            file.Seek(seek, SeekOrigin.Begin);
                            file.WriteByte((byte)(account.Length * 2 + 1));
                            foreach (char item in account)
                            {
                                file.WriteByte((byte)item);
                                file.Seek(1, SeekOrigin.Current);
                            }                       
                    
                }
                file.Dispose();
            }catch(Exception ex)
            {
                MessageBox.Show("Cannot Edit account! Origin error\n" + ex.Message);
            }
        }

        private string encryptAccount(long acc)
        {
            char[] key = new char []{'3', '5', '2', '8', '1', '7', '9', '6', '4', '0'};
            long salt = 1001001;
            acc -= salt;
            
            StringBuilder builder = new StringBuilder();
            foreach (char item in acc.ToString())
            {
                builder.Append(key[int.Parse(item + "")]);
            }
            return builder.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPathResource.Text = regService.getResourceFilePath();
            txtPathToNewFile.Text = regService.getNewFilePath();
            if(File.Exists(regService.getResourceFilePath()))
            txtAccount.Text = getAccountFromPath(regService.getResourceFilePath()).ToString();
        }

        private long getAccountFromPath(string path)
        {
            int seek = getIndexOfAccount(path);

            try
            {
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                file.Seek(seek, SeekOrigin.Begin);
                int length = (file.ReadByte()-1)/2;
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < length; i++)
                {
                    builder.Append((char)file.ReadByte());
                    file.Seek(1, SeekOrigin.Current);
                }
                long acc = 0;
                long.TryParse(builder.ToString(), out acc);
                file.Dispose();
                return decryptAccount(acc);                
            }catch(Exception ex)
            {
                MessageBox.Show("Cannot read account! Origin message\n" + ex.Message);
            }
            return 0;
        }

        private int getIndexOfAccount(string path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                byte[] data = new byte[6];
                long size = file.Length - 6;                
                
                if (file.CanSeek)
                {
                    for (int i = 30000; i < size; i++)
                    {
                        file.Seek(i, SeekOrigin.Begin);
                        file.Read(data, 0, 6);
                        if (data[0] == 'c' && data[2] == 'p' && data[4] == '5')
                        {
                            file.Seek(i-1, SeekOrigin.Begin);
                            int seek = file.Read(data, 0, 6);
                            file.Dispose();
                            return i+seek+1;
                        }
                    }
                }
                file.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot get account! Origin error\n" + ex.Message);
            }
            return 0;
        }
        private long decryptAccount(long acc)
        {
            char[] key = new char[] { '9', '4', '2', '0', '8', '1', '7', '5', '3', '6' };
            long salt = 1001001;

            StringBuilder builder = new StringBuilder();
            foreach (char item in acc.ToString())
            {
                builder.Append(key[Int32.Parse(item + "")]);
            }
            long.TryParse(builder.ToString(), out acc);
            acc += salt;
            
            return acc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
