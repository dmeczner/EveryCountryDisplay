Világ országai programozási feladat

Feladatvégzésre vonatkozó szabályok

1.	A feladatvégzés során (a fejlesztői gyakorlatnak megfelelően) szabadon használható az Internet vagy egyéb írásos forrás, viszont nem megengedett mástól segítséget kérni.
2.	Az alkalmazást C# nyelven kell kidolgozni, a használt keretrendszert (Blazor, MAUI, ASP.NET stb.) a pályázó szabadon megválaszthatja.
3.	A feladat megoldása során TDD módszertant és unit teszteket nem várunk el.
4.	A feladat kidolgozására 4 óra áll rendelkezésre.
5.	A specifikációban nem tárgyalt részletekről a pályázó önállóan dönthet.
6.	A képernyőkép csak illusztrációnak készült. A UI kialakítása lehet nagyon egyszerű, egy designos / csillogó megjelenés nem elvárás.
7.	A kidolgozás során a lenti fejezetben meghatározott prioritási sorrendben érdemes haladni.
8.	Az elkészült forráskódót a jelöltnek – a 4 órás feladatvégzési idő végén – el kell küldeni a groma.istvandr@sdadms.hu e-mail címre.

A feladat specifikációja

A megvalósítandó feladat egy országnyilvántartást vizuálisan megjelenítő egyképernyős webalkalmazás. Az alkalmazás induláskor letölti az alábbi nyilvánosan elérhető JSON REST szolgáltatás segítségével a rendszer alapját képző adatbázist:
https://restcountries.com/v3.1/all

A nyilvántartásban szereplő országokról az alábbi adatokat kell beolvasni a memóriába, záróljelben szerepeltetjük az adatmezőt egyértelműen meghatározó JSONPath kifejezést (https://en.wikipedia.org/wiki/JSONPath).

1.	Országkód ($[*].cca3): egyedi háromjegyű azonosírtó belső ábrázoláshoz, az ISO 3166-1 alpha-3 nemzetközi szabványt követi (https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3).
2.	Ország hivatalos neve ($[*].name.official): az adott ország hivatalos neve.
3.	Kontinens ($[*].region): A kontinens vagy régió, ahol az ország elhelyezkedik.
4.	Főváros ($[*].capital[0]): Az ország első számú fővárosa.
5.	Gini-index ($[*].gini.*): egy mérőszám, ami az ország vagyoni eloszlásának egyenlőtlenségeit méri százalékban kifejezve (https://hu.wikipedia.org/wiki/Gini-index).
6.	Zászló ($[*].flags.png): az ország hivatalos zászlóját ábrázoló PNG formátumú bitkép elérését leíró URL.
7.	Hivatalos valuták: $[*].currencies
    a,  Név ($[*].currencies.*.name): a valuta megnevezése.
    b,  Rövidítés ($[*].currencies.*~): a valuta rövidítése.
    c,  Devizajel ($[*].currencies.*.symbol): a valuta nemzetközileg alkalmazott devizajele.

 
Az országokról összegyűjtött adatokat az alábbi képernyővázlaton bemutatott elrendezésben kell prezentálni a felhasználónak:
1.  A képernyőn az Ország neve címke alatti legördülőből (<select>) szabadon kiválasztható a megtekintendő ország.
2.  A legördülőben történő sorváltás esetén (addEventListener & onchange) frissüljön az oldal (submit) a kiválasztott ország adataival!
3.  A többi kezelő – Kontinens, Főváros (<input>) – és adatlista – Valuták (<table>) – csak olvasható üzemmódban jelenjenek meg!
4.	A Gini-index adatot egy folyamatjelző sáv (<progress>) segítségével ábrázoljuk, értékkészlete 0 és 100 között legyen!
5.	A Zászló-t vizuális (<img>) formában kell megjeleníteni!
6.	A felület lehetőség szerint könnyen kezelhető legyen: tabulátor sorrend, WCAG akadálymentesség (aria-), reszponzív felület stb.
7.	A képernyő háttérszíne legyen konfigurációból szabályozható (dinamikus css), például az alábbi formában:
  {
    "Background": "blue"
  }

![kép](https://github.com/user-attachments/assets/a7d9ad4e-3edd-43d7-9df5-6bd1302ee062)


Feladatrészek megoldási prioritása
1.	Adatmodell kialakítása.
2.	REST API aladatok letöltése és feldolgozása.
3.	Felületvázlat összeállítása.
4.	Országváltó legördülő eseménykezelő.
5.	Valuták adatlista összeállítása.
6.	Háttérszín állíthatósága.
