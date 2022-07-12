namespace RestApiModelDDD.Domain.Entitys
{
    public class Cliente : Base //Vai herdar a classe Base
    {
        public string Name { get; set; }
        public string LasName { get; set; }
        public string Email { get; set; }
        public DateTime DateCad { get; set; }
        public bool IsActive { get; set; }
    }
}
