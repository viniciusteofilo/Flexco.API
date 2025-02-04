using System;

public class Ferramenta
{
	public Ferramenta()
	{
		public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Disponivel { get; set; }

    //relaciona com as categorais de empresas
         public int CategoriaId { get; set; }
         public Categoria Categoria { get; set; }
  
    }
}
