
----------------------------------------------------
2 AudioPage> i�in Android te bir ka� izin gerekiyor.
NuGet > plugin.audiorecorder indir
Android > Properties > AndroidManifest 
ALLOW MODIFY_AUDIO_SETTINGS & RECORD_AUDIO
----------------------------------------------------
3 BatterySamplePage >
ALLOW BATTERY_STATS
----------------------------------------------------
Preferences
Kullan�c� se.imlerini vs gibi de�erleri tutar.
Key value se�klinde �al���r
---------------
DeviceDisplay  telefon �evrildi�inde yakal�yoruz. Event vereb�l�yoruz.
----------------------------------------------------
CheckConnectPage>  (�nternet var m� yok mu ? de�i�ti�inde ne olsun.)
ALLOW ACCESS_NETWORK_STATE
----------------------------------------------------
ShakeMovementPage>
Telefonun konumunu x y z ye g�re verir duru�unu g�r���n� vs.. yakalayab�l�rs�n.
https://www.youtube.com/watch?v=6ZAom6csHWw&list=PLfbOp004UaYWUR5MC_eck7ldVWkGY9lea&index=11&ab_channel=GeraldVersluis
----------------------------------------------------
ContactsSamplePage >
Rehbere ula�ma i�lemi. Bununla se�ilen ki�inin telefonuna ula��lab�l�yor.
ALLOW READ_CONTACTS
----------------------------------------------------
GeocodingPage
�sme g�re lat lang , lat lang a g�re isim posta kodu vs vs gibi bilgilere eri�ebiliyoruz.
----------------------------------------------------
GeoLocationPage
ALLOW ACCESS_FINE_LOCATION  ACCESS_COARSE_LOCATION
Burada konumu buluyoruz . Surekl� konum istegi att�k
---------------------------------------------------
PickImagesAndPDFPage
ALLOW READ_EXTERNAL_STORAGE WRITE_EXTERNAL_STORAGE
