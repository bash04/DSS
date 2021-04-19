namespace Capa_Presentacion
{
    partial class Reporte_CumplimientoTCvsPPTO_xTipo
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
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteCumplimientoTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadoCumplimientoTCxTipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCumplimientoTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCumplimientoTCxTipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.listadoCumplimientoTCxTipoBindingSource, "ejec_estandar", true));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reportes.Reporte_Cump_TC_xTipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(204, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(889, 452);
            this.reportViewer1.TabIndex = 1;
            // 
            // reporteCumplimientoTCBindingSource
            // 
            this.reporteCumplimientoTCBindingSource.DataSource = typeof(Capa_Negocio.ReporteCumplimientoTC);
            // 
            // listadoCumplimientoTCxTipoBindingSource
            // 
            this.listadoCumplimientoTCxTipoBindingSource.DataSource = typeof(Capa_Negocio.ListadoCumplimientoTCxTipo);
            // 
            // Reporte_CumplimientoTCvsPPTO_xTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 594);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "Reporte_CumplimientoTCvsPPTO_xTipo";
            this.Text = "Reporte_CumplimientoTCvsPPTO_xTipo";
            this.Load += new System.EventHandler(this.Reporte_CumplimientoTCvsPPTO_xTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteCumplimientoTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoCumplimientoTCxTipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteCumplimientoTCBindingSource;
        private System.Windows.Forms.BindingSource listadoCumplimientoTCxTipoBindingSource;
    }
}