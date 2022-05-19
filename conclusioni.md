# Conclusioni

## 1. *Difficoltà* riscontrate nella realizzazione:
> Durante la realizzazione della nostra applicazione abbiamo riscontrato le seguenti difficoltà:
> - **GPG:** Utilizzare le classi dichiarate nel progetto per il controllo della firma digitale. Di fatto non è stato possibile effettuare questa operazione direttamente all'interno di Visual Studio utilizzando c#, in quanto non è presente alcuna libreria che permetta di ricavare dai database remoti la chiave pubblica necessaria alla verifica della firma digitale.
> - **Output CMD:** Indirizzare l'output fornito dai comandi in cmd direttamente all'interno dell'applicazione. Non è stato possibile ricavare in output l'esito del comando effettuato in cmd, non permettendo in questo modo il controllo della verifica GPG.

## 2. *Soluzioni* alle difficoltà:
> Le soluzioni ai problemi sopra citati sono state le seguenti:
> - **GPG:** Per l'importazione della chiave pubblica e il seguente controllo della firma digitale del file abbiamo creato due processi che utilizzano la cmd per dare in input i comandi che effettuano tutte le operzioni.
> - **Output CMD:** Data l'impossibilità di prendere l'output fornito dai controlli in cmd, abbiamo fatto in modo che la scheda cmd rimanesse aperta, facendo visualizzare all'utente l'esito dei controlli, che verrà successivamente inserito a mano una volta chiusa la scheda mediante dei "radio button".
> ![Interfaccia](Interfaccia.png)

## 3. *Differenze* del programma rispetto al progetto:
> Le differenze presenti nel programma realizzato rispetto alla progettazione precedente (consultabile alla seguente [pagina](/02-progetto/README.md).) consistono in:
> - **Interfaccia:** L'interfaccia realizzata presenta quattro pagine raggiungibili mediante i bottoni "avanti" e "indietro" a differenza dell'unica pagina dichiarata in fase progettuale.
> - **Finger:** A differenza del progetto dove non era prevista, si è reso necessario richiedere in input all'utente la finger del programma da analizzare, al fine di  ricavare in internet la chiave pubblica corretta.

## 4. *Sviluppi* futuri:
> Gli sviluppi futuri immaginati dal nostro gruppo per questa applicazione consistono nell'implementazione del controllo gpg direttamante utilizzando c# (senza il bisogna della cmd), in modo da non dover richiedere all'utente l'esito del controllo visualizzato in linea di comando.

