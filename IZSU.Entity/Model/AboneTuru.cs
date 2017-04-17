namespace IZSU.Entity.Model
{
    public class AboneTuru
    {
        public int AboneTuruID { get; set; }
        public string AboneTuruAd { get; set; }

        public override string ToString()
        {
            return AboneTuruAd;
        }
    }
}
