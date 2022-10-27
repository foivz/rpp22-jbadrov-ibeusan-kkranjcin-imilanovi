# LibRes

## Projektni tim RPP22_07

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Jan Badrov | jbadrov20@student.foi.hr | 0016151855 | jbadrov20
Ivan Beusan | ibeusan20@student.foi.hr | 0016150244 | ibeusan20
Karlo Kranjčina | kkranjcin20@student.foi.hr | 0016146923 | kkranjcin20
Ivan Milanović-Litre | imilanovi20@student.foi.hr | 0016150879 | imilanovi20


## Opis domene
Domena koju naš softver pokriva je rezervacija te praćenje broja i stanja knjiga u knjižnici. Softver će biti povezan s bazom podataka unutar koje se nalaze sve knjige iz knjižnice. Knjižničar će u sustavu moći pregledati sve knjige, rezervirati i otkazati rezervaciju knjige za člana knjižnice, dodati novopristiglu knjigu u knjižnicu te ih pretraživati. Osim toga, knjižničar može dodati nove članove u knjižnicu, pretraživati ih, ažurirati njihove podatke te izbrisati njihov profil. Softver će moći napraviti izračun kazne pri kašnjenju s povratkom knjige. 


## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava u sustav | Knjižničar će imati mogućnost prijave u sustav koristeći QR kod. | Karlo Kranjčina
F02 | Unos, ažuriranje i brisanje knjige | Knjižničar će imati mogućnost dodavanja nove knjige u sustav pri nabavi novih knjiga. Knjižničar će imati mogućnost ažuriranja podataka o pojedinoj knjizi. Knjižničar će imati mogućnost brisanja pojedine knjige iz sustava. | Karlo Kranjčina
F03 | Pregled i pretraživanje knjige | Knjižničar će imati mogućnost pregleda svih knjiga koje se nalaze u sustavu. Knjižničar će imati mogućnost pretraživanja i filtriranja pojedine knjige. | Jan Badrov
F04 | Pregledati podatke knjige | Knjižničar će imati mogućnost pregleda podataka knjige poput autora, naslova, godine izdanja. Također će moći provjeriti broj rezerviranih, broj zauzetih i broj dostupnih primjeraka knjige. Knjižničar će imati mogućnost dodavanja PDF verzije knjige te će biti moguće pregledati PDF verziju kroz aplikaciju. | Jan Badrov
F05 | Unos, ažuriranje i brisanje primjerka knjige | Knjižničar će imati mogućnost dodavanja novog primjerka knjige u sustav pri nabavi novih primjeraka. Knjižničar će imati mogućnost ažuriranja podataka o pojedinom primjeru knjige. Knjižničar će imati mogućnost brisanja pojedinog primjerka iz sustava prilikom gubitka primjerka, oštećivanja i sličnih situacija. | Karlo Kranjčina
F06 | Registracija i brisanje člana knjižnice te ažuriranje korisničkih podataka | Knjižničar će imati mogućnost dodavanja novog člana knjižnice u sustav te samim time i kreiranje članske iskaznice (QR koda) za člana, mogućnost unosa korisničkih podataka člana, mogućnost brisanja člana knjižnice iz sustava te mogućnost ažuriranja podataka pojedinog korisnika. | Ivan Beusan
F07 | Pregled i pretraživanje svih članova knjižnice | Knjižničar će imati uvid u sve registrirane članove knjižnice te mogućnost pretrage i filtriranja članova po njihovim korisničkim podacima. | Ivan Beusan
F08 | Pregled podataka o pojedinom članu knjižnice | Knjižničar će imati mogućnost pregleda podataka pojedinog člana knjižnice kao što su ime, prezime, datum učlanjenja i sl. Također će imati mogućnost provjere trenutno rezerviranih i korištenih primjeraka nekog naslova. (Popis trenutno posuđenih primjeraka knjiga, rezerviranih primjeraka knjiga, kao i popis svih dosadašnjih posudbi). | Ivan Milanović-Litre
F09 | Rezervacija i otkazivanje rezervacije primjerka knjige za člana knjižnice | Knjižničar će imati mogućnost rezervacije primjerka za pojedinoga člana knjižnice ako postoji slobodan primjerak kao i mogućnost otkazivanja bilo koje aktivne rezervacije. | Ivan Milanović-Litre
F10 | Posudba primjerka knjige | Knjižničar će imati mogućnost davanja primjerka knjige na posudbu te će to činiti očitavanjem QR koda knjige te QR koda člana. | ...
F11 | Vraćanje posuđenog primjerka knjige | Aplikacija će pratiti vremenski period posuđenosti knjige. Knjižničar će imati mogućnost vraćanja knjige korištenjem QR koda te pregled penala. | ...


## Tehnologije i oprema
Za izradu softvera koristit ćemo programski jezik C# u .NET Frameworku. Vrsta projekta je WinForms. Dokumentaciju ćemo većinski izrađivati u Wordu i Visual Paradigmu.
