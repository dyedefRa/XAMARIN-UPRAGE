
----------------------------------------------------
2 AudioPage> için Android te bir kaç izin gerekiyor.
NuGet > plugin.audiorecorder indir
Android > Properties > AndroidManifest 
ALLOW MODIFY_AUDIO_SETTINGS & RECORD_AUDIO
----------------------------------------------------
3 BatterySamplePage >
ALLOW BATTERY_STATS
----------------------------------------------------
Preferences
Kullanýcý se.imlerini vs gibi deðerleri tutar.
Key value seþklinde çalýþýr
---------------
DeviceDisplay  telefon çevrildiðinde yakalýyoruz. Event verebýlýyoruz.
----------------------------------------------------
CheckConnectPage>  (Ýnternet var mý yok mu ? deðiþtiðinde ne olsun.)
ALLOW ACCESS_NETWORK_STATE
----------------------------------------------------
ShakeMovementPage>
Telefonun konumunu x y z ye göre verir duruþunu görüþünü vs.. yakalayabýlýrsýn.
https://www.youtube.com/watch?v=6ZAom6csHWw&list=PLfbOp004UaYWUR5MC_eck7ldVWkGY9lea&index=11&ab_channel=GeraldVersluis
----------------------------------------------------
ContactsSamplePage >
Rehbere ulaþma iþlemi. Bununla seçilen kiþinin telefonuna ulaþýlabýlýyor.
ALLOW READ_CONTACTS
