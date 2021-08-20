namespace AulaPolimorfismoPt2
{
    class Novo : Imovel
    {
        public double Adicional { get; set; }
        public override void Calcula()
        {
            Preco += Adicional;
        }
    }
}
