using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using GuarderiaCanina.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace GuarderiaCanina.InterfacesUsuario.Turno
{

    public partial class FrmDetalleTurno : Form
    {
        private readonly long IdTurno;
        private readonly string FechaDesde;
        private readonly string FechaHasta;
        private readonly int idCliente;
        private readonly int IdMascota;
        private readonly int IdEmpleado;
        private readonly int Monto;
        public FrmDetalleTurno(long idTurno, string fechaDesde, string fechaHasta, int idCli, int idMascota, int idEmpleado, int Monto)
        {
            this.IdTurno = idTurno;
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            this.idCliente = idCli;
            this.IdMascota = idMascota;
            this.IdEmpleado = idEmpleado;
            this.Monto = Monto;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmDetalleTurno_Load(object sender, EventArgs e)
        {
            var sqlmascota = $"select m.nombre from mascotas m, turno t where m.id_mascota = t.id_mascota and t.id_turno = {IdTurno}";
            DataTable resultadoMascota = DBHelper.GetDBHelper().ConsultaSQL(sqlmascota);
            var sqlempleado = $"select e.nombre from empleados e, turno t where e.id_empleado = t.id_empleado and t.id_turno = {IdEmpleado}";
            DataTable resultadoEmpleado = DBHelper.GetDBHelper().ConsultaSQL(sqlempleado);
            label9.Text = IdTurno.ToString(); 
            label10.Text = FechaDesde.ToString();
            label11.Text = FechaHasta.ToString();
            label12.Text = idCliente.ToString();
            label13.Text = resultadoMascota.ToString();
            //completar para que salga el nombre 
            label14.Text = resultadoEmpleado.ToString();
            //completar para que salga el nombre
            label15.Text = Monto.ToString(); 
            //completar no hay ningun servicio puesto
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            PdfFont fuenteTexto = new PdfStandardFont(PdfFontFamily.Helvetica, 14);

            graphics.DrawString("Generación de turno", font, PdfBrushes.Black, new PointF(0, 0));
            graphics.DrawString("Turno N°: ", fuenteTexto, PdfBrushes.Black, new PointF(0, 30));
            graphics.DrawString("Inicio de turno: ", fuenteTexto, PdfBrushes.Black, new PointF(0, 60));
            graphics.DrawString("Fin de turno: ", fuenteTexto, PdfBrushes.Black, new PointF(0, 90));
            graphics.DrawString("DNI Cliente: ", fuenteTexto, PdfBrushes.Black, new PointF(0, 120));
            graphics.DrawString("Mascota: ", fuenteTexto, PdfBrushes.Black, new PointF(0, 150));

            graphics.DrawString(IdTurno.ToString(), fuenteTexto, PdfBrushes.Black, new PointF(100, 30));
            graphics.DrawString(FechaDesde.ToString(), fuenteTexto, PdfBrushes.Black, new PointF(100, 60));
            graphics.DrawString(FechaHasta.ToString(), fuenteTexto, PdfBrushes.Black, new PointF(100, 90));
            graphics.DrawString(idCliente.ToString(), fuenteTexto, PdfBrushes.Black, new PointF(100, 120));
            graphics.DrawString(IdMascota.ToString(), fuenteTexto, PdfBrushes.Black, new PointF(100, 150));         
            document.Save(@"Escritorio\PDF.pdf");
            document.Close(true);
            MessageBox.Show("PDF Creado correctamente.", "Informacion", MessageBoxButtons.OK);
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
