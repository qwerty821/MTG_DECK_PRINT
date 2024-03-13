namespace MTG_DECK_PRINT
{
    partial class Form2
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
            button1 = new Button();
            cardsView = new FlowLayoutPanel();
            pdfButton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(1505, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 34);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cardsView
            // 
            cardsView.AutoScroll = true;
            cardsView.Location = new Point(39, 36);
            cardsView.Name = "cardsView";
            cardsView.Size = new Size(1265, 915);
            cardsView.TabIndex = 1;
            // 
            // pdfButton
            // 
            pdfButton.Location = new Point(1373, 917);
            pdfButton.Name = "pdfButton";
            pdfButton.Size = new Size(112, 34);
            pdfButton.TabIndex = 2;
            pdfButton.Text = "Print";
            pdfButton.UseVisualStyleBackColor = true;
            pdfButton.Click += pdfButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1373, 544);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 1025);
            Controls.Add(button2);
            Controls.Add(pdfButton);
            Controls.Add(cardsView);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel cardsView;
        private Button pdfButton;
        private Button button2;
    }
}