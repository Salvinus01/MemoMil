// Decompiled with JetBrains decompiler
// Type: MemoMil.dsContato
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
  [XmlRoot("dsContato")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.DataSet")]
  [Serializable]
  public class dsContato : DataSet
  {
    private dsContato.ContatoDataTable tableContato;
    private dsContato.TelefoneDataTable tableTelefone;
    private dsContato.EmailDataTable tableEmail;
    private DataRelation relationContato_Telefone;
    private DataRelation relationContato_Email;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public dsContato()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected dsContato(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Contato)] != null)
            base.Tables.Add((DataTable) new dsContato.ContatoDataTable(dataSet.Tables[nameof (Contato)]));
          if (dataSet.Tables[nameof (Telefone)] != null)
            base.Tables.Add((DataTable) new dsContato.TelefoneDataTable(dataSet.Tables[nameof (Telefone)]));
          if (dataSet.Tables[nameof (Email)] != null)
            base.Tables.Add((DataTable) new dsContato.EmailDataTable(dataSet.Tables[nameof (Email)]));
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
    public dsContato.ContatoDataTable Contato => this.tableContato;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [DebuggerNonUserCode]
    public dsContato.TelefoneDataTable Telefone => this.tableTelefone;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Browsable(false)]
    [DebuggerNonUserCode]
    public dsContato.EmailDataTable Email => this.tableEmail;

    [Browsable(true)]
    [DebuggerNonUserCode]
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
      dsContato dsContato = (dsContato) base.Clone();
      dsContato.InitVars();
      dsContato.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dsContato;
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
        if (dataSet.Tables["Contato"] != null)
          base.Tables.Add((DataTable) new dsContato.ContatoDataTable(dataSet.Tables["Contato"]));
        if (dataSet.Tables["Telefone"] != null)
          base.Tables.Add((DataTable) new dsContato.TelefoneDataTable(dataSet.Tables["Telefone"]));
        if (dataSet.Tables["Email"] != null)
          base.Tables.Add((DataTable) new dsContato.EmailDataTable(dataSet.Tables["Email"]));
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
      this.tableContato = (dsContato.ContatoDataTable) base.Tables["Contato"];
      if (initTable && this.tableContato != null)
        this.tableContato.InitVars();
      this.tableTelefone = (dsContato.TelefoneDataTable) base.Tables["Telefone"];
      if (initTable && this.tableTelefone != null)
        this.tableTelefone.InitVars();
      this.tableEmail = (dsContato.EmailDataTable) base.Tables["Email"];
      if (initTable && this.tableEmail != null)
        this.tableEmail.InitVars();
      this.relationContato_Telefone = this.Relations["Contato_Telefone"];
      this.relationContato_Email = this.Relations["Contato_Email"];
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = nameof (dsContato);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/dsContato.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableContato = new dsContato.ContatoDataTable();
      base.Tables.Add((DataTable) this.tableContato);
      this.tableTelefone = new dsContato.TelefoneDataTable();
      base.Tables.Add((DataTable) this.tableTelefone);
      this.tableEmail = new dsContato.EmailDataTable();
      base.Tables.Add((DataTable) this.tableEmail);
      this.relationContato_Telefone = new DataRelation("Contato_Telefone", new DataColumn[1]
      {
        this.tableContato.cdContatoColumn
      }, new DataColumn[1]
      {
        this.tableTelefone.cdContatoColumn
      }, false);
      this.Relations.Add(this.relationContato_Telefone);
      this.relationContato_Email = new DataRelation("Contato_Email", new DataColumn[1]
      {
        this.tableContato.cdContatoColumn
      }, new DataColumn[1]
      {
        this.tableEmail.cdContatoColumn
      }, false);
      this.Relations.Add(this.relationContato_Email);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeContato() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeTelefone() => false;

    [DebuggerNonUserCode]
    private bool ShouldSerializeEmail() => false;

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
      dsContato dsContato = new dsContato();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dsContato.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsContato.GetSchemaSerializable();
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

    public delegate void ContatoRowChangeEventHandler(
      object sender,
      dsContato.ContatoRowChangeEvent e);

    public delegate void TelefoneRowChangeEventHandler(
      object sender,
      dsContato.TelefoneRowChangeEvent e);

    public delegate void EmailRowChangeEventHandler(object sender, dsContato.EmailRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [Serializable]
    public class ContatoDataTable : TypedTableBase<dsContato.ContatoRow>
    {
      private DataColumn columncdContato;
      private DataColumn columnnmContato;

      [DebuggerNonUserCode]
      public ContatoDataTable()
      {
        this.TableName = "Contato";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal ContatoDataTable(DataTable table)
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
      protected ContatoDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn cdContatoColumn => this.columncdContato;

      [DebuggerNonUserCode]
      public DataColumn nmContatoColumn => this.columnnmContato;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsContato.ContatoRow this[int index] => (dsContato.ContatoRow) this.Rows[index];

      public event dsContato.ContatoRowChangeEventHandler ContatoRowChanging;

      public event dsContato.ContatoRowChangeEventHandler ContatoRowChanged;

      public event dsContato.ContatoRowChangeEventHandler ContatoRowDeleting;

      public event dsContato.ContatoRowChangeEventHandler ContatoRowDeleted;

      [DebuggerNonUserCode]
      public void AddContatoRow(dsContato.ContatoRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsContato.ContatoRow AddContatoRow(string nmContato)
      {
        dsContato.ContatoRow row = (dsContato.ContatoRow) this.NewRow();
        object[] objArray = new object[2]
        {
          null,
          (object) nmContato
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsContato.ContatoRow FindBycdContato(int cdContato) => (dsContato.ContatoRow) this.Rows.Find(new object[1]
      {
        (object) cdContato
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsContato.ContatoDataTable contatoDataTable = (dsContato.ContatoDataTable) base.Clone();
        contatoDataTable.InitVars();
        return (DataTable) contatoDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsContato.ContatoDataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columncdContato = this.Columns["cdContato"];
        this.columnnmContato = this.Columns["nmContato"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columncdContato = new DataColumn("cdContato", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncdContato);
        this.columnnmContato = new DataColumn("nmContato", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnnmContato);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columncdContato
        }, true));
        this.columncdContato.AutoIncrement = true;
        this.columncdContato.AutoIncrementSeed = -1L;
        this.columncdContato.AutoIncrementStep = -1L;
        this.columncdContato.AllowDBNull = false;
        this.columncdContato.Unique = true;
        this.columnnmContato.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public dsContato.ContatoRow NewContatoRow() => (dsContato.ContatoRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsContato.ContatoRow(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsContato.ContatoRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.ContatoRowChanged == null)
          return;
        this.ContatoRowChanged((object) this, new dsContato.ContatoRowChangeEvent((dsContato.ContatoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.ContatoRowChanging == null)
          return;
        this.ContatoRowChanging((object) this, new dsContato.ContatoRowChangeEvent((dsContato.ContatoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.ContatoRowDeleted == null)
          return;
        this.ContatoRowDeleted((object) this, new dsContato.ContatoRowChangeEvent((dsContato.ContatoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.ContatoRowDeleting == null)
          return;
        this.ContatoRowDeleting((object) this, new dsContato.ContatoRowChangeEvent((dsContato.ContatoRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveContatoRow(dsContato.ContatoRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsContato dsContato = new dsContato();
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
          FixedValue = dsContato.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (ContatoDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsContato.GetSchemaSerializable();
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
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class TelefoneDataTable : TypedTableBase<dsContato.TelefoneRow>
    {
      private DataColumn columncdTelefone;
      private DataColumn columncdContato;
      private DataColumn columnnmTelefone;

      [DebuggerNonUserCode]
      public TelefoneDataTable()
      {
        this.TableName = "Telefone";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal TelefoneDataTable(DataTable table)
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
      protected TelefoneDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn cdTelefoneColumn => this.columncdTelefone;

      [DebuggerNonUserCode]
      public DataColumn cdContatoColumn => this.columncdContato;

      [DebuggerNonUserCode]
      public DataColumn nmTelefoneColumn => this.columnnmTelefone;

      [DebuggerNonUserCode]
      [Browsable(false)]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsContato.TelefoneRow this[int index] => (dsContato.TelefoneRow) this.Rows[index];

      public event dsContato.TelefoneRowChangeEventHandler TelefoneRowChanging;

      public event dsContato.TelefoneRowChangeEventHandler TelefoneRowChanged;

      public event dsContato.TelefoneRowChangeEventHandler TelefoneRowDeleting;

      public event dsContato.TelefoneRowChangeEventHandler TelefoneRowDeleted;

      [DebuggerNonUserCode]
      public void AddTelefoneRow(dsContato.TelefoneRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsContato.TelefoneRow AddTelefoneRow(
        dsContato.ContatoRow parentContatoRowByContato_Telefone,
        string nmTelefone)
      {
        dsContato.TelefoneRow row = (dsContato.TelefoneRow) this.NewRow();
        object[] objArray = new object[3]
        {
          null,
          null,
          (object) nmTelefone
        };
        if (parentContatoRowByContato_Telefone != null)
          objArray[1] = parentContatoRowByContato_Telefone[0];
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsContato.TelefoneRow FindBycdTelefone(int cdTelefone) => (dsContato.TelefoneRow) this.Rows.Find(new object[1]
      {
        (object) cdTelefone
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsContato.TelefoneDataTable telefoneDataTable = (dsContato.TelefoneDataTable) base.Clone();
        telefoneDataTable.InitVars();
        return (DataTable) telefoneDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsContato.TelefoneDataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columncdTelefone = this.Columns["cdTelefone"];
        this.columncdContato = this.Columns["cdContato"];
        this.columnnmTelefone = this.Columns["nmTelefone"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columncdTelefone = new DataColumn("cdTelefone", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncdTelefone);
        this.columncdContato = new DataColumn("cdContato", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncdContato);
        this.columnnmTelefone = new DataColumn("nmTelefone", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnnmTelefone);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columncdTelefone
        }, true));
        this.columncdTelefone.AutoIncrement = true;
        this.columncdTelefone.AutoIncrementSeed = -1L;
        this.columncdTelefone.AutoIncrementStep = -1L;
        this.columncdTelefone.AllowDBNull = false;
        this.columncdTelefone.Unique = true;
        this.columnnmTelefone.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public dsContato.TelefoneRow NewTelefoneRow() => (dsContato.TelefoneRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsContato.TelefoneRow(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsContato.TelefoneRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.TelefoneRowChanged == null)
          return;
        this.TelefoneRowChanged((object) this, new dsContato.TelefoneRowChangeEvent((dsContato.TelefoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.TelefoneRowChanging == null)
          return;
        this.TelefoneRowChanging((object) this, new dsContato.TelefoneRowChangeEvent((dsContato.TelefoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.TelefoneRowDeleted == null)
          return;
        this.TelefoneRowDeleted((object) this, new dsContato.TelefoneRowChangeEvent((dsContato.TelefoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.TelefoneRowDeleting == null)
          return;
        this.TelefoneRowDeleting((object) this, new dsContato.TelefoneRowChangeEvent((dsContato.TelefoneRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveTelefoneRow(dsContato.TelefoneRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsContato dsContato = new dsContato();
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
          FixedValue = dsContato.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (TelefoneDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsContato.GetSchemaSerializable();
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
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class EmailDataTable : TypedTableBase<dsContato.EmailRow>
    {
      private DataColumn columncdEmail;
      private DataColumn columncdContato;
      private DataColumn columnnmEmail;

      [DebuggerNonUserCode]
      public EmailDataTable()
      {
        this.TableName = "Email";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal EmailDataTable(DataTable table)
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
      protected EmailDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn cdEmailColumn => this.columncdEmail;

      [DebuggerNonUserCode]
      public DataColumn cdContatoColumn => this.columncdContato;

      [DebuggerNonUserCode]
      public DataColumn nmEmailColumn => this.columnnmEmail;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsContato.EmailRow this[int index] => (dsContato.EmailRow) this.Rows[index];

      public event dsContato.EmailRowChangeEventHandler EmailRowChanging;

      public event dsContato.EmailRowChangeEventHandler EmailRowChanged;

      public event dsContato.EmailRowChangeEventHandler EmailRowDeleting;

      public event dsContato.EmailRowChangeEventHandler EmailRowDeleted;

      [DebuggerNonUserCode]
      public void AddEmailRow(dsContato.EmailRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsContato.EmailRow AddEmailRow(
        dsContato.ContatoRow parentContatoRowByContato_Email,
        string nmEmail)
      {
        dsContato.EmailRow row = (dsContato.EmailRow) this.NewRow();
        object[] objArray = new object[3]
        {
          null,
          null,
          (object) nmEmail
        };
        if (parentContatoRowByContato_Email != null)
          objArray[1] = parentContatoRowByContato_Email[0];
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsContato.EmailRow FindBycdEmail(int cdEmail) => (dsContato.EmailRow) this.Rows.Find(new object[1]
      {
        (object) cdEmail
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsContato.EmailDataTable emailDataTable = (dsContato.EmailDataTable) base.Clone();
        emailDataTable.InitVars();
        return (DataTable) emailDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsContato.EmailDataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columncdEmail = this.Columns["cdEmail"];
        this.columncdContato = this.Columns["cdContato"];
        this.columnnmEmail = this.Columns["nmEmail"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columncdEmail = new DataColumn("cdEmail", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncdEmail);
        this.columncdContato = new DataColumn("cdContato", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columncdContato);
        this.columnnmEmail = new DataColumn("nmEmail", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnnmEmail);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columncdEmail
        }, true));
        this.columncdEmail.AutoIncrement = true;
        this.columncdEmail.AutoIncrementSeed = -1L;
        this.columncdEmail.AutoIncrementStep = -1L;
        this.columncdEmail.AllowDBNull = false;
        this.columncdEmail.Unique = true;
        this.columnnmEmail.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      public dsContato.EmailRow NewEmailRow() => (dsContato.EmailRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsContato.EmailRow(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsContato.EmailRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.EmailRowChanged == null)
          return;
        this.EmailRowChanged((object) this, new dsContato.EmailRowChangeEvent((dsContato.EmailRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.EmailRowChanging == null)
          return;
        this.EmailRowChanging((object) this, new dsContato.EmailRowChangeEvent((dsContato.EmailRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.EmailRowDeleted == null)
          return;
        this.EmailRowDeleted((object) this, new dsContato.EmailRowChangeEvent((dsContato.EmailRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.EmailRowDeleting == null)
          return;
        this.EmailRowDeleting((object) this, new dsContato.EmailRowChangeEvent((dsContato.EmailRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveEmailRow(dsContato.EmailRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsContato dsContato = new dsContato();
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
          FixedValue = dsContato.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (EmailDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsContato.GetSchemaSerializable();
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
    public class ContatoRow : DataRow
    {
      private dsContato.ContatoDataTable tableContato;

      [DebuggerNonUserCode]
      internal ContatoRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableContato = (dsContato.ContatoDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int cdContato
      {
        get => (int) this[this.tableContato.cdContatoColumn];
        set => this[this.tableContato.cdContatoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string nmContato
      {
        get
        {
          try
          {
            return (string) this[this.tableContato.nmContatoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'nmContato' in table 'Contato' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableContato.nmContatoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsnmContatoNull() => this.IsNull(this.tableContato.nmContatoColumn);

      [DebuggerNonUserCode]
      public void SetnmContatoNull() => this[this.tableContato.nmContatoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public dsContato.TelefoneRow[] GetTelefoneRows() => this.Table.ChildRelations["Contato_Telefone"] == null ? new dsContato.TelefoneRow[0] : (dsContato.TelefoneRow[]) this.GetChildRows(this.Table.ChildRelations["Contato_Telefone"]);

      [DebuggerNonUserCode]
      public dsContato.EmailRow[] GetEmailRows() => this.Table.ChildRelations["Contato_Email"] == null ? new dsContato.EmailRow[0] : (dsContato.EmailRow[]) this.GetChildRows(this.Table.ChildRelations["Contato_Email"]);
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class TelefoneRow : DataRow
    {
      private dsContato.TelefoneDataTable tableTelefone;

      [DebuggerNonUserCode]
      internal TelefoneRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableTelefone = (dsContato.TelefoneDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int cdTelefone
      {
        get => (int) this[this.tableTelefone.cdTelefoneColumn];
        set => this[this.tableTelefone.cdTelefoneColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int cdContato
      {
        get
        {
          try
          {
            return (int) this[this.tableTelefone.cdContatoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'cdContato' in table 'Telefone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTelefone.cdContatoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string nmTelefone
      {
        get
        {
          try
          {
            return (string) this[this.tableTelefone.nmTelefoneColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'nmTelefone' in table 'Telefone' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableTelefone.nmTelefoneColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public dsContato.ContatoRow ContatoRow
      {
        get => (dsContato.ContatoRow) this.GetParentRow(this.Table.ParentRelations["Contato_Telefone"]);
        set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Contato_Telefone"]);
      }

      [DebuggerNonUserCode]
      public bool IscdContatoNull() => this.IsNull(this.tableTelefone.cdContatoColumn);

      [DebuggerNonUserCode]
      public void SetcdContatoNull() => this[this.tableTelefone.cdContatoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsnmTelefoneNull() => this.IsNull(this.tableTelefone.nmTelefoneColumn);

      [DebuggerNonUserCode]
      public void SetnmTelefoneNull() => this[this.tableTelefone.nmTelefoneColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class EmailRow : DataRow
    {
      private dsContato.EmailDataTable tableEmail;

      [DebuggerNonUserCode]
      internal EmailRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableEmail = (dsContato.EmailDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public int cdEmail
      {
        get => (int) this[this.tableEmail.cdEmailColumn];
        set => this[this.tableEmail.cdEmailColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public int cdContato
      {
        get
        {
          try
          {
            return (int) this[this.tableEmail.cdContatoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'cdContato' in table 'Email' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEmail.cdContatoColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string nmEmail
      {
        get
        {
          try
          {
            return (string) this[this.tableEmail.nmEmailColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'nmEmail' in table 'Email' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableEmail.nmEmailColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public dsContato.ContatoRow ContatoRow
      {
        get => (dsContato.ContatoRow) this.GetParentRow(this.Table.ParentRelations["Contato_Email"]);
        set => this.SetParentRow((DataRow) value, this.Table.ParentRelations["Contato_Email"]);
      }

      [DebuggerNonUserCode]
      public bool IscdContatoNull() => this.IsNull(this.tableEmail.cdContatoColumn);

      [DebuggerNonUserCode]
      public void SetcdContatoNull() => this[this.tableEmail.cdContatoColumn] = Convert.DBNull;

      [DebuggerNonUserCode]
      public bool IsnmEmailNull() => this.IsNull(this.tableEmail.nmEmailColumn);

      [DebuggerNonUserCode]
      public void SetnmEmailNull() => this[this.tableEmail.nmEmailColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class ContatoRowChangeEvent : EventArgs
    {
      private dsContato.ContatoRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public ContatoRowChangeEvent(dsContato.ContatoRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsContato.ContatoRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class TelefoneRowChangeEvent : EventArgs
    {
      private dsContato.TelefoneRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public TelefoneRowChangeEvent(dsContato.TelefoneRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsContato.TelefoneRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class EmailRowChangeEvent : EventArgs
    {
      private dsContato.EmailRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public EmailRowChangeEvent(dsContato.EmailRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsContato.EmailRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
