// Decompiled with JetBrains decompiler
// Type: MemoMil.Crypto
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

using System;
using System.Security.Cryptography;
using System.Text;

namespace MemoMil
{
  internal class Crypto
  {
    private const string _BLOB_Chave = "AQaAcNCMnd8BFdjRjHoAwE/Cl+sBA+-AaEZI6VkWBkuGy7mz0lJxFAQAAqACA5AAbAADZgAAqAAuABAAcABQWYtQBF1eCarohKtCNeObAAABAASAACCgAAAEEAAiAEAv+F9NB+HZ65fNClqXntQIAAAAyARpnFFc9C8UAAAAhmWCh+4FlSpZKJ20nxo+LajMmIs0";
    private const string _BLOB_VI = "bCaEcamoiIJOasdfeUiOIJOdflfneoi+-asfEAo34DFAHRoie4N90235aoieuioGEGETYAopXkoriBaeioNIUseokdOIIYFTFaseoiOIUGHIGseseOIJKIIUGsdfseoaueiuOINOqJUHIUsefoeifaose+-+eh+jsnfieuUGUI--uieseuhOIONaseoilk02j8ll";
    private string _Chave_Publica;

    public Crypto() => this._Chave_Publica = "AQaAcNCMnd8BFdjRjHoAwE/Cl+sBA+-AaEZI6VkWBkuGy7mz0lJxFAQAAqACA5AAbAADZgAAqAAuABAAcABQWYtQBF1eCarohKtCNeObAAABAASAACCgAAAEEAAiAEAv+F9NB+HZ65fNClqXntQIAAAAyARpnFFc9C8UAAAAhmWCh+4FlSpZKJ20nxo+LajMmIs0";

    public string Chave
    {
      set => this._Chave_Publica = value;
    }

    public string Encriptar(string texto)
    {
      if (texto == null)
        throw new ArgumentNullException(nameof (texto));
      byte[] inputBuffer = texto.Trim().Length != 0 ? Encoding.ASCII.GetBytes(texto) : throw new ArgumentException("Texto não fornecido", nameof (texto));
      byte[] numArray1 = (byte[]) null;
      using (SHA256Managed shA256Managed = new SHA256Managed())
        numArray1 = shA256Managed.ComputeHash(Encoding.ASCII.GetBytes(this._Chave_Publica));
      byte[] numArray2 = (byte[]) null;
      using (MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider())
        numArray2 = cryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("bCaEcamoiIJOasdfeUiOIJOdflfneoi+-asfEAo34DFAHRoie4N90235aoieuioGEGETYAopXkoriBaeioNIUseokdOIIYFTFaseoiOIUGHIGseseOIJKIIUGsdfseoaueiuOINOqJUHIUsefoeifaose+-+eh+jsnfieuUGUI--uieseuhOIONaseoilk02j8ll"));
      using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
      {
        rijndaelManaged.Key = numArray1;
        rijndaelManaged.IV = numArray2;
        return Convert.ToBase64String(rijndaelManaged.CreateEncryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
    }

    public string Decriptar(string textoEncriptado)
    {
      if (textoEncriptado == null)
        throw new ArgumentNullException(nameof (textoEncriptado));
      byte[] inputBuffer = textoEncriptado.Trim().Length != 0 ? Convert.FromBase64String(textoEncriptado) : throw new ArgumentException("Texto Encriptado não fornecido", nameof (textoEncriptado));
      byte[] numArray1 = (byte[]) null;
      using (SHA256Managed shA256Managed = new SHA256Managed())
        numArray1 = shA256Managed.ComputeHash(Encoding.ASCII.GetBytes(this._Chave_Publica));
      byte[] numArray2 = (byte[]) null;
      using (MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider())
        numArray2 = cryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes("bCaEcamoiIJOasdfeUiOIJOdflfneoi+-asfEAo34DFAHRoie4N90235aoieuioGEGETYAopXkoriBaeioNIUseokdOIIYFTFaseoiOIUGHIGseseOIJKIIUGsdfseoaueiuOINOqJUHIUsefoeifaose+-+eh+jsnfieuUGUI--uieseuhOIONaseoilk02j8ll"));
      using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
      {
        rijndaelManaged.Key = numArray1;
        rijndaelManaged.IV = numArray2;
        return Encoding.ASCII.GetString(rijndaelManaged.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
      }
    }

    public static string Encrypt(string texto) => new Crypto().Encriptar(texto);

    public static string Decrypt(string textoencriptado) => new Crypto().Decriptar(textoencriptado);
  }
}
