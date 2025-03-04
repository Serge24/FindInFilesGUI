namespace FindInFilesGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            search_dir_target = new TextBox();
            change_dir_target = new Button();
            label3 = new Label();
            search_input = new TextBox();
            file_tree_view = new TreeView();
            start_search_btn = new Button();
            content_textbox = new RichTextBox();
            selected_line_details = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 1;
            label2.Text = "Emplacement ...";
            // 
            // search_dir_target
            // 
            search_dir_target.Location = new Point(185, 23);
            search_dir_target.Margin = new Padding(3, 4, 3, 4);
            search_dir_target.Name = "search_dir_target";
            search_dir_target.ReadOnly = true;
            search_dir_target.Size = new Size(334, 28);
            search_dir_target.TabIndex = 2;
            // 
            // change_dir_target
            // 
            change_dir_target.Location = new Point(524, 23);
            change_dir_target.Margin = new Padding(3, 4, 3, 4);
            change_dir_target.Name = "change_dir_target";
            change_dir_target.Size = new Size(30, 28);
            change_dir_target.TabIndex = 3;
            change_dir_target.Text = "...";
            change_dir_target.UseVisualStyleBackColor = true;
            change_dir_target.Click += Onchange_dir_target;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(170, 19);
            label3.TabIndex = 1;
            label3.Text = "Contenu à rechercher";
            // 
            // search_input
            // 
            search_input.Location = new Point(185, 82);
            search_input.Margin = new Padding(3, 4, 3, 4);
            search_input.Name = "search_input";
            search_input.Size = new Size(334, 28);
            search_input.TabIndex = 2;
            // 
            // file_tree_view
            // 
            file_tree_view.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            file_tree_view.Location = new Point(18, 168);
            file_tree_view.Name = "file_tree_view";
            file_tree_view.Size = new Size(258, 349);
            file_tree_view.TabIndex = 6;
            file_tree_view.AfterSelect += Onfile_tree_view_AfterSelect;
            // 
            // start_search_btn
            // 
            start_search_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            start_search_btn.Location = new Point(766, 523);
            start_search_btn.Name = "start_search_btn";
            start_search_btn.Size = new Size(120, 44);
            start_search_btn.TabIndex = 7;
            start_search_btn.Text = "Rechercher";
            start_search_btn.UseVisualStyleBackColor = true;
            start_search_btn.Click += Onstart_search_btn_Click;
            // 
            // content_textbox
            // 
            content_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content_textbox.BackColor = SystemColors.Window;
            content_textbox.BorderStyle = BorderStyle.FixedSingle;
            content_textbox.Location = new Point(278, 191);
            content_textbox.Name = "content_textbox";
            content_textbox.ReadOnly = true;
            content_textbox.Size = new Size(608, 326);
            content_textbox.TabIndex = 8;
            content_textbox.Text = "";
            // 
            // selected_line_details
            // 
            selected_line_details.AutoSize = true;
            selected_line_details.Location = new Point(283, 167);
            selected_line_details.Name = "selected_line_details";
            selected_line_details.Size = new Size(15, 21);
            selected_line_details.TabIndex = 9;
            selected_line_details.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(779, 15);
            button1.Name = "button1";
            button1.Size = new Size(107, 47);
            button1.TabIndex = 10;
            button1.Text = "Paramètres";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnSettingsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 535);
            label1.Name = "label1";
            label1.Size = new Size(333, 21);
            label1.TabIndex = 11;
            label1.Text = "Find in files © | by <sergestalaki@gmail.com> ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 579);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(selected_line_details);
            Controls.Add(content_textbox);
            Controls.Add(start_search_btn);
            Controls.Add(file_tree_view);
            Controls.Add(change_dir_target);
            Controls.Add(search_input);
            Controls.Add(label3);
            Controls.Add(search_dir_target);
            Controls.Add(label2);
            Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find in Files GUI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox search_dir_target;
        private Button change_dir_target;
        private Label label3;
        private TextBox search_input;
        private TreeView file_tree_view;
        private Button start_search_btn;
        private RichTextBox content_textbox;
        private Label selected_line_details;
        private Button button1;
        private Label label1;
    }
}