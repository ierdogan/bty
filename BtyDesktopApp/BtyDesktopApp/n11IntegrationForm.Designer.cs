namespace BtyDesktopApp
{
    partial class n11IntegrationForm
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
            this.pgc1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.button1 = new System.Windows.Forms.Button();
            this.edsc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pgc1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgc1
            // 
            this.pgc1.Location = new System.Drawing.Point(12, 159);
            this.pgc1.Name = "pgc1";
            this.pgc1.Size = new System.Drawing.Size(785, 370);
            this.pgc1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "TopLevelCat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edsc
            // 
            this.edsc.Location = new System.Drawing.Point(112, 42);
            this.edsc.Name = "edsc";
            this.edsc.Size = new System.Drawing.Size(59, 20);
            this.edsc.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "SubCat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // n11IntegrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.edsc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgc1);
            this.Name = "n11IntegrationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pgc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pgc1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox edsc;
        private System.Windows.Forms.Button button2;
    }
}

