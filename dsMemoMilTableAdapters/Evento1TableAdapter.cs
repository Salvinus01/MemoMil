// Decompiled with JetBrains decompiler
// Type: MemoMil.dsMemoMilTableAdapters.Evento1TableAdapter
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using MemoMil.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;

namespace MemoMil.dsMemoMilTableAdapters
{
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [HelpKeyword("vs.data.TableAdapter")]
  [DataObject(true)]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  public class Evento1TableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public Evento1TableAdapter() => this.ClearBeforeFill = true;

    [DebuggerNonUserCode]
    private OleDbDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    internal OleDbConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
        }
      }
    }

    [DebuggerNonUserCode]
    protected OleDbCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    public bool ClearBeforeFill
    {
      get => this._clearBeforeFill;
      set => this._clearBeforeFill = value;
    }

    [DebuggerNonUserCode]
    private void InitAdapter()
    {
      this._adapter = new OleDbDataAdapter();
      this._adapter.TableMappings.Add((object) new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "Evento1",
        ColumnMappings = {
          {
            "Codigo",
            "Codigo"
          },
          {
            "DataEvento",
            "DataEvento"
          },
          {
            "Tipo",
            "Tipo"
          },
          {
            "Descricao",
            "Descricao"
          },
          {
            "DataLembrete",
            "DataLembrete"
          },
          {
            "Mostrado",
            "Mostrado"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM `Evento` WHERE ((`Codigo` = ?))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Codigo", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Codigo", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `Evento` (`Codigo`, `DataEvento`, `Tipo`, `Descricao`, `DataLembrete`, `Mostrado`) VALUES (?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Codigo", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Codigo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("DataEvento", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DataEvento", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Tipo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipo", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Descricao", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Descricao", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("DataLembrete", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DataLembrete", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Mostrado", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Mostrado", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE `Evento` SET `Codigo` = ?, `DataEvento` = ?, `Tipo` = ?, `Descricao` = ?, `DataLembrete` = ?, `Mostrado` = ? WHERE ((`Codigo` = ?))";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Codigo", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Codigo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DataEvento", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DataEvento", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Tipo", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Tipo", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Descricao", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Descricao", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("DataLembrete", OleDbType.Date, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "DataLembrete", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Mostrado", OleDbType.Boolean, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Mostrado", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Codigo", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Codigo", DataRowVersion.Original, false, (object) null));
    }

    [DebuggerNonUserCode]
    private void InitConnection()
    {
      this._connection = new OleDbConnection();
      this._connection.ConnectionString = Settings.Default.EventoConnectionString;
    }

    [DebuggerNonUserCode]
    private void InitCommandCollection()
    {
      this._commandCollection = new OleDbCommand[1];
      this._commandCollection[0] = new OleDbCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT     Evento.*\r\nFROM         Evento";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(dsMemoMil.Evento1DataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public virtual dsMemoMil.Evento1DataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      dsMemoMil.Evento1DataTable data = new dsMemoMil.Evento1DataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(dsMemoMil.Evento1DataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(dsMemoMil dataSet) => this.Adapter.Update((DataSet) dataSet, "Evento1");

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow) => this.Adapter.Update(new DataRow[1]
    {
      dataRow
    });

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    [DebuggerNonUserCode]
    public virtual int Delete(int? Original_Codigo)
    {
      if (Original_Codigo.HasValue)
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_Codigo.Value;
      else
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) DBNull.Value;
      ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
      if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.DeleteCommand.Connection.Open();
      try
      {
        return this.Adapter.DeleteCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.DeleteCommand.Connection.Close();
      }
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public virtual int Insert(
      int? Codigo,
      DateTime? DataEvento,
      string Tipo,
      string Descricao,
      DateTime? DataLembrete,
      bool Mostrado)
    {
      if (Codigo.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) Codigo.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (DataEvento.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DataEvento.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (Tipo == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) Tipo;
      if (Descricao == null)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) Descricao;
      if (DataLembrete.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DataLembrete.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      this.Adapter.InsertCommand.Parameters[5].Value = (object) Mostrado;
      ConnectionState state = this.Adapter.InsertCommand.Connection.State;
      if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.InsertCommand.Connection.Open();
      try
      {
        return this.Adapter.InsertCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.InsertCommand.Connection.Close();
      }
    }

    [DataObjectMethod(DataObjectMethodType.Update, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(
      int? Codigo,
      DateTime? DataEvento,
      string Tipo,
      string Descricao,
      DateTime? DataLembrete,
      bool Mostrado,
      int? Original_Codigo)
    {
      if (Codigo.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) Codigo.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (DataEvento.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DataEvento.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (Tipo == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) Tipo;
      if (Descricao == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) Descricao;
      if (DataLembrete.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DataLembrete.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      this.Adapter.UpdateCommand.Parameters[5].Value = (object) Mostrado;
      if (Original_Codigo.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) Original_Codigo.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
      if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        this.Adapter.UpdateCommand.Connection.Open();
      try
      {
        return this.Adapter.UpdateCommand.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          this.Adapter.UpdateCommand.Connection.Close();
      }
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    [DebuggerNonUserCode]
    public virtual int Update(
      DateTime? DataEvento,
      string Tipo,
      string Descricao,
      DateTime? DataLembrete,
      bool Mostrado,
      int? Original_Codigo)
    {
      return this.Update(Original_Codigo, DataEvento, Tipo, Descricao, DataLembrete, Mostrado, Original_Codigo);
    }
  }
}
