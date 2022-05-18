# Conclusioni

## 1. *Difficoltà* riscontrate nella realizzazione:
> Durante la realizzazione della nostra applicazione abbiamo riscontrato le seguenti difficoltà:
> - **GPG:** Utilizzare le classi dichiarate nel progetto per il controllo della firma digitale. Di fatto non è stato possibile effettuare questa operazione direttamente all'interno di Visual Studio utilizzando c#, in quanto non è presente alcuna libreria che permetta di ricavare dai database remoti la chiave pubblica necessaria alla verifica della firma digitale.
> - **Output CMD:** Indirizzare l'output fornito dai comandi in cmd direttamente all'interno dell'applicazione. Non è stato possibile ricavare in output l'esito del comando effettuato in cmd, non permettendo in questo modo il controllo della verifica GPG.

## 2. *Soluzioni* alle difficoltà:
> Il lavoro che andremo a svolgere verrà suddiviso principalmente in 3 fasi:
> - **Fase 1** (Interfaccia wpf): Eseguita da Rughetta Mattia, usufruendo di 2 ore in laboratorio;
> In questa fase verrà realizzata la pagina che interfaccerà l'utente all'applicazione. Essa conterrà un "OpenFileDialog" per la selezione del file; Tre "TextBox" per l'inserimento dei dati rischiesti; Una "ProgressBar" per verificare l'avanzamento; Un "Button" per l'esecuzione e un "Label" per la stampa del risultato.
> L'interfaccia avrà il seguente aspetto:
> 
> ![Interfaccia](Interfaccia.png)
>  
> - **Fase 2** (Calcolo del cheksum SHA256): Eseguito da Cancemi Gabriele con l'aiuto del gruppo, servendosi di 4 ore in laboratorio;
> Scriveremo il codice che calcolerà il checksum SHA256 del file che l'utente inserirà in input.  
> 
> - **Fase 3** (Controllo della firma digitale): Eseguito da Soudqi Nizar, aiutato dal resto del gruppo, beneficiando di 4 ore in laboratorio;
> Decifreremo il checksum criptato che l'utente inserirà in input con la chiave pubblica fornita e andremo a confrontare i due codici in modo da ricavare l'eventuale autenticità del file firmato.
> 
> - **Fase 4** (Check-up finale del prodotto): Eseguito da tutti i membri del gruppo, in 1 ora di laboratorio.
> Controlleremo il totale funzionamento dell'applicazione, correggendo eventuali errori. 
> 
> Ipoteticamente il lavoro dovrebbe essere completato entro il 06/04/2022.

## 3. *Differenze* del programma rispetto al progetto:
>

## 3. *Sviluppi* futuri:
> Per la documentazione del processo di realizzazione utilezzeremo il software "GitHub" e la relativa applicazione "GitHub Desktop", all'interno dei quali andremo a descrivere ogni modifica effettuata al progetto utilizzando i "Commit".
> Per ogni commit inseriremo un titolo e una sintesi del lavoro svolto, in modo da tener traccia di ogni progresso.

