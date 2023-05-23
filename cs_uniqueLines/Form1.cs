using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace cs_uniqueLines
{
    public partial class Form1 : Form
    {
        private string filePath;
        private List<string> uniqueLines;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnFilpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                LoadFileToListBox();
            }

            tbxFilePath.Text = filePath;
        }

        private void LoadFileToListBox()
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                lbxfileInfo.Items.Clear();
                lbxfileInfo.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }

        private void btnUnique_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("파일이 없습니다.");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);
                uniqueLines = lines.Distinct().ToList();

                lbxfileInfo.Items.Clear();
                lbxfileInfo.Items.AddRange(uniqueLines.ToArray());

                MessageBox.Show("중복된 행이 제거 되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (uniqueLines == null || !uniqueLines.Any())
            {
                MessageBox.Show("저장할 내용이 없습니다.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(sfd.FileName, uniqueLines.ToArray());

                    MessageBox.Show("저장되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"error: {ex.Message}");
                }
            }
        }
    }
}
