// Decompiled with JetBrains decompiler
// Type: MemoMil.frmMemoMill
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using MemoMil.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MemoMil
{
  public class frmMemoMill : Form
  {
    private int childFormNumber;
    private IContainer components;
    private MenuStrip menuStrip;
    private ToolStrip toolStrip;
    private StatusStrip statusStrip;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem printSetupToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripStatusLabel toolStripStatusLabel;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem tileHorizontalToolStripMenuItem;
    private ToolStripMenuItem fileMenu;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripMenuItem printToolStripMenuItem;
    private ToolStripMenuItem printPreviewToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editMenu;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem viewMenu;
    private ToolStripMenuItem toolBarToolStripMenuItem;
    private ToolStripMenuItem statusBarToolStripMenuItem;
    private ToolStripMenuItem toolsMenu;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem windowsMenu;
    private ToolStripMenuItem newWindowToolStripMenuItem;
    private ToolStripMenuItem cascadeToolStripMenuItem;
    private ToolStripMenuItem tileVerticalToolStripMenuItem;
    private ToolStripMenuItem closeAllToolStripMenuItem;
    private ToolStripMenuItem arrangeIconsToolStripMenuItem;
    private ToolStripMenuItem helpMenu;
    private ToolStripMenuItem contentsToolStripMenuItem;
    private ToolStripMenuItem indexToolStripMenuItem;
    private ToolStripMenuItem searchToolStripMenuItem;
    private ToolStripButton verEventosToolStripButton;
    private ToolStripButton aniversarioToolStripButton;
    private ToolStripButton lembretesToolStripButton;
    private ToolStripButton printToolStripButton;
    private ToolStripButton helpToolStripButton;
    private ToolTip toolTip;
    private ToolStripButton feriadosStripButton1;
    private ToolStripButton senhasStripButton1;
    private ToolStripMenuItem cadastrosToolStripMenuItem;
    private ToolStripMenuItem aniversáriosToolStripMenuItem;
    private ToolStripMenuItem feriadosToolStripMenuItem;
    private ToolStripMenuItem lembretesToolStripMenuItem;
    private ToolStripMenuItem senhasToolStripMenuItem;
    private ToolStripPanel toolStripPanel1;
    private ToolStrip toolStripEventos;
    private ToolStripLabel toolStripLabel3;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripButton toolStripButton1;
    private ToolStripButton tsbCores;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem próximosEventosToolStripMenuItem;
    private ToolStrip toolStripCadastro;
    private ToolStripLabel toolStripLabel1;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripButton toolStripButtonPrimeiro;
    private ToolStripButton toolStripButtonAnterior;
    private ToolStripLabel toolStripLabelRegistro;
    private ToolStripButton toolStripButtonProximo;
    private ToolStripButton toolStripButtonUltimo;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStripButton toolStripButtonAdicionar;
    private ToolStripButton toolStripButtonAlterar;
    private ToolStripButton toolStripButtonExcluir;
    private ToolStrip toolStripCopia;
    private ToolStripButton copyToolStripButton;
    private ToolStripButton telefonesStripButton;

    public frmMemoMill() => this.InitializeComponent();

    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new frmMemoMill());
    }

    private void ShowNewForm(object sender, EventArgs e)
    {
      Form form = new Form();
      form.MdiParent = (Form) this;
      form.Text = "Window " + (object) this.childFormNumber++;
      form.Show();
    }

    private void OpenFile(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (openFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string fileName = openFileDialog.FileName;
    }

    private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
      saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
      if (saveFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      string fileName = saveFileDialog.FileName;
    }

    private void CutToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.toolStrip.Visible = this.toolStripEventos.Visible = this.toolStripCadastro.Visible = this.toolBarToolStripMenuItem.Checked;
        if (!this.toolBarToolStripMenuItem.Checked)
          return;
        this.GerenciarBarrasFerramentas();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.statusStrip.Visible = this.statusBarToolStripMenuItem.Checked;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.LayoutMdi(MdiLayout.Cascade);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.LayoutMdi(MdiLayout.TileVertical);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.LayoutMdi(MdiLayout.TileHorizontal);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.LayoutMdi(MdiLayout.ArrangeIcons);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.FecharTodosFormulariosFilhos();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void frmMemoMill_Load(object sender, EventArgs e)
    {
      this.toolStripPanel1.Join(this.toolStripCopia);
      this.toolStripPanel1.Join(this.toolStripCadastro);
      this.toolStripPanel1.Join(this.toolStripEventos);
      this.toolStripPanel1.Join(this.toolStrip);
      this.toolStripEventos.Visible = this.toolStripCadastro.Visible = this.toolStripCopia.Visible = false;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        frmSobre frmSobre = new frmSobre();
        int num = (int) frmSobre.ShowDialog((IWin32Window) this);
        frmSobre.Dispose();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void helpToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        frmSobre frmSobre = new frmSobre();
        int num = (int) frmSobre.ShowDialog((IWin32Window) this);
        frmSobre.Dispose();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void frmMemoMill_Shown(object sender, EventArgs e)
    {
      try
      {
        this.MostrarEventos();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void próximosEventosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarEventos();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void verEventosToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarEventos();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void aniversáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarCadastroAniversarios();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void aniversarioToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarCadastroAniversarios();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.MdiChildren.Length == 0)
          return;
        ((frmEvento) this.MdiChildren[0]).PopularEventos();
        int num = (int) MessageBox.Show("Eventos Atualizados", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.Close();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void frmMemoMill_MdiChildActivate(object sender, EventArgs e)
    {
      try
      {
        this.GerenciarBarrasFerramentas();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void MostrarEventos()
    {
      this.IniciarCarga("Carregando Eventos...");
      frmEvento frmEvento = new frmEvento();
      frmEvento.MdiParent = (Form) this;
      frmEvento.Show();
      this.FinalizarCarga();
    }

    private void MostrarCadastroAniversarios()
    {
      this.IniciarCarga("Carregando Cadastro de Anviersários...");
      frmCadastro frmCadastro = new frmCadastro();
      frmCadastro.Tipo = frmCadastro.TipoCadastro.Aniversario;
      frmCadastro.MdiParent = (Form) this;
      frmCadastro.Show();
      this.FinalizarCarga();
    }

    private void MostrarCadastroFeriados()
    {
      this.IniciarCarga("Carregando Cadastro de Feriados...");
      frmCadastro frmCadastro = new frmCadastro();
      frmCadastro.Tipo = frmCadastro.TipoCadastro.Feriado;
      frmCadastro.MdiParent = (Form) this;
      frmCadastro.Show();
      this.FinalizarCarga();
    }

    private void MostrarCadastroLembretes()
    {
      this.IniciarCarga("Carregando Cadastro de Lembretes...");
      frmCadastro frmCadastro = new frmCadastro();
      frmCadastro.Tipo = frmCadastro.TipoCadastro.Lembrete;
      frmCadastro.MdiParent = (Form) this;
      frmCadastro.Show();
      this.FinalizarCarga();
    }

    private void MostrarSenhas()
    {
      this.IniciarCarga("Carregando Cadastro de Senhas...");
      frmSenha frmSenha = new frmSenha();
      frmSenha.MdiParent = (Form) this;
      frmSenha.Show();
      this.FinalizarCarga();
    }

    private void MostrarTelefones()
    {
      this.IniciarCarga("Carregando Cadastro de Telefones...");
      frmTelefone frmTelefone = new frmTelefone();
      frmTelefone.MdiParent = (Form) this;
      frmTelefone.Show();
      this.FinalizarCarga();
    }

    private void FecharTodosFormulariosFilhos()
    {
      foreach (Form mdiChild in this.MdiChildren)
        mdiChild.Close();
    }

    private void IniciarCarga(string mensagem)
    {
      this.toolStripStatusLabel.Text = mensagem;
      this.Cursor = Cursors.WaitCursor;
      Application.DoEvents();
      this.FecharTodosFormulariosFilhos();
    }

    private void FinalizarCarga()
    {
      this.Cursor = Cursors.Default;
      this.toolStripStatusLabel.Text = "Pronto.";
    }

    private void GerenciarBarrasFerramentas()
    {
      if (this.MdiChildren.Length == 0)
        this.toolStripEventos.Visible = this.toolStripCadastro.Visible = this.toolStripCopia.Visible = false;
      this.toolStripEventos.Visible = this.MdiChildren[0] is frmEvento && this.MdiChildren[0].Visible;
      this.toolStripCadastro.Visible = this.MdiChildren[0] is frmCadastro && this.MdiChildren[0].Visible || this.MdiChildren[0] is frmSenha && this.MdiChildren[0].Visible;
      this.toolStripCopia.Visible = this.MdiChildren[0] is frmSenha && this.MdiChildren[0].Visible;
    }

    private void toolStripButtonPrimeiro_Click(object sender, EventArgs e)
    {
      try
      {
        ((ICadastro) this.MdiChildren[0]).PrimeiroRegistro();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButtonAnterior_Click(object sender, EventArgs e)
    {
      try
      {
        ((ICadastro) this.MdiChildren[0]).RetrocederRegistro();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButtonProximo_Click(object sender, EventArgs e)
    {
      try
      {
        ((ICadastro) this.MdiChildren[0]).AvancarRegistro();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButtonUltimo_Click(object sender, EventArgs e)
    {
      try
      {
        ((ICadastro) this.MdiChildren[0]).UltimoRegistro();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButtonAdicionar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.toolStripButtonAdicionar.Checked)
          this.toolStripButtonAlterar.Checked = this.toolStripButtonExcluir.Checked = false;
        ((ICadastro) this.MdiChildren[0]).AdicionarRegistro(this.toolStripButtonAdicionar.Checked);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButtonAlterar_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.toolStripButtonAlterar.Checked)
          this.toolStripButtonAdicionar.Checked = this.toolStripButtonExcluir.Checked = false;
        ((ICadastro) this.MdiChildren[0]).AlterarRegistro(this.toolStripButtonAlterar.Checked);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void toolStripButtonExcluir_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.toolStripButtonExcluir.Checked)
          this.toolStripButtonAdicionar.Checked = this.toolStripButtonAlterar.Checked = false;
        ((ICadastro) this.MdiChildren[0]).ExcluirRegistro(this.toolStripButtonExcluir.Checked);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    public int CadastroNumeroRegistro
    {
      get => int.Parse(this.toolStripLabelRegistro.Text);
      set => this.toolStripLabelRegistro.Text = value.ToString();
    }

    public void CancelarModificacao() => this.toolStripButtonAdicionar.Checked = this.toolStripButtonAlterar.Checked = this.toolStripButtonExcluir.Checked = false;

    public void AtivarModificacao()
    {
      this.toolStripButtonAdicionar.Checked = this.toolStripButtonExcluir.Checked = false;
      this.toolStripButtonAlterar.Checked = true;
    }

    public void AtivarExclusao()
    {
      this.toolStripButtonAdicionar.Checked = this.toolStripButtonAlterar.Checked = false;
      this.toolStripButtonExcluir.Checked = true;
    }

    public void AtivarAdicao()
    {
      this.toolStripButtonAlterar.Checked = this.toolStripButtonExcluir.Checked = false;
      this.toolStripButtonAdicionar.Checked = true;
    }

    private void feriadosStripButton1_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarCadastroFeriados();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void feriadosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarCadastroFeriados();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lembretesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarCadastroLembretes();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lembretesToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarCadastroLembretes();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void senhasStripButton1_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarSenhas();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void senhasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarSenhas();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void telefonesStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        this.MostrarTelefones();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void copyToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.MdiChildren.Length == 0 || !(this.MdiChildren[0] is frmSenha))
          return;
        ((frmSenha) this.MdiChildren[0]).Copiar();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        frmOpcoes frmOpcoes = new frmOpcoes();
        if (frmOpcoes.ShowDialog((IWin32Window) this) == DialogResult.OK && this.MdiChildren.Length > 0 && this.MdiChildren[0] is frmEvento)
          this.MostrarEventos();
        frmOpcoes.Dispose();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void tsbCores_Click(object sender, EventArgs e)
    {
      try
      {
        frmOpcoes frmOpcoes = new frmOpcoes();
        if (frmOpcoes.ShowDialog((IWin32Window) this) == DialogResult.OK && this.MdiChildren.Length > 0 && this.MdiChildren[0] is frmEvento)
          this.MostrarEventos();
        frmOpcoes.Dispose();
      }
      catch (Exception ex)
      {
        this.Cursor = Cursors.Default;
        this.statusStrip.Text = "Pronto.";
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void printToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void printToolStripButton_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemoMill));
      this.menuStrip = new MenuStrip();
      this.fileMenu = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.saveToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.printToolStripMenuItem = new ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new ToolStripMenuItem();
      this.printSetupToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.cadastrosToolStripMenuItem = new ToolStripMenuItem();
      this.aniversáriosToolStripMenuItem = new ToolStripMenuItem();
      this.feriadosToolStripMenuItem = new ToolStripMenuItem();
      this.lembretesToolStripMenuItem = new ToolStripMenuItem();
      this.senhasToolStripMenuItem = new ToolStripMenuItem();
      this.editMenu = new ToolStripMenuItem();
      this.undoToolStripMenuItem = new ToolStripMenuItem();
      this.redoToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.cutToolStripMenuItem = new ToolStripMenuItem();
      this.copyToolStripMenuItem = new ToolStripMenuItem();
      this.pasteToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.selectAllToolStripMenuItem = new ToolStripMenuItem();
      this.viewMenu = new ToolStripMenuItem();
      this.próximosEventosToolStripMenuItem = new ToolStripMenuItem();
      this.toolBarToolStripMenuItem = new ToolStripMenuItem();
      this.statusBarToolStripMenuItem = new ToolStripMenuItem();
      this.toolsMenu = new ToolStripMenuItem();
      this.optionsToolStripMenuItem = new ToolStripMenuItem();
      this.windowsMenu = new ToolStripMenuItem();
      this.newWindowToolStripMenuItem = new ToolStripMenuItem();
      this.cascadeToolStripMenuItem = new ToolStripMenuItem();
      this.tileVerticalToolStripMenuItem = new ToolStripMenuItem();
      this.tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
      this.closeAllToolStripMenuItem = new ToolStripMenuItem();
      this.arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
      this.helpMenu = new ToolStripMenuItem();
      this.contentsToolStripMenuItem = new ToolStripMenuItem();
      this.indexToolStripMenuItem = new ToolStripMenuItem();
      this.searchToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.toolStrip = new ToolStrip();
      this.verEventosToolStripButton = new ToolStripButton();
      this.aniversarioToolStripButton = new ToolStripButton();
      this.feriadosStripButton1 = new ToolStripButton();
      this.lembretesToolStripButton = new ToolStripButton();
      this.senhasStripButton1 = new ToolStripButton();
      this.telefonesStripButton = new ToolStripButton();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.printToolStripButton = new ToolStripButton();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.helpToolStripButton = new ToolStripButton();
      this.statusStrip = new StatusStrip();
      this.toolStripStatusLabel = new ToolStripStatusLabel();
      this.toolTip = new ToolTip(this.components);
      this.toolStripPanel1 = new ToolStripPanel();
      this.toolStripCadastro = new ToolStrip();
      this.toolStripLabel1 = new ToolStripLabel();
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.toolStripButtonPrimeiro = new ToolStripButton();
      this.toolStripButtonAnterior = new ToolStripButton();
      this.toolStripLabelRegistro = new ToolStripLabel();
      this.toolStripButtonProximo = new ToolStripButton();
      this.toolStripButtonUltimo = new ToolStripButton();
      this.toolStripSeparator12 = new ToolStripSeparator();
      this.toolStripButtonAdicionar = new ToolStripButton();
      this.toolStripButtonAlterar = new ToolStripButton();
      this.toolStripButtonExcluir = new ToolStripButton();
      this.toolStripEventos = new ToolStrip();
      this.toolStripLabel3 = new ToolStripLabel();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.toolStripButton1 = new ToolStripButton();
      this.tsbCores = new ToolStripButton();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.toolStripCopia = new ToolStrip();
      this.copyToolStripButton = new ToolStripButton();
      this.menuStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.toolStripCadastro.SuspendLayout();
      this.toolStripEventos.SuspendLayout();
      this.toolStripCopia.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip.Items.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.fileMenu,
        (ToolStripItem) this.cadastrosToolStripMenuItem,
        (ToolStripItem) this.editMenu,
        (ToolStripItem) this.viewMenu,
        (ToolStripItem) this.toolsMenu,
        (ToolStripItem) this.windowsMenu,
        (ToolStripItem) this.helpMenu
      });
      this.menuStrip.Location = new Point(0, 0);
      this.menuStrip.MdiWindowListItem = this.windowsMenu;
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new Size(589, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "MenuStrip";
      this.fileMenu.DropDownItems.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.newToolStripMenuItem,
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.saveToolStripMenuItem,
        (ToolStripItem) this.saveAsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.printToolStripMenuItem,
        (ToolStripItem) this.printPreviewToolStripMenuItem,
        (ToolStripItem) this.printSetupToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
      this.fileMenu.Name = "fileMenu";
      this.fileMenu.Size = new Size(56, 20);
      this.fileMenu.Text = "&Arquivo";
      this.newToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("newToolStripMenuItem.Image");
      this.newToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = Keys.N | Keys.Control;
      this.newToolStripMenuItem.Size = new Size(161, 22);
      this.newToolStripMenuItem.Text = "&New";
      this.newToolStripMenuItem.Visible = false;
      this.newToolStripMenuItem.Click += new EventHandler(this.ShowNewForm);
      this.openToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("openToolStripMenuItem.Image");
      this.openToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Control;
      this.openToolStripMenuItem.Size = new Size(161, 22);
      this.openToolStripMenuItem.Text = "&Open";
      this.openToolStripMenuItem.Visible = false;
      this.openToolStripMenuItem.Click += new EventHandler(this.OpenFile);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(158, 6);
      this.toolStripSeparator3.Visible = false;
      this.saveToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("saveToolStripMenuItem.Image");
      this.saveToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Control;
      this.saveToolStripMenuItem.Size = new Size(161, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Visible = false;
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new Size(161, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As";
      this.saveAsToolStripMenuItem.Visible = false;
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.SaveAsToolStripMenuItem_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(158, 6);
      this.toolStripSeparator4.Visible = false;
      this.printToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("printToolStripMenuItem.Image");
      this.printToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = Keys.P | Keys.Control;
      this.printToolStripMenuItem.Size = new Size(161, 22);
      this.printToolStripMenuItem.Text = "&Imprimir";
      this.printToolStripMenuItem.Visible = false;
      this.printToolStripMenuItem.Click += new EventHandler(this.printToolStripMenuItem_Click);
      this.printPreviewToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("printPreviewToolStripMenuItem.Image");
      this.printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new Size(161, 22);
      this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
      this.printPreviewToolStripMenuItem.Visible = false;
      this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
      this.printSetupToolStripMenuItem.Size = new Size(161, 22);
      this.printSetupToolStripMenuItem.Text = "Print Setup";
      this.printSetupToolStripMenuItem.Visible = false;
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(158, 6);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = Keys.X | Keys.Control;
      this.exitToolStripMenuItem.Size = new Size(161, 22);
      this.exitToolStripMenuItem.Text = "Sai&r";
      this.exitToolStripMenuItem.Click += new EventHandler(this.ExitToolsStripMenuItem_Click);
      this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.aniversáriosToolStripMenuItem,
        (ToolStripItem) this.feriadosToolStripMenuItem,
        (ToolStripItem) this.lembretesToolStripMenuItem,
        (ToolStripItem) this.senhasToolStripMenuItem
      });
      this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
      this.cadastrosToolStripMenuItem.Size = new Size(68, 20);
      this.cadastrosToolStripMenuItem.Text = "&Cadastros";
      this.aniversáriosToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("aniversáriosToolStripMenuItem.Image");
      this.aniversáriosToolStripMenuItem.Name = "aniversáriosToolStripMenuItem";
      this.aniversáriosToolStripMenuItem.Size = new Size(144, 22);
      this.aniversáriosToolStripMenuItem.Text = "&Aniversários";
      this.aniversáriosToolStripMenuItem.Click += new EventHandler(this.aniversáriosToolStripMenuItem_Click);
      this.feriadosToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("feriadosToolStripMenuItem.Image");
      this.feriadosToolStripMenuItem.Name = "feriadosToolStripMenuItem";
      this.feriadosToolStripMenuItem.Size = new Size(144, 22);
      this.feriadosToolStripMenuItem.Text = "&Feriados";
      this.feriadosToolStripMenuItem.Click += new EventHandler(this.feriadosToolStripMenuItem_Click);
      this.lembretesToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("lembretesToolStripMenuItem.Image");
      this.lembretesToolStripMenuItem.Name = "lembretesToolStripMenuItem";
      this.lembretesToolStripMenuItem.Size = new Size(144, 22);
      this.lembretesToolStripMenuItem.Text = "&Lembretes";
      this.lembretesToolStripMenuItem.Click += new EventHandler(this.lembretesToolStripMenuItem_Click);
      this.senhasToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("senhasToolStripMenuItem.Image");
      this.senhasToolStripMenuItem.Name = "senhasToolStripMenuItem";
      this.senhasToolStripMenuItem.Size = new Size(144, 22);
      this.senhasToolStripMenuItem.Text = "&Senhas";
      this.senhasToolStripMenuItem.Click += new EventHandler(this.senhasToolStripMenuItem_Click);
      this.editMenu.DropDownItems.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.undoToolStripMenuItem,
        (ToolStripItem) this.redoToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.cutToolStripMenuItem,
        (ToolStripItem) this.copyToolStripMenuItem,
        (ToolStripItem) this.pasteToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.selectAllToolStripMenuItem
      });
      this.editMenu.Name = "editMenu";
      this.editMenu.Size = new Size(37, 20);
      this.editMenu.Text = "&Edit";
      this.editMenu.Visible = false;
      this.undoToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("undoToolStripMenuItem.Image");
      this.undoToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = Keys.Z | Keys.Control;
      this.undoToolStripMenuItem.Size = new Size(167, 22);
      this.undoToolStripMenuItem.Text = "&Undo";
      this.redoToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("redoToolStripMenuItem.Image");
      this.redoToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = Keys.Y | Keys.Control;
      this.redoToolStripMenuItem.Size = new Size(167, 22);
      this.redoToolStripMenuItem.Text = "&Redo";
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(164, 6);
      this.cutToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("cutToolStripMenuItem.Image");
      this.cutToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = Keys.X | Keys.Control;
      this.cutToolStripMenuItem.Size = new Size(167, 22);
      this.cutToolStripMenuItem.Text = "Cu&t";
      this.cutToolStripMenuItem.Click += new EventHandler(this.CutToolStripMenuItem_Click);
      this.copyToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("copyToolStripMenuItem.Image");
      this.copyToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = Keys.C | Keys.Control;
      this.copyToolStripMenuItem.Size = new Size(167, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      this.copyToolStripMenuItem.Click += new EventHandler(this.CopyToolStripMenuItem_Click);
      this.pasteToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("pasteToolStripMenuItem.Image");
      this.pasteToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = Keys.V | Keys.Control;
      this.pasteToolStripMenuItem.Size = new Size(167, 22);
      this.pasteToolStripMenuItem.Text = "&Paste";
      this.pasteToolStripMenuItem.Click += new EventHandler(this.PasteToolStripMenuItem_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(164, 6);
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.ShortcutKeys = Keys.A | Keys.Control;
      this.selectAllToolStripMenuItem.Size = new Size(167, 22);
      this.selectAllToolStripMenuItem.Text = "Select &All";
      this.viewMenu.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.próximosEventosToolStripMenuItem,
        (ToolStripItem) this.toolBarToolStripMenuItem,
        (ToolStripItem) this.statusBarToolStripMenuItem
      });
      this.viewMenu.Name = "viewMenu";
      this.viewMenu.Size = new Size(45, 20);
      this.viewMenu.Text = "E&xibir";
      this.próximosEventosToolStripMenuItem.Image = (Image) Resources.Evento;
      this.próximosEventosToolStripMenuItem.Name = "próximosEventosToolStripMenuItem";
      this.próximosEventosToolStripMenuItem.Size = new Size(175, 22);
      this.próximosEventosToolStripMenuItem.Text = "&Próximos Eventos";
      this.próximosEventosToolStripMenuItem.Click += new EventHandler(this.próximosEventosToolStripMenuItem_Click);
      this.toolBarToolStripMenuItem.Checked = true;
      this.toolBarToolStripMenuItem.CheckOnClick = true;
      this.toolBarToolStripMenuItem.CheckState = CheckState.Checked;
      this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
      this.toolBarToolStripMenuItem.Size = new Size(175, 22);
      this.toolBarToolStripMenuItem.Text = "Barra &Ferramentas";
      this.toolBarToolStripMenuItem.Click += new EventHandler(this.ToolBarToolStripMenuItem_Click);
      this.statusBarToolStripMenuItem.Checked = true;
      this.statusBarToolStripMenuItem.CheckOnClick = true;
      this.statusBarToolStripMenuItem.CheckState = CheckState.Checked;
      this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
      this.statusBarToolStripMenuItem.Size = new Size(175, 22);
      this.statusBarToolStripMenuItem.Text = "Barra &Estatus";
      this.statusBarToolStripMenuItem.Click += new EventHandler(this.StatusBarToolStripMenuItem_Click);
      this.toolsMenu.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.optionsToolStripMenuItem
      });
      this.toolsMenu.Name = "toolsMenu";
      this.toolsMenu.Size = new Size(80, 20);
      this.toolsMenu.Text = "Ferra&mentas";
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new Size(133, 22);
      this.optionsToolStripMenuItem.Text = "&Opções...";
      this.optionsToolStripMenuItem.Click += new EventHandler(this.optionsToolStripMenuItem_Click);
      this.windowsMenu.DropDownItems.AddRange(new ToolStripItem[6]
      {
        (ToolStripItem) this.newWindowToolStripMenuItem,
        (ToolStripItem) this.cascadeToolStripMenuItem,
        (ToolStripItem) this.tileVerticalToolStripMenuItem,
        (ToolStripItem) this.tileHorizontalToolStripMenuItem,
        (ToolStripItem) this.closeAllToolStripMenuItem,
        (ToolStripItem) this.arrangeIconsToolStripMenuItem
      });
      this.windowsMenu.Name = "windowsMenu";
      this.windowsMenu.Size = new Size(50, 20);
      this.windowsMenu.Text = "&Janela";
      this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
      this.newWindowToolStripMenuItem.Size = new Size(153, 22);
      this.newWindowToolStripMenuItem.Text = "&New Window";
      this.newWindowToolStripMenuItem.Visible = false;
      this.newWindowToolStripMenuItem.Click += new EventHandler(this.ShowNewForm);
      this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
      this.cascadeToolStripMenuItem.Size = new Size(153, 22);
      this.cascadeToolStripMenuItem.Text = "Em &cascata";
      this.cascadeToolStripMenuItem.Click += new EventHandler(this.CascadeToolStripMenuItem_Click);
      this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
      this.tileVerticalToolStripMenuItem.Size = new Size(153, 22);
      this.tileVerticalToolStripMenuItem.Text = "Na &Vertical";
      this.tileVerticalToolStripMenuItem.Click += new EventHandler(this.TileVerticalToolStripMenuItem_Click);
      this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
      this.tileHorizontalToolStripMenuItem.Size = new Size(153, 22);
      this.tileHorizontalToolStripMenuItem.Text = "Na &Horizontal";
      this.tileHorizontalToolStripMenuItem.Click += new EventHandler(this.TileHorizontalToolStripMenuItem_Click);
      this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
      this.closeAllToolStripMenuItem.Size = new Size(153, 22);
      this.closeAllToolStripMenuItem.Text = "&Fechar Todas";
      this.closeAllToolStripMenuItem.Click += new EventHandler(this.CloseAllToolStripMenuItem_Click);
      this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
      this.arrangeIconsToolStripMenuItem.Size = new Size(153, 22);
      this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
      this.arrangeIconsToolStripMenuItem.Visible = false;
      this.arrangeIconsToolStripMenuItem.Click += new EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
      this.helpMenu.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.contentsToolStripMenuItem,
        (ToolStripItem) this.indexToolStripMenuItem,
        (ToolStripItem) this.searchToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.aboutToolStripMenuItem
      });
      this.helpMenu.Name = "helpMenu";
      this.helpMenu.Size = new Size(47, 20);
      this.helpMenu.Text = "A&juda";
      this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
      this.contentsToolStripMenuItem.ShortcutKeys = Keys.F1 | Keys.Control;
      this.contentsToolStripMenuItem.Size = new Size(195, 22);
      this.contentsToolStripMenuItem.Text = "&Contents";
      this.contentsToolStripMenuItem.Visible = false;
      this.indexToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("indexToolStripMenuItem.Image");
      this.indexToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new Size(195, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      this.indexToolStripMenuItem.Visible = false;
      this.searchToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("searchToolStripMenuItem.Image");
      this.searchToolStripMenuItem.ImageTransparentColor = Color.Black;
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new Size(195, 22);
      this.searchToolStripMenuItem.Text = "&Search";
      this.searchToolStripMenuItem.Visible = false;
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(192, 6);
      this.toolStripSeparator8.Visible = false;
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(195, 22);
      this.aboutToolStripMenuItem.Text = "&Sobre o Memo 1000 ...";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.toolStrip.Dock = DockStyle.None;
      this.toolStrip.Items.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.verEventosToolStripButton,
        (ToolStripItem) this.aniversarioToolStripButton,
        (ToolStripItem) this.feriadosStripButton1,
        (ToolStripItem) this.lembretesToolStripButton,
        (ToolStripItem) this.senhasStripButton1,
        (ToolStripItem) this.telefonesStripButton,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.printToolStripButton,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.helpToolStripButton
      });
      this.toolStrip.Location = new Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new Size(179, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "ToolStrip";
      this.verEventosToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.verEventosToolStripButton.Image = (Image) Resources.Evento;
      this.verEventosToolStripButton.ImageTransparentColor = Color.Black;
      this.verEventosToolStripButton.Name = "verEventosToolStripButton";
      this.verEventosToolStripButton.Size = new Size(23, 22);
      this.verEventosToolStripButton.Text = "Próximos Eventos";
      this.verEventosToolStripButton.Click += new EventHandler(this.verEventosToolStripButton_Click);
      this.aniversarioToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.aniversarioToolStripButton.Image = (Image) Resources.Aniversario;
      this.aniversarioToolStripButton.ImageTransparentColor = Color.Black;
      this.aniversarioToolStripButton.Name = "aniversarioToolStripButton";
      this.aniversarioToolStripButton.Size = new Size(23, 22);
      this.aniversarioToolStripButton.Text = "Aniversários";
      this.aniversarioToolStripButton.Click += new EventHandler(this.aniversarioToolStripButton_Click);
      this.feriadosStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.feriadosStripButton1.Image = (Image) Resources.Feriado;
      this.feriadosStripButton1.ImageTransparentColor = Color.Black;
      this.feriadosStripButton1.Name = "feriadosStripButton1";
      this.feriadosStripButton1.Size = new Size(23, 22);
      this.feriadosStripButton1.Text = "Feriados";
      this.feriadosStripButton1.Click += new EventHandler(this.feriadosStripButton1_Click);
      this.lembretesToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.lembretesToolStripButton.Image = (Image) Resources.Lembrete;
      this.lembretesToolStripButton.ImageTransparentColor = Color.Black;
      this.lembretesToolStripButton.Name = "lembretesToolStripButton";
      this.lembretesToolStripButton.Size = new Size(23, 22);
      this.lembretesToolStripButton.Text = "Lembretes";
      this.lembretesToolStripButton.Click += new EventHandler(this.lembretesToolStripButton_Click);
      this.senhasStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.senhasStripButton1.Image = (Image) Resources.Senha;
      this.senhasStripButton1.ImageTransparentColor = Color.Black;
      this.senhasStripButton1.Name = "senhasStripButton1";
      this.senhasStripButton1.Size = new Size(23, 22);
      this.senhasStripButton1.Text = "Senhas";
      this.senhasStripButton1.Click += new EventHandler(this.senhasStripButton1_Click);
      this.telefonesStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.telefonesStripButton.Image = (Image) Resources.phone2_16x16;
      this.telefonesStripButton.ImageTransparentColor = Color.Magenta;
      this.telefonesStripButton.Name = "telefonesStripButton";
      this.telefonesStripButton.Size = new Size(23, 22);
      this.telefonesStripButton.Text = "toolStripButton2";
      this.telefonesStripButton.ToolTipText = "Telefones";
      this.telefonesStripButton.Click += new EventHandler(this.telefonesStripButton_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(6, 25);
      this.toolStripSeparator1.Visible = false;
      this.printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.printToolStripButton.Image = (Image) componentResourceManager.GetObject("printToolStripButton.Image");
      this.printToolStripButton.ImageTransparentColor = Color.Black;
      this.printToolStripButton.Name = "printToolStripButton";
      this.printToolStripButton.Size = new Size(23, 22);
      this.printToolStripButton.Text = "Imprimir";
      this.printToolStripButton.Visible = false;
      this.printToolStripButton.Click += new EventHandler(this.printToolStripButton_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(6, 25);
      this.helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.helpToolStripButton.Image = (Image) componentResourceManager.GetObject("helpToolStripButton.Image");
      this.helpToolStripButton.ImageTransparentColor = Color.Black;
      this.helpToolStripButton.Name = "helpToolStripButton";
      this.helpToolStripButton.Size = new Size(23, 22);
      this.helpToolStripButton.Text = "Sobre";
      this.helpToolStripButton.Click += new EventHandler(this.helpToolStripButton_Click);
      this.statusStrip.GripMargin = new Padding(2, 0, 2, 2);
      this.statusStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripStatusLabel
      });
      this.statusStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
      this.statusStrip.Location = new Point(0, 356);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
      this.statusStrip.Size = new Size(589, 18);
      this.statusStrip.TabIndex = 2;
      this.statusStrip.Text = "StatusStrip";
      this.toolStripStatusLabel.Name = "toolStripStatusLabel";
      this.toolStripStatusLabel.Size = new Size(38, 13);
      this.toolStripStatusLabel.Text = "Status";
      this.toolStripPanel1.Dock = DockStyle.Top;
      this.toolStripPanel1.Location = new Point(0, 24);
      this.toolStripPanel1.Name = "toolStripPanel1";
      this.toolStripPanel1.Orientation = Orientation.Horizontal;
      this.toolStripPanel1.RowMargin = new Padding(3, 0, 0, 0);
      this.toolStripPanel1.Size = new Size(589, 0);
      this.toolStripCadastro.Dock = DockStyle.None;
      this.toolStripCadastro.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.toolStripLabel1,
        (ToolStripItem) this.toolStripSeparator11,
        (ToolStripItem) this.toolStripButtonPrimeiro,
        (ToolStripItem) this.toolStripButtonAnterior,
        (ToolStripItem) this.toolStripLabelRegistro,
        (ToolStripItem) this.toolStripButtonProximo,
        (ToolStripItem) this.toolStripButtonUltimo,
        (ToolStripItem) this.toolStripSeparator12,
        (ToolStripItem) this.toolStripButtonAdicionar,
        (ToolStripItem) this.toolStripButtonAlterar,
        (ToolStripItem) this.toolStripButtonExcluir
      });
      this.toolStripCadastro.Location = new Point(296, 24);
      this.toolStripCadastro.Name = "toolStripCadastro";
      this.toolStripCadastro.Size = new Size(262, 25);
      this.toolStripCadastro.TabIndex = 19;
      this.toolStripCadastro.Text = "toolStrip1";
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new Size(51, 22);
      this.toolStripLabel1.Text = "Cadastro";
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new Size(6, 25);
      this.toolStripButtonPrimeiro.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonPrimeiro.Image = (Image) Resources.Primeiro;
      this.toolStripButtonPrimeiro.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonPrimeiro.Name = "toolStripButtonPrimeiro";
      this.toolStripButtonPrimeiro.Size = new Size(23, 22);
      this.toolStripButtonPrimeiro.Text = "toolStripButton1";
      this.toolStripButtonPrimeiro.ToolTipText = "Primeiro";
      this.toolStripButtonPrimeiro.Click += new EventHandler(this.toolStripButtonPrimeiro_Click);
      this.toolStripButtonAnterior.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonAnterior.Image = (Image) Resources.Anterior;
      this.toolStripButtonAnterior.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonAnterior.Name = "toolStripButtonAnterior";
      this.toolStripButtonAnterior.Size = new Size(23, 22);
      this.toolStripButtonAnterior.Text = "toolStripButton1";
      this.toolStripButtonAnterior.ToolTipText = "Voltar";
      this.toolStripButtonAnterior.Click += new EventHandler(this.toolStripButtonAnterior_Click);
      this.toolStripLabelRegistro.AutoSize = false;
      this.toolStripLabelRegistro.Name = "toolStripLabelRegistro";
      this.toolStripLabelRegistro.Size = new Size(26, 22);
      this.toolStripLabelRegistro.Text = "0";
      this.toolStripButtonProximo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonProximo.Image = (Image) Resources.Proximo;
      this.toolStripButtonProximo.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonProximo.Name = "toolStripButtonProximo";
      this.toolStripButtonProximo.Size = new Size(23, 22);
      this.toolStripButtonProximo.Text = "toolStripButton2";
      this.toolStripButtonProximo.ToolTipText = "Avançar";
      this.toolStripButtonProximo.Click += new EventHandler(this.toolStripButtonProximo_Click);
      this.toolStripButtonUltimo.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonUltimo.Image = (Image) Resources.Ultimo;
      this.toolStripButtonUltimo.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonUltimo.Name = "toolStripButtonUltimo";
      this.toolStripButtonUltimo.Size = new Size(23, 22);
      this.toolStripButtonUltimo.Text = "toolStripButton2";
      this.toolStripButtonUltimo.ToolTipText = "Último";
      this.toolStripButtonUltimo.Click += new EventHandler(this.toolStripButtonUltimo_Click);
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      this.toolStripSeparator12.Size = new Size(6, 25);
      this.toolStripButtonAdicionar.CheckOnClick = true;
      this.toolStripButtonAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonAdicionar.Image = (Image) componentResourceManager.GetObject("toolStripButtonAdicionar.Image");
      this.toolStripButtonAdicionar.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonAdicionar.Name = "toolStripButtonAdicionar";
      this.toolStripButtonAdicionar.Size = new Size(23, 22);
      this.toolStripButtonAdicionar.Text = "toolStripButton3";
      this.toolStripButtonAdicionar.ToolTipText = "Adicionar";
      this.toolStripButtonAdicionar.Click += new EventHandler(this.toolStripButtonAdicionar_Click);
      this.toolStripButtonAlterar.CheckOnClick = true;
      this.toolStripButtonAlterar.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonAlterar.Image = (Image) Resources.Alterar;
      this.toolStripButtonAlterar.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonAlterar.Name = "toolStripButtonAlterar";
      this.toolStripButtonAlterar.Size = new Size(23, 22);
      this.toolStripButtonAlterar.Text = "toolStripButton4";
      this.toolStripButtonAlterar.ToolTipText = "Alterar";
      this.toolStripButtonAlterar.Click += new EventHandler(this.toolStripButtonAlterar_Click);
      this.toolStripButtonExcluir.CheckOnClick = true;
      this.toolStripButtonExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButtonExcluir.Image = (Image) componentResourceManager.GetObject("toolStripButtonExcluir.Image");
      this.toolStripButtonExcluir.ImageTransparentColor = Color.Magenta;
      this.toolStripButtonExcluir.Name = "toolStripButtonExcluir";
      this.toolStripButtonExcluir.Size = new Size(23, 22);
      this.toolStripButtonExcluir.Text = "toolStripButton5";
      this.toolStripButtonExcluir.ToolTipText = "Excluir";
      this.toolStripButtonExcluir.Click += new EventHandler(this.toolStripButtonExcluir_Click);
      this.toolStripEventos.Dock = DockStyle.None;
      this.toolStripEventos.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripLabel3,
        (ToolStripItem) this.toolStripSeparator9,
        (ToolStripItem) this.toolStripButton1,
        (ToolStripItem) this.tsbCores,
        (ToolStripItem) this.toolStripSeparator10
      });
      this.toolStripEventos.Location = new Point(179, 24);
      this.toolStripEventos.Name = "toolStripEventos";
      this.toolStripEventos.Size = new Size(116, 25);
      this.toolStripEventos.TabIndex = 18;
      this.toolStripEventos.Text = "toolStrip2";
      this.toolStripLabel3.Name = "toolStripLabel3";
      this.toolStripLabel3.Size = new Size(46, 22);
      this.toolStripLabel3.Text = "Eventos";
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new Size(6, 25);
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = (Image) componentResourceManager.GetObject("toolStripButton1.Image");
      this.toolStripButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      this.toolStripButton1.ToolTipText = "Atualizar";
      this.toolStripButton1.Click += new EventHandler(this.toolStripButton1_Click);
      this.tsbCores.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.tsbCores.Image = (Image) componentResourceManager.GetObject("tsbCores.Image");
      this.tsbCores.ImageTransparentColor = Color.Magenta;
      this.tsbCores.Name = "tsbCores";
      this.tsbCores.Size = new Size(23, 22);
      this.tsbCores.Text = "Cores";
      this.tsbCores.ToolTipText = "Configurar Cores";
      this.tsbCores.Click += new EventHandler(this.tsbCores_Click);
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new Size(6, 25);
      this.toolStripCopia.Dock = DockStyle.None;
      this.toolStripCopia.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.copyToolStripButton
      });
      this.toolStripCopia.Location = new Point(558, 24);
      this.toolStripCopia.Name = "toolStripCopia";
      this.toolStripCopia.Size = new Size(35, 25);
      this.toolStripCopia.TabIndex = 20;
      this.copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.copyToolStripButton.Image = (Image) componentResourceManager.GetObject("copyToolStripButton.Image");
      this.copyToolStripButton.ImageTransparentColor = Color.Magenta;
      this.copyToolStripButton.Name = "copyToolStripButton";
      this.copyToolStripButton.Size = new Size(23, 22);
      this.copyToolStripButton.Text = "&Copiar";
      this.copyToolStripButton.Click += new EventHandler(this.copyToolStripButton_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.Control;
      this.BackgroundImageLayout = ImageLayout.Center;
      this.ClientSize = new Size(589, 374);
      this.Controls.Add((Control) this.toolStripCadastro);
      this.Controls.Add((Control) this.toolStripPanel1);
      this.Controls.Add((Control) this.toolStripEventos);
      this.Controls.Add((Control) this.statusStrip);
      this.Controls.Add((Control) this.toolStripCopia);
      this.Controls.Add((Control) this.menuStrip);
      this.Controls.Add((Control) this.toolStrip);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip;
      this.Name = nameof (frmMemoMill);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Memo 1000";
      this.Load += new EventHandler(this.frmMemoMill_Load);
      this.Shown += new EventHandler(this.frmMemoMill_Shown);
      this.MdiChildActivate += new EventHandler(this.frmMemoMill_MdiChildActivate);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.toolStripCadastro.ResumeLayout(false);
      this.toolStripCadastro.PerformLayout();
      this.toolStripEventos.ResumeLayout(false);
      this.toolStripEventos.PerformLayout();
      this.toolStripCopia.ResumeLayout(false);
      this.toolStripCopia.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
