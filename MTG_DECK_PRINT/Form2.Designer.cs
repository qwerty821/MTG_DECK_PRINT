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
            buttonPrint = new Button();
            buttonLoad = new Button();
            cardsView = new FlowLayoutPanel();
            progressBar1 = new ProgressBar();
            buttonCancel = new Button();
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
            // buttonPrint
            // 
            buttonPrint.Location = new Point(1373, 917);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(112, 34);
            buttonPrint.TabIndex = 2;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(1373, 544);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(112, 34);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // cardsView
            // 
            cardsView.AutoScroll = true;
            cardsView.Location = new Point(22, 15);
            cardsView.Name = "cardsView";
            cardsView.Size = new Size(1300, 936);
            cardsView.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(52, 969);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1230, 38);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 5;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1373, 736);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 1025);
            Controls.Add(buttonCancel);
            Controls.Add(progressBar1);
            Controls.Add(cardsView);
            Controls.Add(buttonLoad);
            Controls.Add(buttonPrint);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Cancel";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonPrint;
        private Button buttonLoad;
        private FlowLayoutPanel cardsView;
        private ProgressBar progressBar1;
        private Button buttonCancel;
    }
}