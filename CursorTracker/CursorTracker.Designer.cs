namespace CursorTracker
{
    partial class CursorTracker
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
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.redlbl = new System.Windows.Forms.Label();
            this.greenlbl = new System.Windows.Forms.Label();
            this.bluelbl = new System.Windows.Forms.Label();
            this.redval = new System.Windows.Forms.Label();
            this.greenval = new System.Windows.Forms.Label();
            this.blueval = new System.Windows.Forms.Label();
            this.colordisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(12, 9);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(45, 44);
            this.x.TabIndex = 0;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(12, 53);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(43, 44);
            this.y.TabIndex = 1;
            this.y.Text = "Y";
            // 
            // lbly
            // 
            this.lbly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbly.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.Location = new System.Drawing.Point(61, 53);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(107, 44);
            this.lbly.TabIndex = 2;
            this.lbly.Text = "0000";
            this.lbly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblx
            // 
            this.lblx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblx.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.Location = new System.Drawing.Point(61, 9);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(107, 44);
            this.lblx.TabIndex = 3;
            this.lblx.Text = "0000";
            this.lblx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redlbl
            // 
            this.redlbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redlbl.Location = new System.Drawing.Point(12, 138);
            this.redlbl.Name = "redlbl";
            this.redlbl.Size = new System.Drawing.Size(96, 28);
            this.redlbl.TabIndex = 5;
            this.redlbl.Text = "Red:";
            // 
            // greenlbl
            // 
            this.greenlbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenlbl.Location = new System.Drawing.Point(12, 166);
            this.greenlbl.Name = "greenlbl";
            this.greenlbl.Size = new System.Drawing.Size(96, 28);
            this.greenlbl.TabIndex = 6;
            this.greenlbl.Text = "Green: ";
            // 
            // bluelbl
            // 
            this.bluelbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluelbl.Location = new System.Drawing.Point(12, 194);
            this.bluelbl.Name = "bluelbl";
            this.bluelbl.Size = new System.Drawing.Size(96, 28);
            this.bluelbl.TabIndex = 7;
            this.bluelbl.Text = "Blue: ";
            // 
            // redval
            // 
            this.redval.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redval.Location = new System.Drawing.Point(114, 138);
            this.redval.Name = "redval";
            this.redval.Size = new System.Drawing.Size(96, 28);
            this.redval.TabIndex = 8;
            this.redval.Text = "000";
            // 
            // greenval
            // 
            this.greenval.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenval.Location = new System.Drawing.Point(114, 166);
            this.greenval.Name = "greenval";
            this.greenval.Size = new System.Drawing.Size(96, 28);
            this.greenval.TabIndex = 9;
            this.greenval.Text = "000";
            // 
            // blueval
            // 
            this.blueval.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueval.Location = new System.Drawing.Point(114, 194);
            this.blueval.Name = "blueval";
            this.blueval.Size = new System.Drawing.Size(96, 28);
            this.blueval.TabIndex = 10;
            this.blueval.Text = "000";
            // 
            // colordisplay
            // 
            this.colordisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colordisplay.BackColor = System.Drawing.Color.Red;
            this.colordisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colordisplay.Location = new System.Drawing.Point(17, 106);
            this.colordisplay.Name = "colordisplay";
            this.colordisplay.Size = new System.Drawing.Size(151, 22);
            this.colordisplay.TabIndex = 11;
            // 
            // CursorTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 228);
            this.Controls.Add(this.colordisplay);
            this.Controls.Add(this.blueval);
            this.Controls.Add(this.greenval);
            this.Controls.Add(this.redval);
            this.Controls.Add(this.bluelbl);
            this.Controls.Add(this.greenlbl);
            this.Controls.Add(this.redlbl);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.MaximumSize = new System.Drawing.Size(196, 267);
            this.MinimumSize = new System.Drawing.Size(196, 267);
            this.Name = "CursorTracker";
            this.RightToLeftLayout = true;
            this.Text = "CursorTracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label redlbl;
        private System.Windows.Forms.Label greenlbl;
        private System.Windows.Forms.Label bluelbl;
        private System.Windows.Forms.Label redval;
        private System.Windows.Forms.Label greenval;
        private System.Windows.Forms.Label blueval;
        private System.Windows.Forms.Label colordisplay;
    }
    
}

