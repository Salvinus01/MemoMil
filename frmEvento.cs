// Decompiled with JetBrains decompiler
// Type: MemoMil.frmEvento
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using MemoMil.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MemoMil
{
  public class frmEvento : Form
  {
    private IContainer components;
    private NumericUpDown nudDias;
    private Panel panel1;
    private Label label1;
    private Label label2;
    private DataGridView gvEventos;
    private DataGridViewImageColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private dsMemoMil _dsMemoMil;
    private dsConfig _dsCon;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEvento));
      this.nudDias = new NumericUpDown();
      this.panel1 = new Panel();
      this.label2 = new Label();
      this.label1 = new Label();
      this.gvEventos = new DataGridView();
      this.Column1 = new DataGridViewImageColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.nudDias.BeginInit();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.gvEventos).BeginInit();
      this.SuspendLayout();
      this.nudDias.Anchor = AnchorStyles.Top;
      this.nudDias.Location = new Point(301, 3);
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
      this.nudDias.TabIndex = 21;
      this.nudDias.Value = new Decimal(new int[4]
      {
        15,
        0,
        0,
        0
      });
      this.nudDias.ValueChanged += new EventHandler(this.nudDias_ValueChanged);
      this.panel1.BackColor = SystemColors.InactiveCaptionText;
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.nudDias);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(499, 26);
      this.panel1.TabIndex = 22;
      this.label2.Anchor = AnchorStyles.Top;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(122, 7);
      this.label2.Name = "label2";
      this.label2.Size = new Size(176, 13);
      this.label2.TabIndex = 23;
      this.label2.Text = "Visualizar Eventos para os Próximos";
      this.label1.Anchor = AnchorStyles.Top;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(351, 6);
      this.label1.Name = "label1";
      this.label1.Size = new Size(26, 13);
      this.label1.TabIndex = 22;
      this.label1.Text = "dias";
      this.gvEventos.AllowUserToAddRows = false;
      this.gvEventos.AllowUserToDeleteRows = false;
      this.gvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.gvEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      this.gvEventos.BackgroundColor = SystemColors.InactiveCaptionText;
      this.gvEventos.BorderStyle = BorderStyle.None;
      this.gvEventos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
      this.gvEventos.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4);
      this.gvEventos.Dock = DockStyle.Fill;
      this.gvEventos.Location = new Point(0, 26);
      this.gvEventos.MultiSelect = false;
      this.gvEventos.Name = "gvEventos";
      this.gvEventos.ReadOnly = true;
      this.gvEventos.RowHeadersVisible = false;
      this.gvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.gvEventos.Size = new Size(499, 199);
      this.gvEventos.TabIndex = 23;
      this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      this.Column1.HeaderText = "";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 5;
      this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.Column2.DefaultCellStyle = gridViewCellStyle2;
      this.Column2.HeaderText = "Em (dias)";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 75;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column3.DefaultCellStyle = gridViewCellStyle3;
      this.Column3.HeaderText = "Evento";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.Column4.DefaultCellStyle = gridViewCellStyle4;
      this.Column4.FillWeight = 50f;
      this.Column4.HeaderText = "Data";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(499, 225);
      this.Controls.Add((Control) this.gvEventos);
      this.Controls.Add((Control) this.panel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmEvento);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Próximos Eventos";
      this.WindowState = FormWindowState.Minimized;
      this.Load += new EventHandler(this.frmEvento_Load);
      this.Shown += new EventHandler(this.frmEvento_Shown);
      this.nudDias.EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.gvEventos).EndInit();
      this.ResumeLayout(false);
    }

    public frmEvento() => this.InitializeComponent();

    private void frmEvento_Load(object sender, EventArgs e)
    {
      this.IniciarControles();
      this.PopularEventos();
    }

    private void nudDias_ValueChanged(object sender, EventArgs e) => this.PopularEventos();

    private void IniciarControles()
    {
      if (this._dsCon == null)
        this._dsCon = Util.CarregarDataSetConfiguracao();
      this.nudDias.Value = (Decimal) this._dsCon.Config1[0].NumDias;
    }

    public void PopularEventos()
    {
      if (this._dsMemoMil == null)
        this._dsMemoMil = Util.CarregarDataSet();
      if (this._dsCon == null)
        this._dsCon = Util.CarregarDataSetConfiguracao();
      Util.NormalizarDataSet(this._dsMemoMil);
      Util.SalvarDataSet(this._dsMemoMil);
      DataRow[] dataRowArray = this._dsMemoMil.Evento1.Select("", "DataLembrete");
      if (dataRowArray.Length == 0)
      {
        int num1 = (int) MessageBox.Show("Eventos não Cadastrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        Image image = (Image) null;
        this.gvEventos.Rows.Clear();
        foreach (dsMemoMil.Evento1Row evento1Row in dataRowArray)
        {
          int days = (evento1Row.DataLembrete - DateTime.Today).Days;
          if (!((Decimal) days > this.nudDias.Value))
          {
            int num2 = !(evento1Row.Tipo == "Aniversario") ? -1 : DateTime.Today.Year - evento1Row.DataEvento.Date.Year;
            string str = num2 == -1 || num2 >= 100 ? evento1Row.Descricao.Trim() : evento1Row.Descricao.Trim() + " (" + num2.ToString() + " anos)";
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            switch (evento1Row.Tipo)
            {
              case "Aniversario":
                image = (Image) Resources.Aniversario;
                dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(this._dsCon.Config1[0].CorAniversario);
                dataGridViewRow.DefaultCellStyle.ForeColor = Color.FromArgb(this._dsCon.Config1[0].CorAniversarioFore);
                break;
              case "Feriado":
                image = (Image) Resources.Feriado;
                dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(this._dsCon.Config1[0].CorFeriado);
                dataGridViewRow.DefaultCellStyle.ForeColor = Color.FromArgb(this._dsCon.Config1[0].CorFeriadoFore);
                break;
              case "Lembrete":
                image = (Image) Resources.Lembrete;
                dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(this._dsCon.Config1[0].CorLembrete);
                dataGridViewRow.DefaultCellStyle.ForeColor = Color.FromArgb(this._dsCon.Config1[0].CorLembreteFore);
                break;
            }
            dataGridViewRow.CreateCells(this.gvEventos, (object) image, (object) days.ToString(), (object) str, (object) evento1Row.DataLembrete.ToShortDateString());
            this.gvEventos.Rows.Add(dataGridViewRow);
          }
        }
        this.gvEventos.ClearSelection();
      }
    }

    private void frmEvento_Shown(object sender, EventArgs e) => this.WindowState = FormWindowState.Maximized;
  }
}
