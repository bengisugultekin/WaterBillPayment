namespace IZSU.Entity.Model
{
    public class Abone
    {
        public int AboneID { get; set; }
        public string AboneAdSoyad { get; set; }
        public int AboneTuruID { get; set; }

        public AboneTuru AboneTuru { get; set; }
    }
}
