// Decompiled with JetBrains decompiler
// Type: MemoMil.dsConfigTableAdapters.Config1TableAdapter
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

namespace MemoMil.dsConfigTableAdapters
{
  [DataObject(true)]
  [ToolboxItem(true)]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.TableAdapter")]
  public class Config1TableAdapter : Component
  {
    private OleDbDataAdapter _adapter;
    private OleDbConnection _connection;
    private OleDbCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    public Config1TableAdapter() => this.ClearBeforeFill = true;

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
        DataSetTable = "Config1",
        ColumnMappings = {
          {
            "CorAniversario",
            "CorAniversario"
          },
          {
            "CorFeriado",
            "CorFeriado"
          },
          {
            "CorLembrete",
            "CorLembrete"
          },
          {
            "CorAniversarioFore",
            "CorAniversarioFore"
          },
          {
            "CorFeriadoFore",
            "CorFeriadoFore"
          },
          {
            "CorLembreteFore",
            "CorLembreteFore"
          },
          {
            "cdConfig",
            "cdConfig"
          },
          {
            "NumDias",
            "NumDias"
          }
        }
      });
      this._adapter.DeleteCommand = new OleDbCommand();
      this._adapter.DeleteCommand.Connection = this.Connection;
      this._adapter.DeleteCommand.CommandText = "DELETE FROM `Config` WHERE ((`cdConfig` = ?))";
      this._adapter.DeleteCommand.CommandType = CommandType.Text;
      this._adapter.DeleteCommand.Parameters.Add(new OleDbParameter("Original_cdConfig", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdConfig", DataRowVersion.Original, false, (object) null));
      this._adapter.InsertCommand = new OleDbCommand();
      this._adapter.InsertCommand.Connection = this.Connection;
      this._adapter.InsertCommand.CommandText = "INSERT INTO `Config` (`cdConfig`, `CorAniversario`, `CorFeriado`, `CorLembrete`, `CorAniversarioFore`, `CorFeriadoFore`, `CorLembreteFore`, `NumDias`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
      this._adapter.InsertCommand.CommandType = CommandType.Text;
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("cdConfig", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdConfig", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CorAniversario", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorAniversario", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CorFeriado", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorFeriado", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CorLembrete", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorLembrete", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CorAniversarioFore", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorAniversarioFore", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CorFeriadoFore", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorFeriadoFore", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("CorLembreteFore", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorLembreteFore", DataRowVersion.Current, false, (object) null));
      this._adapter.InsertCommand.Parameters.Add(new OleDbParameter("NumDias", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NumDias", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand = new OleDbCommand();
      this._adapter.UpdateCommand.Connection = this.Connection;
      this._adapter.UpdateCommand.CommandText = "UPDATE `Config` SET `cdConfig` = ?, `CorAniversario` = ?, `CorFeriado` = ?, `CorLembrete` = ?, `CorAniversarioFore` = ?, `CorFeriadoFore` = ?, `CorLembreteFore` = ?, `NumDias` = ? WHERE ((`cdConfig` = ?))";
      this._adapter.UpdateCommand.CommandType = CommandType.Text;
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("cdConfig", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdConfig", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CorAniversario", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorAniversario", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CorFeriado", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorFeriado", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CorLembrete", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorLembrete", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CorAniversarioFore", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorAniversarioFore", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CorFeriadoFore", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorFeriadoFore", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("CorLembreteFore", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "CorLembreteFore", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("NumDias", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "NumDias", DataRowVersion.Current, false, (object) null));
      this._adapter.UpdateCommand.Parameters.Add(new OleDbParameter("Original_cdConfig", OleDbType.Integer, 0, ParameterDirection.Input, (byte) 0, (byte) 0, "cdConfig", DataRowVersion.Original, false, (object) null));
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
      this._commandCollection[0].CommandText = "SELECT     Config.*\r\nFROM         Config";
      this._commandCollection[0].CommandType = CommandType.Text;
    }

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    public virtual int Fill(dsConfig.Config1DataTable dataTable)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual dsConfig.Config1DataTable GetData()
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      dsConfig.Config1DataTable data = new dsConfig.Config1DataTable();
      this.Adapter.Fill((DataTable) data);
      return data;
    }

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(dsConfig.Config1DataTable dataTable) => this.Adapter.Update((DataTable) dataTable);

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(dsConfig dataSet) => this.Adapter.Update((DataSet) dataSet, "Config1");

    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Update(DataRow dataRow) => this.Adapter.Update(new DataRow[1]
    {
      dataRow
    });

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(DataRow[] dataRows) => this.Adapter.Update(dataRows);

    [DebuggerNonUserCode]
    [HelpKeyword("vs.data.TableAdapter")]
    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public virtual int Delete(int? Original_cdConfig)
    {
      if (Original_cdConfig.HasValue)
        this.Adapter.DeleteCommand.Parameters[0].Value = (object) Original_cdConfig.Value;
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

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    [DebuggerNonUserCode]
    public virtual int Insert(
      int? cdConfig,
      int? CorAniversario,
      int? CorFeriado,
      int? CorLembrete,
      int? CorAniversarioFore,
      int? CorFeriadoFore,
      int? CorLembreteFore,
      int? NumDias)
    {
      if (cdConfig.HasValue)
        this.Adapter.InsertCommand.Parameters[0].Value = (object) cdConfig.Value;
      else
        this.Adapter.InsertCommand.Parameters[0].Value = (object) DBNull.Value;
      if (CorAniversario.HasValue)
        this.Adapter.InsertCommand.Parameters[1].Value = (object) CorAniversario.Value;
      else
        this.Adapter.InsertCommand.Parameters[1].Value = (object) DBNull.Value;
      if (CorFeriado.HasValue)
        this.Adapter.InsertCommand.Parameters[2].Value = (object) CorFeriado.Value;
      else
        this.Adapter.InsertCommand.Parameters[2].Value = (object) DBNull.Value;
      if (CorLembrete.HasValue)
        this.Adapter.InsertCommand.Parameters[3].Value = (object) CorLembrete.Value;
      else
        this.Adapter.InsertCommand.Parameters[3].Value = (object) DBNull.Value;
      if (CorAniversarioFore.HasValue)
        this.Adapter.InsertCommand.Parameters[4].Value = (object) CorAniversarioFore.Value;
      else
        this.Adapter.InsertCommand.Parameters[4].Value = (object) DBNull.Value;
      if (CorFeriadoFore.HasValue)
        this.Adapter.InsertCommand.Parameters[5].Value = (object) CorFeriadoFore.Value;
      else
        this.Adapter.InsertCommand.Parameters[5].Value = (object) DBNull.Value;
      if (CorLembreteFore.HasValue)
        this.Adapter.InsertCommand.Parameters[6].Value = (object) CorLembreteFore.Value;
      else
        this.Adapter.InsertCommand.Parameters[6].Value = (object) DBNull.Value;
      if (NumDias.HasValue)
        this.Adapter.InsertCommand.Parameters[7].Value = (object) NumDias.Value;
      else
        this.Adapter.InsertCommand.Parameters[7].Value = (object) DBNull.Value;
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
    [DataObjectMethod(DataObjectMethodType.Update, true)]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Update(
      int? cdConfig,
      int? CorAniversario,
      int? CorFeriado,
      int? CorLembrete,
      int? CorAniversarioFore,
      int? CorFeriadoFore,
      int? CorLembreteFore,
      int? NumDias,
      int? Original_cdConfig)
    {
      if (cdConfig.HasValue)
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) cdConfig.Value;
      else
        this.Adapter.UpdateCommand.Parameters[0].Value = (object) DBNull.Value;
      if (CorAniversario.HasValue)
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) CorAniversario.Value;
      else
        this.Adapter.UpdateCommand.Parameters[1].Value = (object) DBNull.Value;
      if (CorFeriado.HasValue)
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) CorFeriado.Value;
      else
        this.Adapter.UpdateCommand.Parameters[2].Value = (object) DBNull.Value;
      if (CorLembrete.HasValue)
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) CorLembrete.Value;
      else
        this.Adapter.UpdateCommand.Parameters[3].Value = (object) DBNull.Value;
      if (CorAniversarioFore.HasValue)
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) CorAniversarioFore.Value;
      else
        this.Adapter.UpdateCommand.Parameters[4].Value = (object) DBNull.Value;
      if (CorFeriadoFore.HasValue)
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) CorFeriadoFore.Value;
      else
        this.Adapter.UpdateCommand.Parameters[5].Value = (object) DBNull.Value;
      if (CorLembreteFore.HasValue)
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) CorLembreteFore.Value;
      else
        this.Adapter.UpdateCommand.Parameters[6].Value = (object) DBNull.Value;
      if (NumDias.HasValue)
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) NumDias.Value;
      else
        this.Adapter.UpdateCommand.Parameters[7].Value = (object) DBNull.Value;
      if (Original_cdConfig.HasValue)
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) Original_cdConfig.Value;
      else
        this.Adapter.UpdateCommand.Parameters[8].Value = (object) DBNull.Value;
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
    public virtual int Update(
      int? CorAniversario,
      int? CorFeriado,
      int? CorLembrete,
      int? CorAniversarioFore,
      int? CorFeriadoFore,
      int? CorLembreteFore,
      int? NumDias,
      int? Original_cdConfig)
    {
      return this.Update(Original_cdConfig, CorAniversario, CorFeriado, CorLembrete, CorAniversarioFore, CorFeriadoFore, CorLembreteFore, NumDias, Original_cdConfig);
    }
  }
}
