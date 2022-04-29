
namespace SHSCC.OPD.UI.AppUI
{
    partial class FrmStartup
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
            this.components = new System.ComponentModel.Container();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtDataLocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lblDateTime = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.btnBrows = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.button1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblDateTime);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnStart);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnBrows);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtDataLocation);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(573, 378);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Description = "SHSC";
            this.kryptonGroupBox1.Values.Heading = "SAURABH HOMIO SKIN CARE";
            // 
            // txtDataLocation
            // 
            this.txtDataLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataLocation.Location = new System.Drawing.Point(166, 199);
            this.txtDataLocation.Name = "txtDataLocation";
            this.txtDataLocation.ReadOnly = true;
            this.txtDataLocation.Size = new System.Drawing.Size(237, 23);
            this.txtDataLocation.TabIndex = 1;
            this.txtDataLocation.Text = "Select Data Location";
            this.txtDataLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataLocation.TextChanged += new System.EventHandler(this.txtDataLocation_TextChanged);
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(166, 155);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(237, 25);
            this.kryptonWrapLabel1.Text = "Data Location Information";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.btnStart.Location = new System.Drawing.Point(166, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 37);
            this.btnStart.TabIndex = 4;
            this.btnStart.Values.Text = "START APPLICATION";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(24, 110);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(146, 25);
            this.kryptonWrapLabel2.Text = "Date and Time :";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblDateTime.Location = new System.Drawing.Point(176, 120);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(16, 15);
            this.lblDateTime.Text = "...";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // btnBrows
            // 
            this.btnBrows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrows.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.btnBrows.Location = new System.Drawing.Point(166, 228);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(237, 27);
            this.btnBrows.TabIndex = 3;
            this.btnBrows.Values.Text = "Select Location";
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.kryptonButton1.Location = new System.Drawing.Point(436, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(123, 30);
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Values.Text = "EXIT APPLICATION";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ClearText";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStartup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELLO Mr. Ankit";
            this.Load += new System.EventHandler(this.FrmStartup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDataLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStart;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrows;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
    }
}