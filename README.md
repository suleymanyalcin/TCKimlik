# TCKimlik
Bu Kütüphane TCK(Türkiye Cumhuriyeti Kimlik) numarasının doğruluğunu
https://tckimlik.nvi.gov.tr/Service/KPSPublicv2.asmx?WSDL adresinde yayınlanan servisi kullanarak 
kontrol etmenizi sağlar.

#TCKimlik Nesnesini Oluşturma.
<b>1-TCKimlik.CreateInstance()<b/>

Statik CreateInstance()  Fonksiyonu Size bir TCKimlik Nesnesi Geri döndürür.

<b>2-TCKimlik item = new TCKimlik()<b/>

#Doğrulama işlemi
Doğrulama İşleminde varsayılan değerleri Null atanmış fieldlar Nufüz müdürlüğünde bulunan kimlik kaydında eğer yoksa null olarak bırakılmalıdır.
null olarak bıraktığınız değer nufüz kaydınızda bulunuyorsa işlem yapılamayacaktır.

<b>1- Bool Dogrula(long tcKimlikNo, string ad, int dogumYil, string soyad = null, int? dogumGun = null, int? dogumAy = null)<b/>

Bu Doğrulama işlemi kişinin kütükte mevcut son "Açık" kayıt bilgilerinin doğrulanması sağlanacaktır.

<b>2-Bool Dogrula(long tcKimlikNo, string ad, int dogumYil, int? cuzdanNo, string cuzdanSeri, string soyad = null, int? dogumGun = null, int? dogumAy = null)<b/>

Bu Doğrulama işlemi kişiye ait son aktif Nüfus Cüzdanı üzerinde yazan bilgilerin doğrulanması sağlanacaktır.
#Asenkron Doğrulama
<b>1-DogrulaAsync(long tcKimlikNo, string ad, int dogumYil, string soyad = null, int? dogumGun = null, int? dogumAy = null)<b/>

<b>2-DogrulaAsync(long tcKimlikNo, string ad, int dogumYil, int? cuzdanNo, string cuzdanSeri, string soyad = null, int? dogumGun = null, int? dogumAy = null)<b/>





