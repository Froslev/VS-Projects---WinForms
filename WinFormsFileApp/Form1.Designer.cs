namespace WinFormsFileApp
{
    partial class FilhanteringsApp
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
            label1 = new Label();
            SkapaBtn = new Button();
            FyllBtn = new Button();
            first_name = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DeleteBtn = new Button();
            file_content = new RichTextBox();
            last_name = new TextBox();
            LäsFilBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(453, 56);
            label1.TabIndex = 0;
            label1.Text = "Var vänlig fyll i din fil:";
            // 
            // SkapaBtn
            // 
            SkapaBtn.BackColor = Color.White;
            SkapaBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SkapaBtn.Location = new Point(12, 183);
            SkapaBtn.Name = "SkapaBtn";
            SkapaBtn.Size = new Size(100, 38);
            SkapaBtn.TabIndex = 1;
            SkapaBtn.Text = "Skapa fil";
            SkapaBtn.UseVisualStyleBackColor = false;
            SkapaBtn.Click += SkapaBtn_Click;
            // 
            // FyllBtn
            // 
            FyllBtn.BackColor = Color.White;
            FyllBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FyllBtn.Location = new Point(118, 183);
            FyllBtn.Name = "FyllBtn";
            FyllBtn.Size = new Size(100, 38);
            FyllBtn.TabIndex = 2;
            FyllBtn.Text = "Fyll filen ";
            FyllBtn.UseVisualStyleBackColor = false;
            FyllBtn.Click += FyllBtn_Click;
            // 
            // first_name
            // 
            first_name.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            first_name.Location = new Point(14, 140);
            first_name.Name = "first_name";
            first_name.Size = new Size(152, 28);
            first_name.TabIndex = 3;
            first_name.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(330, 227);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 172);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(355, 102);
            label2.Name = "label2";
            label2.Size = new Size(0, 26);
            label2.TabIndex = 5;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(366, 193);
            label3.Name = "label3";
            label3.Size = new Size(191, 28);
            label3.TabIndex = 6;
            label3.Text = "Dina sparade filer:";
            label3.Click += label3_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(330, 405);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(282, 23);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Radera alla filer";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // file_content
            // 
            file_content.Location = new Point(12, 227);
            file_content.Name = "file_content";
            file_content.Size = new Size(312, 201);
            file_content.TabIndex = 8;
            file_content.Text = "";
            // 
            // last_name
            // 
            last_name.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            last_name.Location = new Point(170, 140);
            last_name.Name = "last_name";
            last_name.Size = new Size(154, 28);
            last_name.TabIndex = 9;
            // 
            // LäsFilBtn
            // 
            LäsFilBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LäsFilBtn.Location = new Point(224, 183);
            LäsFilBtn.Name = "LäsFilBtn";
            LäsFilBtn.Size = new Size(100, 38);
            LäsFilBtn.TabIndex = 10;
            LäsFilBtn.Text = "Läs filen";
            LäsFilBtn.UseVisualStyleBackColor = true;
            LäsFilBtn.Click += LäsFilBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(88, 26);
            label4.TabIndex = 11;
            label4.Text = "Förnamn";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(172, 111);
            label5.Name = "label5";
            label5.Size = new Size(100, 26);
            label5.TabIndex = 12;
            label5.Text = "Efternamn";
            // 
            // FilhanteringsApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(627, 440);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LäsFilBtn);
            Controls.Add(last_name);
            Controls.Add(file_content);
            Controls.Add(DeleteBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(first_name);
            Controls.Add(FyllBtn);
            Controls.Add(SkapaBtn);
            Controls.Add(label1);
            Name = "FilhanteringsApp";
            Text = "FileApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SkapaBtn;
        private Button FyllBtn;
        private TextBox first_name;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button DeleteBtn;
        private RichTextBox file_content;
        private TextBox last_name;
        private Button LäsFilBtn;
        private Label label4;
        private Label label5;
    }
}