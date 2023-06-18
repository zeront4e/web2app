
namespace Web2App
{
    partial class FrmRemoveWebapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemoveWebapp));
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.cmbWebapps = new System.Windows.Forms.ComboBox();
            this.btnRemoveWebapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(12, 7);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(58, 13);
            this.lblAppTitle.TabIndex = 10;
            this.lblAppTitle.Text = "App title:";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbWebapps
            // 
            this.cmbWebapps.FormattingEnabled = true;
            this.cmbWebapps.Location = new System.Drawing.Point(15, 26);
            this.cmbWebapps.Name = "cmbWebapps";
            this.cmbWebapps.Size = new System.Drawing.Size(301, 21);
            this.cmbWebapps.TabIndex = 11;
            this.cmbWebapps.SelectedIndexChanged += new System.EventHandler(this.cmbWebapps_SelectedIndexChanged);
            // 
            // btnRemoveWebapp
            // 
            this.btnRemoveWebapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveWebapp.Enabled = false;
            this.btnRemoveWebapp.Location = new System.Drawing.Point(15, 54);
            this.btnRemoveWebapp.Name = "btnRemoveWebapp";
            this.btnRemoveWebapp.Size = new System.Drawing.Size(301, 23);
            this.btnRemoveWebapp.TabIndex = 12;
            this.btnRemoveWebapp.Text = "Remove webapp";
            this.btnRemoveWebapp.UseVisualStyleBackColor = true;
            this.btnRemoveWebapp.Click += new System.EventHandler(this.btnRemoveWebapp_Click);
            // 
            // FrmRemoveWebapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(332, 91);
            this.Controls.Add(this.btnRemoveWebapp);
            this.Controls.Add(this.cmbWebapps);
            this.Controls.Add(this.lblAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRemoveWebapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove webapp";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.ComboBox cmbWebapps;
        private System.Windows.Forms.Button btnRemoveWebapp;
    }
}