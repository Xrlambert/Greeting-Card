namespace Greeting_Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OpenButton = new Button();
            SuspendLayout();
            // 
            // OpenButton
            // 
            OpenButton.BackColor = Color.White;
            OpenButton.Font = new Font("Segoe UI", 16F);
            OpenButton.ForeColor = Color.Navy;
            OpenButton.Location = new Point(101, 464);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(293, 66);
            OpenButton.TabIndex = 0;
            OpenButton.Text = "Click to open your card!";
            OpenButton.UseVisualStyleBackColor = false;
            OpenButton.Visible = false;
            OpenButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(537, 608);
            Controls.Add(OpenButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Birthday Card";
            Click += Form1_Click;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button OpenButton;
    }
}
