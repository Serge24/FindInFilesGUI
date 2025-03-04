namespace FindInFilesGUI
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            python_location = new TextBox();
            find_in_file_prj = new TextBox();
            save_btn = new Button();
            label1 = new Label();
            find_file_project = new Label();
            python_interpreter_selector = new Button();
            find_in_file_btn = new Button();
            SuspendLayout();
            // 
            // python_location
            // 
            python_location.Location = new Point(26, 56);
            python_location.Name = "python_location";
            python_location.ReadOnly = true;
            python_location.Size = new Size(419, 27);
            python_location.TabIndex = 0;
            // 
            // find_in_file_prj
            // 
            find_in_file_prj.Location = new Point(26, 122);
            find_in_file_prj.Name = "find_in_file_prj";
            find_in_file_prj.ReadOnly = true;
            find_in_file_prj.Size = new Size(419, 27);
            find_in_file_prj.TabIndex = 0;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(378, 193);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(115, 38);
            save_btn.TabIndex = 1;
            save_btn.Text = "Sauvegarder";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += Onsave_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 2;
            label1.Text = "Emplacement de l'interpreter python";
            // 
            // find_file_project
            // 
            find_file_project.AutoSize = true;
            find_file_project.Location = new Point(31, 99);
            find_file_project.Name = "find_file_project";
            find_file_project.Size = new Size(222, 20);
            find_file_project.TabIndex = 2;
            find_file_project.Text = "Emplacement du project python";
            // 
            // python_interpreter_selector
            // 
            python_interpreter_selector.Location = new Point(451, 56);
            python_interpreter_selector.Name = "python_interpreter_selector";
            python_interpreter_selector.Size = new Size(42, 29);
            python_interpreter_selector.TabIndex = 1;
            python_interpreter_selector.Text = "...";
            python_interpreter_selector.UseVisualStyleBackColor = true;
            python_interpreter_selector.Click += Onpython_interpreter_selector_Click;
            // 
            // find_in_file_btn
            // 
            find_in_file_btn.Location = new Point(451, 121);
            find_in_file_btn.Name = "find_in_file_btn";
            find_in_file_btn.Size = new Size(42, 29);
            find_in_file_btn.TabIndex = 1;
            find_in_file_btn.Text = "...";
            find_in_file_btn.UseVisualStyleBackColor = true;
            find_in_file_btn.Click += Onfind_in_file_btn_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 253);
            Controls.Add(find_file_project);
            Controls.Add(label1);
            Controls.Add(find_in_file_btn);
            Controls.Add(python_interpreter_selector);
            Controls.Add(save_btn);
            Controls.Add(find_in_file_prj);
            Controls.Add(python_location);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
         
        private TextBox python_location;
        private TextBox find_in_file_prj;
        private Button save_btn;
        private Label label1;
        private Label find_file_project;
        private Button python_interpreter_selector;
        private Button find_in_file_btn;
    }
}