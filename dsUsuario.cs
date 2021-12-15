// Decompiled with JetBrains decompiler
// Type: MemoMil.dsUsuario
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
  [XmlRoot("dsUsuario")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [HelpKeyword("vs.data.DataSet")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [Serializable]
  public class dsUsuario : DataSet
  {
    private dsUsuario.UsuarioDataTable tableUsuario;
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

    [DebuggerNonUserCode]
    public dsUsuario()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    protected dsUsuario(SerializationInfo info, StreamingContext context)
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
          if (dataSet.Tables[nameof (Usuario)] != null)
            base.Tables.Add((DataTable) new dsUsuario.UsuarioDataTable(dataSet.Tables[nameof (Usuario)]));
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
    public dsUsuario.UsuarioDataTable Usuario => this.tableUsuario;

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [Browsable(true)]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get => this._schemaSerializationMode;
      set => this._schemaSerializationMode = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DebuggerNonUserCode]
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
      dsUsuario dsUsuario = (dsUsuario) base.Clone();
      dsUsuario.InitVars();
      dsUsuario.SchemaSerializationMode = this.SchemaSerializationMode;
      return (DataSet) dsUsuario;
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
        if (dataSet.Tables["Usuario"] != null)
          base.Tables.Add((DataTable) new dsUsuario.UsuarioDataTable(dataSet.Tables["Usuario"]));
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
      this.tableUsuario = (dsUsuario.UsuarioDataTable) base.Tables["Usuario"];
      if (!initTable || this.tableUsuario == null)
        return;
      this.tableUsuario.InitVars();
    }

    [DebuggerNonUserCode]
    private void InitClass()
    {
      this.DataSetName = nameof (dsUsuario);
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/dsUsuario.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableUsuario = new dsUsuario.UsuarioDataTable();
      base.Tables.Add((DataTable) this.tableUsuario);
    }

    [DebuggerNonUserCode]
    private bool ShouldSerializeUsuario() => false;

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
      dsUsuario dsUsuario = new dsUsuario();
      XmlSchemaComplexType typedDataSetSchema = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      xmlSchemaSequence.Items.Add((XmlSchemaObject) new XmlSchemaAny()
      {
        Namespace = dsUsuario.Namespace
      });
      typedDataSetSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = dsUsuario.GetSchemaSerializable();
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

    public delegate void UsuarioRowChangeEventHandler(
      object sender,
      dsUsuario.UsuarioRowChangeEvent e);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class UsuarioDataTable : TypedTableBase<dsUsuario.UsuarioRow>
    {
      private DataColumn columnUsuario;
      private DataColumn columnSenha;

      [DebuggerNonUserCode]
      public UsuarioDataTable()
      {
        this.TableName = "Usuario";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      internal UsuarioDataTable(DataTable table)
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
      protected UsuarioDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      public DataColumn UsuarioColumn => this.columnUsuario;

      [DebuggerNonUserCode]
      public DataColumn SenhaColumn => this.columnSenha;

      [Browsable(false)]
      [DebuggerNonUserCode]
      public int Count => this.Rows.Count;

      [DebuggerNonUserCode]
      public dsUsuario.UsuarioRow this[int index] => (dsUsuario.UsuarioRow) this.Rows[index];

      public event dsUsuario.UsuarioRowChangeEventHandler UsuarioRowChanging;

      public event dsUsuario.UsuarioRowChangeEventHandler UsuarioRowChanged;

      public event dsUsuario.UsuarioRowChangeEventHandler UsuarioRowDeleting;

      public event dsUsuario.UsuarioRowChangeEventHandler UsuarioRowDeleted;

      [DebuggerNonUserCode]
      public void AddUsuarioRow(dsUsuario.UsuarioRow row) => this.Rows.Add((DataRow) row);

      [DebuggerNonUserCode]
      public dsUsuario.UsuarioRow AddUsuarioRow(string Usuario, string Senha)
      {
        dsUsuario.UsuarioRow row = (dsUsuario.UsuarioRow) this.NewRow();
        object[] objArray = new object[2]
        {
          (object) Usuario,
          (object) Senha
        };
        row.ItemArray = objArray;
        this.Rows.Add((DataRow) row);
        return row;
      }

      [DebuggerNonUserCode]
      public dsUsuario.UsuarioRow FindByUsuario(string Usuario) => (dsUsuario.UsuarioRow) this.Rows.Find(new object[1]
      {
        (object) Usuario
      });

      [DebuggerNonUserCode]
      public override DataTable Clone()
      {
        dsUsuario.UsuarioDataTable usuarioDataTable = (dsUsuario.UsuarioDataTable) base.Clone();
        usuarioDataTable.InitVars();
        return (DataTable) usuarioDataTable;
      }

      [DebuggerNonUserCode]
      protected override DataTable CreateInstance() => (DataTable) new dsUsuario.UsuarioDataTable();

      [DebuggerNonUserCode]
      internal void InitVars()
      {
        this.columnUsuario = this.Columns["Usuario"];
        this.columnSenha = this.Columns["Senha"];
      }

      [DebuggerNonUserCode]
      private void InitClass()
      {
        this.columnUsuario = new DataColumn("Usuario", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnUsuario);
        this.columnSenha = new DataColumn("Senha", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSenha);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnUsuario
        }, true));
        this.columnUsuario.AllowDBNull = false;
        this.columnUsuario.Unique = true;
        this.columnUsuario.MaxLength = 10;
        this.columnSenha.MaxLength = (int) byte.MaxValue;
      }

      [DebuggerNonUserCode]
      public dsUsuario.UsuarioRow NewUsuarioRow() => (dsUsuario.UsuarioRow) this.NewRow();

      [DebuggerNonUserCode]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder) => (DataRow) new dsUsuario.UsuarioRow(builder);

      [DebuggerNonUserCode]
      protected override Type GetRowType() => typeof (dsUsuario.UsuarioRow);

      [DebuggerNonUserCode]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        if (this.UsuarioRowChanged == null)
          return;
        this.UsuarioRowChanged((object) this, new dsUsuario.UsuarioRowChangeEvent((dsUsuario.UsuarioRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        if (this.UsuarioRowChanging == null)
          return;
        this.UsuarioRowChanging((object) this, new dsUsuario.UsuarioRowChangeEvent((dsUsuario.UsuarioRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        if (this.UsuarioRowDeleted == null)
          return;
        this.UsuarioRowDeleted((object) this, new dsUsuario.UsuarioRowChangeEvent((dsUsuario.UsuarioRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        if (this.UsuarioRowDeleting == null)
          return;
        this.UsuarioRowDeleting((object) this, new dsUsuario.UsuarioRowChangeEvent((dsUsuario.UsuarioRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      public void RemoveUsuarioRow(dsUsuario.UsuarioRow row) => this.Rows.Remove((DataRow) row);

      [DebuggerNonUserCode]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType typedTableSchema = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        dsUsuario dsUsuario = new dsUsuario();
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
          FixedValue = dsUsuario.Namespace
        });
        typedTableSchema.Attributes.Add((XmlSchemaObject) new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = nameof (UsuarioDataTable)
        });
        typedTableSchema.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = dsUsuario.GetSchemaSerializable();
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
    public class UsuarioRow : DataRow
    {
      private dsUsuario.UsuarioDataTable tableUsuario;

      [DebuggerNonUserCode]
      internal UsuarioRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableUsuario = (dsUsuario.UsuarioDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      public string Usuario
      {
        get => (string) this[this.tableUsuario.UsuarioColumn];
        set => this[this.tableUsuario.UsuarioColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public string Senha
      {
        get
        {
          try
          {
            return (string) this[this.tableUsuario.SenhaColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Senha' in table 'Usuario' is DBNull.", (Exception) ex);
          }
        }
        set => this[this.tableUsuario.SenhaColumn] = (object) value;
      }

      [DebuggerNonUserCode]
      public bool IsSenhaNull() => this.IsNull(this.tableUsuario.SenhaColumn);

      [DebuggerNonUserCode]
      public void SetSenhaNull() => this[this.tableUsuario.SenhaColumn] = Convert.DBNull;
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public class UsuarioRowChangeEvent : EventArgs
    {
      private dsUsuario.UsuarioRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      public UsuarioRowChangeEvent(dsUsuario.UsuarioRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }

      [DebuggerNonUserCode]
      public dsUsuario.UsuarioRow Row => this.eventRow;

      [DebuggerNonUserCode]
      public DataRowAction Action => this.eventAction;
    }
  }
}
