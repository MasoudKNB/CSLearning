namespace SayHello
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
            BtnSayHello = new Button();
            BtnClear = new Button();
            BtnExit = new Button();
            LblEntrName = new Label();
            TxtBName = new TextBox();
            lblSayHello = new Label();
            SuspendLayout();
            // 
            // BtnSayHello
            // 
            BtnSayHello.Location = new Point(16, 40);
            BtnSayHello.Name = "BtnSayHello";
            BtnSayHello.Size = new Size(97, 26);
            BtnSayHello.TabIndex = 0;
            BtnSayHello.Text = "&Say Hello";
            BtnSayHello.UseVisualStyleBackColor = true;
            BtnSayHello.Click += BtnSayHello_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(134, 40);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(97, 26);
            BtnClear.TabIndex = 0;
            BtnClear.Text = "&Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnExit
            // 
            BtnExit.ForeColor = SystemColors.ActiveCaptionText;
            BtnExit.Location = new Point(252, 40);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(97, 26);
            BtnExit.TabIndex = 0;
            BtnExit.Text = "E&xit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LblEntrName
            // 
            LblEntrName.AutoSize = true;
            LblEntrName.Location = new Point(16, 10);
            LblEntrName.Name = "LblEntrName";
            LblEntrName.Size = new Size(125, 17);
            LblEntrName.TabIndex = 1;
            LblEntrName.Text = "Enter Your Name:";
            LblEntrName.Click += label1_Click;
            LblEntrName.MouseLeave += LblEntrName_MouseLeave;
            LblEntrName.MouseMove += LblEntrName_MouseMove;
            // 
            // TxtBName
            // 
            TxtBName.Location = new Point(151, 7);
            TxtBName.Name = "TxtBName";
            TxtBName.Size = new Size(198, 25);
            TxtBName.TabIndex = 2;
            TxtBName.TextChanged += TxtBName_TextChanged;
            // 
            // lblSayHello
            // 
            lblSayHello.AutoSize = true;
            lblSayHello.Location = new Point(16, 79);
            lblSayHello.Name = "lblSayHello";
            lblSayHello.Size = new Size(0, 17);
            lblSayHello.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 113);
            Controls.Add(TxtBName);
            Controls.Add(lblSayHello);
            Controls.Add(LblEntrName);
            Controls.Add(BtnExit);
            Controls.Add(BtnClear);
            Controls.Add(BtnSayHello);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "MyApp ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSayHello;
        private Button BtnClear;
        private Button BtnExit;
        private Label LblEntrName;
        private TextBox TxtBName;
        private Label lblSayHello;
    }
}
