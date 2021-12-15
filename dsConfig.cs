// Decompiled with JetBrains decompiler
// Type: MemoMil.dsConfig
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
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MemoMil
{
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [DesignerCategory("code")]
  [XmlRoot("dsConfig")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class dsConfig : DataSet
  {
    private dsConfig.Config1DataTable tableConfig1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public dsConfig()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected dsConfig(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Config1)] != null)
            base.Tables.Add((DataTable) new dsConfig.Config1DataTable(dataSet.Tables[nameof (Config1)]));
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

    [DebuggerNonUserCode]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public dsConfig.Config1DataTable Config1 => this.tableConfig1;

    [DebuggerNonUserCode]
    [Browsable(true)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables => base.Tables;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
      dsConfig dsConfig = (dsConfig) base.Clone();
      dsConfig.InitVars();
      dsConfig.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dsConfig;
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
        if (dataSet.Tables["Config1"] != null)
          base.Tables.Add((DataTable) new dsConfig.Config1DataTable(dataSet.Tables["Config1"]));
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
      this.tableConfig1 = (dsConfig.Config1DataTable) base.Tables["Config1"];
      if (!initTable || this.tableConfig1 == null)
        return;
      this.tableConfig1.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = nameof (dsConfig);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/dsConfig.xsd";
      this.Locale = new CultureInfo("en-US");
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableConfig1 = new dsConfig.Config1DataTable();
      base.Tables.Add((DataTable) this.tableConfig1);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeConfig1() => false;

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
      dsConfig dsConfig = new dsConfig();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dsConfig.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsConfig.GetSchemaSerializable();
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

    public delegate void Config1RowChangeEventHandler(
      object sender,
      dsConfig.Config1RowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class Config1DataTable : TypedTableBase<dsConfig.Config1Row>
    {
      private DataColumn columnCorAniversario;
      private DataColumn columnCorFeriado;
      private DataColumn columnCorLembrete;
      private DataColumn columnCorAniversarioFore;
      private DataColumn columnCorFeriadoFore;
      private DataColumn columnCorLembreteFore;
      private DataColumn columncdConfig;
      private DataColumn columnNumDias;

      [DebuggerNonUserCode]
      public Config1DataTable()
      {
        this.TableName = "Config1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Config1DataTable(DataTable table)
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
      protected Config1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn CorAniversarioColumn => this.columnCorAniversario;

      [DebuggerNonUserCode]
      public DataColumn CorFeriadoColumn => this.columnCorFeriado;

      [DebuggerNonUserCode]
      public DataColumn CorLembreteColumn => this.columnCorLembrete;

      [DebuggerNonUserCode]
      public DataColumn CorAniversarioForeColumn => this.columnCorAniversarioFore;

      [DebuggerNonUserCode]
      public DataColumn CorFeriadoForeColumn => this.columnCorFeriadoFore;

      [DebuggerNonUserCode]
      public DataColumn CorLembreteForeColumn => this.columnCorLembreteFore;

      [DebuggerNonUserCode]
      public DataColumn cdConfigColumn => this.columncdConfig;

      [DebuggerNonUserCode]
      public DataColumn NumDiasColumn => this.columnNumDias;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsConfig.Config1Row this[int index] => (dsConfig.Config1Row) this.Rows[index];

      public event dsConfig.Config1RowChangeEventHandler Config1RowChanging;

      public event dsConfig.Config1RowChangeEventHandler Config1RowChanged;

      public event dsConfig.Config1RowChangeEventHandler Config1RowDeleting;

      public event dsConfig.Config1RowChangeEventHandler Config1RowDeleted;

      [DebuggerNonUserCode]
      public void AddConfig1Row(dsConfig.Config1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsConfig.Config1Row AddConfig1Row(
        int CorAniversario,
        int CorFeriado,
        int CorLembrete,
        int CorAniversarioFore,
        int CorFeriadoFore,
        int CorLembreteFore,
        int cdConfig,
        int NumDias)
      {
        dsConfig.Config1Row row = (dsConfig.Config1Row) this.NewRow();
        object[] objArray = new object[8]
        {
          (object) CorAniversario,
          (object) CorFeriado,
          (object) CorLembrete,
          (object) CorAniversarioFore,
          (object) CorFeriadoFore,
          (object) CorLembreteFore,
          (object) cdConfig,
          (object) NumDias
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsConfig.Config1Row FindBycdConfig(int cdConfig) => (dsConfig.Config1Row) this.Rows.Find(new object[1]
      {
        (object) cdConfig
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsConfig.Config1DataTable config1DataTable = (dsConfig.Config1DataTable) base.Clone();
        config1DataTable.InitVars();
        return (DataTable) config1DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsConfig.Config1DataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnCorAniversario = this.Columns["CorAniversario"];
        this.columnCorFeriado = this.Columns["CorFeriado"];
        this.columnCorLembrete = this.Columns["CorLembrete"];
        this.columnCorAniversarioFore = this.Columns["CorAniversarioFore"];
        this.columnCorFeriadoFore = this.Columns["CorFeriadoFore"];
        this.columnCorLembreteFore = this.Columns["CorLembreteFore"];
        this.columncdConfig = this.Columns["cdConfig"];
        this.columnNumDias = this.Columns["NumDias"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnCorAniversario = new DataColumn("CorAniversario", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCorAniversario);
        this.columnCorFeriado = new DataColumn("CorFeriado", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCorFeriado);
        this.columnCorLembrete = new DataColumn("CorLembrete", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCorLembrete);
        this.columnCorAniversarioFore = new DataColumn("CorAniversarioFore", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCorAniversarioFore);
        this.columnCorFeriadoFore = new DataColumn("CorFeriadoFore", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCorFeriadoFore);
        this.columnCorLembreteFore = new DataColumn("CorLembreteFore", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCorLembreteFore);
        this.columncdConfig = new DataColumn("cdConfig", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncdConfig);
        this.columnNumDias = new DataColumn("NumDias", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnNumDias);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columncdConfig
        }, true));
        this.columncdConfig.AllowDBNull = false;
        this.columncdConfig.Unique = true;
      }

      [DebuggerNonUserCode]
      public dsConfig.Config1Row NewConfig1Row() => (dsConfig.Config1Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsConfig.Config1Row(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsConfig.Config1Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Config1RowChanged == null)
          return;
        this.Config1RowChanged((object) this, new dsConfig.Config1RowChangeEvent((dsConfig.Config1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Config1RowChanging == null)
          return;
        this.Config1RowChanging((object) this, new dsConfig.Config1RowChangeEvent((dsConfig.Config1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Config1RowDeleted == null)
          return;
        this.Config1RowDeleted((object) this, new dsConfig.Config1RowChangeEvent((dsConfig.Config1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Config1RowDeleting == null)
          return;
        this.Config1RowDeleting((object) this, new dsConfig.Config1RowChangeEvent((dsConfig.Config1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveConfig1Row(dsConfig.Config1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsConfig dsConfig = new dsConfig();
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
          FixedValue = dsConfig.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Config1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsConfig.GetSchemaSerializable();
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
    public class Config1Row : DataRow
    {
      private dsConfig.Config1DataTable tableConfig1;

      [DebuggerNonUserCode]
      internal Config1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableConfig1 = (dsConfig.Config1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int CorAniversario
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.CorAniversarioColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CorAniversario' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.CorAniversarioColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int CorFeriado
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.CorFeriadoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CorFeriado' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.CorFeriadoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int CorLembrete
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.CorLembreteColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CorLembrete' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.CorLembreteColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int CorAniversarioFore
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.CorAniversarioForeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CorAniversarioFore' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.CorAniversarioForeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int CorFeriadoFore
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.CorFeriadoForeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CorFeriadoFore' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.CorFeriadoForeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int CorLembreteFore
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.CorLembreteForeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'CorLembreteFore' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.CorLembreteForeColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int cdConfig
      {
        get => (int) this[this.tableConfig1.cdConfigColumn];
        set => this[this.tableConfig1.cdConfigColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int NumDias
      {
        get
        {
          try
          {
            return (int) this[this.tableConfig1.NumDiasColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'NumDias' in table 'Config1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableConfig1.NumDiasColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsCorAniversarioNull() => this.IsNull(this.tableConfig1.CorAniversarioColumn);

      [DebuggerNonUserCode]
      public void SetCorAniversarioNull() => this[this.tableConfig1.CorAniversarioColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCorFeriadoNull() => this.IsNull(this.tableConfig1.CorFeriadoColumn);

      [DebuggerNonUserCode]
      public void SetCorFeriadoNull() => this[this.tableConfig1.CorFeriadoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCorLembreteNull() => this.IsNull(this.tableConfig1.CorLembreteColumn);

      [DebuggerNonUserCode]
      public void SetCorLembreteNull() => this[this.tableConfig1.CorLembreteColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCorAniversarioForeNull() => this.IsNull(this.tableConfig1.CorAniversarioForeColumn);

      [DebuggerNonUserCode]
      public void SetCorAniversarioForeNull() => this[this.tableConfig1.CorAniversarioForeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCorFeriadoForeNull() => this.IsNull(this.tableConfig1.CorFeriadoForeColumn);

      [DebuggerNonUserCode]
      public void SetCorFeriadoForeNull() => this[this.tableConfig1.CorFeriadoForeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsCorLembreteForeNull() => this.IsNull(this.tableConfig1.CorLembreteForeColumn);

      [DebuggerNonUserCode]
      public void SetCorLembreteForeNull() => this[this.tableConfig1.CorLembreteForeColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsNumDiasNull() => this.IsNull(this.tableConfig1.NumDiasColumn);

      [DebuggerNonUserCode]
      public void SetNumDiasNull() => this[this.tableConfig1.NumDiasColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Config1RowChangeEvent : EventArgs
    {
      private dsConfig.Config1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Config1RowChangeEvent(dsConfig.Config1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsConfig.Config1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
