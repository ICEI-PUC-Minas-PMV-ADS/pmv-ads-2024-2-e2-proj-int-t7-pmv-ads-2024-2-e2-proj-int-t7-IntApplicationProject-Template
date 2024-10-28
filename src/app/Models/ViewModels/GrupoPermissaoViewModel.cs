using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

public class GrupoPermissaoViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    
    // Add these two properties:
    public List<int> PermissoesSelecionadas { get; set; }
    public MultiSelectList PermissoesDisponiveis { get; set; }
    public List<string> PermissoesNomes { get; set; }
}
