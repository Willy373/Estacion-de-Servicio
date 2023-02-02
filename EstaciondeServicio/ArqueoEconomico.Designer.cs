﻿namespace EstaciondeServicio
{
    partial class ArqueoEconomico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArqueoEconomico));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fechor_actual = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_combustible = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_num_servicio = new System.Windows.Forms.Label();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.timerArqueoEconomico = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewArqueo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArqueo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(999, 39);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Red;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(996, 0);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(47, 39);
            this.btn_salir.TabIndex = 68;
            this.btn_salir.Text = "X";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-15, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1058, 39);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(701, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fechor_actual
            // 
            this.lbl_fechor_actual.AutoSize = true;
            this.lbl_fechor_actual.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_fechor_actual.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechor_actual.ForeColor = System.Drawing.Color.Black;
            this.lbl_fechor_actual.Location = new System.Drawing.Point(775, 641);
            this.lbl_fechor_actual.Name = "lbl_fechor_actual";
            this.lbl_fechor_actual.Size = new System.Drawing.Size(38, 23);
            this.lbl_fechor_actual.TabIndex = 76;
            this.lbl_fechor_actual.Text = "----";
            this.lbl_fechor_actual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_usuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_usuario.Location = new System.Drawing.Point(104, 642);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(38, 23);
            this.lbl_usuario.TabIndex = 77;
            this.lbl_usuario.Text = "----";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 78;
            this.label6.Text = "Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_combustible
            // 
            this.lbl_combustible.AutoSize = true;
            this.lbl_combustible.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_combustible.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_combustible.ForeColor = System.Drawing.Color.Black;
            this.lbl_combustible.Location = new System.Drawing.Point(27, 9);
            this.lbl_combustible.Name = "lbl_combustible";
            this.lbl_combustible.Size = new System.Drawing.Size(45, 23);
            this.lbl_combustible.TabIndex = 82;
            this.lbl_combustible.Text = "-----";
            this.lbl_combustible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(140, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "| Punto de Venta #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_num_servicio
            // 
            this.lbl_num_servicio.AutoSize = true;
            this.lbl_num_servicio.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_num_servicio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_servicio.ForeColor = System.Drawing.Color.Black;
            this.lbl_num_servicio.Location = new System.Drawing.Point(323, 8);
            this.lbl_num_servicio.Name = "lbl_num_servicio";
            this.lbl_num_servicio.Size = new System.Drawing.Size(38, 23);
            this.lbl_num_servicio.TabIndex = 84;
            this.lbl_num_servicio.Text = "----";
            this.lbl_num_servicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_menu.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.Black;
            this.lbl_menu.Location = new System.Drawing.Point(194, 42);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(619, 70);
            this.lbl_menu.TabIndex = 85;
            this.lbl_menu.Text = "ARQUEO ECONOMICO";
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btn_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.Location = new System.Drawing.Point(251, 573);
            this.btn_reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(435, 44);
            this.btn_reporte.TabIndex = 95;
            this.btn_reporte.Text = "IMPRIMIR ARQUEO ECONOMICO";
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // timerArqueoEconomico
            // 
            this.timerArqueoEconomico.Tick += new System.EventHandler(this.timerArqueoEconomico_Tick);
            // 
            // dataGridViewArqueo
            // 
            this.dataGridViewArqueo.AllowUserToAddRows = false;
            this.dataGridViewArqueo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArqueo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArqueo.ColumnHeadersHeight = 30;
            this.dataGridViewArqueo.EnableHeadersVisualStyles = false;
            this.dataGridViewArqueo.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewArqueo.Location = new System.Drawing.Point(13, 116);
            this.dataGridViewArqueo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewArqueo.MultiSelect = false;
            this.dataGridViewArqueo.Name = "dataGridViewArqueo";
            this.dataGridViewArqueo.ReadOnly = true;
            this.dataGridViewArqueo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArqueo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArqueo.RowHeadersWidth = 51;
            this.dataGridViewArqueo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewArqueo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewArqueo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewArqueo.RowTemplate.Height = 30;
            this.dataGridViewArqueo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArqueo.Size = new System.Drawing.Size(1015, 451);
            this.dataGridViewArqueo.TabIndex = 96;
            // 
            // ArqueoEconomico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1041, 670);
            this.Controls.Add(this.dataGridViewArqueo);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.lbl_num_servicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_combustible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_fechor_actual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArqueoEconomico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArqueoEconomico";
            this.Load += new System.EventHandler(this.ArqueoEconomico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArqueo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fechor_actual;
        public System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_combustible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_num_servicio;
        public System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Timer timerArqueoEconomico;
        private System.Windows.Forms.DataGridView dataGridViewArqueo;
    }
}