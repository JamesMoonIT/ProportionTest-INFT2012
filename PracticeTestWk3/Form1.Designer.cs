
namespace PracticeTestWk3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbxProportion = new System.Windows.Forms.TextBox();
            this.lblProportion = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.picbxDrawing = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // txbxProportion
            // 
            this.txbxProportion.Location = new System.Drawing.Point(186, 52);
            this.txbxProportion.Name = "txbxProportion";
            this.txbxProportion.Size = new System.Drawing.Size(100, 23);
            this.txbxProportion.TabIndex = 0;
            // 
            // lblProportion
            // 
            this.lblProportion.AutoSize = true;
            this.lblProportion.Location = new System.Drawing.Point(113, 55);
            this.lblProportion.Name = "lblProportion";
            this.lblProportion.Size = new System.Drawing.Size(67, 15);
            this.lblProportion.TabIndex = 1;
            this.lblProportion.Text = "Proportion:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(154, 96);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picbxDrawing
            // 
            this.picbxDrawing.Location = new System.Drawing.Point(96, 163);
            this.picbxDrawing.Name = "picbxDrawing";
            this.picbxDrawing.Size = new System.Drawing.Size(200, 100);
            this.picbxDrawing.TabIndex = 3;
            this.picbxDrawing.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.ForeColor = System.Drawing.Color.Maroon;
            this.lblResult.Location = new System.Drawing.Point(96, 334);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 40);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Please enter a proportion between 0.0 and 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picbxDrawing);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblProportion);
            this.Controls.Add(this.txbxProportion);
            this.Name = "Form1";
            this.Text = "Inft2012 practice test";
            ((System.ComponentModel.ISupportInitialize)(this.picbxDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxProportion;
        private System.Windows.Forms.Label lblProportion;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picbxDrawing;
        private System.Windows.Forms.Label lblResult;
    }
}

