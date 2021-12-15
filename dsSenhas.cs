// Decompiled with JetBrains decompiler
// Type: MemoMil.dsSenhas
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MemoMil
{
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [HelpKeyword("vs.data.DataSet")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlRoot("dsSenhas")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class dsSenhas : DataSet
  {
    private dsSenhas.SenhaDataTable tableSenha;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public dsSenhas()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected dsSenhas(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables[nameof (Senha)] != null)
            base.Tables.Add((DataTable) new dsSenhas.SenhaDataTable(dataSet.Tables[nameof (Senha)]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        else
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public dsSenhas.SenhaDataTable Senha => this.tableSenha;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DebuggerNonUserCode]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataTableCollection Tables => base.Tables;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
    public new DataRelationCollection Relations => base.Relations;

    [DebuggerNonUserCode]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    public override DataSet Clone()
    {
      dsSenhas dsSenhas = (dsSenhas) base.Clone();
      dsSenhas.InitVars();
      dsSenhas.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dsSenhas;
    }

    [DebuggerNonUserCode]
    protected override bool ShouldSerializeTables() => false;

    [DebuggerNonUserCode]
    protected override bool ShouldSerializeRelations() => false;

    [DebuggerNonUserCode]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["Senha"] != null)
          base.Tables.Add((DataTable) new dsSenhas.SenhaDataTable(dataSet.Tables["Senha"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
      else
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    internal void InitVars() => this.InitVars(true);

    [DebuggerNonUserCode]
    internal void InitVars(bool initTable)
    {
      this.tableSenha = (dsSenhas.SenhaDataTable) base.Tables["Senha"];
      if (!initTable || this.tableSenha == null)
        return;
      this.tableSenha.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = nameof (dsSenhas);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/dsSenhas.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableSenha = new dsSenhas.SenhaDataTable();
      base.Tables.Add((DataTable) this.tableSenha);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeSenha() => false;

    [DebuggerNonUserCode]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      dsSenhas dsSenhas = new dsSenhas();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dsSenhas.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsSenhas.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
          while (enumerator.MoveNext())
          {
            XmlSchema current = (XmlSchema) enumerator.Current;
            memoryStream2.SetLength(0L);
            current.Write((Stream) memoryStream2);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return typedDataSetSchema;
            }
          }
        }
        finally
        {
          memoryStream1?.Close();
          memoryStream2?.Close();
        }
      }
      xs.Add(schemaSerializable);
      return typedDataSetSchema;
    }

    public delegate void SenhaRowChangeEventHandler(object sender, dsSenhas.SenhaRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class SenhaDataTable : TypedTableBase<dsSenhas.SenhaRow>
    {
      private DataColumn columnUsuario;
      private DataColumn columnDescricao;
      private DataColumn columnSenha;

      [DebuggerNonUserCode]
      public SenhaDataTable()
      {
        this.TableName = "Senha";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal SenhaDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      protected SenhaDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn UsuarioColumn => this.columnUsuario;

      [DebuggerNonUserCode]
      public DataColumn DescricaoColumn => this.columnDescricao;

      [DebuggerNonUserCode]
      public DataColumn SenhaColumn => this.columnSenha;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsSenhas.SenhaRow this[int index] => (dsSenhas.SenhaRow) this.Rows[index];

      public event dsSenhas.SenhaRowChangeEventHandler SenhaRowChanging;

      public event dsSenhas.SenhaRowChangeEventHandler SenhaRowChanged;

      public event dsSenhas.SenhaRowChangeEventHandler SenhaRowDeleting;

      public event dsSenhas.SenhaRowChangeEventHandler SenhaRowDeleted;

      [DebuggerNonUserCode]
      public void AddSenhaRow(dsSenhas.SenhaRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsSenhas.SenhaRow AddSenhaRow(string Usuario, string Descricao, string Senha)
      {
        dsSenhas.SenhaRow row = (dsSenhas.SenhaRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) Usuario,
          (object) Descricao,
          (object) Senha
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsSenhas.SenhaRow FindByUsuarioDescricao(string Usuario, string Descricao) => (dsSenhas.SenhaRow) this.Rows.Find(new object[2]
      {
        (object) Usuario,
        (object) Descricao
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsSenhas.SenhaDataTable senhaDataTable = (dsSenhas.SenhaDataTable) base.Clone();
        senhaDataTable.InitVars();
        return (DataTable) senhaDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsSenhas.SenhaDataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnUsuario = this.Columns["Usuario"];
        this.columnDescricao = this.Columns["Descricao"];
        this.columnSenha = this.Columns["Senha"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnUsuario = new DataColumn("Usuario", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUsuario);
        this.columnDescricao = new DataColumn("Descricao", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescricao);
        this.columnSenha = new DataColumn("Senha", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSenha);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[2]
        {
          this.columnUsuario,
          this.columnDescricao
        }, true));
        this.columnUsuario.AllowDBNull = false;
        this.columnUsuario.MaxLength = 10;
        this.columnDescricao.AllowDBNull = false;
        this.columnDescricao.MaxLength = 50;
        this.columnSenha.MaxLength = (int) byte.MaxValue;
      }

      [DebuggerNonUserCode]
      public dsSenhas.SenhaRow NewSenhaRow() => (dsSenhas.SenhaRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsSenhas.SenhaRow(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsSenhas.SenhaRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.SenhaRowChanged == null)
          return;
        this.SenhaRowChanged((object) this, new dsSenhas.SenhaRowChangeEvent((dsSenhas.SenhaRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.SenhaRowChanging == null)
          return;
        this.SenhaRowChanging((object) this, new dsSenhas.SenhaRowChangeEvent((dsSenhas.SenhaRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.SenhaRowDeleted == null)
          return;
        this.SenhaRowDeleted((object) this, new dsSenhas.SenhaRowChangeEvent((dsSenhas.SenhaRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.SenhaRowDeleting == null)
          return;
        this.SenhaRowDeleting((object) this, new dsSenhas.SenhaRowChangeEvent((dsSenhas.SenhaRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveSenhaRow(dsSenhas.SenhaRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsSenhas dsSenhas = new dsSenhas();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        xmlSchemaAny1.MinOccurs = 0M;
        xmlSchemaAny1.MaxOccurs = Decimal.MaxValue;
        xmlSchemaAny1.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny1);
        XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
        xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        xmlSchemaAny2.MinOccurs = 1M;
        xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "namespace",
          FixedValue = dsSenhas.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (SenhaDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsSenhas.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
            while (enumerator.MoveNext())
            {
              XmlSchema current = (XmlSchema) enumerator.Current;
              memoryStream2.SetLength(0L);
              current.Write((Stream) memoryStream2);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return typedTableSchema;
              }
            }
          }
          finally
          {
            memoryStream1?.Close();
            memoryStream2?.Close();
          }
        }
        xs.Add(schemaSerializable);
        return typedTableSchema;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SenhaRow : DataRow
    {
      private dsSenhas.SenhaDataTable tableSenha;

      [DebuggerNonUserCode]
      internal SenhaRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSenha = (dsSenhas.SenhaDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string Usuario
      {
        get => (string) this[this.tableSenha.UsuarioColumn];
        set => this[this.tableSenha.UsuarioColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Descricao
      {
        get => (string) this[this.tableSenha.DescricaoColumn];
        set => this[this.tableSenha.DescricaoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Senha
      {
        get
        {
          try
          {
            return (string) this[this.tableSenha.SenhaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Senha' in table 'Senha' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableSenha.SenhaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSenhaNull() => this.IsNull(this.tableSenha.SenhaColumn);

      [DebuggerNonUserCode]
      public void SetSenhaNull() => this[this.tableSenha.SenhaColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class SenhaRowChangeEvent : EventArgs
    {
      private dsSenhas.SenhaRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public SenhaRowChangeEvent(dsSenhas.SenhaRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsSenhas.SenhaRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
