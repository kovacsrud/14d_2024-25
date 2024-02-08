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
