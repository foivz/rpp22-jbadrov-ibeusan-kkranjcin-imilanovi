# Inicijalne upute za prijavu projekta iz Razvoja programskih proizvoda

asdfghjklč

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Razvoj programskih proizvoda, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. Mentor će vam slati povratne informacije kroz sekciju Discussions također dostupnu na GitHubu vašeg projekta. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# LibRes

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Jan Badrov | jbadrov20@student.foi.hr | 0016151855 | jbadrov20
Ivan Beusan | ibeusan20@student.foi.hr | 0016150244 | ibeusan20
Karlo Kranjčina | kkranjcin20@student.foi.hr | 0016146923 | kkranjcin20
Ivan Milanović-Litre | imilanovi20@student.foi.hr | 0016150879 | imilanovi20


## Opis domene
Domena koju naš softver pokriva je rezervacija te praćenje broja i stanja knjiga u knjižnici. Softver će biti povezan s bazom podataka unutar koje se nalaze sve knjige iz knjižnice. Knjižničar će u sustavu moći pregledati sve knjige, rezervirati i otkazati rezervaciju knjige za člana knjižnice, dodati novopristiglu knjigu u knjižnicu te ih pretraživati. Osim toga, knjižničar može dodati nove članove u knjižnicu, pretraživati ih, ažurirati njihove podatke te izbrisati njihov profil. Softver će moći napraviti izračun kazne pri kašnjenju s povratkom knjige. 

## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka koju ćemo za vas mi pripremiti i dati vam pristup naknadno. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava u sustav | Knjižničar će imati mogućnost prijave u sustav koristeći dodijeljene korisničke podatke. | ...
F02 | Unos naslova |Knjižničar će imati mogućnost dodavanja nove knjige u sustav pri nabavi novih knjiga. | ...
F03 | Brisanje naslova | Knjižničar će imati mogućnost brisanja pojedine knjige iz sustava prilikom gubitka djela, oštećivanja i sličnih situacija. | ...
F04 | Ažuriranje podataka o naslovu | Knjižničar će imati mogućnost ažuriranja podataka o pojedinoj knjizi. | ...
F05 | Pregled naslova | Knjižničar će imati mogućnost pregled svih knjiga koji se nalaze u sustavu. | ...
F06 | Pregledati podatke naslova  | Knjižničar će imati mogućnost pregleda podatka knjige poput autora, naslova, godine izdanja. Također će moći provjeriti broj rezerviranih, broj zauzetih i broj dostupnih knjiga. | ...
F07 | Pretraživanje naslova | Knjižničar će imati mogućnost pretraživanja pojedine knjige ovisno o njenim podatcima. | ...
F08 | Registracija člana knjižnice | Knjižničar će imati mogućnost dodavanja novog člana knjižnice u sustav te unos korisničkih podataka člana. | ...
F09 | Brisanje člana knjižnice | Knjižničar će imati mogućnost brisanja člana knjižnice iz sustava. | ...
F10 | Ažuriranje korisničkih podataka člana knjižnice | Knjižničar će imati mogućnost ažuriranja podataka pojedinog korisnika. | ...
F11 | Pregled svih članova knjižnice | Knjižničar će imati uvid u sve registrirane članove knjižnice. | ...
F12 | Pregled podataka o pojedinom članu knjižnice | Knjižničar će imati mogućnost pregleda podataka pojedinog člana knjižnice kao što su ime, prezime, datum učlanjenja i sl. Također će imati mogućnost provjere trenutno rezerviranih i korištenih knjiga. | ...
F13 | Pretraživanje članova knjižnice | Knjižničar će imati mogućnost pretrage članova po njihovim korisničkim podatcima. | ...
F14 | Rezervacija knjige za člana knjižnice | Knjižničar će imati mogućnost rezervacije knjige za pojedinoga člana knjižnice ako postoji slobodan primjerak. | ...
F15 | Otkazivanje rezervacije knjige za člana knjižnice | Knjižničar će imati mogućnost otkazivanja bilo koje aktivne rezervacije. | ...
F16 | Dodavanje penala za kašnjenje pri povratku posuđenih naslova | Sustav će omogućiti dodavanje negativnih bodova na profil člana knjižnice ukoliko ne vrati knjigu na vrijeme. | ...



## Tehnologije i oprema
Za izradu softvera koristit ćemo programski jezik C# u .NET Framework. Za rad s bazom podataka koristit ćemo MySQL. Vrsta projekta je...

Umjesto ovih uputa jasno popišite sve tehnologije, alate i opremu koju ćete koristiti pri implementaciji vašeg rješenja. Projekti se razvijaju koristeći .Net Framework ili .Net Core razvojne okvire, a vrsta projekta može biti WinForms, WPF i UWP. Ne zaboravite planirati korištenje tehnologija u aktivnostima kao što su projektni menadžment ili priprema dokumentacije. Tehnologije koje ćete koristiti bi trebale biti javno dostupne, a ako ih ne budemo obrađivali na vježbama u vašoj dokumentaciji ćete morati navesti način preuzimanja, instaliranja i korištenja onih tehnologija koje su neopbodne kako bi se vaš programski proizvod preveo i pokrenuo. Pazite da svi alati koje ćete koristiti moraju imati odgovarajuću licencu. Što se tiče zahtjeva nastavnika, obvezno je koristiti git i GitHub za verzioniranje programskog koda, GitHub Wiki za pisanje tehničke i projektne dokumentacije, a projektne zadatke je potrebno planirati i pratiti u alatu GitHub projects. 
