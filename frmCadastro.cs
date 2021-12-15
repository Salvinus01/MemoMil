// Decompiled with JetBrains decompiler
// Type: MemoMil.frmCadastro
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using MemoMil.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MemoMil
{
  public class frmCadastro : Form, ICadastro
  {
    private IContainer components;
    private DataGridView gvEventos;
    private Panel pnModificacao;
    internal Button btnCancelar;
    internal Button btnOK;
    internal TextBox txtEvento;
    internal CheckBox chkAnoDesconhecido;
    internal DateTimePicker dtEvento;
    private Label lblEvento;
    private Label label1;
    private Panel pnCabec;
    private Button btnFechar;
    private Label lblTituloCab;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Codigo;
    private ContextMenuStrip MenuContexto;
    private ToolStripMenuItem criarToolStripMenuItem;
    private ToolStripMenuItem alterarToolStripMenuItem;
    private ToolStripMenuItem excluirToolStripMenuItem;
    private ToolStripMenuItem copiarToolStripMenuItem;
    private dsMemoMil _dsMemoMil;
    private frmMemoMill fPai;
    private string _Informar = "";
    public frmCadastro.TipoCadastro Tipo;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCadastro));
      this.gvEventos = new DataGridView();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Codigo = new DataGridViewTextBoxColumn();
      this.MenuContexto = new ContextMenuStrip(this.components);
      this.copiarToolStripMenuItem = new ToolStripMenuItem();
      this.criarToolStripMenuItem = new ToolStripMenuItem();
      this.alterarToolStripMenuItem = new ToolStripMenuItem();
      this.excluirToolStripMenuItem = new ToolStripMenuItem();
      this.pnModificacao = new Panel();
      this.pnCabec = new Panel();
      this.lblTituloCab = new Label();
      this.btnFechar = new Button();
      this.lblEvento = new Label();
      this.label1 = new Label();
      this.btnCancelar = new Button();
      this.btnOK = new Button();
      this.txtEvento = new TextBox();
      this.chkAnoDesconhecido = new CheckBox();
      this.dtEvento = new DateTimePicker();
      ((ISupportInitialize) this.gvEventos).BeginInit();
      this.MenuContexto.SuspendLayout();
      this.pnModificacao.SuspendLayout();
      this.pnCabec.SuspendLayout();
      this.SuspendLayout();
      this.gvEventos.AllowUserToAddRows = false;
      this.gvEventos.AllowUserToDeleteRows = false;
      this.gvEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      this.gvEventos.BackgroundColor = SystemColors.InactiveCaptionText;
      this.gvEventos.BorderStyle = BorderStyle.None;
      this.gvEventos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.gvEventos.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.gvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvEventos.Columns.AddRange((DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Codigo);
      this.gvEventos.ContextMenuStrip = this.MenuContexto;
      this.gvEventos.Dock = DockStyle.Fill;
      this.gvEventos.Location = new Point(0, 0);
      this.gvEventos.MultiSelect = false;
      this.gvEventos.Name = "gvEventos";
      this.gvEventos.ReadOnly = true;
      this.gvEventos.RowHeadersWidth = 24;
      this.gvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.gvEventos.Size = new Size(501, 351);
      this.gvEventos.TabIndex = 24;
      this.gvEventos.Sorted += new EventHandler(this.gvEventos_Sorted);
      this.gvEventos.MouseDoubleClick += new MouseEventHandler(this.gvEventos_MouseDoubleClick);
      this.gvEventos.KeyDown += new KeyEventHandler(this.gvEventos_KeyDown);
      this.gvEventos.SelectionChanged += new EventHandler(this.gvEventos_SelectionChanged);
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column3.DefaultCellStyle = gridViewCellStyle2;
      this.Column3.HeaderText = "Aniversariante";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 99;
      this.Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.Format = "d";
      gridViewCellStyle3.NullValue = (object) null;
      this.Column4.DefaultCellStyle = gridViewCellStyle3;
      this.Column4.FillWeight = 50f;
      this.Column4.HeaderText = "Data";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 55;
      this.Codigo.HeaderText = "Codigo";
      this.Codigo.Name = "Codigo";
      this.Codigo.ReadOnly = true;
      this.Codigo.Visible = false;
      this.MenuContexto.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.copiarToolStripMenuItem,
        (ToolStripItem) this.criarToolStripMenuItem,
        (ToolStripItem) this.alterarToolStripMenuItem,
        (ToolStripItem) this.excluirToolStripMenuItem
      });
      this.MenuContexto.Name = "MenuContexto";
      this.MenuContexto.Size = new Size(130, 92);
      this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
      this.copiarToolStripMenuItem.Size = new Size(129, 22);
      this.copiarToolStripMenuItem.Text = "Copiar";
      this.criarToolStripMenuItem.Image = (Image) Resources.Adicionar;
      this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
      this.criarToolStripMenuItem.Size = new Size(129, 22);
      this.criarToolStripMenuItem.Text = "Adicionar";
      this.criarToolStripMenuItem.Click += new EventHandler(this.criarToolStripMenuItem_Click);
      this.alterarToolStripMenuItem.Image = (Image) Resources.Alterar;
      this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
      this.alterarToolStripMenuItem.Size = new Size(129, 22);
      this.alterarToolStripMenuItem.Text = "Alterar";
      this.alterarToolStripMenuItem.Click += new EventHandler(this.alterarToolStripMenuItem_Click);
      this.excluirToolStripMenuItem.Image = (Image) Resources.Excluir;
      this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
      this.excluirToolStripMenuItem.Size = new Size(129, 22);
      this.excluirToolStripMenuItem.Text = "Excluir";
      this.excluirToolStripMenuItem.Click += new EventHandler(this.excluirToolStripMenuItem_Click);
      this.pnModificacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pnModificacao.BorderStyle = BorderStyle.FixedSingle;
      this.pnModificacao.Controls.Add((Control) this.pnCabec);
      this.pnModificacao.Controls.Add((Control) this.lblEvento);
      this.pnModificacao.Controls.Add((Control) this.label1);
      this.pnModificacao.Controls.Add((Control) this.btnCancelar);
      this.pnModificacao.Controls.Add((Control) this.btnOK);
      this.pnModificacao.Controls.Add((Control) this.txtEvento);
      this.pnModificacao.Controls.Add((Control) this.chkAnoDesconhecido);
      this.pnModificacao.Controls.Add((Control) this.dtEvento);
      this.pnModificacao.Location = new Point(242, 28);
      this.pnModificacao.Name = "pnModificacao";
      this.pnModificacao.Size = new Size(235, 141);
      this.pnModificacao.TabIndex = 25;
      this.pnCabec.BackColor = SystemColors.ActiveCaption;
      this.pnCabec.Controls.Add((Control) this.lblTituloCab);
      this.pnCabec.Controls.Add((Control) this.btnFechar);
      this.pnCabec.Cursor = Cursors.NoMove2D;
      this.pnCabec.Dock = DockStyle.Top;
      this.pnCabec.Location = new Point(0, 0);
      this.pnCabec.Name = "pnCabec";
      this.pnCabec.Size = new Size(233, 18);
      this.pnCabec.TabIndex = 11;
      this.lblTituloCab.AutoSize = true;
      this.lblTituloCab.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTituloCab.ForeColor = Color.White;
      this.lblTituloCab.Location = new Point(0, 3);
      this.lblTituloCab.Name = "lblTituloCab";
      this.lblTituloCab.Size = new Size(0, 13);
      this.lblTituloCab.TabIndex = 1;
      this.btnFechar.Cursor = Cursors.Default;
      this.btnFechar.Image = (Image) Resources.BotaoFechar;
      this.btnFechar.Location = new Point(215, 0);
      this.btnFechar.Name = "btnFechar";
      this.btnFechar.Size = new Size(18, 18);
      this.btnFechar.TabIndex = 0;
      this.btnFechar.UseVisualStyleBackColor = true;
      this.btnFechar.Click += new EventHandler(this.btnCancelar_Click);
      this.lblEvento.AutoSize = true;
      this.lblEvento.Location = new Point(3, 64);
      this.lblEvento.Name = "lblEvento";
      this.lblEvento.Size = new Size(38, 13);
      this.lblEvento.TabIndex = 10;
      this.lblEvento.Text = "Nome:";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(33, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Data:";
      this.btnCancelar.DialogResult = DialogResult.Cancel;
      this.btnCancelar.Location = new Point(155, 106);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new Size(75, 23);
      this.btnCancelar.TabIndex = 9;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
      this.btnOK.Location = new Point(7, 106);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 8;
      this.btnOK.Text = "OK";
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.txtEvento.Location = new Point(6, 80);
      this.txtEvento.MaxLength = 50;
      this.txtEvento.Name = "txtEvento";
      this.txtEvento.Size = new Size(223, 20);
      this.txtEvento.TabIndex = 6;
      this.chkAnoDesconhecido.FlatStyle = FlatStyle.Flat;
      this.chkAnoDesconhecido.Location = new Point(115, 39);
      this.chkAnoDesconhecido.Name = "chkAnoDesconhecido";
      this.chkAnoDesconhecido.Size = new Size(114, 24);
      this.chkAnoDesconhecido.TabIndex = 7;
      this.chkAnoDesconhecido.Text = "Ano Desconhecido";
      this.chkAnoDesconhecido.TextAlign = ContentAlignment.MiddleRight;
      this.dtEvento.Format = DateTimePickerFormat.Short;
      this.dtEvento.Location = new Point(6, 41);
      this.dtEvento.Name = "dtEvento";
      this.dtEvento.Size = new Size(96, 20);
      this.dtEvento.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(501, 351);
      this.Controls.Add((Control) this.pnModificacao);
      this.Controls.Add((Control) this.gvEventos);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmCadastro);
      this.Text = "Cadastro de Aniversários";
      this.WindowState = FormWindowState.Minimized;
      this.Load += new EventHandler(this.frmCadastroAniversario_Load);
      this.Shown += new EventHandler(this.frmCadastroAniversario_Shown);
      ((ISupportInitialize) this.gvEventos).EndInit();
      this.MenuContexto.ResumeLayout(false);
      this.pnModificacao.ResumeLayout(false);
      this.pnModificacao.PerformLayout();
      this.pnCabec.ResumeLayout(false);
      this.pnCabec.PerformLayout();
      this.ResumeLayout(false);
    }

    public frmCadastro()
    {
      this.InitializeComponent();
      ControlMover.Init((Control) this.pnCabec, (Control) this.pnModificacao, ControlMover.Direction.Any);
    }

    private void frmCadastroAniversario_Load(object sender, EventArgs e)
    {
      this.fPai = (frmMemoMill) this.MdiParent;
      this.pnModificacao.Visible = false;
      this.PopularCadastroAniversarios();
      if (this.Tipo == frmCadastro.TipoCadastro.Aniversario)
      {
        this.chkAnoDesconhecido.Visible = true;
        this.lblEvento.Text = "Nome";
        this._Informar = "Informar o Nome do Aniversariante";
        this.gvEventos.Columns[0].HeaderText = "Aniversariante";
        this.Text = "Cadastro de Aniversários";
      }
      else if (this.Tipo == frmCadastro.TipoCadastro.Feriado)
      {
        this.chkAnoDesconhecido.Visible = false;
        this.lblEvento.Text = "Feriado";
        this._Informar = "Informar o Feriado";
        this.gvEventos.Columns[0].HeaderText = "Feriado";
        this.Text = "Cadastro de Feriados";
      }
      else
      {
        if (this.Tipo != frmCadastro.TipoCadastro.Lembrete)
          return;
        this.chkAnoDesconhecido.Visible = false;
        this.lblEvento.Text = "Lembrete";
        this._Informar = "Informar Lembrete";
        this.gvEventos.Columns[0].HeaderText = "Lembrete";
        this.Text = "Cadastro de Lembretes";
      }
    }

    private void frmCadastroAniversario_Shown(object sender, EventArgs e) => this.WindowState = FormWindowState.Maximized;

    private void gvEventos_SelectionChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.gvEventos.SelectedRows.Count == 0)
          return;
        this.gvEventos.CurrentCell = this.gvEventos.SelectedRows[0].Cells[0];
        this.fPai.CadastroNumeroRegistro = this.gvEventos.SelectedRows[0].Index + 1;
        this.fPai.CancelarModificacao();
        this.pnModificacao.Visible = false;
        if (this.gvEventos.SelectedRows[0].Displayed)
          return;
        this.gvEventos.FirstDisplayedScrollingRowIndex = this.gvEventos.SelectedRows[0].Index;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void gvEventos_Sorted(object sender, EventArgs e)
    {
      try
      {
        if (this.gvEventos.SelectedRows.Count == 0)
          return;
        this.fPai.CadastroNumeroRegistro = this.gvEventos.SelectedRows[0].Index + 1;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      try
      {
        this.fPai.CancelarModificacao();
        this.pnModificacao.Visible = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void gvEventos_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      try
      {
        if (e.Button != MouseButtons.Left)
          return;
        this.fPai.AtivarModificacao();
        this.AlterarRegistro(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void gvEventos_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        if (e.KeyCode != Keys.Delete)
          return;
        this.fPai.AtivarExclusao();
        this.ExcluirRegistro(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.pnModificacao.Visible)
          return;
        if (this.btnOK.Text == "Sim - Excluir")
        {
          this.fPai.CancelarModificacao();
          this.pnModificacao.Visible = false;
          this.ProcederExclusao();
          this.gvEventos.Focus();
        }
        else if (this.btnOK.Text == "Alterar")
        {
          if (string.IsNullOrEmpty(this.txtEvento.Text))
          {
            int num = (int) MessageBox.Show(this._Informar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtEvento.Focus();
          }
          else
          {
            this.fPai.CancelarModificacao();
            this.pnModificacao.Visible = false;
            this.ProcederAlteracao();
            this.gvEventos.Focus();
          }
        }
        else
        {
          if (!(this.btnOK.Text == "Criar"))
            return;
          if (string.IsNullOrEmpty(this.txtEvento.Text))
          {
            int num = (int) MessageBox.Show(this._Informar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtEvento.Focus();
          }
          else
          {
            this.fPai.CancelarModificacao();
            this.pnModificacao.Visible = false;
            this.ProcederInsercao();
            this.gvEventos.Focus();
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void criarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.fPai.AtivarAdicao();
        this.AdicionarRegistro(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.fPai.AtivarModificacao();
        this.AlterarRegistro(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.fPai.AtivarExclusao();
        this.ExcluirRegistro(true);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void PopularCadastroAniversarios()
    {
      if (this._dsMemoMil == null)
        this._dsMemoMil = Util.CarregarDataSet();
      Util.NormalizarDataSet(this._dsMemoMil);
      Util.SalvarDataSet(this._dsMemoMil);
      DataRow[] dataRowArray = (DataRow[]) null;
      if (this.Tipo == frmCadastro.TipoCadastro.Aniversario)
        dataRowArray = this._dsMemoMil.Evento1.Select("Tipo='Aniversario'", "Descricao");
      else if (this.Tipo == frmCadastro.TipoCadastro.Feriado)
        dataRowArray = this._dsMemoMil.Evento1.Select("Tipo='Feriado'", "Descricao");
      else if (this.Tipo == frmCadastro.TipoCadastro.Lembrete)
        dataRowArray = this._dsMemoMil.Evento1.Select("Tipo='Lembrete'", "Descricao");
      this.gvEventos.Rows.Clear();
      if (dataRowArray.Length == 0)
      {
        int num = (int) MessageBox.Show("Não Existem Registros Cadastrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        foreach (dsMemoMil.Evento1Row evento1Row in dataRowArray)
          this.gvEventos.Rows.Add((object) evento1Row.Descricao.Trim(), (object) evento1Row.DataEvento, (object) evento1Row.Codigo);
        this.gvEventos.Rows[0].Selected = true;
      }
    }

    public void AdicionarRegistro(bool ativo)
    {
      this.pnModificacao.Visible = ativo;
      if (!ativo)
        return;
      this.dtEvento.Value = DateTime.Today;
      this.chkAnoDesconhecido.Checked = false;
      this.txtEvento.Text = "";
      this.btnOK.Text = "Criar";
      this.lblTituloCab.Text = "Criação de Registro";
      this.txtEvento.ReadOnly = false;
      this.dtEvento.Enabled = true;
      this.chkAnoDesconhecido.Enabled = true;
    }

    public void AlterarRegistro(bool ativo)
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      this.pnModificacao.Visible = ativo;
      if (!ativo)
        return;
      this.txtEvento.Text = this.gvEventos.SelectedRows[0].Cells[0].Value.ToString();
      this.dtEvento.Value = DateTime.Parse(this.gvEventos.SelectedRows[0].Cells[1].Value.ToString());
      if (this.Tipo == frmCadastro.TipoCadastro.Aniversario)
        this.chkAnoDesconhecido.Checked = this.dtEvento.Value <= new DateTime(1901, 1, 1);
      this.btnOK.Text = "Alterar";
      this.lblTituloCab.Text = "Alteração de Registro";
      this.txtEvento.ReadOnly = false;
      this.dtEvento.Enabled = true;
      this.chkAnoDesconhecido.Enabled = true;
    }

    public void ExcluirRegistro(bool ativo)
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      this.pnModificacao.Visible = ativo;
      if (!ativo)
        return;
      this.txtEvento.Text = this.gvEventos.SelectedRows[0].Cells[0].Value.ToString();
      this.dtEvento.Value = DateTime.Parse(this.gvEventos.SelectedRows[0].Cells[1].Value.ToString());
      if (this.Tipo == frmCadastro.TipoCadastro.Aniversario)
        this.chkAnoDesconhecido.Checked = this.dtEvento.Value <= new DateTime(1901, 1, 1);
      this.btnOK.Text = "Sim - Excluir";
      this.lblTituloCab.Text = "EXCLUSÃO de Registro";
      this.txtEvento.ReadOnly = true;
      this.dtEvento.Enabled = false;
      this.chkAnoDesconhecido.Enabled = false;
    }

    public void AvancarRegistro()
    {
      if (this.gvEventos.Rows.Count == 0 || this.gvEventos.SelectedRows[0].Index == this.gvEventos.Rows.Count - 1)
        return;
      this.gvEventos.Rows[this.gvEventos.SelectedRows[0].Index + 1].Selected = true;
    }

    public void RetrocederRegistro()
    {
      if (this.gvEventos.Rows.Count == 0 || this.gvEventos.SelectedRows[0].Index == 0)
        return;
      this.gvEventos.Rows[this.gvEventos.SelectedRows[0].Index - 1].Selected = true;
    }

    public void PrimeiroRegistro()
    {
      if (this.gvEventos.Rows.Count == 0)
        return;
      this.gvEventos.Rows[0].Selected = true;
    }

    public void UltimoRegistro()
    {
      if (this.gvEventos.Rows.Count == 0)
        return;
      this.gvEventos.Rows[this.gvEventos.Rows.Count - 1].Selected = true;
    }

    private void ProcederExclusao()
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      this._dsMemoMil.Evento1.Select("Codigo = " + this.gvEventos.SelectedRows[0].Cells[2].Value.ToString())[0].Delete();
      Util.SalvarDataSet(this._dsMemoMil);
      this._dsMemoMil = (dsMemoMil) null;
      this.PopularCadastroAniversarios();
    }

    private void ProcederAlteracao()
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      string str = this.gvEventos.SelectedRows[0].Cells[2].Value.ToString();
      dsMemoMil.Evento1Row evento1Row = (dsMemoMil.Evento1Row) this._dsMemoMil.Evento1.Select("Codigo = " + str)[0];
      evento1Row.DataEvento = this.Tipo != frmCadastro.TipoCadastro.Aniversario || !this.chkAnoDesconhecido.Checked ? this.dtEvento.Value.Date : new DateTime(1901, this.dtEvento.Value.Month, this.dtEvento.Value.Day);
      evento1Row.Descricao = this.txtEvento.Text.Trim();
      evento1Row.DataLembrete = new DateTime(DateTime.Today.Year, evento1Row.DataEvento.Month, evento1Row.DataEvento.Day);
      Util.SalvarDataSet(this._dsMemoMil);
      this._dsMemoMil = (dsMemoMil) null;
      this.PopularCadastroAniversarios();
      foreach (DataGridViewRow row in (IEnumerable) this.gvEventos.Rows)
      {
        if (row.Cells[2].Value.ToString() == str)
        {
          row.Selected = true;
          break;
        }
      }
    }

    private void ProcederInsercao()
    {
      int num1 = 0;
      foreach (dsMemoMil.Evento1Row row in (InternalDataCollectionBase) this._dsMemoMil.Evento1.Rows)
      {
        if (row.Codigo > num1)
          num1 = row.Codigo;
      }
      dsMemoMil.Evento1Row row1 = (dsMemoMil.Evento1Row) this._dsMemoMil.Evento1.NewRow();
      row1.DataEvento = this.Tipo != frmCadastro.TipoCadastro.Aniversario || !this.chkAnoDesconhecido.Checked ? this.dtEvento.Value.Date : new DateTime(1901, this.dtEvento.Value.Month, this.dtEvento.Value.Day);
      row1.Descricao = this.txtEvento.Text.Trim();
      int num2 = num1 + 1;
      row1.Codigo = num2;
      if (this.Tipo == frmCadastro.TipoCadastro.Aniversario)
        row1.Tipo = "Aniversario";
      else if (this.Tipo == frmCadastro.TipoCadastro.Feriado)
        row1.Tipo = "Feriado";
      else if (this.Tipo == frmCadastro.TipoCadastro.Lembrete)
        row1.Tipo = "Lembrete";
      row1.DataLembrete = new DateTime(DateTime.Today.Year, row1.DataEvento.Month, row1.DataEvento.Day);
      this._dsMemoMil.Evento1.Rows.Add((DataRow) row1);
      Util.SalvarDataSet(this._dsMemoMil);
      this._dsMemoMil = (dsMemoMil) null;
      this.PopularCadastroAniversarios();
      foreach (DataGridViewRow row2 in (IEnumerable) this.gvEventos.Rows)
      {
        if (row2.Cells[2].Value.ToString() == num2.ToString())
        {
          row2.Selected = true;
          break;
        }
      }
    }

    public enum TipoCadastro
    {
      Aniversario,
      Feriado,
      Lembrete,
    }
  }
}
