namespace WinFormsApp5
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
            textBox1 = new TextBox();
            SearchButton = new Button();
            MarkaRadio = new RadioButton();
            ModelRadio = new RadioButton();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(28, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 51);
            textBox1.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(456, 29);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(160, 51);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // MarkaRadio
            // 
            MarkaRadio.AutoSize = true;
            MarkaRadio.Checked = true;
            MarkaRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarkaRadio.Location = new Point(28, 97);
            MarkaRadio.Name = "MarkaRadio";
            MarkaRadio.Size = new Size(88, 32);
            MarkaRadio.TabIndex = 2;
            MarkaRadio.TabStop = true;
            MarkaRadio.Text = "Marka";
            MarkaRadio.UseVisualStyleBackColor = true;
            // 
            // ModelRadio
            // 
            ModelRadio.AutoSize = true;
            ModelRadio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModelRadio.Location = new Point(137, 97);
            ModelRadio.Name = "ModelRadio";
            ModelRadio.Size = new Size(90, 32);
            ModelRadio.TabIndex = 3;
            ModelRadio.Text = "Model";
            ModelRadio.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(588, 344);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 499);
            Controls.Add(listBox1);
            Controls.Add(ModelRadio);
            Controls.Add(MarkaRadio);
            Controls.Add(SearchButton);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button SearchButton;
        private RadioButton MarkaRadio;
        private RadioButton ModelRadio;
        private ListBox listBox1;
    }
}
