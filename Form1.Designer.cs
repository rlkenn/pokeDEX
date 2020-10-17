namespace pokeDEX
{
    partial class Form1
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
            this.txtPokéName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgPokeBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReadOnly1 = new System.Windows.Forms.TextBox();
            this.txtReadOnly2 = new System.Windows.Forms.TextBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokeBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPokéName
            // 
            this.txtPokéName.Location = new System.Drawing.Point(23, 36);
            this.txtPokéName.Name = "txtPokéName";
            this.txtPokéName.Size = new System.Drawing.Size(147, 20);
            this.txtPokéName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Pokémon Name:";
            // 
            // imgPokeBox1
            // 
            this.imgPokeBox1.Location = new System.Drawing.Point(6, 18);
            this.imgPokeBox1.Name = "imgPokeBox1";
            this.imgPokeBox1.Size = new System.Drawing.Size(81, 68);
            this.imgPokeBox1.TabIndex = 2;
            this.imgPokeBox1.TabStop = false;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGo.Location = new System.Drawing.Point(176, 19);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(60, 37);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Search";
            this.buttonGo.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReadOnly2);
            this.groupBox1.Controls.Add(this.txtReadOnly1);
            this.groupBox1.Controls.Add(this.imgPokeBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results:";
            // 
            // txtReadOnly1
            // 
            this.txtReadOnly1.Location = new System.Drawing.Point(92, 19);
            this.txtReadOnly1.Multiline = true;
            this.txtReadOnly1.Name = "txtReadOnly1";
            this.txtReadOnly1.ReadOnly = true;
            this.txtReadOnly1.Size = new System.Drawing.Size(92, 67);
            this.txtReadOnly1.TabIndex = 3;
            // 
            // txtReadOnly2
            // 
            this.txtReadOnly2.Location = new System.Drawing.Point(6, 94);
            this.txtReadOnly2.Multiline = true;
            this.txtReadOnly2.Name = "txtReadOnly2";
            this.txtReadOnly2.ReadOnly = true;
            this.txtReadOnly2.Size = new System.Drawing.Size(177, 89);
            this.txtReadOnly2.TabIndex = 4;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Arial", 8F);
            this.buttonPrev.Location = new System.Drawing.Point(58, 250);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(52, 24);
            this.buttonPrev.TabIndex = 8;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Arial", 8F);
            this.buttonNext.Location = new System.Drawing.Point(115, 250);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(55, 24);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 315);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPokéName);
            this.Name = "Form1";
            this.Text = "pokéDEX!";
            ((System.ComponentModel.ISupportInitialize)(this.imgPokeBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPokéName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgPokeBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReadOnly1;
        private System.Windows.Forms.TextBox txtReadOnly2;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
    }
}

