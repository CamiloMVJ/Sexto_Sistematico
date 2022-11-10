namespace SextoSistematico
{
    partial class frmMultiUsos
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
            this.scDivididor = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFiccion = new System.Windows.Forms.Button();
            this.btnRomance = new System.Windows.Forms.Button();
            this.btnTerror = new System.Windows.Forms.Button();
            this.btnFantasia = new System.Windows.Forms.Button();
            this.btnEspirituales = new System.Windows.Forms.Button();
            this.btnThrillers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scDivididor)).BeginInit();
            this.scDivididor.Panel1.SuspendLayout();
            this.scDivididor.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scDivididor
            // 
            this.scDivididor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDivididor.IsSplitterFixed = true;
            this.scDivididor.Location = new System.Drawing.Point(0, 0);
            this.scDivididor.Name = "scDivididor";
            // 
            // scDivididor.Panel1
            // 
            this.scDivididor.Panel1.AutoScroll = true;
            this.scDivididor.Panel1.BackColor = System.Drawing.Color.White;
            this.scDivididor.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // scDivididor.Panel2
            // 
            this.scDivididor.Panel2.AutoScroll = true;
            this.scDivididor.Panel2.BackColor = System.Drawing.Color.Linen;
            this.scDivididor.Size = new System.Drawing.Size(800, 531);
            this.scDivididor.SplitterDistance = 163;
            this.scDivididor.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFiccion);
            this.flowLayoutPanel1.Controls.Add(this.btnRomance);
            this.flowLayoutPanel1.Controls.Add(this.btnTerror);
            this.flowLayoutPanel1.Controls.Add(this.btnFantasia);
            this.flowLayoutPanel1.Controls.Add(this.btnEspirituales);
            this.flowLayoutPanel1.Controls.Add(this.btnThrillers);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 401);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnFiccion
            // 
            this.btnFiccion.BackColor = System.Drawing.Color.Silver;
            this.btnFiccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiccion.Location = new System.Drawing.Point(3, 3);
            this.btnFiccion.Name = "btnFiccion";
            this.btnFiccion.Size = new System.Drawing.Size(150, 59);
            this.btnFiccion.TabIndex = 13;
            this.btnFiccion.Text = "Ciencia Ficción";
            this.btnFiccion.UseVisualStyleBackColor = false;
            this.btnFiccion.Click += new System.EventHandler(this.btnFiccion_Click);
            this.btnFiccion.MouseEnter += new System.EventHandler(this.btnFiccion_MouseEnter);
            this.btnFiccion.MouseLeave += new System.EventHandler(this.btnFiccion_MouseLeave);
            // 
            // btnRomance
            // 
            this.btnRomance.BackColor = System.Drawing.Color.Silver;
            this.btnRomance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRomance.Location = new System.Drawing.Point(3, 68);
            this.btnRomance.Name = "btnRomance";
            this.btnRomance.Size = new System.Drawing.Size(150, 59);
            this.btnRomance.TabIndex = 8;
            this.btnRomance.Text = "Romance";
            this.btnRomance.UseVisualStyleBackColor = false;
            this.btnRomance.Click += new System.EventHandler(this.button1_Click);
            this.btnRomance.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnRomance.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnTerror
            // 
            this.btnTerror.BackColor = System.Drawing.Color.Silver;
            this.btnTerror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerror.Location = new System.Drawing.Point(3, 133);
            this.btnTerror.Name = "btnTerror";
            this.btnTerror.Size = new System.Drawing.Size(150, 59);
            this.btnTerror.TabIndex = 12;
            this.btnTerror.Text = "Terror";
            this.btnTerror.UseVisualStyleBackColor = false;
            this.btnTerror.Click += new System.EventHandler(this.btnTerror_Click);
            this.btnTerror.MouseEnter += new System.EventHandler(this.btnTerror_MouseEnter);
            this.btnTerror.MouseLeave += new System.EventHandler(this.btnTerror_MouseLeave);
            // 
            // btnFantasia
            // 
            this.btnFantasia.BackColor = System.Drawing.Color.Silver;
            this.btnFantasia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFantasia.Location = new System.Drawing.Point(3, 198);
            this.btnFantasia.Name = "btnFantasia";
            this.btnFantasia.Size = new System.Drawing.Size(150, 59);
            this.btnFantasia.TabIndex = 11;
            this.btnFantasia.Text = "Fantasía";
            this.btnFantasia.UseVisualStyleBackColor = false;
            this.btnFantasia.Click += new System.EventHandler(this.btnFantasia_Click);
            this.btnFantasia.MouseEnter += new System.EventHandler(this.btnFantasia_MouseEnter);
            this.btnFantasia.MouseLeave += new System.EventHandler(this.btnFantasia_MouseLeave);
            // 
            // btnEspirituales
            // 
            this.btnEspirituales.BackColor = System.Drawing.Color.Silver;
            this.btnEspirituales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspirituales.Location = new System.Drawing.Point(3, 263);
            this.btnEspirituales.Name = "btnEspirituales";
            this.btnEspirituales.Size = new System.Drawing.Size(150, 59);
            this.btnEspirituales.TabIndex = 10;
            this.btnEspirituales.Text = "Espirituales";
            this.btnEspirituales.UseVisualStyleBackColor = false;
            this.btnEspirituales.Click += new System.EventHandler(this.btnEspirituales_Click);
            this.btnEspirituales.MouseEnter += new System.EventHandler(this.btnEspirituales_MouseEnter);
            this.btnEspirituales.MouseLeave += new System.EventHandler(this.btnEspirituales_MouseLeave);
            // 
            // btnThrillers
            // 
            this.btnThrillers.BackColor = System.Drawing.Color.Silver;
            this.btnThrillers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThrillers.Location = new System.Drawing.Point(3, 328);
            this.btnThrillers.Name = "btnThrillers";
            this.btnThrillers.Size = new System.Drawing.Size(150, 59);
            this.btnThrillers.TabIndex = 9;
            this.btnThrillers.Text = "Thrillers";
            this.btnThrillers.UseVisualStyleBackColor = false;
            this.btnThrillers.Click += new System.EventHandler(this.btnThrillers_Click);
            this.btnThrillers.MouseEnter += new System.EventHandler(this.btnThrillers_MouseEnter);
            this.btnThrillers.MouseLeave += new System.EventHandler(this.btnThrillers_MouseLeave);
            // 
            // frmMultiUsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.scDivididor);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmMultiUsos";
            this.Text = "Biblioteca";
            this.scDivididor.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDivididor)).EndInit();
            this.scDivididor.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer scDivididor;
        private Button btnFiccion;
        private Button btnTerror;
        private Button btnFantasia;
        private Button btnEspirituales;
        private Button btnThrillers;
        private Button btnRomance;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}