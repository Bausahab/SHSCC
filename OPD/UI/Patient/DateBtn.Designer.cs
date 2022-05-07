
namespace SHSCC.OPD.UI.Patient
{
    partial class DateBtn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionIcon
            // 
            this.instructionIcon.AutoSize = true;
            this.instructionIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.instructionIcon.CausesValidation = false;
            this.instructionIcon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionIcon.ForeColor = System.Drawing.Color.White;
            this.instructionIcon.Location = new System.Drawing.Point(0, 0);
            this.instructionIcon.Margin = new System.Windows.Forms.Padding(4);
            this.instructionIcon.Name = "instructionIcon";
            this.instructionIcon.Padding = new System.Windows.Forms.Padding(4);
            this.instructionIcon.Size = new System.Drawing.Size(118, 31);
            this.instructionIcon.TabIndex = 4;
            this.instructionIcon.Text = "12-12-2020";
            this.instructionIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.instructionIcon.Click += new System.EventHandler(this.instructionIcon_Click);
            // 
            // DateBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.instructionIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Name = "DateBtn";
            this.Size = new System.Drawing.Size(122, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionIcon;
    }
}
