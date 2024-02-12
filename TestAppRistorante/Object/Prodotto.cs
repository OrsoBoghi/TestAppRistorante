public class Prodotto
{
    public int IDProdotto { 
        get {
            return _IDProdotto; 
        }
        set 
        { 
            _IDProdotto = value;
        } 
    }
    public int IDCategoria {
        get { 
            return _IDCategoria;
        } 
        set {
            _IDCategoria = value; 
        }
    }
    public decimal Prezzo
    {
        get
        {
            return _Prezzo;
        }
        set
        {
            _Prezzo = value;
        }
    }
    public decimal? Sconto
    {
        get
        {
            return _Sconto;
        }
        set
        {
            _Sconto = value;
        }
    }
    public string Descrizione
    {
        get
        {
            return _Descrizione;
        }
        set
        {
            _Descrizione = value;
        }
    }
    public string Immagine
    {
        get
        {
            return _Immagine;
        }
        set
        {
            _Immagine = value;
        }
    }

    private int _IDProdotto;
    private int _IDCategoria;
    private decimal _Prezzo;
    private decimal? _Sconto;
    private string _Descrizione;
    private string _Immagine;

}