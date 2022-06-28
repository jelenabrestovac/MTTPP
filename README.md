

## Projekt

Scenarij ovog testa bio je provjeriti funkcionalnost web stranice. Korišten je Katalon Recorder koji je snimio 5 testnih slučajeva te je potom korišten Visual Studio za kreiranje NUnit Test Projekta. U Visual Studiju je pomoću Selenium Web Drivera, NUnit frameworka, Test Adaptera i Chrome Drivera testirana dodana testna skripta u C# koja je prilagođena. Pokretanje testa je izvršeno u Test Exploreru.


![image](https://user-images.githubusercontent.com/93642039/176233972-d508612b-a1ff-4be8-be51-3b60f908b955.png)

## Testni slučajevi

Area of functionality: Modul za prijavu korisnika, promjenu podataka i odjavu korisnika
Objective: Provjera funkcionalnosti prijave korisnika, odjave korisnika i promjene podataka
Test case results: 5 testnih točki: 5 Pass, 0 Fail
Note: Korisnik je prethodno registriran

Test seq. ID Action taken Precondition Expected results Pass/Fail Note (in the case of "Fail")

1. Korisnik upisuje ime stranice https://parabank.parasoft.com/parabank/index.htm
2. Korisnik se prijavljuje sa svojim korisničkim podacima
3. Korisnik testira navigacijsku traku (About Us, Services, Products)
4. Korisnik ažurira informacije (adresu)
5. Korisnik se odjavljuje
