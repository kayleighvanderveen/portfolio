# You can place the script of your game in this file.

# Declare images below this line, using the image statement.
# eg. image eileen happy = "eileen_happy.png"
image henkbg = "henk.png"
image mariabg = "background digitale component v2.png"
image janbg = "jan.png"
image annabg = "maria.png"
image samuelbg = "background digitale component 2.png"
image willembg = "character+background1.jpg"
image simonbg = "character+background3.jpg"
image wilhelminabg = "character+background5.jpg"


# Declare characters used by this game.
define jij = Character('Jij', color="#c8ffc8")
define henk = Character('Henk', color="#c8ffc8")
define maria = Character('Maria', color="#c8ffc8")
define jan = Character('Jan', color="#c8ffc8")
define anna = Character('Anna', color="#c8ffc8")
define samuel = Character('Josephina', color="#c8ffc8")
define willem = Character('Willem', color="#c8ffc8")
define simon = Character('Simon', color="#c8ffc8")
define wilhelmina = Character('Wilhelmina', color="#c8ffc8")


# The game starts here.
label start:

    scene Dialogue
    scene black
    menu:
        "Ik hoor bij het verzet":
            jump VERZET
        "Ik hoor bij de NSB":
            jump NSB
            
            
            
            
            
            
    label VERZET:
    scene black
    "Huis 1"
    hide black
    play music "bgmusic.mp3"
    scene henkbg
    henk "Hallo? Kan ik je helpen?"
    
    menu:
        "'Ik kom uw kind halen.'":
            jump bad
        "'Zou ik binnen mogen komen?'":
            jump verzet1
        "'Hallo, ik zit in het verzet.'":
            jump verzet1
            
    label verzet1:
        henk "Ow, Je komt zeker voor Sara. Haar ouders zijn 3 weken geleden opgepakt. En ik ben bang dat ze hier niet lang meer veilig is.."
        henk "Kan ik erop vertrouwen dat jullie haar zullen beschermen van de Nazi’s?"
        menu:
             "'We hebben niet veel tijd, we moeten snel handelen.'":
                 jump bad
             "'Ik kan helaas niet garanderen dat uw kind dit gaat overleven..'":
                 jump bad
             "'Maakt u zich geen zorgen, ze is veilig bij een van onze pleeggezinnen.'":
                 jump good
        
    label good:
        henk "We kunnen zo niet langer leven, ze heeft al een paar dagen geen voedsel gehad. Het doet me veel pijn maar het is niet anders. Neem haar maar mee."
        "'Het is je gelukt om de onderduikers mee te nemen!'"
        jump huistwee
            
    label bad:
        henk "Ik wil dat je nu weg gaat!"
        "Henk doet de deur dicht"
        "Het is je niet gelukt om de onderduikers mee te nemen!"
        jump huistwee
          
        
        
    label huistwee:
        stop music 
        scene black
        "Huis 2"
        hide black
        play music "bgmusic.mp3"
        scene mariabg
        maria "Sorry, ik heb nu geen tijd!"
        
        menu:  
            "'Het verzet heeft je nodig.'":
                jump mariaja
            "'Maar het zal niet lang duren.'":
                jump marianietmeenemen
            "'Ik heb belangrijke informatie..'":
                jump marianietmeenemen
                
    label marianietmeenemen:
        maria "Jullie zijn dus ook niet te vertrouwen! Niemand is te vertrouwen. Maak dat je wegkomt."
        "'Het is je niet gelukt om de onderduikers mee te nemen!'"
        jump huisdrie
        
    label mariaja:
        maria "Jullie hebben mij nodig?"
        menu: 
            "'Officieren zullen binnekort bij jullie langskomen'":
                jump mariameenemen
            "'Ik doe alleen wat mij opgedragen wordt'":
                jump marianietmeenemen
            
    label mariameenemen:
        maria "Wie heeft ons verraden? Je kan ook echt niemand meer vertrouwen.."
        maria "Maar oke, ik zal Abraham halen. Waat het niet om iets geks te doen!"
        "Het is je gelukt om de onderduikers mee te nemen!"
        jump huisdrie 
        
        
        
        
        
    label huisdrie:
        stop music
        scene black 
        "Huis 3"
        hide black
        play music "bgmusic.mp3"
        scene janbg
        jan "Hallo?"
        
        menu:
            "'Hallo, we moeten praten.'":
                jump jannietmeenemen
            "'Het studentenverzet heeft mij gestuurd.'":
                jump janja
            "'Zou ik binnen mogen komen?'":
                jump jannietmeenemen
                
    label janja:
        jan "Jij zit in wat!? Wat als je je familie in gevaar brengt? Ik heb zelf een dochter van 2 jaar. Ik had aan salomon belooft dat ik voor Jacob zou zorgen als hem iets zou overkomen. Nu zit ik hier met Jacob."
        jan "Ik heb wel van jullie gehoord. Denk je dat jullie alle Joodse kinderen kunnen redden?"
        
        menu:
            "'Zolang we de NSB voor zijn, kunnen we de kinderen redden.'":
                jump janmeenemen
            "'Ik geloof dat we alleen doen wat iedereen hoort te doen.'":
                jump janmeenemen
            "'Als we snel zijn, de tijd tikt door..'":
                jump jannietmeenemen
        
    label janmeenemen:
        jan "Ik hoop dat je gelijk hebt. Hij is 7 jaar oud. Zijn vliegtuigje is het enigste wat hij over heeft van zijn pa. Raak het niet kwijt. Dag Jacob"
        "Het is je gelukt om de onderduikers mee te nemen!"
        jump huisvier
        
    label jannietmeenemen:
        jan "Ik wil hier niet aan meewerken!"
        "'Het is je niet gelukt om de onderduikers mee te nemen!'"
        jump huisvier
        
        
        
        
        
    label huisvier:
        stop music
        scene black
        "Huis 4"
        hide black
        scene annabg
        play music "bgmusic.mp3"
        anna "Jeetje dit is de derde persoon al. Sorry maar ik heb geen voedselbon meer."
        
        menu:
            "'Waar heeft u het over?'":
                jump annanietmee
            "'Hier, ik heb een voedselbon voor u.'":
                jump annaja
            "'Het is ook mogelijk met geld rond te komen'":
                jump annanietmee
                
    label annaja:
        anna "Zo gul, waaraan heb ik dit verdiend? Ik bedoel we hebben het heel hard nodig. Nu dat de Nazi ons beperkt voedsel geven."
        anna "Waarom bent u hier gekomen. Ik denk niet alleen om voedselbonnen rond te geven ofwel?"
        
        menu:
            "'Ik weet dat u het liefst ieder kind wilt beschermen, maar dit houd u niet langer vol.'":
                jump annameenemen
            "'We doen allemaal ons best, maar wij net ietsje meer.'":
                jump annanietmee
            "'Wij van het verzet zouden u graag willen helpen, dat maakt het voor iedereen makkelijker.'":
                jump annameenemen
                
    label annanietmee:
        anna "Dat zal allemaal wel. Wij hebben geen hulp nodig, toch bedankt."
        "Het is je niet gelukt om de onderduikers mee te nemen!"
        jump huisvijf
        
    label annameenemen:
        anna "Ja ik zou iedereen willen helpen. Alleen lukt het niet meer. We hebben steeds minder voedsel. Joseph komt eraan, zorg goed voor hem."
        "Het is je gelukt om de onderduikers mee te nemen!"    
        jump huisvijf
        
        
        
        
        
    label huisvijf:
        stop music 
        scene black
        "Huis 5"
        hide black
        play music "bgmusic.mp3"
        scene samuelbg
        samuel "Stop met aankloppen. Ik heb geen tijd voor dit."
        
        menu:
            "'Ik weet van uw identiteit, ik wil alleen helpen.'":
                jump samuelja
            "'Snel, de NSB komt eraan!'":
                jump samuelnietmee
            "'Sorry, maar ze komen iedereen binnekort halen.'":
                jump samuelja
            
    label samuelja:
        samuel "Nee toch! Ik dacht dat onze papieren hadden verbrand. Ze zijn toch achter onze identiteit gekomen."
        samuel "Van wie heb je dat gehoord?"
        
        menu:
            "'Gehoord van betrouwbare bronnen.'":
                jump samuelnietmee
            "'We hebben studenten die informatie lekken.'":
                jump samuelmeenemen
            "'Dat hoorde ik de NSB net vertellen.'":
                jump samuelnietmee

    label samuelnietmee:
        samuel "Ik heb geen tijd en zin in deze grapjes. Wegwezen, nu!"
        "Het is je niet gelukt om de onderduikers mee te nemen!"
        jump huiszes
        
    label samuelmeenemen:
        "Ik wist dat deze dag zou komen. Ik heb Isaac hier al op voorbereid dus hij zal voor geen problemen zorgen."
        "Het is je gelukt om de onderduikers mee te nemen!"
        jump huiszes


        
        
    label huiszes:
        stop music 
        scene black
        "Huis 6"
        hide black
        play music "bgmusic.mp3"
        scene willembg
        willem "ja?"
        
        menu:
            "'Willem, ik ben van het verzet.'":
                jump willemja
            "'Hallo, heeft u een momentje om te praten?'":
                jump willemnietmee
            "'Willem, we moeten praten.'":
                jump willemnietmee
                
    label willemja:
        willem "Nou en, wat doe je hier.."
        willem "Wie heeft jou mijn adres gegeven?"
        
        menu:
            "'Ik ben hier voor de onderduiker, en ik kreeg je adres van het verzet.'":
                jump willemnietmee
            "'Geen tijd voor dat De onderduiker die bij jou verblijft, ze is niet meer veilig!'":
                jump willemmeenemen
            "'We kunnen deze informatie het best binnen bespreken.'":
                jump willemnietmee

    label willemnietmee:
        willem "Als je toch al weet wie ik ben, dat betekent dat we beide niet meer veilig zijn. We kunnen niet meer samen gezien worden, waag het niet hier nog eens langs te komen!"
        "Het is je niet gelukt om de onderduikers mee te nemen!"
        jump huiszeven
        
    label willemmeenemen:
        willem "Ik kan moeilijk zeggen dat ik je nu vertrouw. Zelfs in het verzet heb je ratten. Maargoed, Eva komt er zo aan, een moment."
        "Het is je gelukt om de onderduikers mee te nemen!"
        jump huiszeven
        
        
        
        
    label huiszeven:
        stop music 
        scene black
        "Huis 7"
        hide black
        play music "bgmusic.mp3"
        scene simonbg
        simon "Wat moet je?"
        
        menu:
            "'Ik ben van het verzet.'":
                jump simonnietmee
            "'We moeten de NSB voor zijn.'":
                jump simonnietmee
            "'De officieren kunnen hier elk momen zijn.'":
                jump simonja
                
    label simonja:
        simon "Nee toch, wat hebben Joden gedaan om dit te verdienen. We zijn gewoon mensen met familie en vrienden zoals iedereen."
        simon "Of heb ik het fout?"
        menu:
            "'Verschil moet er zijn in de wereld.'":
                jump simonnietmee
            "'We zijn allemaal hetzelfde, niemand is meer of minder.'":    
                jump simonmeenemen
            "'Helaas denkt niet iedereen er hetzelfde over.'":
                jump simonmeenemen
            
    label simonnietmee:
        simon "Ach mens, wij kunnen blijkbaar niet samen door een deur, geen spraken van dat ik jou zal vertrouwen. Lazer op!"
        "Het is je niet gelukt om de onderduikers mee te nemen!"
        jump huisacht
        
    label simonmeenemen:
        simon "Haha, je bent best naïef. Ik hoop dat er meer mensen zoals jou in de toekomst bestaan."
        "Het is je gelukt om de onderduikers mee te nemen!"
        jump huisacht
        
        
        
        
    label huisacht:
        stop music 
        scene black
        "Huis 8"
        hide black
        play music "bgmusic.mp3"
        scene wilhelminabg
        wilhelmina "Ja, wat kan ik voor je doen?"
        
        menu:
            "'We komen Clara ophalen.'":
                jump wilhelminanietmee
            "'We hebben niet veel tijd mevrouw.'":
                jump wilhelminanietmee
            "'Ik kom hulp aanbieden.'":
                jump wilhelminaja
    
    label wilhelminaja:
        wilhelmina "Ow nou ik heb veel hulp nodig. Ze willen mijn zoon oproepen voor de oorlog. Heb je hem gezien? Hij is zo dun als een stok,niet een echte vechter als je snap wat ik bedoel. Mijn man gaat nog proberen om boer Jan om hulp te vragen."
        wilhelmina "Heb je een idee of ken je iemand waar Jan kan verblijven?"
        menu:
            "'Sorry, ik zou graag helpen maar we moeten prioriteiten stellen.'":
                jump wilhelminanietmee
            "'Sorry, ik kan alleen helpen bij het onderduiken van Joodse jongeren.'":
                jump wilhelminameenemen
            "'Ik heb alleen orders gekregen voor Clara.'":
                jump wilhelminanietmee
                
    label wilhelminanietmee:
        wilhelmina "Nouja zeg. Dit verzoek moet ik vriendelijk afstaan. Tot nooit meer ziens."
        "Het is je niet gelukt om de onderduikers mee te nemen!"
        return
        
    label wilhelminameenemen:
        wilhelmina "Jammer, maar ook fijn dat je Clara wilt helpen. Ze heeft beide van haar ouders verloren aan de Nazi’s… arme meid, ze heeft een stem van een engel. Zorg goed voor haar."
        "Het is je gelukt om de onderduikers mee te nemen!"
        return
    
                
        
        
        
        
        
        
        
        
        
    label NSB:
    scene black
    "Huis 1"
    hide black    
    play music "bgmusic.mp3"
    scene henkbg
    "De deur gaat open.."
    henk "Uh… Ow, hallo officier. Is er een probleem?"
    
    menu:
        "'Wij komen langs voor controle, ga aan de kant!'":
            jump verzetten1
        "'Er is een bevel gegeven om een Jood op te pakken.'":
            jump nsb1
        "'Er is doorgegeven dat hier joden aanwezig zijn.'":
            jump verzetten1
            
    label nsb1:
        henk "Sorry maar ik denk echt dat u zich vergist?"
        menu:
            "'Luister eens hier. Als je niet uit mijn weg gaat worden jij en jouw familie ook vervoerd!.'":
                jump meewerken1
            "'Ik wil geen geweld gebruiken, dus ga uit mijn weg.'":
                jump verzetten1
            "'Als jij nou toch niet aan de kant gaat..'":
                jump verzetten1
                
    label meewerken1:
        henk "… Oke oke, ik zal haar halen. Laat mijn familie alstublieft hier buiten."
        "Je hebt het Joodse kind Sara meegenomen en laat de familie leven."
        jump nsbtwee
        
    label verzetten1:
        "Het Joodse kind Sara wordt meegenomen. Ze zal worden vervoerd naar het concentratiekamp."
        jump nsbtwee
        
        
        
        
        
    label nsbtwee:
        stop music
        scene black
        "Huis 2"
        hide black
        play music "bgmusic.mp3"
        scene mariabg
        maria "Oh hallo? Wat kan ik voor U betekenen?"
        jij "Ik heb een bevel voor een Jood"
        maria "Dat is heel raar, wie heeft u dat nou weer verteld?"
        
        menu:
            "'Luister, als je niet meewerkt zal het niet goedkomen met je familie.'":
                jump tweebad
            "'Ik wil niemand pijn doen, ik volg alleen mijn orders om het kind op te halen.'":
                jump tweegood

    label tweebad:
        maria "Ik wou dat ik kon helpen maar ik weet niks over een Jood hier"
        "Maria aarzeld en gaat terug naar binnen. Na een tijdje komt ze bij de deur met kleine Abraham.."
        maria "Alstublieft.. hij is maar een kind."
        "Abraham word met geweld uit haar handen getrokken. Maria krijgt een paar rake klappen. Het huilende gezicht van Abraham is het laatste wat ze van hem zag"
        "Je hebt met geweld de Jood opgepakt."
        jump nsbdrie
        
    label tweegood:
        maria "Ik wou dat ik kon helpen maar ik weet niks over een Jood hier"
        "Maria aarzeld en gaat terug naar binnen. Na een tijdje komt ze bij de deur met kleine Abraham.."
        maria "Alstublieft.. hij is maar een kind."
        "Abraham word uit haar handen getrokken. Het huilende gezicht van Abraham is het laatste wat ze van hem zag."
        "Het is je gelukt om de Jood op te pakken en hebt verder niemand pijn gedaan."
        jump nsbdrie
        
        
        
        
    label nsbdrie:
        stop music 
        scene black
        "Huis 3"
        hide black
        play music "bgmusic.mp3"
        scene janbg
        jan "Hallo Officier"
        
        menu:
            "'Shh! Stil. Ik kom naar binnen en doe alsof ik rondkijk. Ik blijf maar een half uur.'":
                jump driegood
            "'Ik heb de orders gekregen om dit huis te doorzoeken, ga aan de kant.'":
                jump driebad

    label driegood:
        jan "Waarom helpt u ons?"
        menu:
            "'We zijn niet allemaal slecht. Als ik mijn werk niet doe dan kan ik mijn gezin verliezen. Maar soms kan ik het gewoon niet, dus je het dit keer geluk.'":
                jump driegoodend
            "'Helpen? Waar heb je het over? Aan de kant! Ik moet het huis doorzoeken.'":
                jump driebadend
                
    label driebad:
        jan "Maar waarom? Er zijn hier geen onderduikers."
        menu: 
            "'Dat maak ik zelf wel uit, aan de kant zei ik!'":
                jump driebadend
            "'In dat geval moet ik je maar op je woord geloven.'":
                jump driegoodend

    label driegoodend:
        "Je hebt de Jood met rust gelaten. Jan, de bewoner, bedankt jou en wenst je een prettige dag verder."
        jump nsbvier
        
    label driebadend:
        "Je hebt de Jood weten op te pakken. Je toont geen genade, want je doet gewoon je werk."
        jump nsbvier
        

        
        
    label nsbvier:
        stop music 
        scene black
        "Huis 4"
        hide black
        play music "bgmusic.mp3"
        scene annabg
        anna "Ja?"
        menu:
            "'Mevrouw, ga opzij, we komen het huis doorzoeken naar Joden.'":
                jump viergood
            "'Ga aan de kant of ik ga geweld gebruiken!'":
                jump vierbad
                
    label viergood:    
        anna "Jullie kunnen niet zomaar binnen dringen. Hebben jullie dan geen respect voor mensen hun huizen?!"
        jump vierend
        
    label vierbad:
        anna "Jullie kunnen niet zomaar binnen dringen. Hebben jullie dan geen respect voor mensen hun huizen?!"
        jump vierend
        
    label vierend:
        "Je vind een jongen genaamd Joseph. Hij zat verstopt in een hoekje op zolder, hij lijkt verhongerd."
        
        menu:
            "'Neem de jongen mee.'":
                jump vierbadend
            "'Verlaat het huis zonder de jongen.'":
                jump viergoodend

    label vierbadend:
        "Je volgt je orders en kiest ervoor om de Jood op te pakken, ondanks zijn huidige conditie. De andere NSB'ers zullen trots op je zijn."
        jump nsbvijf
        
    label viergoodend:
        "De hongerige jongen heeft je gevoelens geraakt, we zijn allemaal maar mensen. Je hebt ervoor gekozen om de jongen op te pakken."
        jump nsbvijf    
        
        

        
    label nsbvijf:
        stop music 
        scene black
        "Huis 5"
        hide black
        play music "bgmusic.mp3"
        scene samuelbg
        samuel "Hallo?"
        menu:
            "'We hebben een bevel voor de bewoners van dit huis.'":
                jump vijfgood
            "'We komen de joden ophalen.'":
                jump vijfgood
                
    label vijfgood:
        samuel "We hebben niks gedaan. Waarom kunnen jullie ons niet met rust laten?.."
        samuel "Laat ons alstublieft met rust. We zullen vandaag onze spullen pakken en weggaan."
        menu: 
            "'Neem de Joden mee.'":
                jump vijfgoodend
            "'Laat de Joden met rust.'":
                jump vijfbadend

    label vijfgoodend:
        samuel "Ik kan jullie niet genoeg bedanken! Kom Isaac, we gaan!"
        "Je hebt ervoor gekozen om de Joden niet mee te nemen."
        jump nsbzes
        
    label vijfbadend:
        samuel "Nee, astublieft!"
        "De vader, Samuel, en zijn zoon Isaac worden meegenomen.. Je hoort Samuel wat tegen zijn zoon zeggen"
        samuel "Isaac, maak je geen zorgen.. het komt allemaal goed."
        "Je hebt ervoor gekozen om de Joden mee te nemen."
        jump nsbzes
        
        
        
        
    label nsbzes:
        stop music
        scene black
        "Huis 6"
        hide black
        play music "bgmusic.mp3"
        scene willembg
        willem "Ah, de NAZI-Slaven, wat moeten jullie?"
        menu:
            "'Let op je woorden! Anders nemen we jou ook mee, samen met de onderduikers die jullie verbergen.'":
                jump zesgood
            "'Rustig aan nou jongeman.'":
                jump zesgood
                
    label zesgood:
        samuel "Ja dat kunnen jullie alleen he. Mensen lopen bedreigen"
        
        menu:
            "'Gebruik geweld om de Jood te zoeken.'":
                jump zesbadend
            "'Gebruik geen geweld om de Jood te zoeken.'":
                jump zesgoodend
                
    label zesbadend:
        "Je duwt Willem opzij en gaat grondig op zoek naar de Jood genaamd Eva. Willem probeert je tegen te houden maar je geeft hem een knal tegen zijn neus. Hij valt recht op de vloer."
        jump nsbzeven
        
    label zesgoodend:
        "Je vraagt Willem opzij te gaan en gaat grondig op zoek naar de Jood genaamd Eva. Eva wordt huilend meegenomen.."
        jump nsbzeven
        


        
    label nsbzeven:
        stop music
        scene black
        "Huis 7"
        hide black
        play music "bgmusic.mp3"
        scene simonbg
        simon "Hallo?"
        
        menu:
            "'Ga aan de kant! Ik heb orders iemand te vervoeren.'":
                jump zevengood
            "'Laat me nu naar binnen! Pak alls wat je kan en maak dat je weg komt, vlug!'":
                jump zevenbad
                
    label zevengood:
        simon "Astublieft, nee! Er is hier niemand, geloof me!"
        menu:
            "'Doorzoek het huis en vervoer de Joden.'":
                jump zevengoodend
            "'Geloof Simon op zijn woord en laat hen met rust.'":
                jump zevenbadend
            
    label zevenbad:
        simon "Waarom help je ons?"
        menu:
            "'Helpen? Jullie helpen? Waar heb je het over? Ik neem jullie mee.'":
                jump zevengoodend
            "'Omdat dat het juiste is om te doen.'":
                jump zevenbadend
                
    label zevengoodend:
        "Je hebt ervoor gekozen de Joden te vervoeren, zoals je is opgedragen."
        jump nsbacht
        
    label zevenbadend:
        "Simon ontsnapt uit de klauwen van de Nazi’s met zijn gezin.. dankzij jou"
        "Je hebt ervoor gekozen om de Joden niet mee te nemen."
        jump nsbacht
        

        
        
    label nsbacht:
        stop music
        scene black
        "Huis 8"
        hide black
        play music "bgmusic.mp3"
        scene wilhelminabg
        wilhelmina "Oh, Goedendag.."
        jij "Goedendag? Geef je over!"
        wilhelmina "Me overgeven? Maar ik heb helemaal niks gedaan!"
        jij "We weten dat je Joden helpt met onderduiken."
        menu:
            "Gebruik geweld om de Joden te vinden.":
                jump achtbadend
            "Gebruik geen geweld om de Joden te vinden.":
                jump achtgoodend

    label achtbadend:
        "Jullie duwen de bewoner opzij en gaan stampen door het hele huis zoeken. Alles word omver gegooid en kapot gemaakt. Eindelijk wordt een kleine meisje genaamd Clara gevonden. Ze huilt maar wordt hard aan haar arm getrokken naar jullie voertuig."
        return
        
    label achtgoodend:
        "Jullie verzoeken de bewoner opzij te gaan en doorzoeken het hele huis. Eindelijk wordt een kleine meisje genaamd Clara gevonden. Ze huilt en word weggevoerd."
        return
                
        
        
        
    
       
        
        

    
    
    

        
