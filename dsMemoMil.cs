// Decompiled with JetBrains decompiler
// Type: MemoMil.dsMemoMil
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
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.DataSet")]
  [XmlRoot("dsMemoMil")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class dsMemoMil : DataSet
  {
    private dsMemoMil.Evento1DataTable tableEvento1;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public dsMemoMil()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected dsMemoMil(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Evento1)] != null)
            base.Tables.Add((DataTable) new dsMemoMil.Evento1DataTable(dataSet.Tables[nameof (Evento1)]));
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    [Browsable(false)]
    public dsMemoMil.Evento1DataTable Evento1 => this.tableEvento1;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    [DebuggerNonUserCode]
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
      dsMemoMil dsMemoMil = (dsMemoMil) base.Clone();
      dsMemoMil.InitVars();
      dsMemoMil.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dsMemoMil;
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
        if (dataSet.Tables["Evento1"] != null)
          base.Tables.Add((DataTable) new dsMemoMil.Evento1DataTable(dataSet.Tables["Evento1"]));
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
      this.tableEvento1 = (dsMemoMil.Evento1DataTable) base.Tables["Evento1"];
      if (!initTable || this.tableEvento1 == null)
        return;
      this.tableEvento1.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = nameof (dsMemoMil);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/dsMemoMil.xsd";
      this.Locale = new CultureInfo("en-US");
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableEvento1 = new dsMemoMil.Evento1DataTable();
      base.Tables.Add((DataTable) this.tableEvento1);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeEvento1() => false;

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
      dsMemoMil dsMemoMil = new dsMemoMil();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dsMemoMil.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsMemoMil.GetSchemaSerializable();
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

    public delegate void Evento1RowChangeEventHandler(
      object sender,
      dsMemoMil.Evento1RowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class Evento1DataTable : TypedTableBase<dsMemoMil.Evento1Row>
    {
      private DataColumn columnCodigo;
      private DataColumn columnDataEvento;
      private DataColumn columnTipo;
      private DataColumn columnDescricao;
      private DataColumn columnDataLembrete;
      private DataColumn columnMostrado;

      [DebuggerNonUserCode]
      public Evento1DataTable()
      {
        this.TableName = "Evento1";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal Evento1DataTable(DataTable table)
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
      protected Evento1DataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn CodigoColumn => this.columnCodigo;

      [DebuggerNonUserCode]
      public DataColumn DataEventoColumn => this.columnDataEvento;

      [DebuggerNonUserCode]
      public DataColumn TipoColumn => this.columnTipo;

      [DebuggerNonUserCode]
      public DataColumn DescricaoColumn => this.columnDescricao;

      [DebuggerNonUserCode]
      public DataColumn DataLembreteColumn => this.columnDataLembrete;

      [DebuggerNonUserCode]
      public DataColumn MostradoColumn => this.columnMostrado;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsMemoMil.Evento1Row this[int index] => (dsMemoMil.Evento1Row) this.Rows[index];

      public event dsMemoMil.Evento1RowChangeEventHandler Evento1RowChanging;

      public event dsMemoMil.Evento1RowChangeEventHandler Evento1RowChanged;

      public event dsMemoMil.Evento1RowChangeEventHandler Evento1RowDeleting;

      public event dsMemoMil.Evento1RowChangeEventHandler Evento1RowDeleted;

      [DebuggerNonUserCode]
      public void AddEvento1Row(dsMemoMil.Evento1Row row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsMemoMil.Evento1Row AddEvento1Row(
        int Codigo,
        DateTime DataEvento,
        string Tipo,
        string Descricao,
        DateTime DataLembrete,
        bool Mostrado)
      {
        dsMemoMil.Evento1Row row = (dsMemoMil.Evento1Row) this.NewRow();
        object[] objArray = new object[6]
        {
          (object) Codigo,
          (object) DataEvento,
          (object) Tipo,
          (object) Descricao,
          (object) DataLembrete,
          (object) Mostrado
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsMemoMil.Evento1Row FindByCodigo(int Codigo) => (dsMemoMil.Evento1Row) this.Rows.Find(new object[1]
      {
        (object) Codigo
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsMemoMil.Evento1DataTable evento1DataTable = (dsMemoMil.Evento1DataTable) base.Clone();
        evento1DataTable.InitVars();
        return (DataTable) evento1DataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsMemoMil.Evento1DataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnCodigo = this.Columns["Codigo"];
        this.columnDataEvento = this.Columns["DataEvento"];
        this.columnTipo = this.Columns["Tipo"];
        this.columnDescricao = this.Columns["Descricao"];
        this.columnDataLembrete = this.Columns["DataLembrete"];
        this.columnMostrado = this.Columns["Mostrado"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnCodigo = new DataColumn("Codigo", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCodigo);
        this.columnDataEvento = new DataColumn("DataEvento", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDataEvento);
        this.columnTipo = new DataColumn("Tipo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnTipo);
        this.columnDescricao = new DataColumn("Descricao", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDescricao);
        this.columnDataLembrete = new DataColumn("DataLembrete", typeof (DateTime), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDataLembrete);
        this.columnMostrado = new DataColumn("Mostrado", typeof (bool), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMostrado);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnCodigo
        }, true));
        this.columnCodigo.AllowDBNull = false;
        this.columnCodigo.Unique = true;
        this.columnTipo.MaxLength = 50;
        this.columnDescricao.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public dsMemoMil.Evento1Row NewEvento1Row() => (dsMemoMil.Evento1Row) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsMemoMil.Evento1Row(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsMemoMil.Evento1Row);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.Evento1RowChanged == null)
          return;
        this.Evento1RowChanged((object) this, new dsMemoMil.Evento1RowChangeEvent((dsMemoMil.Evento1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.Evento1RowChanging == null)
          return;
        this.Evento1RowChanging((object) this, new dsMemoMil.Evento1RowChangeEvent((dsMemoMil.Evento1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.Evento1RowDeleted == null)
          return;
        this.Evento1RowDeleted((object) this, new dsMemoMil.Evento1RowChangeEvent((dsMemoMil.Evento1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.Evento1RowDeleting == null)
          return;
        this.Evento1RowDeleting((object) this, new dsMemoMil.Evento1RowChangeEvent((dsMemoMil.Evento1Row) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveEvento1Row(dsMemoMil.Evento1Row row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsMemoMil dsMemoMil = new dsMemoMil();
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
          FixedValue = dsMemoMil.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (Evento1DataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsMemoMil.GetSchemaSerializable();
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
    public class Evento1Row : DataRow
    {
      private dsMemoMil.Evento1DataTable tableEvento1;

      [DebuggerNonUserCode]
      internal Evento1Row(DataRowBuilder rb)
        : base(rb)
      {
        this.tableEvento1 = (dsMemoMil.Evento1DataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int Codigo
      {
        get => (int) this[this.tableEvento1.CodigoColumn];
        set => this[this.tableEvento1.CodigoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime DataEvento
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableEvento1.DataEventoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DataEvento' in table 'Evento1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEvento1.DataEventoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Tipo
      {
        get
        {
          try
          {
            return (string) this[this.tableEvento1.TipoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Tipo' in table 'Evento1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEvento1.TipoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Descricao
      {
        get
        {
          try
          {
            return (string) this[this.tableEvento1.DescricaoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Descricao' in table 'Evento1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEvento1.DescricaoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public DateTime DataLembrete
      {
        get
        {
          try
          {
            return (DateTime) this[this.tableEvento1.DataLembreteColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DataLembrete' in table 'Evento1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEvento1.DataLembreteColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool Mostrado
      {
        get
        {
          try
          {
            return (bool) this[this.tableEvento1.MostradoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Mostrado' in table 'Evento1' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEvento1.MostradoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsDataEventoNull() => this.IsNull(this.tableEvento1.DataEventoColumn);

      [DebuggerNonUserCode]
      public void SetDataEventoNull() => this[this.tableEvento1.DataEventoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsTipoNull() => this.IsNull(this.tableEvento1.TipoColumn);

      [DebuggerNonUserCode]
      public void SetTipoNull() => this[this.tableEvento1.TipoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDescricaoNull() => this.IsNull(this.tableEvento1.DescricaoColumn);

      [DebuggerNonUserCode]
      public void SetDescricaoNull() => this[this.tableEvento1.DescricaoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsDataLembreteNull() => this.IsNull(this.tableEvento1.DataLembreteColumn);

      [DebuggerNonUserCode]
      public void SetDataLembreteNull() => this[this.tableEvento1.DataLembreteColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsMostradoNull() => this.IsNull(this.tableEvento1.MostradoColumn);

      [DebuggerNonUserCode]
      public void SetMostradoNull() => this[this.tableEvento1.MostradoColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class Evento1RowChangeEvent : EventArgs
    {
      private dsMemoMil.Evento1Row eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public Evento1RowChangeEvent(dsMemoMil.Evento1Row row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsMemoMil.Evento1Row Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
