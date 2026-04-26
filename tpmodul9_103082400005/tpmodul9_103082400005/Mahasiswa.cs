namespace tpmodul9_103082400005
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(string nama, string nim)
        {
            this.Nama = nama;
            this.Nim = nim;
        }
    }
}
