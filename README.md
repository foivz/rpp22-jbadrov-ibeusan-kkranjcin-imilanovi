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
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Prijava u sustav | Knjižničar će imati mogućnost prijave u sustav koristeći QR kod. | Karlo Kranjčina
F02 | Unos, ažuriranje i brisanje naslova | Knjižničar će imati mogućnost dodavanja novog naslova u sustav pri nabavi novih naslova. Knjižničar će imati mogućnost ažuriranja podataka o pojedinom naslovu. Knjižničar će imati mogućnost brisanja pojedinog naslova iz sustava prilikom gubitka primjerka, oštećivanja i sličnih situacija. | Karlo Kranjčina
F03 | Pregled i pretraživanje naslova | Knjižničar će imati mogućnost pregled svih naslov koji se nalaze u sustavu. Knjižničar će imati mogućnost pretraživanja i filtriranja pojedinog naslova. | Jan Badrov
F04 | Pregledati podatke naslova  | Knjižničar će imati mogućnost pregleda podatka naslova poput autora, naslova, godine izdanja. Također će moći provjeriti broj rezerviranih, broj zauzetih i broj dostupnih naslova. Knjižničar će imati mogućnost dodavanja PDF verzije knjige te će biti moguće pregledati PDF verziju kroz aplikaciju. | Jan Badrov
F05 | Registracija i brisanje člana knjižnice te Ažuriranje korisničkih podataka | Knjižničar će imati mogućnost dodavanja novog člana knjižnice u sustav te unos korisničkih podataka člana. Knjižničar će imati mogućnost brisanja člana knjižnice iz sustava. Knjižničar će imati mogućnost ažuriranja podataka pojedinog korisnika. | Ivan Beusan
F06 | Pregled  i pretraživanje svih članova knjižnice | Knjižničar će imati uvid u sve registrirane članove knjižnice. Knjižničar će imati mogućnost pretrage i filtriranja članova po njihovim korisničkim podacima. | Ivan Beusan
F07 | Pregled podataka o pojedinom članu knjižnice | Knjižničar će imati mogućnost pregleda podataka pojedinog člana knjižnice kao što su ime, prezime, datum učlanjenja i sl. Također će imati mogućnost provjere trenutno rezerviranih i korištenih naslova. Popis trenutno posuđenih knjiga, rezerviranih knjiga, kao i popis svih dosadašnjih posudbi | Ivan Milanović-Litre
F08 | Rezervacija i otkazivanje rezervacije knjige za člana knjižnice | Knjižničar će imati mogućnost rezervacije naslova za pojedinoga člana knjižnice ako postoji slobodan primjerak. Knjižničar će imati mogućnost otkazivanja bilo koje aktivne rezervacije. | Ivan Milanović-Litre
F09 | Dodavanje penala za kašnjenje pri povratku posuđenih naslova | Sustav će izračunati iznos kazne ukoliko član ne vrati posuđeni naslov na vrijeme. | Jan Badrov
F10 | Posudba knjige | Prilikom dodavanja knjige na posudbu nekom korisniku potrebno je koristiti QR kodove i za skeniranje člana knjižnice i za skeniranje knjige. | ...
F11 | Vraćanje posuđene knjige |  | ...


## Tehnologije i oprema
Za izradu softvera koristit ćemo programski jezik C# u .NET Frameworku. Vrsta projekta je WinForms. Dokumentaciju ćemo većinski izrađivati u Wordu i Visual Paradigmu.
