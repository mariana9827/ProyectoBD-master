using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal ()
        {
            InitializeComponent();
        }

        private void ShowNewForm (object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile (object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click (object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click (object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click (object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click (object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click (object sender, EventArgs e)
        {
         
        }

        private void StatusBarToolStripMenuItem_Click (object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click (object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click (object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click (object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click (object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click (object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void reportesToolStripMenuItem_Click (object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load (object sender, EventArgs e)
        {

            

        }

        private void btnCliente_Click (object sender, EventArgs e)
        {
            
        }

        private void menuStrip_ItemClicked (object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click (object sender, EventArgs e)
        {
          
        }

        private void nacionalExtranjeroToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void currierToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmCourrier courrier = new FrmCourrier();
            courrier.Show();
            
        }

        private void nacionalExtranjeroToolStripMenuItem_Click_1 (object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void jurídicaToolStripMenuItem_Click (object sender, EventArgs e)
        {
            FrmJuridico juridico = new FrmJuridico();
            juridico.Show();
        }

        private void agregarToolStripMenuItem1_Click (object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem1_Click_1 (object sender, EventArgs e)
        {
            FrmProductocs producto = new FrmProductocs();
            producto.Show();
        }
    }
}
