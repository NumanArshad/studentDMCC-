namespace StudentDMC
{
    partial class ShowDMC
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
            this.richtxtbxDMC = new System.Windows.Forms.RichTextBox();
            this.cmdCloseDMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richtxtbxDMC
            // 
            this.richtxtbxDMC.BackColor = System.Drawing.Color.White;
            this.richtxtbxDMC.Cursor = System.Windows.Forms.Cursors.No;
            this.richtxtbxDMC.Dock = System.Windows.Forms.DockStyle.Top;
            this.richtxtbxDMC.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtbxDMC.Location = new System.Drawing.Point(0, 0);
            this.richtxtbxDMC.Name = "richtxtbxDMC";
            this.richtxtbxDMC.ReadOnly = true;
            this.richtxtbxDMC.Size = new System.Drawing.Size(484, 302);
            this.richtxtbxDMC.TabIndex = 0;
            this.richtxtbxDMC.Text = "";
            // 
            // cmdCloseDMC
            // 
            this.cmdCloseDMC.BackColor = System.Drawing.Color.Black;
            this.cmdCloseDMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCloseDMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCloseDMC.ForeColor = System.Drawing.Color.White;
            this.cmdCloseDMC.Location = new System.Drawing.Point(21, 308);
            this.cmdCloseDMC.Name = "cmdCloseDMC";
            this.cmdCloseDMC.Size = new System.Drawing.Size(93, 29);
            this.cmdCloseDMC.TabIndex = 1;
            this.cmdCloseDMC.Text = "Close";
            this.cmdCloseDMC.UseVisualStyleBackColor = false;
            this.cmdCloseDMC.Click += new System.EventHandler(this.cmdCloseDMC_Click);
            // 
            // ShowDMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCloseDMC);
            this.Controls.Add(this.richtxtbxDMC);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ShowDMC";
            this.Text = "ShowDMC";
            this.Load += new System.EventHandler(this.ShowDMC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtbxDMC;
        private System.Windows.Forms.Button cmdCloseDMC;
    }
}