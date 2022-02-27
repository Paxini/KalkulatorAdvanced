
namespace KalkulatorAdvanced
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.rt2 = new System.Windows.Forms.RichTextBox();
            this.rt3 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.broj1Minus = new System.Windows.Forms.RadioButton();
            this.broj1Plus = new System.Windows.Forms.RadioButton();
            this.broj2Minus = new System.Windows.Forms.RadioButton();
            this.broj2Plus = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaberi = new System.Windows.Forms.Button();
            this.buttonOduzmi = new System.Windows.Forms.Button();
            this.buttonPomnozi = new System.Windows.Forms.Button();
            this.buttonPodeli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rimskiSaberi = new System.Windows.Forms.Button();
            this.rimskiMinus = new System.Windows.Forms.Button();
            this.rimskiPodeli = new System.Windows.Forms.Button();
            this.rimskiPomnozi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.importToolStripMenuItem.Text = "Save";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exportToolStripMenuItem.Text = "Save As";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.importToolStripMenuItem1.Text = "Import";
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.ImportToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rt1
            // 
            this.rt1.Location = new System.Drawing.Point(125, 73);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(1046, 67);
            this.rt1.TabIndex = 1;
            this.rt1.Text = "";
            // 
            // rt2
            // 
            this.rt2.Location = new System.Drawing.Point(125, 183);
            this.rt2.Name = "rt2";
            this.rt2.Size = new System.Drawing.Size(1046, 67);
            this.rt2.TabIndex = 2;
            this.rt2.Text = "";
            // 
            // rt3
            // 
            this.rt3.Location = new System.Drawing.Point(125, 350);
            this.rt3.Name = "rt3";
            this.rt3.Size = new System.Drawing.Size(1046, 115);
            this.rt3.TabIndex = 3;
            this.rt3.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.broj1Minus);
            this.panel1.Controls.Add(this.broj1Plus);
            this.panel1.Location = new System.Drawing.Point(40, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 67);
            this.panel1.TabIndex = 6;
            // 
            // broj1Minus
            // 
            this.broj1Minus.AutoSize = true;
            this.broj1Minus.Location = new System.Drawing.Point(11, 31);
            this.broj1Minus.Name = "broj1Minus";
            this.broj1Minus.Size = new System.Drawing.Size(28, 17);
            this.broj1Minus.TabIndex = 1;
            this.broj1Minus.TabStop = true;
            this.broj1Minus.Text = "-";
            this.broj1Minus.UseVisualStyleBackColor = true;
            // 
            // broj1Plus
            // 
            this.broj1Plus.AutoSize = true;
            this.broj1Plus.Location = new System.Drawing.Point(11, 8);
            this.broj1Plus.Name = "broj1Plus";
            this.broj1Plus.Size = new System.Drawing.Size(31, 17);
            this.broj1Plus.TabIndex = 0;
            this.broj1Plus.TabStop = true;
            this.broj1Plus.Text = "+";
            this.broj1Plus.UseVisualStyleBackColor = true;
            // 
            // broj2Minus
            // 
            this.broj2Minus.AutoSize = true;
            this.broj2Minus.Location = new System.Drawing.Point(11, 31);
            this.broj2Minus.Name = "broj2Minus";
            this.broj2Minus.Size = new System.Drawing.Size(28, 17);
            this.broj2Minus.TabIndex = 1;
            this.broj2Minus.TabStop = true;
            this.broj2Minus.Text = "-";
            this.broj2Minus.UseVisualStyleBackColor = true;
            // 
            // broj2Plus
            // 
            this.broj2Plus.AutoSize = true;
            this.broj2Plus.Location = new System.Drawing.Point(11, 8);
            this.broj2Plus.Name = "broj2Plus";
            this.broj2Plus.Size = new System.Drawing.Size(31, 17);
            this.broj2Plus.TabIndex = 0;
            this.broj2Plus.TabStop = true;
            this.broj2Plus.Text = "+";
            this.broj2Plus.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.broj2Minus);
            this.panel2.Controls.Add(this.broj2Plus);
            this.panel2.Location = new System.Drawing.Point(40, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 67);
            this.panel2.TabIndex = 7;
            // 
            // buttonSaberi
            // 
            this.buttonSaberi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaberi.Location = new System.Drawing.Point(336, 281);
            this.buttonSaberi.Name = "buttonSaberi";
            this.buttonSaberi.Size = new System.Drawing.Size(137, 44);
            this.buttonSaberi.TabIndex = 9;
            this.buttonSaberi.Text = "+";
            this.buttonSaberi.UseVisualStyleBackColor = true;
            this.buttonSaberi.Click += new System.EventHandler(this.buttonSaberi_Click);
            // 
            // buttonOduzmi
            // 
            this.buttonOduzmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOduzmi.Location = new System.Drawing.Point(479, 281);
            this.buttonOduzmi.Name = "buttonOduzmi";
            this.buttonOduzmi.Size = new System.Drawing.Size(137, 44);
            this.buttonOduzmi.TabIndex = 10;
            this.buttonOduzmi.Text = "-";
            this.buttonOduzmi.UseVisualStyleBackColor = true;
            this.buttonOduzmi.Click += new System.EventHandler(this.buttonOduzmi_Click);
            // 
            // buttonPomnozi
            // 
            this.buttonPomnozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPomnozi.Location = new System.Drawing.Point(622, 281);
            this.buttonPomnozi.Name = "buttonPomnozi";
            this.buttonPomnozi.Size = new System.Drawing.Size(137, 44);
            this.buttonPomnozi.TabIndex = 11;
            this.buttonPomnozi.Text = "×";
            this.buttonPomnozi.UseVisualStyleBackColor = true;
            this.buttonPomnozi.Click += new System.EventHandler(this.buttonPomnozi_Click);
            // 
            // buttonPodeli
            // 
            this.buttonPodeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPodeli.Location = new System.Drawing.Point(765, 281);
            this.buttonPodeli.Name = "buttonPodeli";
            this.buttonPodeli.Size = new System.Drawing.Size(137, 44);
            this.buttonPodeli.TabIndex = 12;
            this.buttonPodeli.Text = "/";
            this.buttonPodeli.UseVisualStyleBackColor = true;
            this.buttonPodeli.Click += new System.EventHandler(this.buttonPodeli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 73);
            this.label2.TabIndex = 14;
            this.label2.Text = "-";
            this.label2.Visible = false;
            // 
            // rimskiSaberi
            // 
            this.rimskiSaberi.Location = new System.Drawing.Point(918, 281);
            this.rimskiSaberi.Name = "rimskiSaberi";
            this.rimskiSaberi.Size = new System.Drawing.Size(30, 22);
            this.rimskiSaberi.TabIndex = 15;
            this.rimskiSaberi.Text = "+";
            this.rimskiSaberi.UseVisualStyleBackColor = true;
            this.rimskiSaberi.Click += new System.EventHandler(this.rimskiSaberi_Click);
            // 
            // rimskiMinus
            // 
            this.rimskiMinus.Location = new System.Drawing.Point(918, 303);
            this.rimskiMinus.Name = "rimskiMinus";
            this.rimskiMinus.Size = new System.Drawing.Size(30, 22);
            this.rimskiMinus.TabIndex = 16;
            this.rimskiMinus.Text = "-";
            this.rimskiMinus.UseVisualStyleBackColor = true;
            this.rimskiMinus.Click += new System.EventHandler(this.rimskiMinus_Click);
            // 
            // rimskiPodeli
            // 
            this.rimskiPodeli.Location = new System.Drawing.Point(954, 303);
            this.rimskiPodeli.Name = "rimskiPodeli";
            this.rimskiPodeli.Size = new System.Drawing.Size(30, 22);
            this.rimskiPodeli.TabIndex = 18;
            this.rimskiPodeli.Text = "/";
            this.rimskiPodeli.UseVisualStyleBackColor = true;
            this.rimskiPodeli.Click += new System.EventHandler(this.rimskiPodeli_Click);
            // 
            // rimskiPomnozi
            // 
            this.rimskiPomnozi.Location = new System.Drawing.Point(954, 281);
            this.rimskiPomnozi.Name = "rimskiPomnozi";
            this.rimskiPomnozi.Size = new System.Drawing.Size(30, 22);
            this.rimskiPomnozi.TabIndex = 17;
            this.rimskiPomnozi.Text = "×";
            this.rimskiPomnozi.UseVisualStyleBackColor = true;
            this.rimskiPomnozi.Click += new System.EventHandler(this.rimskiPomnozi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 525);
            this.Controls.Add(this.rimskiPodeli);
            this.Controls.Add(this.rimskiPomnozi);
            this.Controls.Add(this.rimskiMinus);
            this.Controls.Add(this.rimskiSaberi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPodeli);
            this.Controls.Add(this.buttonPomnozi);
            this.Controls.Add(this.buttonOduzmi);
            this.Controls.Add(this.buttonSaberi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rt3);
            this.Controls.Add(this.rt2);
            this.Controls.Add(this.rt1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.RichTextBox rt2;
        private System.Windows.Forms.RichTextBox rt3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton broj1Plus;
        private System.Windows.Forms.RadioButton broj1Minus;
        private System.Windows.Forms.RadioButton broj2Minus;
        private System.Windows.Forms.RadioButton broj2Plus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSaberi;
        private System.Windows.Forms.Button buttonOduzmi;
        private System.Windows.Forms.Button buttonPomnozi;
        private System.Windows.Forms.Button buttonPodeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rimskiSaberi;
        private System.Windows.Forms.Button rimskiMinus;
        private System.Windows.Forms.Button rimskiPodeli;
        private System.Windows.Forms.Button rimskiPomnozi;
    }
}

