# Definizione

## 1. *Bisogni* esposti nella traccia:
> - Permettere all'utente di aprire nel programma un file specifico presente nel file system;
> - Inserire una stringa rappresentante il checksum SHA256;
> - Calcolare il checksum SHA256 del file caricato dall'utente;
> - Controllare la chiave pubblica inserita dall'utente per verificare la firma digitale del file;
> - In caso di esito positivo dei controlli indicarlo all'utente, altrimenti segnalare gli errori identificati.

## 2. *Risposte* tecnologiche ai bisogni individuati:
> Per lo sviluppo di questa applicazione utilizzeremo il software "Visual Studio" che ci permetterà, senza bisogna di elementi aggiuntivi, di inserire  delle stringhe mediante l'interfaccia wpf e compararle attraverso dei metodi già presenti nell'ambiente di sviluppo.
> Per l'apertura del file system da cui selezionare un file useremo una classe presente nella libreria "using Microsoft.Win32", denominata "OpenFileDialog".
> Il calcolo del checksum SHA256 di un file lo otterremo con l'inserimento della libreria "using System.Security.Cryptography", che contiene tutti gli elementi necessari alla risoluzione del nostro problema.
> Sempre tramite l'utilizzo di quest'ultima libreria, controlleremo le chiavi pubbliche per verificare la firma digitale del file con il metodo "RSACryptoServiceProvider".


## 3. *Gap* di conoscenza rilevati nei membri del gruppo:
> - Utilizzo dell' "OpenFileDialog" per la selezione di un determinato file;
> - Calcolo del checksum SHA256 di un file ("using System.Security.Cryptography");
> - Controllo della firma digitale con il metodo "RSACryptoServiceProvider".


## 4. *Informazioni* che si useranno per rispondere ai bisogni e colmare i gap di conoscenza:
> Per rispondere ai bisogni trovati e ai gap di conoscenza utilizzeremo le seguenti fonti:
> - https://docs.microsoft.com/it-it/dotnet/api/system.security.cryptography.hashalgorithm.computehash?view=net-6.0;
> - https://docs.microsoft.com/it-it/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0;
> - https://docs.microsoft.com/it-it/dotnet/api/system.security.cryptography.rsacryptoserviceprovider.verifydata?view=net-6.0

