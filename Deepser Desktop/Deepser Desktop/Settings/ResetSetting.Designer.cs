namespace Deepser_Desktop
{
    partial class ResetSetting
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
            labelReset = new Label();
            buttonReset = new CustomControls.RJControls.RJButton();
            SuspendLayout();
            // 
            // labelReset
            // 
            labelReset.Font = new Font("Poppins", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelReset.Location = new Point(160, 97);
            labelReset.Name = "labelReset";
            labelReset.Size = new Size(569, 293);
            labelReset.TabIndex = 0;
            labelReset.Text = "Do you want to delete the program configuration of all users and any sectors? This is an irreversible operation that will restart you from the initial setup of the program";
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Crimson;
            buttonReset.BackgroundColor = Color.Crimson;
            buttonReset.BorderColor = Color.Crimson;
            buttonReset.BorderRadius = 15;
            buttonReset.BorderSize = 0;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(346, 371);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(206, 54);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Reset";
            buttonReset.TextColor = Color.White;
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // ResetSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 519);
            Controls.Add(buttonReset);
            Controls.Add(labelReset);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetSetting";
            Text = "ResetSetting";
            ResumeLayout(false);
        }

        #endregion

        private Label labelReset;
        private CustomControls.RJControls.RJButton buttonReset;
    }
}