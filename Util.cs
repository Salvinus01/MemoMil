// Decompiled with JetBrains decompiler
// Type: MemoMil.Util
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using MemoMil.dsConfigTableAdapters;
using MemoMil.dsContatoTableAdapters;
using MemoMil.dsMemoMilTableAdapters;
using MemoMil.dsSenhasTableAdapters;
using MemoMil.dsUsuarioTableAdapters;
using System;
using System.Data;

namespace MemoMil
{
  public class Util
  {
    private const string _SA = ";Jet OLEDB:Database Password=sacaromyces";

    public static dsMemoMil CarregarDataSet()
    {
      dsMemoMil dsMemoMil = new dsMemoMil();
      Evento1TableAdapter evento1TableAdapter = new Evento1TableAdapter();
      evento1TableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      evento1TableAdapter.Fill(dsMemoMil.Evento1);
      return dsMemoMil;
    }

    public static void SalvarDataSet(dsMemoMil ds)
    {
      Evento1TableAdapter evento1TableAdapter = new Evento1TableAdapter();
      evento1TableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      evento1TableAdapter.Update(ds);
    }

    public static void NormalizarDataSet(dsMemoMil ds)
    {
      for (int index = ds.Evento1.Rows.Count - 1; index >= 0; --index)
      {
        if ((ds.Evento1.Rows[index]["Tipo"].ToString() == "Lembrete" || ds.Evento1.Rows[index]["Tipo"].ToString() == "Aviso") && DateTime.Parse(ds.Evento1.Rows[index]["DataEvento"].ToString()) < DateTime.Today)
          ds.Evento1.Rows.RemoveAt(index);
      }
      foreach (dsMemoMil.Evento1Row evento1Row in (TypedTableBase<dsMemoMil.Evento1Row>) ds.Evento1)
      {
        switch (evento1Row.Tipo.Trim())
        {
          case "Aniversario":
          case "Feriado":
            if (evento1Row.DataLembrete < DateTime.Today)
            {
              evento1Row.DataLembrete = new DateTime(DateTime.Today.Year + 1, evento1Row.DataEvento.Month, evento1Row.DataEvento.Day);
              continue;
            }
            continue;
          case "Aviso Recorrente":
            if (evento1Row.DataLembrete < DateTime.Now && evento1Row.Mostrado)
            {
              TimeSpan timeSpan = DateTime.Today.AddDays(1.0) - evento1Row.DataLembrete.Date;
              evento1Row.DataLembrete = evento1Row.DataLembrete.Add(timeSpan);
              evento1Row.Mostrado = false;
              continue;
            }
            continue;
          default:
            continue;
        }
      }
    }

    public static dsConfig CarregarDataSetConfiguracao()
    {
      dsConfig dsConfig = new dsConfig();
      Config1TableAdapter config1TableAdapter = new Config1TableAdapter();
      config1TableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      config1TableAdapter.Fill(dsConfig.Config1);
      return dsConfig;
    }

    public static void SalvarDataSetConfiguracao(dsConfig ds)
    {
      Config1TableAdapter config1TableAdapter = new Config1TableAdapter();
      config1TableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      config1TableAdapter.Update(ds);
    }

    public static dsUsuario CarregarDataSetUsuario()
    {
      dsUsuario dsUsuario = new dsUsuario();
      UsuarioTableAdapter usuarioTableAdapter = new UsuarioTableAdapter();
      usuarioTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      usuarioTableAdapter.Fill(dsUsuario.Usuario);
      return dsUsuario;
    }

    public static void SalvarDataSetUsuario(dsUsuario ds)
    {
      UsuarioTableAdapter usuarioTableAdapter = new UsuarioTableAdapter();
      usuarioTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      usuarioTableAdapter.Update(ds);
    }

    public static dsSenhas CarregarDataSetSenhas(string Usuario)
    {
      dsSenhas dsSenhas = new dsSenhas();
      SenhaTableAdapter senhaTableAdapter = new SenhaTableAdapter();
      senhaTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      senhaTableAdapter.Fill(dsSenhas.Senha, Usuario);
      return dsSenhas;
    }

    public static void SalvarDataSetSenhas(dsSenhas ds)
    {
      SenhaTableAdapter senhaTableAdapter = new SenhaTableAdapter();
      senhaTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      senhaTableAdapter.Update(ds);
    }

    public static dsContato RecuperarContatos()
    {
      dsContato dsContato = new dsContato();
      ContatoTableAdapter contatoTableAdapter = new ContatoTableAdapter();
      contatoTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      contatoTableAdapter.Fill(dsContato.Contato);
      TelefoneTableAdapter telefoneTableAdapter = new TelefoneTableAdapter();
      telefoneTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      telefoneTableAdapter.Fill(dsContato.Telefone);
      EmailTableAdapter emailTableAdapter = new EmailTableAdapter();
      emailTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      emailTableAdapter.Fill(dsContato.Email);
      return dsContato;
    }

    public static int InserirContato(string Nome)
    {
      ContatoTableAdapter contatoTableAdapter = new ContatoTableAdapter();
      contatoTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      contatoTableAdapter.Insert(Nome.Trim());
      return contatoTableAdapter.Novo_cdContato().HasValue ? int.Parse(contatoTableAdapter.Novo_cdContato().ToString()) : 0;
    }

    public static void AlterarContato(int cdContato, string Nome)
    {
      ContatoTableAdapter contatoTableAdapter = new ContatoTableAdapter();
      contatoTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      contatoTableAdapter.Update(Nome, cdContato);
    }

    public static void ExcluirContato(int cdContato)
    {
      TelefoneTableAdapter telefoneTableAdapter = new TelefoneTableAdapter();
      telefoneTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      telefoneTableAdapter.ExcluirTelefonesDoContato(new int?(cdContato));
      EmailTableAdapter emailTableAdapter = new EmailTableAdapter();
      emailTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      emailTableAdapter.ExcluirEmailsDoContato(new int?(cdContato));
      ContatoTableAdapter contatoTableAdapter = new ContatoTableAdapter();
      contatoTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      contatoTableAdapter.Delete(cdContato);
    }

    public static void ExcluirTelefonesDoContato(int cdContato)
    {
      TelefoneTableAdapter telefoneTableAdapter = new TelefoneTableAdapter();
      telefoneTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      telefoneTableAdapter.ExcluirTelefonesDoContato(new int?(cdContato));
    }

    public static void ExcluirEmailsdoContato(int cdContato)
    {
      EmailTableAdapter emailTableAdapter = new EmailTableAdapter();
      emailTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      emailTableAdapter.ExcluirEmailsDoContato(new int?(cdContato));
    }

    public static void InserirTelefone(int cdContato, string Telefone)
    {
      TelefoneTableAdapter telefoneTableAdapter = new TelefoneTableAdapter();
      telefoneTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      telefoneTableAdapter.Insert(new int?(cdContato), Telefone);
    }

    public static void InserirEmail(int cdContato, string Email)
    {
      EmailTableAdapter emailTableAdapter = new EmailTableAdapter();
      emailTableAdapter.Connection.ConnectionString += ";Jet OLEDB:Database Password=sacaromyces";
      emailTableAdapter.Insert(new int?(cdContato), Email);
    }
  }
}
