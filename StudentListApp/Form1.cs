using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudentListApp
{
    public partial class Form1 : Form
    {
        private string filePath = "telebeler.txt";

        public Form1()
        {
            InitializeComponent();

            
            label1.Text = "ID:";
            label2.Text = "Ad:";
            label3.Text = "Yaş:";
            label4.Text = "Axtarış (Ad):";

          
            btnAdd.Text = "1) Tələbə əlavə et";
            btnShowAll.Text = "2) Hamısını göstər";
            btnSearch.Text = "3) Ada görə axtar";
            btnExit.Text = "4) Çıxış";
        }

        // 1) Tələbə əlavə et (btnAdd)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string age = txtAge.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age))
            {
                MessageBox.Show("Zəhmət olmasa ID, Ad və Yaş xanalarını doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                sw.WriteLine($"{id};{name};{age}");
            }

            txtID.Clear();
            txtName.Clear();
            txtAge.Clear();
            MessageBox.Show("Tələbə fayla əlavə edildi!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 2) Hamısını göstər (btnShowAll)
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Hələ heç bir tələbə əlavə edilməyib.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');
                if (parts.Length == 3)
                {
                    lstStudents.Items.Add($"ID: {parts[0]} | Ad: {parts[1]} | Yaş: {parts[2]}");
                }
            }
        }

        // 3) Ada görə axtar (btnSearch)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            string searchName = txtSearch.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Fayl mövcud deyil.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Axtarış üçün ad daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            bool found = false;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');
                if (parts.Length == 3 && parts[1].IndexOf(searchName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    lstStudents.Items.Add($"ID: {parts[0]} | Ad: {parts[1]} | Yaş: {parts[2]}");
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Bu adda tələbə tapılmadı.", "Nəticə", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 4) Çıxış (btnExit)
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}