
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
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblDateTime = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.btnStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblSeltedDriveinfo = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
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
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblSeltedDriveinfo);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblDateTime);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnStart);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonWrapLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(682, 431);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Description = "SHSC";
            this.kryptonGroupBox1.Values.Heading = "SAURABH HOMIO SKIN CARE";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.kryptonButton1.Location = new System.Drawing.Point(550, 6);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(123, 30);
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Values.Text = "EXIT APPLICATION";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblDateTime.Location = new System.Drawing.Point(243, 120);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(16, 15);
            this.lblDateTime.Text = "...";
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(90, 111);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(146, 25);
            this.kryptonWrapLabel2.Text = "Date and Time :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(221, 282);
            this.btnStart.Name = "btnStart";
            this.btnStart.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnStart.Size = new System.Drawing.Size(237, 37);
            this.btnStart.TabIndex = 4;
            this.btnStart.Values.Text = "START APPLICATION";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(221, 155);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(237, 25);
            this.kryptonWrapLabel1.Text = "Data Location Information";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 237;
            this.kryptonComboBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonComboBox1.Location = new System.Drawing.Point(221, 233);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonComboBox1.Size = new System.Drawing.Size(237, 21);
            this.kryptonComboBox1.TabIndex = 14;
            this.kryptonComboBox1.DropDown += new System.EventHandler(this.kryptonComboBox1_DropDown);
            this.kryptonComboBox1.SelectionChangeCommitted += new System.EventHandler(this.kryptonComboBox1_SelectionChangeCommitted);
            // 
            // lblSeltedDriveinfo
            // 
            this.lblSeltedDriveinfo.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblSeltedDriveinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lblSeltedDriveinfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblSeltedDriveinfo.Location = new System.Drawing.Point(221, 205);
            this.lblSeltedDriveinfo.Name = "lblSeltedDriveinfo";
            this.lblSeltedDriveinfo.Size = new System.Drawing.Size(189, 25);
            this.lblSeltedDriveinfo.Text = "SELECT DATA DRIVE:";
            // 
            // kryptonWrapLabel3
            // 
            this.kryptonWrapLabel3.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.kryptonWrapLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.kryptonWrapLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonWrapLabel3.Location = new System.Drawing.Point(134, 233);
            this.kryptonWrapLabel3.Name = "kryptonWrapLabel3";
            this.kryptonWrapLabel3.Size = new System.Drawing.Size(81, 25);
            this.kryptonWrapLabel3.Text = "Change:";
            // 
            // FrmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 431);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblDateTime;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnStart;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblSeltedDriveinfo;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel3;
    }
}