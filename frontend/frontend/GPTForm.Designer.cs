namespace frontend
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
        protected override void Dispose (bool disposing) {
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
        private void InitializeComponent () {
            textBoxPrompt = new TextBox();
            textBoxResponse = new TextBox();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // textBoxPrompt
            // 
            textBoxPrompt.Location = new Point(140, 84);
            textBoxPrompt.Name = "textBoxPrompt";
            textBoxPrompt.Size = new Size(561, 27);
            textBoxPrompt.TabIndex = 0;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(158, 303);
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.Size = new Size(552, 27);
            textBoxResponse.TabIndex = 1;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(334, 377);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(94, 29);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "buttonSend";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSend);
            Controls.Add(textBoxResponse);
            Controls.Add(textBoxPrompt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrompt;
        private TextBox textBoxResponse;
        private Button buttonSend;
    }
}
