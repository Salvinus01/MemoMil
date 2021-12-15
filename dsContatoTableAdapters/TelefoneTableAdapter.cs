// Decompiled with JetBrains decompiler
// Type: MemoMil.dsContatoTableAdapters.TelefoneTableAdapter
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

namespace MemoMil.dsContatoTableAdapters
{
  [HelpKeyword("vs.data.TableAdapter")]
  [DataObject(true)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  public class TelefoneTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public TelefoneTableAdapter() => this.ClearBeforeFill = true;

    [DebuggerNonUserCode]
    protected internal OleDbDataAdapter Adapter
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
    internal OleDbTransaction Transaction
    {
      get => this._transaction;
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
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
        DataSetTable = "Telefone",
        ColumnMappings = {
          {
            "cdTelefone",
            "cdTelefone"
          },
          {
            "cdContato",
            "cdContato"
          },
          {
            "nmTelefone",
            "nmTelefone"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM `Telefone` WHERE ((`cdTelefone` = ?))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_cdTelefone", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdTelefone", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `Telefone` (`cdContato`, `nmTelefone`) VALUES (?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("cdContato", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdContato", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("nmTelefone", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "nmTelefone", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE `Telefone` SET `cdContato` = ?, `nmTelefone` = ? WHERE ((`cdTelefone` = ?))";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("cdContato", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdContato", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("nmTelefone", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "nmTelefone", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_cdTelefone", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdTelefone", DataRowVersion.Original, false, (object) null));
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
      this._commandCollection = new OleDbCommand[2];
      this._commandCollection[0] = new OleDbCommand();
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "SELECT     Telefone.*\r\nFROM         Telefone";
      this._commandCollection[0].CommandType = CommandType.Text;
      this._commandCollection[1] = new OleDbCommand();
      this._commandCollection[1].Connection = this.Connection;
      this._commandCollection[1].CommandText = "DELETE FROM Telefone\r\nWHERE     (cdContato = ?)";
      this._commandCollection[1].CommandType = CommandType.Text;
      this._commandCollection[1].Parameters.Add(new OleDbParameter("cdContato", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdContato", DataRowVersion.Original, false, (object) null));
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(dsContato.TelefoneDataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual dsContato.TelefoneDataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      dsContato.TelefoneDataTable data = new dsContato.TelefoneDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(dsContato.TelefoneDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(dsContato dataSet) => this.Adapter.Update((DataSet) dataSet, "Telefone");

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow dataRow) => this.Adapter.Update(new DataRow[1]
    {
      dataRow
    });

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    [DebuggerNonUserCode]
    public virtual int Delete(int Original_cdTelefone)
    {
      this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_cdTelefone;
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

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Insert(int? cdContato, string nmTelefone)
    {
      if (cdContato.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) cdContato.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (nmTelefone == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) nmTelefone;
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

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public virtual int Update(int? cdContato, string nmTelefone, int Original_cdTelefone)
    {
      if (cdContato.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) cdContato.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (nmTelefone == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) nmTelefone;
      this.Adapter.UpdateCommand.Parameters[2].Value = (object) Original_cdTelefone;
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

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, false)]
    public virtual int ExcluirTelefonesDoContato(int? cdContato)
    {
      OleDbCommand command = this.CommandCollection[1];
      if (cdContato.HasValue)
        command.Parameters[0].Value = (object) cdContato.Value;
      else
        command.Parameters[0].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      try
      {
        return command.ExecuteNonQuery();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
    }
  }
}
