namespace COMP1004_Assignment4
{
    partial class StartForm
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
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(92, 183);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(93, 35);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.Location = new System.Drawing.Point(92, 236);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(93, 35);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "Load Order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(92, 288);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(92, 30);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(100, 116);
            this.ImagePictureBox.TabIndex = 3;
            this.ImagePictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 357);
            this.ControlBox = false;
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
    }
}