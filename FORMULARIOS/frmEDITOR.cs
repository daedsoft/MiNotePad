using MiNotePad.CLASES;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiNotePad
{
    public partial class frmEDITOR : Form
    {

        int Tam = 14; //contador para el tamaño de la letra

        public frmEDITOR()
        {
            InitializeComponent();

            try
            {
                MiNotePadAcciones.SetArchivoOriginal(MiNotePadAcciones.GetRutaRecibida()); //= File.ReadAllText(Acciones.GetRutaRecibida);

                this.Text = $"Mi NotePad {MiNotePadAcciones.GetTitulo()}";

                lbESTADO.Text = MiNotePadAcciones.GetEstado();
            }
            catch { }
        }

        private void frmEDITOR_Load(object sender, EventArgs e)
        {
            try 
            {
                RichTextBox.Text = File.ReadAllText(MiNotePadAcciones.GetRutaRecibida());
                RichTextBox.Focus();
            }
            catch { }
        }

        private void btNUEVO_Click(object sender, EventArgs e)
        {
            MiNotePadAcciones.Nuevo();
        }


        private void btABRIR_Click(object sender, EventArgs e)
        {
            if (lbESTADO.Text == "Archivo modificado (sin guardar).")
            {
                DialogResult dialogResult = MessageBox.Show("Si crea abre otro archivo se perderán los cambios realizados. " +
                                                            "¿Desea continuar?", "Abrir otro archivo",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    MiNotePadAcciones.Abrir();

                    RichTextBox.Text = MiNotePadAcciones.GetArchivoLeido();
                    this.Text = MiNotePadAcciones.GetTitulo();
                    lbESTADO.Text = MiNotePadAcciones.GetEstado();
                    RichTextBox.Focus();
                }
            }
            else
            {
                MiNotePadAcciones.Abrir();

                RichTextBox.Text = MiNotePadAcciones.GetArchivoLeido();
                this.Text = MiNotePadAcciones.GetTitulo();
                lbESTADO.Text = MiNotePadAcciones.GetEstado();
                RichTextBox.Focus();
            }
        }

        private void btGUARDAR_Click(object sender, EventArgs e)
        {
            MiNotePadAcciones.Guardar(MiNotePadAcciones.GetRutaRecibida(), RichTextBox.Text);
            this.Text = MiNotePadAcciones.GetTitulo();
            lbESTADO.Text = MiNotePadAcciones.GetEstado();
            RichTextBox.Focus();            
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (MiNotePadAcciones.GetArchivoOriginal() != RichTextBox.Text) 
            {
                MiNotePadAcciones.SetEstado("Archivo modificado (sin guardar).");
                lbESTADO.Text = MiNotePadAcciones.GetEstado();
            }
        }
                
        private void btZOOM_IN_Click(object sender, EventArgs e)
        {            
            if (Tam < 48)
            {
                Tam += 4;
                RichTextBox.Font = new Font("Segoe UI", Tam);
            }
        }

        private void btZOOM_OUT_Click(object sender, EventArgs e)
        {            
            if (Tam > 8)
            {
                Tam -= 4;
                RichTextBox.Font = new Font("Segoe UI", Tam);
            }
        }

        //
        // BUSCAR
        //
        private void btBUSCAR_Click(object sender, EventArgs e)
        {
            panelBUSCAR.Visible = true;
            txBUSCAR.Focus();
        }

        private void lbCerrar_Click(object sender, EventArgs e)
        {
            txBUSCAR.Text = string.Empty;
            panelBUSCAR.Visible = false;
        }

        private void txBUSCAR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                int i = RichTextBox.SelectionStart;

                try
                {
                    var Pos = MiNotePadAcciones.Buscar(txBUSCAR.Text, i, RichTextBox);
                    RichTextBox.Focus();
                    RichTextBox.SelectionStart = Pos;
                    RichTextBox.SelectionLength = txBUSCAR.TextLength;
                }
                catch
                {
                    MessageBox.Show("No se encontraron resultados.", "Error");
                }
            }
        }

        //
        // CONTEXT MENU
        //
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Cut();
        }        

        

        private void frmEDITOR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lbESTADO.Text == "Archivo modificado (sin guardar).")
            {
                DialogResult dialogResult = MessageBox.Show("Hay cambios sin guardar." +
                                                            "¿Desea salir de todas formas?", "Abrir otro archivo",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
