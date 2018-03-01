using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
namespace Tarea2
{
    public partial class Tarea2 : Form
    {
        XmlSerializer Xml;
        List<Agenda> Listaagenda;
        public Tarea2()
        {
            InitializeComponent();
            Xml = new XmlSerializer(typeof(List<Agenda>));
            Listaagenda = new List<Agenda>();
        }
        private void datos(FileStream archivo)
        {
            BinaryReader leerBMP = new BinaryReader(archivo);
            if (archivo.ReadByte() == 66 && archivo.ReadByte() == 77)
            {
                textBox_mostrarBMP.Text = "Tamaño: " + leerBMP.ReadInt32().ToString() + "\r\n";
                archivo.Seek(12, SeekOrigin.Current);
                textBox_mostrarBMP.Text += "Ancho: " + leerBMP.ReadInt32().ToString() + "\r\n";
                textBox_mostrarBMP.Text += "Alto: " + leerBMP.ReadInt32().ToString() + "\r\n";
                archivo.Seek(2, SeekOrigin.Current);
                textBox_mostrarBMP.Text += "Pixel: " + leerBMP.ReadInt32().ToString() + "\r\n";
            }
            else
            {
                textBox_mostrarBMP.Text = "El archivo seleccionado no es BMP";
            }
            leerBMP.Close();
            archivo.Close();
        }
        private void button_BMP_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream archivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            datos(archivo);
        }

        private void button_agendar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivo Xml (*.xml)|*.xml ";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Agenda agenda = new Agenda();
                agenda.Nombre = textBox_nombre.Text;
                agenda.Lugar = textBox_fecha.Text;
                agenda.Numtf = textBox_numtf.Text;
                agenda.Fecha = textBox_fecha.Text;
                agenda.Motivo = textBox_motivo.Text;
                XmlSave.SaveData(agenda, saveFileDialog1.FileName);
            }
        }
    }
    public class Agenda
    {
        private string _Nombre;
        private string _Lugar;
        private string _Numtf;
        private string _Fecha;
        private string _Motivo;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Lugar
        {
            get { return _Lugar; }
            set { _Lugar = value; }
        }
        public string Numtf
        {
            get { return _Numtf; }
            set { _Numtf = value; }
        }
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value; }
        }

    }
}
