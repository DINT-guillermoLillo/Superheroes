using System.ComponentModel;

 class Superheroe
{   
    public string Nombre { 
        get { return this.Nombre; }
        set {

            if (this.Nombre != value)
            {
                this.Nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }
        }
    }

    public string Enemigo
    {
        get { return this.Enemigo; }
        set
        {
            if (this.Enemigo != value)
            {
                this.Enemigo = value;
                this.NotifyPropertyChanged("Enemigo");
            }
        }
    }

    public string Foto
    {
        get { return this.Foto; }
        set
        {
            if (this.Foto != value)
            {
                this.Foto = value;
                this.NotifyPropertyChanged("Foto");
            }
        }
    }

    public bool Vengador
    {
        get { return this.Vengador; }
        set
        {
            if (this.Vengador != value)
            {
                this.Vengador = value;
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

