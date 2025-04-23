
namespace test_1049
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbGrupa = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.btnDeserializare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Prezent";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbGrupa
            // 
            this.tbGrupa.Location = new System.Drawing.Point(105, 131);
            this.tbGrupa.Name = "tbGrupa";
            this.tbGrupa.Size = new System.Drawing.Size(100, 20);
            this.tbGrupa.TabIndex = 3;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(105, 79);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(105, 25);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grupa";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(46, 215);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 7;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.Location = new System.Drawing.Point(151, 215);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(75, 23);
            this.btnVizualizare.TabIndex = 8;
            this.btnVizualizare.Text = "Vizualizare";
            this.btnVizualizare.UseVisualStyleBackColor = true;
            this.btnVizualizare.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // btnDeserializare
            // 
            this.btnDeserializare.Location = new System.Drawing.Point(13, 179);
            this.btnDeserializare.Name = "btnDeserializare";
            this.btnDeserializare.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializare.TabIndex = 9;
            this.btnDeserializare.Text = "Deserializare";
            this.btnDeserializare.UseVisualStyleBackColor = true;
            this.btnDeserializare.Click += new System.EventHandler(this.btnDeserializare_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdauga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(275, 280);
            this.Controls.Add(this.btnDeserializare);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbGrupa);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbGrupa;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnVizualizare;
        private System.Windows.Forms.Button btnDeserializare;
    }
}

