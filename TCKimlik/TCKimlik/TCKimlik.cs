/*
 */
using TCKimlik.IdentityService;
using System.Threading.Tasks;
namespace TCKimlik
{
    /// <summary>
    /// 
    /// </summary>
    public class TCKimlik
    {
        /// <summary>
        /// 
        /// </summary>
        private KPSPublicV2SoapClient _client;
        /// <summary>
        /// 
        /// </summary>
        public TCKimlik() { _client = new KPSPublicV2SoapClient(); _client.Open(); }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static TCKimlik CreateInstance() { return new TCKimlik(); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tcKimlikNo"></param>
        /// <param name="ad"></param>
        /// <param name="dogumYil"></param>
        /// <param name="soyad"></param>
        /// <param name="dogumGun"></param>
        /// <param name="dogumAy"></param>
        /// <returns></returns>
        public bool Dogrula(long tcKimlikNo, string ad, int dogumYil, string soyad = null, int? dogumGun = null, int? dogumAy = null)
        {
            return Dogrula(CreateBody(tcKimlikNo, dogumYil, ad, soyad, dogumGun, dogumAy, null, null, null));
        }
        public bool Dogrula(long tcKimlikNo, string ad, int dogumYil, int? cuzdanNo, string cuzdanSeri, string soyad = null, int? dogumGun = null, int? dogumAy = null)
        {
            return Dogrula(CreateBody(tcKimlikNo, dogumYil, ad, soyad, dogumGun, dogumAy, cuzdanNo, cuzdanSeri, null));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tcKimlikNo"></param>
        /// <param name="ad"></param>
        /// <param name="dogumYil"></param>
        /// <param name="soyad"></param>
        /// <param name="dogumGun"></param>
        /// <param name="dogumAy"></param>
        /// <returns></returns>
        public Task<KisiVeCuzdanDogrulaResponse> DogrulaAsync(long tcKimlikNo, string ad, int dogumYil, string soyad = null, int? dogumGun = null, int? dogumAy = null)
        {
            return DogrulaAsync(CreateBody(tcKimlikNo, dogumYil, ad, soyad, dogumGun, dogumAy, null, null, null));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tcKimlikNo"></param>
        /// <param name="ad"></param>
        /// <param name="dogumYil"></param>
        /// <param name="cuzdanNo"></param>
        /// <param name="cuzdanSeri"></param>
        /// <param name="soyad"></param>
        /// <param name="dogumGun"></param>
        /// <param name="dogumAy"></param>
        /// <returns></returns>
        public Task<KisiVeCuzdanDogrulaResponse> DogrulaAsync(long tcKimlikNo, string ad, int dogumYil, int? cuzdanNo, string cuzdanSeri, string soyad = null, int? dogumGun = null, int? dogumAy = null)
        {
            return DogrulaAsync(CreateBody(tcKimlikNo, dogumYil, ad, soyad, dogumGun, dogumAy, cuzdanNo, cuzdanSeri, null));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        private bool Dogrula(KisiVeCuzdanDogrulaRequestBody body)
        {
            return _client.KisiVeCuzdanDogrula(body.TCKimlikNo, body.Ad, body.Soyad, body.SoyadYok, body.DogumGun, body.DogumGunYok, body.DogumAy, body.DogumAyYok, body.DogumYil, body.CuzdanSeri, body.CuzdanNo, body.TCKKSeriNo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        private Task<KisiVeCuzdanDogrulaResponse> DogrulaAsync(KisiVeCuzdanDogrulaRequestBody body)
        {
            return _client.KisiVeCuzdanDogrulaAsync(body.TCKimlikNo, body.Ad, body.Soyad, body.SoyadYok, body.DogumGun, body.DogumGunYok, body.DogumAy, body.DogumAyYok, body.DogumYil, body.CuzdanSeri, body.CuzdanNo, body.TCKKSeriNo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tcKimlikNo"></param>
        /// <param name="dogumYil"></param>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <param name="dogumGun"></param>
        /// <param name="dogumAy"></param>
        /// <param name="cuzdanNo"></param>
        /// <param name="cuzdanSeri"></param>
        /// <param name="tckkSeriNo"></param>
        /// <returns></returns>
        private KisiVeCuzdanDogrulaRequestBody CreateBody(
            long tcKimlikNo,
            int dogumYil,
            string ad,
            string soyad = null,
            int? dogumGun = null,
            int? dogumAy = null,
            int? cuzdanNo = null,
            string cuzdanSeri = null,
            string tckkSeriNo = null
            )
        {
            var result = new KisiVeCuzdanDogrulaRequestBody()
            {
                TCKimlikNo = tcKimlikNo,
                Ad = ad,
                Soyad = soyad,
                DogumGun = dogumGun,
                DogumAy = dogumAy,
                DogumYil = dogumYil,
                CuzdanNo = cuzdanNo,
                CuzdanSeri = cuzdanSeri,
                TCKKSeriNo = tckkSeriNo,
                DogumAyYok = dogumAy == null ? true : false,
                DogumGunYok = dogumGun == null ? true : false,
                SoyadYok = soyad == null ? true : false
            };
            return result;
        }
    }
}
