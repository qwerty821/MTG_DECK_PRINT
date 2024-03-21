namespace MTG_DECK_PRINT
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
            button2 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            openFileDialog1 = new OpenFileDialog();
            exitButton = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(207, 620);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(159, 61);
            button2.TabIndex = 1;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImage = Properties.Resources.taskbaar;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Location = new Point(1112, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 2;
            exitButton.TabStop = false;
            exitButton.Click += ExitEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe Print", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(54, 549);
            label1.Name = "label1";
            label1.Size = new Size(460, 54);
            label1.TabIndex = 3;
            label1.Text = "Choose the folder with cards";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 738);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CardPrint";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private FileSystemWatcher fileSystemWatcher1;
        private OpenFileDialog openFileDialog1;
        private PictureBox exitButton;
        private Label label1;
    }
}
