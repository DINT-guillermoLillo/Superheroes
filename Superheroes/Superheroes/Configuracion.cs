using System.ComponentModel;

public class Configuracion
{
    public string AjusteImagen
    {
        get { return this.AjusteImagen; }
        set
        {

            if (this.AjusteImagen != value)
            {
                this.AjusteImagen = value;
                this.NotifyPropertyChanged("AjusteImagen");
            }
        }
    }
    public string Fondo
    {
        get { return this.Fondo; }
        set
        {

            if (this.Fondo != value)
            {
                this.Fondo = value;
                this.NotifyPropertyChanged("Fondo");
            }
        }
    }

    public Configuracion()
    {

    }


    //Implementación de la interfaz INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

