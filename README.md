ΠΑΝΕΠΙΣΤΗΜΙΟ ΠΕΙΡΑΙΩΣ Τμήμα Πληροφορικής 

![](https://i.imgur.com/5BQAYuF.png)

Εργασία Μαθήματος **Αντικειμενοστρεφής Ανάπτυξη Εφαρμογών** 



|***Αριθμός εργασίας – Τίτλος  εργασίας*** |***Τελική Εργασία*** |
| :- | - |
|Όνομα φοιτητή  |Σοφία Μαρκοπούλου, Μιχαήλ Στυλιανίδης, Κωνσταντίνος Καλογερόπουλους |
|Αρ. Μητρώου |Π19097, Π19165, Π19057 |
|Ημερομηνία παράδοσης |23/02/2021 |

**Εισαγωγή** 

Οι πρώτες δύο εφαρμογές υλοποιήθηκαν σε windows forms, ενώ η τρίτη σε ASP .NET.   

**Παιχνίδι: Μνήμης** 

**Εικόνα 1: Main menu**

![](https://i.imgur.com/zHKWTBJ.jpg)

**Εικόνα 2: Options** 

![](https://i.imgur.com/mJgwrpR.jpg)

**Εικόνα 3: Login screen** 

![](https://i.imgur.com/7Z82AkW.jpg)

**Εικόνα 4: Game, με όλες τις κάρτες κλειστές** 

![](https://i.imgur.com/yJntgpM.jpg)

**Εικόνα 5: Game, με κάποιες ανοιχτές κάρτες** 

![](https://i.imgur.com/0N7Gtci.jpg)

**Εικόνα 6: Scoreboard, αρχική κατάσταση** 

![](https://i.imgur.com/RIstCnz.jpg)

**Εικόνα 7: Scoreboard μετά απο μετακίνηση των καρτών** 

![](https://i.imgur.com/OAwSOWg.jpg)

Η εφαρμογή ξεκινάει με την FormMain και εμφανίζεται το μενού που οδηγεί σε όλα τα υπόλοιπα τμήματα της εφαρμογής. Το κάθε τμήμα έχει υλοποιηθεί με τη χρήση user control με μοναδική εξαίρεση το μενού της FormMain. Συγκεκριμένα, υπάρχουν τα user controls: 

1) Login: Η περιοχή της σύνδεσης. Σε αυτό το σημείο ο χρήστης δακτυλογραφεί ένα όνομα και προχωράει στο παιχνίδι 
2) Game: H περιοχή του παιχνιδιού. Για την υλοποίηση του μηχανισμού του παιχνιδιού έχει δημιουργηθεί η τάξη Card, η οποία κληρονομεί από το PictureBox. Συνολικά στο game section υπάρχουν 16 αντικείμενα της Card. Για την φόρτωση του παιχνιδιού καλείται η μέθοδος LoadGame.  Αυτή φορτώνει σε μία λίστα όλα τα paths των εικόνων  από  τον  φάκελο  που  έχει  οριστεί  στη  στατική  τάξη  GameSettings.  Στη συνέχεια επιλέγει 8 από αυτές τυχαία και φτιάνει ένα αντίγραφο για καθεμία. Στο τέλος η λίστα με τα 16 πλέον paths ανακατεύεται για άλλη μια φορά και αποθηκεύει ένα path σε κάθε Card και ξεκινάει το παιχνίδι. Όταν ο χρήστης πατάει σε μία κάρτα αυτή ανοίγει και αποθηκεύεται ως ανοιχτή. Μόλις πατήσει την επόμενη συγκρίνει τα paths τους και αν είναι ίδια τότε παραμένουν ανοιχτές και οι 2. Διαφορετικά μετά από μία καθυστέρηση 400 milisecond (υλοποιημένης με Thread) κλείνουν. Μόλις ανοίξουν όλες οι κάρτες αποθηκεύεται ο παίκτης με το όνομα, τις προσπάθειες και το χρόνο που έκανε (τάξη Player) και η εφαρμογή μεταβαίνει στο scoreboard. Κάθε στιγμή πριν το τέλος του παιχνιδιού ο χρήστης έχει τη δυνατότητα να πατήσει esc, ώστε να κάνει παύση και να ανοίξει ένα μενού που περιέχει τις επιλογές: συνέχεια, αλλαγή ονόματος και επιστροφή στο μενού. Εάν επιλέξει μία από τις δύο τελευταίες το παιχνίδι επαναφέρεται στην αρχική κατάσταση και χάνεται η πρόοδος του παίκτη. Για την υλοποίηση του μενού αυτού έχουν δημιουργηθεί 2 φόρμες. Η FormMask και η FormGameMenu. 
3) FormMask:  Αυτή  η  φόρμα  χρησιμοποιείται  για  να  σκοτεινιάσει  την FormMain. Αυτό επιτυγχάνεται ορίζοντας το background color σε μαύρο και το Opacity σε 80%. 
4) FormGameMenu: H φόρμα που περιέχει το μενού 
5) Scoreboard: Σε αυτή την περιοχή φαίνονται οι προσπάθειες των παικτών με αύξουσα σειρά ανάλογα με το χρόνο. Για την απεικόνιση των παικτών έχουν χρησιμοποιηθεί τα user controls PlayerModel και Champion. Σε αυτά φορτώνονται οι πληροφορίες των παικτών και εμφανίζονται στην οθόνη (Στο κέντρο πάνω ο πρωταθλητής και απο κάτω  όλοι  οι  άλλοι  παίκτες).  Εάν  δε  χωράνε  όλοι  οι  παίκτες  μπορούν  να χρησιμοποιηθούν τα βελάκια για τη μετακίνηση των παικτών δεξιά και αριστερά. 
6) Options: Η περιοχή των ρυθμίσεων. Παρέχει τη δυνατότητα στο χρήστη να επιλέξει δικό του φάκελο με φωτογραφίες καθώς και να απενεργοποιήσει τη μουσική και τα ηχητικά εφέ (περισσότερα γι αυτό στη συνέχεια). 

Επιπλέον έχουν υλοποιηθεί οι τάξεις Serializer, Responsive και Sound για τις διάφορες λειτουργίες του προγράμματος. Αναλυτικότερα: 

1) Serializer:  Αυτή  η  τάξη  είναι  υπεύθυνη  για  την  αποθήκευση  και  άντληση  των δεδομένων των παικτών μέσω της τεχνικής του serialization. 
2) Responsive: Αυτή η τάξη έχει υλοποιηθεί για να διατηρείται το σωστό μέγεθος και η σωστή θέση όλων των controls ανεξάρτητα από τις αλλαγές στο μέγεθος της φόρμας. Όσες  φόρμες  και  UserControl  τη  χρησιμοποιούν  κάνουν  implement  το  ειδικό interface  IResponsive  που  έχει  δημιουργηθεί  γι  αυτό  το  σκοπό.  Συγκεκριμένα, λειτουργεί ως εξής: Στον constructor της responsive δίνεται σαν όρισμα μία φόρμα ή ένα user control ή ένα πάνελ και αποθηκεύεται το αρχικό μέγεθος αυτών καθώς και όλα τα controls που περιέχουν. Για την αναδιαστασιολόγηση των controls είναι απαραίτητο να ειναι γνωστή η σχέση του μεγέθος του container και του μεγέθους και τοποθεσίας των controls. Γι αυτό έχει δημιουργηθεί η τάξη Ratio που αποθηκεύει αυτή τη σχέση για κάθε control. Τέλος, υπάρχει η μέθοδος ResizeUI η οποία παίρνει σαν όρισμα το νέο μέγεθος του container και αλλάζει το μέγεθος και την τοποθεσία των  controls  πολλαπλασιάζοντας  το  νέο  μέγεθος  του  container  με  το  ratio  του μεγέθους και της τοποθεσίας του κάθε control. 
3) Sound: Αυτή η τάξη είναι υπεύθυνη για τη μουσική και τα ηχητικά εφέ. Για την αναπαραγωγή των αρχείων ήχου έχει χρησιμοποιηθεί η βιβλιοθήκη του windows media player.

<br/>
  
**Παιχνίδι: Σκάκι** 

![](https://i.imgur.com/pPdsLD7.jpg)

**Εικόνα 8: Μήνυμα λάθους** 

![](https://i.imgur.com/p4VD95t.png)

**Εικόνα 9: Απεικόνιση βάσης δεδομένων**

![](https://i.imgur.com/87hIRbN.jpg)

**Εικόνα 10: Σκακιέρα** 

![](https://i.imgur.com/4TkfE1U.jpg)

**Εικόνα 11: Τέλος παιχνιδιού**

![](https://i.imgur.com/324kaSG.jpg)

Το στήσιμο της εφαρμογής σκακιού βασίζεται στην εναλλαγή των panel. Με την έναρξη του παιχνιδιού βρισκόμαστε μπροστά στο πρώτο – menu panel, στο οποίο οι παίκτες ζητούνται να  δώσουν μερικές πληροφορίες στο πρόγραμμα: 

1. Τα *ονόματά* τους στα δύο textbox.  
1. Να σημειώσουν πόσο *χρόνο* θα έχει ο κάθε παίκτης για τις κινήσεις του κατά την διάρκεια του παιχνιδιού. 
1. Να επιλέξουν την *σκακιέρα* της αρεσκείας μέσα από τα τέσσερα προτεινόμενα σχέδια στα radiobuttons. 

Εάν κάποιο από τα πιο πάνω δεν είναι σημειωμένο σωστά θα εμφανιστεί μήνυμα λάθους και το παιχνίδι δεν θα ξεκινήσει μέχρι να διορθωθούν. 

Επιπλέον μέσα από το κουμπί «Player List» περνάνε στο panel “playerlistPanel” όπου μέσα από ένα DataGridView και με την κλάση DataReader εμφανίζονται τα δεδομένα της βάσης, δηλαδή τα ονόματα των προηγούμενων παικτών και τα χρονικά στοιχεία για το παιχνίδι τους.  

![](https://i.imgur.com/v7OVBg8.png)

Στην συνέχεια μέσα από το κουμπί “start” μεταφερόμαστε στην σκακιέρα. Εφόσον το παιχνίδι αρχίσει τα δεδομένα των παικτών καταχωρούνται στην βάση με την βοήθεια της κλάσης DataEntry και της συνάρτησης InsertData. 

![](https://i.imgur.com/EcEDZNY.jpg)

Με την έναρξη του παιχνιδιού τα χρονόμετρα των δύο παιχτών ρυθμίζονται στον ορισμένο χρόνο και διορθώνονται τυχών λάθη στον ορισμό τους(π.χ. αν έχουν δοθεί 100 δευτ. γίνονται 1λ. και 30 δευτ.). Μετά από κάθε κίνηση ο κάθε παίκτης χρειάζεται να πατούν το κουμπί “stop” ώστε να σταματήσει ο χρόνος τους και να ξεκινήσει η αντίστροφη μέτρηση για τον αντίπαλο. 

Τα πιόνια κινούνται χάρη στα ομαδικά events “MouseDown” “MouseUp” “MouseMove”. 

![](https://i.imgur.com/aoR5Tg6.jpg)

Κάθε παίκτης έχει την επιλογή “Give Up” σε περίπτωση που θέλει να τερματίσει το παιχνίδι, σε αυτή την περίπτωση οι χρόνοι σταματούν και εμφανίζεται το “Game over”. Το ίδιο συμβαίνει και εάν τελειώσει ένας από τους δύο αντίστροφους μετρητές. 

Εάν οι παίκτες θέλουν να ξεκινήσουν ένα ακόμα παιχνίδι μπορούν να πατήσουν το “Return” και να ανακατευθυνθούν στο menupanel και κρατήσουν τις προηγούμενες ρυθμίσεις είτε να κάνουν όποιες αλλαγές θελήσουν. Πατώντας το  “Start” το παιχνίδι αρχίζει ξανά και τα πιόνια έχουν επανατοποθετηθεί στις αρχικές τους θέσης χάρη στην κλάση Piece.  

![](https://i.imgur.com/foTFjEa.png)

![](https://i.imgur.com/0S4Yup1.png)

<br/>

3. **Διαχείριση Covid-19** 

**Εικόνα 12 Εισαγωγή καταγραφής νέου κρούσματος** 

![](https://i.imgur.com/iINxOgi.jpg)

**Εικόνα 13 Προβολή, επεξεργασία και αναζήτηση στην βάση δεδομένων** 

![](https://i.imgur.com/oVfbng4.jpg)

**Εικόνα 14 Στατιστικά που προκύπτουν από τις καταγραφές της βάσης δεδομένων.** 
![](https://i.imgur.com/Hwz7YVO.jpg)

Η εφαρμογή έχει υλοποιηθεί στο περιβάλλον του ASP .NET και ο σκοπός της είναι η βέλτιστη διαχείριση μιας βάσης δεδομένων μέσω των λειτουργιών της εισαγωγής, επεξεργασίας, αναζήτησης και διαγραφής μίας καταγραφής σε αυτήν (CRUD Operations). Το πρόγραμμα κάνει  χρήση  του  κοντρόλ  GridView(μια  μορφή  πίνακα  για  προβολή  και  διαχείριση δεδομένων) του ASP .NET και στα events αυτού καλούνται οι συναρτήσεις από την κλάση **DataHandler**.  Επιπλέον,  η  κλάση  **CovidCase**  είναι  υπεύθυνη  για  την  καταγραφή  των δεδομένων ενός νέου κρούσματος. Τέλος η εφαρμογή περιέχει και κάποια στατιστικά στο τέλος της σελίδας. 

```
public class CovidCase 
{ 
  public string FirstName { get; set; }         
  public string LastName { get; set; } 
  public string PhoneNumber { get; set; } 
  public string Gender { get; set; } 
  public string Age { get; set; } 
  public string Address { get; set; } 
  public string Deseases { get; set; } 
  public string Date { get; set; } 
  
  public CovidCase(string firstName, string lastName, string PhoneNumber, string gender, string age, string address, string deseases, string data)
}
```

Ο κατασκευαστής (constructor) της κλάσης περιέχει σαν παραμέτρους όλα τα στοιχεία μιας καταγραφής(record) για την βάση δεδομένων. Στην δημιουργία  αντικειμένου,  δίνονται  οι  πληροφορίες  στον κατασκευαστή(constructor) ο οποίος με την σειρά του τα αποθηκεύει στις μεταβλητές(property) της κλάσης για μελλοντική χρήση από άλλες μεθόδους. 

public class DataHandler { 

- public SqlConnection ConnectToDatabase() 

Μέθοδος η οποία είναι υπεύθυνη για την σύνδεση με την βάση δεδομένων. Σε αυτήν τοποθετείται η συμβολοσειρά σύνδεσης(connection string). Η μέθοδος  αυτή  καλείται  από  τις  υπόλοιπες  μέθοδούς  της  κλάσης DataHandler για να επιτευχθεί η σύνδεση με την βάση δεδομένων.  

- public DataTable ExecuteSqlCommand(string command, SqlConnection mysqlconnection) 

Μέθοδος η οποία είναι υπεύθυνη για την εκτέλεση SQL εντολών της μορφής SELECT. Με την σειρά της καλείται από άλλες μεθόδους της ιδιά κλάσης οπού χρειάζονται οι εντολές αυτής της μορφής. 

- public void InsertData(CovidCase newCovidCase) 

Μέθοδος η οποία είναι υπεύθυνη για την εισαγωγή δεδομένων στην βάση. Παίρνει ως όρισμα ένα αντικείμενο της κλάσης CovidCase το οποίο περιέχει τις πληροφορίες για κάθε στοιχείο που εισάγει ο χρήστης. Μέσω του αντικειμένου αυτού, αποκτά πρόσβαση στις μεταβλητές που περιέχουν τις πληροφορίες που θα εισαχθούν στην βάση. 

- public void BindData(GridView aGridView) 

Μέθοδος η οποία είναι υπεύθυνη για την ανανέωση του GridView. Επιλέγει όλα τα δεδομένα από την βάση δεδομένων και τα στέλνει ξανά πίσω στο GridView. Η συγκεκριμένη μέθοδος καλείται κάθε φορά στο τέλος κάθε μεθόδου που επιτελεί κάποια λειτουργία(Insert,Search,Edit,Delete) για να έχουμε την εμφάνιση του αποτελέσματος της. 

- public void SearchData(GridView aGridView, TextBox searchkey) Μέθοδος η οποία είναι υπεύθυνη για την αναζήτηση μέσα στην βάση δεδομένων  με  βάση  ένα  searchkey  το  οποίο  δόθηκε.  Η  αναζήτηση πραγματοποιείται με βάση το επώνυμο(LastName). 
- public void RowUpdateData(GridView aGridView, GridViewUpdateEventArgs e) Μέθοδος η οποία είναι υπεύθυνη για την επεξεργασία των δεδομένων κάθε γραμμής του GridView. Μετατρέπει τα fields σε TextBox στα οποία ο χρήστης μπορεί να συμπληρώσει τις αλλαγές που θέλει στην επιλεγμένη καταγραφή της βάσης δεδομένων. 
- public void RowDeleteData(GridView aGridView, GridViewDeleteEventArgs e) 

Μέθοδος η οποία είναι υπεύθυνη για την διαγραφή καταγραφών από την βάση δεδομένων. Η διαγραφή πραγματοποιείται μέσω του ID κάθε καταγραφής και γίνεται συνολική διαγραφή της επιλεγμένης γραμμής. } 
