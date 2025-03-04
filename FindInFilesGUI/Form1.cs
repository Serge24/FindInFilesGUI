using Python.Runtime;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.Json;


namespace FindInFilesGUI
{
    public partial class Form1 : Form
    {
        private string SourceDir = string.Empty;
        private IEnumerable<FoundFile> Records = Array.Empty<FoundFile>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void Onchange_dir_target(object sender, EventArgs e)
        {
            FolderBrowserDialog Dialog = new()
            {
                ShowNewFolderButton = true
            };

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                SourceDir = Dialog.SelectedPath;
                search_dir_target.Text = SourceDir;
            }
        }

        private void ClearTreeView()
        {
            file_tree_view.Nodes.Clear();
        }

        private void Onstart_search_btn_Click(object sender, EventArgs e)
        {
            if (search_input.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Champ de recherche vide");
                return;
            }

            if (SourceDir.Trim().Length <= 0)
            {
                MessageBox.Show("Emplacement de recherche vide");
                return;
            }

            if (Settings1.Default.python_path.Trim().Length <= 0 || Settings1.Default.find_in_file_path.Trim().Length <= 0)
            {
                MessageBox.Show("Veuillez définir les paramètres");
                return;
            }

            selected_line_details.Text = "-";
            content_textbox.Text = "";

            var python_script = Path.Combine(Settings1.Default.find_in_file_path.Trim(), "FindInFiles.py");
            var python_interpreter = Path.Combine(Settings1.Default.python_path.Trim(), "python.exe");


            ClearTreeView();

            ProcessStartInfo psi = new()
            {
                FileName = python_interpreter,
                Arguments = python_script + " -text=\"" + search_input.Text.ToLower().Trim() + "\" -s=\"" + SourceDir + "\" -json=true",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = Process.Start(psi);
            string cmd_result = process.StandardOutput.ReadToEnd();
            string cmd_errors = process.StandardError.ReadToEnd();

            if (cmd_errors.Trim() != string.Empty)
            {
                MessageBox.Show(cmd_errors);
                return;
            }

            List<FoundFile> records = JsonSerializer.Deserialize<List<FoundFile>>(cmd_result);

            if (records != null && records.Count > 0)
            {
                Records = records;
                foreach (var record in records)
                {
                    var Root = new TreeNode(record.File);
                    foreach (var data in record.Data)
                    {
                        var node = new TreeNode(string.Format("Ligne {0}", data.Line));
                        Root.Nodes.Add(node);
                    }

                    file_tree_view.Nodes.Add(Root);
                }

                file_tree_view.ExpandAll();
            }

        }

        private void HighlightWord(RichTextBox richTextBox, string word, Color color)
        {
            int start = 0;
            while ((start = richTextBox.Text.IndexOf(word, start, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                richTextBox.Select(start, word.Length);
                richTextBox.SelectionColor = color;
                start += word.Length; // Move past the current word
            }
        }

        public LineData? FindRecord(string fileName, int lineNumber)
        {
            return Records
                .Where(record => record.File == fileName) // Filtrer par fichier
                .SelectMany(record => record.Data)
                .FirstOrDefault(data => data.Line == lineNumber); // Trouver la bonne ligne
        }


        private void Onfile_tree_view_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e?.Node?.Parent != null)
            {
                var File = e?.Node?.Parent.Text;
                var Line = int.Parse(e?.Node?.Text.Replace("Ligne ", ""));

                selected_line_details.Text = string.Format("{0} Ligne {1}", Path.Combine(SourceDir, File), Line);
                var data = FindRecord(File, Line);

                content_textbox.Text = data?.Content;

                HighlightWord(content_textbox, search_input.Text.ToLower(), Color.Red);
            }
        }

        private void OnSettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new();
            form.ShowDialog();
        }
    }
}