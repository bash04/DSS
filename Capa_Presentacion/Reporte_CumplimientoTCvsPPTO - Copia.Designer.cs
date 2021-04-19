namespace Capa_Presentacion
{
    partial class Reporte_CumplimientoTCvsPPTO
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_meses = new System.Windows.Forms.ComboBox();
            this.ver_reporte_btn = new System.Windows.Forms.Button();
            this.reporteCumplimientoTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoCumplimientoTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCumplimientoTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCumplimientoTCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.Reporte_Cump_TC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(163, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(904, 620);
            this.reportViewer1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label5.Location = new System.Drawing.Point(48, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "MES";
            // 
            // combo_meses
            // 
            this.combo_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_meses.FormattingEnabled = true;
            this.combo_meses.Location = new System.Drawing.Point(12, 75);
            this.combo_meses.Name = "combo_meses";
            this.combo_meses.Size = new System.Drawing.Size(122, 33);
            this.combo_meses.TabIndex = 55;
            // 
            // ver_reporte_btn
            // 
            this.ver_reporte_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ver_reporte_btn.FlatAppearance.BorderSize = 0;
            this.ver_reporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver_reporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_reporte_btn.ForeColor = System.Drawing.Color.White;
            this.ver_reporte_btn.Location = new System.Drawing.Point(12, 144);
            this.ver_reporte_btn.Name = "ver_reporte_btn";
            this.ver_reporte_btn.Size = new System.Drawing.Size(122, 35);
            this.ver_reporte_btn.TabIndex = 57;
            this.ver_reporte_btn.Text = "Ver Reporte";
            this.ver_reporte_btn.UseVisualStyleBackColor = false;
            this.ver_reporte_btn.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // reporteCumplimientoTCBindingSource
            // 
            this.reporteCumplimientoTCBindingSource.DataSource = typeof(Capa_Negocio.ReporteCumplimientoTC);
            // 
            // listadoCumplimientoTCBindingSource
            // 
            this.listadoCumplimientoTCBindingSource.DataSource = typeof(Capa_Negocio.ListadoCumplimientoTC);
            // 
            // Reporte_CumplimientoTCvsPPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1068, 635);
            this.Controls.Add(this.ver_reporte_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_meses);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_CumplimientoTCvsPPTO";
            this.Text = "Reporte_CumplimientoTCvsPPTO";
            this.Load += new System.EventHandler(this.Reporte_CumplimientoTCvsPPTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCumplimientoTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCumplimientoTCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteCumplimientoTCBindingSource;
        private System.Windows.Forms.BindingSource listadoCumplimientoTCBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_meses;
        private System.Windows.Forms.Button ver_reporte_btn;
    }
}