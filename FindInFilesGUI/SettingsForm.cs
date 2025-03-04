using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindInFilesGUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Onsave_btn_Click(object sender, EventArgs e)
        {
            Settings1.Default.Save();
            MessageBox.Show("Enregistrement réussi");
        }

        private void Onpython_interpreter_selector_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new()
            {
                ShowNewFolderButton = true
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                python_location.Text = Dialog.SelectedPath;
                Settings1.Default.python_path = Dialog.SelectedPath;
            }
        }

        private void Onfind_in_file_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new()
            {
                ShowNewFolderButton = true
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                find_in_file_prj.Text = Dialog.SelectedPath;
                Settings1.Default.find_in_file_path = Dialog.SelectedPath;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            python_location.Text = Settings1.Default.python_path;
            find_in_file_prj.Text = Settings1.Default.find_in_file_path;
        }
    }
}
