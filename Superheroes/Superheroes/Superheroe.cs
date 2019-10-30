using System.ComponentModel;

 class Superheroe
{
    private string _Nombre;
    private string _Enemigo;
    private string _Foto;
    private bool _Vengador;

    public string Nombre { 
        get { return this._Nombre; }
        set {

            if (this._Nombre != value)
            {
                this._Nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }
        }
    }

    public string Enemigo
    {
        get { return this._Enemigo; }
        set
        {
            if (this._Enemigo != value)
            {
                this._Enemigo = value;
                this.NotifyPropertyChanged("Enemigo");
            }
        }
    }

    public string Foto
    {
        get { return this._Foto; }
        set
        {
            if (this._Foto != value)
            {
                this._Foto = value;
                this.NotifyPropertyChanged("Foto");
            }
        }
    }

    public bool Vengador
    {
        get { return this._Vengador; }
        set
        {
            if (this._Vengador != value)
            {
                this._Vengador = value;
                this.NotifyPropertyChanged("Vengador");
            }
        }
    }


    //Constructores
    public Superheroe()
    {
    }

    public static Superheroe GetSample()
    {
        Superheroe heroe = new Superheroe();
        heroe.Nombre = "Daredevil";
        heroe.Enemigo = "Kingping";
        heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
        heroe.Vengador = false;

        return heroe;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

