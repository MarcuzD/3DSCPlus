﻿namespace MarcusD._3DSCPlusDummy
{
    partial class FormAltedit
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
            if(disposing && (components != null))
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
            this.imgAlt = new System.Windows.Forms.PictureBox();
            this.radioToolSelect = new System.Windows.Forms.RadioButton();
            this.radioToolDelet = new System.Windows.Forms.RadioButton();
            this.radioToolEdit = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnBgsel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSel = new System.Windows.Forms.Label();
            this.radioToolResize = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAlt
            // 
            this.imgAlt.BackColor = System.Drawing.Color.Black;
            this.imgAlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgAlt.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgAlt.Location = new System.Drawing.Point(0, 0);
            this.imgAlt.MaximumSize = new System.Drawing.Size(320, 240);
            this.imgAlt.MinimumSize = new System.Drawing.Size(320, 240);
            this.imgAlt.Name = "imgAlt";
            this.imgAlt.Size = new System.Drawing.Size(320, 240);
            this.imgAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgAlt.TabIndex = 0;
            this.imgAlt.TabStop = false;
            // 
            // radioToolSelect
            // 
            this.radioToolSelect.AutoSize = true;
            this.radioToolSelect.Checked = true;
            this.radioToolSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioToolSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioToolSelect.Location = new System.Drawing.Point(320, 0);
            this.radioToolSelect.Name = "radioToolSelect";
            this.radioToolSelect.Size = new System.Drawing.Size(80, 17);
            this.radioToolSelect.TabIndex = 1;
            this.radioToolSelect.TabStop = true;
            this.radioToolSelect.Text = "Select";
            this.radioToolSelect.UseVisualStyleBackColor = true;
            this.radioToolSelect.CheckedChanged += new System.EventHandler(this.radioToolSelect_CheckedChanged);
            // 
            // radioToolDelet
            // 
            this.radioToolDelet.AutoSize = true;
            this.radioToolDelet.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioToolDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioToolDelet.Location = new System.Drawing.Point(320, 17);
            this.radioToolDelet.Name = "radioToolDelet";
            this.radioToolDelet.Size = new System.Drawing.Size(80, 17);
            this.radioToolDelet.TabIndex = 3;
            this.radioToolDelet.Text = "Delete";
            this.radioToolDelet.UseVisualStyleBackColor = true;
            this.radioToolDelet.CheckedChanged += new System.EventHandler(this.radioToolDelet_CheckedChanged);
            // 
            // radioToolEdit
            // 
            this.radioToolEdit.AutoSize = true;
            this.radioToolEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioToolEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioToolEdit.Location = new System.Drawing.Point(320, 34);
            this.radioToolEdit.Name = "radioToolEdit";
            this.radioToolEdit.Size = new System.Drawing.Size(80, 17);
            this.radioToolEdit.TabIndex = 4;
            this.radioToolEdit.Text = "Edit";
            this.radioToolEdit.UseVisualStyleBackColor = true;
            this.radioToolEdit.CheckedChanged += new System.EventHandler(this.radioToolEdit_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(320, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 21);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImage.Location = new System.Drawing.Point(320, 196);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(80, 23);
            this.btnOpenImage.TabIndex = 6;
            this.btnOpenImage.Text = "Select Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnBgsel
            // 
            this.btnBgsel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBgsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBgsel.Location = new System.Drawing.Point(320, 173);
            this.btnBgsel.Name = "btnBgsel";
            this.btnBgsel.Size = new System.Drawing.Size(80, 23);
            this.btnBgsel.TabIndex = 7;
            this.btnBgsel.Text = "Bg Color";
            this.btnBgsel.UseVisualStyleBackColor = true;
            this.btnBgsel.Click += new System.EventHandler(this.btnBgsel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(320, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSel.Location = new System.Drawing.Point(320, 83);
            this.lblSel.Name = "lblSel";
            this.lblSel.Size = new System.Drawing.Size(43, 52);
            this.lblSel.TabIndex = 9;
            this.lblSel.Text = "X: ???\r\nY: ???\r\nW: ???\r\nH: ???";
            // 
            // radioToolResize
            // 
            this.radioToolResize.AutoSize = true;
            this.radioToolResize.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioToolResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioToolResize.Location = new System.Drawing.Point(320, 51);
            this.radioToolResize.Name = "radioToolResize";
            this.radioToolResize.Size = new System.Drawing.Size(80, 17);
            this.radioToolResize.TabIndex = 10;
            this.radioToolResize.Text = "Resize";
            this.radioToolResize.UseVisualStyleBackColor = true;
            this.radioToolResize.CheckedChanged += new System.EventHandler(this.radioToolResize_CheckedChanged);
            // 
            // FormAltedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.radioToolResize);
            this.Controls.Add(this.lblSel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBgsel);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioToolEdit);
            this.Controls.Add(this.radioToolDelet);
            this.Controls.Add(this.radioToolSelect);
            this.Controls.Add(this.imgAlt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAltedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAltedit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAltedit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioToolSelect;
        private System.Windows.Forms.RadioButton radioToolDelet;
        private System.Windows.Forms.RadioButton radioToolEdit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnBgsel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSel;
        private System.Windows.Forms.RadioButton radioToolResize;
        public System.Windows.Forms.PictureBox imgAlt;
    }
}