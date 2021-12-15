// Decompiled with JetBrains decompiler
// Type: MemoMil.frmOpcoes
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MemoMil
{
  public class frmOpcoes : Form
  {
    private IContainer components;
    private NumericUpDown nudDias;
    private Label label1;
    private GroupBox groupBox1;
    private Button btnForeLembrete;
    private Button btnBackLembrete;
    private Button btnForeFeriado;
    private Button btnBackFeriado;
    private Button btnForeAniversario;
    private Button btnBackAniversario;
    private Label lblLembrete;
    private Label lblFeriado;
    private Label lblAniversario;
    private GroupBox groupBox2;
    private ColorDialog colorDialog1;
    internal Button btnCancelar;
    internal Button btnOK;
    private dsConfig ds;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.nudDias = new NumericUpDown();
      this.label1 = new Label();
      this.groupBox1 = new GroupBox();
      this.btnForeLembrete = new Button();
      this.btnBackLembrete = new Button();
      this.btnForeFeriado = new Button();
      this.btnBackFeriado = new Button();
      this.btnForeAniversario = new Button();
      this.btnBackAniversario = new Button();
      this.lblLembrete = new Label();
      this.lblFeriado = new Label();
      this.lblAniversario = new Label();
      this.groupBox2 = new GroupBox();
      this.colorDialog1 = new ColorDialog();
      this.btnCancelar = new Button();
      this.btnOK = new Button();
      this.nudDias.BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      this.nudDias.Location = new Point(276, 19);
      this.nudDias.Maximum = new Decimal(new int[4]
      {
        365,
        0,
        0,
        0
      });
      this.nudDias.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.nudDias.Name = "nudDias";
      this.nudDias.Size = new Size(47, 20);
      this.nudDias.TabIndex = 1;
      this.nudDias.Value = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.label1.AutoSize = true;
      this.label1.Location = new Point(8, 21);
      this.label1.Name = "label1";
      this.label1.Size = new Size(195, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Número de Dias para Exibição  (padrão)";
      this.groupBox1.Controls.Add((Control) this.btnForeLembrete);
      this.groupBox1.Controls.Add((Control) this.btnBackLembrete);
      this.groupBox1.Controls.Add((Control) this.btnForeFeriado);
      this.groupBox1.Controls.Add((Control) this.btnBackFeriado);
      this.groupBox1.Controls.Add((Control) this.btnForeAniversario);
      this.groupBox1.Controls.Add((Control) this.btnBackAniversario);
      this.groupBox1.Controls.Add((Control) this.lblLembrete);
      this.groupBox1.Controls.Add((Control) this.lblFeriado);
      this.groupBox1.Controls.Add((Control) this.lblAniversario);
      this.groupBox1.Location = new Point(12, 67);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(333, 115);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Esquema de Cores na Tabela de Lembretes";
      this.btnForeLembrete.Location = new Point(248, 83);
      this.btnForeLembrete.Name = "btnForeLembrete";
      this.btnForeLembrete.Size = new Size(75, 20);
      this.btnForeLembrete.TabIndex = 17;
      this.btnForeLembrete.Text = "Letras";
      this.btnForeLembrete.Click += new EventHandler(this.Cor_Click);
      this.btnBackLembrete.Location = new Point(167, 83);
      this.btnBackLembrete.Name = "btnBackLembrete";
      this.btnBackLembrete.Size = new Size(75, 20);
      this.btnBackLembrete.TabIndex = 16;
      this.btnBackLembrete.Text = "Fundo";
      this.btnBackLembrete.Click += new EventHandler(this.Cor_Click);
      this.btnForeFeriado.Location = new Point(248, 52);
      this.btnForeFeriado.Name = "btnForeFeriado";
      this.btnForeFeriado.Size = new Size(75, 20);
      this.btnForeFeriado.TabIndex = 15;
      this.btnForeFeriado.Text = "Letras";
      this.btnForeFeriado.Click += new EventHandler(this.Cor_Click);
      this.btnBackFeriado.Location = new Point(167, 52);
      this.btnBackFeriado.Name = "btnBackFeriado";
      this.btnBackFeriado.Size = new Size(75, 20);
      this.btnBackFeriado.TabIndex = 14;
      this.btnBackFeriado.Text = "Fundo";
      this.btnBackFeriado.Click += new EventHandler(this.Cor_Click);
      this.btnForeAniversario.Location = new Point(248, 21);
      this.btnForeAniversario.Name = "btnForeAniversario";
      this.btnForeAniversario.Size = new Size(75, 20);
      this.btnForeAniversario.TabIndex = 13;
      this.btnForeAniversario.Text = "Letras";
      this.btnForeAniversario.Click += new EventHandler(this.Cor_Click);
      this.btnBackAniversario.Location = new Point(167, 21);
      this.btnBackAniversario.Name = "btnBackAniversario";
      this.btnBackAniversario.Size = new Size(75, 20);
      this.btnBackAniversario.TabIndex = 12;
      this.btnBackAniversario.Text = "Fundo";
      this.btnBackAniversario.Click += new EventHandler(this.Cor_Click);
      this.lblLembrete.BackColor = SystemColors.Window;
      this.lblLembrete.BorderStyle = BorderStyle.FixedSingle;
      this.lblLembrete.Location = new Point(11, 85);
      this.lblLembrete.Name = "lblLembrete";
      this.lblLembrete.Size = new Size(150, 18);
      this.lblLembrete.TabIndex = 11;
      this.lblLembrete.Text = "Lembrete";
      this.lblLembrete.TextAlign = ContentAlignment.MiddleCenter;
      this.lblFeriado.BackColor = SystemColors.Window;
      this.lblFeriado.BorderStyle = BorderStyle.FixedSingle;
      this.lblFeriado.Location = new Point(11, 54);
      this.lblFeriado.Name = "lblFeriado";
      this.lblFeriado.Size = new Size(150, 18);
      this.lblFeriado.TabIndex = 10;
      this.lblFeriado.Text = "Feriado";
      this.lblFeriado.TextAlign = ContentAlignment.MiddleCenter;
      this.lblAniversario.BackColor = SystemColors.Window;
      this.lblAniversario.BorderStyle = BorderStyle.FixedSingle;
      this.lblAniversario.Location = new Point(11, 23);
      this.lblAniversario.Name = "lblAniversario";
      this.lblAniversario.Size = new Size(150, 18);
      this.lblAniversario.TabIndex = 9;
      this.lblAniversario.Text = "Aniversário";
      this.lblAniversario.TextAlign = ContentAlignment.MiddleCenter;
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Controls.Add((Control) this.nudDias);
      this.groupBox2.Location = new Point(12, 9);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(333, 51);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Exibição de Eventos";
      this.colorDialog1.Color = Color.White;
      this.btnCancelar.DialogResult = DialogResult.Cancel;
      this.btnCancelar.Location = new Point(23, 188);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new Size(75, 23);
      this.btnCancelar.TabIndex = 6;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
      this.btnOK.DialogResult = DialogResult.OK;
      this.btnOK.Location = new Point(260, 188);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(75, 23);
      this.btnOK.TabIndex = 5;
      this.btnOK.Text = "OK";
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.AcceptButton = (IButtonControl) this.btnOK;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.btnCancelar;
      this.ClientSize = new Size(360, 218);
      this.Controls.Add((Control) this.btnCancelar);
      this.Controls.Add((Control) this.btnOK);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmOpcoes);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Opções";
      this.Load += new EventHandler(this.frmOpcoes_Load);
      this.nudDias.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
    }

    public frmOpcoes() => this.InitializeComponent();

    private void frmOpcoes_Load(object sender, EventArgs e)
    {
      this.ds = Util.CarregarDataSetConfiguracao();
      this.nudDias.Value = (Decimal) this.ds.Config1[0].NumDias;
      this.lblAniversario.BackColor = Color.FromArgb(this.ds.Config1[0].CorAniversario);
      this.lblAniversario.ForeColor = Color.FromArgb(this.ds.Config1[0].CorAniversarioFore);
      this.lblFeriado.BackColor = Color.FromArgb(this.ds.Config1[0].CorFeriado);
      this.lblFeriado.ForeColor = Color.FromArgb(this.ds.Config1[0].CorFeriadoFore);
      this.lblLembrete.BackColor = Color.FromArgb(this.ds.Config1[0].CorLembrete);
      this.lblLembrete.ForeColor = Color.FromArgb(this.ds.Config1[0].CorLembreteFore);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.ds.Config1[0].NumDias = (int) this.nudDias.Value;
      Util.SalvarDataSetConfiguracao(this.ds);
      this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e) => this.ds.RejectChanges();

    private void Cor_Click(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      if (this.ds.Tables[0].Rows.Count != 0)
      {
        switch (button.Name.Trim())
        {
          case "btnBackAniversario":
            this.colorDialog1.Color = Color.FromArgb(this.ds.Config1[0].CorAniversario);
            break;
          case "btnForeAniversario":
            this.colorDialog1.Color = Color.FromArgb(this.ds.Config1[0].CorAniversarioFore);
            break;
          case "btnBackFeriado":
            this.colorDialog1.Color = Color.FromArgb(this.ds.Config1[0].CorFeriado);
            break;
          case "btnForeFeriado":
            this.colorDialog1.Color = Color.FromArgb(this.ds.Config1[0].CorFeriadoFore);
            break;
          case "btnBackLembrete":
            this.colorDialog1.Color = Color.FromArgb(this.ds.Config1[0].CorLembrete);
            break;
          case "btnForeLembrete":
            this.colorDialog1.Color = Color.FromArgb(this.ds.Config1[0].CorLembreteFore);
            break;
        }
      }
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      int argb = this.colorDialog1.Color.ToArgb();
      switch (button.Name.Trim())
      {
        case "btnBackAniversario":
          this.lblAniversario.BackColor = Color.FromArgb(argb);
          this.ds.Config1[0].CorAniversario = argb;
          break;
        case "btnForeAniversario":
          this.lblAniversario.ForeColor = Color.FromArgb(argb);
          this.ds.Config1[0].CorAniversarioFore = argb;
          break;
        case "btnBackFeriado":
          this.lblFeriado.BackColor = Color.FromArgb(argb);
          this.ds.Config1[0].CorFeriado = argb;
          break;
        case "btnForeFeriado":
          this.lblFeriado.ForeColor = Color.FromArgb(argb);
          this.ds.Config1[0].CorFeriadoFore = argb;
          break;
        case "btnBackLembrete":
          this.lblLembrete.BackColor = Color.FromArgb(argb);
          this.ds.Config1[0].CorLembrete = argb;
          break;
        case "btnForeLembrete":
          this.lblLembrete.ForeColor = Color.FromArgb(argb);
          this.ds.Config1[0].CorLembreteFore = argb;
          break;
      }
    }
  }
}
