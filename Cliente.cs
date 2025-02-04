using System;

public class Cliente
{
	public Cliente()
	{

		public string Name { get; set; }
	    public string Email { get; set; }
	    public int Id { get; set; }

		  // Relacionamento com Contratos
    public ICollection<Contrato> Contratos { get; set; }
}
}
