// Decompiled with JetBrains decompiler
// Type: MemoMil.frmSenha
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
  public class frmSenha : Form, ICadastro
  {
    private IContainer components;
    private DataGridView gvEventos;
    private Panel pnModificacao;
    private Panel pnCabec;
    private Label lblTituloCab;
    private Button btnFechar;
    private Label lblEvento;
    private Label label1;
    internal Button btnCancelar;
    internal Button btnOK;
    internal TextBox txtSenha;
    private ContextMenuStrip MenuContexto;
    private ToolStripMenuItem criarToolStripMenuItem;
    private ToolStripMenuItem alterarToolStripMenuItem;
    private ToolStripMenuItem excluirToolStripMenuItem;
    internal TextBox txtDescicao;
    private Panel pnLogin;
    internal TextBox txtUsuario;
    private Panel pnCabecLogin;
    private Label label2;
    private Label label3;
    private Label label4;
    internal Button btnCriarLogin;
    internal Button btnOKLogin;
    internal TextBox txtUsuarioSenha;
    private CheckBox chkVerSenha;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Codigo;
    private ToolStripMenuItem copiarToolStripMenuItem;
    private frmMemoMill fPai;
    private dsUsuario _dsUsuario;
    private dsSenhas _dsSenhas;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSenha));
      this.gvEventos = new DataGridView();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Codigo = new DataGridViewTextBoxColumn();
      this.MenuContexto = new ContextMenuStrip(this.components);
      this.copiarToolStripMenuItem = new ToolStripMenuItem();
      this.criarToolStripMenuItem = new ToolStripMenuItem();
      this.alterarToolStripMenuItem = new ToolStripMenuItem();
      this.excluirToolStripMenuItem = new ToolStripMenuItem();
      this.pnModificacao = new Panel();
      this.chkVerSenha = new CheckBox();
      this.txtDescicao = new TextBox();
      this.pnCabec = new Panel();
      this.lblTituloCab = new Label();
      this.btnFechar = new Button();
      this.lblEvento = new Label();
      this.label1 = new Label();
      this.btnCancelar = new Button();
      this.btnOK = new Button();
      this.txtSenha = new TextBox();
      this.pnLogin = new Panel();
      this.txtUsuario = new TextBox();
      this.pnCabecLogin = new Panel();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.btnCriarLogin = new Button();
      this.btnOKLogin = new Button();
      this.txtUsuarioSenha = new TextBox();
      ((ISupportInitialize) this.gvEventos).BeginInit();
      this.MenuContexto.SuspendLayout();
      this.pnModificacao.SuspendLayout();
      this.pnCabec.SuspendLayout();
      this.pnLogin.SuspendLayout();
      this.pnCabecLogin.SuspendLayout();
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
      this.gvEventos.Columns.AddRange((DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Codigo);
      this.gvEventos.ContextMenuStrip = this.MenuContexto;
      this.gvEventos.Dock = DockStyle.Fill;
      this.gvEventos.Location = new Point(0, 0);
      this.gvEventos.MultiSelect = false;
      this.gvEventos.Name = "gvEventos";
      this.gvEventos.ReadOnly = true;
      this.gvEventos.RowHeadersWidth = 24;
      this.gvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.gvEventos.Size = new Size(501, 351);
      this.gvEventos.TabIndex = 2;
      this.gvEventos.Sorted += new EventHandler(this.gvEventos_Sorted);
      this.gvEventos.MouseClick += new MouseEventHandler(this.gvEventos_MouseClick);
      this.gvEventos.MouseDoubleClick += new MouseEventHandler(this.gvEventos_MouseDoubleClick);
      this.gvEventos.KeyDown += new KeyEventHandler(this.gvEventos_KeyDown);
      this.gvEventos.SelectionChanged += new EventHandler(this.gvEventos_SelectionChanged);
      this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column3.DefaultCellStyle = gridViewCellStyle2;
      this.Column3.HeaderText = "Recurso";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 72;
      this.Codigo.HeaderText = "Senha";
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
      this.copiarToolStripMenuItem.Image = (Image) Resources.Copiar;
      this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
      this.copiarToolStripMenuItem.Size = new Size(129, 22);
      this.copiarToolStripMenuItem.Text = "Copiar";
      this.copiarToolStripMenuItem.Click += new EventHandler(this.copiarToolStripMenuItem_Click);
      this.criarToolStripMenuItem.Image = (Image) Resources.Adicionar;
      this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
      this.criarToolStripMenuItem.Size = new Size(129, 22);
      this.criarToolStripMenuItem.Text = "Adicionar";
      this.alterarToolStripMenuItem.Image = (Image) Resources.Alterar;
      this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
      this.alterarToolStripMenuItem.Size = new Size(129, 22);
      this.alterarToolStripMenuItem.Text = "Alterar";
      this.excluirToolStripMenuItem.Image = (Image) Resources.Excluir;
      this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
      this.excluirToolStripMenuItem.Size = new Size(129, 22);
      this.excluirToolStripMenuItem.Text = "Excluir";
      this.pnModificacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pnModificacao.BorderStyle = BorderStyle.FixedSingle;
      this.pnModificacao.Controls.Add((Control) this.chkVerSenha);
      this.pnModificacao.Controls.Add((Control) this.txtDescicao);
      this.pnModificacao.Controls.Add((Control) this.pnCabec);
      this.pnModificacao.Controls.Add((Control) this.lblEvento);
      this.pnModificacao.Controls.Add((Control) this.label1);
      this.pnModificacao.Controls.Add((Control) this.btnCancelar);
      this.pnModificacao.Controls.Add((Control) this.btnOK);
      this.pnModificacao.Controls.Add((Control) this.txtSenha);
      this.pnModificacao.Location = new Point(242, 28);
      this.pnModificacao.Name = "pnModificacao";
      this.pnModificacao.Size = new Size(235, 141);
      this.pnModificacao.TabIndex = 1;
      this.chkVerSenha.AutoSize = true;
      this.chkVerSenha.Location = new Point(122, 63);
      this.chkVerSenha.Name = "chkVerSenha";
      this.chkVerSenha.Size = new Size(104, 17);
      this.chkVerSenha.TabIndex = 12;
      this.chkVerSenha.Text = "Visualizar Senha";
      this.chkVerSenha.UseVisualStyleBackColor = true;
      this.chkVerSenha.CheckedChanged += new EventHandler(this.chkVerSenha_CheckedChanged);
      this.txtDescicao.Location = new Point(5, 41);
      this.txtDescicao.MaxLength = 50;
      this.txtDescicao.Name = "txtDescicao";
      this.txtDescicao.Size = new Size(223, 20);
      this.txtDescicao.TabIndex = 0;
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
      this.lblEvento.Text = "Senha";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(55, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Descrição";
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
      this.txtSenha.Location = new Point(6, 80);
      this.txtSenha.MaxLength = 50;
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.Size = new Size(223, 20);
      this.txtSenha.TabIndex = 1;
      this.pnLogin.Anchor = AnchorStyles.Top;
      this.pnLogin.BorderStyle = BorderStyle.FixedSingle;
      this.pnLogin.Controls.Add((Control) this.txtUsuario);
      this.pnLogin.Controls.Add((Control) this.pnCabecLogin);
      this.pnLogin.Controls.Add((Control) this.label3);
      this.pnLogin.Controls.Add((Control) this.label4);
      this.pnLogin.Controls.Add((Control) this.btnCriarLogin);
      this.pnLogin.Controls.Add((Control) this.btnOKLogin);
      this.pnLogin.Controls.Add((Control) this.txtUsuarioSenha);
      this.pnLogin.Location = new Point(133, 54);
      this.pnLogin.Name = "pnLogin";
      this.pnLogin.Size = new Size(235, 141);
      this.pnLogin.TabIndex = 0;
      this.txtUsuario.Location = new Point(5, 41);
      this.txtUsuario.MaxLength = 10;
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new Size(223, 20);
      this.txtUsuario.TabIndex = 0;
      this.pnCabecLogin.BackColor = SystemColors.ActiveCaption;
      this.pnCabecLogin.Controls.Add((Control) this.label2);
      this.pnCabecLogin.Cursor = Cursors.NoMove2D;
      this.pnCabecLogin.Dock = DockStyle.Top;
      this.pnCabecLogin.Location = new Point(0, 0);
      this.pnCabecLogin.Name = "pnCabecLogin";
      this.pnCabecLogin.Size = new Size(233, 18);
      this.pnCabecLogin.TabIndex = 4;
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(0, 3);
      this.label2.Name = "label2";
      this.label2.Size = new Size(38, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Login";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(3, 64);
      this.label3.Name = "label3";
      this.label3.Size = new Size(114, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Código de Autorização";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(3, 25);
      this.label4.Name = "label4";
      this.label4.Size = new Size(43, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Usuário";
      this.btnCriarLogin.DialogResult = DialogResult.Cancel;
      this.btnCriarLogin.Location = new Point(155, 106);
      this.btnCriarLogin.Name = "btnCriarLogin";
      this.btnCriarLogin.Size = new Size(75, 23);
      this.btnCriarLogin.TabIndex = 3;
      this.btnCriarLogin.Text = "Criar Usuário";
      this.btnCriarLogin.Click += new EventHandler(this.btnCriarLogin_Click);
      this.btnOKLogin.Location = new Point(7, 106);
      this.btnOKLogin.Name = "btnOKLogin";
      this.btnOKLogin.Size = new Size(75, 23);
      this.btnOKLogin.TabIndex = 2;
      this.btnOKLogin.Text = "OK";
      this.btnOKLogin.Click += new EventHandler(this.btnOKLogin_Click);
      this.txtUsuarioSenha.Location = new Point(6, 80);
      this.txtUsuarioSenha.MaxLength = 50;
      this.txtUsuarioSenha.Name = "txtUsuarioSenha";
      this.txtUsuarioSenha.PasswordChar = '*';
      this.txtUsuarioSenha.Size = new Size(223, 20);
      this.txtUsuarioSenha.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(501, 351);
      this.Controls.Add((Control) this.pnLogin);
      this.Controls.Add((Control) this.pnModificacao);
      this.Controls.Add((Control) this.gvEventos);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmSenha);
      this.Text = "Senhas";
      this.WindowState = FormWindowState.Minimized;
      this.Load += new EventHandler(this.frmSenha_Load);
      this.Shown += new EventHandler(this.frmSenha_Shown);
      ((ISupportInitialize) this.gvEventos).EndInit();
      this.MenuContexto.ResumeLayout(false);
      this.pnModificacao.ResumeLayout(false);
      this.pnModificacao.PerformLayout();
      this.pnCabec.ResumeLayout(false);
      this.pnCabec.PerformLayout();
      this.pnLogin.ResumeLayout(false);
      this.pnLogin.PerformLayout();
      this.pnCabecLogin.ResumeLayout(false);
      this.pnCabecLogin.PerformLayout();
      this.ResumeLayout(false);
    }

    public frmSenha()
    {
      this.InitializeComponent();
      ControlMover.Init((Control) this.pnCabec, (Control) this.pnModificacao, ControlMover.Direction.Any);
      ControlMover.Init((Control) this.pnCabecLogin, (Control) this.pnLogin, ControlMover.Direction.Any);
    }

    private void frmSenha_Load(object sender, EventArgs e)
    {
      this.fPai = (frmMemoMill) this.MdiParent;
      this.pnModificacao.Visible = false;
      this.pnLogin.Visible = true;
      this.txtUsuario.Focus();
    }

    private void frmSenha_Shown(object sender, EventArgs e) => this.WindowState = FormWindowState.Maximized;

    private void btnCriarLogin_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.CriarConta())
          return;
        this.pnLogin.Visible = false;
        if (this._dsSenhas == null)
          this._dsSenhas = Util.CarregarDataSetSenhas(this.txtUsuario.Text.Trim());
        int num = (int) MessageBox.Show("Novo Usuário Criado. Pronto para Cadastrar Senhas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnOKLogin_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.EfetuarLogin())
          return;
        this.pnLogin.Visible = false;
        this.CarregarSenhas();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

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
          if (string.IsNullOrEmpty(this.txtDescicao.Text))
          {
            int num = (int) MessageBox.Show("Informar o Recurso para Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtDescicao.Focus();
          }
          else if (string.IsNullOrEmpty(this.txtSenha.Text))
          {
            int num = (int) MessageBox.Show("Informar uma Senha para Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtSenha.Focus();
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
          if (string.IsNullOrEmpty(this.txtDescicao.Text))
          {
            int num = (int) MessageBox.Show("Informar o Recurso para Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtDescicao.Focus();
          }
          else if (string.IsNullOrEmpty(this.txtSenha.Text))
          {
            int num = (int) MessageBox.Show("Informar uma Senha para Cadastro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.txtSenha.Focus();
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

    private void chkVerSenha_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        this.GerenciarVerSenha();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void gvEventos_MouseClick(object sender, MouseEventArgs e)
    {
      try
      {
        if (e.Button != MouseButtons.Middle)
          return;
        this.Copiar();
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

    private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.Copiar();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool CriarConta()
    {
      if (string.IsNullOrEmpty(this.txtUsuario.Text))
      {
        int num = (int) MessageBox.Show("Informar Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtUsuario.Focus();
        return false;
      }
      if (string.IsNullOrEmpty(this.txtUsuarioSenha.Text))
      {
        int num = (int) MessageBox.Show("Informar Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtUsuario.Focus();
        return false;
      }
      if (this._dsUsuario == null)
        this._dsUsuario = Util.CarregarDataSetUsuario();
      if (this._dsUsuario.Usuario.Select("Usuario='" + this.txtUsuario.Text.Trim() + "'").Length > 0)
      {
        int num = (int) MessageBox.Show("Usuário já Existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtUsuario.Focus();
        return false;
      }
      Crypto crypto = new Crypto();
      this._dsUsuario.Usuario.AddUsuarioRow(this.txtUsuario.Text.Trim(), crypto.Encriptar(this.txtUsuarioSenha.Text.Trim()));
      Util.SalvarDataSetUsuario(this._dsUsuario);
      return true;
    }

    private bool EfetuarLogin()
    {
      if (string.IsNullOrEmpty(this.txtUsuario.Text))
      {
        int num = (int) MessageBox.Show("Informar Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtUsuario.Focus();
        return false;
      }
      if (string.IsNullOrEmpty(this.txtUsuarioSenha.Text))
      {
        int num = (int) MessageBox.Show("Informar Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.txtUsuario.Focus();
        return false;
      }
      Crypto crypto = new Crypto();
      if (this._dsUsuario == null)
        this._dsUsuario = Util.CarregarDataSetUsuario();
      if (this._dsUsuario.Usuario.Select("Usuario='" + this.txtUsuario.Text.Trim() + "' and Senha='" + crypto.Encriptar(this.txtUsuarioSenha.Text.Trim()) + "'").Length == 1)
        return true;
      int num1 = (int) MessageBox.Show("Usuário e/ou Código de Autorização Inválido(s)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }

    private void CarregarSenhas()
    {
      if (this._dsSenhas == null)
        this._dsSenhas = Util.CarregarDataSetSenhas(this.txtUsuario.Text.Trim());
      this.gvEventos.Rows.Clear();
      if (this._dsSenhas.Senha.Rows.Count == 0)
      {
        int num = (int) MessageBox.Show("Não Existem Senhas Cadastradas para este Usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        foreach (dsSenhas.SenhaRow row in (InternalDataCollectionBase) this._dsSenhas.Senha.Rows)
          this.gvEventos.Rows.Add((object) row.Descricao, (object) row.Senha);
        this.gvEventos.Rows[0].Selected = true;
      }
    }

    public void AdicionarRegistro(bool ativo)
    {
      this.pnModificacao.Visible = ativo;
      if (!ativo)
        return;
      this.txtDescicao.Text = "";
      this.txtSenha.Text = "";
      this.btnOK.Text = "Criar";
      this.lblTituloCab.Text = "Criação de Registro";
      this.txtDescicao.ReadOnly = false;
      this.txtSenha.ReadOnly = false;
      this.chkVerSenha.Checked = false;
      this.GerenciarVerSenha();
    }

    public void AlterarRegistro(bool ativo)
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      this.pnModificacao.Visible = ativo;
      if (!ativo)
        return;
      Crypto crypto = new Crypto();
      this.txtDescicao.Text = this.gvEventos.SelectedRows[0].Cells[0].Value.ToString();
      this.txtSenha.Text = crypto.Decriptar(this.gvEventos.SelectedRows[0].Cells[1].Value.ToString());
      this.btnOK.Text = "Alterar";
      this.lblTituloCab.Text = "Alteração de Registro";
      this.txtDescicao.ReadOnly = false;
      this.txtSenha.ReadOnly = false;
      this.chkVerSenha.Checked = false;
      this.GerenciarVerSenha();
    }

    public void ExcluirRegistro(bool ativo)
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      this.pnModificacao.Visible = ativo;
      if (!ativo)
        return;
      Crypto crypto = new Crypto();
      this.txtDescicao.Text = this.gvEventos.SelectedRows[0].Cells[0].Value.ToString();
      this.txtSenha.Text = crypto.Decriptar(this.gvEventos.SelectedRows[0].Cells[1].Value.ToString());
      this.btnOK.Text = "Sim - Excluir";
      this.lblTituloCab.Text = "EXCLUSÃO de Registro";
      this.txtDescicao.ReadOnly = true;
      this.txtSenha.ReadOnly = true;
      this.chkVerSenha.Checked = false;
      this.GerenciarVerSenha();
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
      this._dsSenhas.Senha.Select("Descricao = '" + this.txtDescicao.Text.Trim() + "'")[0].Delete();
      Util.SalvarDataSetSenhas(this._dsSenhas);
      this._dsSenhas = (dsSenhas) null;
      this.CarregarSenhas();
    }

    private void ProcederAlteracao()
    {
      if (this.gvEventos.SelectedRows.Count == 0)
        return;
      dsSenhas.SenhaRow senhaRow = (dsSenhas.SenhaRow) this._dsSenhas.Senha.Select("Descricao = '" + this.gvEventos.SelectedRows[0].Cells[0].Value.ToString() + "'")[0];
      Crypto crypto = new Crypto();
      senhaRow.Descricao = this.txtDescicao.Text.Trim();
      senhaRow.Senha = crypto.Encriptar(this.txtSenha.Text.Trim());
      Util.SalvarDataSetSenhas(this._dsSenhas);
      this._dsSenhas = (dsSenhas) null;
      this.CarregarSenhas();
      foreach (DataGridViewRow row in (IEnumerable) this.gvEventos.Rows)
      {
        if (row.Cells[0].Value.ToString() == this.txtDescicao.Text.Trim())
        {
          row.Selected = true;
          break;
        }
      }
    }

    private void ProcederInsercao()
    {
      Crypto crypto = new Crypto();
      this._dsSenhas.Senha.AddSenhaRow(this.txtUsuario.Text.Trim(), this.txtDescicao.Text.Trim(), crypto.Encriptar(this.txtSenha.Text.Trim()));
      Util.SalvarDataSetSenhas(this._dsSenhas);
      this._dsSenhas = (dsSenhas) null;
      this.CarregarSenhas();
      foreach (DataGridViewRow row in (IEnumerable) this.gvEventos.Rows)
      {
        if (row.Cells[0].Value.ToString() == this.txtDescicao.Text.Trim())
        {
          row.Selected = true;
          break;
        }
      }
    }

    private void GerenciarVerSenha()
    {
      if (this.chkVerSenha.Checked)
        this.txtSenha.PasswordChar = char.MinValue;
      else
        this.txtSenha.PasswordChar = '*';
    }

    public void Copiar()
    {
      Crypto crypto = new Crypto();
      Clipboard.Clear();
      Clipboard.SetText(crypto.Decriptar(this.gvEventos.SelectedRows[0].Cells[1].Value.ToString()));
    }
  }
}
