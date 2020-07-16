namespace MiNotePad
{
    partial class frmEDITOR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEDITOR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBUSCAR = new System.Windows.Forms.Button();
            this.btZOOM_OUT = new System.Windows.Forms.Button();
            this.btZOOM_IN = new System.Windows.Forms.Button();
            this.btNUEVO = new System.Windows.Forms.Button();
            this.btABRIR = new System.Windows.Forms.Button();
            this.btGUARDAR = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.cmCLIPBOARD = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbESTADO = new System.Windows.Forms.Label();
            this.panelBUSCAR = new System.Windows.Forms.Panel();
            this.lbCerrar = new System.Windows.Forms.Label();
            this.txBUSCAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbACERCADE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.cmCLIPBOARD.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBUSCAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btBUSCAR);
            this.panel1.Controls.Add(this.btZOOM_OUT);
            this.panel1.Controls.Add(this.btZOOM_IN);
            this.panel1.Controls.Add(this.btNUEVO);
            this.panel1.Controls.Add(this.btABRIR);
            this.panel1.Controls.Add(this.btGUARDAR);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 878);
            this.panel1.TabIndex = 0;
            // 
            // btBUSCAR
            // 
            this.btBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBUSCAR.FlatAppearance.BorderSize = 0;
            this.btBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btBUSCAR.Image")));
            this.btBUSCAR.Location = new System.Drawing.Point(0, 835);
            this.btBUSCAR.Name = "btBUSCAR";
            this.btBUSCAR.Size = new System.Drawing.Size(52, 40);
            this.btBUSCAR.TabIndex = 6;
            this.toolTip.SetToolTip(this.btBUSCAR, "Buscar (Ctrl + B)");
            this.btBUSCAR.UseVisualStyleBackColor = true;
            this.btBUSCAR.Click += new System.EventHandler(this.btBUSCAR_Click);
            // 
            // btZOOM_OUT
            // 
            this.btZOOM_OUT.FlatAppearance.BorderSize = 0;
            this.btZOOM_OUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZOOM_OUT.Image = ((System.Drawing.Image)(resources.GetObject("btZOOM_OUT.Image")));
            this.btZOOM_OUT.Location = new System.Drawing.Point(0, 185);
            this.btZOOM_OUT.Name = "btZOOM_OUT";
            this.btZOOM_OUT.Size = new System.Drawing.Size(52, 40);
            this.btZOOM_OUT.TabIndex = 5;
            this.toolTip.SetToolTip(this.btZOOM_OUT, "Disminuir (Ctrl + Menos)");
            this.btZOOM_OUT.UseVisualStyleBackColor = true;
            this.btZOOM_OUT.Click += new System.EventHandler(this.btZOOM_OUT_Click);
            // 
            // btZOOM_IN
            // 
            this.btZOOM_IN.FlatAppearance.BorderSize = 0;
            this.btZOOM_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZOOM_IN.Image = ((System.Drawing.Image)(resources.GetObject("btZOOM_IN.Image")));
            this.btZOOM_IN.Location = new System.Drawing.Point(0, 139);
            this.btZOOM_IN.Name = "btZOOM_IN";
            this.btZOOM_IN.Size = new System.Drawing.Size(52, 40);
            this.btZOOM_IN.TabIndex = 4;
            this.toolTip.SetToolTip(this.btZOOM_IN, "Aumentar (Ctrl + Más)");
            this.btZOOM_IN.UseVisualStyleBackColor = true;
            this.btZOOM_IN.Click += new System.EventHandler(this.btZOOM_IN_Click);
            // 
            // btNUEVO
            // 
            this.btNUEVO.FlatAppearance.BorderSize = 0;
            this.btNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("btNUEVO.Image")));
            this.btNUEVO.Location = new System.Drawing.Point(0, 93);
            this.btNUEVO.Name = "btNUEVO";
            this.btNUEVO.Size = new System.Drawing.Size(52, 40);
            this.btNUEVO.TabIndex = 3;
            this.toolTip.SetToolTip(this.btNUEVO, "Nuevo (Ctrl + N)");
            this.btNUEVO.UseVisualStyleBackColor = true;
            this.btNUEVO.Click += new System.EventHandler(this.btNUEVO_Click);
            // 
            // btABRIR
            // 
            this.btABRIR.FlatAppearance.BorderSize = 0;
            this.btABRIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btABRIR.Image = ((System.Drawing.Image)(resources.GetObject("btABRIR.Image")));
            this.btABRIR.Location = new System.Drawing.Point(0, 47);
            this.btABRIR.Name = "btABRIR";
            this.btABRIR.Size = new System.Drawing.Size(52, 40);
            this.btABRIR.TabIndex = 2;
            this.toolTip.SetToolTip(this.btABRIR, "Abrir (Ctrl + A)");
            this.btABRIR.UseVisualStyleBackColor = true;
            this.btABRIR.Click += new System.EventHandler(this.btABRIR_Click);
            // 
            // btGUARDAR
            // 
            this.btGUARDAR.FlatAppearance.BorderSize = 0;
            this.btGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btGUARDAR.Image")));
            this.btGUARDAR.Location = new System.Drawing.Point(0, 1);
            this.btGUARDAR.Name = "btGUARDAR";
            this.btGUARDAR.Size = new System.Drawing.Size(52, 40);
            this.btGUARDAR.TabIndex = 1;
            this.toolTip.SetToolTip(this.btGUARDAR, "Guardar (Ctrl + G)");
            this.btGUARDAR.UseVisualStyleBackColor = true;
            this.btGUARDAR.Click += new System.EventHandler(this.btGUARDAR_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.AcceptsTab = true;
            this.RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.ContextMenuStrip = this.cmCLIPBOARD;
            this.RichTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RichTextBox.Location = new System.Drawing.Point(52, 0);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(849, 878);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            this.RichTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cmCLIPBOARD
            // 
            this.cmCLIPBOARD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmCLIPBOARD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem});
            this.cmCLIPBOARD.Name = "cmCLIPBOARD";
            this.cmCLIPBOARD.Size = new System.Drawing.Size(139, 94);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.copiarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pegarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pegarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cortarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cortarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.lbACERCADE);
            this.panel2.Controls.Add(this.lbESTADO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 878);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 39);
            this.panel2.TabIndex = 2;
            // 
            // lbESTADO
            // 
            this.lbESTADO.AutoSize = true;
            this.lbESTADO.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESTADO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbESTADO.Location = new System.Drawing.Point(10, 7);
            this.lbESTADO.Name = "lbESTADO";
            this.lbESTADO.Size = new System.Drawing.Size(68, 25);
            this.lbESTADO.TabIndex = 0;
            this.lbESTADO.Text = "Estado";
            // 
            // panelBUSCAR
            // 
            this.panelBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelBUSCAR.Controls.Add(this.lbCerrar);
            this.panelBUSCAR.Controls.Add(this.txBUSCAR);
            this.panelBUSCAR.Controls.Add(this.label1);
            this.panelBUSCAR.Location = new System.Drawing.Point(440, 5);
            this.panelBUSCAR.Name = "panelBUSCAR";
            this.panelBUSCAR.Size = new System.Drawing.Size(440, 55);
            this.panelBUSCAR.TabIndex = 4;
            this.panelBUSCAR.Visible = false;
            // 
            // lbCerrar
            // 
            this.lbCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCerrar.ForeColor = System.Drawing.Color.Firebrick;
            this.lbCerrar.Location = new System.Drawing.Point(3, 7);
            this.lbCerrar.Name = "lbCerrar";
            this.lbCerrar.Size = new System.Drawing.Size(32, 32);
            this.lbCerrar.TabIndex = 3;
            this.lbCerrar.Text = "x";
            this.lbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCerrar.Click += new System.EventHandler(this.lbCerrar_Click);
            // 
            // txBUSCAR
            // 
            this.txBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txBUSCAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBUSCAR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBUSCAR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txBUSCAR.Location = new System.Drawing.Point(103, 10);
            this.txBUSCAR.Name = "txBUSCAR";
            this.txBUSCAR.Size = new System.Drawing.Size(326, 33);
            this.txBUSCAR.TabIndex = 2;
            this.txBUSCAR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txBUSCAR_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.toolTip.ForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // lbACERCADE
            // 
            this.lbACERCADE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbACERCADE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbACERCADE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbACERCADE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbACERCADE.Location = new System.Drawing.Point(864, 2);
            this.lbACERCADE.Name = "lbACERCADE";
            this.lbACERCADE.Size = new System.Drawing.Size(36, 36);
            this.lbACERCADE.TabIndex = 1;
            this.lbACERCADE.Text = "?";
            this.lbACERCADE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbACERCADE.Click += new System.EventHandler(this.lbACERCADE_Click);
            // 
            // frmEDITOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 917);
            this.Controls.Add(this.panelBUSCAR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmEDITOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEDITOR_FormClosing);
            this.Load += new System.EventHandler(this.frmEDITOR_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEDITOR_KeyDown);
            this.panel1.ResumeLayout(false);
            this.cmCLIPBOARD.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBUSCAR.ResumeLayout(false);
            this.panelBUSCAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGUARDAR;
        private System.Windows.Forms.Button btABRIR;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button btNUEVO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbESTADO;
        private System.Windows.Forms.Button btZOOM_OUT;
        private System.Windows.Forms.Button btZOOM_IN;
        private System.Windows.Forms.ContextMenuStrip cmCLIPBOARD;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.Panel panelBUSCAR;
        private System.Windows.Forms.TextBox txBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBUSCAR;
        private System.Windows.Forms.Label lbCerrar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbACERCADE;
    }
}

