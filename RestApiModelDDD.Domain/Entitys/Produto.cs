namespace RestApiModelDDD.Domain.Entitys
{
    public class Produto : Base    //Vai herdar a classe Base
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool IsDisponible { get; set; }
    }
}
