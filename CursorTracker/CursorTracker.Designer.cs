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
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.Location = new System.Drawing.Point(63, 53);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(104, 44);
            this.lbly.TabIndex = 2;
            this.lbly.Text = "0000";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.Location = new System.Drawing.Point(63, 9);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(104, 44);
            this.lblx.TabIndex = 3;
            this.lblx.Text = "0000";
            // 
            // CursorTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 109);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.MaximumSize = new System.Drawing.Size(202, 148);
            this.MinimumSize = new System.Drawing.Size(202, 148);
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

    }
    
}

