// Decompiled with JetBrains decompiler
// Type: MemoMil.ICadastro
// Assembly: MemoMil, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9C7E3763-5270-4A8A-B38E-4BB30F3D9267
// Assembly location: D:\Gimenez & Gimenez\Memo Mil\MemoMil.exe

namespace MemoMil
{
  internal interface ICadastro
  {
    void AdicionarRegistro(bool ativo);

    void AlterarRegistro(bool ativo);

    void ExcluirRegistro(bool ativo);

    void AvancarRegistro();

    void RetrocederRegistro();

    void PrimeiroRegistro();

    void UltimoRegistro();
  }
}
