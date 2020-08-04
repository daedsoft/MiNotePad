using MiNotePad.CLASES;
using MiNotePad.FORMULARIOS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiNotePad
{
    public partial class frmEDITOR : Form
    {        
        //
        // CONSTRUCTOR
        //

        public frmEDITOR()
        {
            InitializeComponent();

            try
            {
                MiNotePadAcciones.SetArchivoOriginal(MiNotePadAcciones.GetRutaRecibida()); 

                this.Text = $"Mi NotePad {MiNotePadAcciones.GetTitulo()}";

                lbESTADO.Text = MiNotePadAcciones.GetEstado();
            }
            catch { }
        }

        //
        // AL CARGAR FORM
        //

        private void frmEDITOR_Load(object sender, EventArgs e)
        {
            try 
            {
                RichTextBox.Text = File.ReadAllText(MiNotePadAcciones.GetRutaRecibida());
                RichTextBox.Focus();
            }
            catch { }
        }

        //
        // NUEVO
        //
        private void btNUEVO_Click(object sender, EventArgs e)
        {
            MiNotePadAcciones.Nuevo();
        }

        //
        // ABRIR
        //

        private void btABRIR_Click(object sender, EventArgs e)
        {            

            if (MiNotePadAcciones.GetEstado() == "Modificado.")
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Si crea abre otro archivo se perderán los cambios realizados. " +
                    "¿Desea continuar?", "Abrir otro archivo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            MiNotePadAcciones.Abrir();

            RichTextBox.Text = MiNotePadAcciones.GetArchivoLeido();
            this.Text = MiNotePadAcciones.GetTitulo();
            lbESTADO.Text = MiNotePadAcciones.GetEstado();
            RichTextBox.Focus();
        }

        //
        // GUARDAR
        //

        private void btGUARDAR_Click(object sender, EventArgs e)
        {
            MiNotePadAcciones.Guardar(MiNotePadAcciones.GetRutaRecibida(), RichTextBox.Text);
            this.Text = MiNotePadAcciones.GetTitulo();
            lbESTADO.Text = MiNotePadAcciones.GetEstado();
            RichTextBox.Focus();            
        }

        //
        // DETECTAR CAMBIOS
        //

        private void TextBox_TextChanged(object sender, EventArgs e)
        {           
            if (MiNotePadAcciones.GetArchivoOriginal() != RichTextBox.Text) 
            {
                MiNotePadAcciones.SetEstado(1);
                lbESTADO.Text = MiNotePadAcciones.GetEstado();
            }
        }

        //
        // ZOOM
        //

        int Tam = 14;
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
                    MessageBox.Show($"El texto ({txBUSCAR.Text}) no se encuentra en el archivo.", 
                        "No se encontraron resultados.");
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

        //
        // VALIDACION AL CERRAR APP
        //

        private void frmEDITOR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lbESTADO.Text == "Modificado.")
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

        //
        // SHORTCUTS
        //
        private void frmEDITOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                btABRIR.PerformClick();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.G)
            {
                btGUARDAR.PerformClick();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                btNUEVO.PerformClick();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                btBUSCAR.PerformClick();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Add)
            {
                btZOOM_IN.PerformClick();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Subtract)
            {
                btZOOM_OUT.PerformClick();
            }
        }

        //
        // ACERCA DE
        //
        private void lbACERCADE_Click(object sender, EventArgs e)
        {
            frmACERCA ObfrmACERCA = new frmACERCA();
            ObfrmACERCA.ShowDialog();
        }
    }
}
