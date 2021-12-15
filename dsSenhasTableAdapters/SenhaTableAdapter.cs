// Decompiled with JetBrains decompiler
// Type: MemoMil.dsSenhasTableAdapters.SenhaTableAdapter
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

namespace MemoMil.dsSenhasTableAdapters
{
  [HelpKeyword("vs.data.TableAdapter")]
  [DesignerCategory("code")]
  [DataObject(true)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [ToolboxItem(true)]
  public class SenhaTableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbTransaction _transaction;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public SenhaTableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "Senha",
        ColumnMappings = {
          {
            "Usuario",
            "Usuario"
          },
          {
            "Descricao",
            "Descricao"
          },
          {
            "Senha",
            "Senha"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM `Senha` WHERE ((`Usuario` = ?) AND (`Descricao` = ?))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Usuario", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Usuario", DataRowVersion.Original, false, (object) null));
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_Descricao", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Descricao", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `Senha` (`Usuario`, `Descricao`, `Senha`) VALUES (?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Usuario", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Usuario", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Descricao", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Descricao", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("Senha", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Senha", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE `Senha` SET `Usuario` = ?, `Descricao` = ?, `Senha` = ? WHERE ((`Usuario` = ?) AND (`Descricao` = ?))";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Usuario", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Usuario", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Descricao", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Descricao", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Senha", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Senha", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Usuario", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Usuario", DataRowVersion.Original, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_Descricao", OleDbType.VarWChar, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "Descricao", DataRowVersion.Original, false, (object) null));
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
      this._commandCollection[0].CommandText = "SELECT     Usuario, Descricao, Senha\r\nFROM         Senha\r\nWHERE     (Usuario = ?)";
      this._commandCollection[0].CommandType = CommandType.Text;
      this._commandCollection[0].Parameters.Add(new OleDbParameter("Usuario", OleDbType.WChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, "Usuario", DataRowVersion.Current, false, (object) null));
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(dsSenhas.SenhaDataTable dataTable, string Usuario)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (Usuario == null)
        this.Adapter.SelectCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.SelectCommand.Parameters[0].Value = (object) Usuario;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    public virtual dsSenhas.SenhaDataTable GetData(string Usuario)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (Usuario == null)
        this.Adapter.SelectCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.SelectCommand.Parameters[0].Value = (object) Usuario;
      dsSenhas.SenhaDataTable data = new dsSenhas.SenhaDataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(dsSenhas.SenhaDataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(dsSenhas dataSet) => this.Adapter.Update((DataSet) dataSet, "Senha");

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
    public virtual int Delete(string Original_Usuario, string Original_Descricao)
    {
      if (Original_Usuario == null)
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_Usuario;
      if (Original_Descricao == null)
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.DeleteCommand.Parameters[1].Value = (object) Original_Descricao;
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
    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Insert(string Usuario, string Descricao, string Senha)
    {
      if (Usuario == null)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) Usuario;
      if (Descricao == null)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) Descricao;
      if (Senha == null)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) Senha;
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
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(
      string Usuario,
      string Descricao,
      string Senha,
      string Original_Usuario,
      string Original_Descricao)
    {
      if (Usuario == null)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) Usuario;
      if (Descricao == null)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) Descricao;
      if (Senha == null)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) Senha;
      if (Original_Usuario == null)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) Original_Usuario;
      if (Original_Descricao == null)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) Original_Descricao;
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

    [DataObjectMethod(DataObjectMethodType.Update, true)]
    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(string Senha, string Original_Usuario, string Original_Descricao) => this.Update(Original_Usuario, Original_Descricao, Senha, Original_Usuario, Original_Descricao);
  }
}
