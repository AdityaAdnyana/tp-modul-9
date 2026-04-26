using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_103082400005.Controller
{
    [ApiController]
    [Route("api/mahasiswa")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("I Putu Gde Aditya Stiti Adnyana", "103082400005"),
            new Mahasiswa("Ridho Ananta Wibowo", "103082400024"),
            new Mahasiswa("Farid Abdurochman A", "103082400018")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswaBaru)
        {
            mahasiswaList.Add(mahasiswaBaru);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < mahasiswaList.Count)
            {
                mahasiswaList.RemoveAt(id);
            }
        }
    }
}