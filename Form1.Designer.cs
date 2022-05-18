namespace PokemonTypeCombos
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.richtxtbx = new System.Windows.Forms.RichTextBox();
            this.cmbx1 = new System.Windows.Forms.ComboBox();
            this.cmbx2 = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(332, 216);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(179, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // richtxtbx
            // 
            this.richtxtbx.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richtxtbx.Location = new System.Drawing.Point(35, 273);
            this.richtxtbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richtxtbx.Name = "richtxtbx";
            this.richtxtbx.Size = new System.Drawing.Size(741, 154);
            this.richtxtbx.TabIndex = 1;
            this.richtxtbx.Text = "";
            // 
            // cmbx1
            // 
            this.cmbx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbx1.BackColor = System.Drawing.SystemColors.Window;
            this.cmbx1.DropDownHeight = 150;
            this.cmbx1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbx1.FormattingEnabled = true;
            this.cmbx1.IntegralHeight = false;
            this.cmbx1.ItemHeight = 37;
            this.cmbx1.Location = new System.Drawing.Point(286, 52);
            this.cmbx1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbx1.Name = "cmbx1";
            this.cmbx1.Size = new System.Drawing.Size(254, 45);
            this.cmbx1.TabIndex = 2;
            this.cmbx1.Text = "Select Primary Type:";
            // 
            // cmbx2
            // 
            this.cmbx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbx2.DropDownHeight = 150;
            this.cmbx2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbx2.FormattingEnabled = true;
            this.cmbx2.IntegralHeight = false;
            this.cmbx2.Location = new System.Drawing.Point(286, 148);
            this.cmbx2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbx2.Name = "cmbx2";
            this.cmbx2.Size = new System.Drawing.Size(254, 45);
            this.cmbx2.TabIndex = 3;
            this.cmbx2.Text = "Select Secondary Type:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(321, 9);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(244, 37);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Enter Primary Type:";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(296, 106);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(284, 37);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Enter Secondary Type: ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(828, 453);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmbx2);
            this.Controls.Add(this.cmbx1);
            this.Controls.Add(this.richtxtbx);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Pokemon Type Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalculate;
        private RichTextBox richtxtbx;
        private ComboBox cmbx1;
        private ComboBox cmbx2;
        private Label lbl1;
        private Label lbl2;
    }
}