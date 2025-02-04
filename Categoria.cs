using System;

public class Categoria
{
	public Categoria()
	{

		public int Id { get; set; }
	    public string Name { get; set; }

	//relaciona as categorais com as ferramentas
        public ICollection<Ferramenta> Ferramentas{ get; set; }
    
}
}
