// Decompiled with JetBrains decompiler
// Type: MemoMil.dsSenhasTableAdapters.TableAdapterManager
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;

namespace MemoMil.dsSenhasTableAdapters
{
  [HelpKeyword("vs.data.TableAdapterManager")]
  [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
  [DesignerCategory("code")]
  [ToolboxItem(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public class TableAdapterManager : Component
  {
    private TableAdapterManager.UpdateOrderOption _updateOrder;
    private SenhaTableAdapter _senhaTableAdapter;
    private bool _backupDataSetBeforeUpdate;
    private IDbConnection _connection;

    [DebuggerNonUserCode]
    public TableAdapterManager.UpdateOrderOption UpdateOrder
    {
      get => this._updateOrder;
      set => this._updateOrder = value;
    }

    [Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
    [DebuggerNonUserCode]
    public SenhaTableAdapter SenhaTableAdapter
    {
      get => this._senhaTableAdapter;
      set => this._senhaTableAdapter = value;
    }

    [DebuggerNonUserCode]
    public bool BackupDataSetBeforeUpdate
    {
      get => this._backupDataSetBeforeUpdate;
      set => this._backupDataSetBeforeUpdate = value;
    }

    [DebuggerNonUserCode]
    [Browsable(false)]
    public IDbConnection Connection
    {
      get
      {
        if (this._connection != null)
          return this._connection;
        return this._senhaTableAdapter != null && this._senhaTableAdapter.Connection != null ? (IDbConnection) this._senhaTableAdapter.Connection : (IDbConnection) null;
      }
      set => this._connection = value;
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    public int TableAdapterInstanceCount
    {
      get
      {
        int adapterInstanceCount = 0;
        if (this._senhaTableAdapter != null)
          ++adapterInstanceCount;
        return adapterInstanceCount;
      }
    }

    [DebuggerNonUserCode]
    private int UpdateUpdatedRows(
      dsSenhas dataSet,
      List<DataRow> allChangedRows,
      List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._senhaTableAdapter != null)
      {
        DataRow[] realUpdatedRows = this.GetRealUpdatedRows(dataSet.Senha.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent), allAddedRows);
        if (realUpdatedRows != null && 0 < realUpdatedRows.Length)
        {
          num += this._senhaTableAdapter.Update(realUpdatedRows);
          allChangedRows.AddRange((IEnumerable<DataRow>) realUpdatedRows);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateInsertedRows(dsSenhas dataSet, List<DataRow> allAddedRows)
    {
      int num = 0;
      if (this._senhaTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Senha.Select((string) null, (string) null, DataViewRowState.Added);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._senhaTableAdapter.Update(dataRowArray);
          allAddedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private int UpdateDeletedRows(dsSenhas dataSet, List<DataRow> allChangedRows)
    {
      int num = 0;
      if (this._senhaTableAdapter != null)
      {
        DataRow[] dataRowArray = dataSet.Senha.Select((string) null, (string) null, DataViewRowState.Deleted);
        if (dataRowArray != null && 0 < dataRowArray.Length)
        {
          num += this._senhaTableAdapter.Update(dataRowArray);
          allChangedRows.AddRange((IEnumerable<DataRow>) dataRowArray);
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
    {
      if (updatedRows == null || updatedRows.Length < 1 || allAddedRows == null || allAddedRows.Count < 1)
        return updatedRows;
      List<DataRow> dataRowList = new List<DataRow>();
      for (int index = 0; index < updatedRows.Length; ++index)
      {
        DataRow updatedRow = updatedRows[index];
        if (!allAddedRows.Contains(updatedRow))
          dataRowList.Add(updatedRow);
      }
      return dataRowList.ToArray();
    }

    [DebuggerNonUserCode]
    public virtual int UpdateAll(dsSenhas dataSet)
    {
      if (dataSet == null)
        throw new ArgumentNullException(nameof (dataSet));
      if (!dataSet.HasChanges())
        return 0;
      if (this._senhaTableAdapter != null && !this.MatchTableAdapterConnection((IDbConnection) this._senhaTableAdapter.Connection))
        throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
      IDbConnection connection = this.Connection;
      if (connection == null)
        throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
      bool flag = false;
      if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
        connection.Close();
      if (connection.State == ConnectionState.Closed)
      {
        connection.Open();
        flag = true;
      }
      IDbTransaction dbTransaction = connection.BeginTransaction();
      if (dbTransaction == null)
        throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
      List<DataRow> allChangedRows = new List<DataRow>();
      List<DataRow> allAddedRows = new List<DataRow>();
      List<DataAdapter> dataAdapterList = new List<DataAdapter>();
      Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
      int num = 0;
      DataSet dataSet1 = (DataSet) null;
      if (this.BackupDataSetBeforeUpdate)
      {
        dataSet1 = new DataSet();
        dataSet1.Merge((DataSet) dataSet);
      }
      try
      {
        if (this._senhaTableAdapter != null)
        {
          dictionary.Add((object) this._senhaTableAdapter, (IDbConnection) this._senhaTableAdapter.Connection);
          this._senhaTableAdapter.Connection = (OleDbConnection) connection;
          this._senhaTableAdapter.Transaction = (OleDbTransaction) dbTransaction;
          if (this._senhaTableAdapter.Adapter.AcceptChangesDuringUpdate)
          {
            this._senhaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            dataAdapterList.Add((DataAdapter) this._senhaTableAdapter.Adapter);
          }
        }
        if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
        {
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
        }
        else
        {
          num += this.UpdateInsertedRows(dataSet, allAddedRows);
          num += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
        }
        num += this.UpdateDeletedRows(dataSet, allChangedRows);
        dbTransaction.Commit();
        if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
        if (0 < allChangedRows.Count)
        {
          DataRow[] array = new DataRow[allChangedRows.Count];
          allChangedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChanges();
        }
      }
      catch (Exception ex)
      {
        dbTransaction.Rollback();
        if (this.BackupDataSetBeforeUpdate)
        {
          dataSet.Clear();
          dataSet.Merge(dataSet1);
        }
        else if (0 < allAddedRows.Count)
        {
          DataRow[] array = new DataRow[allAddedRows.Count];
          allAddedRows.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
          {
            DataRow dataRow = array[index];
            dataRow.AcceptChanges();
            dataRow.SetAdded();
          }
        }
        throw ex;
      }
      finally
      {
        if (flag)
          connection.Close();
        if (this._senhaTableAdapter != null)
        {
          this._senhaTableAdapter.Connection = (OleDbConnection) dictionary[(object) this._senhaTableAdapter];
          this._senhaTableAdapter.Transaction = (OleDbTransaction) null;
        }
        if (0 < dataAdapterList.Count)
        {
          DataAdapter[] array = new DataAdapter[dataAdapterList.Count];
          dataAdapterList.CopyTo(array);
          for (int index = 0; index < array.Length; ++index)
            array[index].AcceptChangesDuringUpdate = true;
        }
      }
      return num;
    }

    [DebuggerNonUserCode]
    protected virtual void SortSelfReferenceRows(
      DataRow[] rows,
      DataRelation relation,
      bool childFirst)
    {
      Array.Sort<DataRow>(rows, (IComparer<DataRow>) new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
    }

    [DebuggerNonUserCode]
    protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection) => this._connection != null || this.Connection == null || inputConnection == null || string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    public enum UpdateOrderOption
    {
      InsertUpdateDelete,
      UpdateInsertDelete,
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
    private class SelfReferenceComparer : IComparer<DataRow>
    {
      private DataRelation _relation;
      private int _childFirst;

      [DebuggerNonUserCode]
      internal SelfReferenceComparer(DataRelation relation, bool childFirst)
      {
        this._relation = relation;
        if (childFirst)
          this._childFirst = -1;
        else
          this._childFirst = 1;
      }

      [DebuggerNonUserCode]
      private bool IsChildAndParent(DataRow child, DataRow parent)
      {
        DataRow parentRow = child.GetParentRow(this._relation, DataRowVersion.Default);
        while (parentRow != null && !object.ReferenceEquals((object) parentRow, (object) child) && !object.ReferenceEquals((object) parentRow, (object) parent))
          parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default);
        if (parentRow == null)
        {
          parentRow = child.GetParentRow(this._relation, DataRowVersion.Original);
          while (parentRow != null && !object.ReferenceEquals((object) parentRow, (object) child) && !object.ReferenceEquals((object) parentRow, (object) parent))
            parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original);
        }
        return object.ReferenceEquals((object) parentRow, (object) parent);
      }

      [DebuggerNonUserCode]
      public int Compare(DataRow row1, DataRow row2)
      {
        if (object.ReferenceEquals((object) row1, (object) row2))
          return 0;
        if (row1 == null)
          return -1;
        if (row2 == null)
          return 1;
        if (this.IsChildAndParent(row1, row2))
          return this._childFirst;
        return this.IsChildAndParent(row2, row1) ? -1 * this._childFirst : 0;
      }
    }
  }
}
