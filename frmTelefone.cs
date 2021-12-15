// Decompiled with JetBrains decompiler
// Type: MemoMil.frmTelefone
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using MemoMil.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MemoMil
{
  public class frmTelefone : Form
  {
    private IContainer components;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TextBox txtNome;
    private Panel pnNome;
    private Button btnNomeCancelar;
    private Button btnNomeOK;
    private Label label2;
    private Panel pnTelefone;
    private Button btnTelefoneCancelar;
    private Button btnTelefonesOK;
    private TextBox txtTelefones;
    private Label label1;
    private Panel pnEmail;
    private Button btnEmailCancela;
    private Button btnEmailOK;
    private TextBox txtEmail;
    private Label label3;
    private TableLayoutPanel tblPainelAZ;
    private Panel panel1;
    private RadioButton rbAZ;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private RadioButton radioButton5;
    private RadioButton radioButton6;
    private RadioButton radioButton7;
    private RadioButton radioButton8;
    private RadioButton radioButton9;
    private RadioButton radioButton10;
    private RadioButton radioButton11;
    private RadioButton radioButton12;
    private RadioButton radioButton13;
    private RadioButton radioButton14;
    private RadioButton radioButton15;
    private RadioButton radioButton16;
    private RadioButton radioButton17;
    private RadioButton radioButton18;
    private RadioButton radioButton19;
    private RadioButton radioButton20;
    private RadioButton radioButton21;
    private RadioButton radioButton22;
    private RadioButton radioButton23;
    private RadioButton radioButton24;
    private RadioButton radioButton25;
    private RadioButton radioButton26;
    private Panel panel2;
    private Panel pnCabecEmail;
    private Label lblTituloCab;
    private Button btnFechar;
    private Panel pnCabecTelefone;
    private Label label4;
    private Button button1;
    private Button btnExcluir;
    private Panel pnCabecNome;
    private Label label5;
    private Button button2;
    private Label _LabelNome;
    private ListBox _ListTelefone;
    private ListBox _ListEmail;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmTelefone));
      this.tabPage3 = new TabPage();
      this.tabPage4 = new TabPage();
      this.txtNome = new TextBox();
      this.pnNome = new Panel();
      this.btnNomeCancelar = new Button();
      this.btnNomeOK = new Button();
      this.label2 = new Label();
      this.pnTelefone = new Panel();
      this.btnTelefoneCancelar = new Button();
      this.btnTelefonesOK = new Button();
      this.txtTelefones = new TextBox();
      this.label1 = new Label();
      this.pnEmail = new Panel();
      this.btnEmailCancela = new Button();
      this.btnEmailOK = new Button();
      this.txtEmail = new TextBox();
      this.label3 = new Label();
      this.rbAZ = new RadioButton();
      this.radioButton1 = new RadioButton();
      this.radioButton2 = new RadioButton();
      this.radioButton3 = new RadioButton();
      this.radioButton4 = new RadioButton();
      this.radioButton5 = new RadioButton();
      this.radioButton6 = new RadioButton();
      this.radioButton7 = new RadioButton();
      this.radioButton8 = new RadioButton();
      this.radioButton9 = new RadioButton();
      this.radioButton10 = new RadioButton();
      this.radioButton11 = new RadioButton();
      this.radioButton12 = new RadioButton();
      this.radioButton13 = new RadioButton();
      this.radioButton14 = new RadioButton();
      this.radioButton15 = new RadioButton();
      this.radioButton16 = new RadioButton();
      this.radioButton17 = new RadioButton();
      this.radioButton18 = new RadioButton();
      this.radioButton19 = new RadioButton();
      this.radioButton20 = new RadioButton();
      this.radioButton21 = new RadioButton();
      this.radioButton22 = new RadioButton();
      this.radioButton23 = new RadioButton();
      this.radioButton24 = new RadioButton();
      this.radioButton25 = new RadioButton();
      this.radioButton26 = new RadioButton();
      this.panel2 = new Panel();
      this.panel1 = new Panel();
      this.tblPainelAZ = new TableLayoutPanel();
      this.pnCabecEmail = new Panel();
      this.lblTituloCab = new Label();
      this.btnFechar = new Button();
      this.pnCabecTelefone = new Panel();
      this.label4 = new Label();
      this.button1 = new Button();
      this.pnCabecNome = new Panel();
      this.label5 = new Label();
      this.button2 = new Button();
      this.btnExcluir = new Button();
      this.pnNome.SuspendLayout();
      this.pnTelefone.SuspendLayout();
      this.pnEmail.SuspendLayout();
      this.panel1.SuspendLayout();
      this.pnCabecEmail.SuspendLayout();
      this.pnCabecTelefone.SuspendLayout();
      this.pnCabecNome.SuspendLayout();
      this.SuspendLayout();
      this.tabPage3.Location = new Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(491, 199);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "A";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage4.Location = new Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new Padding(3);
      this.tabPage4.Size = new Size(491, 199);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "B";
      this.tabPage4.UseVisualStyleBackColor = true;
      this.txtNome.Location = new Point(6, 39);
      this.txtNome.MaxLength = 35;
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new Size(268, 20);
      this.txtNome.TabIndex = 1;
      this.pnNome.BackColor = SystemColors.ControlLight;
      this.pnNome.BorderStyle = BorderStyle.FixedSingle;
      this.pnNome.Controls.Add((Control) this.btnExcluir);
      this.pnNome.Controls.Add((Control) this.pnCabecNome);
      this.pnNome.Controls.Add((Control) this.btnNomeCancelar);
      this.pnNome.Controls.Add((Control) this.btnNomeOK);
      this.pnNome.Controls.Add((Control) this.label2);
      this.pnNome.Controls.Add((Control) this.txtNome);
      this.pnNome.Location = new Point(37, 73);
      this.pnNome.Name = "pnNome";
      this.pnNome.Size = new Size(283, 94);
      this.pnNome.TabIndex = 2;
      this.pnNome.Visible = false;
      this.btnNomeCancelar.Location = new Point(199, 64);
      this.btnNomeCancelar.Name = "btnNomeCancelar";
      this.btnNomeCancelar.Size = new Size(75, 23);
      this.btnNomeCancelar.TabIndex = 4;
      this.btnNomeCancelar.Text = "&Cancelar";
      this.btnNomeCancelar.UseVisualStyleBackColor = true;
      this.btnNomeCancelar.Click += new EventHandler(this.btnNomeCancelar_Click);
      this.btnNomeOK.Location = new Point(6, 64);
      this.btnNomeOK.Name = "btnNomeOK";
      this.btnNomeOK.Size = new Size(75, 23);
      this.btnNomeOK.TabIndex = 3;
      this.btnNomeOK.Text = "&OK";
      this.btnNomeOK.UseVisualStyleBackColor = true;
      this.btnNomeOK.Click += new EventHandler(this.btnNomeOK_Click);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(3, 23);
      this.label2.Name = "label2";
      this.label2.Size = new Size(132, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Alterar o Nome do Contato";
      this.pnTelefone.BackColor = SystemColors.ControlLight;
      this.pnTelefone.BorderStyle = BorderStyle.FixedSingle;
      this.pnTelefone.Controls.Add((Control) this.pnCabecTelefone);
      this.pnTelefone.Controls.Add((Control) this.btnTelefoneCancelar);
      this.pnTelefone.Controls.Add((Control) this.btnTelefonesOK);
      this.pnTelefone.Controls.Add((Control) this.txtTelefones);
      this.pnTelefone.Controls.Add((Control) this.label1);
      this.pnTelefone.Location = new Point(37, 35);
      this.pnTelefone.Name = "pnTelefone";
      this.pnTelefone.Size = new Size(265, 165);
      this.pnTelefone.TabIndex = 3;
      this.pnTelefone.Visible = false;
      this.btnTelefoneCancelar.Location = new Point(182, 137);
      this.btnTelefoneCancelar.Name = "btnTelefoneCancelar";
      this.btnTelefoneCancelar.Size = new Size(75, 23);
      this.btnTelefoneCancelar.TabIndex = 3;
      this.btnTelefoneCancelar.Text = "&Cancelar";
      this.btnTelefoneCancelar.UseVisualStyleBackColor = true;
      this.btnTelefoneCancelar.Click += new EventHandler(this.btnTelefoneCancelar_Click);
      this.btnTelefonesOK.Location = new Point(7, 137);
      this.btnTelefonesOK.Name = "btnTelefonesOK";
      this.btnTelefonesOK.Size = new Size(75, 23);
      this.btnTelefonesOK.TabIndex = 2;
      this.btnTelefonesOK.Text = "&OK";
      this.btnTelefonesOK.UseVisualStyleBackColor = true;
      this.btnTelefonesOK.Click += new EventHandler(this.btnTelefonesOK_Click);
      this.txtTelefones.Location = new Point(7, 35);
      this.txtTelefones.Multiline = true;
      this.txtTelefones.Name = "txtTelefones";
      this.txtTelefones.ScrollBars = ScrollBars.Vertical;
      this.txtTelefones.Size = new Size(250, 94);
      this.txtTelefones.TabIndex = 1;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(4, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(253, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Alterar a Lista de Telefones (Um Telefone por Linha)";
      this.pnEmail.BackColor = SystemColors.Control;
      this.pnEmail.BorderStyle = BorderStyle.FixedSingle;
      this.pnEmail.Controls.Add((Control) this.pnCabecEmail);
      this.pnEmail.Controls.Add((Control) this.btnEmailCancela);
      this.pnEmail.Controls.Add((Control) this.btnEmailOK);
      this.pnEmail.Controls.Add((Control) this.txtEmail);
      this.pnEmail.Controls.Add((Control) this.label3);
      this.pnEmail.Location = new Point(141, 36);
      this.pnEmail.Name = "pnEmail";
      this.pnEmail.Size = new Size(265, 164);
      this.pnEmail.TabIndex = 4;
      this.pnEmail.Visible = false;
      this.btnEmailCancela.Location = new Point(182, 135);
      this.btnEmailCancela.Name = "btnEmailCancela";
      this.btnEmailCancela.Size = new Size(75, 23);
      this.btnEmailCancela.TabIndex = 3;
      this.btnEmailCancela.Text = "&Cancelar";
      this.btnEmailCancela.UseVisualStyleBackColor = true;
      this.btnEmailCancela.Click += new EventHandler(this.btnEmailCancela_Click);
      this.btnEmailOK.Location = new Point(7, 135);
      this.btnEmailOK.Name = "btnEmailOK";
      this.btnEmailOK.Size = new Size(75, 23);
      this.btnEmailOK.TabIndex = 2;
      this.btnEmailOK.Text = "&OK";
      this.btnEmailOK.UseVisualStyleBackColor = true;
      this.btnEmailOK.Click += new EventHandler(this.btnEmailOK_Click);
      this.txtEmail.Location = new Point(7, 35);
      this.txtEmail.Multiline = true;
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.ScrollBars = ScrollBars.Vertical;
      this.txtEmail.Size = new Size(250, 94);
      this.txtEmail.TabIndex = 1;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(4, 19);
      this.label3.Name = "label3";
      this.label3.Size = new Size(240, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Alterar a Lista de eMails (Um Endereço por Linha)";
      this.rbAZ.Appearance = Appearance.Button;
      this.rbAZ.CheckAlign = ContentAlignment.MiddleCenter;
      this.rbAZ.Checked = true;
      this.rbAZ.Location = new Point(0, 0);
      this.rbAZ.Name = "rbAZ";
      this.rbAZ.Size = new Size(29, 20);
      this.rbAZ.TabIndex = 4;
      this.rbAZ.TabStop = true;
      this.rbAZ.Text = "a-z";
      this.rbAZ.TextAlign = ContentAlignment.MiddleCenter;
      this.rbAZ.UseVisualStyleBackColor = true;
      this.rbAZ.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton1.Appearance = Appearance.Button;
      this.radioButton1.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton1.Location = new Point(28, 0);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new Size(19, 20);
      this.radioButton1.TabIndex = 6;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "a";
      this.radioButton1.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton2.Appearance = Appearance.Button;
      this.radioButton2.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton2.Location = new Point(64, 0);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new Size(19, 20);
      this.radioButton2.TabIndex = 8;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "c";
      this.radioButton2.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton3.Appearance = Appearance.Button;
      this.radioButton3.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton3.Location = new Point(46, 0);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new Size(19, 20);
      this.radioButton3.TabIndex = 7;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "b";
      this.radioButton3.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton4.Appearance = Appearance.Button;
      this.radioButton4.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton4.Location = new Point(136, 0);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new Size(19, 20);
      this.radioButton4.TabIndex = 12;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "g";
      this.radioButton4.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton5.Appearance = Appearance.Button;
      this.radioButton5.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton5.Location = new Point(118, 0);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new Size(19, 20);
      this.radioButton5.TabIndex = 11;
      this.radioButton5.TabStop = true;
      this.radioButton5.Text = "f";
      this.radioButton5.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton5.UseVisualStyleBackColor = true;
      this.radioButton5.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton6.Appearance = Appearance.Button;
      this.radioButton6.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton6.Location = new Point(100, 0);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new Size(19, 20);
      this.radioButton6.TabIndex = 10;
      this.radioButton6.TabStop = true;
      this.radioButton6.Text = "e";
      this.radioButton6.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton6.UseVisualStyleBackColor = true;
      this.radioButton6.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton7.Appearance = Appearance.Button;
      this.radioButton7.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton7.Location = new Point(82, 0);
      this.radioButton7.Name = "radioButton7";
      this.radioButton7.Size = new Size(19, 20);
      this.radioButton7.TabIndex = 9;
      this.radioButton7.TabStop = true;
      this.radioButton7.Text = "d";
      this.radioButton7.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton7.UseVisualStyleBackColor = true;
      this.radioButton7.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton8.Appearance = Appearance.Button;
      this.radioButton8.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton8.Location = new Point(280, 0);
      this.radioButton8.Name = "radioButton8";
      this.radioButton8.Size = new Size(19, 20);
      this.radioButton8.TabIndex = 20;
      this.radioButton8.TabStop = true;
      this.radioButton8.Text = "o";
      this.radioButton8.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton8.UseVisualStyleBackColor = true;
      this.radioButton8.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton9.Appearance = Appearance.Button;
      this.radioButton9.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton9.Location = new Point(262, 0);
      this.radioButton9.Name = "radioButton9";
      this.radioButton9.Size = new Size(19, 20);
      this.radioButton9.TabIndex = 19;
      this.radioButton9.TabStop = true;
      this.radioButton9.Text = "n";
      this.radioButton9.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton9.UseVisualStyleBackColor = true;
      this.radioButton9.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton10.Appearance = Appearance.Button;
      this.radioButton10.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton10.Location = new Point(244, 0);
      this.radioButton10.Name = "radioButton10";
      this.radioButton10.Size = new Size(19, 20);
      this.radioButton10.TabIndex = 18;
      this.radioButton10.TabStop = true;
      this.radioButton10.Text = "m";
      this.radioButton10.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton10.UseVisualStyleBackColor = true;
      this.radioButton10.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton11.Appearance = Appearance.Button;
      this.radioButton11.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton11.Location = new Point(226, 0);
      this.radioButton11.Name = "radioButton11";
      this.radioButton11.Size = new Size(19, 20);
      this.radioButton11.TabIndex = 17;
      this.radioButton11.TabStop = true;
      this.radioButton11.Text = "l";
      this.radioButton11.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton11.UseVisualStyleBackColor = true;
      this.radioButton11.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton12.Appearance = Appearance.Button;
      this.radioButton12.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton12.Location = new Point(208, 0);
      this.radioButton12.Name = "radioButton12";
      this.radioButton12.Size = new Size(19, 20);
      this.radioButton12.TabIndex = 16;
      this.radioButton12.TabStop = true;
      this.radioButton12.Text = "k";
      this.radioButton12.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton12.UseVisualStyleBackColor = true;
      this.radioButton12.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton13.Appearance = Appearance.Button;
      this.radioButton13.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton13.Location = new Point(190, 0);
      this.radioButton13.Name = "radioButton13";
      this.radioButton13.Size = new Size(19, 20);
      this.radioButton13.TabIndex = 15;
      this.radioButton13.TabStop = true;
      this.radioButton13.Text = "j";
      this.radioButton13.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton13.UseVisualStyleBackColor = true;
      this.radioButton13.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton14.Appearance = Appearance.Button;
      this.radioButton14.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton14.Location = new Point(172, 0);
      this.radioButton14.Name = "radioButton14";
      this.radioButton14.Size = new Size(19, 20);
      this.radioButton14.TabIndex = 14;
      this.radioButton14.TabStop = true;
      this.radioButton14.Text = "i";
      this.radioButton14.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton14.UseVisualStyleBackColor = true;
      this.radioButton14.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton15.Appearance = Appearance.Button;
      this.radioButton15.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton15.Location = new Point(154, 0);
      this.radioButton15.Name = "radioButton15";
      this.radioButton15.Size = new Size(19, 20);
      this.radioButton15.TabIndex = 13;
      this.radioButton15.TabStop = true;
      this.radioButton15.Text = "h";
      this.radioButton15.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton15.UseVisualStyleBackColor = true;
      this.radioButton15.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton16.Appearance = Appearance.Button;
      this.radioButton16.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton16.Location = new Point(478, 0);
      this.radioButton16.Name = "radioButton16";
      this.radioButton16.Size = new Size(19, 20);
      this.radioButton16.TabIndex = 31;
      this.radioButton16.TabStop = true;
      this.radioButton16.Text = "z";
      this.radioButton16.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton16.UseVisualStyleBackColor = true;
      this.radioButton16.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton17.Appearance = Appearance.Button;
      this.radioButton17.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton17.Location = new Point(460, 0);
      this.radioButton17.Name = "radioButton17";
      this.radioButton17.Size = new Size(19, 20);
      this.radioButton17.TabIndex = 30;
      this.radioButton17.TabStop = true;
      this.radioButton17.Text = "y";
      this.radioButton17.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton17.UseVisualStyleBackColor = true;
      this.radioButton17.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton18.Appearance = Appearance.Button;
      this.radioButton18.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton18.Location = new Point(442, 0);
      this.radioButton18.Name = "radioButton18";
      this.radioButton18.Size = new Size(19, 20);
      this.radioButton18.TabIndex = 29;
      this.radioButton18.TabStop = true;
      this.radioButton18.Text = "x";
      this.radioButton18.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton18.UseVisualStyleBackColor = true;
      this.radioButton18.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton19.Appearance = Appearance.Button;
      this.radioButton19.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton19.Location = new Point(424, 0);
      this.radioButton19.Name = "radioButton19";
      this.radioButton19.Size = new Size(19, 20);
      this.radioButton19.TabIndex = 28;
      this.radioButton19.TabStop = true;
      this.radioButton19.Text = "w";
      this.radioButton19.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton19.UseVisualStyleBackColor = true;
      this.radioButton19.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton20.Appearance = Appearance.Button;
      this.radioButton20.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton20.Location = new Point(406, 0);
      this.radioButton20.Name = "radioButton20";
      this.radioButton20.Size = new Size(19, 20);
      this.radioButton20.TabIndex = 27;
      this.radioButton20.TabStop = true;
      this.radioButton20.Text = "v";
      this.radioButton20.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton20.UseVisualStyleBackColor = true;
      this.radioButton20.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton21.Appearance = Appearance.Button;
      this.radioButton21.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton21.Location = new Point(388, 0);
      this.radioButton21.Name = "radioButton21";
      this.radioButton21.Size = new Size(19, 20);
      this.radioButton21.TabIndex = 26;
      this.radioButton21.TabStop = true;
      this.radioButton21.Text = "u";
      this.radioButton21.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton21.UseVisualStyleBackColor = true;
      this.radioButton21.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton22.Appearance = Appearance.Button;
      this.radioButton22.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton22.Location = new Point(370, 0);
      this.radioButton22.Name = "radioButton22";
      this.radioButton22.Size = new Size(19, 20);
      this.radioButton22.TabIndex = 25;
      this.radioButton22.TabStop = true;
      this.radioButton22.Text = "t";
      this.radioButton22.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton22.UseVisualStyleBackColor = true;
      this.radioButton22.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton23.Appearance = Appearance.Button;
      this.radioButton23.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton23.Location = new Point(352, 0);
      this.radioButton23.Name = "radioButton23";
      this.radioButton23.Size = new Size(19, 20);
      this.radioButton23.TabIndex = 24;
      this.radioButton23.TabStop = true;
      this.radioButton23.Text = "s";
      this.radioButton23.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton23.UseVisualStyleBackColor = true;
      this.radioButton23.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton24.Appearance = Appearance.Button;
      this.radioButton24.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton24.Location = new Point(334, 0);
      this.radioButton24.Name = "radioButton24";
      this.radioButton24.Size = new Size(19, 20);
      this.radioButton24.TabIndex = 23;
      this.radioButton24.TabStop = true;
      this.radioButton24.Text = "r";
      this.radioButton24.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton24.UseVisualStyleBackColor = true;
      this.radioButton24.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton25.Appearance = Appearance.Button;
      this.radioButton25.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton25.Location = new Point(316, 0);
      this.radioButton25.Name = "radioButton25";
      this.radioButton25.Size = new Size(19, 20);
      this.radioButton25.TabIndex = 22;
      this.radioButton25.TabStop = true;
      this.radioButton25.Text = "q";
      this.radioButton25.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton25.UseVisualStyleBackColor = true;
      this.radioButton25.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.radioButton26.Appearance = Appearance.Button;
      this.radioButton26.CheckAlign = ContentAlignment.MiddleCenter;
      this.radioButton26.Location = new Point(298, 0);
      this.radioButton26.Name = "radioButton26";
      this.radioButton26.Size = new Size(19, 20);
      this.radioButton26.TabIndex = 21;
      this.radioButton26.TabStop = true;
      this.radioButton26.Text = "p";
      this.radioButton26.TextAlign = ContentAlignment.MiddleCenter;
      this.radioButton26.UseVisualStyleBackColor = true;
      this.radioButton26.CheckedChanged += new EventHandler(this.radioButton16_CheckedChanged);
      this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.panel2.BackgroundImage = (Image) Resources.border43;
      this.panel2.Location = new Point(0, 22);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(28, 203);
      this.panel2.TabIndex = 32;
      this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.panel1.AutoScroll = true;
      this.panel1.BackgroundImage = (Image) Resources.border45;
      this.panel1.Controls.Add((Control) this.tblPainelAZ);
      this.panel1.Location = new Point(28, 22);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(518, 204);
      this.panel1.TabIndex = 5;
      this.tblPainelAZ.AutoSize = true;
      this.tblPainelAZ.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.tblPainelAZ.BackColor = Color.Transparent;
      this.tblPainelAZ.ColumnCount = 3;
      this.tblPainelAZ.ColumnStyles.Add(new ColumnStyle());
      this.tblPainelAZ.ColumnStyles.Add(new ColumnStyle());
      this.tblPainelAZ.ColumnStyles.Add(new ColumnStyle());
      this.tblPainelAZ.Location = new Point(3, 3);
      this.tblPainelAZ.Name = "tblPainelAZ";
      this.tblPainelAZ.RowCount = 1;
      this.tblPainelAZ.RowStyles.Add(new RowStyle());
      this.tblPainelAZ.Size = new Size(0, 0);
      this.tblPainelAZ.TabIndex = 2;
      this.tblPainelAZ.Visible = false;
      this.pnCabecEmail.BackColor = SystemColors.ActiveCaption;
      this.pnCabecEmail.Controls.Add((Control) this.lblTituloCab);
      this.pnCabecEmail.Controls.Add((Control) this.btnFechar);
      this.pnCabecEmail.Cursor = Cursors.NoMove2D;
      this.pnCabecEmail.Dock = DockStyle.Top;
      this.pnCabecEmail.Location = new Point(0, 0);
      this.pnCabecEmail.Name = "pnCabecEmail";
      this.pnCabecEmail.Size = new Size(263, 18);
      this.pnCabecEmail.TabIndex = 12;
      this.lblTituloCab.AutoSize = true;
      this.lblTituloCab.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTituloCab.ForeColor = Color.White;
      this.lblTituloCab.Location = new Point(0, 3);
      this.lblTituloCab.Name = "lblTituloCab";
      this.lblTituloCab.Size = new Size(0, 13);
      this.lblTituloCab.TabIndex = 1;
      this.btnFechar.Cursor = Cursors.Default;
      this.btnFechar.Image = (Image) Resources.BotaoFechar;
      this.btnFechar.Location = new Point(245, -1);
      this.btnFechar.Name = "btnFechar";
      this.btnFechar.Size = new Size(18, 18);
      this.btnFechar.TabIndex = 0;
      this.btnFechar.UseVisualStyleBackColor = true;
      this.btnFechar.Click += new EventHandler(this.btnEmailCancela_Click);
      this.pnCabecTelefone.BackColor = SystemColors.ActiveCaption;
      this.pnCabecTelefone.Controls.Add((Control) this.label4);
      this.pnCabecTelefone.Controls.Add((Control) this.button1);
      this.pnCabecTelefone.Cursor = Cursors.NoMove2D;
      this.pnCabecTelefone.Dock = DockStyle.Top;
      this.pnCabecTelefone.Location = new Point(0, 0);
      this.pnCabecTelefone.Name = "pnCabecTelefone";
      this.pnCabecTelefone.Size = new Size(263, 18);
      this.pnCabecTelefone.TabIndex = 13;
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(0, 3);
      this.label4.Name = "label4";
      this.label4.Size = new Size(0, 13);
      this.label4.TabIndex = 1;
      this.button1.Cursor = Cursors.Default;
      this.button1.Image = (Image) Resources.BotaoFechar;
      this.button1.Location = new Point(245, -1);
      this.button1.Name = "button1";
      this.button1.Size = new Size(18, 18);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.btnTelefoneCancelar_Click);
      this.pnCabecNome.BackColor = SystemColors.ActiveCaption;
      this.pnCabecNome.Controls.Add((Control) this.label5);
      this.pnCabecNome.Controls.Add((Control) this.button2);
      this.pnCabecNome.Cursor = Cursors.NoMove2D;
      this.pnCabecNome.Dock = DockStyle.Top;
      this.pnCabecNome.Location = new Point(0, 0);
      this.pnCabecNome.Name = "pnCabecNome";
      this.pnCabecNome.Size = new Size(281, 18);
      this.pnCabecNome.TabIndex = 14;
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = Color.White;
      this.label5.Location = new Point(0, 3);
      this.label5.Name = "label5";
      this.label5.Size = new Size(0, 13);
      this.label5.TabIndex = 1;
      this.button2.Cursor = Cursors.Default;
      this.button2.Image = (Image) Resources.BotaoFechar;
      this.button2.Location = new Point(262, -1);
      this.button2.Name = "button2";
      this.button2.Size = new Size(18, 18);
      this.button2.TabIndex = 0;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.btnNomeCancelar_Click);
      this.btnExcluir.Location = new Point(97, 64);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new Size(87, 23);
      this.btnExcluir.TabIndex = 15;
      this.btnExcluir.Text = "Excluir Contato";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.InactiveCaptionText;
      this.ClientSize = new Size(546, 225);
      this.Controls.Add((Control) this.pnNome);
      this.Controls.Add((Control) this.pnTelefone);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.radioButton16);
      this.Controls.Add((Control) this.radioButton17);
      this.Controls.Add((Control) this.radioButton18);
      this.Controls.Add((Control) this.radioButton19);
      this.Controls.Add((Control) this.radioButton20);
      this.Controls.Add((Control) this.radioButton21);
      this.Controls.Add((Control) this.radioButton22);
      this.Controls.Add((Control) this.radioButton23);
      this.Controls.Add((Control) this.radioButton24);
      this.Controls.Add((Control) this.radioButton25);
      this.Controls.Add((Control) this.radioButton26);
      this.Controls.Add((Control) this.radioButton8);
      this.Controls.Add((Control) this.radioButton9);
      this.Controls.Add((Control) this.radioButton10);
      this.Controls.Add((Control) this.radioButton11);
      this.Controls.Add((Control) this.radioButton12);
      this.Controls.Add((Control) this.radioButton13);
      this.Controls.Add((Control) this.radioButton14);
      this.Controls.Add((Control) this.radioButton15);
      this.Controls.Add((Control) this.radioButton4);
      this.Controls.Add((Control) this.radioButton5);
      this.Controls.Add((Control) this.radioButton6);
      this.Controls.Add((Control) this.radioButton7);
      this.Controls.Add((Control) this.radioButton2);
      this.Controls.Add((Control) this.radioButton3);
      this.Controls.Add((Control) this.radioButton1);
      this.Controls.Add((Control) this.rbAZ);
      this.Controls.Add((Control) this.pnEmail);
      this.Controls.Add((Control) this.panel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmTelefone);
      this.StartPosition = FormStartPosition.CenterParent;
      this.WindowState = FormWindowState.Minimized;
      this.Load += new EventHandler(this.frmTelefone_Load);
      this.Shown += new EventHandler(this.frmTelefone_Shown);
      this.pnNome.ResumeLayout(false);
      this.pnNome.PerformLayout();
      this.pnTelefone.ResumeLayout(false);
      this.pnTelefone.PerformLayout();
      this.pnEmail.ResumeLayout(false);
      this.pnEmail.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.pnCabecEmail.ResumeLayout(false);
      this.pnCabecEmail.PerformLayout();
      this.pnCabecTelefone.ResumeLayout(false);
      this.pnCabecTelefone.PerformLayout();
      this.pnCabecNome.ResumeLayout(false);
      this.pnCabecNome.PerformLayout();
      this.ResumeLayout(false);
    }

    public frmTelefone()
    {
      this.InitializeComponent();
      ControlMover.Init((Control) this.pnCabecEmail, (Control) this.pnEmail, ControlMover.Direction.Any);
      ControlMover.Init((Control) this.pnCabecTelefone, (Control) this.pnTelefone, ControlMover.Direction.Any);
      ControlMover.Init((Control) this.pnCabecNome, (Control) this.pnNome, ControlMover.Direction.Any);
    }

    private void frmTelefone_Load(object sender, EventArgs e)
    {
      try
      {
        this.RecuperarContatos();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void frmTelefone_Shown(object sender, EventArgs e) => this.WindowState = FormWindowState.Maximized;

    private void lblNome_Click(object sender, EventArgs e)
    {
      try
      {
        Label label = (Label) sender;
        this._LabelNome = label;
        if (label.Text.Trim() == "<< NOVO CONTATO >>")
          this.txtNome.Text = "";
        else
          this.txtNome.Text = label.Text;
        this.pnNome.Top = (this.Height - this.pnNome.Height) / 3;
        this.pnNome.Left = (this.Width - this.pnNome.Width) / 2;
        this.pnNome.Visible = true;
        this.txtNome.Focus();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lblNome_MouseEnter(object sender, EventArgs e) => ((Control) sender).BackColor = Color.LightGray;

    private void lblNome_MouseLeave(object sender, EventArgs e) => ((Control) sender).BackColor = Color.Empty;

    private void btnNomeCancelar_Click(object sender, EventArgs e) => this.pnNome.Visible = false;

    private void btnNomeOK_Click(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrEmpty(this.txtNome.Text))
        {
          int num1 = (int) MessageBox.Show("Informar um Nome para o Contato!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (this.txtNome.Text.Trim().Length > 35)
        {
          int num2 = (int) MessageBox.Show("O Nome do Contato não pode ter mais de 35 Caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          this._LabelNome.Text = this.txtNome.Text.Trim();
          this.pnNome.Visible = false;
          if (this._LabelNome.Tag.ToString() == "-1")
          {
            int x = this.CriarContato(this._LabelNome.Text.Trim());
            this._LabelNome.Tag = (object) x;
            this.AtualizarControlesNovo(this.Controls, x);
            this.CriarRodaPe();
          }
          else
            this.AlterarContato(int.Parse(this._LabelNome.Tag.ToString()), this._LabelNome.Text.Trim());
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      try
      {
        this.pnNome.Visible = false;
        if (this._LabelNome.Tag.ToString() == "-1")
          return;
        this.ExcluirContato(int.Parse(this._LabelNome.Tag.ToString()));
        this.RecuperarContatos();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lstTelefones_MouseLeave(object sender, EventArgs e) => ((Control) sender).BackColor = Color.Empty;

    private void lstTelefones_MouseEnter(object sender, EventArgs e) => ((Control) sender).BackColor = Color.LightGray;

    private void lstTelefones_Click(object sender, EventArgs e)
    {
      ListBox listBox = (ListBox) sender;
      this._ListTelefone = listBox;
      if (listBox.Tag.ToString() == "-1")
      {
        int num = (int) MessageBox.Show("Primeiro Criar Novo Contato (último item da lista) antes de Informar os Telefones!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        this.txtTelefones.Text = "";
        foreach (object obj in listBox.Items)
        {
          TextBox txtTelefones = this.txtTelefones;
          txtTelefones.Text = txtTelefones.Text + obj.ToString() + Environment.NewLine;
        }
        this.pnTelefone.Top = (this.Height - this.pnTelefone.Height) / 3;
        this.pnTelefone.Left = (this.Width - this.pnTelefone.Width) / 2;
        this.pnTelefone.Visible = true;
        this.txtTelefones.Focus();
      }
    }

    private void btnTelefoneCancelar_Click(object sender, EventArgs e) => this.pnTelefone.Visible = false;

    private void btnTelefonesOK_Click(object sender, EventArgs e)
    {
      try
      {
        this._ListTelefone.Items.Clear();
        string[] Telefones = this.txtTelefones.Text.Split(new string[1]
        {
          Environment.NewLine
        }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string str in Telefones)
        {
          if (str.Trim().Length > 30)
          {
            int num = (int) MessageBox.Show("Cada anotação de Telefone Não deve ter mais de 30 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
        }
        foreach (object obj in Telefones)
          this._ListTelefone.Items.Add(obj);
        this.AtualiarTelefones(int.Parse(this._ListTelefone.Tag.ToString()), Telefones);
        this.pnTelefone.Visible = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void lstEmail_MouseLeave(object sender, EventArgs e) => ((Control) sender).BackColor = Color.Empty;

    private void lstEmail_MouseEnter(object sender, EventArgs e) => ((Control) sender).BackColor = Color.LightGray;

    private void lstEmail_Click(object sender, EventArgs e)
    {
      ListBox listBox = (ListBox) sender;
      this._ListEmail = listBox;
      if (listBox.Tag.ToString() == "-1")
      {
        int num = (int) MessageBox.Show("Primeiro Criar Novo Contato (último item da lista) antes de Informar os Telefones!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        this.txtEmail.Text = "";
        foreach (object obj in listBox.Items)
        {
          TextBox txtEmail = this.txtEmail;
          txtEmail.Text = txtEmail.Text + obj.ToString() + Environment.NewLine;
        }
        this.pnEmail.Top = (this.Height - this.pnEmail.Height) / 3;
        this.pnEmail.Left = (this.Width - this.pnEmail.Width) / 2;
        this.pnEmail.Visible = true;
        this.txtEmail.Focus();
      }
    }

    private void btnEmailOK_Click(object sender, EventArgs e)
    {
      try
      {
        this._ListEmail.Items.Clear();
        string[] Emails = this.txtEmail.Text.Split(new string[1]
        {
          Environment.NewLine
        }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string str in Emails)
        {
          if (str.Trim().Length > 30)
          {
            int num = (int) MessageBox.Show("Cada anotação de eMail Não deve ter mais de 30 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
        }
        foreach (object obj in Emails)
          this._ListEmail.Items.Add(obj);
        this.AtualizarEmails(int.Parse(this._ListEmail.Tag.ToString()), Emails);
        this.pnEmail.Visible = false;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnEmailCancela_Click(object sender, EventArgs e) => this.pnEmail.Visible = false;

    private void RecuperarContatos()
    {
      this.tblPainelAZ.Visible = false;
      this.tblPainelAZ.Controls.Clear();
      foreach (dsContato.ContatoRow row in (InternalDataCollectionBase) Util.RecuperarContatos().Contato.Rows)
      {
        if (!(this.TAB.Text != "a-z") || !(row.nmContato.Substring(0, 1).ToLower() != this.TAB.Text))
        {
          Label lblNome = new Label();
          this.ConfiguraControleNome(lblNome);
          lblNome.Text = row.nmContato;
          lblNome.Tag = (object) row.cdContato;
          ListBox lstTelefones = new ListBox();
          this.ConfigurarControleTelefone(lstTelefones);
          lstTelefones.Tag = (object) row.cdContato;
          foreach (dsContato.TelefoneRow telefoneRow in row.GetTelefoneRows())
            lstTelefones.Items.Add((object) telefoneRow.nmTelefone);
          ListBox lstEmail = new ListBox();
          this.ConfigurarControlesEmail(lstEmail);
          lstEmail.Tag = (object) row.cdContato;
          foreach (dsContato.EmailRow emailRow in row.GetEmailRows())
            lstEmail.Items.Add((object) emailRow.nmEmail);
          this.tblPainelAZ.Controls.Add((Control) lblNome);
          this.tblPainelAZ.Controls.Add((Control) lstTelefones);
          this.tblPainelAZ.Controls.Add((Control) lstEmail);
        }
      }
      this.CriarRodaPe();
      this.tblPainelAZ.Visible = true;
    }

    private int CriarContato(string Nome) => Util.InserirContato(Nome);

    private void ExcluirContato(int cdContato) => Util.ExcluirContato(cdContato);

    private void AlterarContato(int cdContato, string Nome) => Util.AlterarContato(cdContato, Nome);

    private void AtualiarTelefones(int cdContato, string[] Telefones)
    {
      Util.ExcluirTelefonesDoContato(cdContato);
      foreach (string telefone in Telefones)
        Util.InserirTelefone(cdContato, telefone.Trim());
    }

    private void AtualizarEmails(int cdContato, string[] Emails)
    {
      Util.ExcluirEmailsdoContato(cdContato);
      foreach (string email in Emails)
        Util.InserirEmail(cdContato, email);
    }

    private void AtualizarControlesNovo(Control.ControlCollection ctrs, int x)
    {
      foreach (Control ctr in (ArrangedElementCollection) ctrs)
      {
        if (ctr.HasChildren)
          this.AtualizarControlesNovo(ctr.Controls, x);
        if (ctr is ListBox)
        {
          if (ctr.Tag.ToString() == "-1")
            ctr.Tag = (object) x.ToString();
        }
      }
    }

    private void CriarRodaPe()
    {
      Label lblNome = new Label();
      this.ConfiguraControleNome(lblNome);
      lblNome.Text = "<< NOVO CONTATO >>";
      lblNome.Tag = (object) "-1";
      this.tblPainelAZ.Controls.Add((Control) lblNome);
      ListBox lstTelefones = new ListBox();
      this.ConfigurarControleTelefone(lstTelefones);
      lstTelefones.Tag = (object) "-1";
      this.tblPainelAZ.Controls.Add((Control) lstTelefones);
      ListBox lstEmail = new ListBox();
      this.ConfigurarControlesEmail(lstEmail);
      lstEmail.Tag = (object) "-1";
      this.tblPainelAZ.Controls.Add((Control) lstEmail);
    }

    private void ConfiguraControleNome(Label lblNome)
    {
      lblNome.AutoSize = true;
      lblNome.Anchor = AnchorStyles.Left;
      lblNome.Cursor = Cursors.Hand;
      lblNome.Click += new EventHandler(this.lblNome_Click);
      lblNome.MouseEnter += new EventHandler(this.lblNome_MouseEnter);
      lblNome.MouseLeave += new EventHandler(this.lblNome_MouseLeave);
    }

    private void ConfigurarControleTelefone(ListBox lstTelefones)
    {
      lstTelefones.Height = 43;
      lstTelefones.Width = 185;
      lstTelefones.SelectionMode = SelectionMode.None;
      lstTelefones.Cursor = Cursors.Hand;
      lstTelefones.Click += new EventHandler(this.lstTelefones_Click);
      lstTelefones.MouseEnter += new EventHandler(this.lstTelefones_MouseEnter);
      lstTelefones.MouseLeave += new EventHandler(this.lstTelefones_MouseLeave);
    }

    private void ConfigurarControlesEmail(ListBox lstEmail)
    {
      lstEmail.Height = 43;
      lstEmail.Width = 185;
      lstEmail.SelectionMode = SelectionMode.None;
      lstEmail.Cursor = Cursors.Hand;
      lstEmail.Click += new EventHandler(this.lstEmail_Click);
      lstEmail.MouseEnter += new EventHandler(this.lstEmail_MouseEnter);
      lstEmail.MouseLeave += new EventHandler(this.lstEmail_MouseLeave);
    }

    private RadioButton TAB
    {
      get
      {
        RadioButton tab = (RadioButton) null;
        foreach (Control control in (ArrangedElementCollection) this.Controls)
        {
          if (control is RadioButton)
          {
            tab = (RadioButton) control;
            if (tab.Checked)
              break;
          }
        }
        return tab;
      }
    }

    private void radioButton16_CheckedChanged(object sender, EventArgs e)
    {
      if (!((RadioButton) sender).Checked)
        return;
      this.RecuperarContatos();
    }
  }
}
