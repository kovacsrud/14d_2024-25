using System;
using System.Collections.Generic;

namespace WpfKutyakUniqueEF.mvvm.models;

public partial class Kutya
{
    public int Id { get; set; }

    public int Fajtaid { get; set; }

    public int Nevid { get; set; }

    public int Eletkor { get; set; }

    public string Utolsoell { get; set; } = null!;

    public virtual Kutyafajtak Fajta { get; set; } = null!;

    public virtual Kutyanevek Nev { get; set; } = null!;
}
