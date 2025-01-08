﻿namespace MsalExample
{
    partial class MainWindow
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
            Button ExitButton;
            TableLayoutPanel tableLayoutPanel1;
            Label label2;
            Button SignInButton;
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            AccessTokenSourceLabel = new Label();
            SignOutButton = new Button();
            SignInCallToActionLabel = new Label();
            GraphResultsPanel = new Panel();
            GraphResultsTextBox = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            ExitButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            SignInButton = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            GraphResultsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom;
            ExitButton.Location = new Point(302, 359);
            ExitButton.Margin = new Padding(2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(78, 20);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AccessTokenSourceLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(SignOutButton, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 260);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(668, 26);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // AccessTokenSourceLabel
            // 
            AccessTokenSourceLabel.Anchor = AnchorStyles.Left;
            AccessTokenSourceLabel.AutoSize = true;
            AccessTokenSourceLabel.Location = new Point(83, 5);
            AccessTokenSourceLabel.Margin = new Padding(0, 0, 2, 0);
            AccessTokenSourceLabel.Name = "AccessTokenSourceLabel";
            AccessTokenSourceLabel.Size = new Size(148, 15);
            AccessTokenSourceLabel.TabIndex = 1;
            AccessTokenSourceLabel.Text = "[Cached | Newly Acquired]";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(2, 5);
            label2.Margin = new Padding(2, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Access Token:";
            // 
            // SignOutButton
            // 
            SignOutButton.Anchor = AnchorStyles.Right;
            SignOutButton.Location = new Point(588, 3);
            SignOutButton.Margin = new Padding(2);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(78, 20);
            SignOutButton.TabIndex = 2;
            SignOutButton.Text = "Sign &Out";
            SignOutButton.UseVisualStyleBackColor = true;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.Top;
            SignInButton.Location = new Point(14, 11);
            SignInButton.Margin = new Padding(2);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(143, 48);
            SignInButton.TabIndex = 0;
            SignInButton.Text = "Reset Passwords";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Microsoft Graph Response:";
            // 
            // SignInCallToActionLabel
            // 
            SignInCallToActionLabel.Anchor = AnchorStyles.Top;
            SignInCallToActionLabel.AutoSize = true;
            SignInCallToActionLabel.Location = new Point(132, 127);
            SignInCallToActionLabel.Margin = new Padding(2, 0, 2, 0);
            SignInCallToActionLabel.Name = "SignInCallToActionLabel";
            SignInCallToActionLabel.Size = new Size(385, 45);
            SignInCallToActionLabel.TabIndex = 2;
            SignInCallToActionLabel.Text = "This application will access Microsoft Graph, if you authorize it to do so.\r\n\r\nClick the Sign In button above to get started.";
            SignInCallToActionLabel.TextAlign = ContentAlignment.MiddleCenter;
            SignInCallToActionLabel.UseMnemonic = false;
            // 
            // GraphResultsPanel
            // 
            GraphResultsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GraphResultsPanel.Controls.Add(label1);
            GraphResultsPanel.Controls.Add(GraphResultsTextBox);
            GraphResultsPanel.Controls.Add(tableLayoutPanel1);
            GraphResultsPanel.Location = new Point(8, 69);
            GraphResultsPanel.Margin = new Padding(2);
            GraphResultsPanel.Name = "GraphResultsPanel";
            GraphResultsPanel.Size = new Size(668, 286);
            GraphResultsPanel.TabIndex = 1;
            GraphResultsPanel.Visible = false;
            // 
            // GraphResultsTextBox
            // 
            GraphResultsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GraphResultsTextBox.Location = new Point(6, 17);
            GraphResultsTextBox.Margin = new Padding(2);
            GraphResultsTextBox.Multiline = true;
            GraphResultsTextBox.Name = "GraphResultsTextBox";
            GraphResultsTextBox.ReadOnly = true;
            GraphResultsTextBox.ScrollBars = ScrollBars.Both;
            GraphResultsTextBox.Size = new Size(659, 242);
            GraphResultsTextBox.TabIndex = 1;
            GraphResultsTextBox.TextChanged += GraphResultsTextBox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "2fdbaf70-405c-420d-81e6-0d5391cd6245";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(551, 7);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 5;
            button1.Text = "Save TenantID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(367, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "1be0f404-8ead-476c-bc75-72a6bd2ac06d";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(551, 36);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 7;
            button2.Text = "Save ClientID";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ExitButton;
            ClientSize = new Size(685, 386);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(GraphResultsPanel);
            Controls.Add(SignInButton);
            Controls.Add(ExitButton);
            Controls.Add(SignInCallToActionLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimumSize = new Size(565, 316);
            Name = "MainWindow";
            Text = "Refer-All Microsoft Graph Toolbox";
            Load += MainWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            GraphResultsPanel.ResumeLayout(false);
            GraphResultsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignInCallToActionLabel;
        private Panel GraphResultsPanel;
        private Label AccessTokenSourceLabel;
        private Button SignOutButton;
        private TextBox GraphResultsTextBox;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
    }
}