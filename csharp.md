# Asztali alkalmazások fejlesztése

**Javasolt könyv:[https://reiteristvan.files.wordpress.com/2018/01/reiter-istvc3a1n-c-programozc3a1s-lc3a9pc3a9src591l-lc3a9pc3a9sre.pdf] (Reiter féle C# könyv)**

  
## Fejlesztő környezetek
 - SharpDevelop (ingyenes, szolidan fapados)
 - Visual Studio Code (ingyenes, fordítás, futtatás kicsit nehézkes)
 - Microsoft Visual Studio 2015,2017,2019 (a legjobban használható, a Community Edition ingyenes, csak egy Microsoft fiók kell hozzá)
 
 ## Mit lehet írni vele?
  - konzol alkalmazás
  - grafikus alkalmazás
  - webalkalmazás
  - mobil alkalmazás (Android)
  
 # Változó típuok
 
 ## Érték típusok
 
  ## Egész számok tárolása
   - int előjeles 32 bit
   - short előjeles 16 bit
   - long előjeles 64 bit
   -uint előjel nélküli 32 bit
   -ushort előjel nélküli 16 bit
   -ulong előjel nélküli 64 bit
  
## Deklarálás
```C#
int szam;
int masikSzam = 12;
uint eSzam = 34;
short rovid = 3345;
long hosszu = 2423445;
Int32 szam32 = 23455;
```

## Min, max értékek kiíratása

```c#
Console.WriteLine($"Előjeles 16bit:min:{Int16.MinValue},max:{Int16.MaxValue}");
Console.WriteLine($"Előjel nélküli 16bit:min:{UInt16.MinValue},max:{UInt16.MaxValue}");

Console.WriteLine($"Előjeles 32bit:min:{Int32.MinValue},max:{Int32.MaxValue}");
Console.WriteLine($"Előjel nélküli 32bit:min:{UInt32.MinValue},max:{UInt32.MaxValue}");
```

## Tört számok (lebegőpontos) számok tárolása


**egyszeres pontosságú, 32 bites**
```C#
float nemEgesz32 = 105.1287697369263926392936936f;
```

**kétszeres pontosságú, 64 bites**

```C#
double nemEgesz64 = 105.1287697369263926392936936;
```

**decimális, 128 bites**
```C#
decimal nemEgesz128 = 105.1287697369263926392936936m;
```
**Pénzügyi alkalmazások esetén (kerekítési problémák miatt) a decimal típust kell használni. Egyéb esetekre elég a float ill. a double.**

**Logikai típus (igaz/hamis)**
```C#            
 bool logikai;
 logikai = true;
 logikai = false;
 ```

 **Szöveg típus**
```C# 
String szoveg = "Csodálatos hétfő reggel..";
```

**Egy string karaktereire egyenkét is lehet hivatkozni**
pl. első karakterének kiíratása
C#-ban az elemek számozása 0-val kezdődik!!!
```C#
Console.WriteLine(szoveg[0]);
Console.WriteLine(szoveg[1]);
```

**Műveletek stringekkel**

**Szöveg hossza:**
```C#
Console.WriteLine(szoveg.Length);
```

**Van a szoveg string-ben hétfő?**
```C#
Console.WriteLine(szoveg.Contains("hétfő"));
```

**ugyanaz, csak változóval**
```C#
string keresett = "Hétfő";
Console.WriteLine(szoveg.Contains(keresett));
Console.WriteLine(szoveg.StartsWith(keresett));
```

**Karakter cseréje a szövegben**
```C#
Console.WriteLine(szoveg.Replace('o','ö'));
```

**Szóközök eltüntetése**

```C#
Console.WriteLine(szoveg.Replace(" ",""));
```
**Szövegrész kiemelése adott karakter pozíciótól**
```c#
Console.WriteLine(szoveg.Substring(3));
```

**adott karakter pozíciótól, a megadott darab karakter kiemelése**
```c#
Console.WriteLine(szoveg.Substring(3,5));
```
```c#
string hetfo = szoveg.Substring(11,5);
Console.WriteLine(hetfo);
```
**Dátum feldolgozás substring-el**
```c#
var datum = "2019.10.14";

//Az év kiemelése a datum változóból
var ev = datum.Substring(0,4);

//A hónap kiemelése a datum változóból
var honap = datum.Substring(6, 2);

//a nap kiemelése
var nap = datum.Substring(9,2);
            
```
**dátum feldarabolása a Split-el**
```c#
//string felvágása

var fontosDatum = "2019-12-12";

//string darabolása adott karakter mentén
var datumElemek = fontosDatum.Split('-');

//a darabolás után egy tömböt kapunk, melynek
//elemei tartalmazzák az egyes szövegeket
// [0]    [1]  [2]
//[2019],[12],[12]
Console.WriteLine(datumElemek[0]);
Console.WriteLine(datumElemek[1]);
Console.WriteLine(datumElemek[2]);
```
**A tömb elemeinek kiírása ciklusban sokkal egyszerűbb**
```C#
  for (int i = 0; i < datumElemek.Length; i++)
{
 Console.WriteLine(datumElemek[i]);
}
```

**Feladat:Feladat:minden karaktert alakítsunk az ellenkező írásmódúra**
 ```c#
 string alakitando = "eZt KelLeNe áTalAKíTaNi";
 ```
 
**String változtatásához a stringet karakter tömbbé kell alakítani**
```C#
var chAtalakitando = alakitando.ToCharArray();
```
**Egy ciklus karakterenént végigmegy a tömbön, és a karaktert az ellenkező írásmódúra változtatja**
```C#
for (int i = 0; i < chAtalakitando.Length; i++)
            {
                if (Char.IsLower(chAtalakitando[i]))
                {
                    //Ha kisbetűs, nagybetűsre alakítjuk
                    chAtalakitando[i] = Char.ToUpper(chAtalakitando[i]);
                }
                else 
                {
                    //Ha nagybetűs, akkor pedig kisbetűsre
                    chAtalakitando[i] = Char.ToLower(chAtalakitando[i]);
                }
            }
```

**Végül a karaktertömböt visszaalakítjuk string-é**
```c#
alakitando = new string(chAtalakitando);
Console.WriteLine(alakitando);
```

**kisbetűsre alakítás**
```c#
Console.WriteLine(szoveg.ToLower());
```
**nagybetűsre alakítás**
```c#
Console.WriteLine(szoveg.ToUpper());
```

**Karakter típus**
```C#            
Char karakter = 'h';
```
**Átalakítás a változó típusok között**

String típusú változóban tárolt számok átalakítása integer-re.

```C#
string a = "15";
string b = "26";

int c = 0;

//string értékek átalakítása int típusra
c = Convert.ToInt32(a) + Convert.ToInt32(b);
```            
**Stringek összefűzése**
```C#
//ebben az esetben a két string össze lesz fűzve
   var d = a + b;
```
**Típus kényszerítése**
```C#
int e = 29;
int f = 119;
double g = 345.26;
//ITT g-re rákényszerítjük az int típust
int osszeg = e + f + (int)g;

g = e + f;
            
//típus kényszerítés itt is, más néven kasztolás
f = (int)g + e;
```
**Típus konverzió a típus PARSE() függvényével**

```C#
 g = Double.Parse("18,8") + Double.Parse("76,99");
``` 
# Vezérlési szerkezetek (elágazások, ciklusok)
## Elágazások
**Egyszeres, egyágú**

```c#
int szam = 12;
if (szam>0)
{
 Console.WriteLine("A szám pozitív!");
}
```            
 **Egyszeres,kétágú**
 ```C#
 if (szam>=0)
 {
    Console.WriteLine("A szám pozitív!");
} else
{
    Console.WriteLine("A szám negatív!");
}
```
**Többszörös szelekció**
```c#
if (szam>0)
{
  Console.WriteLine("A szám pozitív!");
}
else if (szam==0)
{
  Console.WriteLine("A szám nulla!");
}
else
{
  Console.WriteLine("A szám nulla!");
}
```
**Többszörös szelekció, switch**
Esetek megkülönböztetésére szolgál, azonban az eseteknél nem lehet összehasonlításokat alkalmazni pl.<,>,==,!=,<=,>=

```C#
int valaszt = 2;

            switch (valaszt)
            {
                case 1:
                    Console.WriteLine("1-es kiválasztva");
                    break;
                case 2:
                    Console.WriteLine("2-es kiválasztva");
                    break;
                case 3:
                    Console.WriteLine("3-as kiválasztva");
                    break;
                default:
                    Console.WriteLine("Nincs kiválasztva semmi");
                    break;
            }
```            
##Ciklusok (ismételt tevékenységek)

**Növekményes (előírt lépésszámú)**
**Pontosan tudjuk, hányszor hajtódik végre**

pl. a ciklusváltozó értékét négyzetre emeljük és kiíratjuk
```C#
for (int i = 0; i < 100; i++)
{
   Console.WriteLine(Math.Pow(i,2));    
}
```            
**Elöltesztelő (while) ciklus**

írjunk ciklust, ami minden lépésben csökkenti a jármű sebességét, amíg az meg nem áll
```c#
int sebesseg = 120;
int sebessegCsokkenes = 10;

while (sebesseg>0)
{
   Console.WriteLine(sebesseg);
   sebesseg = sebesseg - sebessegCsokkenes;
}

Console.WriteLine("Az autó megállt");
```            

**Hátultesztelő ciklus**

Az előző példa hátultesztelő ciklussal.
A hátultesztelő ciklus egyszer mindenféleképpen lefut, hiszen a ciklusmag utasításai a kilépési feltétel kiértékelése előtt vannak.

```C#
sebesseg = 120;
sebessegCsokkenes = 15;

do
{
  Console.WriteLine(sebesseg);
  sebesseg = sebesseg - sebessegCsokkenes;
  
} while (sebesseg>0);

```

## Alapvető (elemi) algoritmusok

 - összegzés
 - megszámlálás
 - minimum/maximum kiválasztás
 - keresés
 - rendezés
 
 Jellemzően valamilyen adatszerkezet adatain vannak ezek a műveletek végrehajtva.
 
 **Összegzés**
 
 Összegezzük az alábbi tömb elemeit!
 ```c#
 int[] szamok = {1,19,216,-18,49,76,-8 };
 ```
kell egy változó az összeg tárolására
```C#
int osszeg = 0;
```
Ciklussal végigmegyünk a tömbön:
```C#
for (int i = 0; i < szamok.Length; i++)
{
   osszeg = osszeg + szamok[i];
}
Console.WriteLine($"Az elemek összege:{osszeg}");
```
**Megszámlálás**
Nagyon hasonlít az összegzéshez, de itt egy változó értékét 1-el növeljük.

kell egy változó az összeg tárolására
```C#
int darabszam = 0;
```
Ciklussal végigmegyünk a tömbön:
```C#
for (int i = 0; i < szamok.Length; i++)
{
   darabszam++
}
Console.WriteLine($"Az elemek darabszáma:{darabszam}");
```
**Minimum/maximum kiválasztás**

A minimumot/maximumot tároló változók kezőértékének célszerű a tömb első elemét választani.
```C#
int min = szamok[0];
int max = szamok[0];

for (int i = 0; i < szamok.Length; i++)
{
 if (szamok[i]<min)
   {
      min = szamok[i];
   }
 if (szamok[i]>max)
   {
      max = szamok[i];
   }
}

Console.WriteLine($"Min:{min},max:{max}");
```
**Tömb elemeinek rendezése**

Adott az alábbi tömb:
```C#
int[] szamok = {8,3,129,76,19,47};
```
Szeretnénk a tömb elemeit értekeik szerint sorba rendezni. A rendezés során két ciklust kell használni.
Össze kell hasonlítani a tömb két szomszédos elemét, és ha szüséges, akkor fel kell őket cserélni.

```C#
for (int i = 0; i < szamok.Length-1; i++)
{
             
    for (int j = i+1; j < szamok.Length; j++)
    {

             //ha kell, akkor csere
             if (szamok[i]>szamok[j])
             {
              //elmentjük ez egyik elemet
              //egy átmeneti változóba
              var temp = szamok[i];
              //a kisebb értéket a nagyobb helyére
              //tesszük
              szamok[i] = szamok[j];
              //a nagyobb érték a kisebb helyére kerül
              szamok[j] = temp;
             }

     }

}
```

# Hibakeresés a programban

## Hibák fordítási időben

Ezek a hibák nem engedik a forráskód lefordítását, a program elindulását, tehát
a programozó rögtön értesül erről. Nagy általánosságban ezek szintaktikai hibák.

**Szintaktikai hiba:** egy utasítást nem úgy ír a programozó, ahogy a nyelv megköveteli.

**Szemantikai hiba:** a program lefordul, működik, de esetenként nem kívánt működést
tapasztalunk. Pl. nem kap megfelelő értéket egy változó, nem fut le egy ciklus, pedig
kéne. 

A futás közben jelentkező problémák felderítése sokkal nehezebb. Ezt a műveletet nevezik hibakeresésnek, más néven**debugolás**-nak.

**Lépésenkénti programvégrehajtás**
Ebben az esetben töréspontot helyezünk el a programban, ezen a ponton a program futása megáll, és ezt követően lépésenként hajtathatjuk végre a program utasításait, figyelhetjük a változók értékét.

**Töréspont beszúrása**

Az F9 gomb lenyomásával lehet a főprogram valamely sorára töréspontot beszúrni. A töréspont elérésekor a program futása megáll, és a forráskódnál követhetjük a program utasításait. F10 gombbal lehet a következő utasításra lépni. Az egyes változók aktuális értéke megtekinthető ha az egérrel a változó nevére mutatunk. Tömbök esetében a tömb elemeinek az értéke is megtekinthető. Egy programba több töréspont is elhelyezhető.

# Listák

A lista egy generikus adatszerkezet. A generikus azt jelenti, hogy bármilyen (egyszerű vagy összetett) típusa lehet. A tömbbel ellentétben a lista elemszámát nem kell megadni, az elemszám mindig annyi, amennyi elem a listán éppen található.

## Lista létrehozása (az elemek típusa int)
```C#
List<int> szamok = new List<int>();
```
## Lista létrehozása (az elemek típusa string)
```C#
List<string> nevek = new List<string>();
```
## Elemek hozzáadása a listához
```C#
szamok.Add(12);
szamok.Add(48);
szamok.Add(1223);

nevek.Add("Ubul");
nevek.Add("Zénó");
nevek.Add("Eulália");
```
## Hozzáférés a lista elemeihez
```C#
Console.WriteLine(szamok[0]);
Console.WriteLine(nevek[1]);
```
## A lista elemeinek listázása
```C#
for (int i = 0; i < szamok.Count; i++)
{
 Console.WriteLine(szamok[i]);
}
```

## A lista elemeinek listázása foreach-el
```C#
foreach (var xc in nevek)
{
 Console.WriteLine(xc);
}
```
#  Összetett adattípusok, struktúra

## Struktúra létrehozása

**A struktúra megadását a főprogramon (main függvény) kívül kell elvégezni
```C#

public struct Dolgozo
{
  public string nev;
  public int szulEv;
  public int magassag;
  public int suly;
  public string anyjaNeve;
}
```
## Struktúra példány létrehozása a programban, értékek megadása
```C#
Dolgozo dolgozo = new Dolgozo();
dolgozo.nev = "Sivár Iván";
dolgozo.anyjaNeve = "Korompai Eufrozina";
dolgozo.magassag = 180;
dolgozo.suly = 86;
dolgozo.szulEv = 1989;
```
## Dolgozok típus elemeit tartalmazó lista létrehozása, dolgozo hozzáadása
```C#
List<Dolgozo> dolgozok = new List<Dolgozo>();
dolgozok.Add(dolgozo);
```
## a dolgozok lista elemeinek adataihoz való hozzáférés
```C#
Console.WriteLine(dolgozok[0].nev);
Console.WriteLine(dolgozok[0].anyjaNeve);
```
## a dolgozok lista kiíratása
```C#
foreach (var d in dolgozok)
{
 Console.WriteLine($"{d.nev},{d.anyjaNeve},{d.magassag},{d.suly},{d.szulEv}");
}
```
# Függvények azaz alprogramok létrehozása

A függvény olyan egysége a programnak, amelyet egyszer létrehozunk,
majd a főprogramból annyiszor hívhatjuk meg, amennyiszer szükséges.

Két formája van, az egyik végrehajtja a függvényben megadott
utasításokat. Ezt a **void** kulcsszó jelzi.
A másik formája a függvényeknek rendelkezik visszatérési értékkel. 
Ebben az esetben nem a **void** kulcsszó szerepel, hanem valamilyen
változó típus (int,string,double...stb)
 
## Példa

Adott 4 tömb a főprogramban_
```c#
int[] t1 = { 1, 23, 445, 78, 7765, 43, 566, 87 };
int[] t2 = { 11, 213, 45, 781, 75, 439, 56, 8766,1123,899 };
int[] t3 = { 97, 135, 459, 78111, 175, 3999, 1156, 8569, 1233, 89900 };
int[] t4 = { 9823, 22135, 11459, 789111, 23, 36, 99844, 102569, 221033, 79900 };
```
Szeretnénk egy olyan függvényt, amely képes egy adott tömb elemeinek a kilistázására. A függvénynek nem kell visszaadnia értéket, tehát
a void kulcsszót kell használni.

```C#
 public static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
        }
```

A függvény híváskor kapja meg a kiírandó tömböt:

```C#
TombLista(t1);
```

Az egész együtt:

```C#
 public static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+" ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] t1 = { 1, 23, 445, 78, 7765, 43, 566, 87 };
            int[] t2 = { 11, 213, 45, 781, 75, 439, 56, 8766,1123,899 };
            int[] t3 = { 97, 135, 459, 78111, 175, 3999, 1156, 8569, 1233, 89900 };
            int[] t4 = { 9823, 22135, 11459, 789111, 23, 36, 99844, 102569, 221033, 79900 };

            TombLista(t1);
            TombLista(t2);
            TombLista(t3);
            TombLista(t4);


            Console.ReadKey();
        }

```

# Fájlok kezelése

A fájlok kezelésére alapvetően két módszer van:
 - szöveges fájlok kezelése
 - fájlok kezelése bináris módban

## FileStream, StreamReader

A fájl betöltéséhez deklarálni kell egy FileStream-et.

```C#
 FileStream fajl = new FileStream(@"tesztadat_20k.txt", FileMode.Open);
```
Ezután létre kell hozni egy StreamReader-t, ez fog olvasni a fájlból, soronként.
A korábban megadott FileStream-et (fajl) kell megadni neki, valamint a szöveg kódolását (Encoding.Default)
```C#
StreamReader reader = new StreamReader(fajl, Encoding.Default);
```
Ezt követően egy while ciklussal olvasható a fájl, soronként. A ciklus addig fut, amíg az utolsó sor is be nem lesz olvasva.
```c#
 while (!reader.EndOfStream)
    {
        var sor = reader.ReadLine();
        Console.WriteLine(sor);
    }
```
A beolvasás után be kell zárni a fájlt
```C#
 reader.Close();
```
## Kivételek, kezelésük a programban

A programok működése során sokféle probléma adódhat, ebben az esetben a rendszer ún. exception-öket (kivételeket)  hoz létre. A kivételek kezelésével kell a programozónak úrrá lennie a problémán.

A kivételek elkapásához és kezeléséhez egy külön blokkot kell használni, melynek neve: **try...catch**

```C#
try {

//Ide kerülnek a végrehajtani kívánt, és adott esetben
//kivételt létrehozó műveletek

}
catch()
{
//Itt adjuk meg, hogy mi történjen, ha kivétel 
//keletkezett
}
```

Az előbbi példa try..catch blokkban
```C#
 try
            {
                FileStream fajl = new FileStream(@"tesztadat_20k.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fajl, Encoding.Default);

                while (!reader.EndOfStream)
                {
                    var sor = reader.ReadLine();
                    Console.WriteLine(sor);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
```
## Szöveges fájl beolvasása a ReadAllLines paranccsal

A **ReadAllLines** beolvassa a szöveges fájlt soronként, a sorokat egy string tömbbe teszi.

```C#
try
   {   
     var sorok = File.ReadAllLines(@"c:/eu/EUcsatlakozas.txt", Encoding.Default);

       for (int i = 0; i < sorok.Length; i++)
         {
                    Console.WriteLine(sorok[i]);
         }

   }
catch (Exception ex)
   {
       Console.WriteLine(ex.Message);                
   }
```            
## Beolvasás és feldolgozás

```C#
      struct orszag
        {
            public string orszagnev;
            public string csatlakozas;
        }

        static void Main(string[] args)
        {
            //szükségesek az adatok feldolgozásához
            List<orszag> orszagok = new List<orszag>();
            orszag orszag = new orszag();

            try
            {
                var sorok=File.ReadAllLines(@"c:/eu/EUcsatlakozas.txt", Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    var adatok = sorok[i].Split(';');
                    orszag.orszagnev = adatok[0];
                    orszag.csatlakozas = adatok[1];
                    orszagok.Add(orszag);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Az országok száma a listában:{orszagok.Count}");

            foreach (var i in orszagok)
            {
                Console.WriteLine($"{i.orszagnev},{i.csatlakozas}");
            }


            Console.ReadKey();
        }
```

## Adatok írása fájlba
**Adott a következő lista, amit fájlba szeretnénk írni:**
```C#
List<string> nevek = new List<string> {"Éva","Ubul","Gerzson","Ágnes","Zénó","Eufrozina" };
```
** FileStream-et és StreamWriter-t használunk**
```C#
 try
            {
                FileStream fajl = new FileStream(@"nevek.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl, Encoding.Default);
                foreach (var i in nevek)
                {
                    writer.WriteLine(i);
                }
                writer.Close();// a lezárás itt nagyon fontos
                Console.WriteLine("Kiírás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
```

**A StreamWriter használata USING kódblokkal**
A USING kódblokk automatikusan elvégzi a fájlba való írás után elvégzendő dolgokat (fájl bezárása, erőforrások felszabadítása), használata javasolt.
A kód így néz ki a USING használatával:
```C#
try
            {
                FileStream fajl = new FileStream(@"nevek.txt", FileMode.Create);

                //a using blokk eltakarít maga után, az előzőnél jobb megoldás

                using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                {
                    foreach (var i in nevek)
                    {
                        writer.WriteLine(i);
                    }
                }          
                                
                Console.WriteLine("Kiírás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
```

## Struktúra (több egyszerű változót tartalmazó típus) létrehozása
A struktúrát mindig a főprogramon kívül kell létrehozni. Akár külön fájlban is lehet.

```C#
 struct Orszag
        {
            public string Orszagnev;
            public string Csatlakozas;
        }
```
Ez a struktúra két string változót tartalmaz.

A struktúrából a főprogramban példányt kell létrehozni, a példányt lehet adatokkal feltölteni, stb.

```C#
Orszag ausztria = new Orszag();
ausztria.Orszagnev = "Ausztria";
ausztria.Csatlakozas = "1995.01.01.";
```

## Fájl beolvasás, feldolgozás struktúrába
```C#
 List<Orszag> orszagok = new List<Orszag>();
            Orszag orszag = new Orszag();
            try
            {
                FileStream fajl = new FileStream(@"c:/EU/EUcsatlakozas.txt", FileMode.Open);

                using (StreamReader reader = new StreamReader(fajl,Encoding.UTF7))
                {
                    while (!reader.EndOfStream)
                    {
                        //Egy sor beolvasása a fájlból,felvágás a ; karakter mentén
                        //és az eredmény tömbbe rakása
                        var e = reader.ReadLine().Split(';');
                                                
                        orszag.Orszagnev = e[0];
                        orszag.Csatlakozas = e[1];
                        orszagok.Add(orszag);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
```
## Adatok kiválogatása (L betűvel kezdődő országok) és másik listába helyezése
```C#
var lorszagok = orszagok.FindAll(x => x.Orszagnev.StartsWith("L"));
```
A FindAll megkeresi az **orszagok** listában a feltételnek megfelelő összes sort, és egy új listába helyezi.

## Az eredménylista fájlba írása

A fájlba írás nagyon hasonlít a beolvasáshoz, lényegében be kell járni egy ciklussal a kiírni kívánt kollekciót(listát) és a sorait a fájlba írni.

```C#
//A kiírást is try..catch blokkban végezzük
try
            {
                //Filestream létrehozás            
                FileStream fajl = new FileStream(@"c:/EU/l_orszagok.txt", FileMode.Create);

                //Kiírásra a StreamWriter-t kell használni, using blokkban
                using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                {
                    foreach (var i in lorszagok)
                    {
                        writer.WriteLine($"{i.Orszagnev};{i.Csatlakozas}");
                    }
                }
                
                Console.WriteLine("Kiírás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                
            }
```

# Hiányzások vizsgafeladat megoldása

```C#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hianyzasok
{
    class Program
    {
        struct Hianyzas
        {
            public string nev;
            public string osztaly;
            public int elsonap;
            public int utolsonap;
            public int mulasztottorak;

            //Konstruktor függvény, ezzel dolgozzuk fel a fájlból
            //beolvasott sort
            public Hianyzas(string sor)
            {
                var e = sor.Split(';');
                nev = e[0];
                osztaly = e[1];
                elsonap = Convert.ToInt32(e[2]);
                utolsonap= Convert.ToInt32(e[3]);
                mulasztottorak= Convert.ToInt32(e[4]);
            }


        }

        static void Main(string[] args)
        {
            List<Hianyzas> hianyzasok = new List<Hianyzas>();

            try
            {
                var sorok = File.ReadAllLines(@"c:/hianyzasok/szeptember.csv",Encoding.Default);
                //Az első sor nem kell feldolgozni, ezért a FOR 1-től fut.
                for (int i = 1; i < sorok.Length; i++)
                {
                    //Struktúra példányosítása
                    Hianyzas hianyzas = new Hianyzas(sorok[i]);

                    //A struktúra hozzáadása a listához
                    hianyzasok.Add(hianyzas);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Adatsorok száma:{hianyzasok.Count}");

            //A tanulók összes hiányzása
            var osszhianyzas = hianyzasok.Sum(x=>x.mulasztottorak);

            Console.WriteLine($"Összes hiányzás:{osszhianyzas}");

            //Bekérés konzolról
            Console.Write("A tanuló neve:");
            var tanulonev = Console.ReadLine();
            Console.Write("Adjon meg egy napot 1 és 30 között:");
            var nap = Convert.ToInt32(Console.ReadLine());

            //Az Any meg tudja nézni, hogy egy érték szerepel-e az
            //adatszerkezetben
            if (hianyzasok.Any(x=>x.nev==tanulonev))
            {
                Console.WriteLine("A tanuló hiányzott szeptemberben");
            } else
            {
                Console.WriteLine("A tanuló nem hiányzott szeptemberben");
            }

            //A bekért napon hiányzó tanulók
            var hianyzokegynapon = hianyzasok.FindAll(x=>x.elsonap>=nap && x.utolsonap<=nap);

            //Ha van hiányzó, akkor listázzuk, egyébként üzenet
            if (hianyzokegynapon.Count>0)
            {
                foreach (var i in hianyzokegynapon)
                {
                    Console.WriteLine($"{i.nev},{i.osztaly}");
                }
            } else
            {
                Console.WriteLine("Ezen a napon nem hiányzott senki");
            }

            //Összesítés készítése -> ToLookUp

            var osszesites = hianyzasok.ToLookup(x=>x.osztaly).OrderBy(x=>x.Key);

            //Az összesítés kiíratása

            //Adatmező helyett az összesítés kulcsát kell kiíratni
            foreach (var i in osszesites)
            {
                Console.WriteLine($"{i.Key},{i.Sum(x=>x.mulasztottorak)}");
            }

            //Fájlba írás a StreamWriter-el
            try
            {
                FileStream fajl = new FileStream(@"c:/hianyzasok/osszegzes.txt", FileMode.Create);
                using (StreamWriter wr=new StreamWriter(fajl,Encoding.Default))
                {
                    foreach (var i in osszesites)
                    {
                        wr.WriteLine($"{i.Key},{i.Sum(x => x.mulasztottorak)}");
                    }
                }
                Console.WriteLine("Kiírás kész");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                               
            }



            Console.ReadKey();
        }
    }
}
```
# Objektum-orientált szemlélet, programozás

Az objektum összetartozó adatokat és metódusokat jelent. Az objektum egy önálló egység, amely jó meghatározott határokkal rendelkezik.

Osztály: az osztály az objektum terve, definíciója.
Példány: az osztály alapján létrehozott használható, "futtatható" objektum. 

pl. 

**példányosítás**
```C#
Random veletlenSzam=new Random();
```
**a példány használata, egy metódusának hívása**
```C#
veletlenSzam.Next(-10,10+1)
```
## Egységbe zárás
Az egységbe zárás(encapsulation) azt jelenti, hogy az osztály adatai kívülről nem érhetőek el, vagy módosíthatóak közvetlenül, azokat
csak metódusokon keresztül lehet elérni. A metódusok segítségével lehet az adatok értékeit ellenőrzötten beállítani, módosítani.

## Konstruktor

A konstruktor metódus feladata a példány kezdeti (vagy akár végleges) értékeinek beállítása. Az osztály példányosításakor automatikusan lefut, nem kell külön hívni.

## Öröklődés

Egy meglévő osztály továbbfejleszthetünk, vagy specializálhatunk az öröklődés segítségével. Egy adott osztályból leszármaztathatunk egy újat, és az utód osztály mindent tudni fog, amit az ős osztály, illetve tudni fogja az utód osztály azokat a metódusokat, adatokat, amelyeket hozzáadtunk.

### Metódusok felülírása

Ha szükség van arra, hogy az utód osztályban máshogy viselkedjen az ős osztály metódusa, akkor metódus felülírást alkalmazunk. Ebben az esetben az ős osztályban a **VIRTUAL** kulcsszóval jelezzük, hogy az adott metódus az utód osztályban felülírható.
Az utód osztályban a felülíró metódusnál az **OVERRIDE** kulcsszó fog szerepelni.

### A property (tulajdonság) a C#-ban

A property egy adatot és a hozzá tartozó lekérdező illetve beállító függvényeket jelenti (3 az 1-ben :) ).
Alaphelyzetben a property publikus láthatóságú és lekérdezhető ill. beállítható, de saját lekérdező és beállító függvényt is készíthetünk neki.

## Absztrakt osztályok

Az ilyen osztály attól absztrakt, hogy bizonyos metódusait még nem lehet megvalósítani azért, mert az osztály jelenlegi formája túl általános. Az absztrakt osztályok pusztán öröklési célokat szolgálnak. Rögzíthető bennük, hogy az utódoknak mely metódusokat kell megvalósítaniuk. Tartalmazhatnak nem absztrakt metódusokat is. Az absztrakt osztály nem példányosítható.

```c#
public abstract class Ember
    {
        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public int GetEletkor()
        {
            return 2020 - SzuletesiEv;
        }

        public abstract void Eszik();

        public abstract void Iszik();

        public abstract void Mozog();

    }
```
Az absztrakt osztályból leszármaztatott osztály lesz példányosítható, ebben az osztályban meg kell valósítani a korábban absztraktnak deklarált metódusokat. 

```C#
 public class Sportolo : Ember
    {
        public Sportolo(string sportag,string nev,int magassag,int szulev,int suly)
        {
            Sportag = sportag;
            Nev = nev;
            Magassag = magassag;
            SzuletesiEv = szulev;
            Suly = suly;
        }

        public string Sportag { get; set; }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sokat iszik, alkoholt soha.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló lendületesen mozog");
        }

        public void Sportol()
        {
            Console.WriteLine($"A sportoló sportok:{Sportag}");
        }
    }
```
A Sportolo osztály az Ember-ből lett leszármaztatva, ebben override-al felül lettek írva a korábbi absztrakt metódusok.

Számos osztályt származtathatunk az Ember-ből. A Sportolo osztálynak van Mozog() metódusa, és ha leszármaztatunk az Ember-ből egy Nyugdijas-osztályt, abban is lesz. Nyilvánvaló, hogy a Nyugdijas osztály egészen mást fog csinálni, ha a Mozog() metódust meghívjuk, mint a Sportolo osztály esetében. Ezt nevezik az OOP-ben polimorfizmusnak.
